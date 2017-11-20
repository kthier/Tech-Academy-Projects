<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_7___Epic_Spies_Asset_Tracker.Default" MaintainScrollPositionOnPostback = "true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 180px;
            height: 223px;
        }
        .auto-style2 {
            font-size: xx-large;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <img alt="Epic Spy Logo" class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <strong><span class="auto-style2">&nbsp; Asset Performance Tracker</span></strong><br />
        <br />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp; Asset Name:&nbsp; </span>
        <asp:TextBox ID="assetNameTextBox" runat="server" CssClass="auto-style3"></asp:TextBox>
        <br class="auto-style3" />
        <br class="auto-style3" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp; Elections Rigged:&nbsp; </span>
        <asp:TextBox ID="electionsRiggedTextBox" runat="server" CssClass="auto-style3"></asp:TextBox>
        <br class="auto-style3" />
        <br class="auto-style3" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp; Acts of Subterfuge Performed:&nbsp; </span>
        <asp:TextBox ID="actsOfSubterfugeTextBox" runat="server" CssClass="auto-style3"></asp:TextBox>
        <br class="auto-style3" />
        <br class="auto-style3" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="addAssetButton" runat="server" CssClass="auto-style3" OnClick="addAssetButton_Click" Text="Add Asset" />
        <br class="auto-style3" />
        <br class="auto-style3" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="resultLabel" runat="server" CssClass="auto-style3"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
