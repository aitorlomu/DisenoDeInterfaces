using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PuenteDeMando
{
    public class Oficial
    {
        /////////////
        //ATRIBUTOS//
        /////////////

        //Atributo que indica si el personaje ocupa el puesto de oficial
        protected String nombre;
        protected Boolean puesto;
        protected int claveoficial;
        protected String graduacion;
        protected Image foto;
        protected String raza;

        ///////////////
        //CONSTRUCTOR//
        ///////////////

        //Constructor que crea un objeto vacio
        public Oficial()
        {}

        public Oficial(String nombre,Boolean p_puesto, int p_claveoficial, String p_graduacion, Image cara, String raza)
        {
            this.nombre = nombre;
            this.puesto = p_puesto;
            this.claveoficial = p_claveoficial;
            this.graduacion = p_graduacion;
            this.foto = cara;
            this.raza = raza;
        }

        ///////////////////
        //METODOS GET-SET//
        ///////////////////

        //METODOS GET
        public String getNombre()
        {
            return this.nombre;
        }
        public Boolean getPuesto()
        {
            return this.puesto;
        }
        public int getClave()
        {
            return this.claveoficial;
        }
        //metodo devolver graduación
        public String getGraduacion()
        {
            return this.graduacion;
        }
        public Image getFoto()
        {
            return this.foto;
        }
        public String getRaza()
        {
            return this.raza;
        }
        //METODOS SET
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setPuesto(Boolean p_puesto)
        {
            this.puesto = p_puesto;
        }
        public void setClave(int p_claveoficial)
        {
            this.claveoficial = p_claveoficial;
        }
        //metodo cambiar graduacion
        public void setGraduacion(String p_graduacion)
        {
            this.graduacion = p_graduacion;
        }
        public void setFoto(Image cara)
        {
            this.foto = cara;
        }
        public void setRaza(String raza)
        {
            this.raza = raza;
        }
        ////////////////////
        //METODOS PUBLICOS//
        ////////////////////
        public Boolean isOficial()
        {
            return this.puesto;
        }

    }
}
