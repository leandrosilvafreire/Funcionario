Public Class frmLogin

    Dim dtLogin As New DataTable

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            servidor = "LSF-PC\SQLEXPRESS"
            banco = "bd_industria"
            usuario = "sa"
            senha = "l3@ndr0"

            criarConexao()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            If txtUsuario.Text = String.Empty Then
                MsgBox("Usuário não digitado!", MsgBoxStyle.Information, "Alerta")
                txtUsuario.Focus()
            ElseIf txtSenha.Text = String.Empty Then
                MsgBox("Senha não digitada!", MsgBoxStyle.Information, "Alerta")
                txtSenha.Focus()
            Else
                sql = "select usuario, senha from tb_usuario where usuario = '" & txtUsuario.Text & "'"
                dtLogin = consulta(sql)

                If dtLogin.Rows.Count > 0 Then
                    If dtLogin.Rows(0)(1).ToString = txtSenha.Text Then
                        MsgBox("Usuário validado com sucesso!", MsgBoxStyle.Information, "Alerta")
                        Me.Hide()
                        frmPrincipal.Show()
                    Else
                        MsgBox("Senha Incorreta!", MsgBoxStyle.Exclamation, "Alerta")

                    End If
                Else
                    MsgBox("Usuário não existe!", MsgBoxStyle.Exclamation, "Alerta")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class
