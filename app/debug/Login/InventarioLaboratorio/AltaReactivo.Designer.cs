namespace InventarioLaboratorio
{
    partial class AltaReactivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaReactivo));
            this.lblCat1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.txtReacNom = new System.Windows.Forms.TextBox();
            this.txtReacNum = new System.Windows.Forms.TextBox();
            this.txtReacCat = new System.Windows.Forms.TextBox();
            this.txtReacUni = new System.Windows.Forms.TextBox();
            this.btnAgregarRc = new System.Windows.Forms.Button();
            this.btnCancelarRc = new System.Windows.Forms.Button();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReacObs = new System.Windows.Forms.TextBox();
            this.lstLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lstClasificacion = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtReacCad = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblCat1
            // 
            this.lblCat1.AutoSize = true;
            this.lblCat1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat1.ForeColor = System.Drawing.Color.White;
            this.lblCat1.Location = new System.Drawing.Point(68, 42);
            this.lblCat1.Name = "lblCat1";
            this.lblCat1.Size = new System.Drawing.Size(83, 23);
            this.lblCat1.TabIndex = 22;
            this.lblCat1.Text = "Nombre:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(68, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(83, 23);
            this.lblNumero.TabIndex = 23;
            this.lblNumero.Text = "Numero:";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.White;
            this.lblUnidad.Location = new System.Drawing.Point(443, 150);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(75, 23);
            this.lblUnidad.TabIndex = 24;
            this.lblUnidad.Text = "Unidad:";
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.White;
            this.lblCatalogo.Location = new System.Drawing.Point(443, 93);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(90, 23);
            this.lblCatalogo.TabIndex = 25;
            this.lblCatalogo.Text = "Catálogo:";
            // 
            // txtReacNom
            // 
            this.txtReacNom.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacNom.Location = new System.Drawing.Point(194, 39);
            this.txtReacNom.Name = "txtReacNom";
            this.txtReacNom.Size = new System.Drawing.Size(206, 32);
            this.txtReacNom.TabIndex = 26;
            // 
            // txtReacNum
            // 
            this.txtReacNum.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacNum.Location = new System.Drawing.Point(194, 96);
            this.txtReacNum.Name = "txtReacNum";
            this.txtReacNum.Size = new System.Drawing.Size(206, 32);
            this.txtReacNum.TabIndex = 27;
            // 
            // txtReacCat
            // 
            this.txtReacCat.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacCat.Location = new System.Drawing.Point(569, 90);
            this.txtReacCat.Name = "txtReacCat";
            this.txtReacCat.Size = new System.Drawing.Size(206, 32);
            this.txtReacCat.TabIndex = 28;
            // 
            // txtReacUni
            // 
            this.txtReacUni.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacUni.Location = new System.Drawing.Point(569, 141);
            this.txtReacUni.Name = "txtReacUni";
            this.txtReacUni.Size = new System.Drawing.Size(206, 32);
            this.txtReacUni.TabIndex = 29;
            // 
            // btnAgregarRc
            // 
            this.btnAgregarRc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarRc.Location = new System.Drawing.Point(255, 267);
            this.btnAgregarRc.Name = "btnAgregarRc";
            this.btnAgregarRc.Size = new System.Drawing.Size(120, 35);
            this.btnAgregarRc.TabIndex = 30;
            this.btnAgregarRc.Text = "Agregar";
            this.btnAgregarRc.UseVisualStyleBackColor = true;
            this.btnAgregarRc.Click += new System.EventHandler(this.btnAgregarRc_Click);
            // 
            // btnCancelarRc
            // 
            this.btnCancelarRc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarRc.Location = new System.Drawing.Point(479, 267);
            this.btnCancelarRc.Name = "btnCancelarRc";
            this.btnCancelarRc.Size = new System.Drawing.Size(120, 35);
            this.btnCancelarRc.TabIndex = 31;
            this.btnCancelarRc.Text = "Cancelar";
            this.btnCancelarRc.UseVisualStyleBackColor = true;
            this.btnCancelarRc.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidad.ForeColor = System.Drawing.Color.White;
            this.lblCaducidad.Location = new System.Drawing.Point(443, 42);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(104, 23);
            this.lblCaducidad.TabIndex = 32;
            this.lblCaducidad.Text = "Caducidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Observación:";
            // 
            // txtReacObs
            // 
            this.txtReacObs.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacObs.Location = new System.Drawing.Point(569, 196);
            this.txtReacObs.Name = "txtReacObs";
            this.txtReacObs.Size = new System.Drawing.Size(206, 32);
            this.txtReacObs.TabIndex = 35;
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
            this.lstLaboratorio.Location = new System.Drawing.Point(194, 202);
            this.lstLaboratorio.Name = "lstLaboratorio";
            this.lstLaboratorio.Size = new System.Drawing.Size(206, 31);
            this.lstLaboratorio.TabIndex = 37;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorio.Location = new System.Drawing.Point(68, 205);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(98, 23);
            this.lblLaboratorio.TabIndex = 36;
            this.lblLaboratorio.Text = "Ubicación:";
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
            this.lstClasificacion.Location = new System.Drawing.Point(194, 147);
            this.lstClasificacion.Name = "lstClasificacion";
            this.lstClasificacion.Size = new System.Drawing.Size(206, 31);
            this.lstClasificacion.TabIndex = 40;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(68, 150);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(120, 23);
            this.lblTipo.TabIndex = 39;
            this.lblTipo.Text = "Clasificación:";
            // 
            // txtReacCad
            // 
            this.txtReacCad.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.txtReacCad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.txtReacCad.Location = new System.Drawing.Point(569, 42);
            this.txtReacCad.Name = "txtReacCad";
            this.txtReacCad.Size = new System.Drawing.Size(206, 32);
            this.txtReacCad.TabIndex = 41;
            // 
            // AltaReactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 331);
            this.Controls.Add(this.txtReacCad);
            this.Controls.Add(this.lstClasificacion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lstLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.txtReacObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaducidad);
            this.Controls.Add(this.btnCancelarRc);
            this.Controls.Add(this.btnAgregarRc);
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
            this.Name = "AltaReactivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Reactivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCat1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.TextBox txtReacNom;
        private System.Windows.Forms.TextBox txtReacNum;
        private System.Windows.Forms.TextBox txtReacCat;
        private System.Windows.Forms.TextBox txtReacUni;
        private System.Windows.Forms.Button btnAgregarRc;
        private System.Windows.Forms.Button btnCancelarRc;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReacObs;
        private System.Windows.Forms.ComboBox lstLaboratorio;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.ComboBox lstClasificacion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker txtReacCad;
    }
}