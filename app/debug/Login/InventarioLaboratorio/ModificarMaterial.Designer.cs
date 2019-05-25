namespace InventarioLaboratorio
{
    partial class ModificarMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarMaterial));
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lstLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtMatObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnCancelarEq = new System.Windows.Forms.Button();
            this.btnModificarMat = new System.Windows.Forms.Button();
            this.txtMatCapacidad = new System.Windows.Forms.TextBox();
            this.txtMatNombre = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEqNombre = new System.Windows.Forms.Label();
            this.txtMatId = new System.Windows.Forms.TextBox();
            this.lstMatEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "Aro para soporte",
            "Bureta",
            "Embudo",
            "Escobilla de tubos de ensayo",
            "Frascos ámbar",
            "Gotero",
            "Gradilla",
            "Manguera ",
            "Matraz",
            "Mechero de alcohol",
            "Mortero",
            "Pinzas de crisol",
            "Pipeta graduada",
            "Pizeta",
            "Placa Petri",
            "Probeta",
            "Rejilla",
            "Soporte universal",
            "Termómetro",
            "Trípode",
            "Tubo de ensayo",
            "Varilla",
            "Vaso de precipitado",
            "Vidrio de reloj"});
            this.lstTipo.Location = new System.Drawing.Point(149, 103);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(204, 31);
            this.lstTipo.TabIndex = 96;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(434, 64);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 23);
            this.lblEstado.TabIndex = 94;
            this.lblEstado.Text = "Estado:";
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
            this.lstLaboratorio.Location = new System.Drawing.Point(618, 103);
            this.lstLaboratorio.Name = "lstLaboratorio";
            this.lstLaboratorio.Size = new System.Drawing.Size(204, 31);
            this.lstLaboratorio.TabIndex = 93;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorio.Location = new System.Drawing.Point(434, 112);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(98, 23);
            this.lblLaboratorio.TabIndex = 92;
            this.lblLaboratorio.Text = "Ubicación:";
            // 
            // txtMatObs
            // 
            this.txtMatObs.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatObs.Location = new System.Drawing.Point(618, 150);
            this.txtMatObs.Name = "txtMatObs";
            this.txtMatObs.Size = new System.Drawing.Size(204, 32);
            this.txtMatObs.TabIndex = 91;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(434, 160);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(119, 23);
            this.lblObs.TabIndex = 90;
            this.lblObs.Text = "Observación:";
            // 
            // btnCancelarEq
            // 
            this.btnCancelarEq.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarEq.Location = new System.Drawing.Point(503, 260);
            this.btnCancelarEq.Name = "btnCancelarEq";
            this.btnCancelarEq.Size = new System.Drawing.Size(120, 35);
            this.btnCancelarEq.TabIndex = 89;
            this.btnCancelarEq.Text = "Cancelar";
            this.btnCancelarEq.UseVisualStyleBackColor = true;
            this.btnCancelarEq.Click += new System.EventHandler(this.btnCancelarEq_Click);
            // 
            // btnModificarMat
            // 
            this.btnModificarMat.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarMat.Location = new System.Drawing.Point(233, 260);
            this.btnModificarMat.Name = "btnModificarMat";
            this.btnModificarMat.Size = new System.Drawing.Size(120, 35);
            this.btnModificarMat.TabIndex = 88;
            this.btnModificarMat.Text = "Modificar";
            this.btnModificarMat.UseVisualStyleBackColor = true;
            this.btnModificarMat.Click += new System.EventHandler(this.btnModificarMat_Click);
            // 
            // txtMatCapacidad
            // 
            this.txtMatCapacidad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatCapacidad.Location = new System.Drawing.Point(149, 150);
            this.txtMatCapacidad.Name = "txtMatCapacidad";
            this.txtMatCapacidad.Size = new System.Drawing.Size(204, 32);
            this.txtMatCapacidad.TabIndex = 87;
            // 
            // txtMatNombre
            // 
            this.txtMatNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatNombre.Location = new System.Drawing.Point(149, 55);
            this.txtMatNombre.Name = "txtMatNombre";
            this.txtMatNombre.Size = new System.Drawing.Size(204, 32);
            this.txtMatNombre.TabIndex = 86;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.ForeColor = System.Drawing.Color.White;
            this.lblCapacidad.Location = new System.Drawing.Point(33, 153);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(103, 23);
            this.lblCapacidad.TabIndex = 85;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(33, 116);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 23);
            this.lblTipo.TabIndex = 84;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblEqNombre
            // 
            this.lblEqNombre.AutoSize = true;
            this.lblEqNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqNombre.ForeColor = System.Drawing.Color.White;
            this.lblEqNombre.Location = new System.Drawing.Point(33, 58);
            this.lblEqNombre.Name = "lblEqNombre";
            this.lblEqNombre.Size = new System.Drawing.Size(83, 23);
            this.lblEqNombre.TabIndex = 83;
            this.lblEqNombre.Text = "Nombre:";
            // 
            // txtMatId
            // 
            this.txtMatId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatId.Location = new System.Drawing.Point(149, 12);
            this.txtMatId.Name = "txtMatId";
            this.txtMatId.Size = new System.Drawing.Size(204, 32);
            this.txtMatId.TabIndex = 107;
            this.txtMatId.Visible = false;
            // 
            // lstMatEstado
            // 
            this.lstMatEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMatEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatEstado.FormattingEnabled = true;
            this.lstMatEstado.Items.AddRange(new object[] {
            "Activo",
            "Baja"});
            this.lstMatEstado.Location = new System.Drawing.Point(618, 58);
            this.lstMatEstado.Name = "lstMatEstado";
            this.lstMatEstado.Size = new System.Drawing.Size(204, 31);
            this.lstMatEstado.TabIndex = 108;
            // 
            // ModificarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 331);
            this.Controls.Add(this.lstMatEstado);
            this.Controls.Add(this.txtMatId);
            this.Controls.Add(this.lstTipo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lstLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.txtMatObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnCancelarEq);
            this.Controls.Add(this.btnModificarMat);
            this.Controls.Add(this.txtMatCapacidad);
            this.Controls.Add(this.txtMatNombre);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEqNombre);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtMatId;
        public System.Windows.Forms.ComboBox lstTipo;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.ComboBox lstLaboratorio;
        public System.Windows.Forms.Label lblLaboratorio;
        public System.Windows.Forms.TextBox txtMatObs;
        public System.Windows.Forms.Label lblObs;
        public System.Windows.Forms.Button btnCancelarEq;
        public System.Windows.Forms.Button btnModificarMat;
        public System.Windows.Forms.TextBox txtMatCapacidad;
        public System.Windows.Forms.TextBox txtMatNombre;
        public System.Windows.Forms.Label lblCapacidad;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lblEqNombre;
        public System.Windows.Forms.ComboBox lstMatEstado;
    }
}