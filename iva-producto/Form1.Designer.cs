namespace iva_producto
{
    partial class Form1
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
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblproducto = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.lbltotaliva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblpreciototal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(310, 89);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(126, 20);
            this.txtproducto.TabIndex = 0;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(442, 85);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(175, 89);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(129, 20);
            this.lblproducto.TabIndex = 2;
            this.lblproducto.Text = "Precio Producto :";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(210, 147);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(94, 20);
            this.lbliva.TabIndex = 3;
            this.lbliva.Text = "IVA ( 19%) :";
            // 
            // lbltotaliva
            // 
            this.lbltotaliva.AutoSize = true;
            this.lbltotaliva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaliva.Location = new System.Drawing.Point(310, 152);
            this.lbltotaliva.Name = "lbltotaliva";
            this.lbltotaliva.Size = new System.Drawing.Size(71, 20);
            this.lbltotaliva.TabIndex = 4;
            this.lbltotaliva.Text = "precioiva";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(211, 207);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total : ";
            // 
            // lblpreciototal
            // 
            this.lblpreciototal.AutoSize = true;
            this.lblpreciototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreciototal.Location = new System.Drawing.Point(310, 207);
            this.lblpreciototal.Name = "lblpreciototal";
            this.lblpreciototal.Size = new System.Drawing.Size(83, 20);
            this.lblpreciototal.TabIndex = 6;
            this.lblpreciototal.Text = "preciototal";
            this.lblpreciototal.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpreciototal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbltotaliva);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtproducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lbltotaliva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblpreciototal;
    }
}

