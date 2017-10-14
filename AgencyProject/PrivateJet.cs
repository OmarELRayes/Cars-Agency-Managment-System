using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgencyProject
{
    public class PrivateJet : Aerial
    {
        public PrivateJet(string name,string made,string model,int crew,int pplCapacity,int emptyWeight,
            int maxSpeed, int maxTakeoffWeight, float rateOfClimb, float price, int range, int fuelCapacity,int quantity)
            : base(name, made, model, crew, pplCapacity, emptyWeight, maxSpeed, maxTakeoffWeight, rateOfClimb, price, range, fuelCapacity,quantity)
        {

        }
        public static void method(HttpServerUtility server, HttpRequest Request, DropDownList company, DropDownList model)
        {
            switch (server.UrlDecode(Request["company"]).ToString())
            {

                case "Cessna":
                    company.SelectedValue = "Cessna";

                    //  if (!IsPostBack)
                    //{
                    foreach (PrivateJet n in Aerial.privatejet)
                    {
                        if (n.made == "Cessna" /*&& model.Items.Count < 6*/)
                        {
                            model.Items.Add(n.model);
                        }
                    }
                    //}
                    break;
                case "Pilatus":
                    company.SelectedValue = "Pilatus AirCraft";
                    //        if (!IsPostBack)
                    //      {
                    foreach (PrivateJet n in Aerial.privatejet)
                    {
                        if (n.made == "Pilatus AirCraft" /*&& model.Items.Count < 5*/)
                            model.Items.Add(n.model);
                    }
                    //    }
                    break;

            }
        }
    }
}