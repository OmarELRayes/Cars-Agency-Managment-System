using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgencyProject
{
    public class WaterCraft:OverSea
    {
        public WaterCraft(string name, string made, string model, int maxSpeed, int hp, float price,
            int numberOfCapins, int year, int fuelCapacity, int Quantity):base(name,made,model,maxSpeed,hp,price,numberOfCapins,year,fuelCapacity,Quantity)
        {

        }
        public static void method(HttpServerUtility server, HttpRequest Request, DropDownList company, DropDownList model)
        {
            switch (server.UrlDecode(Request["company"]).ToString())
            {

                case "SEA-DOO":
                    company.SelectedValue = "SEA-DOO";

                    //  if (!IsPostBack)
                    //{
                    foreach (Yacht n in OverSea.yacht)
                    {
                        if (n.made == "SEA-DOO" /*&& model.Items.Count < 6*/)
                        {
                            model.Items.Add(n.model);
                        }
                    }
                    //}
                    break;
                case "Kawasaki":
                    company.SelectedValue = "Kawasaki";
                    //        if (!IsPostBack)
                    //      {
                    foreach (Yacht n in OverSea.yacht)
                    {
                        if (n.made == "Kawasaki" /*&& model.Items.Count < 5*/)
                            model.Items.Add(n.model);
                    }
                    //    }
                    break;

            }
        }
    }
}