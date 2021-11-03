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
        Producto Buscador = new Producto();
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

            TB_Cat.Text = "";
            TB_Producto.Text = "";
            TB_Cantidad.Text = "";
            TB_Cat.Focus();

            Lbl_Notificaciones.Text = "El producto se cargó correctamente.";


        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscador = Lista.BuscarProd(Convert.ToInt32(TB_BuscarID.Text));

            if (Buscador.Id > 0)
            {
                TB_BuscarCat.Text = Buscador.Cat;
                TB_BuscarCant.Text = Buscador.Cant.ToString();
                TB_BuscarProd.Text = Buscador.Prod;
                
                TB_BuscarID.Focus();

                Lbl_Notificaciones.Text = "Producto encontrado.";
            }
            else
            {
                TB_BuscarCat.Text = "";
                TB_BuscarCant.Text = "";
                TB_BuscarProd.Text = "";
                TB_BuscarID.Focus();
                TB_BuscarID.SelectAll();
                Lbl_Notificaciones.Text = "El producto no existe.";
            }
        }
    }
}
