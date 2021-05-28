using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace WindowsFormsApp11
{
    public partial class NCparks_and_Rec : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amanda Leigh\source\repos\WindowsFormsApp11\Database1.mdf;Integrated Security=True");
        public NCparks_and_Rec()
        {
            InitializeComponent();

        }

        //File Dialog
        private void FileDialog2_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog fileDialog2 = new OpenFileDialog();
             fileDialog2.Title = "Select File";
             fileDialog2.FileName = FileDialogText.Text;
             fileDialog2.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*,*)|*.*";
             fileDialog2.FilterIndex = 1;
             fileDialog2.RestoreDirectory = true;
             if (fileDialog2.ShowDialog() == DialogResult.OK)
             {

                //fileDialog2.FileName = txtFileName.Text;
                string path = fileDialog2.FileName;
                var fileStream = fileDialog2.OpenFile();
                using(StreamReader reader =new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

             }

          
        }
        //Insert information from textboxes into database
        private void InsertButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into [Orders] (OrderID, CustomerID, OrderName, OrderQuantity) Values (@OrderID, @CustomerID, @OrderName, @OrderQuantity)";
                cmd.Parameters.AddWithValue("@OrderID", textBoxOrderID.Text);
                cmd.Parameters.AddWithValue("@CustomerID", textBoxCustomerID.Text);
                cmd.Parameters.AddWithValue("@OrderName", textBoxOrderDate.Text);
                cmd.Parameters.AddWithValue("@OrderQuantity", textBoxOrderQuantity.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                Display_Data();
                textBoxCustomerID.Text = "";
                textBoxOrderDate.Text = "";
                textBoxOrderID.Text = "";
                textBoxOrderQuantity.Text = "";
                label2.Text = "Data imported successfully.";
               
            }
            catch(Exception ex)
            {
                label2.Text="Exception Message:" + ex.Message;
            }
      
        }
        //Display Data in DataGridView
        private void Display_Data()
        {
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * FROM [Orders]", connection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Insert2_Click(object sender, EventArgs e)
        {
            try
            {
              

                string path = FileDialogText.Text;
                // string ConnString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amanda Leigh\source\repos\WindowsFormsApp11\Database1.mdf;Integrated Security=True");
                string ConnString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=Excel 8.0";
                DataTable data = new DataTable();
                using (SqlConnection connection2 = new SqlConnection(ConnString))
                {
                    connection2.Open();
                    SqlCommand cmd2 = new SqlCommand("@SELECT * FROM [dataGridView1_Data$]", connection2);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                    dataGridView1.DataSource = data;
                    adapter.Fill(data);
                    connection2.Close();

                }
        }

            catch(Exception ex)
            {
                label2.Text = "Exception Message:" + ex.Message;
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            


            }
        }
    }

