Public Class Inventory
    Inherits CollectionBase
    Public results As New ArrayList


    Public Function buildBook(author As Author, title As String, bound As String, price As Double, qty As Integer) As Book
        Dim newBook As New Book
        newBook.Author = author.Name
        newBook.Title = title
        newBook.Price = price
        newBook.Qty = qty
        If bound = "Hardcover" Then
            newBook.Bound = Book.binding.Hardcover
        ElseIf bound = "Softcover" Then
            newBook.Bound = Book.binding.Softcover
        End If
        Return newBook
    End Function

    Public Sub Add(newBook As Book)
        Me.List.Add(newBook)
    End Sub

    Public Sub remove(soldBook As Book)
        Me.List.Remove(soldBook)
    End Sub

    Default Public Property Item(index As Integer) As Book
        Get
            Return CType(Me.List.Item(index), Book)
        End Get
        Set(value As Book)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Sub Find(search As String)
        results.Clear()
        For Each selection In Me.InnerList
            Dim finding As Book = CType(selection, Book)
            If finding.Author.ToString.ToLower.Contains(search.ToLower) Then
                results.Add(finding)
            ElseIf finding.Title.ToString.ToLower.Contains(search.ToLower) Then
                results.Add(finding)
            End If
        Next
        If results.Count = 0 Then
            MsgBox("Sorry no items found")
        End If
    End Sub
End Class
