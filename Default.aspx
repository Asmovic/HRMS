<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%--    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-large">Learn more &raquo;</a></p>
    </div>--%>
    
    <div class="container">
<br />
<div class="carousel slide" id="myCarousel" data-ride="carousel">
<ol class="carousel-indicators">
<li data-target="#myCarousel" data-slide-to="0" class="active"></li>
<li data-target="#myCarousel" data-slide-to="1"></li>
<li data-target="#myCarousel" data-slide-to="2"></li>
<li data-target="#myCarousel" data-slide-to="3"></li>
<li data-target="#myCarousel" data-slide-to="4"></li>
<li data-target="#myCarousel" data-slide-to="5"></li>
<li data-target="#myCarousel" data-slide-to="6"></li>
<li data-target="#myCarousel" data-slide-to="7"></li>
<li data-target="#myCarousel" data-slide-to="8"></li>

</ol>

<div class="carousel-inner" role="listbox">
<div class="item active">
<img src="img/ca 1.jpg" alt="ca1" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

<div class="item">
<img src="img/ca 2a.jpg" alt="ca2" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

<div class="item">
<img src="img/ca33.jpg" alt="ca33" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

<div class="item">
<img src="img/ca 34.jpg" alt="ca34" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

    <div class="item">
<img src="img/ca 55.jpg" alt="ca5" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

    <div class="item">
<img src="img/ca 7.jpg" alt="ca7" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

    <div class="item">
<img src="img/ca 8.PNG" alt="ca8" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

    <div class="item">
<img src="img/ca 9.jpg" alt="ca9" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

<div class="item">
<img src="img/ca 11.jpg" alt="ca11" />
<div class="carousel-caption">
<h3></h3>
<p></p>
</div>
</div>

</div>

<a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
<span class="glyphicon glyphicon-chevron-left" aria-hidden="true" ></span>
<span class="sr-only">Previous</span>
</a>
<a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
<span class="glyphicon glyphicon-chevron-right" aria-hidden="true" ></span>
<span class="sr-only">Next</span>
</a>
</div></div>

    <div class="row">
        <div class="col-md-3">
            <h3>Centralized and secure employee data</h3>
            <p>
               Manage all your HR administrative actions from a central location. Search employees and analyze attrition reports - all from a single dashboard.
            </p>
            <p>
                <a class="btn btn-success" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h3>Job Application</h3>
            <p>
               You can submit your credentials here.
            </p>
            <p>
                <a class="btn btn-info" href="hrpages/Recruitment.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h3>Leave Management</h3>
            <p>
               Simplifies your leave management process. You can record and monitor all types of leave across your organization: vacation, training, sick days, etc. Centralized view of all employee leave information, accurate leave reports.
            </p>
            <p>
                <a class="btn btn-warning" href="#">Learn more &raquo;</a>
            </p>
        </div>
         <div class="col-md-3">
            <h3>Performance Appraisal</h3>
            <p>
               Help you analyze the abilities and performance of your employees. It also deals with promotion, Retirement, Transfer, Recruitment and so on.
            </p>
            <p>
                <a class="btn btn-primary" href="#">Learn more &raquo;</a>
            </p>
        </div>
    </div>

            <style runat="server">
         .carousel-inner > .item > img,
  .carousel-inner > .item > a > img {
      width: 100%;
      margin: inherit;
      height:550px;
	  }
        </style>
</asp:Content>
