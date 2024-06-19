using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtBox1Lado.Text); 
            int b = Convert.ToInt32(txtBox2Lado.Text);
            int c = Convert.ToInt32(txtBox3Lado.Text); 

            if (a == b && b == c)
            {
                resultado.Text = "Triangulo Equilatero"; 
                this.isosceles.Visible = true;
                this.escalemo.Visible = false;
                this.equilatero.Visible = false;
            } 

            else if (a != b && b != c)
            {
                resultado.Text = "Triangulo escaleno";
                this.escalemo.Visible = true;
                this.isosceles.Visible = false;
                this.equilatero.Visible = false;   
            } 
            else if (a == b || a == c || b == c)
            {
                resultado.Text = "Triangulo isóceles";
                this.equilatero.Visible = true; 
                this.isosceles.Visible= false; 
                this.escalemo.Visible = false;
            }
        }
    }
}
