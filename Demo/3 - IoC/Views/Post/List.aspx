<%@ Page Language="C#"
    MasterPageFile="~/Views/Shared/Site.Master"
    Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="MvcBestPractices.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%= ViewData["Title"]%></h2>
    
   
    <ul>
    
    <% foreach (Post post in ViewData["posts"] as IEnumerable) { %>
        <li><a href="Post/Page?PostId=<%= post.Id %>"><%= post.Title %></a></li>
    <% } %>
    </ul>


</asp:Content>
