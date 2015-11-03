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
    public partial class AboutUsGUI : Form
    {
        public AboutUsGUI()
        {
            InitializeComponent();
            
        }

        //Oculta la ventana AboutUs
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
