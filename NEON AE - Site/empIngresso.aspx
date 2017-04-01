﻿<%@ Page Title="" Language="C#" MasterPageFile="~/mpEmpresa.master" AutoEventWireup="true" CodeFile="empIngresso.aspx.cs" Inherits="empIngresso" %> <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> <style type="text/css"> .auto-style1 { width: 20%; } .auto-style2 { width: 10%; } .btnEvento { border-style: none; border-color: inherit; border-width: medium; font-size: 16px; background-color: #00ffff; color:white; padding:6px; cursor:pointer; border-radius: 4px; transition: 0.3s; } .btnEvento:hover{ background-color: #58d7ee; transition:0.3s; } .auto-style3 { width: 20%; } .auto-style4 { width: 20%; height: 56px; } .auto-style5 { width:25%; height: 56px; } .auto-style6 { width: 302px; height: 56px; } .auto-style7 { height: 56px; } .auto-style8 { width: 20%; height: 48px; } .auto-style9 { width: 20%; height: 48px; } .auto-style10 { width: 302px; height: 48px; } .auto-style11 { height: 48px; } .auto-style12 { width: 20%; height: 42px; } .auto-style13 { width: 20%; height: 42px; } .auto-style14 { width: 302px; height: 42px; } .auto-style15 { height: 42px; } </style> </asp:Content> <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> <form id="form1" runat="server"> <table style="width: 100%; height: 202px;"> <tr> <td style="text-align:center;font-size:20px;font-weight:bold;" class="auto-style4">INGRESSOS<div class="line-title bg-primary"></div></td> <td class="auto-style5"></td> <td class="auto-style6"> <asp:SqlDataSource ID="sqlIngressos" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="INSERT INTO ingressos(id_even, qtddisp_ing, precotot_ing, qtdvend_ing) VALUES (@id, @qtd, @preco,'gMcO0KKCb0sV0Hvc94u79g==')" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM ingressos"> <InsertParameters> <asp:SessionParameter Name="id" SessionField="getIdEvento" /> <asp:Parameter Name="qtd" /> <asp:Parameter Name="preco" /> </InsertParameters> </asp:SqlDataSource> <asp:SqlDataSource ID="sqlRanking" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into ranking values(0,@id,@classif,@qtdfav)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM ranking"> <InsertParameters> <asp:SessionParameter Name="id" SessionField="getIdEvento" /> <asp:Parameter Name="classif" /> <asp:Parameter Name="qtdfav" /> </InsertParameters> </asp:SqlDataSource> </td> <td class="auto-style7"> <asp:SqlDataSource ID="sqlEventos" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="INSERT INTO evento(nome_even, uf_even, cid_even, rua_even, numlocal_even, nomelocal_even, img_even, detalhes_even, startdt_even, starthr_even, fimdt_even, fimhr_even, id_teve, id_st, id_emp, id_subt, ativo_even) VALUES (@evento, @uf, @cid, @rua, @num, @local, @img, @detalhes, @startdt, @starthr, @fimdt, @fimhr, @tipo, @status, @empresa, @subtipo, 1)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM evento"> <InsertParameters> <asp:SessionParameter Name="evento" SessionField="evento" /> <asp:SessionParameter Name="uf" SessionField="uf" /> <asp:SessionParameter Name="cid" SessionField="cid" /> <asp:SessionParameter Name="rua" SessionField="rua" /> <asp:SessionParameter Name="num" SessionField="num" /> <asp:SessionParameter Name="local" SessionField="local" /> <asp:SessionParameter Name="img" SessionField="img" /> <asp:SessionParameter Name="detalhes" SessionField="detalhes" /> <asp:SessionParameter Name="startdt" SessionField="startdt" /> <asp:SessionParameter Name="starthr" SessionField="starthr" /> <asp:SessionParameter Name="fimdt" SessionField="fimdt" /> <asp:SessionParameter Name="fimhr" SessionField="fimhr" /> <asp:SessionParameter Name="tipo" SessionField="tipo" /> <asp:SessionParameter Name="status" SessionField="status" /> <asp:SessionParameter Name="empresa" SessionField="idEmp" /> <asp:SessionParameter Name="subtipo" SessionField="subtipo" /> </InsertParameters> </asp:SqlDataSource> <asp:SqlDataSource ID="sqlAudEmp" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into aud_emp values(0,@id,@table,@desc,@hr,@data)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM admeventos"> <InsertParameters> <asp:Parameter Name="id"/> <asp:Parameter Name="table" /> <asp:Parameter Name="desc" /> <asp:Parameter Name="hr" /> <asp:Parameter Name="data" /> </InsertParameters> </asp:SqlDataSource> </td> </tr> <tr> <td class="auto-style8"></td> <td class="auto-style9" style="text-align:right;">Quantidade de Ingressos (Total):</td> <td class="auto-style10"> &nbsp;<asp:TextBox ID="txtQtdIng" runat="server" MaxLength="11" Width="74px"></asp:TextBox> </td> <td class="auto-style11"> </td> </tr> <tr> <td class="auto-style12"></td> <td class="auto-style13" style="text-align:right;">Preço Total (R$):</td> <td class="auto-style14"> &nbsp;<asp:TextBox ID="txtPreco" runat="server" MaxLength="10" Width="74px"></asp:TextBox> </td> <td class="auto-style15"> </td> </tr> <tr> <td class="auto-style1">&nbsp;</td> <td class="auto-style2" style="text-align:right;">&nbsp;</td> <td class="auto-style3"> <asp:Label ID="lblResp" runat="server" Font-Bold="True"></asp:Label> </td> <td> <asp:Button ID="btnCriarEvento" runat="server" Font-Bold="False" Height="35px" Text="Criar Evento" Width="50%" OnClick="btnCriarEvento_Click" CssClass="btnEvento" /> </td> </tr> <tr> <td class="auto-style1">&nbsp;</td> <td class="auto-style2" style="text-align:right;">&nbsp;</td> <td class="auto-style3"> &nbsp;</td> <td> &nbsp;</td> </tr> </table> </form> </asp:Content> 