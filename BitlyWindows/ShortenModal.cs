using BitlyDotNET.Implementations;
using BitlyDotNET.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BitlyWindows
{
    public partial class ShortenModal : Form
    {
        public ShortenModal()
        {
            InitializeComponent();
        }

        private void shortenURLButton_Click(object sender, EventArgs e)
        {
            string longURL = longURLBox.Text;
            if (!string.IsNullOrEmpty(longURL))
            {
                try
                {
                    shortURLBox.Text = Logic.ShortenURL(longURL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.shortenError, "URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You should fill in a URL.", "URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void longURLBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                shortenURLButton_Click(null, null);
            }
        }

        private void shortURLBox_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(shortURLBox.Text);
        }
    }
}
