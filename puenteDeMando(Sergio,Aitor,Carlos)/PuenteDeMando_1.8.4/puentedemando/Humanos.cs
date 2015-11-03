using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PuenteDeMando
{
    class Humanos : Oficial
    {
        /////////////
        //ATRIBUTOS//
        /////////////
        private String especialidad;
        private String planeta;

        ///////////////
        //CONSTRUCTOR//
        ///////////////

        public Humanos(String nombre,Boolean puesto, int claveoficial, String graduacion, int especialidad, String planeta, Image foto)
        {
            base.nombre = nombre;
            base.puesto = puesto;
            base.claveoficial = claveoficial;
            base.graduacion = graduacion;
            selectEspeciality(especialidad);
            this.planeta = planeta;
            base.foto = foto;
            base.raza = "HUMANO";
        }

        ///////////////////
        //METODOS GET-SET//
        ///////////////////
        public String getEspecialidad()
        {
            return this.especialidad;
        }
        public String getPlaneta()
        {
            return this.planeta;
        }
        public void setEspecialidad(String new_especialidad)
        {
            this.especialidad = new_especialidad;
        }
        public void setPlaneta(String new_planeta)
        {
            this.planeta = new_planeta;
        }

        //////////////////
        //METODO PRIVADO//
        //////////////////
        private void selectEspeciality(int especialidad)
        {
            String[] especialidades = { "combate", "comunicaciones" };
            this.especialidad = especialidades[especialidad];
        }
    }
}
