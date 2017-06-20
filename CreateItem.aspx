<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateItem.aspx.cs" Inherits="CreateItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
                          <h1>Create Item</h1>
                  <div class="margin">
            <p><asp:Label ID="Label1" runat="server" Text="Title"></asp:Label></p>
            <p><asp:TextBox runat="server" ID="txtTitle"></asp:TextBox></p>
            <p><asp:Label ID="Label2" runat="server" Text="Description"></asp:Label></p>
            <p><asp:TextBox runat="server" ID="txtDescription"></asp:TextBox></p>
            <p><asp:Label ID="Label3" runat="server" Text="Category"></asp:Label></p>
            <p><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></p>
            <asp:Button runat="server" ID="btnCreate" Text="Create" OnClick="btnCreate_Click" />
                      </div>
</asp:Content>

