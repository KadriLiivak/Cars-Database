using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsAppDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CarsAppDB.Properties.Settings.CarsConnectionString"].ConnectionString;
        }
        private void PopulateCarsTable()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CarMark", connection))
            {
                DataTable carTable = new DataTable();
                adapter.Fill(carTable);

                listCarsMark.DisplayMember = "CarMarkName";
                listCarsMark.ValueMember = "Id";
                listCarsMark.DataSource = carTable;
            }
        }
        private void PopulateCarModelNames()
        {
            string query = "SELECT CarInGarage.CarModelName FROM CarMark INNER JOIN CarInGarage ON CarMark.Id=CarInGarage.CarMarkId WHERE CarMark.Id=@Id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", listCarsMark.SelectedValue);
                DataTable CarModelNameTable = new DataTable();
                adapter.Fill(CarModelNameTable);

                listCarModel.DisplayMember = "CarModelName";
                listCarModel.ValueMember = "Id";
                listCarModel.DataSource = CarModelNameTable;
            }
        }

                private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCarsTable();
        }

        private void listCarsMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCarModelNames();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
