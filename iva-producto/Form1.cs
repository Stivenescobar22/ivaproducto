using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iva_producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)


        {
            string precio = txtproducto.Text;
            string descuento = lbltotaliva.Text;
            string total = lblpreciototal.Text;

            float producto = float.Parse(txtproducto.Text);
            float iva = producto * 0.19F;
            float totals = producto + iva;

            lbltotaliva.Text = iva.ToString();
            lblpreciototal.Text = totals.ToString();
           





        }
    }
}
