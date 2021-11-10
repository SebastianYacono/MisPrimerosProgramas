
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.DGV_Datos = new System.Windows.Forms.DataGridView();
            this.TB_Producto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Cat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Notificaciones = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_BuscarCant = new System.Windows.Forms.TextBox();
            this.TB_BuscarCat = new System.Windows.Forms.TextBox();
            this.TB_BuscarID = new System.Windows.Forms.TextBox();
            this.Btn_DisminuirStock = new System.Windows.Forms.Button();
            this.TB_CantDisminuir = new System.Windows.Forms.TextBox();
            this.Btn_AumentarStock = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.TB_CantAumentar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_BuscarProd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Datos
            // 
            this.DGV_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Datos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Datos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_Datos.Location = new System.Drawing.Point(12, 14);
            this.DGV_Datos.Name = "DGV_Datos";
            this.DGV_Datos.RowTemplate.ReadOnly = true;
            this.DGV_Datos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Datos.Size = new System.Drawing.Size(461, 425);
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
            this.groupBox1.Controls.Add(this.Btn_Cargar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Cat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_Producto);
            this.groupBox1.Location = new System.Drawing.Point(493, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar productos";
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
            this.TB_Cantidad.Location = new System.Drawing.Point(164, 34);
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
            this.TB_Cat.Location = new System.Drawing.Point(21, 34);
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
            // Btn_Borrar
            // 
            this.Btn_Borrar.Enabled = false;
            this.Btn_Borrar.Location = new System.Drawing.Point(23, 193);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(252, 23);
            this.Btn_Borrar.TabIndex = 5;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(603, 487);
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
            this.Lbl_Notificaciones.Location = new System.Drawing.Point(7, 16);
            this.Lbl_Notificaciones.Name = "Lbl_Notificaciones";
            this.Lbl_Notificaciones.Size = new System.Drawing.Size(443, 45);
            this.Lbl_Notificaciones.TabIndex = 11;
            this.Lbl_Notificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lucho.Properties.Resources.lucho1;
            this.pictureBox1.Location = new System.Drawing.Point(488, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TB_BuscarCant);
            this.groupBox3.Controls.Add(this.TB_BuscarCat);
            this.groupBox3.Controls.Add(this.TB_BuscarID);
            this.groupBox3.Controls.Add(this.Btn_DisminuirStock);
            this.groupBox3.Controls.Add(this.TB_CantDisminuir);
            this.groupBox3.Controls.Add(this.Btn_Borrar);
            this.groupBox3.Controls.Add(this.Btn_AumentarStock);
            this.groupBox3.Controls.Add(this.Btn_Buscar);
            this.groupBox3.Controls.Add(this.TB_CantAumentar);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TB_BuscarProd);
            this.groupBox3.Location = new System.Drawing.Point(493, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 231);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manejo de Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID";
            // 
            // TB_BuscarCant
            // 
            this.TB_BuscarCant.BackColor = System.Drawing.SystemColors.Window;
            this.TB_BuscarCant.Enabled = false;
            this.TB_BuscarCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BuscarCant.Location = new System.Drawing.Point(199, 40);
            this.TB_BuscarCant.Name = "TB_BuscarCant";
            this.TB_BuscarCant.ReadOnly = true;
            this.TB_BuscarCant.Size = new System.Drawing.Size(77, 20);
            this.TB_BuscarCant.TabIndex = 15;
            // 
            // TB_BuscarCat
            // 
            this.TB_BuscarCat.BackColor = System.Drawing.SystemColors.Window;
            this.TB_BuscarCat.Enabled = false;
            this.TB_BuscarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BuscarCat.Location = new System.Drawing.Point(109, 40);
            this.TB_BuscarCat.Name = "TB_BuscarCat";
            this.TB_BuscarCat.ReadOnly = true;
            this.TB_BuscarCat.Size = new System.Drawing.Size(77, 20);
            this.TB_BuscarCat.TabIndex = 14;
            // 
            // TB_BuscarID
            // 
            this.TB_BuscarID.Location = new System.Drawing.Point(21, 40);
            this.TB_BuscarID.Name = "TB_BuscarID";
            this.TB_BuscarID.Size = new System.Drawing.Size(77, 20);
            this.TB_BuscarID.TabIndex = 7;
            // 
            // Btn_DisminuirStock
            // 
            this.Btn_DisminuirStock.Enabled = false;
            this.Btn_DisminuirStock.Location = new System.Drawing.Point(140, 165);
            this.Btn_DisminuirStock.Name = "Btn_DisminuirStock";
            this.Btn_DisminuirStock.Size = new System.Drawing.Size(135, 23);
            this.Btn_DisminuirStock.TabIndex = 13;
            this.Btn_DisminuirStock.Text = "Disminuir stock";
            this.Btn_DisminuirStock.UseVisualStyleBackColor = true;
            this.Btn_DisminuirStock.Click += new System.EventHandler(this.Btn_DisminuirStock_Click);
            // 
            // TB_CantDisminuir
            // 
            this.TB_CantDisminuir.Location = new System.Drawing.Point(22, 167);
            this.TB_CantDisminuir.Name = "TB_CantDisminuir";
            this.TB_CantDisminuir.Size = new System.Drawing.Size(112, 20);
            this.TB_CantDisminuir.TabIndex = 12;
            // 
            // Btn_AumentarStock
            // 
            this.Btn_AumentarStock.Enabled = false;
            this.Btn_AumentarStock.Location = new System.Drawing.Point(140, 135);
            this.Btn_AumentarStock.Name = "Btn_AumentarStock";
            this.Btn_AumentarStock.Size = new System.Drawing.Size(135, 23);
            this.Btn_AumentarStock.TabIndex = 10;
            this.Btn_AumentarStock.Text = "Aumentar stock";
            this.Btn_AumentarStock.UseVisualStyleBackColor = true;
            this.Btn_AumentarStock.Click += new System.EventHandler(this.Btn_AumentarStock_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(23, 107);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(252, 23);
            this.Btn_Buscar.TabIndex = 9;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // TB_CantAumentar
            // 
            this.TB_CantAumentar.Location = new System.Drawing.Point(22, 137);
            this.TB_CantAumentar.Name = "TB_CantAumentar";
            this.TB_CantAumentar.Size = new System.Drawing.Size(112, 20);
            this.TB_CantAumentar.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre del producto";
            // 
            // TB_BuscarProd
            // 
            this.TB_BuscarProd.BackColor = System.Drawing.SystemColors.Window;
            this.TB_BuscarProd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TB_BuscarProd.Enabled = false;
            this.TB_BuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BuscarProd.Location = new System.Drawing.Point(21, 83);
            this.TB_BuscarProd.Name = "TB_BuscarProd";
            this.TB_BuscarProd.ReadOnly = true;
            this.TB_BuscarProd.Size = new System.Drawing.Size(255, 20);
            this.TB_BuscarProd.TabIndex = 8;
            this.TB_BuscarProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lbl_Notificaciones);
            this.groupBox4.Location = new System.Drawing.Point(13, 441);
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
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco Lucho";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_Notificaciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_AumentarStock;
        private System.Windows.Forms.Button Btn_Buscar;
        public System.Windows.Forms.TextBox TB_CantAumentar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_BuscarProd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_DisminuirStock;
        private System.Windows.Forms.TextBox TB_CantDisminuir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_BuscarCant;
        private System.Windows.Forms.TextBox TB_BuscarCat;
        private System.Windows.Forms.TextBox TB_BuscarID;
    }
}

