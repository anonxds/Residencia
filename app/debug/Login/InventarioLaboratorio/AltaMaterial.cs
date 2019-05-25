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
    public partial class AltaMaterial : Form
    {
        //Inicio del Patron Singleton

        private static AltaMaterial _instanciaMaterial;

        public static AltaMaterial ObtenerInstanciaMaterial()
        {
            if (_instanciaMaterial == null || _instanciaMaterial.IsDisposed)
            {
                _instanciaMaterial = new AltaMaterial();
            }
            _instanciaMaterial.BringToFront();
            return _instanciaMaterial;
        }
        //Fin del Patron Singleton

        private AltaMaterial()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarEq_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpiar lim = new Limpiar();
            lim.BorrarCampos(this);
        }

        private void btnAgregarEq_Click(object sender, EventArgs e)
        {
            Material mt = new Material();

            mt.Nombre = txtEqNombre.Text;
            mt.Tipo = lstTipo.Text;
            mt.Capacidad = txtEqCapacidad.Text;
            mt.Estado = txtEstado.Text;
            mt.Laboratorio = lstLaboratorio.Text;
            mt.Observacion = txtEqObs.Text;

            int Agm = MaterialBD.AgregarMaterial(mt);

            if (Agm > 0)
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
    }
}
