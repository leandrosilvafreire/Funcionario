Public Class frmFuncionarios

    Dim funcionarios As New DataTable

    Private Sub Tb_funcionarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_funcionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_industriaDataSet)

    End Sub

    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bd_industriaDataSet.tb_funcionario' table. You can move, or remove it, as needed.
        Me.Tb_funcionarioTableAdapter.Fill(Me.Bd_industriaDataSet.tb_funcionario)
        dtpDataCad.Text = Format(Date.Now, "dd/MM/yyyy")

    End Sub


    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            If txtNomeI.Text = String.Empty Then
                MsgBox("Campo nome em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtNome.Focus()
            ElseIf txtEndereco.Text = String.Empty Then
                MsgBox("Campo endereço em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtEndereco.Focus()
            ElseIf txtNumero.Text = String.Empty Then
                MsgBox("Campo número em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtNumero.Focus()
            ElseIf txtBairro.Text = String.Empty Then
                MsgBox("Campo bairro em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtBairro.Focus()
            ElseIf txtCidade.Text = String.Empty Then
                MsgBox("Campo cidade em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtCidade.Focus()
            ElseIf txtEstado.Text = String.Empty Then
                MsgBox("Campo estado em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtEstado.Focus()
            Else
                sql = "Insert into tb_funcionario (nome, Endereco, numero, bairro, complemento, cep, cidade, estado, cpf, rg, dt_nascimento, dt_cadastro) values ('" & txtNomeI.Text & "', '" & txtEndereco.Text & "', '" & txtNumero.Text & "', '" & txtBairro.Text & "', '" & txtComplemento.Text & "', '" & mtbCep.Text & "', '" & txtCidade.Text & "', '" & txtEstado.Text & "', '" & mtbCpf.Text & "', '" & txtRg.Text & "', '" & dtpDataNasc.Text & "', '" & dtpDataCad.Text & "')"

                'sql = sql & "'" & txtNomeI.Text & "', '" & txtEndereco.Text & "', '" & txtNumero.Text & "', '" & txtBairro.Text & "', '" & txtComplemento.Text & "', "
                'sql = sql & "'" & mtbCep.Text & "', '" & txtCidade.Text & "', '" & txtEstado.Text & "', '" & mtbCpf.Text & "', '" & txtRg.Text & "', "
                'sql = sql & "'" & mtbDataNasc.Text & "', '" & mtbDataCad.Text & "')"

                executaSql(sql)
                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Alerta")
                limpar()
                funcionarios.Clear()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            sql = "select id_funcionario, nome, Endereco, numero, bairro, complemento, cep, cidade, estado, cpf, rg, dt_nascimento, dt_cadastro from tb_funcionario"

            If Not txtNome.Text = String.Empty Then
                sql = sql & " WHERE nome LIKE '%" & txtNome.Text & "%'"
            End If


            funcionarios = consulta(sql)
            dgvFuncionario.DataSource = funcionarios
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub limpar()
        txtCodigo.Clear()
        txtNomeI.Clear()
        txtEndereco.Clear()
        txtNumero.Clear()
        txtBairro.Clear()
        txtComplemento.Clear()
        mtbCep.Clear()
        txtCidade.Clear()
        txtBairro.Clear()
        mtbCpf.Clear()
        txtRg.Clear()
        dtpDataNasc.Text = Format(Date.Now, "dd/MM/yyyy")
        dtpDataCad.Text = Format(Date.Now, "dd/MM/yyyy")



    End Sub

    Private Sub dgvFuncionario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionario.CellContentClick

    End Sub

    Private Sub dgvFuncionario_DoubleClick(sender As Object, e As EventArgs) Handles dgvFuncionario.DoubleClick
        Try

            txtCodigo.Text = dgvFuncionario.SelectedCells.Item(0).Value
            txtNomeI.Text = IIf(dgvFuncionario.SelectedCells.Item(1).Value Is DBNull.Value,
                               String.Empty, dgvFuncionario.SelectedCells.Item(1).Value)
            txtEndereco.Text = IIf(dgvFuncionario.SelectedCells.Item(2).Value Is DBNull.Value,
                               String.Empty, dgvFuncionario.SelectedCells.Item(2).Value)
            txtNumero.Text = IIf(dgvFuncionario.SelectedCells.Item(3).Value Is DBNull.Value,
                               String.Empty, dgvFuncionario.SelectedCells.Item(3).Value)
            txtBairro.Text = IIf(dgvFuncionario.SelectedCells.Item(4).Value Is DBNull.Value,
                              String.Empty, dgvFuncionario.SelectedCells.Item(4).Value)
            txtComplemento.Text = IIf(dgvFuncionario.SelectedCells.Item(5).Value Is DBNull.Value,
                              String.Empty, dgvFuncionario.SelectedCells.Item(5).Value)
            mtbCep.Text = IIf(dgvFuncionario.SelectedCells.Item(6).Value Is DBNull.Value,
                               String.Empty, dgvFuncionario.SelectedCells.Item(6).Value)
            txtCidade.Text = IIf(dgvFuncionario.SelectedCells.Item(7).Value Is DBNull.Value,
                              String.Empty, dgvFuncionario.SelectedCells.Item(7).Value)
            txtEstado.Text = IIf(dgvFuncionario.SelectedCells.Item(8).Value Is DBNull.Value,
                               String.Empty, dgvFuncionario.SelectedCells.Item(8).Value)
            mtbCpf.Text = IIf(dgvFuncionario.SelectedCells.Item(9).Value Is DBNull.Value,
                               String.Empty, dgvFuncionario.SelectedCells.Item(9).Value)
            txtRg.Text = IIf(dgvFuncionario.SelectedCells.Item(10).Value Is DBNull.Value,
                              String.Empty, dgvFuncionario.SelectedCells.Item(10).Value)
            dtpDataNasc.Text = IIf(dgvFuncionario.SelectedCells.Item(11).Value Is DBNull.Value,
                              String.Empty, dgvFuncionario.SelectedCells.Item(11).Value)
            dtpDataCad.Text = IIf(dgvFuncionario.SelectedCells.Item(12).Value Is DBNull.Value,
                               String.Empty, dgvFuncionario.SelectedCells.Item(12).Value)

            tcFuncionario.SelectedTab = tpCadastro

            btnGravar.Enabled = False
            btnAlterar.Enabled = True
            btnExcluir.Enabled = True
            btnCancelar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            sql = "update tb_funcionario "
            sql = sql & "set nome = '" & txtNomeI.Text & "', "
            sql = sql & "Endereco = '" & txtEndereco.Text & "', "
            sql = sql & "numero = '" & txtNumero.Text & "', "
            sql = sql & "bairro = '" & txtBairro.Text & "', "
            sql = sql & "complemento = '" & txtComplemento.Text & "', "
            sql = sql & "cep = '" & mtbCep.Text & "', "
            sql = sql & "cidade = '" & txtCidade.Text & "', "
            sql = sql & "estado = '" & txtEstado.Text & "', "
            sql = sql & "cpf = '" & mtbCpf.Text & "', "
            sql = sql & "rg = '" & txtRg.Text & "', "
            sql = sql & "dt_nascimento = '" & dtpDataNasc.Text & "', "
            sql = sql & "dt_cadastro = '" & dtpDataCad.Text & "' "
            sql = sql & "WHERE id_funcionario = '" & txtCodigo.Text & "'"

            executaSql(sql)
            MsgBox("Alteração realizada com sucesso!", MsgBoxStyle.Information, "Alerta")
            limpar()
            tcFuncionario.SelectedTab = tpConsulta

            funcionarios.Clear()
            btnGravar.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False

        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)
        End Try






    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If MsgBox("Deseja excluir este registro?", MsgBoxStyle.OkCancel, "Alerta") = MsgBoxResult.Ok Then
                sql = "DELETE FROM tb_funcionario "
                sql = sql & "WHERE id_funcionario = " & txtCodigo.Text

                executaSql(sql)
                limpar()
                MsgBox("Exclusão realizada com sucesso!", MsgBoxStyle.Information, "Alerta")

                funcionarios.Clear()
                tcFuncionario.SelectedTab = tpConsulta
                btnGravar.Enabled = True
                btnAlterar.Enabled = False
                btnExcluir.Enabled = False
                btnCancelar.Enabled = False
            End If
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try




            limpar()
            funcionarios.Clear()
            tcFuncionario.SelectedTab = tpConsulta
            btnGravar.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Try
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
    End Sub

    Private Sub tpCadastro_Click(sender As Object, e As EventArgs) Handles tpCadastro.Click

    End Sub

    Private Sub frmFuncionarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        limpar()
        funcionarios.Clear()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataNasc.ValueChanged

    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If (Asc(e.KeyChar()) < Asc("0")) Or (Asc(e.KeyChar()) > Asc("9")) Then
            If (Asc(e.KeyChar()) <> 8) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub
End Class