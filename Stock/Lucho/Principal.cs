﻿using System;
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
        Producto Prod = new Producto();
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

            Prod = new Producto();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Prod = Lista.BuscarProd(Convert.ToInt32(TB_BuscarID.Text));

            if (Prod.Id > 0)
            {
                TB_BuscarCat.Text = Prod.Cat;
                TB_BuscarCant.Text = Prod.Cant.ToString();
                TB_BuscarProd.Text = Prod.Prod;
                
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

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            if (Lista.BorrarProd (Prod))
            {
                TB_BuscarCat.Text = "";
                TB_BuscarCant.Text = "";
                TB_BuscarProd.Text = "";
                TB_BuscarID.Text = "";
                TB_BuscarID.Focus();
                TB_BuscarID.SelectAll();

                Lbl_Notificaciones.Text = "El producto fue borrado de la lista.";
            }
            
            Prod = new Producto();            
        }
    }
}
