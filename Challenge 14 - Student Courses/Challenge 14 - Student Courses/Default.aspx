<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_14___Student_Courses.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="assignmentButton1" runat="server" OnClick="assignmentButton1_Click" Text="Assignment 1" />
        <br />
        <br />
        <asp:Button ID="assignmentButton2" runat="server" OnClick="assignmentButton2_Click" Text="Assignment 2" />
        <br />
        <br />
        <asp:Button ID="assignmentButton3" runat="server" OnClick="assignmentButton3_Click" Text="Assignment 3" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
