using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgencyProject
{
    public class Helicopter :Aerial
    {
        public Helicopter(string name, string made, string model, int crew, int pplCapacity, int emptyWeight,
            int maxSpeed, int maxTakeoffWeight, float rateOfClimb, float price, int range, int fuelCapacity,int quantity):base(name,made,model,crew,pplCapacity,emptyWeight,maxSpeed,maxTakeoffWeight,rateOfClimb,price,range,fuelCapacity,quantity)
        {

        }
        public static void method(HttpServerUtility server, HttpRequest Request, DropDownList company, DropDownList model)
        {
            switch (server.UrlDecode(Request["company"]).ToString())
            {

                case "Agusta":
                    company.SelectedValue = "AgustaWestland";

                    //  if (!IsPostBack)
                    //{
                    foreach (Helicopter n in Aerial.helicopter)
                    {
                        if (n.made == "AgustaWestland" /*&& model.Items.Count < 6*/)
                        {
                            model.Items.Add(n.model);
                        }
                    }
                    //}
                    break;
                case "Bell":
                    company.SelectedValue = "Bell";
                    //        if (!IsPostBack)
                    //      {
                    foreach (Helicopter n in Aerial.helicopter)
                    {
                        if (n.made == "Bell" /*&& model.Items.Count < 5*/)
                            model.Items.Add(n.model);
                    }
                    //    }
                    break;

            }
        }
    }
}