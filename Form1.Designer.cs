namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.crearLuz = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTermostato = new System.Windows.Forms.Label();
            this.lblPersiana = new System.Windows.Forms.Label();
            this.crearTermostato = new System.Windows.Forms.Button();
            this.crearPersiana = new System.Windows.Forms.Button();
            this.btnTermostatoOff = new System.Windows.Forms.Button();
            this.btnPersianaOff = new System.Windows.Forms.Button();
            this.txtTermostatoOn = new System.Windows.Forms.TextBox();
            this.btnTermostatoOn = new System.Windows.Forms.Button();
            this.txtPersianaOn = new System.Windows.Forms.TextBox();
            this.lblTermostatoOn = new System.Windows.Forms.Label();
            this.btnPersianaOn = new System.Windows.Forms.Button();
            this.lblTermostatoOff = new System.Windows.Forms.Label();
            this.lblPersianaOn = new System.Windows.Forms.Label();
            this.txtTermostatoOff = new System.Windows.Forms.TextBox();
            this.lblPersianaOff = new System.Windows.Forms.Label();
            this.txtPersianaOff = new System.Windows.Forms.TextBox();
            this.lblRgb = new System.Windows.Forms.Label();
            this.lblLuz = new System.Windows.Forms.Label();
            this.crearRgb = new System.Windows.Forms.Button();
            this.btnRgbOff = new System.Windows.Forms.Button();
            this.btnLuzOff = new System.Windows.Forms.Button();
            this.txtRgbOn = new System.Windows.Forms.TextBox();
            this.btnRgbOn = new System.Windows.Forms.Button();
            this.txtLuzOn = new System.Windows.Forms.TextBox();
            this.lblRgbOn = new System.Windows.Forms.Label();
            this.btnLuzOn = new System.Windows.Forms.Button();
            this.lblRgbOff = new System.Windows.Forms.Label();
            this.lblLuzOn = new System.Windows.Forms.Label();
            this.txtRgbOff = new System.Windows.Forms.TextBox();
            this.lblLuzOff = new System.Windows.Forms.Label();
            this.txtLuzOff = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.imgFondo = new System.Windows.Forms.PictureBox();
            this.btnFondo = new System.Windows.Forms.Button();
            this.lblLocationY = new System.Windows.Forms.Label();
            this.txtLocationY = new System.Windows.Forms.TextBox();
            this.lblLocationX = new System.Windows.Forms.Label();
            this.txtLocationX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // crearLuz
            // 
            this.crearLuz.Enabled = false;
            this.crearLuz.Location = new System.Drawing.Point(83, 22);
            this.crearLuz.Name = "crearLuz";
            this.crearLuz.Size = new System.Drawing.Size(40, 40);
            this.crearLuz.TabIndex = 6;
            this.crearLuz.UseVisualStyleBackColor = true;
            this.crearLuz.Click += new System.EventHandler(this.crearLuz_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTipo.Location = new System.Drawing.Point(528, 618);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(149, 20);
            this.txtTipo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTermostato);
            this.groupBox1.Controls.Add(this.lblPersiana);
            this.groupBox1.Controls.Add(this.crearTermostato);
            this.groupBox1.Controls.Add(this.crearPersiana);
            this.groupBox1.Controls.Add(this.btnTermostatoOff);
            this.groupBox1.Controls.Add(this.btnPersianaOff);
            this.groupBox1.Controls.Add(this.txtTermostatoOn);
            this.groupBox1.Controls.Add(this.btnTermostatoOn);
            this.groupBox1.Controls.Add(this.txtPersianaOn);
            this.groupBox1.Controls.Add(this.lblTermostatoOn);
            this.groupBox1.Controls.Add(this.btnPersianaOn);
            this.groupBox1.Controls.Add(this.lblTermostatoOff);
            this.groupBox1.Controls.Add(this.lblPersianaOn);
            this.groupBox1.Controls.Add(this.txtTermostatoOff);
            this.groupBox1.Controls.Add(this.lblPersianaOff);
            this.groupBox1.Controls.Add(this.txtPersianaOff);
            this.groupBox1.Controls.Add(this.lblRgb);
            this.groupBox1.Controls.Add(this.lblLuz);
            this.groupBox1.Controls.Add(this.crearRgb);
            this.groupBox1.Controls.Add(this.crearLuz);
            this.groupBox1.Controls.Add(this.btnRgbOff);
            this.groupBox1.Controls.Add(this.btnLuzOff);
            this.groupBox1.Controls.Add(this.txtRgbOn);
            this.groupBox1.Controls.Add(this.btnRgbOn);
            this.groupBox1.Controls.Add(this.txtLuzOn);
            this.groupBox1.Controls.Add(this.lblRgbOn);
            this.groupBox1.Controls.Add(this.btnLuzOn);
            this.groupBox1.Controls.Add(this.lblRgbOff);
            this.groupBox1.Controls.Add(this.lblLuzOn);
            this.groupBox1.Controls.Add(this.txtRgbOff);
            this.groupBox1.Controls.Add(this.lblLuzOff);
            this.groupBox1.Controls.Add(this.txtLuzOff);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 600);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dispositivos";
            // 
            // lblTermostato
            // 
            this.lblTermostato.AutoSize = true;
            this.lblTermostato.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermostato.Location = new System.Drawing.Point(6, 233);
            this.lblTermostato.Name = "lblTermostato";
            this.lblTermostato.Size = new System.Drawing.Size(71, 14);
            this.lblTermostato.TabIndex = 37;
            this.lblTermostato.Text = "Termostato";
            // 
            // lblPersiana
            // 
            this.lblPersiana.AutoSize = true;
            this.lblPersiana.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersiana.Location = new System.Drawing.Point(6, 167);
            this.lblPersiana.Name = "lblPersiana";
            this.lblPersiana.Size = new System.Drawing.Size(55, 14);
            this.lblPersiana.TabIndex = 28;
            this.lblPersiana.Text = "Persiana";
            // 
            // crearTermostato
            // 
            this.crearTermostato.Enabled = false;
            this.crearTermostato.Location = new System.Drawing.Point(83, 219);
            this.crearTermostato.Name = "crearTermostato";
            this.crearTermostato.Size = new System.Drawing.Size(40, 40);
            this.crearTermostato.TabIndex = 36;
            this.crearTermostato.UseVisualStyleBackColor = true;
            this.crearTermostato.Click += new System.EventHandler(this.crearTermostato_Click);
            // 
            // crearPersiana
            // 
            this.crearPersiana.Enabled = false;
            this.crearPersiana.Location = new System.Drawing.Point(83, 153);
            this.crearPersiana.Name = "crearPersiana";
            this.crearPersiana.Size = new System.Drawing.Size(40, 40);
            this.crearPersiana.TabIndex = 29;
            this.crearPersiana.UseVisualStyleBackColor = true;
            this.crearPersiana.Click += new System.EventHandler(this.crearPersiana_Click);
            // 
            // btnTermostatoOff
            // 
            this.btnTermostatoOff.Enabled = false;
            this.btnTermostatoOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermostatoOff.Location = new System.Drawing.Point(359, 242);
            this.btnTermostatoOff.Name = "btnTermostatoOff";
            this.btnTermostatoOff.Size = new System.Drawing.Size(91, 20);
            this.btnTermostatoOff.TabIndex = 43;
            this.btnTermostatoOff.Text = "Seleccionar";
            this.btnTermostatoOff.UseVisualStyleBackColor = true;
            this.btnTermostatoOff.MouseEnter += new System.EventHandler(this.btnTermostatoOff_MouseEnter);
            // 
            // btnPersianaOff
            // 
            this.btnPersianaOff.Enabled = false;
            this.btnPersianaOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersianaOff.Location = new System.Drawing.Point(359, 176);
            this.btnPersianaOff.Name = "btnPersianaOff";
            this.btnPersianaOff.Size = new System.Drawing.Size(91, 20);
            this.btnPersianaOff.TabIndex = 35;
            this.btnPersianaOff.Text = "Seleccionar";
            this.btnPersianaOff.UseVisualStyleBackColor = true;
            this.btnPersianaOff.MouseEnter += new System.EventHandler(this.btnPersianaOff_MouseEnter);
            // 
            // txtTermostatoOn
            // 
            this.txtTermostatoOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtTermostatoOn.Enabled = false;
            this.txtTermostatoOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermostatoOn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTermostatoOn.Location = new System.Drawing.Point(204, 216);
            this.txtTermostatoOn.Name = "txtTermostatoOn";
            this.txtTermostatoOn.ReadOnly = true;
            this.txtTermostatoOn.Size = new System.Drawing.Size(149, 20);
            this.txtTermostatoOn.TabIndex = 39;
            // 
            // btnTermostatoOn
            // 
            this.btnTermostatoOn.Enabled = false;
            this.btnTermostatoOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermostatoOn.Location = new System.Drawing.Point(359, 216);
            this.btnTermostatoOn.Name = "btnTermostatoOn";
            this.btnTermostatoOn.Size = new System.Drawing.Size(91, 20);
            this.btnTermostatoOn.TabIndex = 42;
            this.btnTermostatoOn.Text = "Seleccionar";
            this.btnTermostatoOn.UseVisualStyleBackColor = true;
            this.btnTermostatoOn.MouseEnter += new System.EventHandler(this.btnTermostatoOn_MouseEnter);
            // 
            // txtPersianaOn
            // 
            this.txtPersianaOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtPersianaOn.Enabled = false;
            this.txtPersianaOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersianaOn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPersianaOn.Location = new System.Drawing.Point(204, 150);
            this.txtPersianaOn.Name = "txtPersianaOn";
            this.txtPersianaOn.ReadOnly = true;
            this.txtPersianaOn.Size = new System.Drawing.Size(149, 20);
            this.txtPersianaOn.TabIndex = 31;
            // 
            // lblTermostatoOn
            // 
            this.lblTermostatoOn.AutoSize = true;
            this.lblTermostatoOn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermostatoOn.Location = new System.Drawing.Point(132, 219);
            this.lblTermostatoOn.Name = "lblTermostatoOn";
            this.lblTermostatoOn.Size = new System.Drawing.Size(69, 14);
            this.lblTermostatoOn.TabIndex = 38;
            this.lblTermostatoOn.Text = "Imagen On:";
            // 
            // btnPersianaOn
            // 
            this.btnPersianaOn.Enabled = false;
            this.btnPersianaOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersianaOn.Location = new System.Drawing.Point(359, 150);
            this.btnPersianaOn.Name = "btnPersianaOn";
            this.btnPersianaOn.Size = new System.Drawing.Size(91, 20);
            this.btnPersianaOn.TabIndex = 34;
            this.btnPersianaOn.Text = "Seleccionar";
            this.btnPersianaOn.UseVisualStyleBackColor = true;
            this.btnPersianaOn.MouseEnter += new System.EventHandler(this.btnPersianaOn_MouseEnter);
            // 
            // lblTermostatoOff
            // 
            this.lblTermostatoOff.AutoSize = true;
            this.lblTermostatoOff.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermostatoOff.Location = new System.Drawing.Point(132, 245);
            this.lblTermostatoOff.Name = "lblTermostatoOff";
            this.lblTermostatoOff.Size = new System.Drawing.Size(70, 14);
            this.lblTermostatoOff.TabIndex = 40;
            this.lblTermostatoOff.Text = "Imagen Off:";
            // 
            // lblPersianaOn
            // 
            this.lblPersianaOn.AutoSize = true;
            this.lblPersianaOn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersianaOn.Location = new System.Drawing.Point(132, 153);
            this.lblPersianaOn.Name = "lblPersianaOn";
            this.lblPersianaOn.Size = new System.Drawing.Size(69, 14);
            this.lblPersianaOn.TabIndex = 30;
            this.lblPersianaOn.Text = "Imagen On:";
            // 
            // txtTermostatoOff
            // 
            this.txtTermostatoOff.BackColor = System.Drawing.SystemColors.Control;
            this.txtTermostatoOff.Enabled = false;
            this.txtTermostatoOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermostatoOff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTermostatoOff.Location = new System.Drawing.Point(204, 242);
            this.txtTermostatoOff.Name = "txtTermostatoOff";
            this.txtTermostatoOff.ReadOnly = true;
            this.txtTermostatoOff.Size = new System.Drawing.Size(149, 20);
            this.txtTermostatoOff.TabIndex = 41;
            // 
            // lblPersianaOff
            // 
            this.lblPersianaOff.AutoSize = true;
            this.lblPersianaOff.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersianaOff.Location = new System.Drawing.Point(132, 179);
            this.lblPersianaOff.Name = "lblPersianaOff";
            this.lblPersianaOff.Size = new System.Drawing.Size(70, 14);
            this.lblPersianaOff.TabIndex = 32;
            this.lblPersianaOff.Text = "Imagen Off:";
            // 
            // txtPersianaOff
            // 
            this.txtPersianaOff.BackColor = System.Drawing.SystemColors.Control;
            this.txtPersianaOff.Enabled = false;
            this.txtPersianaOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersianaOff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPersianaOff.Location = new System.Drawing.Point(204, 176);
            this.txtPersianaOff.Name = "txtPersianaOff";
            this.txtPersianaOff.ReadOnly = true;
            this.txtPersianaOff.Size = new System.Drawing.Size(149, 20);
            this.txtPersianaOff.TabIndex = 33;
            // 
            // lblRgb
            // 
            this.lblRgb.AutoSize = true;
            this.lblRgb.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgb.Location = new System.Drawing.Point(6, 102);
            this.lblRgb.Name = "lblRgb";
            this.lblRgb.Size = new System.Drawing.Size(52, 14);
            this.lblRgb.TabIndex = 21;
            this.lblRgb.Text = "Luz RGB";
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuz.Location = new System.Drawing.Point(6, 36);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(68, 14);
            this.lblLuz.TabIndex = 5;
            this.lblLuz.Text = "Luz ON/OFF";
            // 
            // crearRgb
            // 
            this.crearRgb.Enabled = false;
            this.crearRgb.Location = new System.Drawing.Point(83, 88);
            this.crearRgb.Name = "crearRgb";
            this.crearRgb.Size = new System.Drawing.Size(40, 40);
            this.crearRgb.TabIndex = 20;
            this.crearRgb.UseVisualStyleBackColor = true;
            this.crearRgb.Click += new System.EventHandler(this.crearRgb_Click);
            // 
            // btnRgbOff
            // 
            this.btnRgbOff.Enabled = false;
            this.btnRgbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRgbOff.Location = new System.Drawing.Point(359, 111);
            this.btnRgbOff.Name = "btnRgbOff";
            this.btnRgbOff.Size = new System.Drawing.Size(91, 20);
            this.btnRgbOff.TabIndex = 27;
            this.btnRgbOff.Text = "Seleccionar";
            this.btnRgbOff.UseVisualStyleBackColor = true;
            this.btnRgbOff.MouseEnter += new System.EventHandler(this.btnRgbOff_MouseEnter);
            // 
            // btnLuzOff
            // 
            this.btnLuzOff.Enabled = false;
            this.btnLuzOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuzOff.Location = new System.Drawing.Point(359, 45);
            this.btnLuzOff.Name = "btnLuzOff";
            this.btnLuzOff.Size = new System.Drawing.Size(91, 20);
            this.btnLuzOff.TabIndex = 17;
            this.btnLuzOff.Text = "Seleccionar";
            this.btnLuzOff.UseVisualStyleBackColor = true;
            this.btnLuzOff.MouseEnter += new System.EventHandler(this.btnImagenOff_MouseEnter);
            // 
            // txtRgbOn
            // 
            this.txtRgbOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtRgbOn.Enabled = false;
            this.txtRgbOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgbOn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRgbOn.Location = new System.Drawing.Point(204, 85);
            this.txtRgbOn.Name = "txtRgbOn";
            this.txtRgbOn.ReadOnly = true;
            this.txtRgbOn.Size = new System.Drawing.Size(149, 20);
            this.txtRgbOn.TabIndex = 23;
            // 
            // btnRgbOn
            // 
            this.btnRgbOn.Enabled = false;
            this.btnRgbOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRgbOn.Location = new System.Drawing.Point(359, 85);
            this.btnRgbOn.Name = "btnRgbOn";
            this.btnRgbOn.Size = new System.Drawing.Size(91, 20);
            this.btnRgbOn.TabIndex = 26;
            this.btnRgbOn.Text = "Seleccionar";
            this.btnRgbOn.UseVisualStyleBackColor = true;
            this.btnRgbOn.MouseEnter += new System.EventHandler(this.btnRgbOn_MouseEnter);
            // 
            // txtLuzOn
            // 
            this.txtLuzOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtLuzOn.Enabled = false;
            this.txtLuzOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuzOn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLuzOn.Location = new System.Drawing.Point(204, 19);
            this.txtLuzOn.Name = "txtLuzOn";
            this.txtLuzOn.ReadOnly = true;
            this.txtLuzOn.Size = new System.Drawing.Size(149, 20);
            this.txtLuzOn.TabIndex = 13;
            // 
            // lblRgbOn
            // 
            this.lblRgbOn.AutoSize = true;
            this.lblRgbOn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgbOn.Location = new System.Drawing.Point(132, 88);
            this.lblRgbOn.Name = "lblRgbOn";
            this.lblRgbOn.Size = new System.Drawing.Size(69, 14);
            this.lblRgbOn.TabIndex = 22;
            this.lblRgbOn.Text = "Imagen On:";
            // 
            // btnLuzOn
            // 
            this.btnLuzOn.Enabled = false;
            this.btnLuzOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuzOn.Location = new System.Drawing.Point(359, 19);
            this.btnLuzOn.Name = "btnLuzOn";
            this.btnLuzOn.Size = new System.Drawing.Size(91, 20);
            this.btnLuzOn.TabIndex = 16;
            this.btnLuzOn.Text = "Seleccionar";
            this.btnLuzOn.UseVisualStyleBackColor = true;
            this.btnLuzOn.MouseEnter += new System.EventHandler(this.btnImagenOn_MouseEnter);
            // 
            // lblRgbOff
            // 
            this.lblRgbOff.AutoSize = true;
            this.lblRgbOff.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgbOff.Location = new System.Drawing.Point(132, 114);
            this.lblRgbOff.Name = "lblRgbOff";
            this.lblRgbOff.Size = new System.Drawing.Size(70, 14);
            this.lblRgbOff.TabIndex = 24;
            this.lblRgbOff.Text = "Imagen Off:";
            // 
            // lblLuzOn
            // 
            this.lblLuzOn.AutoSize = true;
            this.lblLuzOn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuzOn.Location = new System.Drawing.Point(132, 22);
            this.lblLuzOn.Name = "lblLuzOn";
            this.lblLuzOn.Size = new System.Drawing.Size(69, 14);
            this.lblLuzOn.TabIndex = 12;
            this.lblLuzOn.Text = "Imagen On:";
            // 
            // txtRgbOff
            // 
            this.txtRgbOff.BackColor = System.Drawing.SystemColors.Control;
            this.txtRgbOff.Enabled = false;
            this.txtRgbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgbOff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRgbOff.Location = new System.Drawing.Point(204, 111);
            this.txtRgbOff.Name = "txtRgbOff";
            this.txtRgbOff.ReadOnly = true;
            this.txtRgbOff.Size = new System.Drawing.Size(149, 20);
            this.txtRgbOff.TabIndex = 25;
            // 
            // lblLuzOff
            // 
            this.lblLuzOff.AutoSize = true;
            this.lblLuzOff.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuzOff.Location = new System.Drawing.Point(132, 48);
            this.lblLuzOff.Name = "lblLuzOff";
            this.lblLuzOff.Size = new System.Drawing.Size(70, 14);
            this.lblLuzOff.TabIndex = 14;
            this.lblLuzOff.Text = "Imagen Off:";
            // 
            // txtLuzOff
            // 
            this.txtLuzOff.BackColor = System.Drawing.SystemColors.Control;
            this.txtLuzOff.Enabled = false;
            this.txtLuzOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuzOff.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLuzOff.Location = new System.Drawing.Point(204, 45);
            this.txtLuzOff.Name = "txtLuzOff";
            this.txtLuzOff.ReadOnly = true;
            this.txtLuzOff.Size = new System.Drawing.Size(149, 20);
            this.txtLuzOff.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(468, 621);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 14);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(468, 647);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 14);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(528, 644);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // imgFondo
            // 
            this.imgFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFondo.Location = new System.Drawing.Point(472, 12);
            this.imgFondo.Name = "imgFondo";
            this.imgFondo.Size = new System.Drawing.Size(800, 600);
            this.imgFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFondo.TabIndex = 18;
            this.imgFondo.TabStop = false;
            // 
            // btnFondo
            // 
            this.btnFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFondo.Location = new System.Drawing.Point(1181, 618);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(91, 20);
            this.btnFondo.TabIndex = 19;
            this.btnFondo.Text = "Fondo";
            this.btnFondo.UseVisualStyleBackColor = true;
            this.btnFondo.Click += new System.EventHandler(this.btnFondo_Click);
            // 
            // lblLocationY
            // 
            this.lblLocationY.AutoSize = true;
            this.lblLocationY.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationY.Location = new System.Drawing.Point(710, 647);
            this.lblLocationY.Name = "lblLocationY";
            this.lblLocationY.Size = new System.Drawing.Size(86, 14);
            this.lblLocationY.TabIndex = 22;
            this.lblLocationY.Text = "Posición eje Y:";
            // 
            // txtLocationY
            // 
            this.txtLocationY.BackColor = System.Drawing.SystemColors.Control;
            this.txtLocationY.Enabled = false;
            this.txtLocationY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLocationY.Location = new System.Drawing.Point(803, 644);
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.Size = new System.Drawing.Size(60, 20);
            this.txtLocationY.TabIndex = 23;
            // 
            // lblLocationX
            // 
            this.lblLocationX.AutoSize = true;
            this.lblLocationX.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationX.Location = new System.Drawing.Point(710, 621);
            this.lblLocationX.Name = "lblLocationX";
            this.lblLocationX.Size = new System.Drawing.Size(87, 14);
            this.lblLocationX.TabIndex = 20;
            this.lblLocationX.Text = "Posición eje X:";
            // 
            // txtLocationX
            // 
            this.txtLocationX.BackColor = System.Drawing.SystemColors.Control;
            this.txtLocationX.Enabled = false;
            this.txtLocationX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLocationX.Location = new System.Drawing.Point(803, 618);
            this.txtLocationX.Name = "txtLocationX";
            this.txtLocationX.ReadOnly = true;
            this.txtLocationX.Size = new System.Drawing.Size(60, 20);
            this.txtLocationX.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Exportar a XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLocationY);
            this.Controls.Add(this.txtLocationY);
            this.Controls.Add(this.lblLocationX);
            this.Controls.Add(this.txtLocationX);
            this.Controls.Add(this.btnFondo);
            this.Controls.Add(this.imgFondo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTipo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crearLuz;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblLuzOn;
        private System.Windows.Forms.TextBox txtLuzOn;
        private System.Windows.Forms.Label lblLuzOff;
        private System.Windows.Forms.TextBox txtLuzOff;
        private System.Windows.Forms.Button btnLuzOn;
        private System.Windows.Forms.Button btnLuzOff;
        private System.Windows.Forms.PictureBox imgFondo;
        private System.Windows.Forms.Button btnFondo;
        private System.Windows.Forms.Label lblRgb;
        private System.Windows.Forms.Button crearRgb;
        private System.Windows.Forms.Button btnRgbOff;
        private System.Windows.Forms.TextBox txtRgbOn;
        private System.Windows.Forms.Button btnRgbOn;
        private System.Windows.Forms.Label lblRgbOn;
        private System.Windows.Forms.Label lblRgbOff;
        private System.Windows.Forms.TextBox txtRgbOff;
        private System.Windows.Forms.Label lblTermostato;
        private System.Windows.Forms.Label lblPersiana;
        private System.Windows.Forms.Button crearTermostato;
        private System.Windows.Forms.Button crearPersiana;
        private System.Windows.Forms.Button btnTermostatoOff;
        private System.Windows.Forms.Button btnPersianaOff;
        private System.Windows.Forms.TextBox txtTermostatoOn;
        private System.Windows.Forms.Button btnTermostatoOn;
        private System.Windows.Forms.TextBox txtPersianaOn;
        private System.Windows.Forms.Label lblTermostatoOn;
        private System.Windows.Forms.Button btnPersianaOn;
        private System.Windows.Forms.Label lblTermostatoOff;
        private System.Windows.Forms.Label lblPersianaOn;
        private System.Windows.Forms.TextBox txtTermostatoOff;
        private System.Windows.Forms.Label lblPersianaOff;
        private System.Windows.Forms.TextBox txtPersianaOff;
        private System.Windows.Forms.Label lblLocationY;
        private System.Windows.Forms.TextBox txtLocationY;
        private System.Windows.Forms.Label lblLocationX;
        private System.Windows.Forms.TextBox txtLocationX;
        private System.Windows.Forms.Button button1;
    }
}

