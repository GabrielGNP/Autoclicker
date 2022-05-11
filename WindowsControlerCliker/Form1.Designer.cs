
namespace WindowsControlerCliker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CambiarBoton = new System.Windows.Forms.Button();
            this.AutoCliker = new System.Windows.Forms.GroupBox();
            this.ControlActivate = new System.Windows.Forms.CheckBox();
            this.ShiftActivate = new System.Windows.Forms.CheckBox();
            this.CPSIngreser = new System.Windows.Forms.NumericUpDown();
            this.ClicksHechos = new System.Windows.Forms.Label();
            this.CheckActivar = new System.Windows.Forms.CheckBox();
            this.CheckMantener = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IndicadorDeActividad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.ActivadorClick = new System.Windows.Forms.CheckBox();
            this.KeyAsigned = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RuedaRatonCont = new System.Windows.Forms.Label();
            this.ClicksExtra2Cont = new System.Windows.Forms.Label();
            this.ClicksExtra1Cont = new System.Windows.Forms.Label();
            this.ClicksCentralCont = new System.Windows.Forms.Label();
            this.PulsacionTeclaCont = new System.Windows.Forms.Label();
            this.ClicksDerechoCont = new System.Windows.Forms.Label();
            this.ClicksIzquierdoCont = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CoordY = new System.Windows.Forms.Label();
            this.CoordX = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Actualizador = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AutoCliker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIngreser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CambiarBoton
            // 
            this.CambiarBoton.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarBoton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CambiarBoton.Location = new System.Drawing.Point(7, 24);
            this.CambiarBoton.Name = "CambiarBoton";
            this.CambiarBoton.Size = new System.Drawing.Size(101, 23);
            this.CambiarBoton.TabIndex = 0;
            this.CambiarBoton.Text = "Boton de Inicio";
            this.CambiarBoton.UseVisualStyleBackColor = true;
            this.CambiarBoton.Click += new System.EventHandler(this.CambiarBoton_Click);
            // 
            // AutoCliker
            // 
            this.AutoCliker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AutoCliker.Controls.Add(this.ControlActivate);
            this.AutoCliker.Controls.Add(this.ShiftActivate);
            this.AutoCliker.Controls.Add(this.CPSIngreser);
            this.AutoCliker.Controls.Add(this.ClicksHechos);
            this.AutoCliker.Controls.Add(this.CheckActivar);
            this.AutoCliker.Controls.Add(this.CheckMantener);
            this.AutoCliker.Controls.Add(this.label11);
            this.AutoCliker.Controls.Add(this.IndicadorDeActividad);
            this.AutoCliker.Controls.Add(this.label3);
            this.AutoCliker.Controls.Add(this.label211);
            this.AutoCliker.Controls.Add(this.ActivadorClick);
            this.AutoCliker.Controls.Add(this.KeyAsigned);
            this.AutoCliker.Controls.Add(this.CambiarBoton);
            this.AutoCliker.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCliker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AutoCliker.Location = new System.Drawing.Point(12, 12);
            this.AutoCliker.Name = "AutoCliker";
            this.AutoCliker.Size = new System.Drawing.Size(239, 426);
            this.AutoCliker.TabIndex = 1;
            this.AutoCliker.TabStop = false;
            this.AutoCliker.Text = "AutoCliker";
            // 
            // ControlActivate
            // 
            this.ControlActivate.AutoSize = true;
            this.ControlActivate.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlActivate.Location = new System.Drawing.Point(6, 52);
            this.ControlActivate.Name = "ControlActivate";
            this.ControlActivate.Size = new System.Drawing.Size(70, 19);
            this.ControlActivate.TabIndex = 16;
            this.ControlActivate.Text = "Control +";
            this.ControlActivate.UseVisualStyleBackColor = true;
            // 
            // ShiftActivate
            // 
            this.ShiftActivate.AutoSize = true;
            this.ShiftActivate.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftActivate.Location = new System.Drawing.Point(5, 71);
            this.ShiftActivate.Name = "ShiftActivate";
            this.ShiftActivate.Size = new System.Drawing.Size(56, 19);
            this.ShiftActivate.TabIndex = 15;
            this.ShiftActivate.Text = "Shift +";
            this.ShiftActivate.UseVisualStyleBackColor = true;
            // 
            // CPSIngreser
            // 
            this.CPSIngreser.Location = new System.Drawing.Point(5, 92);
            this.CPSIngreser.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.CPSIngreser.Name = "CPSIngreser";
            this.CPSIngreser.Size = new System.Drawing.Size(55, 22);
            this.CPSIngreser.TabIndex = 14;
            this.CPSIngreser.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CPSIngreser.ValueChanged += new System.EventHandler(this.CPSIngreser_ValueChanged);
            // 
            // ClicksHechos
            // 
            this.ClicksHechos.AutoSize = true;
            this.ClicksHechos.BackColor = System.Drawing.Color.Silver;
            this.ClicksHechos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksHechos.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksHechos.ForeColor = System.Drawing.Color.Blue;
            this.ClicksHechos.Location = new System.Drawing.Point(16, 208);
            this.ClicksHechos.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksHechos.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksHechos.Name = "ClicksHechos";
            this.ClicksHechos.Size = new System.Drawing.Size(100, 18);
            this.ClicksHechos.TabIndex = 12;
            this.ClicksHechos.Text = "0";
            this.ClicksHechos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CheckActivar
            // 
            this.CheckActivar.AutoSize = true;
            this.CheckActivar.Checked = true;
            this.CheckActivar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckActivar.Enabled = false;
            this.CheckActivar.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckActivar.Location = new System.Drawing.Point(101, 127);
            this.CheckActivar.Name = "CheckActivar";
            this.CheckActivar.Size = new System.Drawing.Size(60, 19);
            this.CheckActivar.TabIndex = 11;
            this.CheckActivar.Text = "Activar";
            this.CheckActivar.UseVisualStyleBackColor = true;
            // 
            // CheckMantener
            // 
            this.CheckMantener.AutoSize = true;
            this.CheckMantener.Enabled = false;
            this.CheckMantener.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMantener.Location = new System.Drawing.Point(5, 127);
            this.CheckMantener.Name = "CheckMantener";
            this.CheckMantener.Size = new System.Drawing.Size(72, 19);
            this.CheckMantener.TabIndex = 10;
            this.CheckMantener.Text = "Mantener";
            this.CheckMantener.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(122, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Pulsaciones Hechas";
            // 
            // IndicadorDeActividad
            // 
            this.IndicadorDeActividad.AutoSize = true;
            this.IndicadorDeActividad.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndicadorDeActividad.ForeColor = System.Drawing.Color.OrangeRed;
            this.IndicadorDeActividad.Location = new System.Drawing.Point(77, 182);
            this.IndicadorDeActividad.Name = "IndicadorDeActividad";
            this.IndicadorDeActividad.Size = new System.Drawing.Size(71, 15);
            this.IndicadorDeActividad.TabIndex = 6;
            this.IndicadorDeActividad.Text = "| INACTIVO |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPS";
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label211.Location = new System.Drawing.Point(68, 92);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(104, 15);
            this.label211.TabIndex = 4;
            this.label211.Text = "Frecuencia de Clics";
            // 
            // ActivadorClick
            // 
            this.ActivadorClick.Appearance = System.Windows.Forms.Appearance.Button;
            this.ActivadorClick.AutoSize = true;
            this.ActivadorClick.BackColor = System.Drawing.Color.Maroon;
            this.ActivadorClick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ActivadorClick.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivadorClick.ForeColor = System.Drawing.Color.Black;
            this.ActivadorClick.Location = new System.Drawing.Point(9, 149);
            this.ActivadorClick.Margin = new System.Windows.Forms.Padding(0);
            this.ActivadorClick.MaximumSize = new System.Drawing.Size(220, 25);
            this.ActivadorClick.MinimumSize = new System.Drawing.Size(220, 25);
            this.ActivadorClick.Name = "ActivadorClick";
            this.ActivadorClick.Size = new System.Drawing.Size(220, 25);
            this.ActivadorClick.TabIndex = 2;
            this.ActivadorClick.Text = "INHABILITADO";
            this.ActivadorClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActivadorClick.UseVisualStyleBackColor = false;
            this.ActivadorClick.CheckedChanged += new System.EventHandler(this.ActivadorClick_CheckedChanged);
            // 
            // KeyAsigned
            // 
            this.KeyAsigned.AutoSize = true;
            this.KeyAsigned.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyAsigned.Location = new System.Drawing.Point(75, 63);
            this.KeyAsigned.Name = "KeyAsigned";
            this.KeyAsigned.Size = new System.Drawing.Size(31, 15);
            this.KeyAsigned.TabIndex = 1;
            this.KeyAsigned.Text = "none";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RuedaRatonCont);
            this.groupBox1.Controls.Add(this.ClicksExtra2Cont);
            this.groupBox1.Controls.Add(this.ClicksExtra1Cont);
            this.groupBox1.Controls.Add(this.ClicksCentralCont);
            this.groupBox1.Controls.Add(this.PulsacionTeclaCont);
            this.groupBox1.Controls.Add(this.ClicksDerechoCont);
            this.groupBox1.Controls.Add(this.ClicksIzquierdoCont);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CoordY);
            this.groupBox1.Controls.Add(this.CoordX);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(257, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Rueda del Raton";
            // 
            // RuedaRatonCont
            // 
            this.RuedaRatonCont.AutoSize = true;
            this.RuedaRatonCont.BackColor = System.Drawing.Color.Silver;
            this.RuedaRatonCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RuedaRatonCont.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuedaRatonCont.ForeColor = System.Drawing.Color.Blue;
            this.RuedaRatonCont.Location = new System.Drawing.Point(16, 97);
            this.RuedaRatonCont.MaximumSize = new System.Drawing.Size(100, 18);
            this.RuedaRatonCont.MinimumSize = new System.Drawing.Size(100, 18);
            this.RuedaRatonCont.Name = "RuedaRatonCont";
            this.RuedaRatonCont.Size = new System.Drawing.Size(100, 18);
            this.RuedaRatonCont.TabIndex = 31;
            this.RuedaRatonCont.Text = "0";
            this.RuedaRatonCont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClicksExtra2Cont
            // 
            this.ClicksExtra2Cont.AutoSize = true;
            this.ClicksExtra2Cont.BackColor = System.Drawing.Color.Silver;
            this.ClicksExtra2Cont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksExtra2Cont.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksExtra2Cont.ForeColor = System.Drawing.Color.Blue;
            this.ClicksExtra2Cont.Location = new System.Drawing.Point(16, 143);
            this.ClicksExtra2Cont.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksExtra2Cont.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksExtra2Cont.Name = "ClicksExtra2Cont";
            this.ClicksExtra2Cont.Size = new System.Drawing.Size(100, 18);
            this.ClicksExtra2Cont.TabIndex = 30;
            this.ClicksExtra2Cont.Text = "0";
            this.ClicksExtra2Cont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClicksExtra1Cont
            // 
            this.ClicksExtra1Cont.AutoSize = true;
            this.ClicksExtra1Cont.BackColor = System.Drawing.Color.Silver;
            this.ClicksExtra1Cont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksExtra1Cont.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksExtra1Cont.ForeColor = System.Drawing.Color.Blue;
            this.ClicksExtra1Cont.Location = new System.Drawing.Point(16, 120);
            this.ClicksExtra1Cont.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksExtra1Cont.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksExtra1Cont.Name = "ClicksExtra1Cont";
            this.ClicksExtra1Cont.Size = new System.Drawing.Size(100, 18);
            this.ClicksExtra1Cont.TabIndex = 29;
            this.ClicksExtra1Cont.Text = "0";
            this.ClicksExtra1Cont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClicksCentralCont
            // 
            this.ClicksCentralCont.AutoSize = true;
            this.ClicksCentralCont.BackColor = System.Drawing.Color.Silver;
            this.ClicksCentralCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksCentralCont.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksCentralCont.ForeColor = System.Drawing.Color.Blue;
            this.ClicksCentralCont.Location = new System.Drawing.Point(16, 74);
            this.ClicksCentralCont.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksCentralCont.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksCentralCont.Name = "ClicksCentralCont";
            this.ClicksCentralCont.Size = new System.Drawing.Size(100, 18);
            this.ClicksCentralCont.TabIndex = 28;
            this.ClicksCentralCont.Text = "0";
            this.ClicksCentralCont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PulsacionTeclaCont
            // 
            this.PulsacionTeclaCont.AutoSize = true;
            this.PulsacionTeclaCont.BackColor = System.Drawing.Color.Silver;
            this.PulsacionTeclaCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PulsacionTeclaCont.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulsacionTeclaCont.ForeColor = System.Drawing.Color.Blue;
            this.PulsacionTeclaCont.Location = new System.Drawing.Point(276, 32);
            this.PulsacionTeclaCont.MaximumSize = new System.Drawing.Size(100, 18);
            this.PulsacionTeclaCont.MinimumSize = new System.Drawing.Size(100, 18);
            this.PulsacionTeclaCont.Name = "PulsacionTeclaCont";
            this.PulsacionTeclaCont.Size = new System.Drawing.Size(100, 18);
            this.PulsacionTeclaCont.TabIndex = 27;
            this.PulsacionTeclaCont.Text = "0";
            this.PulsacionTeclaCont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClicksDerechoCont
            // 
            this.ClicksDerechoCont.AutoSize = true;
            this.ClicksDerechoCont.BackColor = System.Drawing.Color.Silver;
            this.ClicksDerechoCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksDerechoCont.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksDerechoCont.ForeColor = System.Drawing.Color.Blue;
            this.ClicksDerechoCont.Location = new System.Drawing.Point(16, 51);
            this.ClicksDerechoCont.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksDerechoCont.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksDerechoCont.Name = "ClicksDerechoCont";
            this.ClicksDerechoCont.Size = new System.Drawing.Size(100, 18);
            this.ClicksDerechoCont.TabIndex = 26;
            this.ClicksDerechoCont.Text = "0";
            this.ClicksDerechoCont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClicksIzquierdoCont
            // 
            this.ClicksIzquierdoCont.AutoSize = true;
            this.ClicksIzquierdoCont.BackColor = System.Drawing.Color.Silver;
            this.ClicksIzquierdoCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksIzquierdoCont.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksIzquierdoCont.ForeColor = System.Drawing.Color.Blue;
            this.ClicksIzquierdoCont.Location = new System.Drawing.Point(16, 28);
            this.ClicksIzquierdoCont.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksIzquierdoCont.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksIzquierdoCont.Name = "ClicksIzquierdoCont";
            this.ClicksIzquierdoCont.Size = new System.Drawing.Size(100, 18);
            this.ClicksIzquierdoCont.TabIndex = 25;
            this.ClicksIzquierdoCont.Text = "0";
            this.ClicksIzquierdoCont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(123, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Coordenada Y";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(123, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Coordenada X";
            this.label16.Visible = false;
            // 
            // CoordY
            // 
            this.CoordY.AutoSize = true;
            this.CoordY.BackColor = System.Drawing.Color.Silver;
            this.CoordY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoordY.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordY.ForeColor = System.Drawing.Color.Blue;
            this.CoordY.Location = new System.Drawing.Point(16, 205);
            this.CoordY.MaximumSize = new System.Drawing.Size(100, 18);
            this.CoordY.MinimumSize = new System.Drawing.Size(100, 18);
            this.CoordY.Name = "CoordY";
            this.CoordY.Size = new System.Drawing.Size(100, 18);
            this.CoordY.TabIndex = 22;
            this.CoordY.Text = "label14";
            this.CoordY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CoordY.Visible = false;
            // 
            // CoordX
            // 
            this.CoordX.AutoSize = true;
            this.CoordX.BackColor = System.Drawing.Color.Silver;
            this.CoordX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoordX.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordX.ForeColor = System.Drawing.Color.Blue;
            this.CoordX.Location = new System.Drawing.Point(16, 178);
            this.CoordX.MaximumSize = new System.Drawing.Size(100, 18);
            this.CoordX.MinimumSize = new System.Drawing.Size(100, 18);
            this.CoordX.Name = "CoordX";
            this.CoordX.Size = new System.Drawing.Size(100, 18);
            this.CoordX.TabIndex = 13;
            this.CoordX.Text = "label13";
            this.CoordX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CoordX.Visible = false;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(6, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Editar Estilos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(6, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Editar Valores";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(122, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Reiniciar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(122, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Guardar en .txt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Clics extra 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Clics extra 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Clics Central";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pulsaciones de teclado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clics Derecho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clics Izquierdo";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 70);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // Actualizador
            // 
            this.Actualizador.Interval = 10;
            this.Actualizador.Tick += new System.EventHandler(this.Actualizador_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(670, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AutoCliker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "StadisticsInputs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.AutoCliker.ResumeLayout(false);
            this.AutoCliker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPSIngreser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CambiarBoton;
        private System.Windows.Forms.GroupBox AutoCliker;
        private System.Windows.Forms.Label KeyAsigned;
        private System.Windows.Forms.CheckBox ActivadorClick;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.Label IndicadorDeActividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CheckActivar;
        private System.Windows.Forms.CheckBox CheckMantener;
        private System.Windows.Forms.Label ClicksHechos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CoordY;
        private System.Windows.Forms.Label CoordX;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown CPSIngreser;
        private System.Windows.Forms.Label ClicksDerechoCont;
        private System.Windows.Forms.Label ClicksIzquierdoCont;
        private System.Windows.Forms.Label PulsacionTeclaCont;
        private System.Windows.Forms.Label ClicksCentralCont;
        private System.Windows.Forms.Label ClicksExtra1Cont;
        private System.Windows.Forms.Label ClicksExtra2Cont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RuedaRatonCont;
        private System.Windows.Forms.Timer Actualizador;
        private System.Windows.Forms.CheckBox ControlActivate;
        private System.Windows.Forms.CheckBox ShiftActivate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

