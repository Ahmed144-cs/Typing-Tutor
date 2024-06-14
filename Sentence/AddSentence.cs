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
        Mode mode;

        int sentenceID;
        public static Action<int> CallBack;

        public AddSentence()
        {
            InitializeComponent();
            this.Text = "Add Sentence";
            mode = Mode.add;
        }

        public AddSentence(string sentence, int sentenceID)
        {
            InitializeComponent();

            this.Text = "Update Sentence";
            TbInput.Text = sentence;
            mode = Mode.update;
            this.sentenceID = sentenceID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSentence_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ConfigurationManager.AppSettings["FilePath"]))
            {
                MessageBox.Show("Program data is missing. Please ensure all required data is available and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TbInput.Text.Trim()))
            {
                using (StreamWriter wf = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
                {
                    wf.WriteLine(TbInput.Text.Trim());
                }

                MessageBox.Show("Task finished successfully!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (mode == Mode.update)
                {
                    CallBack(this.sentenceID);
                    this.Close();
                }

                TbInput.Clear();
                TbInput.Focus();
            }
        }
    }
}
