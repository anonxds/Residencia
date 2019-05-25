namespace InventarioLaboratorio
{
    partial class ModificarReactivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarReactivo));
            this.txtReacCad = new System.Windows.Forms.MaskedTextBox();
            this.lstLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtReacObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.btnCancelarRc = new System.Windows.Forms.Button();
            this.btnModificarRc = new System.Windows.Forms.Button();
            this.txtReacUni = new System.Windows.Forms.TextBox();
            this.txtReacCat = new System.Windows.Forms.TextBox();
            this.txtReacNum = new System.Windows.Forms.TextBox();
            this.txtReacNom = new System.Windows.Forms.TextBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCat1 = new System.Windows.Forms.Label();
            this.lstClasificacion = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtReacID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtReacCad
            // 
            this.txtReacCad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.txtReacCad.Location = new System.Drawing.Point(586, 55);
            this.txtReacCad.Mask = "00/00/0000";
            this.txtReacCad.Name = "txtReacCad";
            this.txtReacCad.Size = new System.Drawing.Size(206, 32);
            this.txtReacCad.TabIndex = 54;
            this.txtReacCad.ValidatingType = typeof(System.DateTime);
            // 
            // lstLaboratorio
            // 
            this.lstLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLaboratorio.FormattingEnabled = true;
            this.lstLaboratorio.Items.AddRange(new object[] {
            "Laboratorio 1",
            "Laboratorio 2",
            "Laboratorio 3",
            "Laboratorio 4"});
            this.lstLaboratorio.Location = new System.Drawing.Point(166, 206);
            this.lstLaboratorio.Name = "lstLaboratorio";
            this.lstLaboratorio.Size = new System.Drawing.Size(206, 31);
            this.lstLaboratorio.TabIndex = 53;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorio.Location = new System.Drawing.Point(30, 209);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(108, 23);
            this.lblLaboratorio.TabIndex = 52;
            this.lblLaboratorio.Text = "Laboratorio";
            // 
            // txtReacObs
            // 
            this.txtReacObs.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacObs.Location = new System.Drawing.Point(586, 205);
            this.txtReacObs.Name = "txtReacObs";
            this.txtReacObs.Size = new System.Drawing.Size(206, 32);
            this.txtReacObs.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Observación:";
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidad.ForeColor = System.Drawing.Color.White;
            this.lblCaducidad.Location = new System.Drawing.Point(460, 58);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(104, 23);
            this.lblCaducidad.TabIndex = 49;
            this.lblCaducidad.Text = "Caducidad:";
            // 
            // btnCancelarRc
            // 
            this.btnCancelarRc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarRc.Location = new System.Drawing.Point(483, 267);
            this.btnCancelarRc.Name = "btnCancelarRc";
            this.btnCancelarRc.Size = new System.Drawing.Size(120, 35);
            this.btnCancelarRc.TabIndex = 48;
            this.btnCancelarRc.Text = "Cancelar";
            this.btnCancelarRc.UseVisualStyleBackColor = true;
            this.btnCancelarRc.Click += new System.EventHandler(this.btnCancelarRc_Click);
            // 
            // btnModificarRc
            // 
            this.btnModificarRc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarRc.Location = new System.Drawing.Point(254, 267);
            this.btnModificarRc.Name = "btnModificarRc";
            this.btnModificarRc.Size = new System.Drawing.Size(120, 35);
            this.btnModificarRc.TabIndex = 47;
            this.btnModificarRc.Text = "Modificar";
            this.btnModificarRc.UseVisualStyleBackColor = true;
            this.btnModificarRc.Click += new System.EventHandler(this.btnModificarRc_Click);
            // 
            // txtReacUni
            // 
            this.txtReacUni.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacUni.Location = new System.Drawing.Point(586, 155);
            this.txtReacUni.Name = "txtReacUni";
            this.txtReacUni.Size = new System.Drawing.Size(206, 32);
            this.txtReacUni.TabIndex = 46;
            // 
            // txtReacCat
            // 
            this.txtReacCat.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacCat.Location = new System.Drawing.Point(586, 104);
            this.txtReacCat.Name = "txtReacCat";
            this.txtReacCat.Size = new System.Drawing.Size(206, 32);
            this.txtReacCat.TabIndex = 45;
            // 
            // txtReacNum
            // 
            this.txtReacNum.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacNum.Location = new System.Drawing.Point(168, 104);
            this.txtReacNum.Name = "txtReacNum";
            this.txtReacNum.Size = new System.Drawing.Size(206, 32);
            this.txtReacNum.TabIndex = 44;
            // 
            // txtReacNom
            // 
            this.txtReacNom.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacNom.Location = new System.Drawing.Point(168, 55);
            this.txtReacNom.Name = "txtReacNom";
            this.txtReacNom.Size = new System.Drawing.Size(204, 32);
            this.txtReacNom.TabIndex = 43;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.White;
            this.lblCatalogo.Location = new System.Drawing.Point(460, 107);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(90, 23);
            this.lblCatalogo.TabIndex = 42;
            this.lblCatalogo.Text = "Catálogo:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.White;
            this.lblUnidad.Location = new System.Drawing.Point(460, 159);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(75, 23);
            this.lblUnidad.TabIndex = 41;
            this.lblUnidad.Text = "Unidad:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(30, 107);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(83, 23);
            this.lblNumero.TabIndex = 40;
            this.lblNumero.Text = "Numero:";
            // 
            // lblCat1
            // 
            this.lblCat1.AutoSize = true;
            this.lblCat1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat1.ForeColor = System.Drawing.Color.White;
            this.lblCat1.Location = new System.Drawing.Point(30, 58);
            this.lblCat1.Name = "lblCat1";
            this.lblCat1.Size = new System.Drawing.Size(83, 23);
            this.lblCat1.TabIndex = 39;
            this.lblCat1.Text = "Nombre:";
            // 
            // lstClasificacion
            // 
            this.lstClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstClasificacion.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClasificacion.FormattingEnabled = true;
            this.lstClasificacion.Items.AddRange(new object[] {
            "Medio de cultivo",
            "Reactivo Congelador",
            "Reactivo Refrigerador"});
            this.lstClasificacion.Location = new System.Drawing.Point(166, 156);
            this.lstClasificacion.Name = "lstClasificacion";
            this.lstClasificacion.Size = new System.Drawing.Size(206, 31);
            this.lstClasificacion.TabIndex = 56;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(30, 158);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(120, 23);
            this.lblTipo.TabIndex = 55;
            this.lblTipo.Text = "Clasificación:";
            // 
            // txtReacID
            // 
            this.txtReacID.Enabled = false;
            this.txtReacID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacID.Location = new System.Drawing.Point(168, 1);
            this.txtReacID.Name = "txtReacID";
            this.txtReacID.Size = new System.Drawing.Size(206, 32);
            this.txtReacID.TabIndex = 57;
            this.txtReacID.Visible = false;
            // 
            // ModificarReactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 331);
            this.Controls.Add(this.txtReacID);
            this.Controls.Add(this.lstClasificacion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtReacCad);
            this.Controls.Add(this.lstLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.txtReacObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaducidad);
            this.Controls.Add(this.btnCancelarRc);
            this.Controls.Add(this.btnModificarRc);
            this.Controls.Add(this.txtReacUni);
            this.Controls.Add(this.txtReacCat);
            this.Controls.Add(this.txtReacNum);
            this.Controls.Add(this.txtReacNom);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCat1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarReactivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Reactivo";
            this.Load += new System.EventHandler(this.ModificarReactivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtReacNom;
        public System.Windows.Forms.MaskedTextBox txtReacCad;
        public System.Windows.Forms.ComboBox lstLaboratorio;
        public System.Windows.Forms.TextBox txtReacObs;
        public System.Windows.Forms.TextBox txtReacUni;
        public System.Windows.Forms.TextBox txtReacCat;
        public System.Windows.Forms.TextBox txtReacNum;
        public System.Windows.Forms.ComboBox lstClasificacion;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lblLaboratorio;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCaducidad;
        public System.Windows.Forms.Button btnCancelarRc;
        public System.Windows.Forms.Button btnModificarRc;
        public System.Windows.Forms.Label lblCatalogo;
        public System.Windows.Forms.Label lblUnidad;
        public System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.Label lblCat1;
        public System.Windows.Forms.TextBox txtReacID;
    }
}