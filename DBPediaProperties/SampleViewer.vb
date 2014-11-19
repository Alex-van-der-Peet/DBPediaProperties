Public Class SampleViewer

    Public SampleFile As String

    Private Sub SampleViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sr As New System.IO.StreamReader(SampleFile)

            Dim iLines As Integer = 5000
            Dim iLinesRead As Integer = 0
            Dim sb As New System.Text.StringBuilder

            While sr.Peek <> -1
                sb.AppendLine(sr.ReadLine)

                iLinesRead += 1

                If iLinesRead > iLines Then
                    Exit While
                End If
            End While

            tbSample.Text = sb.ToString

            sr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btClose_Click(sender As System.Object, e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub
End Class