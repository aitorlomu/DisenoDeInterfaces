using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PuenteDeMando
{

    //Interfaz principal del Puente de Mando
    public partial class PuenteDeMandoGUI : Form
    {
        //##########################################################################
        //##########################     ATRIBUTOS    ##############################
        //##########################################################################
        public static EscudoGUI egui;
        private static VentanaOficial ventOficial;
        private static FormMensaje ventMensajes;
        private static AboutUsGUI au;
        private static SoundPlayer playFondo;



        //##########################################################################
        //########################     CONSTRUCTORES    ############################
        //##########################################################################
        public PuenteDeMandoGUI()
        {
            
            InitializeComponent();
            ventOficial = new VentanaOficial();
            ventMensajes = new FormMensaje();
            egui = new EscudoGUI();
            prBproteccion.Value = egui.getSanos();
            au = new AboutUsGUI();
            actualizaOficiales();
            lbFecha.Text = "20141";
            playFondo = new SoundPlayer(PuenteDeMando.Properties.Resources.Star_Trek___VOY_Theme);

            
        }

        //##########################################################################
        //###########################     MÉTODOS    ###############################
        //##########################################################################

        //Actualiza los labels con los nombres del oficial y del primer suboficial
        private void actualizaOficiales()
        {
            lbNombreOfi.Text = ventOficial.getNombreOficial();
            lbNombreSub.Text = ventOficial.getNombreSuboficial();
        }

        //Actualiza la fecha estelar
        private void actualizaFecha()
        {
            double fecha = Convert.ToDouble(lbFecha.Text);
            lbFecha.Text = Convert.ToString(fecha + 0.1);
        }
        
 

        //Ejecuta las tareas necesarias para finalizar la simulación
        private void finalizarSimulacion()
        {
            
            ventOficial.deshabilitarBotones();
            ventMensajes.deshabilitarBotones();
            btFinalizarSim.Enabled = false;
            
            
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("¿Desea iniciar la autodestrucción?", "Autodestrucción", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Autodestruccion lastventana = new Autodestruccion();
                lastventana.Opacity = .95;
                lastventana.StartPosition = FormStartPosition.CenterScreen;
                lastventana.Show();
            }
            else
            {
                MessageBox.Show("Simulacion finalizada. Puede visualizar el estado de la nave");
            }
        }

        //##########################################################################
        //###########################     EVENTOS    ###############################
        //##########################################################################

        //evento de finalizar simulación al clickear el botón finalizar simulación
        private void btFinalizarSim_Click(object sender, EventArgs e)
        {
            BWprSimulacion.CancelAsync();
            BWprJubilacion.CancelAsync();
            BWprMensaje.CancelAsync();
            BWescudo.CancelAsync();
            BWeligeCasillas.CancelAsync();
            finalizarSimulacion();
            mItFinalizar.Enabled = false;
        }

        //BW para el escudoGUI que elige 2 casillas del escudo cada segundo y realiza diversas tareas
        private void BWeligeCasillas_DoWork(object sender, DoWorkEventArgs e)
        {
            BWeligeCasillas.WorkerReportsProgress = true;
            BWeligeCasillas.WorkerSupportsCancellation = true;
            for (int i = 5; i >= 0; i--)
            {
                if (BWeligeCasillas.CancellationPending == true) { break; }
                // Wait 1000 milliseconds.
                Thread.Sleep(1000);
                // Report progress.
                BWeligeCasillas.ReportProgress(i);
                if (i == 0)
                {
                    i = 5;
                    egui.eligeCasillas();
                }

            }
        }

        //BW cambia el progressbar del EscudoGUI al resetearse la progressbar
        private void BWeligeCasillas_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            egui.actualizaBarraCasillas(e.ProgressPercentage);

        }

        //BW comprueba el daño del escudo al finalizar los 30 segs
        private void BWescudo_DoWork(object sender, DoWorkEventArgs e)
        {
            BWescudo.WorkerReportsProgress = true;
            BWescudo.WorkerSupportsCancellation = true;
            for (int i = 30; i >= 0; i--)
            {
                if (BWescudo.CancellationPending == true) { break; }
                // Wait 1000 milliseconds.
                Thread.Sleep(1000);
                // Report progress.
                BWescudo.ReportProgress(i);
                if (i == 0)
                {
                    i = 30;
                    egui.comprobarDanio();
                }


            }
        }

        //BW que actualiza el estado del progressbar del escudo y el label de casillas dañadas del EscudoGUI
        private void BWescudo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            egui.actualizaBarra(e.ProgressPercentage);
            egui.actualizarLabel();
            prBproteccion.Value = egui.getEscudo().getSanos();
            egui.cambiaPBdanio();
            if (prBproteccion.Value <= 64 && prBproteccion.Value > 48)
            {
                pbImgNave.Image = PuenteDeMando.Properties.Resources.uss_enterprise_100_;
            }
            if (prBproteccion.Value <= 48 && prBproteccion.Value > 32)
            {
                pbImgNave.Image = PuenteDeMando.Properties.Resources.uss_enterprise_75_;
            }
            if (prBproteccion.Value <= 32 && prBproteccion.Value > 13)
            {
                pbImgNave.Image = PuenteDeMando.Properties.Resources.uss_enterprise_50_;
            }
            if (prBproteccion.Value <= 13 && prBproteccion.Value > 0)
            {
                pbImgNave.Image = PuenteDeMando.Properties.Resources.uss_enterprise_20_;
            }
            if (prBproteccion.Value == 0)
            {
                pbImgNave.Image = PuenteDeMando.Properties.Resources.uss_enterprise_0_;
                playFondo.Stop(); //Para la cancion
            }
        }

        //Worker encargado de controlar los tiempos de los oficiales al mando
        private void BWprJubilacion_DoWork(object sender, DoWorkEventArgs e)
        {
            BWprJubilacion.WorkerReportsProgress = true;
            BWprJubilacion.WorkerSupportsCancellation = true;
            for (int i = 60; i >= 0; i--)
            {
                if (BWprJubilacion.CancellationPending == true) { break; }
                // Wait 1000 milliseconds.
                Thread.Sleep(1000);
                // Report progress.
                BWprJubilacion.ReportProgress(i);
                if (i == 0 || ventOficial.cambioMando() == true) { i = 60; }

            }
        }

        //worker asociado con el anterior el cual realiza los cambios
        private void BWprJubilacion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            prJubilacion.Value = e.ProgressPercentage;
            ventOficial.tiempo(e.ProgressPercentage);

            actualizaOficiales();
        }

        //Worker en cargado de controlar los tiempos de la grabacion de seguridad de los mensajes
        private void BWprMensaje_DoWork(object sender, DoWorkEventArgs e)
        {
            BWprMensaje.WorkerReportsProgress = true;
            BWprMensaje.WorkerSupportsCancellation = true;
            for (int i = 20; i >= 0; i--)
            {
                if (BWprMensaje.CancellationPending == true) { break; }
                // Wait 1000 milliseconds.
                Thread.Sleep(1000);
                // Report progress.
                BWprMensaje.ReportProgress(i);
                if (i == 0 || ventMensajes.getForzado() == true) { i = 20; ventMensajes.setForzado(false); }
            }
        }
        //metodo del worker encargado de realizar los cambios
        private void BWprMensaje_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ventMensajes.tiempo(e.ProgressPercentage);
            ventMensajes.escribirMensaje(); //Metodo hace la copia de seguridad
        }


        //BW para el tiempo de simulación del puente de mando
        private void BWprSimulacion_DoWork(object sender, DoWorkEventArgs e)
        {
            BWprSimulacion.WorkerReportsProgress = true;
            BWprSimulacion.WorkerSupportsCancellation = true;
            for (int i = 0; i <= 600; i++)
            {
                if (BWprSimulacion.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                Thread.Sleep(1000);
                BWprSimulacion.ReportProgress(i);
            }

        }

        //BW cambia el progressbar del tiempo de simulación del puente de mando
        private void BWprSimulacion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prBejecucion.Value = e.ProgressPercentage;
            actualizaFecha();
        }

        
        //BW que al finalizar la simulación activa la finalización del programa
        private void BWprSimulacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == false)
            {
                BWprSimulacion.CancelAsync();
                BWprJubilacion.CancelAsync();
                BWprMensaje.CancelAsync();
                BWescudo.CancelAsync();
                BWeligeCasillas.CancelAsync();
                finalizarSimulacion();
            }


        }
        


        //Evento al seleccionar salir en el menú
        private void MenuSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Evento al seleccionar finalizar en el menú
        private void mItFinalizar_Click(object sender, EventArgs e)
        {
            finalizarSimulacion();
            mItFinalizar.Enabled = false;
        }

        //Muestra la GUI del AboutUs
        private void MostrarAboutUs(object sender, EventArgs e)
        {
            au.StartPosition = FormStartPosition.CenterScreen;
            au.Opacity = .95;
            au.Show();
        }

        //Muestra la GUI de las comunicaciones
        private void MostrarComunicaciones(object sender, EventArgs e)
        {
            ventMensajes.StartPosition = FormStartPosition.CenterScreen;
            ventMensajes.Opacity = .95;
            ventMensajes.Show();
        }

        //Muestra la GUI del escudo
        private void MostrarEscudo(object sender, EventArgs e)
        {
            egui.Opacity = .95;
            egui.StartPosition = FormStartPosition.CenterScreen;
            egui.Show();
        }


        //Muestra la GUI de los oficiales
        private void MostrarVentanaOficiales(object sender, EventArgs e)
        {
            ventOficial.StartPosition = FormStartPosition.CenterScreen;
            ventOficial.Opacity = .95;
            ventOficial.Show();
        }


        //Acciones que realiza el programa al iniciar la interfaz gráfica
        private void PuenteDeMandoGUI_Load(object sender, EventArgs e)
        {
            //Se inicia el backgroundworker
            BWprSimulacion.RunWorkerAsync();
            BWprJubilacion.RunWorkerAsync();
            BWprMensaje.RunWorkerAsync();
            BWescudo.RunWorkerAsync();
            BWeligeCasillas.RunWorkerAsync();
            playFondo.PlayLooping();// Vuelve a reproducir la cancion
            
        }
    }
}
