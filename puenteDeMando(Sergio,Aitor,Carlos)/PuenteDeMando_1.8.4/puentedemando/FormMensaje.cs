using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuenteDeMando
{
    public partial class FormMensaje : Form
    {
       private ListaEMensajes lmsg = new ListaEMensajes();//Lista de mensajes
        private Mensaje msg = null; //objeto mensaje
        private int fila = 0;// fila donde se va a guardar el mensaje en la tabla.
        private String ruta;
        private Boolean forzado;

        //Constructor
        public FormMensaje()
        {
            this.ruta = "./ficheroMensaje.txt";//ruta donde se va a guardar el mensaje
            borrarFichero(ruta);
            InitializeComponent();
            
            rellenarComboBox();
            forzado = false;
        }
        //Metodo para borrar el fichero al iniciar la aplicacion
        private void borrarFichero(String ruta)
        {
            if (System.IO.File.Exists(ruta))
            {
                try
                {
                    System.IO.File.Delete(ruta);
                }

                catch (System.IO.IOException e)
                {
                    MessageBox.Show("El fichero no existe");
                }

            }


        }
        //Metodo que rellena los dos comboBox 
        public void rellenarComboBox()
        {

            String[] matrizComboOrigen = { "Mercurio", "Venus", "La Tierra", "Marte", "Jupiter", "Saturno", "Urano","Pluton" };
            String[] matrizComboDestino = { "Mercurio", "Venus", "La Tierra", "Marte", "Jupiter", "Saturno", "Urano","Pluton" };

            for (int i = 0; i < matrizComboDestino.Length; i++)
            {
                cbOrigen.Items.Add(matrizComboOrigen[i]);
                cbDestino.Items.Add(matrizComboDestino[i]);
            }
            cbOrigen.SelectedItem = "Mercurio";//Seleccionar el primer planeta
            cbDestino.SelectedItem = "Mercurio";
        }
       
       //Metodo hace la copia de seguridad
        public void escribirMensaje()
        {
            int numFilas = dgvTabla.Rows.Count;//Cuenta el numero de filas que tiene la tabla
            String txtOrigen = "";
            String txtDestino = "";
            String texto = "";
                   
                //crea el fichero 
                System.IO.StreamWriter file = new System.IO.StreamWriter(this.ruta, true);
                //Crear objeto StringBuilder para escribir un texto
                StringBuilder sb = new StringBuilder();
                
                //Mientras la lista mensaje esta vacia
                while( !lmsg.Is_Empty()) 
                {
                    //devuelve el primer mensaje de la lista, con el origen,destino y el texto. Despues borra el msg de la lista
                    Mensaje msg = lmsg.Get_First();
                    txtOrigen=msg.getOrigen();
                    txtDestino = msg.getDestino();
                    texto = msg.getMensaje();
                    lmsg.Remove_First();

                //Agregar mensaje al objeto
                sb.AppendLine("Origen: " + txtOrigen + "#" + " Destino: " + txtDestino + "#" + " Texto: " + texto + "##");
                
                
                }
                //escribe el mensaje en el fichero de texto
                file.WriteAsync(sb.ToString());
                file.Close();
        }

       //Metodo para limpiar los comboBox y el mensaje de texto
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbOrigen.SelectedItem = "Mercurio";
            cbDestino.SelectedItem = "Mercurio";
            cajaTexto.Text = "";
        }

        //Metodo que se ejecuta al pulsar el boton Forzar seguridad, guarda el mensaje en el fichero
        private void btnForzarSeguridad_Click(object sender, EventArgs e)
        {
            //Cuenta el numero de filas
            int numFilas = dgvTabla.Rows.Count;
            if(numFilas>1){
                forzado = true;
                escribirMensaje();                
                MessageBox.Show("Copia de seguridad forzada");
            }
            else
            {
                MessageBox.Show("Primero debe haber un mensaje");
            }
            
        }

        private void btnIrPuenteMando_Click(object sender, EventArgs e)
        {
            this.Hide();//oculta la venta de mensaje
        }

        //Metodo que se ejecuta al pulsar el boton guardar. Guarda el mensaje en la tabla (dgvTabla)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String txtOrigen = cbOrigen.SelectedItem.ToString();//recoger el planeta de origen seleccionado
            String txtDestino = cbDestino.SelectedItem.ToString();//recoger el planeta de destino seleccionado

            if (!txtOrigen.Equals(txtDestino))//Comprar que los dos planetas no son iguales
            {
                String texto = cajaTexto.Text;//recoger el contenido del mensaje
                msg = new Mensaje(txtOrigen, txtDestino, texto);
                if (texto.Equals(""))
                {
                    MessageBox.Show("Introduce un mensaje, Please");
                }
                else
                {
                    dgvTabla.Rows.Add();
                    int numFilas = dgvTabla.Rows.Count;//traza para saber cuantas filas hay en la tabla
                    
                    dgvTabla.Rows[fila].Cells[0].Value = txtOrigen;
                    dgvTabla.Rows[fila].Cells[1].Value = txtDestino;
                    dgvTabla.Rows[fila].Cells[2].Value = texto;
                    fila++;

                    lmsg.Add_Last(msg);//añadir el mensaje al final de la lista
                }

            }
            else
            {
                MessageBox.Show("No puedes seleccionar el mismo planeta");
            }
        }
        //Metodo que deshabilita los botones 
        public void deshabilitarBotones()

        {
            btnForzarSeguridad.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            cbDestino.Enabled = false;
            cbOrigen.Enabled = false;
            cajaTexto.Enabled = false;
        }
        //tiempo que va transcurriendo en la barra de progreso, es el tiempo para hacer la copia de seguridad automatica.
        public void tiempo(int tiempo)
        {
            progressBar1.Value = tiempo;
            if (tiempo == 0)
            {
                progressBar1.Value = 20;
                escribirMensaje();
                MessageBox.Show("Haciendo copia de seguridad");
            }
        }
        //metodo que devuelve la ruta del fichero
        public String getRuta()
        {
            return this.ruta;
        }
        //metodo que cambia la ruta a usar
        public void setRuta(String ruta)
        {
            this.ruta = ruta;
        }

        //metodo que comprueba si se forzo el guardado
        public Boolean getForzado()
        {
            return this.forzado;
        }
        //metodo que actualiza el atributo forzado
        public void setForzado(Boolean forzado)
        {
            this.forzado = forzado;
        }



    }
}
