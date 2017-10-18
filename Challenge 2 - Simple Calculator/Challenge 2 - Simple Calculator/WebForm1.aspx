<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Challenge_2___Simple_Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="arial: ; font-size: xx-large; font-style: normal; font-weight: bold; font-family: Arial;">
    
        Simple Calculator</div>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            First Value:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="firstvalueTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Second Value:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="secondvalueTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="additionButton" runat="server" Text=" + " OnClick="additionButton_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="subtractionButton" runat="server" Text=" - " OnClick="subtractionButton_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multiplicationButton" runat="server" Text=" * " OnClick="multiplicationButton_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="divisionButton" runat="server" Text=" / " OnClick="divisionButton_Click" />
            <br />
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            <asp:Label ID="resultLabel" runat="server" BackColor="#99FFCC" BorderColor="#009999" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            &nbsp;</p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            &nbsp;</p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-weight: bold; font-style: normal">
            Tip Calculator</p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            Bill:&nbsp; $<asp:TextBox ID="billTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            Tip %:
            <asp:TextBox ID="differentpercentageTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            <asp:Button ID="calculateButton" runat="server" OnClick="calculateButton_Click" Text="Calculate Tip" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="calculateLabel" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal">
            <asp:Button ID="totalButton" runat="server" OnClick="totalButton_Click" Text="Total" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="totalLabel" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </p>
    </form>
</body>
</html>
