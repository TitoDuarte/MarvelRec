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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
            tabla();
        }

        int id;

        private void tabla()
        {
            string select = "select * from marvel.figuras";

            Conector conector = new Conector();
            conector.Select(select, tbFiguras);
        }

        private void actualizar(Figuras figura)
        {
            string update = "update marvel.figuras set " +
            $"Franquicia = '{figura.franquicia}', " +
            $"Nombre = '{figura.nombre}', " +
            $"Descripcion = '{figura.descripcion}', " +
            $"Precio = {figura.precio}, " +
            $"Existencia = '{figura.existencia}' " +
            $"where ID = {id};";

            Conector con = new Conector();
            con.Insert(update);
            tabla();
            limpiar();
        }

        private void limpiar()
        {
            nombreBox.Text = "";
            precionumeric.Value = 0;
            existencianumeric.Value = 0;
            descripcionBox.Text = "";
        }

        private void Franquicia_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void crear_Click(object sender, EventArgs e)
        {
            Figuras figuras = new Figuras(franquiciaBox.Text, nombreBox.Text, descripcionBox.Text, int.Parse(existencianumeric.Text), int.Parse(precionumeric.Text));

            string insert = $"insert into marvel.figuras(Franquicia,Nombre, Descripcion, Precio, Existencia) values('{figuras.franquicia}','{figuras.nombre}', '{figuras.descripcion}',{figuras.precio},{figuras.existencia});";
            Conector conector = new Conector();
            conector.Insert(insert);
            tabla();
            limpiar();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tbFiguras_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tbFiguras.SelectedRows[0];
            id = int.Parse(row.Cells[0].Value.ToString());
            franquiciaBox.Text = row.Cells[1].Value.ToString();
            nombreBox.Text = row.Cells[2].Value.ToString();
            descripcionBox.Text = row.Cells[3].Value.ToString(); ;
            precionumeric.Value = int.Parse(row.Cells[4].Value.ToString());
            existencianumeric.Value = int.Parse(row.Cells[4].Value.ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Figuras figuras = new Figuras(franquiciaBox.Text, nombreBox.Text, descripcionBox.Text, int.Parse(existencianumeric.Text), int.Parse(precionumeric.Text));
            actualizar(figuras);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
