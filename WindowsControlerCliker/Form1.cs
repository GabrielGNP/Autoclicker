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
using KeysDetectorSegundoPlano; // Se encuentra en la carpeta
                                // C:\Users\USUARIO\source\repos\KeysDetectorSegundoPlano
                                // C:\Users\USUARIO\source\repos\KeysDetectorSegundoPlano\KeysDetectorSegundoPlano\bin\Debug
using System.IO; //Permite manejar archivos de texto (.txt)


namespace WindowsControlerCliker
{
  
    public partial class Form1 : Form
    {
        int ContadorClickL = 0; //Click Izquierdo
        int ContadorClickR = 0; //Click Derecho
        int ContadorClickM = 0; //Click Central
        int ContadorClickXB1 = 0; //Click boton extra 1 del mouse
        int ContadorClickXB2 = 0; //Click boton extra 2 del mouse
        int ContadorRueda = 0; //Rueda del raton
        int ContadorTeclas = 0;

        //_____________________________________________________________________
        // Necesario para el uso de las teclas
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        KeysDetectorSP KH = new KeysDetectorSP();
        MouseDetectorSP MH = new MouseDetectorSP();
   

       

        bool ctrl, shift;
 

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Application; //Crea el icono de sistema en notificacion

            //==
            KH.KeyDown += Kh_KeyDown;
            KH.KeyUp += Kh_KeyUp;

            //MH.ClickDown += MH_ClickDown;
            //MH.ClickUp += MH_ClickUp;
            MH.ClickUp += MH_ClickUp;


       


        }

        private void MH_ClickUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show();
            if (e.Button == MouseButtons.Left)
            {
                ContadorClickL++;
            }
            if (e.Button == MouseButtons.Right)
            {
                ContadorClickR++;
            }
            if (e.Button == MouseButtons.Middle)
            {
                ContadorClickM++;
            }
            if (e.Button == MouseButtons.XButton1)
            {
                ContadorClickXB1++;
                //MessageBox.Show(e.Button.ToString()+" "+ContadorClickXB1.ToString());
                //ClicksExtra1Cont.Text = ContadorClickXB1.ToString();
            }
            if (e.Button == MouseButtons.XButton2)
            {
                ContadorClickXB2++;
                //MessageBox.Show(e.Button.ToString() + " " + ContadorClickXB2.ToString());
                //ClicksExtra2Cont.Text = ContadorClickXB2.ToString();
                
            }
        }

        bool Cargar = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        //    Thread AC = new Thread(AutoClick);
        //    AC.Start(); //Inicia el proceso autoclicker
            backgroundWorker1.RunWorkerAsync();
            //Thread AC = new Thread(AutoClick);
            //AC.Start(); Si esto se hace aumenta MUCHISIMO el consumo del procesador al ejecutar el programa. Aumenta el consumo a un 28% para ser más exacto

            
            if (Cargar)
            {
                Cargar = false;
                if (File.Exists("C:\\juegos\\Info.txt")) //Comprueba si el archivo existe
                {
                    //MessageBox.Show("Se va a leer el archivo para cargar los datos");
                    LecturaDeDatos();
                    MH.RdR = ContadorRueda;
                    //MessageBox.Show("Se a leido el archivo");
                    //MessageBox.Show("Ahora salta error");
                    Actualizador.Enabled = true;

                }
                else
                {
                    StreamWriter stream = new StreamWriter("C:\\juegos\\Info.txt"); //Crea un nuevo archivo vasío
                    //File.WriteAllText("C:\\Info.txt", "Cosa, Hola mundo");
                    MessageBox.Show("Se a creado un nuevo archivo");
                    stream.Close();
                }
                //MessageBox.Show("Termina la carga de datos");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscrituraDeDatos();
           // MessageBox.Show("Se han escrito los datos en el archivo");
        }
        
        String line;
        private void LecturaDeDatos()
        {
            // 1º linea ClicksIzquirdos
            // 2º linea ClicksDerechos
            // 3º linea ClicksCentrales
            // 4º linea TicsRueda
            // 5º linea ClicksX1
            // 6º linea ClicksX2
            // 7º linea PulsacionesTeclado

            StreamReader sr = new StreamReader("C:\\juegos\\Info.txt");
            line = sr.ReadLine();
            if (line != null)
            {
                //MessageBox.Show("Hay datos en el archivo");
                // 1º linea ClicksIzquirdos
                ContadorClickL = ContadorClickL + int.Parse(line);

                // 2º linea ClicksDerechos
                line = sr.ReadLine();
                if (line != null)
                {
                    ContadorClickR = ContadorClickR + int.Parse(line);

                    // 3º linea ClicksCentrales
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        ContadorClickM = ContadorClickM + int.Parse(line);

                        // 4º linea TicsRueda
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            ContadorRueda = ContadorRueda + int.Parse(line);

                            // 5º linea ClicksX1
                            line = sr.ReadLine();
                            if (line != null)
                            {
                                ContadorClickXB1 = ContadorClickXB1 + int.Parse(line);

                                // 6º linea ClicksX2
                                line = sr.ReadLine();
                                if (line != null)
                                {
                                    ContadorClickXB2 = ContadorClickXB2 + int.Parse(line);

                                    // 7º linea PulsacionesTeclado
                                    line = sr.ReadLine();
                                    if (line != null)
                                    {
                                        ContadorTeclas = ContadorTeclas + int.Parse(line);
                                    }
                                    else
                                    {
                                        ContadorTeclas = ContadorTeclas + 0;
                                    }

                                }
                                else
                                {
                                    ContadorClickXB2 = ContadorClickXB2 + 0;
                                    ContadorTeclas = ContadorTeclas + 0;

                                }
                            }
                            else
                            {
                                ContadorClickXB1 = ContadorClickXB1 + 0;
                                ContadorClickXB2 = ContadorClickXB2 + 0;
                                ContadorTeclas = ContadorTeclas + 0;
                                

                            }
                        }
                        else
                        {
                            MH.RdR = MH.RdR + 0;
                            ContadorClickXB1 = ContadorClickXB1 + 0;
                            ContadorClickXB2 = ContadorClickXB2 + 0;
                            ContadorTeclas = ContadorTeclas + 0;
                            

                        }
                    }
                    else
                    {
                        ContadorClickM = ContadorClickM + 0;
                        ContadorRueda = ContadorRueda + 0;
                        ContadorClickXB1 = ContadorClickXB1 + 0;
                        ContadorClickXB2 = ContadorClickXB2 + 0;
                        ContadorTeclas = ContadorTeclas + 0;
                        

                    }
                }
                else
                {
                    ContadorClickR = ContadorClickR + 0;
                    ContadorClickM = ContadorClickM + 0;
                    ContadorRueda = ContadorRueda + 0;
                    ContadorClickXB1 = ContadorClickXB1 + 0;
                    ContadorClickXB2 = ContadorClickXB2 + 0;
                    ContadorTeclas = ContadorTeclas + 0;
                    

                }
            }
            else
            {
                ContadorClickL = ContadorClickL + 0;
                ContadorClickR = ContadorClickR + 0;
                ContadorClickM = ContadorClickM + 0;
                ContadorRueda = ContadorRueda + 0;
                ContadorClickXB1 = ContadorClickXB1 + 0;
                ContadorClickXB2 = ContadorClickXB2 + 0;
                ContadorTeclas = ContadorTeclas + 0;

            }
            ClicksIzquierdoCont.Text = ContadorClickL.ToString();
            ClicksDerechoCont.Text = ContadorClickR.ToString();
            ClicksCentralCont.Text = ContadorClickM.ToString();
            RuedaRatonCont.Text = ContadorRueda.ToString();
            ClicksExtra1Cont.Text = ContadorClickXB1.ToString();
            ClicksExtra2Cont.Text = ContadorClickXB2.ToString();
            PulsacionTeclaCont.Text = ContadorTeclas.ToString();
            //MessageBox.Show("lectura completa, va a cerrar el documento");
            sr.Close();
            Actualizador.Enabled = true;
            
        }


        //_____________________________________________________________________
        //======================================================================
        //======================================================================
        //========== FUNCION DE Deteccion de teclas fuera del programa =========
        //========== para el contador de teclas ===============================
        //======================================================================
        //======================================================================


        
      
        private void Kh_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey) ctrl = false;
            if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey) shift = false;
            if (e.KeyCode == Keys.T && e.KeyCode == Keys.LControlKey)
            {
               
                MessageBox.Show("A soltado control shift T");
            }
            ContadorTeclas++;
            //PulsacionTeclaCont.Text = ContadorTeclas.ToString();
        }
        
        private void Kh_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey) ctrl = true;
            if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey) shift = true;
            if (e.KeyCode == Keys.R && ctrl == true)
            {
               // MessageBox.Show("A presionado control shift R");
            }
            if (e.KeyCode == Keys.Z && ctrl == true)
            {
                //MessageBox.Show("A presionado control shift Z");
            }
        }







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
        public new bool Click = false; //Activa o desactiva la ejecucion de la funcion de los clicks automaticos
        int CountClicks = 0; //Cuenta la cantidad de clicks automaticos que se han dado

        bool CambiarTecla = false;
        Keys KeyAsignada = new Keys();
        KeysConverter Key = new KeysConverter();

       
        private void AutoClick()
        {
            while (true)
            {
                if (Click == true)
                {
                    
                    mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    ContadorClickL--;
                    Thread.Sleep(787 / (int.Parse(intervals.ToString())));
                    
                        //(1000 / (int.Parse(intervals.ToString()))).ToString();
                    CountClicks++;
                    ClicksHechos.Text = CountClicks.ToString();

                }
                else
                {
                    Thread.Sleep(1000);
                }

            }
        }

        //===== ===== ===== ===== Detecta el presionar las teclas fuera del form ===== ===== ===== =====
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           

            Thread AC = new Thread(AutoClick);
            //AC.IsBackground = true;
            AC.Start(); //Inicia el proceso autoclicker
            AC.Interrupt();
            //AC.Suspend(); //Suspende el proceso autoclicker. Esto hace que no se esté ejecutando constantemente sin hacer nada
            while (true)
             {
                 if (CheckActivar.Checked && CambiarTecla == false && ActivadorClick.Checked)
                 {
                     //Es una funcion para detectar las teclas. Al no ejecutarse al tocar una tecla en el
                     // form, sino que se ejecuta al tocar una tecla sin importar si se toca en el form o
                     // fuera del form, se necesita una funcion que detecte las teclas.
                     if (ControlActivate.Checked)
                     {
                         if (ShiftActivate.Checked)
                         {
                             if (GetAsyncKeyState(bindings) < 0 && 
                                (GetAsyncKeyState(Keys.LShiftKey) < 0 || GetAsyncKeyState(Keys.RShiftKey) < 0) &&
                                (GetAsyncKeyState(Keys.LControlKey) < 0 || GetAsyncKeyState(Keys.RControlKey) < 0) &&
                                 Click == true )
                             {
                                 Thread.Sleep(100);
                                 Click = false;
                                //AC.Suspend(); //Suspende el proceso autoclicker. Esto hace que no se esté ejecutando constantemente sin hacer nada
                                AC.Interrupt();

                                //MessageBox.Show("inactivo");
                                IndicadorDeActividad.ForeColor = Color.OrangeRed;
                                 IndicadorDeActividad.Text = "| INACTIVO |";
                             }
                             else if (GetAsyncKeyState(bindings) < 0 && 
                                     (GetAsyncKeyState(Keys.LShiftKey) < 0 || GetAsyncKeyState(Keys.RShiftKey) < 0) &&
                                     (GetAsyncKeyState(Keys.LControlKey) < 0 || GetAsyncKeyState(Keys.RControlKey) < 0) &&
                                      Click == false )
                             {
                                 Thread.Sleep(100);
                                 //MessageBox.Show("activo");
                                 CountClicks = 0;
                                 Click = true;
                                AC.Resume(); //Reanuda el proceso autoclicker 

                                IndicadorDeActividad.ForeColor = Color.Lime;
                                 IndicadorDeActividad.Text = "| ACTIVO |";
                             }
                         }
                         else
                         {
                             if (GetAsyncKeyState(bindings) < 0 &&
                                (GetAsyncKeyState(Keys.LControlKey) < 0 || GetAsyncKeyState(Keys.RControlKey) < 0) &&
                                 Click == true)
                             {
                                 Thread.Sleep(100);
                                 Click = false;
                                 //AC.Suspend(); //Suspende el proceso autoclicker. Esto hace que no se esté ejecutando constantemente sin hacer nada
                                AC.Interrupt();

                                //MessageBox.Show("inactivo");
                                IndicadorDeActividad.ForeColor = Color.OrangeRed;
                                 IndicadorDeActividad.Text = "| INACTIVO |";
                             }
                             else if (GetAsyncKeyState(bindings) < 0 &&
                                     (GetAsyncKeyState(Keys.LControlKey) < 0 || GetAsyncKeyState(Keys.RControlKey) < 0) &&
                                      Click == false)
                             {
                                 Thread.Sleep(100);
                                 //MessageBox.Show("activo");
                                 CountClicks = 0;
                                 Click = true;
                                AC.Resume(); //Reanuda el proceso deautoclicker
                                IndicadorDeActividad.ForeColor = Color.Lime;
                                 IndicadorDeActividad.Text = "| ACTIVO |";
                             }
                         }
                     }
                     else
                     {
                         if (ShiftActivate.Checked)
                         {
                             if (GetAsyncKeyState(bindings) < 0 &&
                                (GetAsyncKeyState(Keys.LShiftKey) < 0 || GetAsyncKeyState(Keys.RShiftKey) < 0) &&
                                 Click == true)
                             {
                                 Thread.Sleep(100);
                                 Click = false;
                                // AC.Suspend(); //Suspende el proceso autoclicker. Esto hace que no se esté ejecutando constantemente sin hacer nada
                                AC.Interrupt();

                                //MessageBox.Show("inactivo");
                                IndicadorDeActividad.ForeColor = Color.OrangeRed;
                                 IndicadorDeActividad.Text = "| INACTIVO |";
                             }
                             else if (GetAsyncKeyState(bindings) < 0 && 
                                     (GetAsyncKeyState(Keys.LShiftKey) < 0 || GetAsyncKeyState(Keys.RShiftKey) < 0) && 
                                      Click == false )
                             {
                                 Thread.Sleep(100);
                                 //MessageBox.Show("activo");
                                 CountClicks = 0;
                                 Click = true;
                                AC.Resume(); //Reanuda el proceso deautoclicker
                                IndicadorDeActividad.ForeColor = Color.Lime;
                                 IndicadorDeActividad.Text = "| ACTIVO |";
                             }
                         }
                         else
                         {
                             if (GetAsyncKeyState(bindings) < 0 && Click == true)
                             {
                                 Thread.Sleep(100);
                                 Click = false;
                                // AC.Suspend(); //Suspende el proceso autoclicker. Esto hace que no se esté ejecutando constantemente sin hacer nada
                                AC.Interrupt();

                                //MessageBox.Show("inactivo");
                                IndicadorDeActividad.ForeColor = Color.OrangeRed;
                                 IndicadorDeActividad.Text = "| INACTIVO |";
                             }
                             else if (GetAsyncKeyState(bindings) < 0 && Click == false)
                             {
                                 Thread.Sleep(100);
                                 //MessageBox.Show("activo");
                                 CountClicks = 0;
                                 Click = true;
                                AC.Resume(); //Reanuda el proceso deautoclicker
                                IndicadorDeActividad.ForeColor = Color.Lime;
                                 IndicadorDeActividad.Text = "| ACTIVO |";
                             }
                         }
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
                //MessageBox.Show(KeyAsignada.ToString());
                if (KeyAsigned.Text != "..." && KeyAsigned.Text != "none")
                {
                    bindings = (Keys)Key.ConvertFromString(KeyAsigned.Text);
                }
                //MessageBox.Show(bindings.ToString());

            }
            
        }

        private void ActivadorClick_CheckedChanged(object sender, EventArgs e)
        {
            if (ActivadorClick.Checked)
            {//Activo
                ActivadorClick.BackColor = Color.LimeGreen;
                //ActivadorClick.ForeColor = Color.Black;
                ActivadorClick.Text = "HABILITADO";
                CambiarBoton.Enabled = false;
                //ControlActivate.Enabled = false;
                //ShiftActivate.Enabled = false;
                CPSIngreser.Enabled = false;
                CheckActivar.Enabled = false;
            }
            else
            {//Inactivo
                ActivadorClick.BackColor = Color.Maroon;
                //ActivadorClick.ForeColor = Color.White;
                ActivadorClick.Text = "INHABILITADO";
                CambiarBoton.Enabled = true;
                //ControlActivate.Enabled = true;
                //ShiftActivate.Enabled = true;
                CPSIngreser.Enabled = true;
                CheckActivar.Enabled = true;
            }
        }

       


        private void Actualizador_Tick(object sender, EventArgs e)
        {
            //ContadorClickL = MH.ClI;
          //  MessageBox.Show("escritura de la variable ContadorClickL al contador ClickIzquierdo");
            ClicksIzquierdoCont.Text = ContadorClickL.ToString();

            //ContadorClickR = MH.ClD;
            //MessageBox.Show("escritura de la variable ContadorClickR al contador ClickDerecho");
            ClicksDerechoCont.Text = ContadorClickR.ToString();

            //ContadorClickM = MH.CMR;
           // MessageBox.Show("escritura de la variable ContadorClickM al contador ClickCentral");
            ClicksCentralCont.Text = ContadorClickM.ToString();

           // MessageBox.Show("escritura de la variable ContadorRueda al contador ticsrueda");
            ContadorRueda = MH.RdR;
            RuedaRatonCont.Text = ContadorRueda.ToString();


            //ContadorClickXB1 = MH.BX1;
            ClicksExtra1Cont.Text = ContadorClickXB1.ToString();

            //ContadorClickXB2 = MH.BX2;
            ClicksExtra2Cont.Text = ContadorClickXB2.ToString();

            PulsacionTeclaCont.Text = ContadorTeclas.ToString();
            // 1º linea ClicksIzquirdos
            // 2º linea ClicksDerechos
            // 3º linea ClicksCentrales
            // 4º linea TicsRueda
            // 5º linea ClicksX1
            // 6º linea ClicksX2
            // 7º linea PulsacionesTeclado

            //Actualizador de datos en el archivo
            EscrituraDeDatos();

        }

        
        private void EscrituraDeDatos()
        {
            if (File.Exists("C:\\juegos\\Info.txt")) //Comprueba si el archivo existe
            {
                StreamWriter stream = new StreamWriter("C:\\juegos\\Info.txt");
                stream.WriteLine(ContadorClickL.ToString());
                stream.WriteLine(ContadorClickR.ToString());
                stream.WriteLine(ContadorClickM.ToString());
                stream.WriteLine(ContadorRueda.ToString());
                stream.WriteLine(ContadorClickXB1.ToString());
                stream.WriteLine(ContadorClickXB2.ToString());
                stream.WriteLine(ContadorTeclas.ToString());

                stream.Close();

            }
            
        }
    }
}


// Material de conocimientos
/*
 * Autocliker
 * https://www.youtube.com/watch?v=-DqX8fT1DrA
 * https://www.youtube.com/watch?v=LSDceJ3197Q
 * 
 * https://www.youtube.com/watch?v=Ax2eHqB8WGo
 * 
 * 
 * Detectar teclas
 * https://www.youtube.com/watch?v=rZPw87iGdLo
 * https://www.youtube.com/watch?v=-2sypfmYXD4
 * 
 * 
 * Detectar Mouse
 * https://www.youtube.com/watch?v=yYMtqatuqxg&t=17s
 * https://www.youtube.com/watch?v=tA9r95ZxZGI
 * 
 * 
 * https://gist.github.com/Dalgona/275ebc861eeac74c1a8d9d437d220f3b
 * 
 * 
 * TEST DE VELOCIDAD DE AUTOCLICKER
 * https://www.arealme.com/click-speed-test/es/
 * 
 * 
 * DETECTAR XBUTTON1 y XBUTTON2
 * https://www.codeproject.com/Articles/14016/Handling-Keyboard-and-Mouse-Application-Buttons-in#revisionhistory
 * https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-appcommand
 * 
 * 
 * 
 * 
 */