Public Class Form1
    Private Sub chkLimitar_CheckedChanged(sender As Object, e As EventArgs) Handles chkLimitar.CheckedChanged
        If Me.chkLimitar.Checked = True Then
            Me.nudLimitar.Enabled = True
        Else
            Me.nudLimitar.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private numeroAleatorio As Integer
    Private limiteInferior As Integer
    Private limiteSuperior As Integer
    Private numApostas As Integer = 0

    Private Sub radEntre1e100_CheckedChanged(sender As Object, e As EventArgs) Handles radEntre1e100.CheckedChanged
        Me.nudInferior.Enabled = False
        Me.nudSuperior.Enabled = False
    End Sub

    Private Sub radEntre_CheckedChanged(sender As Object, e As EventArgs) Handles radEntre.CheckedChanged
        Me.nudInferior.Enabled = True
        Me.nudSuperior.Enabled = True
    End Sub

    Private Sub botIniciar_Click(sender As Object, e As EventArgs) Handles botIniciar.Click
        Me.gbLimites.Enabled = False
        Me.gbTentativas.Enabled = False
        Me.txtAposta.Enabled = True
        Me.botTestarAposta.Enabled = True
        Me.botIniciar.Enabled = False

        Me.lbNApostados.Items.Clear()

        If Me.radEntre1e100.Checked Then
            limiteInferior = 1
            limiteSuperior = 100
        Else
            limiteInferior = CInt(Me.nudInferior.Value)
            limiteSuperior = CInt(Me.nudSuperior.Value)
        End If

        Dim rnd As New Random
        numeroAleatorio = rnd.Next(limiteInferior, limiteSuperior + 1)

        If Me.chkDica.Checked = True Then
            Me.ToolTip1.SetToolTip(Me.botTestarAposta, limiteInferior.ToString & "-" & limiteSuperior.ToString)
        End If

        numApostas = 0
        Me.txtAposta.Text = ""
        Me.txtAposta.Focus()

    End Sub

    Private Sub botTestarAposta_Click(sender As Object, e As EventArgs) Handles botTestarAposta.Click
        If Not IsNumeric(Me.txtAposta.Text) Then
            MessageBox.Show("Por favor introduza um valor numerico!",
        "Aposta nao numerica", MessageBoxButtons.OK,
        MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim aposta As Integer = Integer.Parse(Me.txtAposta.Text)

        numApostas += 1

        Select Case numeroAleatorio

            Case Is < aposta
                limiteSuperior = aposta - 1
                Me.lbNApostados.Items.Insert(0, "< " & aposta.ToString & ControlChars.Tab & "Aposta" & numApostas.ToString)

            Case Is > aposta

                limiteInferior = aposta + 1
                Me.lbNApostados.Items.Insert(0, ">" & aposta.ToString & ControlChars.Tab & "Aposta" & numApostas.ToString)

            Case Else

                Me.lbNApostados.Items.Insert(0, aposta.ToString & ControlChars.Tab & "Parabens!")
                MessageBox.Show("Parabens! Acertou no numero adivinhado." & ControlChars.NewLine & "Necessitou de" & numApostas.ToString & "aposta(s).")
                Me.gbLimites.Enabled = True
                Me.gbTentativas.Enabled = True
                Me.txtAposta.Enabled = False
                Me.botTestarAposta.Enabled = False
                Me.botiniciar.Enabled = True
                Me.botiniciar.Focus()
        End Select

        If Me.chkDica.Checked = True Then
            Me.ToolTip1.SetToolTip(Me.botTestarAposta, limiteInferior.ToString & "-" & limiteSuperior.ToString)
        End If

        If Me.chkLimitar.Checked = True AndAlso
        numeroAleatorio <> aposta AndAlso
        numApostas = Me.nudLimitar.Value Then

            Me.lbNApostados.Items.Insert(0, "Fim!")
            MessageBox.Show("Atingiu o numero de apostas maximas!",
            "Perdeu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.gbLimites.Enabled = True
            Me.gbTentativas.Enabled = True
            Me.txtAposta.Enabled = False
            Me.botTestarAposta.Enabled = False
            Me.botIniciar.Enabled = True
        End If
    End Sub
End Class

