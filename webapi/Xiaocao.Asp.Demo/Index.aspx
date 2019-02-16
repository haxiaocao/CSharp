<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Xiaocao.Asp.Demo.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is my first design web form to be here and format this design to be useful.</div>
        <p>
            <asp:LinkButton ID="linkBaidu" runat="server" OnClick="linkBaidu_Click" ToolTip="haha，baidu yixia ">百度一下</asp:LinkButton>
        </p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="姓名和内容："></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="margin-bottom: 0px" Width="265px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 32px" Width="264px"></asp:TextBox>
        </p>
        <p>

            nihao，最新的一页</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtPosition" runat="server" style="margin-left: 56px" Width="264px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 33px" Width="268px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="开始" Width="74px" />
            <asp:Button ID="btnEnd" runat="server" OnClick="btnEnd_Click" style="margin-left: 87px" Text="结束" Width="92px" />
        </p>
        <asp:GridView ID="GridDemo" runat="server" Height="168px" Width="557px">
        </asp:GridView>
    </form>
</body>
</html>
