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
using static System.Windows.Forms.LinkLabel;

namespace TypingTutor
{
    public partial class SentenceManagement : Form
    {
        public SentenceManagement()
        {
            InitializeComponent();
        }


        List<string> lisSentence = new List<string>();


        private void SentenceManagement_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ConfigurationManager.AppSettings["FilePath"]))
            {
                MessageBox.Show("Program data is missing. Please ensure all required data is available and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            LoadDataFromFile();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSentence addSentence = new AddSentence();
            addSentence.ShowDialog();

            LoadDataFromFile();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dGVSentence.Rows.Count <= 0)
                return;

            lisSentence.RemoveAt((int)dGVSentence.CurrentRow.Cells[0].Value);
            dGVSentence.Rows.RemoveAt((int)dGVSentence.CurrentRow.Cells[0].Value);

            LoadDataToFile();
            ReorderID();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sentenceID = (int)dGVSentence.CurrentRow.Cells[0].Value;

            AddSentence.CallBack = UpdateCallBack;

            AddSentence addSentence = new AddSentence((string)dGVSentence.CurrentRow.Cells[1].Value, sentenceID);
            addSentence.ShowDialog();
        }

        private void UpdateCallBack(int sentenceID)
        {
            LoadDataFromFile();

            lisSentence.RemoveAt(sentenceID); // remove the old Sentence
            dGVSentence.Rows.RemoveAt(sentenceID);

            LoadDataToFile();
            ReorderID();
        }

        private void LoadDataFromFile()
        {
            lisSentence = File.ReadAllLines(ConfigurationManager.AppSettings["FilePath"]).ToList();          

            dGVSentence.DataSource = DataOrganizing();
        }

        private DataTable DataOrganizing()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Sentence", typeof(string));

            for (int i =0; i< lisSentence.Count;i++)
            {
                dt.Rows.Add(i, lisSentence[i]);
            }

            return dt;
        }      

        private void LoadDataToFile()
        {
            File.WriteAllLines(ConfigurationManager.AppSettings["FilePath"], lisSentence);
        }

        private void ReorderID()
        {
            for (int i = 0; i < dGVSentence.Rows.Count; i++)
            {
                dGVSentence.Rows[i].Cells[0].Value = i;
            }
        }
    }
}
