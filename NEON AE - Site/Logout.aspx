﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="Logout" %> <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server"></asp:Content><asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server"><form id="form1" runat="server"><table style="width: 100%; height: 151px;"><tr><td style="text-align: center; font-weight: bold; font-size: 20px;" class="auto-style1">LOGOUT<div class="line-title bg-primary"></div></tr><tr><td style="text-align: center;">Você foi desconectado! <a href="Default.aspx" style="color: cyan; font-weight: bold">CLIQUE AQUI</a> para voltar à Home.<a href="Logout.aspx" class="linear"><asp:SqlDataSource ID="sqlLogoutUsu" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into aud_usu values(0,@id,@table,@desc,@hr,@data)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM aud_usu"><InsertParameters><asp:Parameter Name="id" /><asp:Parameter Name="table" /><asp:Parameter Name="desc" /><asp:Parameter Name="hr" /><asp:Parameter Name="data" /></InsertParameters></asp:SqlDataSource><asp:SqlDataSource ID="sqlLogoutADM" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into aud_adm values(0,@id,@table,@desc,@hr,@data)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM aud_usu"><InsertParameters><asp:Parameter Name="id" /><asp:Parameter Name="table" /><asp:Parameter Name="desc" /><asp:Parameter Name="hr" /><asp:Parameter Name="data" /></InsertParameters></asp:SqlDataSource><asp:SqlDataSource ID="sqlLogoutFunc" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into aud_func values(0,@id,@table,@desc,@hr,@data)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM aud_usu"><InsertParameters><asp:Parameter Name="id" /><asp:Parameter Name="table" /><asp:Parameter Name="desc" /><asp:Parameter Name="hr" /><asp:Parameter Name="data" /></InsertParameters></asp:SqlDataSource><asp:SqlDataSource ID="sqlLogoutEmp" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into aud_emp values(0,@id,@table,@desc,@hr,@data)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM aud_usu"><InsertParameters><asp:Parameter Name="id" /><asp:Parameter Name="table" /><asp:Parameter Name="desc" /><asp:Parameter Name="hr" /><asp:Parameter Name="data" /></InsertParameters></asp:SqlDataSource></td></tr></table></form></asp:Content> 