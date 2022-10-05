<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormStudent.aspx.cs" Inherits="MANY_TO_MANY.Views.WebFormStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>muchos a muchos</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <div class="container">
        <h1>Crea un estudiante</h1>
        <form id="form1" runat="server" >
            <asp:TextBox ID="StudentName" runat="server" placeholder="Nombre" CssClass="form-control mb-3"></asp:TextBox>
            <asp:TextBox ID="StudentLastName" runat="server" placeholder="Apellido" CssClass="form-control mb-3"></asp:TextBox>
            <asp:TextBox ID="StudentAge" runat="server" placeholder="Edad" CssClass="form-control mb-3"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="btn btn-primary" OnClick="BtnSubmit_Click"/>

            <asp:GridView ID="StudentGrid" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="StudentId" HeaderText="Id"/>
                <asp:BoundField DataField="Name" HeaderText="Nombre"/>
                <asp:BoundField DataField="LastName" HeaderText="Apellido"/>
                <asp:BoundField DataField="Age" HeaderText="Edad"/>
            </Columns>
            
        </asp:GridView>
        </form>
    </div>

        

</body>
</html>
