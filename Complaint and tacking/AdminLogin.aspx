<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Complaint_and_tacking.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/submit_complaint.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="form-card">

        <h3>Admin Login</h3>

        <div class="field-group">
            <label>Username</label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        </div>

        <div class="field-group">
            <label>Password</label>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <asp:Button ID="btnLogin" runat="server"
            Text="Login"
            CssClass="btn-submit"
            OnClick="btnLogin_Click" />

        <asp:Label ID="lblMsg" runat="server" CssClass="error"></asp:Label>

    </div>
</form>

</body>
</html>
