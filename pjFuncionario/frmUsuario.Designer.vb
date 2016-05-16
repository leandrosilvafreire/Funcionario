<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Me.tcUsuario = New System.Windows.Forms.TabControl()
        Me.tcConsultaUsuario = New System.Windows.Forms.TabPage()
        Me.dgvUsuario = New System.Windows.Forms.DataGridView()
        Me.codUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnPesquisaUsuario = New System.Windows.Forms.Button()
        Me.txtUsuarioNome = New System.Windows.Forms.TextBox()
        Me.tcCadastroUsuario = New System.Windows.Forms.TabPage()
        Me.btnsairU = New System.Windows.Forms.Button()
        Me.btnCancelarU = New System.Windows.Forms.Button()
        Me.btnExcluirU = New System.Windows.Forms.Button()
        Me.btnAlterarU = New System.Windows.Forms.Button()
        Me.btnGravarU = New System.Windows.Forms.Button()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.lblSenhaUsu = New System.Windows.Forms.Label()
        Me.lblUsuarioUsu = New System.Windows.Forms.Label()
        Me.lblFuncionarioUsu = New System.Windows.Forms.Label()
        Me.lblCodigoUsu = New System.Windows.Forms.Label()
        Me.txtSenhaUsu = New System.Windows.Forms.TextBox()
        Me.txtUsuarioUsu = New System.Windows.Forms.TextBox()
        Me.txtCodigoUsu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcUsuario.SuspendLayout()
        Me.tcConsultaUsuario.SuspendLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCadastroUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcUsuario
        '
        Me.tcUsuario.Controls.Add(Me.tcConsultaUsuario)
        Me.tcUsuario.Controls.Add(Me.tcCadastroUsuario)
        Me.tcUsuario.Location = New System.Drawing.Point(17, 22)
        Me.tcUsuario.Name = "tcUsuario"
        Me.tcUsuario.SelectedIndex = 0
        Me.tcUsuario.Size = New System.Drawing.Size(423, 265)
        Me.tcUsuario.TabIndex = 0
        Me.tcUsuario.Tag = "Consulta"
        '
        'tcConsultaUsuario
        '
        Me.tcConsultaUsuario.Controls.Add(Me.dgvUsuario)
        Me.tcConsultaUsuario.Controls.Add(Me.lblUsuario)
        Me.tcConsultaUsuario.Controls.Add(Me.btnPesquisaUsuario)
        Me.tcConsultaUsuario.Controls.Add(Me.txtUsuarioNome)
        Me.tcConsultaUsuario.Location = New System.Drawing.Point(4, 22)
        Me.tcConsultaUsuario.Name = "tcConsultaUsuario"
        Me.tcConsultaUsuario.Padding = New System.Windows.Forms.Padding(3)
        Me.tcConsultaUsuario.Size = New System.Drawing.Size(415, 239)
        Me.tcConsultaUsuario.TabIndex = 0
        Me.tcConsultaUsuario.Text = "Consulta"
        Me.tcConsultaUsuario.UseVisualStyleBackColor = True
        '
        'dgvUsuario
        '
        Me.dgvUsuario.AllowUserToAddRows = False
        Me.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codUsu, Me.usuUsu, Me.funUsu})
        Me.dgvUsuario.Location = New System.Drawing.Point(9, 66)
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.ReadOnly = True
        Me.dgvUsuario.RowHeadersVisible = False
        Me.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuario.Size = New System.Drawing.Size(400, 150)
        Me.dgvUsuario.TabIndex = 3
        '
        'codUsu
        '
        Me.codUsu.HeaderText = "Código"
        Me.codUsu.Name = "codUsu"
        Me.codUsu.ReadOnly = True
        Me.codUsu.Width = 65
        '
        'usuUsu
        '
        Me.usuUsu.HeaderText = "Usuário"
        Me.usuUsu.Name = "usuUsu"
        Me.usuUsu.ReadOnly = True
        Me.usuUsu.Width = 68
        '
        'funUsu
        '
        Me.funUsu.HeaderText = "Funcionário"
        Me.funUsu.Name = "funUsu"
        Me.funUsu.ReadOnly = True
        Me.funUsu.Width = 87
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(6, 19)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(81, 20)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuário: "
        '
        'btnPesquisaUsuario
        '
        Me.btnPesquisaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaUsuario.Location = New System.Drawing.Point(313, 16)
        Me.btnPesquisaUsuario.Name = "btnPesquisaUsuario"
        Me.btnPesquisaUsuario.Size = New System.Drawing.Size(96, 25)
        Me.btnPesquisaUsuario.TabIndex = 1
        Me.btnPesquisaUsuario.Text = "Pesquisar"
        Me.btnPesquisaUsuario.UseVisualStyleBackColor = True
        '
        'txtUsuarioNome
        '
        Me.txtUsuarioNome.Location = New System.Drawing.Point(93, 21)
        Me.txtUsuarioNome.Name = "txtUsuarioNome"
        Me.txtUsuarioNome.Size = New System.Drawing.Size(211, 20)
        Me.txtUsuarioNome.TabIndex = 0
        '
        'tcCadastroUsuario
        '
        Me.tcCadastroUsuario.Controls.Add(Me.Label2)
        Me.tcCadastroUsuario.Controls.Add(Me.Label1)
        Me.tcCadastroUsuario.Controls.Add(Me.btnsairU)
        Me.tcCadastroUsuario.Controls.Add(Me.btnCancelarU)
        Me.tcCadastroUsuario.Controls.Add(Me.btnExcluirU)
        Me.tcCadastroUsuario.Controls.Add(Me.btnAlterarU)
        Me.tcCadastroUsuario.Controls.Add(Me.btnGravarU)
        Me.tcCadastroUsuario.Controls.Add(Me.cbUsuario)
        Me.tcCadastroUsuario.Controls.Add(Me.lblSenhaUsu)
        Me.tcCadastroUsuario.Controls.Add(Me.lblUsuarioUsu)
        Me.tcCadastroUsuario.Controls.Add(Me.lblFuncionarioUsu)
        Me.tcCadastroUsuario.Controls.Add(Me.lblCodigoUsu)
        Me.tcCadastroUsuario.Controls.Add(Me.txtSenhaUsu)
        Me.tcCadastroUsuario.Controls.Add(Me.txtUsuarioUsu)
        Me.tcCadastroUsuario.Controls.Add(Me.txtCodigoUsu)
        Me.tcCadastroUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcCadastroUsuario.Location = New System.Drawing.Point(4, 22)
        Me.tcCadastroUsuario.Name = "tcCadastroUsuario"
        Me.tcCadastroUsuario.Padding = New System.Windows.Forms.Padding(3)
        Me.tcCadastroUsuario.Size = New System.Drawing.Size(415, 239)
        Me.tcCadastroUsuario.TabIndex = 1
        Me.tcCadastroUsuario.Text = "Cadastro"
        Me.tcCadastroUsuario.UseVisualStyleBackColor = True
        '
        'btnsairU
        '
        Me.btnsairU.Location = New System.Drawing.Point(343, 203)
        Me.btnsairU.Name = "btnsairU"
        Me.btnsairU.Size = New System.Drawing.Size(62, 30)
        Me.btnsairU.TabIndex = 13
        Me.btnsairU.Text = "Sair"
        Me.btnsairU.UseVisualStyleBackColor = True
        '
        'btnCancelarU
        '
        Me.btnCancelarU.Location = New System.Drawing.Point(249, 203)
        Me.btnCancelarU.Name = "btnCancelarU"
        Me.btnCancelarU.Size = New System.Drawing.Size(88, 30)
        Me.btnCancelarU.TabIndex = 12
        Me.btnCancelarU.Text = "Cancelar"
        Me.btnCancelarU.UseVisualStyleBackColor = True
        '
        'btnExcluirU
        '
        Me.btnExcluirU.Location = New System.Drawing.Point(168, 203)
        Me.btnExcluirU.Name = "btnExcluirU"
        Me.btnExcluirU.Size = New System.Drawing.Size(75, 30)
        Me.btnExcluirU.TabIndex = 11
        Me.btnExcluirU.Text = "Excluir"
        Me.btnExcluirU.UseVisualStyleBackColor = True
        '
        'btnAlterarU
        '
        Me.btnAlterarU.Location = New System.Drawing.Point(87, 203)
        Me.btnAlterarU.Name = "btnAlterarU"
        Me.btnAlterarU.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterarU.TabIndex = 10
        Me.btnAlterarU.Text = "Alterar"
        Me.btnAlterarU.UseVisualStyleBackColor = True
        '
        'btnGravarU
        '
        Me.btnGravarU.Location = New System.Drawing.Point(6, 203)
        Me.btnGravarU.Name = "btnGravarU"
        Me.btnGravarU.Size = New System.Drawing.Size(75, 30)
        Me.btnGravarU.TabIndex = 9
        Me.btnGravarU.Text = "Gravar"
        Me.btnGravarU.UseVisualStyleBackColor = True
        '
        'cbUsuario
        '
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(139, 61)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(179, 28)
        Me.cbUsuario.TabIndex = 8
        '
        'lblSenhaUsu
        '
        Me.lblSenhaUsu.AutoSize = True
        Me.lblSenhaUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaUsu.Location = New System.Drawing.Point(25, 161)
        Me.lblSenhaUsu.Name = "lblSenhaUsu"
        Me.lblSenhaUsu.Size = New System.Drawing.Size(66, 20)
        Me.lblSenhaUsu.TabIndex = 7
        Me.lblSenhaUsu.Text = "Senha:"
        '
        'lblUsuarioUsu
        '
        Me.lblUsuarioUsu.AutoSize = True
        Me.lblUsuarioUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioUsu.Location = New System.Drawing.Point(25, 117)
        Me.lblUsuarioUsu.Name = "lblUsuarioUsu"
        Me.lblUsuarioUsu.Size = New System.Drawing.Size(76, 20)
        Me.lblUsuarioUsu.TabIndex = 6
        Me.lblUsuarioUsu.Text = "Usuário:"
        '
        'lblFuncionarioUsu
        '
        Me.lblFuncionarioUsu.AutoSize = True
        Me.lblFuncionarioUsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFuncionarioUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuncionarioUsu.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFuncionarioUsu.Location = New System.Drawing.Point(25, 69)
        Me.lblFuncionarioUsu.Name = "lblFuncionarioUsu"
        Me.lblFuncionarioUsu.Size = New System.Drawing.Size(108, 20)
        Me.lblFuncionarioUsu.TabIndex = 5
        Me.lblFuncionarioUsu.Text = "Funcionário:"
        '
        'lblCodigoUsu
        '
        Me.lblCodigoUsu.AutoSize = True
        Me.lblCodigoUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoUsu.Location = New System.Drawing.Point(22, 30)
        Me.lblCodigoUsu.Name = "lblCodigoUsu"
        Me.lblCodigoUsu.Size = New System.Drawing.Size(70, 20)
        Me.lblCodigoUsu.TabIndex = 4
        Me.lblCodigoUsu.Text = "Código:"
        '
        'txtSenhaUsu
        '
        Me.txtSenhaUsu.Location = New System.Drawing.Point(139, 161)
        Me.txtSenhaUsu.Name = "txtSenhaUsu"
        Me.txtSenhaUsu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaUsu.Size = New System.Drawing.Size(174, 26)
        Me.txtSenhaUsu.TabIndex = 3
        '
        'txtUsuarioUsu
        '
        Me.txtUsuarioUsu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuarioUsu.Location = New System.Drawing.Point(139, 114)
        Me.txtUsuarioUsu.Name = "txtUsuarioUsu"
        Me.txtUsuarioUsu.Size = New System.Drawing.Size(174, 26)
        Me.txtUsuarioUsu.TabIndex = 2
        '
        'txtCodigoUsu
        '
        Me.txtCodigoUsu.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCodigoUsu.Enabled = False
        Me.txtCodigoUsu.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoUsu.Location = New System.Drawing.Point(98, 24)
        Me.txtCodigoUsu.Name = "txtCodigoUsu"
        Me.txtCodigoUsu.Size = New System.Drawing.Size(100, 26)
        Me.txtCodigoUsu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 327)
        Me.Controls.Add(Me.tcUsuario)
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuário"
        Me.tcUsuario.ResumeLayout(False)
        Me.tcConsultaUsuario.ResumeLayout(False)
        Me.tcConsultaUsuario.PerformLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCadastroUsuario.ResumeLayout(False)
        Me.tcCadastroUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcUsuario As System.Windows.Forms.TabControl
    Friend WithEvents tcConsultaUsuario As System.Windows.Forms.TabPage
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnPesquisaUsuario As System.Windows.Forms.Button
    Friend WithEvents txtUsuarioNome As System.Windows.Forms.TextBox
    Friend WithEvents tcCadastroUsuario As System.Windows.Forms.TabPage
    Friend WithEvents dgvUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents codUsu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuUsu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents funUsu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSenhaUsu As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioUsu As System.Windows.Forms.Label
    Friend WithEvents lblFuncionarioUsu As System.Windows.Forms.Label
    Friend WithEvents lblCodigoUsu As System.Windows.Forms.Label
    Friend WithEvents txtSenhaUsu As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioUsu As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoUsu As System.Windows.Forms.TextBox
    Friend WithEvents btnsairU As System.Windows.Forms.Button
    Friend WithEvents btnCancelarU As System.Windows.Forms.Button
    Friend WithEvents btnExcluirU As System.Windows.Forms.Button
    Friend WithEvents btnAlterarU As System.Windows.Forms.Button
    Friend WithEvents btnGravarU As System.Windows.Forms.Button
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
