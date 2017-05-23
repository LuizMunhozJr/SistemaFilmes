<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RelatorioItens.aspx.cs" Inherits="WEB.RelatorioItens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Names="Century Gothic" Font-Overline="False" Font-Size="30pt" Text="Filmes e Séries"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
    Nome:<asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Atores:<asp:TextBox ID="txtAtor" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gênero:<asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
</p>
    <p>
        &nbsp;</p>
<p>
</p>
<p>
    <asp:GridView ID="gvItens" runat="server" AutoGenerateColumns="False" Height="224px" Width="1041px">
        <Columns>
            <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
            <asp:BoundField DataField="Ano" HeaderText="Ano de Lançamento" />
            <asp:TemplateField HeaderText="Imagem"> 
                <ItemTemplate>
                    <asp:Image ID ="Image1" runat="server" Height="100px" Width="100px" 
                        ImageUrl='<%#"Data:Image/png;base64," +Convert.ToBase64String((byte[])Eval("Imagem")) %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
