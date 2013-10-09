Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim pop As Double = 7000000000
        Dim years As Integer = 2012

        Do While pop > 6000000
            pop = pop / 2
            years = years - 50
        Loop

        MessageBox.Show("The world population was less than 6 million in the year " & years & ".")

    End Sub
End Class
