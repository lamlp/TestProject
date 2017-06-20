<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>


<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
                      <h1>Todo List</h1>
                  <div class="margin">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:BoundField DataField="title" HeaderText="Title" />
            <asp:BoundField DataField="description" HeaderText="Description" />
            <asp:BoundField DataField="created_at" HeaderText="Created At" />
             </Columns>
            </asp:GridView>
                                        </div>
</asp:Content>
