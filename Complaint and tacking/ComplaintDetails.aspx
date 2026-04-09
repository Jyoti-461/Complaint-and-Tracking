<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComplaintDetails.aspx.cs" Inherits="Complaint_and_tacking.ComplaintDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title><link href="css/submit_complaint.css" rel="stylesheet" />
</head>
<body>
   <form id="form1" runat="server">
    <div class="form-card">

        <h3>Complaint Details</h3>

        <asp:Label ID="lblDetails" runat="server"></asp:Label>

        <div class="field-group">
            <label>Admin Reply</label>
            <asp:TextBox ID="txtReply" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
        </div>

        <div class="field-group">
            <label>Status</label>
            <asp:DropDownList ID="ddlStatus" runat="server">
                <asp:ListItem>Open</asp:ListItem>
                <asp:ListItem>In Progress</asp:ListItem>
                <asp:ListItem>Resolved</asp:ListItem>
            </asp:DropDownList>
        </div>

        <asp:Button ID="btnUpdate" runat="server"
            Text="Update Complaint"
            CssClass="btn-submit"
            OnClick="btnUpdate_Click" />

        <asp:Label ID="lblMsg" runat="server" CssClass="success"></asp:Label>

        <asp:HyperLink ID="hlBack" runat="server"
            NavigateUrl="AdminDashboard.aspx"
            CssClass="btn-secondary">
            Back to Dashboard
        </asp:HyperLink>

    </div>
</form>

</body>
</html>
