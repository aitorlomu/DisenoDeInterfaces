using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.DataAccess.Client;
using System.Drawing;
using System.Text.RegularExpressions;

namespace MySleepy
{
    class Validaciones
    {
        // Valida que se introduzca un entero limitado por un máximo
        // evt Evento KeyPress
        // texto Texto que queramos introducir
        // maximo Maximo de caracteres que queramos poner
        // txtTexto el textbox a validar
        // lblError la etiqueta que mostrará el error
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

        // Controla que se introduzca un numero de caracteres determinado
        // evt Evento KeyPress
        // texto Texto que queramos introducir
        // maximo Maximo de caracteres que queramos poner
        // txtTexto el textbox a validar
        // lblError la etiqueta que mostrará el error
        public void limitarCaracteres(KeyPressEventArgs evt, String texto, int maximo, TextBox txtTexto, Label lblError)
        {

            if (Convert.ToInt32(evt.KeyChar) == 39)
            {
                evt.Handled = true;
                lblError.Text = "¡Vas a pillar eh!. No puedes introducir la comilla simple";
            }
            else
            {
                if (txtTexto.Text.Length == maximo && !(evt.KeyChar == (char)Keys.Back))
                {
                    evt.Handled = true;
                    lblError.Text = texto + " Longitud Máxima: " + maximo + " caracteres";
                }
                else
                {
                    lblError.Text = "";
                }
            }
           
        }


        // Controla que se escriba solo doubles
        // evt Evento KeyPress
        // texto Texto que queramos introducir
        // maximo Maximo de caracteres que queramos poner
        // txtTexto el textbox a validar
        // lblError la etiqueta que mostrará el error
        // numeroEnteros numero de caracteres enteros
        // numeroDecimales numero de decimales
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
                if (text.Equals("") && (!Char.IsDigit(caracter)))
                {
                    evt.Handled = true;
                    lblError.Text = texto + " El primer digito no puede ser un punto";

                }
                else
                {


                    if (!Char.IsDigit(caracter) && (text.Contains(".") && caracter != '.' && !(caracter == (char)Keys.Back)))
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
                                if(!Char.IsDigit(caracter) && !(caracter==(char)Keys.Back) && caracter!='.'){
                                    evt.Handled = true;
                                    lblError.Text = texto + " Solo numeros y puntos";
                                }
                            }
                        }
                    }
                }

            }
           
            
        }
		
		
		public Boolean ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El email no es correcto");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El email no es correcto");
                return false;
            }
        }
    }
}
