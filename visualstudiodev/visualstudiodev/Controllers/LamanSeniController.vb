Namespace visualstudiodev
    Public Class LamanSeniController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /LamanSeni

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Guitar(ByVal template As String, Optional ByVal download As Integer = 1) As ActionResult
            Return View()
        End Function

        Public Function OnlineMovieStoreTemplate() As ActionResult
            Return View()
        End Function

    End Class
End Namespace
