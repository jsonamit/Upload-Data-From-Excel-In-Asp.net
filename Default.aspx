<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
         <div class="form-group">
        <label for="exampleInputEmail1">Select Excel File </label>
        <asp:FileUpload ID="excelUpload" CssClass="form-control" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnUploadExcel" runat="server" Text="Upload Excel" CssClass="btn btn-success" OnClick="btnUploadExcel_Click" />
    </div>
    </div>   
      <div class="row">
         <div class="form-group">
        <label for="exampleInputEmail1">Select City Excel File </label>
        <asp:FileUpload ID="FileUploadCity" CssClass="form-control" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnUploadCity" runat="server" Text="Upload City Excel" CssClass="btn btn-success" OnClick="btnUploadCity_Click" />
    </div>
    </div>   
</asp:Content>

