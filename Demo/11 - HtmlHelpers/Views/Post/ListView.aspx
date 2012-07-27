<%@ Page Language="C#"
    MasterPageFile="~/Views/Shared/Site.Master"
    Inherits="System.Web.Mvc.ViewPage<ListModel>" %>
<%@ Import Namespace="MvcBestPractices.Helpers"%>
<%@ Import Namespace="MvcBestPractices.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%= Model.Title %></h2>
    
   
    <ul>
    <%
    var rowIndex = 1;
    foreach (Post post in Model.Posts) { %>
        <li><a style="<%=Html.AlternateRowColor(rowIndex++, "Yellow") %>" href="Post/Page?PostId=<%= post.Id %>"><%= post.Title %></a></li>
    <% } %>
    </ul>


</asp:Content>
