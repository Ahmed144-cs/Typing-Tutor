using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingTutorClsDifficultyLevel;

namespace TypingTutor
{
    public partial class ChooseTheDifficultyForm : Form
    {
        public ChooseTheDifficultyForm()
        {
            InitializeComponent();
        }

        private void ChooseTheDifficultyForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            ClsDifficultyLevel.SelectedLevel = "Easy";
            this.Close();
        }

        private void buttonMiddle_Click(object sender, EventArgs e)
        {
            ClsDifficultyLevel.SelectedLevel = "Middle";
            this.Close();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            ClsDifficultyLevel.SelectedLevel = "Hard";
            this.Close();
        }
    }
}
