using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PuenteDeMando
{
    class Vulcanos : Oficial 
    {
        ////////////
        //ATRIBUTO//
        ////////////
        private Boolean sectaRomulano;

        ///////////////
        //CONSTRUCTOR//
        ///////////////
        public Vulcanos(String nombre,Boolean puesto, int claveoficial,String graduacion, Boolean secta, Image foto)
        {
            base.nombre = nombre;
            base.puesto = puesto;
            base.claveoficial = claveoficial;
            base.graduacion = graduacion;
            this.sectaRomulano = secta;
            base.foto = foto;
            base.raza = "VULCANO";
        }

        ///////////////////
        //METODOS GET-SET//
        ///////////////////
        public Boolean getSecta()
        {
            return this.sectaRomulano;
        }
        public void setSecta(Boolean pertenece)
        {
            this.sectaRomulano = pertenece;
        }
    }
}
