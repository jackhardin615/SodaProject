<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SodaProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
            <h1>Soda Machine App</h1></div>
        <div class="text-center">
        <asp:Button ID="insertCoinBtn" class="btn-default btn-primary btn-round" runat="server" Text="Insert Quarter" Font-Size="X-Large" Height="43px" Width="179px" OnClick="insertCoinBtn_Click" />
        <asp:Button ID="refundBtn" class="btn-default btn-success btn-round" runat="server" Text="Refund Quarter" Font-Size="X-Large" Height="43px" Width="186px" Visible="False" OnClick="refundBtn_Click" />
           <br />
            <asp:Label ID="totallbl" runat="server" Text="Total: " Font-Size="X-Large"></asp:Label>
            <asp:Label ID="totalAmountlbl" runat="server" Text="$0.00" Font-Size="X-Large"></asp:Label>
           <br />

            <div class="table-responsive">
            <asp:Table ID="sodaTable" CssClass="table table-bordered" runat="server">
                <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                    <asp:TableCell runat="server">
                        <asp:Button ID="cokeBtn" runat="server" Text="Select" OnClick="cokeBtn_Click"/>
</asp:TableCell>
                    <asp:TableCell runat="server">Coca-Cola</asp:TableCell>
                    <asp:TableCell runat="server">Available: <asp:Label ID="cokeAmountlbl" runat="server" Text=""></asp:Label>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                    <asp:TableCell runat="server">
                        <asp:Button ID="dietCokeBtn" runat="server" Text="Select" OnClick="dietcokeBtn_Click" />
</asp:TableCell>
                    <asp:TableCell runat="server">Diet Coca-Cola</asp:TableCell>
                    <asp:TableCell runat="server">Available: <asp:Label ID="dietcokeAmountlbl" runat="server" Text=""></asp:Label>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                    <asp:TableCell runat="server">
                        <asp:Button ID="spriteBtn" runat="server" Text="Select" OnClick="spriteBtn_Click" />
</asp:TableCell>
                    <asp:TableCell runat="server">Sprite</asp:TableCell>
                    <asp:TableCell runat="server">Available: <asp:Label ID="spriteAmountlbl" runat="server" Text=""></asp:Label>
</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
                    <asp:TableCell runat="server">
                        <asp:Button ID="drpepperBtn" runat="server" Text="Select" OnClick="drpepperBtn_Click" />
</asp:TableCell>
                    <asp:TableCell runat="server">Dr. Pepper</asp:TableCell>
                    <asp:TableCell runat="server">Available: <asp:Label ID="drpepperAmountlbl" runat="server" Text=""></asp:Label>
</asp:TableCell>
                </asp:TableRow>

            </asp:Table>
               </div>

            </div>

    </form>
</body>
</html>
