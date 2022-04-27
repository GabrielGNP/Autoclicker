
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
            this.CPS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CPSIngreser = new System.Windows.Forms.NumericUpDown();
            this.ClicksHechos = new System.Windows.Forms.Label();
            this.CheckActivar = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IndicadorDeActividad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.ActivadorClick = new System.Windows.Forms.CheckBox();
            this.KeyAsigned = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClicksDerecho = new System.Windows.Forms.Label();
            this.ClicksIzquierdo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CoordY = new System.Windows.Forms.Label();
            this.CoordX = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3111 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DetectorTeclas = new System.ComponentModel.BackgroundWorker();
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
            this.AutoCliker.Controls.Add(this.CPS);
            this.AutoCliker.Controls.Add(this.label1);
            this.AutoCliker.Controls.Add(this.CPSIngreser);
            this.AutoCliker.Controls.Add(this.ClicksHechos);
            this.AutoCliker.Controls.Add(this.CheckActivar);
            this.AutoCliker.Controls.Add(this.checkBox2);
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
            // CPS
            // 
            this.CPS.AutoSize = true;
            this.CPS.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPS.Location = new System.Drawing.Point(69, 226);
            this.CPS.Name = "CPS";
            this.CPS.Size = new System.Drawing.Size(13, 15);
            this.CPS.TabIndex = 28;
            this.CPS.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "CPS";
            // 
            // CPSIngreser
            // 
            this.CPSIngreser.Location = new System.Drawing.Point(6, 115);
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
            this.ClicksHechos.Location = new System.Drawing.Point(7, 195);
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
            this.CheckActivar.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckActivar.Location = new System.Drawing.Point(85, 82);
            this.CheckActivar.Name = "CheckActivar";
            this.CheckActivar.Size = new System.Drawing.Size(60, 19);
            this.CheckActivar.TabIndex = 11;
            this.CheckActivar.Text = "Activar";
            this.CheckActivar.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(7, 82);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 19);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Mantener";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(113, 196);
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
            this.IndicadorDeActividad.Location = new System.Drawing.Point(68, 169);
            this.IndicadorDeActividad.Name = "IndicadorDeActividad";
            this.IndicadorDeActividad.Size = new System.Drawing.Size(71, 15);
            this.IndicadorDeActividad.TabIndex = 6;
            this.IndicadorDeActividad.Text = "| INACTIVO |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPS";
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label211.Location = new System.Drawing.Point(69, 115);
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
            this.ActivadorClick.Location = new System.Drawing.Point(9, 51);
            this.ActivadorClick.Margin = new System.Windows.Forms.Padding(0);
            this.ActivadorClick.MaximumSize = new System.Drawing.Size(77, 25);
            this.ActivadorClick.MinimumSize = new System.Drawing.Size(77, 25);
            this.ActivadorClick.Name = "ActivadorClick";
            this.ActivadorClick.Size = new System.Drawing.Size(77, 25);
            this.ActivadorClick.TabIndex = 2;
            this.ActivadorClick.Text = "INACTIVO";
            this.ActivadorClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActivadorClick.UseVisualStyleBackColor = false;
            this.ActivadorClick.CheckedChanged += new System.EventHandler(this.ActivadorClick_CheckedChanged);
            // 
            // KeyAsigned
            // 
            this.KeyAsigned.AutoSize = true;
            this.KeyAsigned.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyAsigned.Location = new System.Drawing.Point(113, 25);
            this.KeyAsigned.Name = "KeyAsigned";
            this.KeyAsigned.Size = new System.Drawing.Size(31, 15);
            this.KeyAsigned.TabIndex = 1;
            this.KeyAsigned.Text = "none";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.ClicksDerecho);
            this.groupBox1.Controls.Add(this.ClicksIzquierdo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CoordY);
            this.groupBox1.Controls.Add(this.CoordX);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3111);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(257, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contador";
            // 
            // ClicksDerecho
            // 
            this.ClicksDerecho.AutoSize = true;
            this.ClicksDerecho.BackColor = System.Drawing.Color.Silver;
            this.ClicksDerecho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksDerecho.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksDerecho.ForeColor = System.Drawing.Color.Blue;
            this.ClicksDerecho.Location = new System.Drawing.Point(16, 51);
            this.ClicksDerecho.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksDerecho.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksDerecho.Name = "ClicksDerecho";
            this.ClicksDerecho.Size = new System.Drawing.Size(100, 18);
            this.ClicksDerecho.TabIndex = 26;
            this.ClicksDerecho.Text = "0";
            this.ClicksDerecho.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClicksIzquierdo
            // 
            this.ClicksIzquierdo.AutoSize = true;
            this.ClicksIzquierdo.BackColor = System.Drawing.Color.Silver;
            this.ClicksIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClicksIzquierdo.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicksIzquierdo.ForeColor = System.Drawing.Color.Blue;
            this.ClicksIzquierdo.Location = new System.Drawing.Point(16, 28);
            this.ClicksIzquierdo.MaximumSize = new System.Drawing.Size(100, 18);
            this.ClicksIzquierdo.MinimumSize = new System.Drawing.Size(100, 18);
            this.ClicksIzquierdo.Name = "ClicksIzquierdo";
            this.ClicksIzquierdo.Size = new System.Drawing.Size(100, 18);
            this.ClicksIzquierdo.TabIndex = 25;
            this.ClicksIzquierdo.Text = "0";
            this.ClicksIzquierdo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(123, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Coordenada Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(123, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Coordenada X";
            // 
            // CoordY
            // 
            this.CoordY.AutoSize = true;
            this.CoordY.BackColor = System.Drawing.Color.Silver;
            this.CoordY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoordY.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordY.ForeColor = System.Drawing.Color.Blue;
            this.CoordY.Location = new System.Drawing.Point(16, 196);
            this.CoordY.MaximumSize = new System.Drawing.Size(100, 18);
            this.CoordY.MinimumSize = new System.Drawing.Size(100, 18);
            this.CoordY.Name = "CoordY";
            this.CoordY.Size = new System.Drawing.Size(100, 18);
            this.CoordY.TabIndex = 22;
            this.CoordY.Text = "label14";
            this.CoordY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CoordX
            // 
            this.CoordX.AutoSize = true;
            this.CoordX.BackColor = System.Drawing.Color.Silver;
            this.CoordX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoordX.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordX.ForeColor = System.Drawing.Color.Blue;
            this.CoordX.Location = new System.Drawing.Point(16, 169);
            this.CoordX.MaximumSize = new System.Drawing.Size(100, 18);
            this.CoordX.MinimumSize = new System.Drawing.Size(100, 18);
            this.CoordX.Name = "CoordX";
            this.CoordX.Size = new System.Drawing.Size(100, 18);
            this.CoordX.TabIndex = 13;
            this.CoordX.Text = "label13";
            this.CoordX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(183, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Editar Estilos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(299, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Editar Valores";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(415, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Reiniciar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(6, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Guardar en .txt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Clics extra 2";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Blue;
            this.textBox6.Location = new System.Drawing.Point(16, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "10000";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Clics extra 1";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Blue;
            this.textBox5.Location = new System.Drawing.Point(16, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "10000";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(122, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Clics Central";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Blue;
            this.textBox4.Location = new System.Drawing.Point(16, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "10000";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pulsaciones de teclado";
            // 
            // textBox3111
            // 
            this.textBox3111.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3111.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3111.ForeColor = System.Drawing.Color.Blue;
            this.textBox3111.Location = new System.Drawing.Point(276, 29);
            this.textBox3111.Name = "textBox3111";
            this.textBox3111.Size = new System.Drawing.Size(100, 22);
            this.textBox3111.TabIndex = 10;
            this.textBox3111.Text = "100000";
            this.textBox3111.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 51);
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DetectorTeclas
            // 
            this.DetectorTeclas.WorkerReportsProgress = true;
            this.DetectorTeclas.WorkerSupportsCancellation = true;
            this.DetectorTeclas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DetectorTeclas_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AutoCliker);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3111;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CheckActivar;
        private System.Windows.Forms.CheckBox checkBox2;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown CPSIngreser;
        private System.Windows.Forms.Label CPS;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker DetectorTeclas;
        private System.Windows.Forms.Label ClicksDerecho;
        private System.Windows.Forms.Label ClicksIzquierdo;
    }
}

