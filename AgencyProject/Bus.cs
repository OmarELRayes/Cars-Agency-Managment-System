using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace AgencyProject
{
    public class Bus : OverLand
    {
        public Bus(string name,string made,string model,float price,string color,
             int maxSpeed,int hp,string gearType,int year,int wheels,int fuelCapacity,int pplCapacity,int quantity):base( name, made, model, price, color,
              maxSpeed, hp, gearType, year, wheels, fuelCapacity, pplCapacity,quantity)
        {
            
            
        }
        public static void method(HttpServerUtility server, HttpRequest Request, DropDownList company, DropDownList model)
        {
            switch (server.UrlDecode(Request["company"]).ToString())
            {

                case "Thomas":
                    company.SelectedValue = "Thomas Bus";

                    //  if (!IsPostBack)
                    //{
                    foreach (Bus n in OverLand.bus)
                    {
                        if (n.made == "Thomas Bus" /*&& model.Items.Count < 6*/)
                        {
                            model.Items.Add(n.model);
                        }
                    }
                    //}
                    break;
                case "Merce":
                    company.SelectedValue = "Mercedes";
                    //        if (!IsPostBack)
                    //      {
                    foreach (Bus n in OverLand.bus)
                    {
                        if (n.made == "Mercedes" /*&& model.Items.Count < 5*/)
                            model.Items.Add(n.model);
                    }
                    //    }
                    break;
               
            }
        }
    }
}