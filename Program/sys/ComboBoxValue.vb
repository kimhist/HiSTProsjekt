Public Class ComboBoxValue
    Private _id As String
    Private _display As String
    Private _name As String

    Sub New(ByVal id As String, ByVal display As String, ByVal name As String)
        Me._id = id
        Me._display = display
        Me._name = name
    End Sub

    Public ReadOnly Property ID() As Integer
        Get
            Return Me._id
        End Get
    End Property


    Public ReadOnly Property Name() As String
        Get
            Return Me._name
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Me._display
    End Function
End Class
