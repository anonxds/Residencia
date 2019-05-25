using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public partial class FmEquipo : Form
    {
        public FmEquipo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmCatalogo formCatalogo = new FrmCatalogo();
            formCatalogo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaEquipo AltasEquipo = AltaEquipo.ObtenerInstanciaEquipo();
            AltasEquipo.Show();
        }

        private void FmEquipo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEquipo.DataSource = EquipoBD.BuscarEquipo(lstLaboratorio.Text, lstEstado.Text);
            lblNombre.Visible = true;
            txtBscNom.Visible = true;
            lblMarca.Visible = true;
            txtBscrMarca.Visible = true;
            lblModelo.Visible = true;
            txtBscrModelo.Visible = true;
            lblInvITT.Visible = true;
            txtInvITT.Visible = true;
            lblInvSEP.Visible = true;
            txtInvSEP.Visible = true;
            lblBscOP.Visible = true;
            txtBscManual.Visible = true;
            lblBscSerie.Visible = true;
            txtSerie.Visible = true;
            lblObservacion.Visible = true;
            txtBscObserv.Visible = true;
            btnExportar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarEquipo me = new ModificarEquipo();
            if (dgvEquipo.SelectedRows.Count > 0)
            {
                me.txtEqId.Text = dgvEquipo.CurrentRow.Cells[0].Value.ToString();
                me.txtEqNombre.Text = dgvEquipo.CurrentRow.Cells[1].Value.ToString();
                me.txtEqMarca.Text = dgvEquipo.CurrentRow.Cells[2].Value.ToString();
                me.txtEqModelo.Text = dgvEquipo.CurrentRow.Cells[3].Value.ToString();
                me.lstEqEstado.Text = dgvEquipo.CurrentRow.Cells[4].Value.ToString();
                me.lstLaboratorio.Text = dgvEquipo.CurrentRow.Cells[5].Value.ToString();
                me.txtEqInvITT.Text = dgvEquipo.CurrentRow.Cells[6].Value.ToString();
                me.txtEqPrc.Text = dgvEquipo.CurrentRow.Cells[7].Value.ToString();
                me.txtEqMnl.Text = dgvEquipo.CurrentRow.Cells[8].Value.ToString();
                me.txtEqSerie.Text = dgvEquipo.CurrentRow.Cells[9].Value.ToString();
                me.txtEqObs.Text = dgvEquipo.CurrentRow.Cells[10].Value.ToString();

                me.ShowDialog();
            }
            else
            {
                MessageBox.Show("Asegúrese de seleccionar una fila", "Dato no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Login CerrarSesion = new Login();
            CerrarSesion.Show();
            this.Hide();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar exportar = new Exportar();
            exportar.ExportarDataGridViewExcel(dgvEquipo);
        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBscLab_Click(object sender, EventArgs e)
        {

        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
