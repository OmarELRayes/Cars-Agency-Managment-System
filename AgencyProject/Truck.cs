using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgencyProject
{
    public class Truck :OverLand
    {
        int Capacity;
        public Truck(string name,string made,string model,float price,string color,
             int maxSpeed,int hp,string gearType,int year,int wheels,int fuelCapacity,int pplCapacity,int capacity,int quantity):base( name, made, model, price, color,
              maxSpeed, hp, gearType, year, wheels, fuelCapacity, pplCapacity,quantity)
        {
            
            this.Capacity = capacity;

        }
        public static void method(HttpServerUtility server, HttpRequest Request, DropDownList company, DropDownList model)
        {
            switch (server.UrlDecode(Request["company"]).ToString())
            {

                case "Cat":
                    company.SelectedValue = "Cat";

                    //  if (!IsPostBack)
                    //{
                    foreach (Truck n in OverLand.truck)
                    {
                        if (n.made == "Cat" /*&& model.Items.Count < 6*/)
                        {
                            model.Items.Add(n.model);
                        }
                    }
                    //}
                    break;
                case "Ford":
                    company.SelectedValue = "Ford";
                    //        if (!IsPostBack)
                    //      {
                    foreach (Truck n in OverLand.truck)
                    {
                        if (n.made == "Ford" /*&& model.Items.Count < 5*/)
                            model.Items.Add(n.model);
                    }
                    //    }
                    break;

            }
        }
    }
}