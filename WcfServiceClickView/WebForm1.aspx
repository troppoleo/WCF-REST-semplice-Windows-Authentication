<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WcfServiceClickView.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" method="post" action="VlkCheck.svc/CallPost">
    <div>
        <label for="firstName">
            First Name</label>:
        <input type="text" name="firstName" value="" />
        <br />
        <br />
        <label for="lastName">
            Last Name</label>:
        <input type="text" name="lastName" value="" />
        <p>
            <input type="submit" /></p>
    </div>
    </form>
</body>
</html>
