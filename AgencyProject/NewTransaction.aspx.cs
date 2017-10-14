using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AgencyProject
{
    public partial class NewTransaction : System.Web.UI.Page
    {
        
        DataTable dtLand = new DataTable();          //Data Source=SCRUB\SQLEXPRESS;Initial Catalog=AgenceProject;Integrated Security=True
        DataTable dtSea = new DataTable();
        DataTable dtAir = new DataTable();
       // DataTable dtPay = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=LEGENDDEV\SQLEXPRESS;Initial Catalog=AgenceProject;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
           // model.Items.Capacity = 5;
        //    if (Server.UrlDecode(Request.QueryString["Data"]) != null)
        //    
        //        TextBox9.Visible = bool.Parse(Server.UrlDecode(Request.QueryString["Data"]));
        //    }
            conn.Open();
            string queryLand = "SELECT * FROM AgenceProject.dbo.[Stock-OverLand]";
            string querySea = "SELECT * FROM AgenceProject.dbo.[Stock-OverSea]";
            string queryAerial = "SELECT * FROM AgenceProject.dbo.[Stock-Aerial]";
            
            SqlCommand cmdLand = new SqlCommand(queryLand, conn);
            dtLand.Load(cmdLand.ExecuteReader());
            string colName;
            for(int i =0;i<dtLand.Rows.Count;i++)
            {
                colName = dtLand.Rows[i][0].ToString();
                if(colName=="Car")
                {
                    Car carItem = new Car(dtLand.Rows[i][0].ToString(), dtLand.Rows[i][1].ToString(),  dtLand.Rows[i][2].ToString(), float.Parse(dtLand.Rows[i][3].ToString()),
                        dtLand.Rows[i][4].ToString(), int.Parse(dtLand.Rows[i][5].ToString()),  int.Parse(dtLand.Rows[i][6].ToString()), dtLand.Rows[i][7].ToString(),
                        int.Parse(dtLand.Rows[i][8].ToString()), int.Parse(dtLand.Rows[i][9].ToString()), int.Parse(dtLand.Rows[i][10].ToString()),int.Parse(dtLand.Rows[i][11].ToString()),int.Parse(dtLand.Rows[i][13].ToString()));
                    OverLand.car.Add(carItem);
                }
                else if (colName=="Bus")
                {
                    Bus busItem = new Bus(dtLand.Rows[i][0].ToString(), dtLand.Rows[i][1].ToString(), dtLand.Rows[i][2].ToString(), float.Parse(dtLand.Rows[i][3].ToString()),
                        dtLand.Rows[i][4].ToString(), int.Parse(dtLand.Rows[i][5].ToString()), int.Parse(dtLand.Rows[i][6].ToString()), dtLand.Rows[i][7].ToString(),
                        int.Parse(dtLand.Rows[i][8].ToString()), int.Parse(dtLand.Rows[i][9].ToString()), int.Parse(dtLand.Rows[i][10].ToString()), int.Parse(dtLand.Rows[i][11].ToString()), int.Parse(dtLand.Rows[i][13].ToString()));
                    OverLand.bus.Add(busItem);
                }
                else if(colName=="Truck")
                {
                    Truck truckItem = new Truck(dtLand.Rows[i][0].ToString(), dtLand.Rows[i][1].ToString(), dtLand.Rows[i][2].ToString(), float.Parse(dtLand.Rows[i][3].ToString()),
                        dtLand.Rows[i][4].ToString(), int.Parse(dtLand.Rows[i][5].ToString()), int.Parse(dtLand.Rows[i][6].ToString()), dtLand.Rows[i][7].ToString(),
                        int.Parse(dtLand.Rows[i][8].ToString()), int.Parse(dtLand.Rows[i][9].ToString()), int.Parse(dtLand.Rows[i][10].ToString()), int.Parse(dtLand.Rows[i][11].ToString()),int.Parse(dtLand.Rows[i][12].ToString()),int.Parse(dtLand.Rows[i][13].ToString()));
                    OverLand.truck.Add(truckItem);
                }
            }
            SqlCommand cmdSea = new SqlCommand(querySea, conn);
            dtSea.Load(cmdSea.ExecuteReader());
            
            for (int i = 0; i < dtSea.Rows.Count; i++)
            {
                colName = dtSea.Rows[i][0].ToString();
                if(colName=="Yacht")
                {
                    Yacht yachtItem = new Yacht(dtSea.Rows[i][0].ToString(), dtSea.Rows[i][1].ToString(), dtSea.Rows[i][2].ToString(), int.Parse(dtSea.Rows[i][3].ToString()),
                        int.Parse(dtSea.Rows[i][4].ToString()), float.Parse(dtSea.Rows[i][5].ToString()), int.Parse(dtSea.Rows[i][6].ToString()), 
                        int.Parse(dtSea.Rows[i][7].ToString()), int.Parse(dtSea.Rows[i][8].ToString()), int.Parse(dtSea.Rows[i][9].ToString()));
                    OverSea.yacht.Add(yachtItem);
                }
                else if(colName=="Water Craft")
                {
                    WaterCraft watercraftItem = new WaterCraft(dtSea.Rows[i][0].ToString(), dtSea.Rows[i][1].ToString(), dtSea.Rows[i][2].ToString(), int.Parse(dtSea.Rows[i][3].ToString()),
                        int.Parse(dtSea.Rows[i][4].ToString()), float.Parse(dtSea.Rows[i][5].ToString()), int.Parse(dtSea.Rows[i][6].ToString()),
                        int.Parse(dtSea.Rows[i][7].ToString()), int.Parse(dtSea.Rows[i][8].ToString()), int.Parse(dtSea.Rows[i][9].ToString()));
                    OverSea.waterCraft.Add(watercraftItem);
                }
            }
            SqlCommand cmdAir = new SqlCommand(queryAerial, conn);
            dtAir.Load(cmdAir.ExecuteReader());

            for (int i = 0; i < dtAir.Rows.Count; i++)
            {
                colName = dtAir.Rows[i][0].ToString();
                if(colName=="Helicopter")
                {
                    Helicopter helicopterItem = new Helicopter(dtAir.Rows[i][0].ToString(), dtAir.Rows[i][1].ToString(), dtAir.Rows[i][2].ToString(), int.Parse(dtAir.Rows[i][3].ToString()),
                        int.Parse(dtAir.Rows[i][4].ToString()), int.Parse(dtAir.Rows[i][5].ToString()), int.Parse(dtAir.Rows[i][6].ToString()), int.Parse(dtAir.Rows[i][7].ToString()),
                        float.Parse(dtAir.Rows[i][8].ToString()), float.Parse(dtAir.Rows[i][9].ToString()), int.Parse(dtAir.Rows[i][10].ToString()), int.Parse(dtAir.Rows[i][11].ToString()),int.Parse(dtAir.Rows[i][12].ToString()));
                    Aerial.helicopter.Add(helicopterItem);
                }
                else if (colName=="Private Jet")
                {
                    PrivateJet privatejetItem = new PrivateJet(dtAir.Rows[i][0].ToString(), dtAir.Rows[i][1].ToString(), dtAir.Rows[i][2].ToString(), int.Parse(dtAir.Rows[i][3].ToString()),
                        int.Parse(dtAir.Rows[i][4].ToString()), int.Parse(dtAir.Rows[i][5].ToString()), int.Parse(dtAir.Rows[i][6].ToString()), int.Parse(dtAir.Rows[i][7].ToString()),
                        float.Parse(dtAir.Rows[i][8].ToString()), float.Parse(dtAir.Rows[i][9].ToString()), int.Parse(dtAir.Rows[i][10].ToString()), int.Parse(dtAir.Rows[i][11].ToString()),int.Parse(dtAir.Rows[i][12].ToString()));
                    Aerial.privatejet.Add(privatejetItem);
                }
            }

            conn.Close();
            }
            switch(Server.UrlDecode(Request["type"]).ToString())
            {
                case "overland" :
                    
                    type.Items.Add("Car");
                    type.Items.Add("Bus");
                    type.Items.Add("Truck");
                    if (!IsPostBack)
                    {
                        switch (Server.UrlDecode(Request["name"]).ToString())
                        {
                            case "Car":
                                type.SelectedValue = "Car";
                                company.Items.Add("BMW");
                                company.Items.Add("Mercedes");
                                company.Items.Add("Kia");
                                 company.Items.Add("Hyundai");
                                 cap.Visible = false;
                                 Label19.Visible = false;
                                 Label18.Visible = false;
                                 maxFHeight.Visible = false;
                                if(!IsPostBack)
                                 Car.method(Server, Request, company, model);
                                break;
                            case "Bus" :
                                 type.SelectedValue = "Bus";
                                 company.Items.Add("Mercedes");
                                 company.Items.Add("Thomas Bus");
                                cap.Visible = false;
                                 Label19.Visible = false;
                                 Label18.Visible = false;
                                 maxFHeight.Visible = false;
                                 if (!IsPostBack)
                                     Bus.method(Server, Request, company, model);
                                break;
                            case "Truck":
                                 type.SelectedValue = "Truck";
                                 company.Items.Add("Cat");
                                 company.Items.Add("Ford");
                                 Label18.Visible = false;
                                 maxFHeight.Visible = false;
                                 if (!IsPostBack)
                                 Truck.method(Server, Request, company, model);
                                break;
                        }

                    }
                    break;
                case "oversea" :
                    type.Items.Add("Yacht");
                    type.Items.Add("Water Craft");
                    if(!IsPostBack)
                    {
                        switch(Server.UrlDecode(Request["name"]).ToString())
                        {
                                
                            case "Yacht" :
                                type.SelectedValue = "Yacht";
                                company.Items.Add("FERRETTI");
                                company.Items.Add("Delta");
                                //
                                //
                                if(!IsPostBack)
                                    Yacht.method(Server, Request, company, model);
                                break;
                            case "waterCraft" :
                                type.SelectedValue = "Water Craft";
                                company.Items.Add("SEA-DOO");
                                company.Items.Add("Kawasaki");
                                //
                                //
                                if (!IsPostBack)
                                    WaterCraft.method(Server, Request, company, model);
                                break;
                        }
                    }
                    break;
                case "aerial" :
                    type.Items.Add("Helicopter");
                    type.Items.Add("Private Jet");
                    if(!IsPostBack)
                    {
                        switch(Server.UrlDecode(Request["name"]).ToString())
                        {
                            case "Helicopter":
                                type.SelectedValue = "Helicopter";
                                company.Items.Add("AgustaWestland");
                                company.Items.Add("Bell");
                                //
                                //
                                if (!IsPostBack)
                                    Helicopter.method(Server, Request, company, model);
                                break;
                            case "PrivateJet":
                                type.SelectedValue = "Private Jet";
                                company.Items.Add("Cessna");
                                company.Items.Add("Pilatus AirCraft");
                                //
                                //
                                if (!IsPostBack)
                                    WaterCraft.method(Server, Request, company, model);
                                break;
                        }
                    }
                    break;
            }

            //model.SelectedValue = null;
        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            model.ClearSelection();
            cName.Text = null;
            cMobile.Text = null;
            cAddress.Text = null;
            modelText.Text = null;
            wheels.Text = null;
            hp.Text = null;
            maxSpeed.Text = null;
            GType.Text = null;
            FCap.Text = null;
            Year.Text = null;
            color.Text = null;
            price.Text = null;
            maxFHeight.Text = null;
            cap.Text = null;
            passengers.Text = null;
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            foreach(Car n in OverLand.car)
            {
                if(n.model==model.SelectedItem.Text)
                {
                    if(n.quantity<=0)
                    {

                        break;
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand insert = conn.CreateCommand();
                        insert.CommandType = CommandType.Text;
                        insert.CommandText="insert into Payment Values('"+1+"','"+cName.Text+"','"+cMobile.Text+"','"+cAddress.Text+"','"+type.SelectedItem.Text+"','"+company.SelectedItem.Text+"','"+model.SelectedItem.Text+"','"+float.Parse(price.Text)+"','"+DateTime.Today+"')";
                        insert.ExecuteNonQuery();
                        insert.CommandText = "update [Stock-OverLand] set Quantity=Quantity-1 where Model='"+model.SelectedItem.Text+"'";
                        insert.ExecuteNonQuery();
                        conn.Close();
                        break;
                    }
                }
            }
            //conn.Open();
            //SqlCommand insert = conn.CreateCommand();
            //insert.CommandType = CommandType.Text;
            //insert.CommandText="insert into Payment Values('"+1+"','"+cName.Text+"','"+cMobile.Text+"','"+cAddress.Text+"','"+type.SelectedItem.Text+"','"+company.SelectedItem.Text+"','"+model.SelectedItem.Text+"','"+float.Parse(price.Text)+"','"+Payment.date+"')";
            //insert.ExecuteNonQuery();
            //conn.Close();

        }

        protected void Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Car x;
            
            string m, w, h, mx, p, pas, g, fc, y, c;
            foreach (Car n in OverLand.car)
            {
                if (n.model == model.SelectedItem.Value)
                {
                    n.setValues(out m, out w, out h, out mx, out p, out pas, out g,
                       out fc, out y, out c);
                    modelText.Text = m;
                    wheels.Text = w;
                    hp.Text = h;
                    maxSpeed.Text = mx;
                    price.Text = p;
                    passengers.Text = pas;
                    GType.Text = g;
                    FCap.Text = fc;
                    Year.Text = y;
                    color.Text = c;
                }
              /*  else if (n.model == "")
                {
                    model.Text = null;
                    wheels.Text = null;
                    hp.Text = null;
                    maxSpeed.Text = null;
                    price.Text = null;
                    passengers.Text = null;
                    GType.Text = null;
                    FCap.Text = null;
                    Year.Text = null;
                    color.Text = null;
                }*/
               
            }
        }

        protected void company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void maxSpeed_TextChanged(object sender, EventArgs e)
        {

        }

    }
}