<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<%
	this.Context.RewritePath("Home", false);

    IHttpHandler httpHandler = new MvcHttpHandler();
    httpHandler.ProcessRequest(this.Context);
%>