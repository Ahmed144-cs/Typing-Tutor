using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTutor
{
    public partial class AddSentence : Form
    {
        private enum Mode { add = 0, update = 1 }
        private Mode _mode;

        private int _sentenceID;
        public static Action<int> CallBack;

        public AddSentence()
        {
            InitializeComponent();

            this.Text = "Add Sentence";
            _mode = Mode.add;
        }

        public AddSentence(string sentence, int sentenceID)
        {
            InitializeComponent();

            this.Text = "Update Sentence";
            TbInput.Text = sentence;
            _mode = Mode.update;
            this._sentenceID = sentenceID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSentence_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.IsDataFileExist())
            {
                MessageBox.Show("Program data is missing. Please ensure all required data is available and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TbInput.Text.Trim()))
            {
                using (StreamWriter wf = new StreamWriter(clsGlobal.GetFilePath(), true))
                {
                    wf.WriteLine(TbInput.Text.Trim());
                }

                MessageBox.Show("Task finished successfully!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_mode == Mode.update)
                {
                    CallBack(this._sentenceID);
                    this.Close();
                }

                TbInput.Clear();
                TbInput.Focus();
            }
        }
    }
}
