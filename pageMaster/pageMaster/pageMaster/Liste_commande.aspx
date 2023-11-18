<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Liste_commande.aspx.cs" Inherits="pageMaster.Liste_commande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="codeC" DataSourceID="SqlDataSource1" EnableModelValidation="True" 
        Height="231px" Width="361px" ShowFooter="True" AllowPaging="True" 
        onselectedindexchanged="GridView1_SelectedIndexChanged1">
        <Columns>
            <asp:TemplateField HeaderText="codeC" SortExpression="codeC">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("codeC") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("codeC") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>

                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="dateC" SortExpression="dateC">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("dateC") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("dateC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="client" SortExpression="client">
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="SqlDataSource2" DataTextField="codeCl" DataValueField="codeCl" Text='<%# Bind("client") %>'>
    </asp:DropDownList>
                
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("client") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                        CommandName="Delete" Text="Supprimer" OnClientClick=" return confirm('voulez vous supprimer?')"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                        CommandName="Update" Text="Mettre à jour"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                        CommandName="Cancel" Text="Annuler"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                        CommandName="Edit" Text="Modifier"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" 
                        CommandName="Select" Text="Sélectionner" ></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#66CCFF" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:gestion_commerceConnectionString %>" 
        DeleteCommand="DELETE FROM [commande] WHERE [codeC] = @original_codeC" 
        InsertCommand="INSERT INTO [commande] ([codeC], [dateC], [client]) VALUES (@codeC, @dateC, @client)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT * FROM [commande] WHERE ([client] = @client)" 
        UpdateCommand="UPDATE [commande] SET [dateC] = @dateC, [client] = @client WHERE [codeC] = @original_codeC">
        <DeleteParameters>
            <asp:Parameter Name="original_codeC" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codeC" Type="Int32" />
            <asp:Parameter Name="dateC" Type="String" />
            <asp:Parameter Name="client" Type="Int32" />
        </InsertParameters>
        <SelectParameters>
            <asp:SessionParameter DefaultValue="1" Name="client" SessionField="code" 
                Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="dateC" Type="String" />
            <asp:Parameter Name="client" Type="Int32" />
            <asp:Parameter Name="original_codeC" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    
    
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:gestion_commerceConnectionString %>" 
        SelectCommand="SELECT [codeCl] FROM [client]"></asp:SqlDataSource>
    
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource3" EnableModelValidation="True" Width="297px">
        <Columns>
            <asp:BoundField DataField="description" HeaderText="description" 
                SortExpression="description" />
            <asp:BoundField DataField="prix" HeaderText="prix" SortExpression="prix" />
            <asp:BoundField DataField="qtte" HeaderText="qtte" SortExpression="qtte" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        
        ConnectionString="<%$ ConnectionStrings:gestion_commerceConnectionString %>" SelectCommand="select description, prix, qtte 
from detail_commande dc,produit p
 where dc.codep = p.codep and codeC = @codeC" 
        onselecting="SqlDataSource3_Selecting">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="codeC" 
                PropertyName="SelectedValue" />
        </SelectParameters>
    </asp:SqlDataSource>
    
    </asp:Content>
