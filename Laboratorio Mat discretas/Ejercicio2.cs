using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_Mat_discretas
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            this.Hide();
            bool flag = true;
            int n;
            for (int i = 0; i <= 100; i++)
            {
                n = Data.Rows.Add();
                if (i < 10 || i > 20)
                {
                    Data.Rows[n].Cells[0].Value = i.ToString();
                }
                if (!(i >= 10 && i <= 20))
                {
                    Data.Rows[n].Cells[1].Value = i.ToString();
                }
                if (Data.Rows[n].Cells != Data.Rows[n].Cells) { flag = false; } 
            }

            if (flag) { answer.Text = "Verdadero";  } else { answer.Text = "Falso"; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Presentacion form = new Presentacion();
            form.Show();
        }
    }
}
