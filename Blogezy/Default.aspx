<%@ Page Title="Home Page" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blogezy._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12">
        <header>
            <div class="page-title">
                <div class="row">
                    <div class="col-md-9 col-xs-12">
                     
                       <% 
                           foreach (var item in MainHeaderList)
                           {%>

                         <h2><span>
                             <%Response.Write(item.Header); %>
                            </span></h2>

                        <p class="subtitle text-muted">
                            <%Response.Write(item.Content); %>
                        </p>
                        <% 
                           }%>
                           
                       
                           
                    </div>
                </div>
            </div>
        </header>
    </div>
    <div class="col-md-9">

        <!-- Post-->
        <% foreach (var item in ArticleList)
                    {%>
        <article class="post">
            
            <div class="post-header">
                <h2 class="post-title"><a href="#"><% Response.Write(item.HeaderInfo); %></a></h2>
                <ul class="post-meta">
                    <li><% Response.Write(item.Publishdate); %></li>
                    <li><i class="mdi mdi-tag-text-outline"></i><a href="#"><%Response.Write(item.Category); %></a></li>
                    <li><i class="mdi mdi-comment-multiple-outline"></i><a href="#"><%Response.Write(item.Commentary); %></a></li>
                </ul>
            </div>

            <div class="post-preview">
                <a href="#">
                    <img src="<%Response.Write(item.ImagePath); %>" alt="" class="img-fluid rounded"></a>
            </div>

            <div class="post-content">
                <p>
                   <%Response.Write(item.Description); %>
                </p>
            </div>
            
            <div><a href="#" class="btn btn-outline-custom">Read More <i class="mdi mdi-arrow-right"></i></a></div>

        </article>
        <% } %>
        <!-- Post end-->

     

        <!-- Pagination-->
        <div class="row">
            <div class="col-lg-12">
                <ul class="pagination">
                    <li class="next"><a href="#"><i class="mdi mdi-chevron-left"></i></a></li>
                    <li class="active"><a href="#">1</a></li>
                    <li><a href="#">2</a></li>
                    <li><a href="#">3</a></li>
                    <li><a href="#">4</a></li>
                    <li><a href="#">5</a></li>
                    <li class="prev"><a href="#"><i class="mdi mdi-chevron-right"></i></a></li>
                </ul>
            </div>
        </div>
        <!-- Pagination end-->
    </div>
     

</asp:Content>
