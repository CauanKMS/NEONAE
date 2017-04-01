﻿<%@ Page Title="" Language="C#" MasterPageFile="~/mpEmpresa.master" AutoEventWireup="true" CodeFile="empCriarEvento.aspx.cs" Inherits="empCriarEvento" %> <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server"><style type="text/css">.btnEvento {border-style: none;border-color: inherit;border-width: medium;font-size: 16px;background-color: #00ffff;color: white;padding: 6px;cursor: pointer;border-radius: 4px;transition: 0.3s;}.btnEvento:hover {background-color: #58d7ee;transition: 0.3s;}.auto-style8 {height: 10%;}.auto-style44 {height: 10%;}.auto-style23 {height: 10%;}.auto-style39 {height: 10%;}.auto-style54 {height: 12%;}.auto-style49 {height: 15%;}.auto256{height: 1%;}.auto55{height:12%;padding-bottom:15px;}.auto-style19 {width: 12%;padding-left: 12px;}.auto20 {width:13%;}.auto22 {width:13%;}.auto23 {width:20%;}.auto24 {width:23%;}.auto21 {}.auto-style16 {}</style></asp:Content> <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server"> <form id="form1" runat="server"> <table style="width: 100%; height: 537px;"> <tr> <td style="text-align: center; font-size: 20px; font-weight: bold;" class="auto-style19">CRIAR EVENTO<div class="line-title bg-primary"></div> </td> <td class="auto20"> <asp:SqlDataSource ID="sqlCriarEvento" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT COUNT(*) AS qtdEven FROM vernomeeven WHERE (nome = @nome)" InsertCommand="INSERT INTO evento(nome_even, uf_even, cid_even, rua_even, numlocal_even, nomelocal_even, img_even, detalhes_even, startdt_even, starthr_even, fimdt_even, fimhr_even, id_teve, id_st, id_emp, id_subt, ativo_even) VALUES (@evento, @uf, @cid, @rua, @num, @local, @img, @detalhes, @startdt, @starthr, @fimdt, @fimhr, @tipo, @status, @empresa, @subtipo, 1)"> <InsertParameters> <asp:Parameter Name="evento" /> <asp:Parameter Name="uf" /> <asp:Parameter Name="cid" /> <asp:Parameter Name="rua" /> <asp:Parameter Name="num" /> <asp:Parameter Name="local" /> <asp:Parameter Name="img" /> <asp:Parameter Name="detalhes" /> <asp:Parameter Name="startdt" /> <asp:Parameter Name="starthr" /> <asp:Parameter Name="fimdt" /> <asp:Parameter Name="fimhr" /> <asp:ControlParameter ControlID="ddlTipoEvento" Name="tipo" PropertyName="SelectedIndex" /> <asp:ControlParameter ControlID="ddlStatus" Name="status" PropertyName="SelectedIndex" /> <asp:SessionParameter Name="empresa" SessionField="idEmp" /> <asp:ControlParameter Name="subtipo" ControlID="ddlSubtipoEvento" PropertyName="SelectedIndex" /> </InsertParameters> <SelectParameters> <asp:ControlParameter ControlID="txtNomeEven" Name="nome" PropertyName="Text" /> </SelectParameters> </asp:SqlDataSource> <asp:SqlDataSource ID="sqlRanking" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into ranking values(0,@id,@classif,@qtdfav)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM ranking"> <InsertParameters> <asp:Parameter Name="id" /> <asp:Parameter Name="classif" /> <asp:Parameter Name="qtdfav" /> </InsertParameters> </asp:SqlDataSource> </td> <td class="auto21"> <asp:Label ID="lblResp" runat="server" Font-Bold="True" Font-Size="16px" ForeColor="Red"></asp:Label> </td> <td class="auto22"></td> <td class="auto23"> <asp:SqlDataSource ID="sqlIdEventoPrivado" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT COUNT(*) AS qtd_even FROM getidevento" InsertCommand="insert into aud_emp values(0,@id,@table,@desc,@hr,@data)"> <InsertParameters> <asp:Parameter Name="id" /> <asp:Parameter Name="table" /> <asp:Parameter Name="desc" /> <asp:Parameter Name="hr" /> <asp:Parameter Name="data" /> </InsertParameters> </asp:SqlDataSource> </td> <td class="auto24">&nbsp;</td> </tr> <tr> <td class="auto-style8">&nbsp;</td> <td style="text-align: right;">Nome do Evento:</td> <td>&nbsp;<asp:TextBox ID="txtNomeEven" runat="server" Width="160px" MaxLength="40"></asp:TextBox> </td> <td style="text-align: right;">Aberto/Privado:</td> <td>&nbsp;<asp:DropDownList ID="ddlStatus" runat="server" Width="109px"> <asp:ListItem></asp:ListItem> <asp:ListItem>Aberto</asp:ListItem> <asp:ListItem>Privado</asp:ListItem> </asp:DropDownList> </td> <td style="color: #ff0000; font-weight: bold;">Se seu evento for &quot;Privado&quot;, você será redirecionado para a página de Ingressos.</td> </tr> <tr> <td class="auto-style8">&nbsp;</td> <td style="text-align: right;">Tipo de Evento:</td> <td>&nbsp;<asp:DropDownList ID="ddlTipoEvento" runat="server" Width="260px"> <asp:ListItem></asp:ListItem> <asp:ListItem>Beneficente</asp:ListItem> <asp:ListItem>Games</asp:ListItem> <asp:ListItem>Workshop</asp:ListItem> <asp:ListItem>Boate</asp:ListItem> <asp:ListItem>Show</asp:ListItem> <asp:ListItem>Social</asp:ListItem> <asp:ListItem>Palestra - Livre</asp:ListItem> <asp:ListItem>Palestra - Para Maiores de 18 Anos</asp:ListItem> <asp:ListItem>Stand Up - Livre</asp:ListItem> <asp:ListItem>Stand Up - Para Maiores de 18 Anos</asp:ListItem> </asp:DropDownList></td> <td style="text-align: right;">Subtipo de Evento:</td> <td>&nbsp;<asp:DropDownList ID="ddlSubtipoEvento" runat="server" Width="180px"> <asp:ListItem></asp:ListItem> <asp:ListItem>Sertanejo</asp:ListItem> <asp:ListItem>Baile</asp:ListItem> <asp:ListItem>Rock</asp:ListItem> <asp:ListItem>Empresarial</asp:ListItem> <asp:ListItem>Jazz</asp:ListItem> <asp:ListItem>Clube de Dança</asp:ListItem> <asp:ListItem>Motivacional</asp:ListItem> <asp:ListItem>Apresentação/Exibição</asp:ListItem> <asp:ListItem>Jantar</asp:ListItem> <asp:ListItem>Pop</asp:ListItem> </asp:DropDownList> </td> <td>&nbsp;</td> </tr> <tr> <td class="auto-style44">&nbsp;</td> <td style="text-align: right;">Nome do Local:</td> <td>&nbsp;<asp:TextBox ID="txtNomeLocal" runat="server" Width="155px" MaxLength="40"></asp:TextBox> </td> <td style="text-align: right;">&nbsp;</td> <td>&nbsp;</td> <td>&nbsp;</td> </tr> <tr> <td class="auto-style44"></td> <td style="text-align: right;">UF:</td> <td>&nbsp;<asp:TextBox ID="txtUf" runat="server" MaxLength="2" Width="40px"></asp:TextBox> </td> <td style="text-align: right;">Cidade:</td> <td>&nbsp;<asp:TextBox ID="txtCidade" runat="server" MaxLength="50"></asp:TextBox> </td> <td>&nbsp;</td> </tr> <tr> <td class="auto-style23"></td> <td style="text-align: right;">Endereço:</td> <td>&nbsp;<asp:TextBox ID="txtRua" runat="server" Width="159px" MaxLength="40"></asp:TextBox> </td> <td style="text-align: right;">Número:</td> <td>&nbsp;<asp:TextBox ID="txtNumLocal" runat="server" Width="74px" MaxLength="4" ClientIDMode="Static"></asp:TextBox> </td> <td></td> </tr> <tr> <td class="auto-style39"></td> <td style="text-align: right;">Imagem Promocional:</td> <td> <asp:FileUpload ID="FileUpload1" runat="server" /> </td> <td></td> <td></td> <td>&nbsp;</td> </tr> <tr> <td class="auto-style16">&nbsp;</td> <td style="text-align: right;">Detalhes do Evento:</td> <td>&nbsp;<asp:TextBox ID="txtDetalhe" runat="server" Height="56px" TextMode="MultiLine" Width="191px" MaxLength="500"></asp:TextBox> </td> <td>&nbsp;</td> <td>&nbsp;</td> <td>&nbsp;</td> </tr> <tr> <td class="auto-style54"></td> <td style="text-align: right;">Data de Início:</td> <td>&nbsp;<asp:TextBox ID="txtDtInicio" runat="server" ClientIDMode="Static"></asp:TextBox> </td> <td style="text-align: right;">Horário de Início:</td> <td>&nbsp;<asp:TextBox ID="txtHrInicio" runat="server" ClientIDMode="Static" Width="69px"></asp:TextBox> </td> <td>&nbsp;</td> </tr> <tr> <td class="auto55">&nbsp;</td> <td style="text-align: right;">Data de Término:</td> <td>&nbsp;<asp:TextBox ID="txtDtFim" runat="server" ClientIDMode="Static"></asp:TextBox> </td> <td style="text-align: right;">Horário de Término:</td> <td>&nbsp;<asp:TextBox ID="txtHrFim" runat="server" ClientIDMode="Static" Width="69px"></asp:TextBox> </td> <td>&nbsp;</td> </tr> <tr> <td class="auto-style49"></td> <td style="text-align: right;"></td> <td></td> <td style="text-align: right;"></td> <td> <asp:Button ID="btnCriarEvento" runat="server" Font-Bold="False" Text="Criar Evento" Width="85%" OnClick="btnCriarEvento_Click" CssClass="btnEvento" Height="35px" /> </td> <td>&nbsp;</td> </tr> <tr> <td class="auto256">&nbsp;</td> <td style="text-align: right;">&nbsp;</td> <td>&nbsp;</td> <td style="text-align: right;">&nbsp;</td> <td>&nbsp;</td> <td>&nbsp;</td> </tr> </table> </form> </asp:Content> 