<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IList<Post>>" %>
<%@ Import Namespace="MvcBestPractices.Models"%>

    <% using(Html.BeginForm("Page","Post",FormMethod.Get)) {%>
    
    <%= Html.DropDownList("PostID",
        new SelectList(Model, "Id", "Title"))%>
        <input type="submit" value="->" />
    
    <% } %>