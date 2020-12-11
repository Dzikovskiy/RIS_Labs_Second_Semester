<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    Calculate
    <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
    <asp:Button ID="sumBtn" runat="server" Text="+" OnClick="sumBtn_Click"/>
    <asp:Button ID="minusBtn" runat="server" Text="-" OnClick="minusBtn_Click"/>
    <asp:Button ID="mulBtn" runat="server" Text="*" OnClick="mulBtn_Click"/>
    <asp:Button ID="divBtn" runat="server" Text="/" OnClick="divBtn_Click"/>
    <asp:TextBox ID="textBox2" runat="server"></asp:TextBox>
    <asp:Label ID="ResultLb" runat="server" Text="Label" Visible="False"></asp:Label>


</asp:Content>