<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalhesItem.aspx.cs" Inherits="WEB.DetalhesItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label1" runat="server" Font-Names="Century Gothic" Font-Size="20pt" Text="Detalhes de Item"></asp:Label>
&nbsp;</p>
<p>
    codigo
    <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" style="height: 26px" />
</p>
<p>
    &nbsp;</p>
<p>
    Filme<asp:GridView ID="gvItem" runat="server" Width="1041px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
            <asp:BoundField DataField="Ano" HeaderText="Ano de Lançamento" />
            <asp:TemplateField> 
                <ItemTemplate>
                    <asp:Image ID ="Image1" runat="server" Height="100px" Width="100px" 
                        ImageUrl='<%#"Data:Image/png;base64," +Convert.ToBase64String((byte[])Eval("Imagem")) %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
    <p>
        <asp:GridView ID="gvGeneros" runat="server" Width="179px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Nome" HeaderText="Generos" />
        </Columns>
    </asp:GridView>
    </p>
<p>
    &nbsp;</p>
<p>
    Participações<asp:GridView ID="gvParticipacoes" runat="server" Width="1030px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="nmArt" HeaderText="Atores" />
            <asp:BoundField DataField="cdPersonagem" HeaderText="Personagens" />
            <asp:TemplateField> 
                <ItemTemplate>
                    <asp:Image ID ="Image1" runat="server" Height="100px" Width="100px" 
                        ImageUrl='<%#"Data:Image/png;base64," +Convert.ToBase64String((byte[])Eval("ImagemArt")) %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
</asp:Content>
