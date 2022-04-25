using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsControlerCliker
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

       
        private void C(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Icon = SystemIcons.Application;
              //  notifyIcon1.BalloonTipText = "Minimizado";
               // notifyIcon1.ShowBalloonTip(1000);

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            //notifyIcon1.BalloonTipText = "normalizado";
            //notifyIcon1.ShowBalloonTip(1000);
            this.WindowState = FormWindowState.Normal;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            //notifyIcon1.BalloonTipText = "normalizado";
            //notifyIcon1.ShowBalloonTip(1000);
            this.WindowState = FormWindowState.Normal;
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Icon = SystemIcons.Application;
            //  notifyIcon1.BalloonTipText = "Minimizado";
            // notifyIcon1.ShowBalloonTip(1000);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }     
}