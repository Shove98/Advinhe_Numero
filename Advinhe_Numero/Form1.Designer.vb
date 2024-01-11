<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbLimites = New System.Windows.Forms.GroupBox()
        Me.radEntre1e100 = New System.Windows.Forms.RadioButton()
        Me.radEntre = New System.Windows.Forms.RadioButton()
        Me.chkDica = New System.Windows.Forms.CheckBox()
        Me.nudInferior = New System.Windows.Forms.NumericUpDown()
        Me.nudSuperior = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbTentativas = New System.Windows.Forms.GroupBox()
        Me.nudLimitar = New System.Windows.Forms.NumericUpDown()
        Me.chkLimitar = New System.Windows.Forms.CheckBox()
        Me.botIniciar = New System.Windows.Forms.Button()
        Me.botTestarAposta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAposta = New System.Windows.Forms.TextBox()
        Me.lbNApostados = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbLimites.SuspendLayout()
        CType(Me.nudInferior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTentativas.SuspendLayout()
        CType(Me.nudLimitar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbLimites
        '
        Me.gbLimites.Controls.Add(Me.radEntre1e100)
        Me.gbLimites.Controls.Add(Me.radEntre)
        Me.gbLimites.Controls.Add(Me.chkDica)
        Me.gbLimites.Controls.Add(Me.nudInferior)
        Me.gbLimites.Controls.Add(Me.nudSuperior)
        Me.gbLimites.Controls.Add(Me.Label1)
        Me.gbLimites.Location = New System.Drawing.Point(13, 12)
        Me.gbLimites.Name = "gbLimites"
        Me.gbLimites.Size = New System.Drawing.Size(200, 164)
        Me.gbLimites.TabIndex = 0
        Me.gbLimites.TabStop = False
        Me.gbLimites.Text = "Limites"
        '
        'radEntre1e100
        '
        Me.radEntre1e100.AutoSize = True
        Me.radEntre1e100.Checked = True
        Me.radEntre1e100.Location = New System.Drawing.Point(6, 21)
        Me.radEntre1e100.Name = "radEntre1e100"
        Me.radEntre1e100.Size = New System.Drawing.Size(104, 20)
        Me.radEntre1e100.TabIndex = 1
        Me.radEntre1e100.TabStop = True
        Me.radEntre1e100.Text = "Entre 1 e 100"
        Me.radEntre1e100.UseVisualStyleBackColor = True
        '
        'radEntre
        '
        Me.radEntre.AutoSize = True
        Me.radEntre.Location = New System.Drawing.Point(6, 47)
        Me.radEntre.Name = "radEntre"
        Me.radEntre.Size = New System.Drawing.Size(59, 20)
        Me.radEntre.TabIndex = 2
        Me.radEntre.Text = "Entre"
        Me.radEntre.UseVisualStyleBackColor = True
        '
        'chkDica
        '
        Me.chkDica.AutoSize = True
        Me.chkDica.Location = New System.Drawing.Point(6, 116)
        Me.chkDica.Name = "chkDica"
        Me.chkDica.Size = New System.Drawing.Size(105, 20)
        Me.chkDica.TabIndex = 6
        Me.chkDica.Text = "Mostrar Dica"
        Me.ToolTip1.SetToolTip(Me.chkDica, "Visualiza os limites do resultado")
        Me.chkDica.UseVisualStyleBackColor = True
        '
        'nudInferior
        '
        Me.nudInferior.Enabled = False
        Me.nudInferior.Location = New System.Drawing.Point(6, 73)
        Me.nudInferior.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudInferior.Name = "nudInferior"
        Me.nudInferior.Size = New System.Drawing.Size(59, 22)
        Me.nudInferior.TabIndex = 3
        '
        'nudSuperior
        '
        Me.nudSuperior.Enabled = False
        Me.nudSuperior.Location = New System.Drawing.Point(92, 75)
        Me.nudSuperior.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSuperior.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSuperior.Name = "nudSuperior"
        Me.nudSuperior.Size = New System.Drawing.Size(58, 22)
        Me.nudSuperior.TabIndex = 4
        Me.nudSuperior.Value = New Decimal(New Integer() {999, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "e"
        '
        'gbTentativas
        '
        Me.gbTentativas.Controls.Add(Me.nudLimitar)
        Me.gbTentativas.Controls.Add(Me.chkLimitar)
        Me.gbTentativas.Location = New System.Drawing.Point(12, 200)
        Me.gbTentativas.Name = "gbTentativas"
        Me.gbTentativas.Size = New System.Drawing.Size(200, 119)
        Me.gbTentativas.TabIndex = 0
        Me.gbTentativas.TabStop = False
        Me.gbTentativas.Text = "Tentativas"
        '
        'nudLimitar
        '
        Me.nudLimitar.Enabled = False
        Me.nudLimitar.Location = New System.Drawing.Point(29, 56)
        Me.nudLimitar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLimitar.Name = "nudLimitar"
        Me.nudLimitar.Size = New System.Drawing.Size(61, 22)
        Me.nudLimitar.TabIndex = 8
        Me.nudLimitar.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'chkLimitar
        '
        Me.chkLimitar.AutoSize = True
        Me.chkLimitar.Location = New System.Drawing.Point(6, 30)
        Me.chkLimitar.Name = "chkLimitar"
        Me.chkLimitar.Size = New System.Drawing.Size(68, 20)
        Me.chkLimitar.TabIndex = 7
        Me.chkLimitar.Text = "Limitar"
        Me.ToolTip1.SetToolTip(Me.chkLimitar, "Permite definir o numero maximo de tentativas")
        Me.chkLimitar.UseVisualStyleBackColor = True
        '
        'botIniciar
        '
        Me.botIniciar.Location = New System.Drawing.Point(357, 26)
        Me.botIniciar.Name = "botIniciar"
        Me.botIniciar.Size = New System.Drawing.Size(120, 27)
        Me.botIniciar.TabIndex = 1
        Me.botIniciar.Text = "Iniciar"
        Me.ToolTip1.SetToolTip(Me.botIniciar, "Clique para iniciar o jogo")
        Me.botIniciar.UseVisualStyleBackColor = True
        '
        'botTestarAposta
        '
        Me.botTestarAposta.Location = New System.Drawing.Point(357, 137)
        Me.botTestarAposta.Name = "botTestarAposta"
        Me.botTestarAposta.Size = New System.Drawing.Size(120, 26)
        Me.botTestarAposta.TabIndex = 2
        Me.botTestarAposta.Text = "Testar Aposta"
        Me.botTestarAposta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Aposta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numeros Apostados:"
        '
        'txtAposta
        '
        Me.txtAposta.Enabled = False
        Me.txtAposta.Location = New System.Drawing.Point(413, 81)
        Me.txtAposta.Name = "txtAposta"
        Me.txtAposta.Size = New System.Drawing.Size(50, 22)
        Me.txtAposta.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtAposta, "Introduza o seu palpite")
        '
        'lbNApostados
        '
        Me.lbNApostados.Enabled = False
        Me.lbNApostados.FormattingEnabled = True
        Me.lbNApostados.ItemHeight = 16
        Me.lbNApostados.Location = New System.Drawing.Point(357, 217)
        Me.lbNApostados.Name = "lbNApostados"
        Me.lbNApostados.Size = New System.Drawing.Size(148, 116)
        Me.lbNApostados.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 363)
        Me.Controls.Add(Me.lbNApostados)
        Me.Controls.Add(Me.txtAposta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.botTestarAposta)
        Me.Controls.Add(Me.botIniciar)
        Me.Controls.Add(Me.gbTentativas)
        Me.Controls.Add(Me.gbLimites)
        Me.Name = "Form1"
        Me.Text = "Advinhe o numero!"
        Me.gbLimites.ResumeLayout(False)
        Me.gbLimites.PerformLayout()
        CType(Me.nudInferior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTentativas.ResumeLayout(False)
        Me.gbTentativas.PerformLayout()
        CType(Me.nudLimitar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbLimites As GroupBox
    Friend WithEvents gbTentativas As GroupBox
    Friend WithEvents radEntre1e100 As RadioButton
    Friend WithEvents radEntre As RadioButton
    Friend WithEvents nudInferior As NumericUpDown
    Friend WithEvents nudSuperior As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents chkDica As CheckBox
    Friend WithEvents chkLimitar As CheckBox
    Friend WithEvents nudLimitar As NumericUpDown
    Friend WithEvents botIniciar As Button
    Friend WithEvents botTestarAposta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAposta As TextBox
    Friend WithEvents lbNApostados As ListBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
