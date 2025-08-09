<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEB_OBG_COUSER_AV.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulário</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Formulário</h1>
            
            <asp:TextBox ID="name" Text="insira seu nome" runat="server"></asp:TextBox>

            <br/>

            <asp:DropDownList ID="ddlCidades" runat="server">
                <asp:ListItem Text="Selecione uma cidade" Value=""></asp:ListItem>
                <asp:ListItem Text="São Paulo" Value="São paulo"></asp:ListItem>
                <asp:ListItem Text="Rio de Janeiro" Value="Rio de janeiro"></asp:ListItem>
                <asp:ListItem Text="Belo Horizonte" Value="Minas"></asp:ListItem>
            </asp:DropDownList>
            
            <br />
            
            <asp:Label ID="labelEnviadoCidade" Text="" runat="server"></asp:Label>
            
            <br />
            
            <asp:Label ID="labelEnviadoName" Text="" runat="server"></asp:Label>

            <asp:Button ID="btnEnvio" Text="Enviar" runat="server" OnClick="btnEnvio_Click" />
            
            <asp:GridView ID="gridProduto" runat="server" AutoGenerateColumns="false">

                <Columns>
                        
                    <asp:BoundField DataField="Id" HeaderText="id" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome do Produto" />
                    <asp:BoundField DataField="Preco" DataFormatString="{0:C}" />
                </Columns>

            </asp:GridView>
        
        </div>
    </form>
</body>
</html>
