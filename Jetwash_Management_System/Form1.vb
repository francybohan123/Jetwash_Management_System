Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Label1.Text = TimeOfDay.ToString()
        Label2.Text = Date.Now.ToString("dd-MMM-yyyy hh:MM:ss tt")

    End Sub
End Class
