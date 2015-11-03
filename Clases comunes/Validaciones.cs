using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.DataAccess.Client;
using System.Drawing;

namespace ARTICULOS
{
    class Validaciones
    {
        public void escribirSoloEnterosLimitado(KeyPressEventArgs evt, String texto, int maximo, TextBox txtTexto, Label lblError)
        {
            if ((txtTexto.Text.Length == maximo) && (Char.IsDigit(evt.KeyChar)))
            {
                evt.Handled = true;
                lblError.Text = (texto + " Longitud Máxima: " + maximo + " caracteres");
            }
            else
            {
                lblError.Text = "";
            }
            if (!Char.IsDigit(evt.KeyChar) && !(Convert.ToInt32(evt.KeyChar) == 13) && !(evt.KeyChar == (char)Keys.Back))
            {
                evt.Handled = true;
                lblError.Text = (texto + " Escribe solo números");
            }
        }

        public void limitarCaracteres(KeyPressEventArgs evt, String texto, int maximo, TextBox txtTexto, Label lblError)
        {
            if (txtTexto.Text.Length == maximo)
            {
                evt.Handled = true;
                lblError.Text = texto + " Longitud Máxima: " + maximo + " caracteres";
            }
            else
            {
                lblError.Text = "";
            }
        }

        public void escribirSoloDoubles(TextBox campo, KeyPressEventArgs evt, String texto, Label lblError, int numeroEnteros, int numeroDecimales)
        {

            String text = campo.Text;
            char caracter = evt.KeyChar;
            Boolean punto;

            punto = campo.Text.IndexOf('.') != -1;
            if (punto && caracter.Equals('.'))
            {
                lblError.Text = texto + " No puedes escribir más puntos";
                evt.Handled = true;
            }
            else
            {
                if (text.Equals("") && (!Char.IsDigit(caracter) || caracter == '0'))
                {
                    evt.Handled = true;
                    lblError.Text = texto + " El primer digito no puede ser un punto o un 0";

                }
                else
                {


                    if (!Char.IsDigit(caracter) && (text.Contains(".") && caracter != '.' && (!Char.IsDigit(caracter)) && !(caracter == (char)Keys.Back)))
                    {
                        evt.Handled = true;
                        lblError.Text = (texto + " Solo números y puntos");
                    }
                    else
                    {
                        if (text.Length >= numeroEnteros && caracter != 46 && !punto && !(caracter == (char)Keys.Back))
                        {
                            evt.Handled = true;
                            lblError.Text = texto + " No puedes escribir más enteros";
                        }
                        else
                        {
                            if (punto)
                            {
                                if (text.Substring(text.IndexOf('.')).Length > numeroDecimales && !(caracter == (char)Keys.Back))
                                {
                                    evt.Handled = true;
                                    lblError.Text = texto + "No puedes escribir más decimales";
                                }
                            }
                            else
                            {
                                lblError.Text = "";
                            }
                        }
                    }
                }

            }
        }
    }
}
