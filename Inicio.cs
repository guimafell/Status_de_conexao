using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace conexao_internet
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        public static Boolean Isconnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Isconnected())
            {
                textBox1.Text = "Conectado";
            }
            else
            {
                textBox1.Text = "Desconectado";
            }
        }
    }
}
