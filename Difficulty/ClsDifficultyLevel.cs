using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTutorClsDifficultyLevel
{
    internal class ClsDifficultyLevel
    {
        static public string SelectedLevel { set; get; }

        static ClsDifficultyLevel()
        {
            SelectedLevel = "Easy";
        }
    }
}
