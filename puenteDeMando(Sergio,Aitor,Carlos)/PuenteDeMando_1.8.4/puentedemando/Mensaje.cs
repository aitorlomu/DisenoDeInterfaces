using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuenteDeMando
{

        public class Mensaje
        {

            //Atributos
            private String mensaje;
            private String origen;
            private String destino;

            /**
             * Enlace
             */
           public Mensaje mensajesig;
            //Constructor

            public Mensaje(String origen, String destino, String texto)
            {
                this.origen = origen;
                this.destino = destino;
                this.mensaje = texto;
                this.mensajesig = null;
            }

            //Getters
            public String getMensaje()
            {
                return mensaje;
            }

            public String getOrigen()
            {
                return origen;
            }

            public String getDestino()
            {
                return destino;
            }
            public Mensaje getMensajesig()
            {
                return mensajesig;
            }
            //Fin Getters

            public String toString()
            {
                String texto;
                texto = origen + " le dice a " + destino + ": " + "''" + mensaje + "''";
                return texto;

            }


        }




}

