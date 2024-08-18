using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTutor
{
    public class clsGlobal
    {       
        public static bool IsDataFileExist()
        {
            return File.Exists(ConfigurationManager.AppSettings["FilePath"]);
        }

        public static string GetFilePath()
        {
            return ConfigurationManager.AppSettings["FilePath"];
        }

        public static void LogAndShowError(Exception ex, string userMessage)
        {
            ErrorLogger.LogError(ex.Message);
            MessageBox.Show(userMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool IsInvalidKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left
               || e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AppendTextWithColor(RichTextBox richTextBox, string text, Color color)
        {
            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectionColor = color;
            richTextBox.AppendText(text);
            richTextBox.SelectionColor = richTextBox.ForeColor;  // Reset color to default
        }
    }
}
