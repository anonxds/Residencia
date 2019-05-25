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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void btnReactivo_Click(object sender, EventArgs e)
        {
            FrmReactivos formReactivo = new FrmReactivos();
            formReactivo.Show();
            this.Hide();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            FmEquipo formEquipo = new FmEquipo();
            formEquipo.Show();
            this.Hide();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Login CerrarSesion = new Login();
            CerrarSesion.Show();
            this.Hide();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            FrmMaterial formMaterial = new FrmMaterial();
            formMaterial.Show();
            this.Hide();
        }
    }
}
