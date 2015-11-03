using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PuenteDeMando
{
    public class MetodosAuxiliares
    {
        private static String[] nombres = {"Kirk","Ohara","Zulu","McCoy","Spock","Soval","Tuvok"};
        private static String[] graduacion = {"Capitan", "Sargento", "Alferez", "subteniente", "Teniente", "Soldado raso", "Cabo" };
        private static Image[] fotos = {PuenteDeMando.Properties.Resources.kirk,PuenteDeMando.Properties.Resources.Ohara,PuenteDeMando.Properties.Resources.Zulu,
                                       PuenteDeMando.Properties.Resources.McCoy,PuenteDeMando.Properties.Resources.Spock,PuenteDeMando.Properties.Resources.Soval,
                                       PuenteDeMando.Properties.Resources.Tuvok};
        private static String[] planetas = { "Tierra", "Marte"};
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        //Metodo que genera la tripulacion
        public static ListaOficiales crearTripulacion()
        {
            ListaOficiales aux = new ListaOficiales();
            Humanos humano;
            Vulcanos vulcano;
            int especialidad,planeta;
            Boolean secta;
            for (int i = 0; i < nombres.Length; i++ )
            {
                if (i <= 3)
                {
                    if(i == 0 || (i % 2) == 0)
                    {
                        especialidad = 0;
                        planeta = 0;
                    }
                    else{especialidad = 1;planeta = 1;}
                    humano = new Humanos(nombres[i], false, randomClave(), graduacion[i], especialidad, planetas[planeta],fotos[i]);
                    aux.Add_Last(humano);
                }
                else
                {
                    if((i % 2) != 0){secta =true;}
                    else{secta = false;}
                    vulcano = new Vulcanos(nombres[i], false, randomClave(), graduacion[i], secta,fotos[i]);
                    aux.Add_Last(vulcano);
                }
            }
            return aux;
        }
        //Metodo que genera aleatoriamente la clave de oficial
        private static int randomClave()
        {
            int num;
            lock (syncLock)
            { // synchronize
                num = random.Next(1, 999);
            }
            return num;
        }
        public static int RandomNumber(int min, int max)
        {

            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

    }
}
