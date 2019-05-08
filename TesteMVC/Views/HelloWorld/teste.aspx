<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="TesteMVC.Models" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <div>
            <table>
                <thead>
                    <tr>
                        <td>Id</td>
                        <td>Nome</td>
                    </tr>
                </thead>
                <tbody>
                    <%
                    //var lista = ViewData["lista"] as IEnumerable<TesteDTO>;
                    var lista = Model as IEnumerable<TesteModel>;
                    
                    foreach (var item in lista)
                    {
                    %>
                    <tr>
                        <td><%: item.Id %></td>
                        <td><%: item.Nome %></td>
                    </tr>
                    <%
                    }
                   %>
                </tbody>
            </table>
        </div>
</body>
</html>
