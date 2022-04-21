Imports Microsoft.AspNetCore.Mvc
Imports ProductsCore.Models
Imports System.Collections
Imports System.Collections.Generic

<ApiController()>
<Route("api/[controller]/[action]")>
Public Class ProductController
    Inherits Microsoft.AspNetCore.Mvc.Controller

    Private ReadOnly Property Products As List(Of Product)
        Get
            Return New List(Of Product) _
                From {New Product With {.Id = 1, .Name = "Tomato Soup", .Category = "Groceries", .Price = 1},
                    New Product With {.Id = 2, .Name = "Yo-yo", .Category = "Toys", .Price = 3.75},
                    New Product With {.Id = 3, .Name = "Hammer", .Category = "Hardware", .Price = 16.9}}
        End Get
    End Property

    <HttpGet()>
    Function GetAllProducts() As ActionResult(Of List(Of Product))
        Return Products
    End Function

    <HttpGet("{id}")>
    Function GetProduct(id As Integer) As ActionResult(Of Product)
        Dim product = Products.Find(Function(p) p.Id = id)
        Return product
    End Function
End Class
