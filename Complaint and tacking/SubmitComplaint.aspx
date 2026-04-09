<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitComplaint.aspx.cs" Inherits="Complaint_and_tacking.SubmitComplaint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/submit_complaint.css" rel="stylesheet" />

    <title>Submit Complaint</title>
</head>
<body>
   <form id="form1" runat="server">
    <div class="form-card">

        <h3>Student Complaint Form</h3>

        <div class="field-group">
            <label>Student Name</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>

        <div class="field-group">
            <label>Email</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>

        <div class="field-group">
            <label>Mobile</label>
            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
        </div>

        <div class="field-group">
            <label>Category</label>
            <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
        </div>

        <div class="field-group">
            <label>Subject</label>
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
        </div>

        <div class="field-group">
            <label>Description</label>
            <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
        </div>

        <div class="field-group">
            <label>Upload Proof</label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>

        <asp:Button ID="btnSubmit" runat="server"
            Text="Submit Complaint"
            CssClass="btn-submit"
            OnClick="btnSubmit_Click" />

        <asp:Label ID="lblMsg" runat="server" CssClass="success"></asp:Label>

        <asp:HyperLink ID="hlTrack" runat="server"
            NavigateUrl="TrackComplaint.aspx"
            CssClass="track-link">
            Track Your Complaint
        </asp:HyperLink>

    </div>
</form>


</body>
</html>
