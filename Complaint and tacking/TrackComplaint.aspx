<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrackComplaint.aspx.cs" Inherits="Complaint_and_tacking.TrackComplaint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/submit_complaint.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="form-card">

        <h3>Track Complaint</h3>

        <div class="field-group">
            <label>Enter Email or Mobile</label>
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="btnSearch" runat="server"
            Text="Search"
            CssClass="btn-submit"
            OnClick="btnSearch_Click" />

       <div class="table-spacing">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderWidth="0" OnRowDataBound="GridView1_RowDataBound">

    <Columns>
        <asp:BoundField DataField="ComplaintId" HeaderText="ID" />
        <asp:BoundField DataField="Subject" HeaderText="Subject" />
        <asp:BoundField DataField="Status" HeaderText="Status" />
        <asp:BoundField DataField="AdminReply" HeaderText="Admin Reply" />
    </Columns>
</asp:GridView>
</div>

        <asp:HyperLink ID="hlBack" runat="server"
            NavigateUrl="SubmitComplaint.aspx"
            CssClass="btn-secondary">
            Back to Complaint Form
        </asp:HyperLink>

    </div>
</form>

</body>
</html>
