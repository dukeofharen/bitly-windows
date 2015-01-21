using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitlyWindows
{
    public partial class SettingsModal : Form
    {
        public SettingsModal()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bitlyUsername = usernameBox.Text;
            Properties.Settings.Default.bitlyKey = bitlyAPIKeyBox.Text;
            try
            {
                Logic.ShortenURL("http://example.com");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.Resources.shortenError, "URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Properties.Settings.Default.Save();
        }

        private void SettingsModal_Load(object sender, EventArgs e)
        {
            usernameBox.Text = Properties.Settings.Default.bitlyUsername;
            bitlyAPIKeyBox.Text = Properties.Settings.Default.bitlyKey;
        }
    }
}
