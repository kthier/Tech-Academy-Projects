<%@ Page Language="C#" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge___Epic_Spies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
    
    </div>
        <p class="auto-style1">
            <strong>Spy Assignment Form</strong></p>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <table border="0" class="auto-style2" draggable="auto">
            <tr>
                <td class="auto-style4">End Date of Previous Assignment:<asp:Calendar ID="previousAssignmentCalendar" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style4">Start Date of New Assignment:<asp:Calendar ID="startDateCalendar" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style4">Projected End Date of New Assignment:<asp:Calendar ID="endDateCalendar" runat="server"></asp:Calendar>
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="AssignSpybutton" runat="server" OnClick="AssignSpybutton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
