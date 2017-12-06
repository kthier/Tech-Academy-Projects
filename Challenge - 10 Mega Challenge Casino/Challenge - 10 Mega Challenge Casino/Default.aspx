<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge___10_Mega_Challenge_Casino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
        .auto-style2 {
            color: #FFFFFF;
            background-color: #000000;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br />
        <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Your Bet:&nbsp;
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="pullButton" runat="server" OnClick="pullButton_Click" Text="Pull the Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1&nbsp; <asp:Image ID="Image4" runat="server" Height="25px" ImageUrl="~/Images/Cherry.png" />
&nbsp;- x2 Your Bet<br />
        2&nbsp; <asp:Image ID="Image5" runat="server" Height="25px" ImageUrl="~/Images/Cherry.png" />
&nbsp;- x3 Your Bet<br />
        3&nbsp;
        <asp:Image ID="Image6" runat="server" Height="25px" ImageUrl="~/Images/Cherry.png" />
&nbsp;- x4 Your Bet<br />
        <br />
        3
        <asp:Image ID="Image7" runat="server" Height="20px" ImageUrl="~/Images/Seven.png" />
        - Jackpot - x100 Your Bet<br />
        <br />
        However... 
        if there is one 
        <span class="auto-style2">BAR</span> you win nothing.&nbsp; <br />
        <br />
        <br />
        </div>
    </form>
</body>
</html>
