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
    public partial class MainModal : Form
    {
        public MainModal()
        {
            InitializeComponent();
        }

        private void MainModal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new ShortenModal().Show();
        }

        private void shortenURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShortenModal().Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsModal().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2015 - Duco Winterwerp\r\nduco.cc");
        }
    }
}
