<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="AgencyProject.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AgenceProjectConnectionString %>" SelectCommand="SELECT * FROM [Employees]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" CssClass="Grid pagination "  AlternatingRowStyle-CssClass="alt"  PagerStyle-CssClass="pgr" runat="server"  AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" AutoGenerateEditButton="True">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                            <asp:BoundField DataField="Employee Name" HeaderText="Employee Name" SortExpression="Employee Name" />
                            <asp:BoundField DataField="Jop" HeaderText="Jop" SortExpression="Jop" />
                            <asp:BoundField DataField="Employee PNumber" HeaderText="Employee PNumber" SortExpression="Employee PNumber" />
                            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                            <asp:BoundField DataField="Employment Date" HeaderText="Employment Date" SortExpression="Employment Date" />
                            <asp:BoundField DataField="Employee Address" HeaderText="Employee Address" SortExpression="Employee Address" />
                            <asp:BoundField DataField="Passowrd" HeaderText="Passowrd" SortExpression="Passowrd" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="div">
                        <asp:Label ID="Label1" runat="server" Text="Employee Name:" CssClass="labels"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="inputs"></asp:TextBox>
                    </div>
                    <div class="div">
                        <asp:Label ID="Label2" runat="server" Text="Jop: " CssClass="labels"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="inputs"></asp:TextBox>
                    </div>
                    <div class="div">
                        <asp:Label ID="Label3" runat="server" Text="Phone Number" CssClass="labels"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="inputs"></asp:TextBox>
                    </div>
                    <div class="div">
                        <asp:Label ID="Label4" runat="server" Text="Salary" CssClass="labels"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="inputs"></asp:TextBox>
                    </div>
                    <div class="div">
                        <asp:Label ID="Label5" runat="server" Text="Employment Date" CssClass="labels"></asp:Label>
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="inputs"></asp:TextBox>
                    </div>
                    <div class="div">
                        <asp:Label ID="Label6" runat="server" Text="Address" CssClass="labels"></asp:Label>
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="inputs"></asp:TextBox>
                    </div>
                    <div class="div">
                        <asp:Label ID="Label7" runat="server" Text="Password" CssClass="labels"></asp:Label>
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="inputs"></asp:TextBox>
                    </div>
                    <div class="div">
                        <asp:Button id="submit_button" CssClass="submit btn btn-primary" Text="Save" runat="server" />
                    </div>
                </div>
            </div>
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
                           .labels {
                               display:inline-block;
                               width:28%;
                           }
                           .div {
                               margin-bottom:8px;
                               width:100%;
                           }
                           .inputs {
                               width:71%;
                           }
                           .submit {
                               width:100%;
                               padding-top:4px !important;
                               height:30px !important;
                           }
    </style>
</asp:Content>

