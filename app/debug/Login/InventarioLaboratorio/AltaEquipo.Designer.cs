namespace InventarioLaboratorio
{
    partial class AltaEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaEquipo));
            this.btnCancelarEq = new System.Windows.Forms.Button();
            this.btnAgregarEq = new System.Windows.Forms.Button();
            this.lblEqNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNumS = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtEqNombre = new System.Windows.Forms.TextBox();
            this.txtEqMarca = new System.Windows.Forms.TextBox();
            this.txtEqModelo = new System.Windows.Forms.TextBox();
            this.txtEqSerie = new System.Windows.Forms.TextBox();
            this.txtEqObs = new System.Windows.Forms.TextBox();
            this.txtEqMnl = new System.Windows.Forms.TextBox();
            this.txtEqPrc = new System.Windows.Forms.TextBox();
            this.txtEqInvITT = new System.Windows.Forms.TextBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblEqSEP = new System.Windows.Forms.Label();
            this.lblNoInventario = new System.Windows.Forms.Label();
            this.lstLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarEq
            // 
            this.btnCancelarEq.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarEq.Location = new System.Drawing.Point(483, 275);
            this.btnCancelarEq.Name = "btnCancelarEq";
            this.btnCancelarEq.Size = new System.Drawing.Size(120, 35);
            this.btnCancelarEq.TabIndex = 51;
            this.btnCancelarEq.Text = "Cancelar";
            this.btnCancelarEq.UseVisualStyleBackColor = true;
            this.btnCancelarEq.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarEq
            // 
            this.btnAgregarEq.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarEq.Location = new System.Drawing.Point(257, 275);
            this.btnAgregarEq.Name = "btnAgregarEq";
            this.btnAgregarEq.Size = new System.Drawing.Size(120, 35);
            this.btnAgregarEq.TabIndex = 50;
            this.btnAgregarEq.Text = "Agregar";
            this.btnAgregarEq.UseVisualStyleBackColor = true;
            this.btnAgregarEq.Click += new System.EventHandler(this.btnAgregarEq_Click);
            // 
            // lblEqNombre
            // 
            this.lblEqNombre.AutoSize = true;
            this.lblEqNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqNombre.ForeColor = System.Drawing.Color.White;
            this.lblEqNombre.Location = new System.Drawing.Point(18, 48);
            this.lblEqNombre.Name = "lblEqNombre";
            this.lblEqNombre.Size = new System.Drawing.Size(83, 23);
            this.lblEqNombre.TabIndex = 42;
            this.lblEqNombre.Text = "Nombre:";
            this.lblEqNombre.Click += new System.EventHandler(this.lblEqNombre_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(18, 96);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 23);
            this.lblMarca.TabIndex = 43;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // lblNumS
            // 
            this.lblNumS.AutoSize = true;
            this.lblNumS.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumS.ForeColor = System.Drawing.Color.White;
            this.lblNumS.Location = new System.Drawing.Point(382, 191);
            this.lblNumS.Name = "lblNumS";
            this.lblNumS.Size = new System.Drawing.Size(88, 23);
            this.lblNumS.TabIndex = 44;
            this.lblNumS.Text = "No. serie:";
            this.lblNumS.Click += new System.EventHandler(this.lblNumS_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(18, 143);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(79, 23);
            this.lblModelo.TabIndex = 45;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // txtEqNombre
            // 
            this.txtEqNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqNombre.Location = new System.Drawing.Point(134, 45);
            this.txtEqNombre.Name = "txtEqNombre";
            this.txtEqNombre.Size = new System.Drawing.Size(204, 32);
            this.txtEqNombre.TabIndex = 46;
            this.txtEqNombre.TextChanged += new System.EventHandler(this.txtEqNombre_TextChanged);
            // 
            // txtEqMarca
            // 
            this.txtEqMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqMarca.Location = new System.Drawing.Point(134, 93);
            this.txtEqMarca.Name = "txtEqMarca";
            this.txtEqMarca.Size = new System.Drawing.Size(204, 32);
            this.txtEqMarca.TabIndex = 47;
            this.txtEqMarca.TextChanged += new System.EventHandler(this.txtEqMarca_TextChanged);
            // 
            // txtEqModelo
            // 
            this.txtEqModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqModelo.Location = new System.Drawing.Point(134, 140);
            this.txtEqModelo.Name = "txtEqModelo";
            this.txtEqModelo.Size = new System.Drawing.Size(204, 32);
            this.txtEqModelo.TabIndex = 48;
            this.txtEqModelo.TextChanged += new System.EventHandler(this.txtEqModelo_TextChanged);
            // 
            // txtEqSerie
            // 
            this.txtEqSerie.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqSerie.Location = new System.Drawing.Point(603, 182);
            this.txtEqSerie.Name = "txtEqSerie";
            this.txtEqSerie.Size = new System.Drawing.Size(204, 32);
            this.txtEqSerie.TabIndex = 49;
            this.txtEqSerie.TextChanged += new System.EventHandler(this.txtEqSerie_TextChanged);
            // 
            // txtEqObs
            // 
            this.txtEqObs.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqObs.Location = new System.Drawing.Point(603, 228);
            this.txtEqObs.Name = "txtEqObs";
            this.txtEqObs.Size = new System.Drawing.Size(204, 32);
            this.txtEqObs.TabIndex = 59;
            this.txtEqObs.TextChanged += new System.EventHandler(this.txtEqObs_TextChanged);
            // 
            // txtEqMnl
            // 
            this.txtEqMnl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqMnl.Location = new System.Drawing.Point(603, 134);
            this.txtEqMnl.Name = "txtEqMnl";
            this.txtEqMnl.Size = new System.Drawing.Size(204, 32);
            this.txtEqMnl.TabIndex = 58;
            this.txtEqMnl.TextChanged += new System.EventHandler(this.txtEqMnl_TextChanged);
            // 
            // txtEqPrc
            // 
            this.txtEqPrc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqPrc.Location = new System.Drawing.Point(603, 87);
            this.txtEqPrc.Name = "txtEqPrc";
            this.txtEqPrc.Size = new System.Drawing.Size(204, 32);
            this.txtEqPrc.TabIndex = 57;
            // 
            // txtEqInvITT
            // 
            this.txtEqInvITT.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEqInvITT.Location = new System.Drawing.Point(603, 39);
            this.txtEqInvITT.Name = "txtEqInvITT";
            this.txtEqInvITT.Size = new System.Drawing.Size(204, 32);
            this.txtEqInvITT.TabIndex = 56;
            this.txtEqInvITT.TextChanged += new System.EventHandler(this.txtEqInvITT_TextChanged);
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.Color.White;
            this.lblManual.Location = new System.Drawing.Point(382, 143);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(194, 23);
            this.lblManual.TabIndex = 55;
            this.lblManual.Text = "Manual de operación:";
            this.lblManual.Click += new System.EventHandler(this.lblManual_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(382, 237);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(119, 23);
            this.lblObs.TabIndex = 54;
            this.lblObs.Text = "Observación:";
            this.lblObs.Click += new System.EventHandler(this.lblObs_Click);
            // 
            // lblEqSEP
            // 
            this.lblEqSEP.AutoSize = true;
            this.lblEqSEP.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqSEP.ForeColor = System.Drawing.Color.White;
            this.lblEqSEP.Location = new System.Drawing.Point(382, 96);
            this.lblEqSEP.Name = "lblEqSEP";
            this.lblEqSEP.Size = new System.Drawing.Size(169, 23);
            this.lblEqSEP.TabIndex = 53;
            this.lblEqSEP.Text = "No. Inventario SEP:";
            this.lblEqSEP.Click += new System.EventHandler(this.lblEqPrecio_Click);
            // 
            // lblNoInventario
            // 
            this.lblNoInventario.AutoSize = true;
            this.lblNoInventario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoInventario.ForeColor = System.Drawing.Color.White;
            this.lblNoInventario.Location = new System.Drawing.Point(382, 48);
            this.lblNoInventario.Name = "lblNoInventario";
            this.lblNoInventario.Size = new System.Drawing.Size(163, 23);
            this.lblNoInventario.TabIndex = 52;
            this.lblNoInventario.Text = "No. inventario ITT:";
            this.lblNoInventario.Click += new System.EventHandler(this.lblNoInventario_Click);
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
            this.lstLaboratorio.Location = new System.Drawing.Point(134, 234);
            this.lstLaboratorio.Name = "lstLaboratorio";
            this.lstLaboratorio.Size = new System.Drawing.Size(204, 31);
            this.lstLaboratorio.TabIndex = 81;
            this.lstLaboratorio.SelectedIndexChanged += new System.EventHandler(this.lstLaboratorio_SelectedIndexChanged);
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorio.Location = new System.Drawing.Point(18, 237);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(98, 23);
            this.lblLaboratorio.TabIndex = 80;
            this.lblLaboratorio.Text = "Ubicación:";
            this.lblLaboratorio.Click += new System.EventHandler(this.lblLaboratorio_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(134, 188);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(204, 32);
            this.txtEstado.TabIndex = 83;
            this.txtEstado.Text = "Activo";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(18, 191);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 23);
            this.lblEstado.TabIndex = 82;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // AltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 331);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lstLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.txtEqObs);
            this.Controls.Add(this.txtEqMnl);
            this.Controls.Add(this.txtEqPrc);
            this.Controls.Add(this.txtEqInvITT);
            this.Controls.Add(this.lblManual);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblEqSEP);
            this.Controls.Add(this.lblNoInventario);
            this.Controls.Add(this.btnCancelarEq);
            this.Controls.Add(this.btnAgregarEq);
            this.Controls.Add(this.txtEqSerie);
            this.Controls.Add(this.txtEqModelo);
            this.Controls.Add(this.txtEqMarca);
            this.Controls.Add(this.txtEqNombre);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNumS);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblEqNombre);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Equipo";
            this.Load += new System.EventHandler(this.AltaEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarEq;
        private System.Windows.Forms.Button btnAgregarEq;
        private System.Windows.Forms.Label lblEqNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNumS;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtEqNombre;
        private System.Windows.Forms.TextBox txtEqMarca;
        private System.Windows.Forms.TextBox txtEqModelo;
        private System.Windows.Forms.TextBox txtEqSerie;
        private System.Windows.Forms.TextBox txtEqObs;
        private System.Windows.Forms.TextBox txtEqMnl;
        private System.Windows.Forms.TextBox txtEqPrc;
        private System.Windows.Forms.TextBox txtEqInvITT;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblEqSEP;
        private System.Windows.Forms.Label lblNoInventario;
        private System.Windows.Forms.ComboBox lstLaboratorio;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}