<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Complaint_and_tacking.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/submit_complaint.css" rel="stylesheet" />
</head>
<body>
   <form id="form1" runat="server">
               <div style="text-align:right; margin-bottom:15px;">
    <asp:Button ID="btnLogout" runat="server"
        Text="Logout"
        CssClass="btn-logout"
        OnClick="btnLogout_Click" />
</div>
    <div class="table-card">

        <h3>Admin Dashboard - Complaints</h3>
       

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderWidth="0">
            <Columns>
                <asp:BoundField DataField="ComplaintId" HeaderText="ID" />
                <asp:BoundField DataField="StudentName" HeaderText="Student" />
                <asp:BoundField DataField="Subject" HeaderText="Subject" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:HyperLinkField 
                    Text="View"
                    DataNavigateUrlFields="ComplaintId"
                    DataNavigateUrlFormatString="ComplaintDetails.aspx?id={0}" />
            </Columns>
        </asp:GridView>

    </div>
</form>

</body>
</html>
