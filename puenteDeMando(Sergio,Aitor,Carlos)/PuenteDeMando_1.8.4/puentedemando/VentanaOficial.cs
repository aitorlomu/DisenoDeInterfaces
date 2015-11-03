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
    public partial class VentanaOficial : Form
    {
        private ListaOficiales oficiales;
        private String nombreOficial;
        private String nombreSuboficial;
        private Boolean cambioOficial;
        public VentanaOficial()
        {
            oficiales = MetodosAuxiliares.crearTripulacion();
            InitializeComponent();
            actualizaListBox();
        }

        private void VentanaOficial_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new System.Drawing.Bitmap(PuenteDeMando.Properties.Resources.Oficial);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Metodo que rellena el listBox de la interfaz
        private void rellenaListBox()
        {
            int cantidad = oficiales.elements();
            String nombre;
            Oficial aux;
            for (int x = 1; x <= cantidad; x++)
            {
                aux = oficiales.getPosition(x);
                nombre = aux.getNombre();
                listOficiales.Items.Insert(x-1, nombre);
            }
        }
        //Metodo que actualiza el listBox de la interfaz con el nuevo orden en el que se encuentren los oficiales
        private void actualizaListBox()
        {
            Oficial aux = oficiales.Get_First();
            this.nombreOficial = aux.getNombre();
            aux = oficiales.getPosition(2);
            this.nombreSuboficial = aux.getNombre();
            Console.WriteLine(nombreOficial + " " + nombreSuboficial);
            listOficiales.Items.Clear();
            rellenaListBox();
            actualizaOficial();
            cambioOficial = false;
        }

        private void btnAscender_Click(object sender, EventArgs e)
        {
            if (listOficiales.SelectedItem != null)
            {
                String nombre = listOficiales.SelectedItem.ToString();//se coge el item seleccionado en el listbox
                int posicion = oficiales.getOficial(nombre.Trim());//busco la posicion de ese oficial en la lista enlazada
                if (posicion != 0)
                {
                    this.cambioOficial = true;
                    Oficial aux = oficiales.getPosition(posicion);//almaceno ese oficial en un auxiliar
                    oficiales.Remove_Position(posicion);//lo elimino de la lista enlazada
                    oficiales.Add_First(aux);//lo añado al principio de esta
                    MessageBox.Show("Se ha nombrado un nuevo oficial en funciones");
                    actualizaListBox();//actualizo el listBox()                    
                }
                else { MessageBox.Show("Oficial no encontrado"); }
            }
        }

        private void btnDegradar_Click(object sender, EventArgs e)
        {
            if (listOficiales.SelectedItem != null)
            {
                String nombre = listOficiales.SelectedItem.ToString();//se coge el item seleccionado en el listbox
                int posicion = oficiales.getOficial(nombre);//busco la posicion de ese oficial en la lista enlazada
                if (posicion == 1)
                {
                    this.cambioOficial = true;
                    MessageBox.Show("Se ha degradado al oficial en funciones");
                    progressBar1.Value = 60;
                }  
                degradar(posicion);
            }
        }
        //Metodo que degrada al oficial al cargo
        private void degradar(int posicion)
        {
            if (posicion != 0)
            {
                Oficial aux = oficiales.getPosition(posicion);//almaceno ese oficial en un auxiliar
                oficiales.Remove_Position(posicion);//lo elimino de la lista enlazada
                aux.setPuesto(false);//indico que ya no esta al cargo
                oficiales.Add_Last(aux);//lo añado al final de esta
                actualizaListBox();//actualizo el listBox() 
            }
        }
        //Metodo que actualiza la interfaz con los datos del nuevo ofical en funciones
        private void actualizaOficial()
        {
            Oficial aux = oficiales.Get_First();
            Humanos aux1;
            Vulcanos aux2;
            lNombre.Text = aux.getNombre();
            lGraduacion.Text = aux.getGraduacion();
            if (aux.getRaza().ToUpper().Equals("HUMANO"))
            {
                aux1 = (Humanos) aux;
                lEspSect.Text = aux1.getEspecialidad();
            }
            else
            {
                if (aux.getRaza().ToUpper().Equals("VULCANO"))
                {
                    aux2 = (Vulcanos)aux;
                    if(aux2.getSecta() == true){
                        lEspSect.Text ="Secta romulana";
                    }
                    else { lEspSect.Text = "No pertenece a ninguna secta"; }                    
                }
            }
            lRaza.Text = aux.getRaza();
            lClave.Text = Convert.ToString(aux.getClave());
            pictureBox1.Image = aux.getFoto();
            aux.setPuesto(true);
        }
        //Metodo que deshabilita los botones 
        public void deshabilitarBotones()
        {
            btnAscender.Enabled = false;
            btnDegradar.Enabled = false;
        }
        //Metodo que controla el progressbar
        public void tiempo(int tiempo)
        {
            progressBar1.Value = tiempo;
            if (tiempo == 0)
            {
                progressBar1.Value = 60;
                this.cambioOficial = true;
                MessageBox.Show("Se ha acabado el tiempo de mandato del oficial en funciones");
                degradar(1);                
            }
        }
        //Metodo que devuelve el nombre del oficial al mando
        public String getNombreOficial()
        {
            return this.nombreOficial;
        }
        //Metodo que devuelve el nombre del segundo de abordo
        public String getNombreSuboficial()
        {
            return this.nombreSuboficial;
        }
        //Metodo que devuelve si se ha producido un cambio de funciones
        public Boolean cambioMando()
        {
            return this.cambioOficial;
        }
    }
}
