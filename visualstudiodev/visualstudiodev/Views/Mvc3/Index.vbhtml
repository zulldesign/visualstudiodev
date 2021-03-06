﻿@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>
<!DOCTYPE HTML>
<html>
<head>
<meta charset="utf-8">
<title>Design and Code an integrated Facebook App</title>
 
<link rel="stylesheet" type="text/css" href="http://yui.yahooapis.com/3.3.0/build/cssreset/reset-min.css">
<link rel="stylesheet" type="text/css" href="/Content/images/fbstyle/style.css">
<script src="http://code.jquery.com/jquery-latest.js" type="text/javascript"></script>
<script src="/Content/images/fbstyle/myjava.js" type="text/javascript"></script>
 
 
</head>
 
<body>
<div class="wrapper">
 
    <div class="maincontent">
     
        <div class="logo"><img src="/Content/images/fbstyle/logo.png" width="379" height="60" alt="webdesigntuts+ logo"></div>
         
        <ul class="tabs">
            <li><a href="#tab1">All</a></li>
            <li><a href="#tab2">About</a></li>
            <li><a href="#tab3">Write For Us</a></li>
            <li><a href="#tab4">Other Blogs</a></li>
        </ul>
 
<div class="tab_container">
    <div id="tab1" class="tab_content">
     
          <div class="post">
        </div><!--End Blog Post-->
         
        <div class="post">
                <h3><a href="#">Designing For, and As, a Color-Blind Person</a></h3>
                <span class="postInfo">by <a href="#">Connor Turnbull</a> on Jul 22nd 2011 with 2 comments</span>
                <p>Color blindness is a mild disability through which the affected experience a decreased ability to distinguish colors from others. This can be a real drawback for anyone in the design field since color theory is an integral feature in successful design, and a lot of decisions are based on the feeling and emotion derived from...</p>
                <a class="more" href="#">Read More</a>
                <span class="line"></span>
                <a href="#">12 Likes 14 Comments Share</a>
                <span class="line"></span>
        </div><!--End Blog Post-->
         
    </div><!--End Tab 1-->
    
    <div id="tab2" class="tab_content">
 
<h3>About</h3>
<p>Webdesigntuts+ is a blog made to house and showcase some of the best web design tutorials and articles around. We publish tutorials that not only produce great results and interfaces, but explain the techniques behind them in a friendly, approachable manner.</p>
<p>Web design is a booming industry with a lot of competition. We hope that reading Webdesigntuts+ will help our readers learn a few tricks, techniques and tips that they might not have seen before and help them maximize their creative potential!</p>
<p><strong>Webdesigntuts+ is part of the Tuts+ Network</strong></p>
 
</div><!--End Tab 2 -->
     
    <div id="tab3" class="tab_content">

    <div class="tabHeader">Categories</div>
            
               <ul>
                   <li><a href="#">Sample Cat 1</a></li>
                   <li><a href="#">Sample Cat 2</a></li>
                   <li><a href="#">Sample Cat 3</a></li>
                   <li><a href="#">Sample Cat 4</a></li>
                   <li><a href="#">Sample cat 5</a></li>
               </ul>
            
           <div class="tabHeader">A Little Bit About Us</div>     

    </div><!--End Tab 3 -->
     
    <div id="tab4" class="tab_content">

    Code Block showing tabs headers
    
    </div><!--End Tab 4 -->
 
</div><!--End Tab Container -->
     
  </div><!--End Main Content-->
     
    <div class="sidebar">

    The Search Filter
    <form action="" method="get">
            <input name="search" class="search" placeholder="Filter webdesigntuts+ posts">
            </form>

    Facebook Like and Button
    <a class="button left" href="http://webdesign.tutsplus.com/" target="_blank"><span class="buttonimage left"></span>Website</a>
           <div id="fb-root"></div><script src="http://connect.facebook.net/en_US/all.js#appId=253432341349745&amp;xfbml=1"></script><fb:like href="http://apps.facebook.com/fbtuttts"layout="button_count" width="75" show_faces="true" action="like" font="lucida grande"></fb:like>
           <a class="button right" href="#"><span class="buttonimage left"></span>Logout</a>

    Tab Headers
    <div class="tabHeader">Categories</div>
            
               <ul>
                   <li><a href="#">Sample Cat 1</a></li>
                   <li><a href="#">Sample Cat 2</a></li>
                   <li><a href="#">Sample Cat 3</a></li>
                   <li><a href="#">Sample Cat 4</a></li>
                   <li><a href="#">Sample cat 5</a></li>
               </ul>
            
           <div class="tabHeader">A Little Bit About Us</div>    
    
    </div><!--End Sidebar-->
</div><!--End Wrapper -->
 
 
</body>
</html>

