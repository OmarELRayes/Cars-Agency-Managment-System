using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AgencyProject
{   
    
    public partial class AddEmployee : System.Web.UI.Page
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=LegendDev\SQLEXPRESS;Initial Catalog=AgenceProject;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
           Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";
            cmd.ExecuteNonQuery();
            Conn.Close();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE FROM Employees WHERE ID='" + TextBox9.Text + "'";
            cmd.ExecuteNonQuery();
            Conn.Close();
            GridView1.DataBind();
        }*/
    }
}