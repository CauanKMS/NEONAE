﻿<%@ Page Title="" Language="C#" MasterPageFile="~/mpUsuario.master" AutoEventWireup="true" CodeFile="usuarioFPgto.aspx.cs" Inherits="usuarioFPgto" %> <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> <style> .auto4{width:16%;}.auto128{}.auto128_4{height:36px;}.auto128_8{padding-top:40px;}.auto256{width:10%;}.auto512{width:60%;}.auto1024{width:40%;} .btnFPgto { height:32px; max-width:320px; min-width:100px; display: -webkit-box;-webkit-line-clamp: 1;-webkit-box-orient: vertical;overflow: hidden;text-overflow: ellipsis;border-style: none;border-color: inherit;border-width: medium;font-size: 16px;background-color: #00ffff;color: white;padding: 6px;cursor: pointer;border-radius: 4px;transition: 0.3s;} .btnFPgto:hover {background-color: #58d7ee;transition: 0.3s;} .ddlTipoCard{min-width:50px;max-width:120px;}.txtNumCard{min-width:80px;max-width:150px;}.txtTitular{max-width:280px;min-width:80px;text-transform:uppercase;}.txtCVV{max-width:50px;min-width:28px;} </style> </asp:Content> <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> <form id="form1" runat="server"> <table style="width: 100%;"> <tr> <td style="text-align: center; font-size: 20px; font-weight: bold;" class="auto4">FORMA DE PAGAMENTO<div class="line-title bg-primary"></div></td> <td> <asp:SqlDataSource ID="sqlFPgto" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" InsertCommand="insert into fpgto values(0,@id,@cartao,@num,@data,@titular,@cvv,1)" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM fpgto where id_usu=@id" UpdateCommand="UPDATE fpgto SET ativo_pgto = 1, cartao_pgto =@cartao, numcartao_pgto =@num, dataexp_pgto =@data, titular_pgto =@titular, cvv_pgto =@cvv WHERE (id_usu = @id)"> <InsertParameters> <asp:SessionParameter Name="id" SessionField="getIdUsu" /> <asp:Parameter Name="cartao" /> <asp:Parameter Name="num" /> <asp:Parameter Name="data" /> <asp:Parameter Name="titular" /> <asp:Parameter Name="cvv" /> </InsertParameters> <SelectParameters> <asp:SessionParameter Name="id" SessionField="getIdUsu" /> </SelectParameters> <UpdateParameters> <asp:SessionParameter Name="id" SessionField="getIdUsu" /> <asp:Parameter Name="cartao" /> <asp:Parameter Name="num" /> <asp:Parameter Name="data" /> <asp:Parameter Name="titular" /> <asp:Parameter Name="cvv" /> </UpdateParameters> </asp:SqlDataSource> </td> <td> <asp:SqlDataSource ID="sqlAudUsu" runat="server" ConnectionString="<%$ ConnectionStrings:neonaeConnectionString %>" ProviderName="<%$ ConnectionStrings:neonaeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM aud_usu" InsertCommand="insert into aud_usu values(0,@id,@table,@desc,@hr,@data)"> <InsertParameters> <asp:Parameter Name="id" /> <asp:Parameter Name="table" /> <asp:Parameter Name="desc" /> <asp:Parameter Name="hr" /> <asp:Parameter Name="data" /> </InsertParameters> </asp:SqlDataSource> </td> </tr> <tr> <td class="auto128" style="padding-top: 15px;padding-left:16px"> <asp:RadioButtonList ID="rblFPgto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblFPgto_SelectedIndexChanged"> <asp:ListItem>Cartão de Crédito/Débito</asp:ListItem> </asp:RadioButtonList> </td> <td class="auto256"> &nbsp;</td> <td class="auto512"></td> <td class="auto1024">&nbsp;</td> </tr> <tr> <td class="auto128_4" style="padding-left:16px;"><asp:DropDownList ID="ddlTipoCard" runat="server" Width="100%" Visible="False" CssClass="ddlTipoCard"> <asp:ListItem>Viza</asp:ListItem> <asp:ListItem>MasterCharge</asp:ListItem> </asp:DropDownList></td> <td class="auto256"> <asp:Label ID="lblNumCard" runat="server" Text="Número:" Visible="False"></asp:Label> </td> <td class="auto512"> <asp:TextBox ID="txtNumCard" runat="server" Width="100%" MaxLength="16" Visible="False" CssClass="txtNumCard" ClientIDMode="Static"></asp:TextBox> </td> <td class="auto1024"> &nbsp;</td> </tr> <tr> <td class="auto128_4">&nbsp;</td> <td class="auto256"><asp:Label ID="lblDataExp" runat="server" Text="Data de Expiração:" Visible="False"></asp:Label> </td> <td class="auto512"> <asp:Label ID="lblMesExp" runat="server" Text="Mês:" Visible="False"></asp:Label> <asp:DropDownList ID="ddlMesExp" runat="server" Width="50px" Height="30px" Visible="False"> <asp:ListItem>MM</asp:ListItem> <asp:ListItem>1</asp:ListItem> <asp:ListItem>2</asp:ListItem> <asp:ListItem>3</asp:ListItem> <asp:ListItem>4</asp:ListItem> <asp:ListItem>5</asp:ListItem> <asp:ListItem>6</asp:ListItem> <asp:ListItem>7</asp:ListItem> <asp:ListItem>8</asp:ListItem> <asp:ListItem>9</asp:ListItem> <asp:ListItem>10</asp:ListItem> <asp:ListItem>11</asp:ListItem> <asp:ListItem>12</asp:ListItem> </asp:DropDownList>&nbsp; <asp:Label ID="lblAnoExp" runat="server" Text="Ano:" Visible="False"></asp:Label> <asp:DropDownList ID="ddlAnoExp" runat="server" Width="64px" Height="30px" Visible="False"> <asp:ListItem>AAAA</asp:ListItem> <asp:ListItem>2016</asp:ListItem> <asp:ListItem>2017</asp:ListItem> <asp:ListItem>2018</asp:ListItem> <asp:ListItem>2019</asp:ListItem> <asp:ListItem>2020</asp:ListItem> <asp:ListItem>2021</asp:ListItem> <asp:ListItem>2022</asp:ListItem> <asp:ListItem>2023</asp:ListItem> <asp:ListItem>2024</asp:ListItem> <asp:ListItem>2025</asp:ListItem> <asp:ListItem>2026</asp:ListItem> <asp:ListItem>2027</asp:ListItem> <asp:ListItem>2028</asp:ListItem> <asp:ListItem>2029</asp:ListItem> <asp:ListItem>2030</asp:ListItem> <asp:ListItem>2031</asp:ListItem> <asp:ListItem>2032</asp:ListItem> <asp:ListItem>2033</asp:ListItem> <asp:ListItem>2034</asp:ListItem> <asp:ListItem>2035</asp:ListItem> </asp:DropDownList> </td> <td class="auto1024"> &nbsp; &nbsp; &nbsp; </td> </tr> <tr> <td class="auto128_4">&nbsp;</td> <td class="auto256"><asp:Label ID="lblTitular" runat="server" Text="Nome do Titular:" Visible="False"></asp:Label> </td> <td class="auto512"> <asp:TextBox ID="txtTitular" runat="server" Width="100%" Visible="False" CssClass="txtTitular"></asp:TextBox> </td> <td class="auto1024"> &nbsp;</td> </tr> <tr> <td class="auto128_4">&nbsp;</td> <td class="auto256"><asp:Label ID="lblCVV" runat="server" Text="CVV:" Visible="False"></asp:Label> </td> <td class="auto512"> <asp:TextBox ID="txtCVV" runat="server" Width="100%" MaxLength="3" Visible="False" CssClass="txtCVV" ClientIDMode="Static"></asp:TextBox> <asp:Label ID="lblHelpCVV" runat="server" Text="<i>Últimos 3 números no verso.</i>" Visible="False"></asp:Label> </td> <td class="auto1024"> &nbsp;</td> </tr> <tr> <td class="auto128_8">&nbsp;</td> <td class="auto256">&nbsp;</td> <td class="auto512" style="padding-left:10%;"> <asp:Button ID="btnFPgto" runat="server" Text="ADICIONAR FORMA DE PAGAMENTO" CssClass="btnFPgto" Width="100%" Visible="False" OnClick="btnFPgto_Click"/> </td> <td class="auto1024">&nbsp;</td> </tr> </table> </form> </asp:Content> 