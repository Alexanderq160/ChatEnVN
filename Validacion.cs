using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Client_APP
{
    class Validacion
    {
         public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }
         public void soloNumeros2(KeyPressEventArgs e)
         {
             try
             {
                 if (Char.IsNumber(e.KeyChar))
                 {
                     e.Handled = false;
                 }
                 else if (Char.IsControl(e.KeyChar))
                 {
                     e.Handled = false;
                 }
                 else if (char.IsPunctuation(e.KeyChar))
                 {
                     e.Handled = false;
                 }
                 else
                 {
                     e.Handled = true;
                 }
             }
             catch (Exception ex)
             {

             }
         }
    }
}
