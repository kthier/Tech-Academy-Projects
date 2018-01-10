<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge__9___Postage_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong><span class="auto-style1">Postage Calculator<br />
        </span></strong>
        <br />
        <br />
        Width:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        <br />
        Height:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        <br />
        Length:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" Checked="True" GroupName="shipping" OnCheckedChanged="handleChange" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="handleChange" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="handleChange" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
