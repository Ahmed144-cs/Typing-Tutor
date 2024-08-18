using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace TypingTutor
{
    public partial class SentenceManagement : Form
    {
        public SentenceManagement()
        {
            InitializeComponent();
        }


        private List<string> _lisSentence = new List<string>();
        public static Action<int> PracticeCallBack;  

        private void SentenceManagement_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.IsDataFileExist())
            {
                MessageBox.Show("Program data is missing. Please ensure all required data is available and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            Task.Run(LoadDataFromFile);
        }

        private void LoadDataFromFile()
        {
            _lisSentence = File.ReadAllLines(clsGlobal.GetFilePath()).ToList();

            if (dGVSentence.InvokeRequired)
            {
                dGVSentence.BeginInvoke(new Action(() =>
                {
                    dGVSentence.DataSource = DataOrganizing();
                }));
            }
            else
            {
                dGVSentence.DataSource = DataOrganizing();
            }
        }

        private DataTable DataOrganizing()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Sentence", typeof(string));

            for (int i = 0; i < _lisSentence.Count; i++)
            {
                dt.Rows.Add(i, _lisSentence[i]);
            }

            return dt;
        }     

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSentence addSentence = new AddSentence();
            addSentence.ShowDialog();

            Task.Run(LoadDataFromFile);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dGVSentence.Rows.Count <= 0)
                return;

            _lisSentence.RemoveAt((int)dGVSentence.CurrentRow.Cells[0].Value);
            dGVSentence.Rows.RemoveAt((int)dGVSentence.CurrentRow.Cells[0].Value);

            Task.Run(LoadDataToFile);
            ReorderID();
        }

        private void LoadDataToFile()
        {
            File.WriteAllLines(clsGlobal.GetFilePath(), _lisSentence);
        }

        private void ReorderID()
        {
            for (int i = 0; i < dGVSentence.Rows.Count; i++)
            {
                dGVSentence.Rows[i].Cells[0].Value = i;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sentenceID = (int)dGVSentence.CurrentRow.Cells[0].Value;

            AddSentence.CallBack = UpdateCallBack;

            AddSentence addUpdateSentence = new AddSentence((string)dGVSentence.CurrentRow.Cells[1].Value, sentenceID);
            addUpdateSentence.ShowDialog();
        }

        private void UpdateCallBack(int sentenceID)
        {
            LoadDataFromFile();

            _lisSentence.RemoveAt(sentenceID); // remove the old Sentence
            dGVSentence.Rows.RemoveAt(sentenceID);

            Task.Run(LoadDataToFile);
            ReorderID();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracticeCallBack?.Invoke((int)dGVSentence.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
