﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CadastroEmp.aspx.cs" Inherits="CadastroEmp" %> <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server"> <style type="text/css"> .txtFone {min-width: 103px;} .txtNum {min-width: 40px;} .txtES {width: 45%;} .txtCEP {min-width: 78px;} .txtCel {min-width: 110px;} .txtCNPJ {min-width: 130px;} .txtCompl {min-width: 40px;} .txtEmp{min-width:70px;} .txtResp{min-width:84px;} .lblErroConta{font-stretch:ultra-condensed;} .imgUploader {min-width: 120px;} .btnOK {min-width: 36px;border-style: none;border-color: inherit;border-width: medium;font-size: 16px;background-color: #00ffff;color: white;padding: 6px;cursor: pointer;border-radius: 4px;transition: 0.3s;} .btnOK:hover {background-color: #58d7ee;transition: 0.3s;} .btnForca {min-width: 115px;border-style: none;border-color: inherit;border-width: medium;font-size: 16px;background-color: #00ffff;color: white;padding: 6px;cursor: pointer;border-radius: 4px;transition: 0.3s;} .btnForca:hover {background-color: #58d7ee;transition: 0.3s;} .btnCad {min-width: 87px;border-style: none;border-color: inherit;border-width: medium;font-size: 16px;background-color: #00ffff;color: white;padding: 6px;cursor: pointer;border-radius: 4px;transition: 0.3s;} .btnCad:hover {background-color: #58d7ee;transition: 0.3s;} .auto-style4 {height: 25px;}.auto-style5 {width: 5%; height: 36px;}.auto-style6 {width: 23%;}.auto-style8 {width: 20%;}.auto-style20 {height: 35px;}.auto-style25 {width: 2%;height: 35px;}.auto-style26 {width: 13%;}.auto-style27 {width: 25%;}.auto-style28 {width: 30%;}.auto-style30 {width: 5%;}.auto-style31 {height: 30%;}.auto-style32 {width: 42%;}.auto-style33 {width: 30%;}.auto-style43 {height: 35px;}.auto-style49 {width: 13%;}.auto-style57 {width: 12%;}.auto-style58 {width: 80%;}.auto-style59 {height: 36px;}.auto-style61 {width: 20%;}.auto-style65 {height: 35px;} .auto-style1 {}.auto-style2 {}.auto-style21 {}.auto-style22 {}.auto-style23 {}.auto-style13 {}.auto-style34 {}.auto-style44 {}.auto-style45 {}.auto-style46 {}.auto-style48 {}.auto-style51 {}.auto-style52 {}.auto-style60 {}.auto-style62 {}.auto-style63 {}.auto-style64 {}.auto-style66 {}.auto-style67 {}.auto-style68 {}.auto-style69 {} </style> </asp:Content> <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server"> <form id="form1" runat="server"> <table style="width: 100%; height: 76px;"> <tr> <td style="text-align: center; font-weight: bold; font-size: 20px;" class="auto-style57">CADASTRO <div class="line-title bg-primary"></div> </td> <td class="auto-style58"></td> <td class="auto-style59"></td> </tr> <tr> <td style="text-align: center; font-weight: bold; font-size: 20px;" class="auto-style31"></td> <td style="text-align: center; font-weight: bold; font-size: 16px;" class="auto-style34">INFORMAÇÕES BÁSICAS</td> <td class="auto-style60"></td> </tr> </table> <table style=""> <tr> <td class="auto-style25"></td> <td class="auto-style26" style="text-align: right;">Nome da Empresa: </td> <td class="auto-style27">&nbsp;<asp:TextBox ID="txtNome" runat="server" Width="70%" MaxLength="40" CssClass="txtEmp"></asp:TextBox> </td> <td class="auto-style28" style="text-align: right">Nome do Responsável:</td> <td class="auto-style61">&nbsp;<asp:TextBox ID="txtNomeResp" runat="server" MaxLength="40" Width="70%" CssClass="txtResp"></asp:TextBox> </td> <td class="auto-style30"></td> </tr> <tr> <td class="auto-style20">&nbsp;</td> <td class="auto-style21" style="text-align: right;">Fone:</td> <td class="auto-style22">&nbsp;<asp:TextBox ID="telefone" runat="server" ClientIDMode="Static" Width="38%" CssClass="txtFone"></asp:TextBox> </td> <td class="auto-style23" style="text-align: right">Celular:</td> <td class="auto-style62">&nbsp;<asp:TextBox ID="celular" runat="server" ClientIDMode="Static" Width="45%" CssClass="txtCel"></asp:TextBox> </td> <td class="auto-style51">&nbsp;</td> </tr> <tr> <td class="auto-style43"></td> <td class="auto-style44" style="text-align: right;">Número (Local):</td> <td class="auto-style45">&nbsp;<asp:TextBox ID="txtNumLocal" runat="server" Width="15%" MaxLength="4" CssClass="txtNum" ClientIDMode="Static"></asp:TextBox> </td> <td class="auto-style46" style="text-align: right">CNPJ:</td> <td class="auto-style63">&nbsp;<asp:TextBox ID="cnpj" runat="server" ClientIDMode="Static" Width="50%" CssClass="txtCNPJ"></asp:TextBox> </td> <td class="auto-style48"></td> </tr> <tr> <td class="auto-style65"></td> <td class="auto-style66" style="text-align: right;">Digite o CEP:</td> <td class="auto-style67">&nbsp;<asp:TextBox ID="cep" runat="server" Width="32%" ClientIDMode="Static" CssClass="txtCEP"></asp:TextBox> &nbsp;<asp:Button ID="btnOK" runat="server" Height="33px" Text="OK" Width="20%" CssClass="btnOK" OnClick="btnOK_Click" /> </td> <td class="auto-style68" style="text-align: right">Complemento:</td> <td class="auto-style69">&nbsp;<asp:TextBox ID="txtCompl" runat="server" Width="20%" CssClass="txtCompl"></asp:TextBox> </td> </tr> <tr> <td class="auto-style4">&nbsp;</td> <td class="auto-style2" style="text-align: right;">&nbsp;</td> <td class="auto-style66" style="font-stretch: extra-condensed;"> <asp:Label ID="lblUf" runat="server"></asp:Label> &nbsp;&nbsp; <asp:Label ID="lblCidade" runat="server"></asp:Label> </td> <td class="auto-style13" style="text-align: right">&nbsp;</td> <td class="auto-style64">&nbsp;</td> <td class="auto-style52">&nbsp;</td> </tr> <tr> <td class="auto-style4">&nbsp;</td> <td class="auto-style2" style="text-align: right;">&nbsp;</td> <td class="auto-style66" style="font-stretch: extra-condensed;"> <asp:Label ID="lblBairro" runat="server"></asp:Label> &nbsp;&nbsp; <asp:Label ID="lblRua" runat="server"></asp:Label> </td> <td class="auto-style13" style="text-align: right">&nbsp;</td> <td class="auto-style64"> <asp:Label ID="lblErro" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="90%"></asp:Label> </td> <td class="auto-style52">&nbsp;</td> </tr> <tr> <td class="auto-style4">&nbsp;</td> <td class="auto-style2" style="text-align: right;">&nbsp;</td> <td class="auto-style6">&nbsp</td> <td class="auto-style13" style="text-align: right">&nbsp;</td> <td class="auto-style64">&nbsp;</td> <td class="auto-style52">&nbsp;</td> </tr> <tr> <td class="auto-style4">&nbsp;</td> <td class="auto-style2" style="text-align: right;">&nbsp;</td> <td class="auto-style6">&nbsp;</td> <td class="auto-style13" style="text-align: right">Imagem de Perfil:&nbsp;</td> <td class="auto-style64"> <asp:FileUpload ID="FileUpload1" runat="server" Width="95%" CssClass="imgUploader" /> </td> <td class="auto-style52">&nbsp;</td> </tr> </table> <table> <tr> <td class="auto-style5">&nbsp;</td> <td class="auto-style49" style="text-align: right;">&nbsp;</td> <td class="auto-style6" style="text-align: right;">&nbsp;</td> <td class="auto-style33" style="text-align: left; font-weight: bold; font-size: 16px;">INFORMAÇÕES DA CONTA</td> <td class="auto-style8">&nbsp;</td> <td class="auto-style1">&nbsp;</td> </tr> <tr> <td class="auto-style5">&nbsp;</td> <td class="auto-style49" style="text-align: right;"> <asp:SqlDataSource ID="sqlCadastrarEmp" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="INSERT INTO cliente_emp(nome_emp, cnpj_emp, cep_emp, numlocal_emp, compl_emp, email_emp, senha_emp, fone_emp, responsavel_emp, cel_emp, img_emp, ativo_emp) VALUES (@nome, @cnpj, @cep, @num, @compl, @email, @senha, @fone, @resp, @cel, @imgEmp,1)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT count(*) as qtdEmp FROM cliente_emp"> <InsertParameters> <asp:Parameter Name="nome" /> <asp:Parameter Name="email" /> <asp:Parameter Name="senha" /> <asp:Parameter Name="fone" /> <asp:Parameter Name="cep" /> <asp:Parameter Name="num" /> <asp:Parameter Name="compl" /> <asp:Parameter Name="cnpj" /> <asp:Parameter Name="cel" /> <asp:Parameter Name="imgEmp" /> <asp:Parameter Name="resp" /> </InsertParameters> </asp:SqlDataSource> </td> <td class="auto-style6" style="text-align: right;">Email:</td> <td class="auto-style32">&nbsp;<asp:TextBox ID="txtEmail" runat="server" MaxLength="40" CssClass="txtES"></asp:TextBox> </td> <td class="auto-style8"> <asp:Label ID="lblErroConta" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="90%" CssClass="lblErroConta"></asp:Label> </td> <td class="auto-style1">&nbsp;</td> </tr> <tr> <td class="auto-style5">&nbsp;</td> <td class="auto-style49" style="text-align: right;"> <asp:SqlDataSource ID="sqlVerEmailEmp" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT count(*) as qtdEmail FROM verloginemp where email=@email" InsertCommand="insert into aud_emp values(0,@id,@table,@desc,@hr,@data)"> <InsertParameters> <asp:Parameter Name="id" /> <asp:Parameter Name="table" /> <asp:Parameter Name="desc" /> <asp:Parameter Name="hr" /> <asp:Parameter Name="data" /> </InsertParameters> <SelectParameters> <asp:Parameter Name="email" /> </SelectParameters> </asp:SqlDataSource> </td> <td class="auto-style6" style="text-align: right;">Senha:<br /> </td> <td class="auto-style32">&nbsp;<asp:TextBox ID="txtSenha" runat="server" TextMode="Password" MaxLength="40" CssClass="txtES"></asp:TextBox> </td> <td class="auto-style8"> <asp:Label ID="lblSaved" runat="server" Text="SENHA SALVA!" Visible="false"></asp:Label> </td> <td class="auto-style1">&nbsp;</td> </tr> <tr> <td class="auto-style5">&nbsp;</td> <td class="auto-style49" style="text-align: right;"> <asp:SqlDataSource ID="sqlVerCnpj" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT COUNT(*) AS qtdCnpj FROM vercnpj WHERE (cnpj = @cnpj)"> <SelectParameters> <asp:ControlParameter ControlID="cnpj" Name="cnpj" PropertyName="Text" /> </SelectParameters> </asp:SqlDataSource> </td> <td class="auto-style6" style="text-align: right;">Confirmação da Senha: </td> <td class="auto-style32">&nbsp;<asp:TextBox ID="txtConfirSenha" runat="server" TextMode="Password" CssClass="txtES"></asp:TextBox> <asp:Button ID="btnVerifForca" runat="server" CssClass="btnForca" Height="34px" OnClick="btnVerifForca_Click" Text="Força" Width="27%" /> &nbsp;</td> <td class="auto-style8"> <asp:Button ID="btnCadastrar" runat="server" Height="34px" Text="Cadastrar" Width="70%" OnClick="btnCadastrar_Click" CssClass="btnCad" /> </td> <td class="auto-style1">&nbsp;</td> </tr> </table> </form> </asp:Content> 