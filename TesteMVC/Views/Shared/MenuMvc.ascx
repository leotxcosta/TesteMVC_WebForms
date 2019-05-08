<%@ Control Language="C#" AutoEventWireup="true"  Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Register Src="~/Views/Shared/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>

<form id="form1" runat="server">
	<uc1:Menu runat="server" ID="Menu" />
</form>
