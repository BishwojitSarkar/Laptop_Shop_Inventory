using System.Data;
using Microsoft.Data.SqlClient;

namespace CRUDproject
{
    public partial class Form1 : Form
    {
        int selectedLaptopID = 0;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Laptops";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = DbConnection.GetConnection();

            string query = "INSERT INTO Laptops (Company, Model, Processor, RAM, Storage, Quantity, Price, Warranty) VALUES (@c, @m, @p, @r, @s, @q, @pr, @w)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@c", companytxtbox.Text);
            cmd.Parameters.AddWithValue("@m", modeltxtbox.Text);
            cmd.Parameters.AddWithValue("@p", processortxtbox.Text);
            cmd.Parameters.AddWithValue("@r", ramtxtbox.Text);
            cmd.Parameters.AddWithValue("@s", storagetxtbox.Text);
            cmd.Parameters.AddWithValue("@q", int.Parse(quantitytxtbox.Text));
            cmd.Parameters.AddWithValue("@pr", decimal.Parse(pricetxtbox.Text));
            cmd.Parameters.AddWithValue("@w", warrantytxtbox.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Laptop Added Successfully");

            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedLaptopID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            companytxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            modeltxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            processortxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ramtxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            storagetxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            quantitytxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            pricetxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            warrantytxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = DbConnection.GetConnection();

            string query = "UPDATE Laptops SET Company=@c, Model=@m, Processor=@p, RAM=@r, Storage=@s, Quantity=@q, Price=@pr, Warranty=@w WHERE LaptopID=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@c", companytxtbox.Text);
            cmd.Parameters.AddWithValue("@m", modeltxtbox.Text);
            cmd.Parameters.AddWithValue("@p", processortxtbox.Text);
            cmd.Parameters.AddWithValue("@r", ramtxtbox.Text);
            cmd.Parameters.AddWithValue("@s", storagetxtbox.Text);
            cmd.Parameters.AddWithValue("@q", int.Parse(quantitytxtbox.Text));
            cmd.Parameters.AddWithValue("@pr", decimal.Parse(pricetxtbox.Text));
            cmd.Parameters.AddWithValue("@w", warrantytxtbox.Text);
            cmd.Parameters.AddWithValue("@id", selectedLaptopID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Laptop Updated Successfully");

            LoadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = DbConnection.GetConnection();

            string query = "DELETE FROM Laptops WHERE LaptopID=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", selectedLaptopID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Laptop Deleted Successfully");

            LoadData();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

            companytxtbox.Clear();
            modeltxtbox.Clear();
            processortxtbox.Clear();
            ramtxtbox.Clear();
            storagetxtbox.Clear();
            quantitytxtbox.Clear();
            pricetxtbox.Clear();
            warrantytxtbox.Clear();

            selectedLaptopID = 0;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = DbConnection.GetConnection();

            string query = "SELECT * FROM Laptops WHERE Company LIKE @search OR Model LIKE @search";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@search", "%" + searchtxtbox.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }

}
