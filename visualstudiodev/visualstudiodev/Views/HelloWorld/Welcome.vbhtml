﻿<h2>Welcome</h2>

@Code       
    ViewData("Title") = "Welcome"
    For i As Integer = 0 To ViewBag.NumTimes
	@<h3> @ViewBag.Message @i.ToString </h3>
     Next i
 End Code
