Public Class frmPrincipal

    Private Sub CadastrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrosToolStripMenuItem.Click

    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Me.Hide()
        frmFuncionarios.Show()

    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        Me.Hide()
        frmUsuario.Show()

    End Sub
End Class