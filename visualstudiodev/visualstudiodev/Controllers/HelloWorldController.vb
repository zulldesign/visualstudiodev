Namespace visualstudiodev
    Public Class HelloWorldController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /HelloWorld

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Welcome(ByVal name As String, Optional ByVal numTimes As Integer = 1) As String
            Dim message As String = "Hello " & name & ", NumTimes is: " & numTimes
            Return "" & Server.HtmlEncode(message) & ""
        End Function

    End Class
End Namespace
