<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Countries.aspx.cs" Inherits="Test_Homework.Countries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="MyStatesOne" runat="server" Text="States"></asp:Label>
        <asp:TextBox ID="MyStates" Text="Enter your state" runat="server" ></asp:TextBox>
        <asp:Label ID="MyCapitalsOne" runat="server" Text="Capital"></asp:Label>
        <asp:TextBox ID="MyCapitals" Text="Enter your capital" runat="server" Label="Capitals"></asp:TextBox>
        <asp:Label ID="MyPopulationOne" runat="server" Text="Population"></asp:Label>
        <asp:TextBox ID="MyPopulation" Text="Enter your population" runat="server" lLabel="Population"></asp:TextBox>
        <asp:Button ID="SearchMe" runat="server" Text="Search" OnClick="SearchMe_Click5"/>
    </div>
    </form>
</body>
</html>
