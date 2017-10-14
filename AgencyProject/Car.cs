using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgencyProject
{
    public class Car :OverLand
    {
       public Car(string name,string made,string model,float price,string color,
             int maxSpeed,int hp,string gearType,int year,int wheels,int fuelCapacity,int pplCapacity,int quantity):base( name, made, model, price, color,
              maxSpeed, hp, gearType, year, wheels, fuelCapacity, pplCapacity,quantity)
        {
           
            
        }
        public  void setValues(out string model,out string wheels,out string hp,out string maxspeed,out string price,
           out string passengers,out string gtype,out string fcap,out string year,out string color)
       {
           model = this.model;
           wheels = this.wheels.ToString();
           hp = this.hp.ToString();
           maxspeed = this.maxSpeed.ToString();
           price = this.price.ToString();
           passengers = this.peopleCapacity.ToString();
           gtype = this.gearType;
           fcap = this.fuelCapacity.ToString();
           year = this.year.ToString();
           color = this.Color;
       }
        public static void method(HttpServerUtility server,HttpRequest Request,DropDownList company,DropDownList model)
    {
             switch (server.UrlDecode(Request["company"]).ToString())
            {

                case "BMW":
                                company.SelectedValue = "BMW";

                  //  if (!IsPostBack)
                    //{
                    foreach (Car n in OverLand.car)
                    {
                        if (n.made == "BMW" /*&& model.Items.Count < 6*/)
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
                        foreach (Car n in OverLand.car)
                        {
                            if (n.made == "Mercedes" /*&& model.Items.Count < 5*/)
                                model.Items.Add(n.model);
                        }
                //    }
                    break;
                case "Kia":
                    company.SelectedValue = "Kia";
                    //  if (!IsPostBack)
                    //{
                        foreach (Car n in OverLand.car)
                        {
                            if (n.made == "Kia" /*&& model.Items.Count < 6*/)
                                model.Items.Add(n.model);
                        }
                    //}
                    break;
                case "Hyund":
                    company.SelectedValue = "Hyundai";
                    //if (!IsPostBack)
                    // {
                        foreach (Car n in OverLand.car)
                        {
                            if (n.made == "Hyundai"/* && model.Items.Count < 6*/)
                                model.Items.Add(n.model);
                        }
            //        }
            break;
            }
    }
    }
}