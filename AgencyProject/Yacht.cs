using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgencyProject
{
    public class Yacht: OverSea
    {
        public Yacht(string name, string made, string model, int maxSpeed, int hp, float price, int numberOfCapins, 
            int year, int fuelCapacity, int Quantity):base(name,made,model,maxSpeed,hp,price,numberOfCapins,year,fuelCapacity,Quantity)
        {
            
        }
        public static void method(HttpServerUtility server, HttpRequest Request, DropDownList company, DropDownList model)
        {
            switch (server.UrlDecode(Request["company"]).ToString())
            {

                case "FERRETTI":
                    company.SelectedValue = "FERRETTI";

                    //  if (!IsPostBack)
                    //{
                    foreach (Yacht n in OverSea.yacht)
                    {
                        if (n.made == "FERRETTI" /*&& model.Items.Count < 6*/)
                        {
                            model.Items.Add(n.model);
                        }
                    }
                    //}
                    break;
                case "Delta":
                    company.SelectedValue = "Delta";
                    //        if (!IsPostBack)
                    //      {
                    foreach (Yacht n in OverSea.yacht)
                    {
                        if (n.made == "Delta" /*&& model.Items.Count < 5*/)
                            model.Items.Add(n.model);
                    }
                    //    }
                    break;

            }
        }
    }
}