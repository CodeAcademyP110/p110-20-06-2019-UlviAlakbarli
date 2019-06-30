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
using System.Configuration;
namespace Win_F_Disconnected
{
    public partial class Login : Form
    {
        private string constring = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        int empId;
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            string comand = "select * from empinfo";
             
            using(SqlConnection con=new SqlConnection(constring))
            {
                
                con.Open();
                using(SqlDataAdapter adapter =new SqlDataAdapter(comand,con))
                {
                    
                    DataSet empinfo = new DataSet();
                    adapter.Fill(empinfo,"empi");
                    dataGridViewEmployees.DataSource = empinfo.Tables["empi"];
                    dataGridViewEmployees.Columns[0].Visible = false;
                }
            }
        }

        private async void DataGridViewEmployees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
             empId = (int)(dataGridViewEmployees[0, e.RowIndex].Value);
            using(SqlConnection con=new SqlConnection(constring))
            {
               
                string comand = $"select * from Employee where Id='{empId}'";
                string comand2 = "select Name from Positions";
                string comand3 = "select Positions.Name from Employee " +
                    "join Positions on Employee.PositionId=Positions.Id " +
                    $"where Employee.Id={empId}";
                using (SqlCommand adapter=new SqlCommand(comand, con))
                {
                    await con.OpenAsync();
                    SqlDataReader reader = await adapter.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtFirstname.Text = reader["Firstname"].ToString();
                        txtlastname.Text = reader["Lastname"].ToString();
                        txtemail.Text = reader["Email"].ToString();
                        numsalary.Value = (decimal)reader["Salary"];
                    }
                    else
                    {
                        MessageBox.Show("Melumat yoxdur");
                    }

                     con.Close();
                    

                }
                using (SqlCommand com = new SqlCommand(comand2, con))
                    {
                    await con.OpenAsync();
                    cmbpos.Items.Clear();
                        
                        SqlDataReader reader = await com.ExecuteReaderAsync();
                        while (reader.Read())
                        {
                            cmbpos.Items.Add(reader["Name"].ToString());
                           
                        }
                       con.Close();
                       

                    }
                using (SqlCommand com = new SqlCommand(comand3, con))
                {
                    await con.OpenAsync();

                    SqlDataReader reader = await com.ExecuteReaderAsync();

                    reader.Read();
                    cmbpos.SelectedItem = reader[0].ToString();

                    con.Close();


                }


            }

        }

        private async void DataGridViewEmployees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            empId = (int)(dataGridViewEmployees[0, e.RowIndex].Value);
            int pId;
            using (SqlConnection con = new SqlConnection(constring))
            {

                string comand = $"select * from Employee where Id='{empId}'";
                string comand2 = "select Name from Positions";
                string comand3 = "select Positions.Name from Employee " +
                    "join Positions on Employee.PositionId=Positions.Id " +
                    $"where Employee.Id={empId}";
                using (SqlCommand adapter = new SqlCommand(comand, con))
                {
                    
                    await con.OpenAsync();
                    SqlDataReader reader = await adapter.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        
                        txtFirstname.Text = reader["Firstname"].ToString();
                        txtlastname.Text = reader["Lastname"].ToString();
                        txtemail.Text = reader["Email"].ToString();
                        numsalary.Value = (decimal)reader["Salary"];
                        pId = (int)reader["PositionId"];
                        

                    }
                    else
                    {
                        MessageBox.Show("Melumat yoxdur");
                    }

                    con.Close();


                }
                using (SqlCommand com = new SqlCommand(comand2, con))
                {
                    await con.OpenAsync();
                    cmbpos.Items.Clear();
                    SqlDataReader reader = await com.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        cmbpos.Items.Add(reader["Name"].ToString());

                    }
                    con.Close();
                    
                    
                    

                }
                using (SqlCommand com = new SqlCommand(comand3, con))
                {
                    await con.OpenAsync();
                    
                    SqlDataReader reader = await com.ExecuteReaderAsync();

                    reader.Read();
                    cmbpos.SelectedItem = reader[0].ToString();
                    
                    con.Close();


                }
            }
            
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            if (empId != null)
            {
                string first = txtFirstname.Text;
                int empposId;
                int x;
                string last = txtlastname.Text;
                string email = txtemail.Text;
                decimal salary = numsalary.Value;
                string position = cmbpos.SelectedItem.ToString();
                string comandpo = $"select Id from Positions where Name='{position}'";
                
                using (SqlConnection con=new SqlConnection(constring))
                {
                    using(SqlCommand com=new SqlCommand(comandpo, con))
                    {
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();
                        reader.Read();
                        empposId = (int)reader[0];
                        con.Close();
                    }
                    string comands = "update Employee " +
                               $"set Firstname = '{first}'," +
                               $"Lastname = '{last}'," +
                               $"Email = '{email}'," +
                               $"Salary = '{salary}'," +
                               $"PositionId = '{empposId}' " +
                               $"where Id = {empId}";
                    
                    using(SqlCommand com=new SqlCommand(comands, con))
                    {
                        con.Open();
                       SqlDataReader reader = com.ExecuteReader();
                      
                        con.Close();

                    }
                    string comand = "select * from empinfo";
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comand, con))
                    {
                        con.Open();
                        DataSet empinfo = new DataSet();
                        adapter.Fill(empinfo, "empi");
                        dataGridViewEmployees.DataSource = empinfo.Tables["empi"];
                        dataGridViewEmployees.Columns[0].Visible = false;
                        con.Close();
                    }

                }
            }
            

        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection con =new SqlConnection(constring))
            {
                string comands = $"delete from Employee where Id='{empId}' ";
                using(SqlCommand com=new SqlCommand(comands, con))
                {
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    con.Close();

                }
            }
        }

        private void NewPos_Click(object sender, EventArgs e)
        {
            NewPosition np = new NewPosition(this);
            this.Hide();
            np.Show();
        }
    }
}
