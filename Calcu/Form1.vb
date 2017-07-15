Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y



        x = Convert.ToDouble(TextBox1.Text)
        y = Convert.ToDouble(TextBox2.Text)
        TextBox3.Text = String.Format(x + y)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x, y

        x = Convert.ToDouble(TextBox1.Text)
        y = Convert.ToDouble(TextBox2.Text)
        TextBox3.Text = String.Format(x - y)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x, y

        x = Convert.ToDouble(TextBox1.Text)
        y = Convert.ToDouble(TextBox2.Text)
        TextBox3.Text = String.Format(x * y)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x, y

        x = Convert.ToDouble(TextBox1.Text)
        y = Convert.ToDouble(TextBox2.Text)
        TextBox3.Text = String.Format(x / y)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x
        x = Convert.ToDouble(TextBox1.Text)
        TextBox3.Text = String.Format(Math.Sqrt(x))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x, y
        x = Convert.ToDouble(TextBox1.Text)
        y = Convert.ToDouble(TextBox2.Text)

        TextBox3.Text = String.Format(Math.Pow(x, y))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub
End Class
