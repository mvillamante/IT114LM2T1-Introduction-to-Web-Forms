<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" CodeBehind="~/Exercise5.aspx.cs" Inherits="Module1Exercise1.Exercise4" %>

<%-- Exercise 5: Creating reusable layouts using master pages--%>
<%-- TODO 5.1 Create a master page that contains a navigation bar, a main content, and a footer. --%>
<%-- The navigation bar should contain links to the other exercises --%>
<%-- The main content must include the content that the other pages will implement --%>
<%-- The footer should contain the copyright information of the page. I.e. it should display "Copyright <your name> 2024" --%>
<%-- Hint: https://www.c-sharpcorner.com/article/how-to-create-master-page-in-asp-net/ --%>

<%-- TODO 5.2 Make this page use the master page that you have created --%>
<%-- In the main content of this page, write your reflection about the following: --%>
<%-- * How would you compare plain HTML to ASP.NET WebForms --%>
<%-- * The code behind (C#) and JavaScript seem to share many use cases. When should you implement logic in the code behind and when should you implement logic in JavaScript? Provide examples. --%>
<%-- * Explain what post backs are. --%>

    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h3>HTML vs. ASP.NET WebForms</h3>
        <p>In HTML, it provides a simple way to create static web pages, where content and presentation are tightly connected. ASP.NET WebForms, on the other hand, offers a more structured approach to web development
            by providing such as server-side controls. With WebForms, we can build interactive and dynamic web applications compared to plain HTML.
        </p>

        <h3>Code Behind (C#) vs. JavaScript</h3>
        <p>
        The code-behind (C#) and JavaScript serve different purposes in ASP.NET WebForms applications. Code-behind is primarily used for server-side logic and interaction with databases. JavaScript, on the other hand, is mainly used for client-side scripting, enhancing user interface functionality and responsiveness.
        When deciding whether to implement logic in the code-behind or JavaScript, we need to consider factors such as performance and user experience. For example, complex data validation and database operations are better handled in the code-behind to ensure data integrity and security. On the other hand, client-side validation and UI enhancements, such as form validation, is more efficiently implemented using JavaScript to reduce server load and improve responsiveness.
        </p>

        <h3>Explanation of Postbacks:</h3>
        <p>
            Postbacks in ASP.NET WebForms refer to a form submitted to the server for processing, and the resulting page is sent back to the client for display. When a user interacts with a WebForms control, such as clicking a button or selecting an item from a dropdown list, a postback occurs, causing the page to be posted back to the server. The server processes the request, performs any necessary actions, and generates a response, which is sent back to the client browser for rendering.
        </p>
    </asp:Content>