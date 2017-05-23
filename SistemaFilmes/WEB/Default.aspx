<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Names="Century Gothic" Font-Size="20pt" Text="Novidades"></asp:Label>
<br />
<br />
<br />
&nbsp;<asp:GridView ID="gvItens" runat="server" AutoGenerateColumns="False" Height="112px" Width="340px">
        <Columns>
            <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
            <asp:TemplateField HeaderText="Imagem"> 
                <ItemTemplate>
                    <asp:Image ID ="Image1" runat="server" Height="100px" Width="100px" 
                        ImageUrl='<%#"Data:Image/png;base64," +Convert.ToBase64String((byte[])Eval("Imagem")) %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
<br />
</asp:Content>
