Imports System.ComponentModel
Imports System.IO
Public Class Beta
    Private Sub Beta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub EN_Click(sender As Object, e As EventArgs) Handles EN.Click
        Try
            Dim w As New StreamWriter("key")
            w.WriteLine(key.Text)
            w.Close()
            End
        Catch ex As Exception
            End
        End Try
    End Sub
End Class