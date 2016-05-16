Public Class frmUsuario

    Dim dt_funcionarios As New DataTable
    Dim dt_Usuarios As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPesquisaUsuario.Click
        Try
            sql = "select us.id_usuario, us.usuario, us.senha, fun.nome, fun.id_funcionario"
            sql = sql & "from tb_usuario us"
            sql = sql & "inner join tb_funcionario fun on fun.id_funcionario = us.id_funcionario"

            If Not txtUsuarioNome.Text = String.Empty Then
                sql = sql & "where us.usuario like '" & txtUsuarioNome.Text & "' "
            End If

            sql = sql & "order by us.usuario"
            dt_Usuarios = consulta(sql)
            dgvUsuario.DataSource = dt_Usuarios
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterarU.Click
        Try
            If cbUsuario.Text = String.Empty Then
                If cbUsuario.Visible = True Then
                    MsgBox("Nenhum funcionário selecionado!", MsgBoxStyle.Exclamation, "Alerta")
                Else
                    sql = "update b_usuario"
                    sql = sql & " set usuario = '" & txtUsuarioUsu.Text & "',"
                    sql = sql & " set senha = '" & txtSenhaUsu.Text & "',"

                    If lblUsuario.Visible = True Then
                        sql = sql & "id_funcionario = " & lblFuncionarioUsu.Text
                    Else
                        sql = sql & " id_funcionario = " & cbUsuario.SelectedValue

                    End If
                    sql = sql & " where id_usuario = " & txtCodigoUsu.Text
                    executaSql(sql)
                    MsgBox("Registro alterado com sucesso!", MsgBoxStyle.Information, "Alerta")
                    zerarInformacoes()

                End If
            End If
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cbUsuario_Click(sender As Object, e As EventArgs) Handles cbUsuario.Click
        Try
            preencherCombo()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnGravarU_Click(sender As Object, e As EventArgs) Handles btnGravarU.Click
        Try
            If cbUsuario.Text = String.Empty Then
                MsgBox("Selecione um funcionário!", MsgBoxStyle.Exclamation, "Alerta")
            ElseIf txtUsuarioNome.Text = String.Empty Then
                MsgBox("Campo Usuário em branco!", MsgBoxStyle.Exclamation, "Alerta")
            ElseIf txtSenhaUsu.Text = String.Empty Then
                MsgBox("Campo senha em branco!", MsgBoxStyle.Exclamation, "Alerta")
            Else
                sql = "insert into tb_usuario (usuario, senha, id_funcionario) values ('"
                sql = sql & txtUsuarioNome.Text & "', '" & txtSenhaUsu.Text & "', '" & cbUsuario.Text & "')"

                executaSql(sql)
                MsgBox("cadstro realizado com sucesso!", MsgBoxStyle.Information, "Alerta")

                zerarInformacoes()

            End If
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub preencherCombo()
        Try
            sql = "select id_funcionario, nome from tb_funcionario where id_funcionario not in (select id_funcionario from tb_usuario) order by nome"
            dt_funcionarios = consulta(sql)

            cbUsuario.DataSource = dt_funcionarios
            cbUsuario.DisplayMember = "Nome"
            cbUsuario.ValueMember = "id_funcionario"

            If dt_funcionarios.Rows.Count > 0 Then
                cbUsuario.SelectedIndex = 0
            End If

        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limparCampos()
        txtCodigoUsu.Clear()
        txtUsuarioNome.Clear()
        txtSenhaUsu.Clear()
        dt_funcionarios.Clear()
        dt_Usuarios.Clear()
        Label2.Visible = False
        cbUsuario.Visible = True
        txtUsuarioNome.Clear()


    End Sub

    Private Sub dgvUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuario.CellContentClick

    End Sub

    Private Sub dgvUsuario_DoubleClick(sender As Object, e As EventArgs) Handles dgvUsuario.DoubleClick
        Try
            txtCodigoUsu.Text = dgvUsuario.SelectedCells.Item(0).Value
            txtUsuarioUsu.Text = dgvUsuario.SelectedCells.Item(1).Value
            txtSenhaUsu.Text = dgvUsuario.SelectedCells.Item(2).Value
            Label2.Text = dgvUsuario.SelectedCells.Item(3).Value

            lblFuncionarioUsu.Text = dgvUsuario.SelectedCells.Item(4).Value

            Label2.Visible = True
            cbUsuario.Visible = False

            btnGravarU.Enabled = False
            btnAlterarU.Enabled = True
            btnExcluirU.Enabled = True
            btnCancelarU.Enabled = True

            lblFuncionarioUsu.Enabled = True

            tcUsuario.SelectedTab = tcCadastroUsuario



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub btnCancelarU_Click(sender As Object, e As EventArgs) Handles btnCancelarU.Click
        Try
            zerarInformacoes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsairU_Click(sender As Object, e As EventArgs) Handles btnsairU.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblFuncionarioUsu_Click(sender As Object, e As EventArgs) Handles lblFuncionarioUsu.Click
        If cbUsuario.Visible = True Then
            Label2.Visible = True
            cbUsuario.Visible = True
        Else
            Label2.Visible = False
            cbUsuario.Visible = True
            preencherCombo()
        End If
    End Sub

    Private Sub btnExcluirU_Click(sender As Object, e As EventArgs) Handles btnExcluirU.Click
        Try
            If MsgBox("Deseja excluir este registro?", MsgBoxStyle.OkCancel, "Alerta") = MsgBoxResult.Ok Then
                sql = "delete from tb_usuario where id_usuario = " & txtCodigoUsu.Text
                executaSql(sql)
                MsgBox("Exclusão realizada com sucesso!", MsgBoxStyle.Information, "Alerta")
                zerarInformacoes()
            End If
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub zerarInformacoes()
        dt_funcionarios.Clear()
        dt_Usuarios.Clear()
        limparCampos()
        btnGravarU.Enabled = True
        btnAlterarU.Enabled = False
        btnExcluirU.Enabled = False
        btnCancelarU.Enabled = False
        lblFuncionarioUsu.Enabled = False
        tcUsuario.SelectedTab = tcConsultaUsuario
    End Sub
End Class