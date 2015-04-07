Public Class Form1
    Dim Invt As New Inventory

    Private Sub UpdateVis()
        lstInventory.Items.Clear()
        Invt.Find(txtSearch.Text)
        For Each item In Invt.results
            lstInventory.Items.Add(item)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim author As New Author
        author.FirstName = txtAuthorFN.Text
        author.LastName = txtAuthorLN.Text
        Dim newBook As Book
        Dim exception As Integer
        Try
            If IsNumeric(txtAuthorFN.Text) = True Or IsNothing(txtAuthorFN.Text) Then
                exception = 0
                Throw New Exception
            ElseIf IsNumeric(txtAuthorLN.Text) = True Or IsNothing(txtAuthorLN.Text) Then
                exception = 1
                Throw New Exception
            ElseIf IsNumeric(txtTitle.Text) = True Or IsNothing(txtTitle.Text) Then
                exception = 2
                Throw New Exception
            ElseIf IsNumeric(txtPrice.Text) = False Or txtPrice.Text(txtPrice.Text.Length - 3) <> _
                "." Or IsNothing(txtPrice.Text) Then
                exception = 3
                Throw New Exception
            ElseIf IsNumeric(txtQty.Text) = False Or IsNothing(txtQty.Text) Then
                exception = 4
                Throw New Exception
            ElseIf cboBiniding.SelectedIndex = -1 Then
                exception = 5
            Else
                newBook = Invt.buildBook(author, txtTitle.Text, cboBiniding.SelectedItem.ToString, CDbl(txtPrice.Text), CInt(txtQty.Text))
                Invt.Add(newBook)
            End If
        Catch ex As Exception When exception = 0
            MsgBox("Author First Name is required and must not be a number")
        Catch ex As Exception When exception = 1
            MsgBox("Author Last Name is requred and must not be a number")
        Catch ex As Exception When exception = 2
            MsgBox("Title is required and must not be a number")
        Catch ex As Exception When exception = 3
            MsgBox("Price is requred and must have two digits after the decimal")
        Catch ex As Exception When exception = 4
            MsgBox("Qty is requred and must be a number")
        Catch ex As Exception When exception = 5
            MsgBox("You must select a binding type")
        End Try
        UpdateVis()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim author As New Author
        author.FirstName = "James"
        author.LastName = "May"
        Invt.Add(Invt.buildBook(author, "Stuff", CStr(Book.binding.Hardcover), 20.25, 10))
        Invt.Add(Invt.buildBook(author, "Things", CStr(Book.binding.Hardcover), 20.0, 10))
        Invt.Add(Invt.buildBook(author, "Items", CStr(Book.binding.Hardcover), 20.0, 10))
        UpdateVis()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        UpdateVis()
    End Sub

    Private Sub btnSellBook_Click(sender As Object, e As EventArgs) Handles btnSellBook.Click
        If lstInventory.SelectedIndex <> -1 Then
            If CType(lstInventory.SelectedItem, Book).Qty > 0 Then
                CType(lstInventory.SelectedItem, Book).Qty = CType(lstInventory.SelectedItem, Book).Qty - 1
            End If
        End If
        UpdateVis()
    End Sub

    Private Sub btnAddQty_Click(sender As Object, e As EventArgs) Handles btnAddQty.Click
        If lstInventory.SelectedIndex <> -1 Then
            If IsNumeric(txtNumToAdd.Text) = True Then
                CType(lstInventory.SelectedItem, Book).Qty += CInt(txtNumToAdd.Text)
            Else
                MsgBox("Quantity must be a number")
            End If
        End If
        UpdateVis()
    End Sub
End Class
