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
    public partial class ModificarEquipo : Form
    {
        public ModificarEquipo()
        {
            InitializeComponent();
        }

        private void btnAgregarEq_Click(object sender, EventArgs e)
        {
            try
            {
                Sql s = new Sql();
                Equipo eq = new Equipo();

                eq.Id = Convert.ToInt64(txtEqId.Text);
                eq.Nombre = txtEqNombre.Text;
                eq.Marca = txtEqMarca.Text;
                eq.Modelo = txtEqModelo.Text;
                eq.Estado = lstEqEstado.Text;
                eq.Laboratorio = lstLaboratorio.Text;
                eq.NumITT = txtEqInvITT.Text;
                eq.Precio = txtEqPrc.Text;
                eq.ManualOP = txtEqMnl.Text;
                eq.NumSerie = txtEqSerie.Text;
                eq.Observacion = txtEqObs.Text;

                string query = string.Format("Update Equipo set Nombre='{0}', Marca='{1}', Modelo='{2}', Estado='{3}', Laboratorio='{4}', NumITT='{5}', NumSEP='{6}', ManualOP='{7}', NumSerie='{8}', Observaciones='{9}' where Id={10}",
                    txtEqNombre.Text, txtEqMarca.Text, txtEqModelo.Text, lstEqEstado.Text, lstLaboratorio.Text, txtEqInvITT.Text, txtEqPrc.Text, txtEqMnl.Text, txtEqSerie.Text, txtEqObs.Text, txtEqId.Text);
                s.Exe(query);

                MessageBox.Show("Equipo modificado con exito", "Dato modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se a producido algun error" + ex);
            }
        }

        private void btnCancelarEq_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }
    }
}
