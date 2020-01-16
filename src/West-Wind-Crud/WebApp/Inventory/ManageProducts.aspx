<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="WebApp.Inventory.ManageProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h1 class="page-header">Manage Products</h1>
        </div>
        <div class="col-md-12">
            <asp:GridView ID="ProductInventoryGridView" runat="server" 
                DataSourceID="ProductInventoryDataSource" 
                AutoGenerateColumns="False"
                CssClass="table table-hover table-condensed"
                >
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ID" SortExpression="ProductID"></asp:BoundField>
                    <asp:BoundField DataField="ProductName" HeaderText="Name" SortExpression="ProductName"></asp:BoundField>
                    <asp:BoundField DataField="SupplierID" HeaderText="Supplier" SortExpression="SupplierID"></asp:BoundField>
                    <asp:BoundField DataField="CategoryID" HeaderText="Category" SortExpression="CategoryID"></asp:BoundField>
                    <asp:BoundField DataField="QuantityPerUnit" HeaderText="Qty/UNit" SortExpression="QuantityPerUnit"></asp:BoundField>
                    <asp:BoundField DataField="MinimumOrderQuantity" HeaderText="Min Order" SortExpression="MinimumOrderQuantity"></asp:BoundField>
                    <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" SortExpression="UnitPrice" DataFormatString="{0:C}"></asp:BoundField>
                    <asp:BoundField DataField="UnitsOnOrder" HeaderText="QtyOnOrder" SortExpression="UnitsOnOrder"></asp:BoundField>
                    <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued"></asp:CheckBoxField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ProductInventoryDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllProducts" TypeName="WestWindSystem.BLL.InventoryController"></asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>
