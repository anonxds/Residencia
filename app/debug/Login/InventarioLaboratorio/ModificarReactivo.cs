using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventarioLaboratorio
{
    public partial class ModificarReactivo : Form
    {
        public ModificarReactivo()
        {
            InitializeComponent();
        }

        private void btnCancelarRc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
            txtReacCad.Clear();
        }

        private void btnModificarRc_Click(object sender, EventArgs e)
        {
            try
            {
                Sql s = new Sql();
                Reactivo r = new Reactivo();

                r.Id = Convert.ToInt64(txtReacID.Text);
                r.Nombre = txtReacNom.Text;
                r.Numero = txtReacNum.Text;
                r.Clasificacion = lstClasificacion.Text;
                r.Laboratorio = lstLaboratorio.Text;
                r.Caducidad = txtReacCad.Text;
                r.Catalogo = txtReacCat.Text;
                r.Unidad = txtReacUni.Text;
                r.Observacion = txtReacObs.Text;

                string query = string.Format("Update Reactivo set Nombre='{0}', Numero='{1}', Clasificacion='{2}', Laboratorio='{3}', Caducidad='{4}', Catalogo='{5}', Unidad='{6}', Observaciones='{7}' where Id={8}",
                        txtReacNom.Text, txtReacNum.Text, lstClasificacion.Text, lstLaboratorio.Text, txtReacCad.Text, txtReacCat.Text, txtReacUni.Text, txtReacObs.Text, txtReacID.Text);

                s.Exe(query);

                MessageBox.Show("Reactivo modificado con exito", "Dato modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se a producido algun error. " + ex);
            }
        }

        private void ModificarReactivo_Load(object sender, EventArgs e)
        {

        }
    }
}
