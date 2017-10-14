<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="AgencyProject.Cars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form id="form1" runat="server">
        <div class="container">
        <div class="row">
                <div class="col-lg-6 text-center">
                   <a href="NewTransaction.aspx?type=overland&name=Car&company=BMW" ><img class="logo" style="width:200px" src="images/BMW.png" /></a><br />
                    
&nbsp;</div>
                <div class="col-lg-6 text-center">
                    <a href="NewTransaction.aspx?type=overland&name=Car&company=Kia"><img class="logo" style="width:300px" src="images/Kia.png"/></a>
                </div>
              <div class="col-lg-6 text-center">
                  <a href="NewTransaction.aspx?type=overland&name=Car&company=Merce">  <img class="logo" style="width:335px" src="images/meci.png"/></a>
                </div>
                <div class="col-lg-6 text-center">
                   <a href="NewTransaction.aspx?type=overland&name=Car&company=Hyund"> <img class="logo"  src="images/hyundai.png"/></a>
                </div>
            </div>
            <style>
                .logo {
                    margin-top: 45px;
                    width:400px;
                }
            </style>

    </div>
        
    </form>
        
</asp:Content>
