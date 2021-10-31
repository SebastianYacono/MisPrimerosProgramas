
namespace Lucho
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Datos = new System.Windows.Forms.DataGridView();
            this.TB_Producto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Cat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Vender = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_CantVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_CatVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_ProdVenta = new System.Windows.Forms.TextBox();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Notificaciones = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_AumentarStock = new System.Windows.Forms.Button();
            this.Btn_BuscarAumentar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_CantAumentar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_CatAumentar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_ProdAumentar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lbl_Prueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Datos
            // 
            this.DGV_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Datos.Location = new System.Drawing.Point(12, 147);
            this.DGV_Datos.Name = "DGV_Datos";
            this.DGV_Datos.Size = new System.Drawing.Size(461, 300);
            this.DGV_Datos.TabIndex = 0;
            // 
            // TB_Producto
            // 
            this.TB_Producto.Location = new System.Drawing.Point(21, 73);
            this.TB_Producto.Name = "TB_Producto";
            this.TB_Producto.Size = new System.Drawing.Size(255, 20);
            this.TB_Producto.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Borrar);
            this.groupBox1.Controls.Add(this.Btn_Cargar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Cat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_Producto);
            this.groupBox1.Location = new System.Drawing.Point(493, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar productos";
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.Location = new System.Drawing.Point(23, 126);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(252, 23);
            this.Btn_Borrar.TabIndex = 5;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Location = new System.Drawing.Point(23, 99);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(252, 23);
            this.Btn_Cargar.TabIndex = 4;
            this.Btn_Cargar.Text = "Cargar";
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            this.Btn_Cargar.Click += new System.EventHandler(this.Btn_Cargar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // TB_Cantidad
            // 
            this.TB_Cantidad.Location = new System.Drawing.Point(163, 34);
            this.TB_Cantidad.Name = "TB_Cantidad";
            this.TB_Cantidad.Size = new System.Drawing.Size(112, 20);
            this.TB_Cantidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // TB_Cat
            // 
            this.TB_Cat.Location = new System.Drawing.Point(22, 34);
            this.TB_Cat.Name = "TB_Cat";
            this.TB_Cat.Size = new System.Drawing.Size(112, 20);
            this.TB_Cat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Vender);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TB_CantVenta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_CatVenta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TB_ProdVenta);
            this.groupBox2.Location = new System.Drawing.Point(493, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vender producto";
            // 
            // Btn_Vender
            // 
            this.Btn_Vender.Location = new System.Drawing.Point(23, 126);
            this.Btn_Vender.Name = "Btn_Vender";
            this.Btn_Vender.Size = new System.Drawing.Size(252, 23);
            this.Btn_Vender.TabIndex = 10;
            this.Btn_Vender.Text = "Vender";
            this.Btn_Vender.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(23, 99);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(252, 23);
            this.Btn_Buscar.TabIndex = 9;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad vendida";
            // 
            // TB_CantVenta
            // 
            this.TB_CantVenta.Location = new System.Drawing.Point(163, 34);
            this.TB_CantVenta.Name = "TB_CantVenta";
            this.TB_CantVenta.Size = new System.Drawing.Size(112, 20);
            this.TB_CantVenta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // TB_CatVenta
            // 
            this.TB_CatVenta.Location = new System.Drawing.Point(22, 34);
            this.TB_CatVenta.Name = "TB_CatVenta";
            this.TB_CatVenta.Size = new System.Drawing.Size(112, 20);
            this.TB_CatVenta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre del producto";
            // 
            // TB_ProdVenta
            // 
            this.TB_ProdVenta.Location = new System.Drawing.Point(21, 73);
            this.TB_ProdVenta.Name = "TB_ProdVenta";
            this.TB_ProdVenta.Size = new System.Drawing.Size(255, 20);
            this.TB_ProdVenta.TabIndex = 8;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(603, 513);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cerrar.TabIndex = 11;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_Notificaciones
            // 
            this.Lbl_Notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Notificaciones.Location = new System.Drawing.Point(7, 15);
            this.Lbl_Notificaciones.Name = "Lbl_Notificaciones";
            this.Lbl_Notificaciones.Size = new System.Drawing.Size(443, 45);
            this.Lbl_Notificaciones.TabIndex = 11;
            this.Lbl_Notificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lucho.Properties.Resources.lucho1;
            this.pictureBox1.Location = new System.Drawing.Point(52, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_AumentarStock);
            this.groupBox3.Controls.Add(this.Btn_BuscarAumentar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TB_CantAumentar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TB_CatAumentar);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TB_ProdAumentar);
            this.groupBox3.Location = new System.Drawing.Point(493, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 161);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aumentar Stock";
            // 
            // Btn_AumentarStock
            // 
            this.Btn_AumentarStock.Location = new System.Drawing.Point(23, 126);
            this.Btn_AumentarStock.Name = "Btn_AumentarStock";
            this.Btn_AumentarStock.Size = new System.Drawing.Size(252, 23);
            this.Btn_AumentarStock.TabIndex = 10;
            this.Btn_AumentarStock.Text = "Aumentar stock";
            this.Btn_AumentarStock.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarAumentar
            // 
            this.Btn_BuscarAumentar.Location = new System.Drawing.Point(23, 99);
            this.Btn_BuscarAumentar.Name = "Btn_BuscarAumentar";
            this.Btn_BuscarAumentar.Size = new System.Drawing.Size(252, 23);
            this.Btn_BuscarAumentar.TabIndex = 9;
            this.Btn_BuscarAumentar.Text = "Buscar";
            this.Btn_BuscarAumentar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad a agregar";
            // 
            // TB_CantAumentar
            // 
            this.TB_CantAumentar.Location = new System.Drawing.Point(163, 34);
            this.TB_CantAumentar.Name = "TB_CantAumentar";
            this.TB_CantAumentar.Size = new System.Drawing.Size(112, 20);
            this.TB_CantAumentar.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Categoria";
            // 
            // TB_CatAumentar
            // 
            this.TB_CatAumentar.Location = new System.Drawing.Point(22, 34);
            this.TB_CatAumentar.Name = "TB_CatAumentar";
            this.TB_CatAumentar.Size = new System.Drawing.Size(112, 20);
            this.TB_CatAumentar.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre del producto";
            // 
            // TB_ProdAumentar
            // 
            this.TB_ProdAumentar.Location = new System.Drawing.Point(21, 73);
            this.TB_ProdAumentar.Name = "TB_ProdAumentar";
            this.TB_ProdAumentar.Size = new System.Drawing.Size(255, 20);
            this.TB_ProdAumentar.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lbl_Notificaciones);
            this.groupBox4.Location = new System.Drawing.Point(13, 466);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 70);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cuadro de notificaciones";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Lbl_Prueba);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco Lucho";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Datos;
        private System.Windows.Forms.TextBox TB_Producto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_CantVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_CatVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_ProdVenta;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_Notificaciones;
        private System.Windows.Forms.Button Btn_Vender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_AumentarStock;
        private System.Windows.Forms.Button Btn_BuscarAumentar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_CantAumentar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_CatAumentar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_ProdAumentar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Lbl_Prueba;
    }
}

