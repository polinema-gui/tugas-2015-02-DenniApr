Public Class Form1

    Private Sub no1_Click(sender As Object, e As EventArgs) Handles no1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub no2_Click(sender As Object, e As EventArgs) Handles no2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub no3_Click(sender As Object, e As EventArgs) Handles no3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub no4_Click(sender As Object, e As EventArgs) Handles no4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub no5_Click(sender As Object, e As EventArgs) Handles no5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub no6_Click(sender As Object, e As EventArgs) Handles no6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub no7_Click(sender As Object, e As EventArgs) Handles no7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub no8_Click(sender As Object, e As EventArgs) Handles no8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub no9_Click(sender As Object, e As EventArgs) Handles no9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub no0_Click(sender As Object, e As EventArgs) Handles no0.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Dim h1 As String
    Dim nil As Integer
    Private Sub smdgn_Click(sender As Object, e As EventArgs) Handles smdgn.Click
        If h1 = "+" Then
            TextBox1.Text = nil + Me.TextBox1.Text
        End If
        If h1 = "-" Then
            TextBox1.Text = nil - Me.TextBox1.Text
        End If

    End Sub
    Private Sub krg_Click(sender As Object, e As EventArgs) Handles krg.Click
        nil = Val(TextBox1.Text)
        TextBox1.Text = Me.TextBox1.Text & " - "
        Me.TextBox1.Text = ""
        h1 = "-"

    End Sub

    Private Sub tbh_Click(sender As Object, e As EventArgs) Handles tbh.Click
        nil = Val(TextBox1.Text)
        TextBox1.Text = Me.TextBox1.Text & " + "
        Me.TextBox1.Text = ""
        h1 = "+"
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Text = ""
        Me.TextBox1.Text = ""




    End Sub
End Class
