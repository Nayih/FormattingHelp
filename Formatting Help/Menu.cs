using System;
using System.Windows.Forms;

namespace Formatting_Help
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (char index in textBox1.Text)
            {
                switch (index)
                {
                    case 'a': case 'A': result += 'ᴀ'; break;
                    case 'b': case 'B': result += 'ʙ'; break;
                    case 'c': case 'C': result += 'ᴄ'; break;
                    case 'ç': case 'Ç': result += 'ҫ'; break;
                    case 'd': case 'D': result += 'ᴅ'; break;
                    case 'e': case 'E': result += 'ᴇ'; break;
                    case 'f': case 'F': result += 'ꜰ'; break;
                    case 'g': case 'G': result += 'ɢ'; break;
                    case 'h': case 'H': result += 'ʜ'; break;
                    case 'i': case 'I': result += 'ɪ'; break;
                    case 'j': case 'J': result += 'ᴊ'; break;
                    case 'k': case 'K': result += 'ĸ'; break;
                    case 'l': case 'L': result += 'ʟ'; break;
                    case 'm': case 'M': result += 'ᴍ'; break;
                    case 'n': case 'N': result += 'ɴ'; break;
                    case 'o': case 'O': result += 'ᴏ'; break;
                    case 'p': case 'P': result += 'ᴘ'; break;
                    case 'q': case 'Q': result += 'ǫ'; break;
                    case 'r': case 'R': result += 'ʀ'; break;
                    case 's': case 'S': result += 's'; break;
                    case 't': case 'T': result += 'ᴛ'; break;
                    case 'u': case 'U': result += 'ᴜ'; break;
                    case 'v': case 'V': result += 'v'; break;
                    case 'w': case 'W': result += 'ᴡ'; break;
                    case 'x': case 'X': result += 'х'; break;
                    case 'y': case 'Y': result += 'ʏ'; break;
                    case 'z': case 'Z': result += 'ᴢ'; break;
                    default: result += index; break;
                }
            }
            textBox2.Text = result;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/Nayoh/");
        }
    }
}
