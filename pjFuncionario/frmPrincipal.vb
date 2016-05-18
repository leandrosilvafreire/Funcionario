Public Class frmPrincipal

    Private Sub CadastrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrosToolStripMenuItem.Click

    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        'Me.Hide()
        frmFuncionarios.ShowDialog()

    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        ' Me.Hide()
        frmUsuario.ShowDialog()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("Deseja ralmente sair?", MsgBoxStyle.OkCancel, "Alerta") = MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Deseja ralmente sair?", MsgBoxStyle.OkCancel, "Alerta") = MsgBoxResult.Ok Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class