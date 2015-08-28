<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarPooling_RegisterVehicle.aspx.cs" Inherits="VDSI_EmpCarPooling.VDSI_EmpCarPooling_UI.CarPooling_RegisterVehicle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../style/StyleSheet1.css" rel="stylesheet" />    
</head>
<body>
    <form id="form1" runat="server">        
            <table>
                <tr>
                    <td>
                        <asp:Label Text="Name" ID="lblName" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Emp Id" ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpId" Enabled="false" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Car Detail" ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCar" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text="In Time" ID="Label7" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtInTime" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label Text="Out Time" ID="Label8" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtOutTime" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="From" ID="Label3" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="To" ID="Label4" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Via" ID="Label5" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtVia" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Email" ID="Label6" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"></asp:Button>
                    </td>
                </tr>
            </table>
            
    </form>
</body>
</html>
