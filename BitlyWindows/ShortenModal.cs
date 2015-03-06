using BitlyDotNET.Exceptions;
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
				string msg = string.Empty;
                try
                {
					if (!longURL.StartsWith("http"))
					{
						msg = Properties.Resources.invalidUrl;
					}
					else
					{
						shortURLBox.Text = Logic.ShortenURL(longURL);
					}
                }
				catch (BitlyDotNETException ex)
				{
					msg = Properties.Resources.shortenError;
				}
				catch (Exception ex)
				{
					if (ex.Message.Contains("Invalid absolute URL"))
					{
						msg = Properties.Resources.invalidUrl;
					}
				}
				finally
				{
					if (!string.IsNullOrEmpty(msg))
					{
						MessageBox.Show(msg, Properties.Resources.url, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
            }
            else
            {
                MessageBox.Show(Properties.Resources.fillInUrl, Properties.Resources.url, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			if (!string.IsNullOrEmpty(shortURLBox.Text))
			{
				Clipboard.SetText(shortURLBox.Text);
			}
        }
    }
}
