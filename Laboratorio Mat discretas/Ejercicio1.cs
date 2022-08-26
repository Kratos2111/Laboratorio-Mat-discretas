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
    public partial class Ejercicio1 : Form
    {
        private const string V = "True";
        private const string F = "False";   

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            this.Hide();
            string first, second;
            string[] tb = { V, V, F, F };
            string[] tb2 = { V, F, V, F };

   
            //DataGridViewRow row = new DataGridViewRow();
            for( int i = 0; i<4; i++)
            {
                Datagrid.Rows.Add();
                first = tb[i];
                second = tb2[i];

                Datagrid.Rows[i].Cells[0].Value = first;
                Datagrid.Rows[i].Cells[1].Value = second;
                Datagrid.Rows[i].Cells[2].Value = toStringfromBoolean(toBoolean(1, first, second));
                Datagrid.Rows[i].Cells[3].Value = toStringfromBoolean(toBoolean(2, first, second));
                Datagrid.Rows[i].Cells[5].Value = toStringfromBoolean(toBoolean(4, first, second));
                Datagrid.Rows[i].Cells[4].Value = toStringfromBoolean(toBoolean(3, first, second));

              
            }

            Datagrid.Columns[2].Visible = false;
            Datagrid.Columns[3].Visible = false;
            Datagrid.Columns[4].Visible = false;
            Datagrid.Columns[5].Visible = false;

        }
        private void changeData()
        {
            if (conjunction.Checked) {Datagrid.Columns[2].Visible = true; }
            else { Datagrid.Columns[2].Visible = false; }

            if (disyuntion.Checked) { Datagrid.Columns[3].Visible = true; }
            else { Datagrid.Columns[3].Visible = false; }

            if (Implication.Checked) { Datagrid.Columns[4].Visible = true; }
            else { Datagrid.Columns[4].Visible = false; }

            if (dbl_implication.Checked) { Datagrid.Columns[5].Visible = true; }
            else { Datagrid.Columns[5].Visible = false; }

        }
        private String toStringfromBoolean(bool a)
        {
            if (a) { return "Verdadero"; }
            return "Falso";
        }
        private bool toBoolean(int opc, string a , string b)
        {
            bool frst = false, scn = false;
            if(a == V) { frst = true; }
            if(b == V) { scn = true; }
            switch (opc)
            {
                case 1:
                    return frst && scn;
                case 2:
                    return frst || scn;
                case 3:
                    if (frst == scn) return true;
                    return scn;
                case 4:
                    return frst == scn;
                default:
                    return false;
            }
        }

        private void conjunction_CheckedChanged(object sender, EventArgs e)
        {
            changeData();
        }

        private void disyuntion_CheckedChanged(object sender, EventArgs e)
        {
            changeData();
        }

        private void Implication_CheckedChanged(object sender, EventArgs e)
        {
            changeData();
        }

        private void dbl_implication_CheckedChanged(object sender, EventArgs e)
        {
            changeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Presentacion form = new Presentacion();
            form.Show();
        }
    }
}
