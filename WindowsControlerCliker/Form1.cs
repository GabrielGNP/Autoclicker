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
using System.Threading;

namespace WindowsControlerCliker
{
    public partial class Form1 : Form
    {
        //_____________________________________________________________________
        // Necesario para el uso de las teclas
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Application; //Crea el icono de sistema en notificacion
        }
        //_____________________________________________________________________

       

        //======================================================================
        //======================================================================
        //========== FUNCION DE MINIMIZAR Y DEJAR EN SEGUNDO PLANO =============
        //======================================================================
        //======================================================================
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                //notifyIcon1.BalloonTipText = "Minimizado"; //Muestra un mensaje de notificacion
                //notifyIcon1.ShowBalloonTip(1000); // Indica el tiempo de duracion del mensaje de notificacion

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            //notifyIcon1.BalloonTipText = "normalizado"; //Muestra un mensaje de notificacion
            //notifyIcon1.ShowBalloonTip(1000); // Indica el tiempo de duracion del mensaje de notificacion
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


        //======================================================================
        //======================================================================
        //==========  =============
        //======================================================================
        //======================================================================

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        public int intervals = 5;
        public bool Click = false;
        private int parsedValue;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            backgroundWorker1.RunWorkerAsync();
            AC.Start();
        }
        private void AutoClick()
        {
            while (true)
            {
                if (Click == true)
                {
                    mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(intervals);
                }
                Thread.Sleep(2);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (CheckActivar.Checked)
                {
                    if (GetAsyncKeyState(Keys.Down) < 0)
                    {
                        Click = false;
                    }else if (GetAsyncKeyState(Keys.Up) < 0)
                    {
                        Click = true;
                    }
                    Thread.Sleep(1);
                }
                Thread.Sleep(1);
            }
        }

        private void CPSIngreser_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(CPSIngreser.Text, out parsedValue))
            {
                MessageBox.Show("Ingrese un numero, NO UNA LETRA");
                return;
            }
            else
            {
                intervals = int.Parse(CPSIngreser.Text);
            }
        }
    }
}