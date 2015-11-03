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
    //Clase de la interfaz gráfica del Escudo
    public partial class EscudoGUI : Form
    {

        //##########################################################################
        //##########################     ATRIBUTOS    ##############################
        //##########################################################################

        //Objeto escudo
        public Escudo escudo;

        //##########################################################################
        //########################     CONSTRUCTORES    ############################
        //##########################################################################
        //Constructor
        public EscudoGUI()
        {
            InitializeComponent();
            escudo = new Escudo(8, 8);
            dgvEscudo.RowCount = 8;
            dgvEscudo.ColumnCount = 8;
            escudo.iniciarEscudo(dgvEscudo);
            comprobarDanio();
            prBEscudo.Value = escudo.getSanos();
        }

        //##########################################################################
        //######################     GETTERS Y SETTERS    ##########################
        //##########################################################################
        public int getSanos()
        {
            return escudo.getSanos();
        }

        public Escudo getEscudo()
        {
            return this.escudo;
        }


        //##########################################################################
        //###########################     MÉTODOS    ###############################
        //##########################################################################

        //Actualiza la progressbar para el tiempo de espera de comprobación del escudo 
        internal void actualizaBarra(int p)
        {
            pbComprobacion.Value = p;
        }

        //Actualiza la progressbar para el tiempo de espera hasta la elección de 2 casillas
        internal void actualizaBarraCasillas(int p)
        {
            pbEligeCasillas.Value = p;
        }

        //Cambia el número de casillas dañadas al realizar la comprobación del escudo 
        public void actualizarLabel(){
            escudo.actualizaLabel(lbDaniadas);
        }

        //Actualiza la progressbar de la salud actual del escudo (al realizar la comprobación del escudo) 
        public void cambiaPBdanio()
        {
            prBEscudo.Value = escudo.getSanos();
        }

        //Comprueba lo dañado que está el escudo del objeto escudo 
        public void comprobarDanio(){
            escudo.compruebaEscudo();
            
        }
        
        //Llama al método del escudo para elegir 2 casillas al azar del DGV
        public void eligeCasillas()
        {
            escudo.eligeCasillas(dgvEscudo);
        }





        //##########################################################################
        //###########################     EVENTOS    ###############################
        //##########################################################################

        //Oculta la ventana EscudoGUI
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }





    }
}
