<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Buses.aspx.cs" Inherits="AgencyProject.Buses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
<%--    <div>
    <a href="NewTransaction.aspx?type=overland&name=Bus&company=Merce" ><img src="images/meci.png"/></a>
    <a href="NewTransaction.aspx?type=overland&name=Bus&company=Thomas"><img src="images/thomas-bus.png" /></a>
    </div>--%>

    <div class="container">
        <div class="row">
            <div class="col-lg-6">
                <div class="col-xs-1 x_panel">
                    <div class="x_title">
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </ul>
                        <div class="clearfix">
                        </div>
                    </div>
                    <div class="x_content">
                        <a href="NewTransaction.aspx?type=overland&name=Bus&company=Merce">
                            <img class="img" src="images/meci.png" /></a>
                    </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="x_panel">
                    <div class="x_title">      
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </ul>
                        <div class="clearfix">
                        </div>
                    </div>
                    <div class="x_content">
                            <a href="NewTransaction.aspx?type=overland&name=Bus&company=Thomas"><img class="img" src="images/thomas-bus.png" /></a>
                    </div>
                </div>
            </div>
    </div></div>
    <style>
        img {
            width:100%;
        }
    </style>
</asp:Content>

