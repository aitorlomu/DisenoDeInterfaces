using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuenteDeMando
{
    public class Escudo{

        //##########################################################################
        //##########################     ATRIBUTOS    ##############################
        //##########################################################################

        private Casilla[,] escudo;
        private int danio;
        private int x;
        private int y;
        private int sanos;


        //##########################################################################
        //########################     CONSTRUCTORES    ############################
        //##########################################################################

        public Escudo(int tamaniox,int tamanioy)
        {
            this.x = tamaniox;
            this.y = tamanioy;
            this.escudo = new Casilla[x, y];
            this.danio = 0;
            this.sanos= 64;
        }


        //##########################################################################
        //######################     GETTERS Y SETTERS    ##########################
        //##########################################################################

        public int getSanos()
        {
            return sanos;
        }


        //##########################################################################
        //###########################     MÉTODOS    ###############################
        //##########################################################################


        /*Dada unas coordenadas en el DGV, comprobará si la casilla está dañada 
         * y si no lo está si sale 0,1 ó 2 se dañará dicha casilla y si es del 3 al 10 cambiará el estado de vida de la casilla
         */
        private void accionCasilla(int x, int y, DataGridView dgvEscudo)
        {
            //Comprueba si está dañado
            if (escudo[x, y].getDaniado() == false)
            {

                int num = MetodosAuxiliares.RandomNumber(0, 11);//genera un número
                //MessageBox.Show("valor de num=" + num);
                if (num < 3)//Se refiere al porcentaje <=20% y daña la casilla
                {
                    escudo[x, y].setValor(0);
                    escudo[x, y].setDaniado(true);
                    dgvEscudo.Rows[y].Cells[x].Value = Properties.Resources.celdaEscudoBad;
                    dgvEscudo.Rows[y].Cells[x].ToolTipText = "Salud:" + escudo[x, y].getValor() + "%";

                }
                else
                {
                    escudo[x, y].setValor(MetodosAuxiliares.RandomNumber(0, 100));//genera un nuevo valor a la casilla

                }

            }
        }

        //Actualiza el label del EscudoGUI pasado por parámetro con el número de casillas dañadas
        internal void actualizaLabel(Label lbDaniadas)
        {
            lbDaniadas.Text = "" + danio;
        }

        //Comprueba el estado del escudo
        public void compruebaEscudo()
        {
            sanos = 64;
            danio = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (escudo[i, j].getDaniado())
                    {
                        danio++;
                    }
                }
            }
            sanos = sanos - danio;
            //PuenteDeMandoGUI.egui.estadoEscudo(sanos);

            if ((danio * 100) / 64 >= 80)
            {
                MessageBox.Show("ESTADO CRÍTICO \n El sistema de protección tiene un daño mayor al 80%");
            }
        }

        //Elige 2 casillas al azar y realizará diversas tareas
        public void eligeCasillas(DataGridView dgvEscudo)
        {
            accionCasilla(MetodosAuxiliares.RandomNumber(0, 8), MetodosAuxiliares.RandomNumber(0, 8), dgvEscudo);
            accionCasilla(MetodosAuxiliares.RandomNumber(0, 8), MetodosAuxiliares.RandomNumber(0, 8), dgvEscudo);
        }

        

        
        //Inicia el escudo y lo carga en el DGV
        public void iniciarEscudo(DataGridView dgvEscudo)
        {
            
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    escudo[i,j]=new Casilla(i,j);

                    if (escudo[i, j].getValor() < 50)
                    {
                        dgvEscudo.Rows[j].Cells[i].Value = PuenteDeMando.Properties.Resources.celdaEscudoBad;
                        dgvEscudo.Rows[j].Cells[i].ToolTipText = "Salud:" + escudo[i, j].getValor() + "%";
                    }
                    else
                    {
                        dgvEscudo.Rows[j].Cells[i].Value = PuenteDeMando.Properties.Resources.celdaEscudoGood;
                        dgvEscudo.Rows[j].Cells[i].ToolTipText = "Salud:" + escudo[i, j].getValor() + "%";
                    }
                    //PuenteDeMandoGUI.egui.getTable().GetControlFromPosition(i, j).BackColor = System.Drawing.Color.Green;

                }
            }
            
        }



    }
}
