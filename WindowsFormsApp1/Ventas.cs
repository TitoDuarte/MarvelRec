using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            cargarFigura();
        }

        int total = 0;

        private void cargarFigura()
        {
            try
            {
                string select = "select ID, Nombre from marvel.figuras where Franquicia = '" + franquiciaBox.SelectedItem + "';";
                Conector conector = new Conector();
                figuraBox.DataSource = conector.Select(select);
                figuraBox.DisplayMember = "Nombre";
                figuraBox.ValueMember = "ID";
            }
            catch (Exception)
            {
            }
        }

        private void cargarInfo()
        {
            string select = $"select Precio, Descripcion from marvel.figuras where ID = {figuraBox.SelectedValue};";
            Conector conector = new Conector();

            DataTable dt;
            dt = conector.Select(select);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                nombreBox.Text = figuraBox.Text;
                precioBox.Text = row["Precio"].ToString();
                descripcionBox.Text = row["Descripcion"].ToString();
            }
        }
        
        private void cargarTotal()
        {
            total += int.Parse(precioBox.Text);
            totalBox.Text = total.ToString();
        }
        private void cargarTabla()
        {
            dataGridventas.Rows.Add(franquiciaBox.Text, nombreBox.Text, descripcionBox.Text, precioBox.Text);
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void dataGridventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void franquiciaBoxv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarFigura();
        }

        private void figuraBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarInfo();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void comprar_Click(object sender, EventArgs e)
        {
            cargarInfo();
            cargarTotal();
            cargarTabla();
        }
    }
}
