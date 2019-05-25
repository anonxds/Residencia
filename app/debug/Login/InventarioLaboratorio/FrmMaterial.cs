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
    public partial class FrmMaterial : Form
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lstEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMaterial.DataSource = MaterialBD.BuscarMaterial(lstTipo.Text, lstLaboratorio.Text);
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblCapacidad.Visible = true;
            txtCapadad.Visible = true;
            lblEstado.Visible = true;
            textEstado.Visible = true;
            lblObs.Visible = true;
            txtObs.Visible = true;
            btnExportar.Enabled = true;
        }

        private void lstLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmCatalogo formCatalogo = new FrmCatalogo();
            formCatalogo.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaMaterial AltasMaterial = AltaMaterial.ObtenerInstanciaMaterial();
            AltasMaterial.Show();
        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Login CerrarSesion = new Login();
            CerrarSesion.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarMaterial mm = new ModificarMaterial();
            if (dgvMaterial.SelectedRows.Count > 0)
            {
                mm.txtMatId.Text = dgvMaterial.CurrentRow.Cells[0].Value.ToString();
                mm.txtMatNombre.Text = dgvMaterial.CurrentRow.Cells[1].Value.ToString();
                mm.lstTipo.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();
                mm.txtMatCapacidad.Text = dgvMaterial.CurrentRow.Cells[3].Value.ToString();
                mm.lstMatEstado.Text = dgvMaterial.CurrentRow.Cells[4].Value.ToString();
                mm.lstLaboratorio.Text = dgvMaterial.CurrentRow.Cells[5].Value.ToString();
                mm.txtMatObs.Text = dgvMaterial.CurrentRow.Cells[6].Value.ToString();

                mm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Asegúrese de seleccionar una fila", "Dato no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar exportar = new Exportar();
            exportar.ExportarDataGridViewExcel(dgvMaterial);
        }
    }
}
