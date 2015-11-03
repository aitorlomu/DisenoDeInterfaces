using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuenteDeMando
{
    public partial class Autodestruccion : Form
    {
        
        public Autodestruccion()
        {
           
            InitializeComponent();
        }
        private void Autodestruccion_Load(object sender, EventArgs e)
        {
            BWAutodestruccion.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BWAutodestruccion.CancelAsync();
            finalizado();
        }

        private void BWAutodestruccion_DoWork(object sender, DoWorkEventArgs e)
        {
            BWAutodestruccion.WorkerReportsProgress = true;
            BWAutodestruccion.WorkerSupportsCancellation = true;
            for (int i = 10; i >= 0; i--)
            {
                if (BWAutodestruccion.CancellationPending == true) { break; }
                Thread.Sleep(1000);
                BWAutodestruccion.ReportProgress(i);
            }
            finalizado();
        }

        private void BWAutodestruccion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prAutodestruccion.Value = e.ProgressPercentage;
            lbtiempo.Text = Convert.ToString(e.ProgressPercentage);
        }
        private void finalizado()
        {
            if (BWAutodestruccion.CancellationPending == false)
            {
                
                //Se crea una instancia de la clase SoundPlayer 
                //que le pasa como parametro al constructo la ruta del archivo 
                //con la propiedad FileName del OpenFileDialog 
                SoundPlayer player = new SoundPlayer("./explosion-01.wav");
                //Llama el metodo Play del SoundPlayer para reproducir el audio,musica,etc 
                player.Play();
                BWAutodestruccion.CancelAsync();
                try
                {
                    Process.Start("notepad.exe", "./ficheroMensaje.txt");
                }
                catch (Exception e)
                {

                }

                Thread.Sleep(6500);
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
    }
}
