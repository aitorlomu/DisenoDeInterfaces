using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuenteDeMando
{
    class Casilla
    {
        //##########################################################################
        //##########################     ATRIBUTOS    ##############################
        //##########################################################################

        private int id;
        private int valor;
        private Boolean daniado;
        private int contador = 0;
        private int x;
        private int y;


        //##########################################################################
        //########################     CONSTRUCTORES    ############################
        //##########################################################################
        public Casilla(int x, int y)
        {
            this.id = contador;
            contador++;
            this.x = x;
            this.y = y;
            this.valor = MetodosAuxiliares.RandomNumber(50,101);
            this.daniado = false;
        }

        //##########################################################################
        //######################     GETTERS Y SETTERS    ##########################
        //##########################################################################
        public Boolean getDaniado()
        {
            return daniado;
        }
        public int getId()
        {
            return id;
        }
        public int getValor()
        {
            return valor;
        }
        public void setValor(int valor)
        {
            this.valor = valor;
        }
        public void setDaniado(Boolean danio)
        {
            this.daniado = danio;
        }



    }
}
