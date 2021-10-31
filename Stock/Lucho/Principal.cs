using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucho
{
    public partial class Principal : Form
    {
        public Producto[] ListaProd { get; set; }
        public ListaProd Lista { get; set; } = new ListaProd();

        public Principal()
        {
            InitializeComponent();

            DGV_Datos.DataSource = Lista.DT;

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            Producto CargarProd = new Producto();
            CargarProd.Cat = TB_Cat.Text;
            CargarProd.Prod = TB_Producto.Text;
            CargarProd.Cant = Convert.ToInt32(TB_Cantidad.Text);

            Lista.CargarDatos(CargarProd);


            Lbl_Notificaciones.Text = "El producto se cargó correctamente.";


        }
    }
}
