
namespace CuentaAtras
{
    partial class FInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
            this.TBTime = new System.Windows.Forms.TextBox();
            this.BIniciar = new System.Windows.Forms.Button();
            this.LblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PICUp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICUp)).BeginInit();
            this.SuspendLayout();
            // 
            // TBTime
            // 
            this.TBTime.Location = new System.Drawing.Point(9, 40);
            this.TBTime.Name = "TBTime";
            this.TBTime.Size = new System.Drawing.Size(189, 20);
            this.TBTime.TabIndex = 0;
            this.TBTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BIniciar
            // 
            this.BIniciar.Location = new System.Drawing.Point(64, 70);
            this.BIniciar.Name = "BIniciar";
            this.BIniciar.Size = new System.Drawing.Size(75, 23);
            this.BIniciar.TabIndex = 1;
            this.BIniciar.Text = "Iniciar";
            this.BIniciar.UseVisualStyleBackColor = true;
            this.BIniciar.Click += new System.EventHandler(this.BIniciar_Click);
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.Red;
            this.LblTime.Location = new System.Drawing.Point(18, 122);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(171, 57);
            this.LblTime.TabIndex = 2;
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BIniciar);
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Controls.Add(this.TBTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta atrás";
            // 
            // PICUp
            // 
            this.PICUp.Image = global::CuentaAtras.Properties.Resources.CuentaAtras;
            this.PICUp.Location = new System.Drawing.Point(-1, 0);
            this.PICUp.Name = "PICUp";
            this.PICUp.Size = new System.Drawing.Size(235, 93);
            this.PICUp.TabIndex = 4;
            this.PICUp.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa el valor inicial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 314);
            this.Controls.Add(this.PICUp);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Atrás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBTime;
        private System.Windows.Forms.Button BIniciar;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PICUp;
        private System.Windows.Forms.Label label1;
    }
}

