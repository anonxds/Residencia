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
    public partial class AltaEquipo : Form
    {

        //Inicio del Patron Singleton

        private static AltaEquipo _instanciaEquipo;

        public static AltaEquipo ObtenerInstanciaEquipo()
        {
            if (_instanciaEquipo == null || _instanciaEquipo.IsDisposed)
            {
                _instanciaEquipo = new AltaEquipo();
            }
            _instanciaEquipo.BringToFront();
            return _instanciaEquipo;
        }
        //Fin del Patron Singleton

        private AltaEquipo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void btnAgregarEq_Click(object sender, EventArgs e)
        {
            Equipo eq = new Equipo();

            eq.Nombre = txtEqNombre.Text;
            eq.Marca = txtEqMarca.Text;
            eq.Modelo = txtEqModelo.Text;
            eq.Estado = txtEstado.Text;
            eq.Laboratorio = lstLaboratorio.Text;
            eq.NumITT = txtEqInvITT.Text;
            eq.Precio = txtEqPrc.Text;
            eq.ManualOP = txtEqMnl.Text;
            eq.NumSerie = txtEqSerie.Text;
            eq.Observacion = txtEqObs.Text;

            int Agr = EquipoBD.AgregarEquipo(eq);

            if (Agr >0)
            {
                MessageBox.Show("Datos guardados correctamente", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                Limpiar limpiar = new Limpiar();
                limpiar.BorrarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al guardar la infomación", "Dato no guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void lstLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Codigo para no editar listado
            lstLaboratorio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AltaEquipo_Load(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblLaboratorio_Click(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEqModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEqMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEqNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblObs_Click(object sender, EventArgs e)
        {

        }

        private void lblNumS_Click(object sender, EventArgs e)
        {

        }

        private void lblManual_Click(object sender, EventArgs e)
        {

        }

        private void lblEqPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblNoInventario_Click(object sender, EventArgs e)
        {

        }

        private void txtEqInvITT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEqMnl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEqSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEqObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEqNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
