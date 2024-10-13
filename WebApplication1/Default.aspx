<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
   
    <asp:Button ID="Button1" runat="server" Text="C to F" OnClick="Button1_Click1" />
  
    <asp:Label ID="Label1" runat="server" Text="Temp" BorderWidth="2px" Width="333px"></asp:Label>

    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>

    <asp:Button ID="Button2" runat="server" Text="F to C" OnClick="Button2_Click" />

    <asp:Label ID="Label2" runat="server" Text="Temp" BorderWidth="2px" Width="333px"></asp:Label>

    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>

    <asp:Button ID="Button3" runat="server" Text="Sort" OnClick="Button3_Click" />

    <asp:Label runat="server" Text="Sorted #'s" BorderWidth="2px" ID="ctl00" Width="338px"></asp:Label>

</asp:Content>