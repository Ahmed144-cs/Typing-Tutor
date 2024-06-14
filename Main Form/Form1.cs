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

        private void quatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }     


        private List<string> DataLines = new List<string>();
        private int DataLineCount = 0;

        bool readyForDeleteMistakes = false;
        int countLetters = 0;
        int countMistakes = 0;

        short timerCount = 0;
        short maxTimerNumber = 0;

        bool madeHimPressEnter = false;


        private void FormTypingTutor_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ConfigurationManager.AppSettings["FilePath"]))
            {
                MessageBox.Show("Program data is missing. Please ensure all required data is available and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            LoadDataFromFile();
        }

        void LoadDataFromFile()
        {
            try
            {
                DataLines.AddRange(File.ReadAllLines(ConfigurationManager.AppSettings["FilePath"]));
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("The program data file is missing. Please ensure the file 'myTypingTutorFile.txt' is available and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.LogError(ex.Message);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the data.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ErrorLogger.LogError(ex.Message);
                this.Close();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {         
            if (DataLineCount == 0)
            {
                textBoxShow.Text = DataLines[DataLineCount];
                textBoxWrite.Focus();
            }

            if (DataLineCount < DataLines.Count)
            {
                textBoxWrite.MaxLength = DataLines[DataLineCount].Length;
            }

            buttonStart.Enabled = false;
            buttonStart.BackColor = Color.Empty;

            textBoxWrite.ReadOnly = false;
            textBoxWrite.Focus();

            SetTimerAndFormatLabel();
            timer.Enabled = true;

            madeHimPressEnter = false;
        }

        void SetTimerAndFormatLabel()
        {
            if (ClsDifficultyLevel.SelectedLevel == "Easy")
            {
                labelMaxTime.Text = ":40";
                maxTimerNumber = 40;
            }

            if (ClsDifficultyLevel.SelectedLevel == "Middle")
            {
                labelMaxTime.Text = ":20";
                maxTimerNumber = 20;
            }

            if (ClsDifficultyLevel.SelectedLevel == "Hard")
            {
                labelMaxTime.Text = ":10";
                maxTimerNumber = 10;
            }
        }

        private void textBoxWrite_Click(object sender, EventArgs e)
        {
            //move cursor to the end of written text
            textBoxWrite.SelectionStart = textBoxWrite.TextLength;
        }

        private void textBoxWrite_KeyDown(object sender, KeyEventArgs e)
        {
            if (madeHimPressEnter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    GetNextText();
                    return;
                }
                else
                {
                    e.SuppressKeyPress = true;
                    return;
                }
            }

            if (readyForDeleteMistakes)
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (countLetters > 0)
                        countLetters--;
                    readyForDeleteMistakes = false;
                    return;
                }
                else
                {
                    e.SuppressKeyPress = true;
                    return;
                }
            }

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left
                || e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                GetNextText();
                return;
            }

            InvalidKey.BackColor = Color.Empty;
        }

        private void textBoxWrite_TextChanged(object sender, EventArgs e)
        {
            IsReadyForDeleteMistakes();

            if((textBoxWrite.Text.Length == textBoxShow.Text.Length) && (!readyForDeleteMistakes))
            {
                FinalResult();
                PassOrField();
            }
        }      

        void IsReadyForDeleteMistakes()
        {
            if (textBoxWrite.Text == "")
            {
                return;
            }

            if (textBoxShow.Text[countLetters] != textBoxWrite.Text[countLetters])
            {
                textBoxResult.Text += textBoxWrite.Text[countLetters] + " ";
                readyForDeleteMistakes = true;
                countMistakes++;
                InvalidKey.BackColor = Color.Red;
            }
            else
            {
                countLetters++;
            }
        }     

        void GetNextText()
        {
            DataLineCount++;

            if (DataLineCount < DataLines.Count)
            {
                ResetForm();
            }
            else
            {
                if (MessageBox.Show("Do you want to go back to the beginning sentences ",
                    "Warning there are no more sentences to show",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DataLineCount = 0;
                    ResetForm();
                }
                else
                {
                    DataLineCount--;
                    buttonReset_Click(null, null);  
                }
            }
        }

        void ResetForm()
        {
            textBoxShow.Text = DataLines[DataLineCount];
            textBoxWrite.MaxLength = DataLines[DataLineCount].Length;

            textBoxWrite.ReadOnly = true;
            textBoxWrite.Clear();

            buttonStart.Enabled = true;
            buttonStart.BackColor = Color.SeaShell;
            buttonStart.Focus();

            textBoxResult.Clear();
            timer.Enabled = false;

            readyForDeleteMistakes = false;
            countLetters = 0;
            countMistakes = 0;

            timerCount = 0;
            maxTimerNumber = 0;
            label1.Text = "0";

            madeHimPressEnter = false;

            InvalidKey.BackColor = Color.Empty;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(timerCount == maxTimerNumber)
            {
                timer.Enabled = false;
                madeHimPressEnter = true;
                FinalResult();
                PassOrField();
                return;
            }

            timerCount++;
            label1.Text = timerCount.ToString();
        }

        void FinalResult()
        {
            textBoxResult.Text += Environment.NewLine + countMistakes.ToString() + " Mistakes";
            madeHimPressEnter = true;
            timer.Enabled = false;
        }

        void PassOrField()
        {
            if (maxTimerNumber == 40)
            {
                int num = textBoxShow.Text.Length / 2;

                if (num > countMistakes && textBoxShow.Text.Length  == textBoxWrite.Text.Length)
                {
                    MessageBox.Show("You Pass", "Pass");
                }
                else
                    MessageBox.Show("You Failed", "Failed");
            }

            else if (maxTimerNumber == 20)
            {
                int num = textBoxShow.Text.Length / 4;

                if (num > countMistakes && textBoxShow.Text.Length == textBoxWrite.Text.Length)
                {
                    MessageBox.Show("You Pass", "Pass");
                }
                else
                    MessageBox.Show("You Failed", "Failed");
            }

            else 
            {
                int num = textBoxShow.Text.Length / 6;

                if (num > countMistakes && textBoxShow.Text.Length == textBoxWrite.Text.Length)
                {
                    MessageBox.Show("You Pass", "Pass");
                }
                else
                    MessageBox.Show("You Failed", "Failed");
            }      
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            madeHimPressEnter = true;
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

        #region
        private void labelMaxTime_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void InvalidKey_Click(object sender, EventArgs e) { }
        private void textBoxResult_TextChanged(object sender, EventArgs e) { }
        private void textBoxShow_TextChanged(object sender, EventArgs e) { }
        private void panelReset_Paint(object sender, PaintEventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        #endregion  
    }
}
