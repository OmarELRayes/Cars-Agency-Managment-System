using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AgencyProject
{
    public partial class Stock : System.Web.UI.Page
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=LEGENDDEV\SQLEXPRESS;Initial Catalog=AgenceProject;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            //styling the list
            show.Items[0].Attributes.Add("style", "color:grey;");
            show.Items[4].Attributes.Add("style", "color:grey;");
            show.Items[7].Attributes.Add("style", "color:grey;");
            show.Items[0].Attributes.Add("style", "font-style:italic;");
            show.Items[4].Attributes.Add("style", "font-style:italic;");
            show.Items[7].Attributes.Add("style", "font-style:italic;");
            show.Items[0].Attributes.Add("disabled", "true");
            show.Items[4].Attributes.Add("disabled", "true");
            show.Items[7].Attributes.Add("disabled", "true");

        }
        protected void show_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (show.SelectedItem.Text == "Buses")
            {
                SqlDataSource1.SelectCommand = "select * from dbo.[Stock-OverLand] where Name = 'Car' ";
                GridView1.DataBind();
              //  Conn.Open();
              //  SqlCommand cmd = new SqlCommand("");
               
              
              //GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}