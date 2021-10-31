using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaAtras
{
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
        }

        private void BIniciar_Click(object sender, EventArgs e)
        {
            int seg = System.Convert.ToInt32(TBTime.Text);

            if (seg > 0)
            {
                for (int cont = seg; cont >= 0; --cont)
                {
                    LblTime.Text = System.Convert.ToString(cont);
                    Thread.Sleep(1000);
                    this.Refresh();
                }
                MessageBox.Show("El tiempo pactado ha llegado a 0.", "TIEMPO");
            }
            else
            {
                LblTime.Text = "ERROR";
                MessageBox.Show("El número no es válido", "ERROR");
            }
            
        }
    }
}
