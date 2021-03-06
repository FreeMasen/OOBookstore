﻿Public Structure Author
    Private _FirstName As String

    Private _LastName As String

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property


    Public ReadOnly Property Name As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property

End Structure
