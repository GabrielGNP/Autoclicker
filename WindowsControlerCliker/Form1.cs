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
        //========== FUNCIONES Y PROCESOS DE AUTOCLICKER =============
        //======================================================================
        //======================================================================

        private const int LEFTUP = 0x0004;  //Comando para soltar el click 
        private const int LEFTDOWN = 0x0002; //Comando para hacer click
        public decimal intervals = 10; //Indica la frecuencia de clicks que se haran
        public bool Click = false; //Activa o desactiva la ejecucion de la funcion de los clicks automaticos
        int CountClicks = 0; //Cuenta la cantidad de clicks automaticos que se han dado

        bool CambiarTecla = false;
        Keys KeyAsignada = new Keys();
        KeysConverter Key = new KeysConverter();

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
                    
                    mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    
                    Thread.Sleep(787 / (int.Parse(intervals.ToString())));
                    CPS.Text = intervals.ToString();
                        //(1000 / (int.Parse(intervals.ToString()))).ToString();
                    CountClicks++;
                    ClicksHechos.Text = CountClicks.ToString();
                }
                //Thread.Sleep(2);
            }
        }

        //===== ===== ===== ===== Detecta el presionar las teclas fuera del form ===== ===== ===== =====
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (CheckActivar.Checked && CambiarTecla == false && ActivadorClick.Checked)
                {

                    //Es una funcion para detectar las teclas. Al no ejecutarse al tocar una tecla en el
                    // form, sino que se ejecuta al tocar una tecla sin importar si se toca en el form o
                    // fuera del form, se necesita una funcion que detecte las teclas.
                    if (GetAsyncKeyState(bindings) < 0 && Click == true /*|| GetAsyncKeyState(Keys.Down) < 0*/)
                    {
                        Thread.Sleep(100);
                        Click = false;
                        //MessageBox.Show("inactivo");
                        IndicadorDeActividad.ForeColor = Color.OrangeRed;
                        IndicadorDeActividad.Text = "| INACTIVO |";
                        
                        
                    }
                    else if (GetAsyncKeyState(bindings) < 0 && Click == false /*|| GetAsyncKeyState(Keys.Up) < 0*/)
                    {
                        Thread.Sleep(100);
                        //MessageBox.Show("activo");
                        CountClicks = 0;
                        Click = true;
                        IndicadorDeActividad.ForeColor = Color.Lime;
                        IndicadorDeActividad.Text = "| ACTIVO |";
                        
                        
                    }

                    Thread.Sleep(1);
                }
                Thread.Sleep(1);
            }
        }



        //===== ===== ===== ===== Obtiene la frecuencia de clicks por segundo ===== ===== ===== =====
        private void CPSIngreser_ValueChanged(object sender, EventArgs e)
        {
            intervals = CPSIngreser.Value;
        }

        private void CambiarBoton_Click(object sender, EventArgs e)
        {
            CambiarTecla = true;
            KeyAsigned.Text = "...";
        }
        Keys bindings;
        //Para que esto funcione se necesita que el KeyPreview en el Form1 esté en True
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (CambiarTecla == true)
            {
                KeyAsignada = e.KeyCode;
                KeyAsigned.Text = e.KeyData.ToString();
                CambiarTecla = false;
                MessageBox.Show(KeyAsignada.ToString());
                if (KeyAsigned.Text != "..." && KeyAsigned.Text != "none")
                {
                    bindings = (Keys)Key.ConvertFromString(KeyAsigned.Text);
                }
                MessageBox.Show(bindings.ToString());

            }
            
        }

        private void ActivadorClick_CheckedChanged(object sender, EventArgs e)
        {
            if (ActivadorClick.Checked)
            {//Activo
                ActivadorClick.BackColor = Color.LimeGreen;
                //ActivadorClick.ForeColor = Color.Black;
                ActivadorClick.Text = "ACTIVO";
                CPSIngreser.Enabled = false;
            }
            else
            {//Inactivo
                ActivadorClick.BackColor = Color.Maroon;
                //ActivadorClick.ForeColor = Color.White;
                ActivadorClick.Text = "INACTIVO";
                CPSIngreser.Enabled = true;
            }
        }

        //======================================================================
        //======================================================================
        //========== CONTADOR DE USOS DE TECLADO Y MOUSE =============
        //======================================================================
        //======================================================================
        private void DetectorTeclas_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }
    }
}