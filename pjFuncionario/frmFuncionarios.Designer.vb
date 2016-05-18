<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblCodigo As System.Windows.Forms.Label
        Dim lblNomeI As System.Windows.Forms.Label
        Dim lblEndereco As System.Windows.Forms.Label
        Dim lblNumero As System.Windows.Forms.Label
        Dim lblBairro As System.Windows.Forms.Label
        Dim lblComplemento As System.Windows.Forms.Label
        Dim lblCep As System.Windows.Forms.Label
        Dim lblCidade As System.Windows.Forms.Label
        Dim lblEstado As System.Windows.Forms.Label
        Dim lblCpf As System.Windows.Forms.Label
        Dim lblRg As System.Windows.Forms.Label
        Dim lblDataNasc As System.Windows.Forms.Label
        Dim lblDataCadas As System.Windows.Forms.Label
        Me.tcFuncionario = New System.Windows.Forms.TabControl()
        Me.tpConsulta = New System.Windows.Forms.TabPage()
        Me.dgvFuncionario = New System.Windows.Forms.DataGridView()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.tpCadastro = New System.Windows.Forms.TabPage()
        Me.dtpDataCad = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataNasc = New System.Windows.Forms.DateTimePicker()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.mtbCpf = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.Tb_funcionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_industriaDataSet = New pjFuncionario.bd_industriaDataSet()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNomeI = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Tb_funcionarioTableAdapter = New pjFuncionario.bd_industriaDataSetTableAdapters.tb_funcionarioTableAdapter()
        Me.TableAdapterManager = New pjFuncionario.bd_industriaDataSetTableAdapters.TableAdapterManager()
        lblCodigo = New System.Windows.Forms.Label()
        lblNomeI = New System.Windows.Forms.Label()
        lblEndereco = New System.Windows.Forms.Label()
        lblNumero = New System.Windows.Forms.Label()
        lblBairro = New System.Windows.Forms.Label()
        lblComplemento = New System.Windows.Forms.Label()
        lblCep = New System.Windows.Forms.Label()
        lblCidade = New System.Windows.Forms.Label()
        lblEstado = New System.Windows.Forms.Label()
        lblCpf = New System.Windows.Forms.Label()
        lblRg = New System.Windows.Forms.Label()
        lblDataNasc = New System.Windows.Forms.Label()
        lblDataCadas = New System.Windows.Forms.Label()
        Me.tcFuncionario.SuspendLayout()
        Me.tpConsulta.SuspendLayout()
        CType(Me.dgvFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCadastro.SuspendLayout()
        CType(Me.Tb_funcionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd_industriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        lblCodigo.AutoSize = True
        lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCodigo.Location = New System.Drawing.Point(3, 25)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New System.Drawing.Size(67, 20)
        lblCodigo.TabIndex = 0
        lblCodigo.Text = "Código: "
        '
        'lblNomeI
        '
        lblNomeI.AutoSize = True
        lblNomeI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNomeI.Location = New System.Drawing.Point(173, 25)
        lblNomeI.Name = "lblNomeI"
        lblNomeI.Size = New System.Drawing.Size(55, 20)
        lblNomeI.TabIndex = 2
        lblNomeI.Text = "Nome:"
        '
        'lblEndereco
        '
        lblEndereco.AutoSize = True
        lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEndereco.Location = New System.Drawing.Point(3, 55)
        lblEndereco.Name = "lblEndereco"
        lblEndereco.Size = New System.Drawing.Size(82, 20)
        lblEndereco.TabIndex = 4
        lblEndereco.Text = "Endereço:"
        '
        'lblNumero
        '
        lblNumero.AutoSize = True
        lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNumero.Location = New System.Drawing.Point(387, 57)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New System.Drawing.Size(69, 20)
        lblNumero.TabIndex = 6
        lblNumero.Text = "Número:"
        '
        'lblBairro
        '
        lblBairro.AutoSize = True
        lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblBairro.Location = New System.Drawing.Point(6, 93)
        lblBairro.Name = "lblBairro"
        lblBairro.Size = New System.Drawing.Size(55, 20)
        lblBairro.TabIndex = 8
        lblBairro.Text = "Bairro:"
        '
        'lblComplemento
        '
        lblComplemento.AutoSize = True
        lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblComplemento.Location = New System.Drawing.Point(258, 93)
        lblComplemento.Name = "lblComplemento"
        lblComplemento.Size = New System.Drawing.Size(112, 20)
        lblComplemento.TabIndex = 10
        lblComplemento.Text = "Complemento:"
        '
        'lblCep
        '
        lblCep.AutoSize = True
        lblCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCep.Location = New System.Drawing.Point(6, 130)
        lblCep.Name = "lblCep"
        lblCep.Size = New System.Drawing.Size(42, 20)
        lblCep.TabIndex = 12
        lblCep.Text = "Cep:"
        '
        'lblCidade
        '
        lblCidade.AutoSize = True
        lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCidade.Location = New System.Drawing.Point(334, 128)
        lblCidade.Name = "lblCidade"
        lblCidade.Size = New System.Drawing.Size(63, 20)
        lblCidade.TabIndex = 14
        lblCidade.Text = "Cidade:"
        '
        'lblEstado
        '
        lblEstado.AutoSize = True
        lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEstado.Location = New System.Drawing.Point(173, 130)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New System.Drawing.Size(64, 20)
        lblEstado.TabIndex = 16
        lblEstado.Text = "Estado:"
        '
        'lblCpf
        '
        lblCpf.AutoSize = True
        lblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCpf.Location = New System.Drawing.Point(190, 168)
        lblCpf.Name = "lblCpf"
        lblCpf.Size = New System.Drawing.Size(38, 20)
        lblCpf.TabIndex = 18
        lblCpf.Text = "Cpf:"
        '
        'lblRg
        '
        lblRg.AutoSize = True
        lblRg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRg.Location = New System.Drawing.Point(6, 170)
        lblRg.Name = "lblRg"
        lblRg.Size = New System.Drawing.Size(34, 20)
        lblRg.TabIndex = 20
        lblRg.Text = "Rg:"
        '
        'lblDataNasc
        '
        lblDataNasc.AutoSize = True
        lblDataNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDataNasc.Location = New System.Drawing.Point(345, 168)
        lblDataNasc.Name = "lblDataNasc"
        lblDataNasc.Size = New System.Drawing.Size(136, 20)
        lblDataNasc.TabIndex = 22
        lblDataNasc.Text = "Data Nascimento:"
        '
        'lblDataCadas
        '
        lblDataCadas.AutoSize = True
        lblDataCadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDataCadas.Location = New System.Drawing.Point(6, 211)
        lblDataCadas.Name = "lblDataCadas"
        lblDataCadas.Size = New System.Drawing.Size(117, 20)
        lblDataCadas.TabIndex = 24
        lblDataCadas.Text = "Data Cadastro:"
        '
        'tcFuncionario
        '
        Me.tcFuncionario.Controls.Add(Me.tpConsulta)
        Me.tcFuncionario.Controls.Add(Me.tpCadastro)
        Me.tcFuncionario.Location = New System.Drawing.Point(12, 12)
        Me.tcFuncionario.Name = "tcFuncionario"
        Me.tcFuncionario.SelectedIndex = 0
        Me.tcFuncionario.Size = New System.Drawing.Size(606, 372)
        Me.tcFuncionario.TabIndex = 0
        Me.tcFuncionario.Tag = "Consulta"
        '
        'tpConsulta
        '
        Me.tpConsulta.Controls.Add(Me.dgvFuncionario)
        Me.tpConsulta.Controls.Add(Me.btnPesquisar)
        Me.tpConsulta.Controls.Add(Me.lblNome)
        Me.tpConsulta.Controls.Add(Me.txtNome)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(598, 346)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'dgvFuncionario
        '
        Me.dgvFuncionario.AllowUserToAddRows = False
        Me.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column1, Me.column2, Me.column3, Me.column4, Me.column5, Me.column6, Me.column7, Me.column8, Me.column9, Me.column10, Me.Column11, Me.Column12, Me.column13})
        Me.dgvFuncionario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvFuncionario.Location = New System.Drawing.Point(3, 85)
        Me.dgvFuncionario.Name = "dgvFuncionario"
        Me.dgvFuncionario.ReadOnly = True
        Me.dgvFuncionario.RowHeadersVisible = False
        Me.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFuncionario.Size = New System.Drawing.Size(592, 258)
        Me.dgvFuncionario.TabIndex = 159
        '
        'column1
        '
        Me.column1.DataPropertyName = "id_funcionario"
        Me.column1.HeaderText = "Código"
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Width = 65
        '
        'column2
        '
        Me.column2.DataPropertyName = "nome"
        Me.column2.HeaderText = "Nome"
        Me.column2.Name = "column2"
        Me.column2.ReadOnly = True
        Me.column2.Width = 60
        '
        'column3
        '
        Me.column3.DataPropertyName = "Endereco"
        Me.column3.HeaderText = "Endereço"
        Me.column3.Name = "column3"
        Me.column3.ReadOnly = True
        Me.column3.Width = 78
        '
        'column4
        '
        Me.column4.DataPropertyName = "numero"
        Me.column4.HeaderText = "Número"
        Me.column4.Name = "column4"
        Me.column4.ReadOnly = True
        Me.column4.Width = 69
        '
        'column5
        '
        Me.column5.DataPropertyName = "bairro"
        Me.column5.HeaderText = "Bairro"
        Me.column5.Name = "column5"
        Me.column5.ReadOnly = True
        Me.column5.Width = 59
        '
        'column6
        '
        Me.column6.DataPropertyName = "complemento"
        Me.column6.HeaderText = "Complemento"
        Me.column6.Name = "column6"
        Me.column6.ReadOnly = True
        Me.column6.Width = 96
        '
        'column7
        '
        Me.column7.DataPropertyName = "cep"
        Me.column7.HeaderText = "Cep"
        Me.column7.Name = "column7"
        Me.column7.ReadOnly = True
        Me.column7.Width = 51
        '
        'column8
        '
        Me.column8.DataPropertyName = "cidade"
        Me.column8.HeaderText = "Cidade"
        Me.column8.Name = "column8"
        Me.column8.ReadOnly = True
        Me.column8.Width = 65
        '
        'column9
        '
        Me.column9.DataPropertyName = "estado"
        Me.column9.HeaderText = "Estado"
        Me.column9.Name = "column9"
        Me.column9.ReadOnly = True
        Me.column9.Width = 65
        '
        'column10
        '
        Me.column10.DataPropertyName = "cpf"
        Me.column10.HeaderText = "CPF"
        Me.column10.Name = "column10"
        Me.column10.ReadOnly = True
        Me.column10.Width = 52
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "rg"
        Me.Column11.HeaderText = "RG"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 48
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "dt_nascimento"
        Me.Column12.HeaderText = "Nascimento"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 88
        '
        'column13
        '
        Me.column13.DataPropertyName = "dt_cadastro"
        Me.column13.HeaderText = "Data Cadastro"
        Me.column13.Name = "column13"
        Me.column13.ReadOnly = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Location = New System.Drawing.Point(446, 14)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(115, 35)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(6, 19)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(77, 26)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome: "
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(89, 21)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(340, 20)
        Me.txtNome.TabIndex = 0
        '
        'tpCadastro
        '
        Me.tpCadastro.AutoScroll = True
        Me.tpCadastro.Controls.Add(Me.dtpDataCad)
        Me.tpCadastro.Controls.Add(Me.dtpDataNasc)
        Me.tpCadastro.Controls.Add(Me.btnSair)
        Me.tpCadastro.Controls.Add(Me.btnCancelar)
        Me.tpCadastro.Controls.Add(Me.btnExcluir)
        Me.tpCadastro.Controls.Add(Me.btnAlterar)
        Me.tpCadastro.Controls.Add(Me.btnGravar)
        Me.tpCadastro.Controls.Add(Me.mtbCpf)
        Me.tpCadastro.Controls.Add(Me.mtbCep)
        Me.tpCadastro.Controls.Add(lblDataCadas)
        Me.tpCadastro.Controls.Add(lblDataNasc)
        Me.tpCadastro.Controls.Add(lblRg)
        Me.tpCadastro.Controls.Add(Me.txtRg)
        Me.tpCadastro.Controls.Add(lblCpf)
        Me.tpCadastro.Controls.Add(lblEstado)
        Me.tpCadastro.Controls.Add(Me.txtEstado)
        Me.tpCadastro.Controls.Add(lblCidade)
        Me.tpCadastro.Controls.Add(Me.txtCidade)
        Me.tpCadastro.Controls.Add(lblCep)
        Me.tpCadastro.Controls.Add(lblComplemento)
        Me.tpCadastro.Controls.Add(Me.txtComplemento)
        Me.tpCadastro.Controls.Add(lblBairro)
        Me.tpCadastro.Controls.Add(Me.txtBairro)
        Me.tpCadastro.Controls.Add(lblNumero)
        Me.tpCadastro.Controls.Add(Me.txtNumero)
        Me.tpCadastro.Controls.Add(lblEndereco)
        Me.tpCadastro.Controls.Add(Me.txtEndereco)
        Me.tpCadastro.Controls.Add(lblNomeI)
        Me.tpCadastro.Controls.Add(Me.txtNomeI)
        Me.tpCadastro.Controls.Add(lblCodigo)
        Me.tpCadastro.Controls.Add(Me.txtCodigo)
        Me.tpCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastro.Size = New System.Drawing.Size(598, 346)
        Me.tpCadastro.TabIndex = 1
        Me.tpCadastro.Text = "Cadastro"
        Me.tpCadastro.UseVisualStyleBackColor = True
        '
        'dtpDataCad
        '
        Me.dtpDataCad.Enabled = False
        Me.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataCad.Location = New System.Drawing.Point(129, 210)
        Me.dtpDataCad.Name = "dtpDataCad"
        Me.dtpDataCad.Size = New System.Drawing.Size(149, 20)
        Me.dtpDataCad.TabIndex = 36
        '
        'dtpDataNasc
        '
        Me.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNasc.Location = New System.Drawing.Point(487, 169)
        Me.dtpDataNasc.Name = "dtpDataNasc"
        Me.dtpDataNasc.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataNasc.TabIndex = 35
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(427, 270)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(88, 30)
        Me.btnSair.TabIndex = 34
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(322, 270)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(234, 270)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 30)
        Me.btnExcluir.TabIndex = 32
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Location = New System.Drawing.Point(137, 270)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterar.TabIndex = 31
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Location = New System.Drawing.Point(48, 270)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(75, 30)
        Me.btnGravar.TabIndex = 30
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'mtbCpf
        '
        Me.mtbCpf.Location = New System.Drawing.Point(234, 168)
        Me.mtbCpf.Mask = "000.000.000-00"
        Me.mtbCpf.Name = "mtbCpf"
        Me.mtbCpf.Size = New System.Drawing.Size(95, 20)
        Me.mtbCpf.TabIndex = 27
        Me.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mtbCep
        '
        Me.mtbCep.Location = New System.Drawing.Point(54, 130)
        Me.mtbCep.Mask = "00.000-000"
        Me.mtbCep.Name = "mtbCep"
        Me.mtbCep.Size = New System.Drawing.Size(96, 20)
        Me.mtbCep.TabIndex = 26
        Me.mtbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtRg
        '
        Me.txtRg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "rg", True))
        Me.txtRg.Location = New System.Drawing.Point(46, 170)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(135, 20)
        Me.txtRg.TabIndex = 21
        '
        'Tb_funcionarioBindingSource
        '
        Me.Tb_funcionarioBindingSource.DataMember = "tb_funcionario"
        Me.Tb_funcionarioBindingSource.DataSource = Me.Bd_industriaDataSet
        '
        'Bd_industriaDataSet
        '
        Me.Bd_industriaDataSet.DataSetName = "bd_industriaDataSet"
        Me.Bd_industriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(243, 130)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(73, 20)
        Me.txtEstado.TabIndex = 17
        '
        'txtCidade
        '
        Me.txtCidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "cidade", True))
        Me.txtCidade.Location = New System.Drawing.Point(403, 128)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(189, 20)
        Me.txtCidade.TabIndex = 15
        '
        'txtComplemento
        '
        Me.txtComplemento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "complemento", True))
        Me.txtComplemento.Location = New System.Drawing.Point(376, 93)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(216, 20)
        Me.txtComplemento.TabIndex = 11
        '
        'txtBairro
        '
        Me.txtBairro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "bairro", True))
        Me.txtBairro.Location = New System.Drawing.Point(67, 93)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(178, 20)
        Me.txtBairro.TabIndex = 9
        '
        'txtNumero
        '
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "numero", True))
        Me.txtNumero.Location = New System.Drawing.Point(461, 57)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(131, 20)
        Me.txtNumero.TabIndex = 7
        '
        'txtEndereco
        '
        Me.txtEndereco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "Endereco", True))
        Me.txtEndereco.Location = New System.Drawing.Point(91, 57)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(294, 20)
        Me.txtEndereco.TabIndex = 5
        '
        'txtNomeI
        '
        Me.txtNomeI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_funcionarioBindingSource, "nome", True))
        Me.txtNomeI.Location = New System.Drawing.Point(234, 25)
        Me.txtNomeI.Name = "txtNomeI"
        Me.txtNomeI.Size = New System.Drawing.Size(358, 20)
        Me.txtNomeI.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(70, 27)
        Me.txtCodigo.MaxLength = 18
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 65
        '
        'Tb_funcionarioTableAdapter
        '
        Me.Tb_funcionarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.produtosTableAdapter = Nothing
        Me.TableAdapterManager.tb_funcionarioTableAdapter = Me.Tb_funcionarioTableAdapter
        Me.TableAdapterManager.tb_usuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pjFuncionario.bd_industriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 401)
        Me.Controls.Add(Me.tcFuncionario)
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionários"
        Me.tcFuncionario.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        Me.tpConsulta.PerformLayout()
        CType(Me.dgvFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCadastro.ResumeLayout(False)
        Me.tpCadastro.PerformLayout()
        CType(Me.Tb_funcionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd_industriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcFuncionario As System.Windows.Forms.TabControl
    Friend WithEvents tpConsulta As System.Windows.Forms.TabPage
    Friend WithEvents tpCadastro As System.Windows.Forms.TabPage
    Friend WithEvents dgvFuncionario As System.Windows.Forms.DataGridView
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Bd_industriaDataSet As pjFuncionario.bd_industriaDataSet
    Friend WithEvents Tb_funcionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_funcionarioTableAdapter As pjFuncionario.bd_industriaDataSetTableAdapters.tb_funcionarioTableAdapter
    Friend WithEvents TableAdapterManager As pjFuncionario.bd_industriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents mtbCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRg As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeI As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpDataCad As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataNasc As System.Windows.Forms.DateTimePicker
End Class
