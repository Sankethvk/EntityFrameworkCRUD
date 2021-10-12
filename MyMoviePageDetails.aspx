<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyMoviePageDetails.aspx.cs" Inherits="DataManagementMovie.MyMoviePageDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Movie Details</h2>
            <hr />
            <table>
                <tr>
                    <td>Movie Name</td><td>
                    <asp:TextBox ID="txtMoviename" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Movie Type</td><td>
                    <asp:TextBox ID="txtMovietype" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Movie Description</td><td>
                    <asp:TextBox ID="txtMoviedesc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td><td>
                    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    <asp:Button ID="btnReset" runat="server" Text="Reset" />
                    </td>

                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Movie Id
                    </td>
                    <td>
                        <asp:TextBox ID="txtEditMovieID" runat="server"></asp:TextBox>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
