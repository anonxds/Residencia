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
    public partial class ModificarMaterial : Form
    {
        public ModificarMaterial()
        {
            InitializeComponent();
        }

        private void btnCancelarEq_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void btnModificarMat_Click(object sender, EventArgs e)
        {
            try
            {
                Sql s = new Sql();
                Material mat = new Material();

                mat.Id = Convert.ToInt64(txtMatId.Text);
                mat.Nombre = txtMatNombre.Text;
                mat.Tipo = lstTipo.Text;
                mat.Capacidad = txtMatCapacidad.Text;
                mat.Estado = lstMatEstado.Text;
                mat.Laboratorio = lstLaboratorio.Text;
                mat.Observacion = txtMatObs.Text;

                string query = string.Format("Update Material set Nombre='{0}', Tipo='{1}', Capacidad='{2}', Estado='{3}', Laboratorio='{4}', Observaciones='{5}' where Id={6}",
                    txtMatNombre.Text, lstTipo.Text, txtMatCapacidad.Text, lstMatEstado.Text, lstLaboratorio.Text, txtMatObs.Text, txtMatId.Text);
                s.Exe(query);

                MessageBox.Show("Material modificado con exito", "Dato modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se a producido algun error" + ex);
            }
        }
    }
}
