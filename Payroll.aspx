<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payroll.aspx.cs" Inherits="Project1_ASP.Payroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Payroll Form"></asp:Label>
        </div>
        <div>

            <asp:Label ID="Label2" runat="server" Text="Gross Salary (yearly): "></asp:Label>
            <asp:TextBox ID="grossSalary" runat="server"></asp:TextBox>
            <br />
            
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Female" 
                CausesValidation="True"/>
            <asp:RadioButton ID="RadioButton2" runat="server" Text ="Male" 
                AutoPostBack="True"/>
            
            <br /><br />
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Number of Dependants"></asp:Label>
            <asp:DropDownList ID="ddlDependants" runat="server" AutoPostBack="True">
                <asp:ListItem Value="366">1</asp:ListItem>
                <asp:ListItem Value="419">2</asp:ListItem>
                <asp:ListItem Value="479">3</asp:ListItem>
                <asp:ListItem Value="537">4</asp:ListItem>
            </asp:DropDownList>

        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Canada Pension Plan (CPP)"></asp:Label>
            <asp:CheckBox ID="cbxCPP" runat="server" AutoPostBack="True" />
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Employment Insurance (EI)"></asp:Label>
            <asp:CheckBox ID="cbxEI" runat="server" AutoPostBack="True" />

            <div>
                <asp:CheckBox ID="cbxBonus" runat="server" Text="Bonus?" />
                <asp:CheckBox ID="cbxAllowance" runat="server" Text="Allowance" />
            </div>

        </div>
        <div>
            <asp:Button ID="Calculate" runat="server" Text="Calculate" OnClick="Calculate_Click" />
        </div>

        <div>
            <asp:Label ID="Label8" runat="server" Text="Net Pay"></asp:Label> 
            <asp:Label ID="NetPay" runat="server" Text=""></asp:Label>
        </div>

    </form>
</body>
</html>
