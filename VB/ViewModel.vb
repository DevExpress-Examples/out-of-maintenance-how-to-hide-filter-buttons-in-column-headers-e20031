Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace E20031

    Public Class TestViewModel
        Inherits BindableBase

        Private _records As ObservableCollection(Of TestData)

        Public Property Records As ObservableCollection(Of TestData)
            Get
                Return _records
            End Get

            Set(ByVal value As ObservableCollection(Of TestData))
                If _records IsNot value Then
                    _records = value
                    RaisePropertyChanged(Function() Records)
                End If
            End Set
        End Property

        Public Sub New()
            Records = New ObservableCollection(Of TestData)()
            For i As Integer = 0 To 10 - 1
                Records.Add(New TestData() With {.Text = "Row" & i, .Number = i})
            Next
        End Sub
    End Class

    Public Class TestData

        Public Property Text As String

        Public Property Number As Integer
    End Class
End Namespace
