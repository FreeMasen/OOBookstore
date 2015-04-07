<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAuthorFN = New System.Windows.Forms.TextBox()
        Me.txtAuthorLN = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboBiniding = New System.Windows.Forms.ComboBox()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnSellBook = New System.Windows.Forms.Button()
        Me.btnAddQty = New System.Windows.Forms.Button()
        Me.txtNumToAdd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAuthorFN
        '
        Me.txtAuthorFN.Location = New System.Drawing.Point(8, 67)
        Me.txtAuthorFN.Name = "txtAuthorFN"
        Me.txtAuthorFN.Size = New System.Drawing.Size(121, 26)
        Me.txtAuthorFN.TabIndex = 0
        '
        'txtAuthorLN
        '
        Me.txtAuthorLN.Location = New System.Drawing.Point(8, 119)
        Me.txtAuthorLN.Name = "txtAuthorLN"
        Me.txtAuthorLN.Size = New System.Drawing.Size(121, 26)
        Me.txtAuthorLN.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(8, 171)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(121, 26)
        Me.txtTitle.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(12, 233)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(117, 26)
        Me.txtPrice.TabIndex = 3
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(8, 285)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(121, 26)
        Me.txtQty.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(214, 67)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(462, 26)
        Me.txtSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Books in Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Binding"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sell Books"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Search"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Qty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Title"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Author Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Author First Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Add to Inventory"
        '
        'cboBiniding
        '
        Me.cboBiniding.FormattingEnabled = True
        Me.cboBiniding.Items.AddRange(New Object() {"Hardcover", "Softcover"})
        Me.cboBiniding.Location = New System.Drawing.Point(8, 337)
        Me.cboBiniding.Name = "cboBiniding"
        Me.cboBiniding.Size = New System.Drawing.Size(121, 28)
        Me.cboBiniding.TabIndex = 16
        '
        'lstInventory
        '
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.ItemHeight = 20
        Me.lstInventory.Location = New System.Drawing.Point(214, 119)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(592, 444)
        Me.lstInventory.TabIndex = 17
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 381)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 55)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add Book to Inventory"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(682, 67)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(124, 46)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(849, 631)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.Visible = False
        Me.LineShape1.X1 = 178
        Me.LineShape1.X2 = 177
        Me.LineShape1.Y1 = 28
        Me.LineShape1.Y2 = 576
        '
        'btnSellBook
        '
        Me.btnSellBook.Location = New System.Drawing.Point(692, 569)
        Me.btnSellBook.Name = "btnSellBook"
        Me.btnSellBook.Size = New System.Drawing.Size(114, 38)
        Me.btnSellBook.TabIndex = 21
        Me.btnSellBook.Text = "Sell Book"
        Me.btnSellBook.UseVisualStyleBackColor = True
        '
        'btnAddQty
        '
        Me.btnAddQty.Location = New System.Drawing.Point(562, 569)
        Me.btnAddQty.Name = "btnAddQty"
        Me.btnAddQty.Size = New System.Drawing.Size(114, 38)
        Me.btnAddQty.TabIndex = 22
        Me.btnAddQty.Text = "Add Qty"
        Me.btnAddQty.UseVisualStyleBackColor = True
        '
        'txtNumToAdd
        '
        Me.txtNumToAdd.Location = New System.Drawing.Point(456, 569)
        Me.txtNumToAdd.Name = "txtNumToAdd"
        Me.txtNumToAdd.Size = New System.Drawing.Size(100, 26)
        Me.txtNumToAdd.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(231, 569)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Number of books to be added"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 631)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNumToAdd)
        Me.Controls.Add(Me.btnAddQty)
        Me.Controls.Add(Me.btnSellBook)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstInventory)
        Me.Controls.Add(Me.cboBiniding)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtAuthorLN)
        Me.Controls.Add(Me.txtAuthorFN)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAuthorFN As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorLN As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboBiniding As System.Windows.Forms.ComboBox
    Friend WithEvents lstInventory As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnSellBook As System.Windows.Forms.Button
    Friend WithEvents btnAddQty As System.Windows.Forms.Button
    Friend WithEvents txtNumToAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
