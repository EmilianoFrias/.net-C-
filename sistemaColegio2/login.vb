Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click
        txtUsuario.Text = ""
        txtUsuario.Focus()

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub txtContraseña_Click(sender As Object, e As EventArgs) Handles txtContraseña.Click
        txtContraseña.Text = ""
        txtContraseña.Focus()
    End Sub
End Class
