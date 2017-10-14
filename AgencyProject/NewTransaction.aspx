<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewTransaction.aspx.cs" Inherits="AgencyProject.NewTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">

    <form id="form1" runat="server" style="margin-top: 50px;padding: 50px;" class="container">
        <div class="row">
        <div class="ax col-lg-7">
            <div class="row">
                <div class="col-lg-12 ">
                    <asp:Label ID="Label5" runat="server" Text="Payment No." CssClass="Labels left-box ax"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="inputs ax"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class=" col-lg-6">
                    <asp:DropDownList runat="server">
                        <asp:ListItem Text="text1" />
                        <asp:ListItem Text="text2" />
                    </asp:DropDownList>
                    <asp:Label ID="Label22" runat="server" Text="Vehcile Type" CssClass="Labels left-box ax" ></asp:Label>
                    <asp:DropDownList ID="type" runat="server" CssClass="inputs left-box ax"  Enabled="False"></asp:DropDownList>
                    <asp:Label ID="Label23" runat="server" Text="Company" CssClass="left-box Labels ax"></asp:Label>
                    <asp:DropDownList ID="company" runat="server" CssClass="left-box inputs ax" Enabled="False" OnSelectedIndexChanged="company_SelectedIndexChanged"></asp:DropDownList>
                    <asp:Label ID="Label24" runat="server" Text="Model" CssClass="left-box Labels ax"></asp:Label>
                    <asp:DropDownList ID="model" runat="server" CssClass="left-box inputs ax" OnSelectedIndexChanged="Model_SelectedIndexChanged" AutoPostBack="True" EnableViewState="True">
                        <asp:ListItem Selected="True"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="Label6" runat="server" Text="Customer Name" CssClass="Labels left-box ax"></asp:Label>
                    <asp:TextBox ID="cName" runat="server" CssClass="inputs left-box ax"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="Customer Mobile" CssClass="Labels left-box ax"></asp:Label>
                    <asp:TextBox ID="cMobile" runat="server" CssClass="inputs left-box ax"></asp:TextBox>
                    <asp:Label ID="Label8" runat="server" Text="Customer Address" CssClass="Labels left-box ax"></asp:Label>
                    <asp:TextBox ID="cAddress" runat="server" CssClass="inputs left-box ax"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    mm</div>
                <div class="col-lg-6">
                    <asp:Button  ID="Clear" runat="server" Text="Clear" CssClass="btn btn-primary btn-p" OnClick="Clear_Click"/>
                </div>
            </div>
        </div>
        <div  style="display:inline-block;padding-left: 65px;border-left: 1.5px solid blueviolet;" class="col-lg-5">
            <div class="ax" style="margin-right:145px;">
                <asp:Label ID="Label9" runat="server" Text="Model" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="modelText" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label10" runat="server" Text="Wheels Size" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="wheels" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label11" runat="server" Text="HP" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="hp" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label12" runat="server" Text="Top Speed" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="maxSpeed" runat="server" CssClass="inputs inputs-left" OnTextChanged="maxSpeed_TextChanged" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label13" runat="server" Text="Gear Type" CssClass="Labels" ></asp:Label>
                <asp:TextBox ID="GType" runat="server"  CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
            </div>
            <div class="ax">
                <asp:Label ID="Label14" runat="server" Text="Fuel Capacity" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="FCap" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label15" runat="server" Text="Manifacture Year" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="Year" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label16" runat="server" Text="Color" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="color" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label17" runat="server" Text="Price" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="price" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label18" runat="server" Text="Max flight Height" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="maxFHeight" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label19" runat="server" Text="Capacity" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="cap" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label20" runat="server" Text="Passengers" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="passengers" runat="server" CssClass="inputs inputs-left" Enabled="false"></asp:TextBox>
            </div>
        </div>
            </div>
        
        <style>
            .btn-p {
                width: 100%;
                padding-top:4px;
                height:40px !important;
                margin-top:15px;

            } 

                        .Labels {
                display: inline-block;
                width:200px;
                font-size:14pt; 
            }
            .inputs {
                display:block;
                width:190px;
                height:35px;
            }
            .ax {
                
                display:inline-block;
            }
            .inputs-left {
                width:190px;
            }
            .left-box {
                margin-top:15px;
                margin-bottom:15px;
            }
        </style>
    </form>

</asp:Content>
