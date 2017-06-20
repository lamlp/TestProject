<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateList.aspx.cs" Inherits="CreateList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
                          <h1>Create Item</h1>
                  <div class="margin">
            <p><asp:Label ID="Label1" runat="server" Text="Category Name"></asp:Label></p>
            <p><asp:TextBox runat="server" ID="txtCategoryName"></asp:TextBox></p>
                      <asp:Button runat="server" ID="btnCreate" Text="Create" OnClick="btnCreate_Click" />
                      </div>
</asp:Content>
