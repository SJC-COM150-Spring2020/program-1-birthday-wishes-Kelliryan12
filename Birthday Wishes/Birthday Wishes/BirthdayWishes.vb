Public Class BirthdayWishes
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        'Show message box 
        MessageBox.Show("Thank you! " & txtName.Text)

        'Print Happy Birthday Song to list box
        lstOut.Items.Add("Happy Birthday to You, Happy Birthday to You,")
        lstOut.Items.Add("Happy Birthday to You,")
        lstOut.Items.Add("Happy Birthday to You!")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear txtName Value 
        txtName.Clear()
        lstOut.Items.Clear()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When user exits pogram
        Application.Exit()

    End Sub
End Class
