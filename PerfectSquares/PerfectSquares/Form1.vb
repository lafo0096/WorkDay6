Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim n As Integer = 1

        Do
            Dim square As Integer = n ^ 2
            lstResult.Items.Add(square)
            n += 1
        Loop Until n > 10

    End Sub
End Class
