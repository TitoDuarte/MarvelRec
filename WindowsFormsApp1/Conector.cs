using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Conector
    {
        String conString = "datasource=localhost;port=3306;username=root;";
        public void Insert(string insert)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(insert, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Guardado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar \n{ex}");
            }
        }

        public void Select(string select, DataGridView table)
        {
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(select, con);

            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                table.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer data \n{ex}");
            }
        }

        public DataTable Select(string select)
        {
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(select, con);

            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer data \n{ex}");
                return null;
            }
        }
    }
}
