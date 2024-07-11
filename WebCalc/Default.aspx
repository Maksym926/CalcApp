<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td style="width: 40px">
                    <asp:Label ID="Label1" runat="server" Text="1 число:"></asp:Label>
                    </td>
                <td style="width: 94px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="81px" ></asp:TextBox></td>
                <%--<td style="width: 308px">--%>
                    <%--<asp:Label ID="Label3" runat="server" Text="Новое значение :"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>--%>
            </tr>
            <tr>
                <td style="width: 40px; height: 26px;">
                    <asp:Label ID="Label2" runat="server" Text="2 число:"></asp:Label>
                    </td>
                <td style="width: 94px; height: 26px;">
                    <asp:TextBox ID="TextBox2" runat="server" Width="81px" ></asp:TextBox></td>
                <td style="width: 40px; height: 26px;">
                    <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
                    </td>
                <td style="width: 94px; height: 26px;">
                    <asp:TextBox ID="TextBox3" runat="server" Width="81px" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 308px; height: 26px;">
                    <%--<asp:Button ID="Button1" runat="server" Text="В Цельсиях" Width="135px" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="В Фаренгейтах" Width="135px" OnClick="Button2_Click" /></td>--%>
                    <asp:Button ID="Button1" runat="server" Text="Додати" Width="135px" OnClick ="Button1_Click"/><%--OnClick ="Button1_Click"--%>
                    <asp:Button ID="Button2" runat="server" Text="Відняти" Width="135px" OnClick ="Button2_Click"/>
                    <asp:Button ID="Button3" runat="server" Text="Помножити" Width="135px" OnClick ="Button3_Click"/>
                    <asp:Button ID="Button4" runat="server" Text="Поділити" Width="135px" OnClick ="Button4_Click"/>
                    <%--<asp:Button ID="Button2" runat="server" Text="В Фаренгейтах" Width="135px"/>--%>
                </td>
            </tr>
            
        </table>
    
    </div>
    </form>
</body>
</html>
