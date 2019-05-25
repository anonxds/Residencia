using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    class Limpiar
    {
        public void BorrarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    //Recore todos los TextBox y los limpia
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    //Regresa los ComboBox al indicador inicial
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
        }
    }
}
