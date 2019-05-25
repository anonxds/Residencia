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
    public partial class FrmReactivos : Form
    {
        public FrmReactivos()
        {
            InitializeComponent();
        }

        public Reactivo ReactivoSeleccionado { get; set; }
        public Reactivo ReactivoActual { get; set; }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmCatalogo formCatalogo = new FrmCatalogo();
            formCatalogo.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaReactivo AltasReactivo = AltaReactivo.ObtenerInstanciaReactivo();
            AltasReactivo.Show();
        }

        private void FrmReactivos_Load(object sender, EventArgs e)
        {
        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           dgvReactivo.DataSource = ReactivoDB.BuscarReactivo(lstLaboratorio.Text, lstTipo.Text);

            lblNombre.Visible = true;
            txtReacNom.Visible = true;
            lblNumero.Visible = true;
            txtReacNum.Visible = true;
            lblCaducidad.Visible = true;
            txtBscCad.Visible = true;
            lblCatalogo.Visible = true;
            txtReacCat.Visible = true;
            lblUnidad.Visible = true;
            txtReacUni.Visible = true;
            lblObservacion.Visible = true;
            txtReacObs.Visible = true;
            btnExportar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            ModificarReactivo ModRea = new ModificarReactivo();
            if (dgvReactivo.SelectedRows.Count > 0)
            {
                ModRea.txtReacID.Text = dgvReactivo.CurrentRow.Cells[0].Value.ToString();
                ModRea.txtReacNom.Text = dgvReactivo.CurrentRow.Cells[1].Value.ToString();
                ModRea.txtReacNum.Text = dgvReactivo.CurrentRow.Cells[2].Value.ToString();
                ModRea.lstClasificacion.Text = dgvReactivo.CurrentRow.Cells[3].Value.ToString();
                ModRea.lstLaboratorio.Text = dgvReactivo.CurrentRow.Cells[4].Value.ToString();
                ModRea.txtReacCad.Text = dgvReactivo.CurrentRow.Cells[5].Value.ToString();
                ModRea.txtReacCat.Text = dgvReactivo.CurrentRow.Cells[6].Value.ToString();
                ModRea.txtReacUni.Text = dgvReactivo.CurrentRow.Cells[7].Value.ToString();
                ModRea.txtReacObs.Text = dgvReactivo.CurrentRow.Cells[8].Value.ToString();

                ModRea.ShowDialog();
            }
            else
            {
                MessageBox.Show("Asegúrese de seleccionar una fila", "Dato no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvReactivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            exportar.ExportarDataGridViewExcel(dgvReactivo);
        }

        private void txtReacNom_TextChanged(object sender, EventArgs e)
        {
            (dgvReactivo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre] like '%{0}%'", txtReacNom.Text);
        }
    }
}
