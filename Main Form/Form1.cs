using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingTutorClsDifficultyLevel;
using System.Configuration;

namespace TypingTutor
{
    public partial class FormTypingTutor : Form
    {
        public FormTypingTutor()
        {
            InitializeComponent();
        }

        private List<string> _dataLines = new List<string>();
        private int _currentLineIndex = 0;
        private int _currentCharIndex = 0;

        private int _mistakeCount = 0;

        private bool _isReadyToDeleteMistakes = false;

        private short _timerCount = 0;
        private short _maxTimeLimit = 0;

        private bool _isWaitingForEnter = false;

        private static readonly object _lockObject = new object();


        private void FormTypingTutor_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.IsDataFileExist())
            {
                MessageBox.Show("Program data is missing. Please ensure all required data is available and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            LoadDataFromFile();
            DisplayCurrentLine();

            SentenceManagement.PracticeCallBack = PracticeInfoCallBack;
        }

        private void LoadDataFromFile()
        {
            try
            {
                _dataLines.Clear();
                _dataLines.AddRange(File.ReadAllLines(clsGlobal.GetFilePath()));
            }
            catch (FileNotFoundException ex)
            {
                clsGlobal.LogAndShowError(ex, "The program data file is missing. Please ensure the file 'myTypingTutorFile.txt' is available and try again.");
                this.Close();
            }
            catch (Exception ex)
            {
                clsGlobal.LogAndShowError(ex, "An error occurred while loading the data.");
                this.Close();
            }
        }

        private void DisplayCurrentLine()
        {        
            textBoxShow.Text = _dataLines[_currentLineIndex];
            textBoxWrite.MaxLength = _dataLines[_currentLineIndex].Length;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStart.BackColor = Color.Empty;

            textBoxWrite.ReadOnly = false;
            textBoxWrite.Focus();

            SetTimerAndFormatLabel();
            timer.Enabled = true;

            _isWaitingForEnter = false;
        }

        private void SetTimerAndFormatLabel()
        {
            if (ClsDifficultyLevel.SelectedLevel == "Easy")
            {
                SetTimer(40);
            }
            else if (ClsDifficultyLevel.SelectedLevel == "Middle")
            {
                SetTimer(20);
            }
            else
            {
                SetTimer(10);
            }
        }

        private void SetTimer(short maxTime)
        {
            _maxTimeLimit = maxTime;
            labelMaxTime.Text = $":{maxTime}";
        }

        private void textBoxWrite_Click(object sender, EventArgs e)
        {
            //move cursor to the end of written text
            textBoxWrite.SelectionStart = textBoxWrite.TextLength;
        }

        private void textBoxWrite_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isWaitingForEnter)
            {
                HandleEnterKey(e);
                return;
            }

            if (_isReadyToDeleteMistakes)
            {
                HandleBackspaceKey(e);
                return;
            }

            if (clsGlobal.IsInvalidKey(e))
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                MoveToNextText();
                return;
            }

            if (e.KeyCode == Keys.ShiftKey)
            {
                Task.Run(() => HighlightKey(e.KeyCode.ToString(), Color.Cyan));
            }
        }

        private void HandleEnterKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MoveToNextText();
            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        private void HandleBackspaceKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if(_currentCharIndex > 0)
                {
                    _currentCharIndex--;
                }
                _isReadyToDeleteMistakes = false;
            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }     

        private void MoveToNextText()
        {
            _currentLineIndex++;

            if (_currentLineIndex < _dataLines.Count)
            {
                ResetForm();
            }
            else
            {
                if (MessageBox.Show("Do you want to go back to the beginning sentences ",
                    "Warning there are no more sentences to show",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _currentLineIndex = 0;
                    ResetForm();
                }
                else
                {
                    _currentLineIndex--;
                    ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            DisplayCurrentLine();

            textBoxWrite.ReadOnly = true;
            textBoxWrite.Clear();

            buttonStart.Enabled = true;
            buttonStart.BackColor = Color.SeaShell;
            buttonStart.Focus();

            richTxtResult.Clear();
            timer.Enabled = false;

            _isReadyToDeleteMistakes = false;
            _currentCharIndex = 0;
            _mistakeCount = 0;

            _timerCount = 0;
            _maxTimeLimit = 0;
            label1.Text = "0";

            _isWaitingForEnter = false;

            Task.Run(ResetLabelColor);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textBoxWrite_TextChanged(object sender, EventArgs e)
        {
            IsReadyForDeleteMistakes();

            if ((textBoxWrite.Text.Length == textBoxShow.Text.Length) && (!_isReadyToDeleteMistakes))
            {
                FinalResult();
                PassOrField();
            }
        }

        private void IsReadyForDeleteMistakes()
        {
            if (textBoxWrite.Text == "")
            {
                return;
            }

            string keyName = textBoxWrite.Text[_currentCharIndex].ToString().ToUpper();

            if (textBoxShow.Text[_currentCharIndex] != textBoxWrite.Text[_currentCharIndex])
            {
                Task.Run(() => HighlightKey(keyName, Color.Red));

                Task.Run(() => FormatResultText(_currentCharIndex));

                _isReadyToDeleteMistakes = true;
                _mistakeCount++;
            }
            else
            {
                Task.Run(() => HighlightKey(keyName, Color.Cyan));

                _currentCharIndex++;
            }
        }     

        private void HighlightKey(string KeyName, Color lettersColor)
        {
            lock (_lockObject)
            {
                ResetLabelColor();

                var controls = panelReset.Controls;
                for (int i = 0; i < controls.Count; i++)
                {
                    var label = controls[i] as Label;
                    if (label != null && label.Tag != null && string.Equals(label.Tag.ToString(), KeyName, StringComparison.OrdinalIgnoreCase))
                    {
                        label.BackColor = lettersColor;
                        return;
                    }
                }

                InvalidKey.BackColor = Color.Red;
            }
        }

        private void ResetLabelColor()
        {
            lock (_lockObject)
            {
                var controls = panelReset.Controls;
                for (int i = 0; i < controls.Count; i++)
                {
                    var label = controls[i] as Label;
                    if (label != null && label.Tag != null && (label.BackColor == Color.Cyan || label.BackColor == Color.Red))
                    {
                        label.BackColor = Color.Empty;
                        return;
                    }
                }
            }
        }

        private void FormatResultText(int charIndex)
        {
            if (richTxtResult.InvokeRequired)
            {
                // If the method is called from a non-UI thread, invoke it on the UI thread.
                richTxtResult.Invoke(new Action(() => FormatResultText(charIndex)));
            }
            else
            {
                // Code to execute on the UI thread.
                clsGlobal.AppendTextWithColor(richTxtResult, textBoxWrite.Text[charIndex].ToString(), Color.Red);
                clsGlobal.AppendTextWithColor(richTxtResult, $" => {textBoxShow.Text[charIndex]}{Environment.NewLine}", Color.Blue);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_timerCount == _maxTimeLimit)
            {
                timer.Enabled = false;
                _isWaitingForEnter = true;
                FinalResult();
                PassOrField();
                return;
            }

            _timerCount++;
            label1.Text = _timerCount.ToString();
        }

        private void FinalResult()
        {
            clsGlobal.AppendTextWithColor(richTxtResult, Environment.NewLine + _mistakeCount.ToString() + " Mistakes", Color.Black);
            _isWaitingForEnter = true;
            timer.Enabled = false;
        }

        private void PassOrField()
        {
            int num;

            if (_maxTimeLimit == 40)
            {
                num = textBoxShow.Text.Length / 2;

                if (num > _mistakeCount && textBoxShow.Text.Length == textBoxWrite.Text.Length)
                {
                    MessageBox.Show("You Pass", "Pass");
                }
                else
                    MessageBox.Show("You Failed", "Failed");
            }

            else if (_maxTimeLimit == 20)
            {
                num = textBoxShow.Text.Length / 4;

                if (num > _mistakeCount && textBoxShow.Text.Length == textBoxWrite.Text.Length)
                {
                    MessageBox.Show("You Pass", "Pass");
                }
                else
                    MessageBox.Show("You Failed", "Failed");
            }

            else
            {
                num = textBoxShow.Text.Length / 6;

                if (num > _mistakeCount && textBoxShow.Text.Length == textBoxWrite.Text.Length)
                {
                    MessageBox.Show("You Pass", "Pass");
                }
                else
                    MessageBox.Show("You Failed", "Failed");
            }
        }

        private void difficultyLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DifficultyLevel = new ChooseTheDifficultyForm();
            DifficultyLevel.ShowDialog();

            SetTimerAndFormatLabel();
        }

        private void addSentenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSentence frm = new AddSentence();
            frm.ShowDialog();

            LoadDataFromFile();
        }

        private void sentenceManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SentenceManagement frm = new SentenceManagement();
            frm.ShowDialog();

            LoadDataFromFile();
        }

        private void quatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PracticeInfoCallBack(int index)
        {
            LoadDataFromFile();

            if(index >= _dataLines.Count)
            {
                MessageBox.Show("An error occurred while loading the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentLineIndex = index;
            ResetForm();
        }
    }
}