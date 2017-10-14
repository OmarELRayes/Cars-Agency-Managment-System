<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stock.aspx.cs" Inherits="AgencyProject.Stock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form runat="server" class="container">
        <div class="row">
            <div class="col-lg-12" style="margin-bottom:22px">
                <asp:Label ID="Label1" runat="server" Text="Show: " CssClass="labels ax"></asp:Label>
                <asp:DropDownList ID="show" runat="server" DataTextField="show" DataValueField="show" CssClass="list" OnSelectedIndexChanged="show_SelectedIndexChanged">
                    <asp:ListItem >--OverLand</asp:ListItem>
                    <asp:ListItem>Cars</asp:ListItem>
                    <asp:ListItem>Buses</asp:ListItem>
                    <asp:ListItem>Trucks</asp:ListItem>
                    <asp:ListItem >--OverSea</asp:ListItem>
                    <asp:ListItem>Yacht</asp:ListItem>
                    <asp:ListItem>Water Carft</asp:ListItem>
                    <asp:ListItem >--Areial</asp:ListItem>
                    <asp:ListItem>Helicopter</asp:ListItem>
                    <asp:ListItem>PrivateJet</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-lg-12">
                <asp:GridView ID="GridView1" CssClass="Grid pagination "  AlternatingRowStyle-CssClass="alt"  PagerStyle-CssClass="pgr" runat="server"  AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" AutoGenerateEditButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="836px" Width="1924px">
            <AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name"  SortExpression="Name" ReadOnly="True" />
                        <asp:BoundField DataField="Made" HeaderText="Made" SortExpression="Made" ReadOnly="True" />
                        <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" ReadOnly="True"/>
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ReadOnly="True"/>
                        <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" ReadOnly="True"/>
                        <asp:BoundField DataField="Max Speed" HeaderText="Max Speed" SortExpression="Max Speed" ReadOnly="True"/>
                        <asp:BoundField DataField="HP" HeaderText="HP" SortExpression="HP" ReadOnly="True"/>
                        <asp:BoundField DataField="Gear Type" HeaderText="Gear Type" SortExpression="Gear Type" ReadOnly="True"/>
                        <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" ReadOnly="True"/>
                        <asp:BoundField DataField="Wheels" HeaderText="Wheels" SortExpression="Wheels" ReadOnly="True"/>
                        <asp:BoundField DataField="Fuel Capacity" HeaderText="Fuel Capacity" SortExpression="Fuel Capacity" ReadOnly="True"/>
                        <asp:BoundField DataField="Ppl Capacity" HeaderText="Ppl Capacity" SortExpression="Ppl Capacity" ReadOnly="True" />
                        <asp:BoundField DataField="Capacity" HeaderText="Capacity" SortExpression="Capacity" ReadOnly="True"/>
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AgenceProjectConnectionString %>" SelectCommand="SELECT * FROM [Stock-OverLand]" OnSelecting="SqlDataSource1_Selecting">
                    <FilterParameters>
        <asp:ControlParameter Name="show" ControlID="show" PropertyName="SelectedValue" />
    </FilterParameters>
                </asp:SqlDataSource>
            </div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AgenceProjectConnectionString %>" SelectCommand="SELECT * FROM [Stock-OverLand] WHERE ([Name] = @Name)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Bus" Name="Name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
    <style>
        .Grid {font-size:11pt;background-color: #fff; margin: 5px 0 10px 0; 
                border: solid 1px #525252; border-collapse:collapse; font-family:Calibri; color: #474747;
        }
.Grid td {
      padding: 25px;
      border: solid 1px #c1c1c1; }
.Grid th  {
    font-size:14pt !important;
    font-weight:800;
      padding : 12px 17px;
      color: #fff;
      background: #2A3F54 repeat-x top;
      border-left: solid 1px #525252;
      font-size: 0.9em; }
.Grid .alt {
      background: #fcfcfc repeat-x top; }
.Grid .pgr {background: #2A3F54 repeat-x top; }
.Grid .pgr table { margin: 3px 0; }
.Grid .pgr td { border-width: 0; padding: 0 6px; border-left: solid 1px white; font-weight: bold; color: #fff; line-height: 12px; }  
.Grid .pgr a { color: white; text-decoration: none; }
        .Grid .pgr a:hover {
            color: #78A8D8;
            text-decoration: none;
        }
        .list {
            width:200px;
            height:30px;
        }
                           .labels {
                display: inline-block;
                width:60px;
                font-size:13pt; 
            }
    </style>
</asp:Content>
