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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContresena.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "" && txtContresena.Text != "")
            {
                if (txtUsuario.Text == "Lab01" && txtContresena.Text == "Dart3")
                {
                    FrmCatalogo formCatalogo = new FrmCatalogo();
                    formCatalogo.Show();
                    this.Hide();
                }
                else if (txtUsuario.Text == "Lab02" && txtContresena.Text == "Ath0s")
                {
                    FrmCatalogo formCatalogo = new FrmCatalogo();
                    formCatalogo.Show();
                    this.Hide();
                }
                else if (txtUsuario.Text == "Lab03" && txtContresena.Text == "Prths6")
                {
                    FrmCatalogo formCatalogo = new FrmCatalogo();
                    formCatalogo.Show();
                    this.Hide();
                }
                else if (txtUsuario.Text == "Lab04" && txtContresena.Text == "Aram1s")
                {
                    FrmCatalogo formCatalogo = new FrmCatalogo();
                    formCatalogo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Asegúrese de que los datos sean correctos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de no dejar campo vacíos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
