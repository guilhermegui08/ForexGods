Public Class casino
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
        FRMprimcipal.Show()
    End Sub

    Private Sub LojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LojaToolStripMenuItem.Click

    End Sub

    Private Sub ImobiliárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImobiliárioToolStripMenuItem.Click
        Me.Close()
        imobiliario.Show()
    End Sub

    Private Sub StandAutomóvelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandAutomóvelToolStripMenuItem.Click
        Me.Close()
        Stand.Show()
    End Sub

    Private Sub LojaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LojaToolStripMenuItem1.Click
        Me.Close()
        loja.Show()
    End Sub

    Private Sub PáginaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaPrincipalToolStripMenuItem.Click
        Me.Close()
        Perfil.Show()
    End Sub

    Private Sub ForexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForexToolStripMenuItem.Click
        Me.Close()
        Forex.Show()
    End Sub

    Private Sub EnsinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnsinoToolStripMenuItem.Click
        Me.Close()
        conheciento.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Labelx3.Click

    End Sub

    Private Sub Buttonslotmachine_Click(sender As Object, e As EventArgs) Handles Buttonslotmachine.Click
        vslot = TextBoxslotmachine.Text
        num = CInt(Int((4 * Rnd()) + 1))
        Select Case num
            Case 1
                dinheiro = dinheiro + vslot * 3
                MsgBox("Parabéns, ganhou:" & vslot * 3 & " €.")        ' 
            Case 2, 3, 4
                dinheiro = dinheiro - vslot
                MsgBox("Perdeu: " & vslot & " €.")
        End Select
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBoxslotmachine.TextChanged
        Dim val As Integer
        val = IsNumeric(TextBoxslotmachine.Text)
        If val = True Then Buttonslotmachine.Enabled = True
        If val = False Then Buttonslotmachine.Enabled = False

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpreto.TextChanged
        Dim val As Integer
        val = IsNumeric(TextBoxpreto.Text)
        If val = True Then Buttonpreto.Enabled = True
        If val = False Then Buttonpreto.Enabled = False

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxvermelho.TextChanged
        Dim val As Integer
        val = IsNumeric(TextBoxvermelho.Text)
        If val = True Then Buttonvermelho.Enabled = True
        If val = False Then Buttonvermelho.Enabled = False

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxverde.TextChanged
        Dim val As Integer
        val = IsNumeric(TextBoxverde.Text)
        If val = True Then Buttonverde.Enabled = True
        If val = False Then Buttonverde.Enabled = False

    End Sub

    Private Sub Buttonpreto_Click(sender As Object, e As EventArgs) Handles Buttonpreto.Click


        vpreto = TextBoxpreto.Text
        num = CInt(Int((11 * Rnd()) + 1))
        Select Case num
            Case 1, 2, 3, 4, 5
                dinheiro = dinheiro + vpreto * 2
                MsgBox("Parabéns, ganhou:" & vpreto * 2 & " €.")

        ' 
            Case 6, 7, 8, 9, 10
                dinheiro = dinheiro - vpreto
                MsgBox("Perdeu:" & vpreto & " €.")

            Case 11
                dinheiro = dinheiro - vpreto
                MsgBox("Perdeu:" & vpreto & " €.")
        End Select
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonvermelho_Click(sender As Object, e As EventArgs) Handles Buttonvermelho.Click
        vvermelho = TextBoxvermelho.Text
        num = CInt(Int((11 * Rnd()) + 1))
        Select Case num
            Case 1, 2, 3, 4, 5
                dinheiro = dinheiro - vvermelho
                MsgBox("Perdeu:" & vvermelho & " €.")

        ' 
            Case 6, 7, 8, 9, 10
                dinheiro = dinheiro + vvermelho * 2
                MsgBox("Parabéns, ganhou:" & vvermelho * 2 & " €.")

            Case 11
                dinheiro = dinheiro + vvermelho * 2
                MsgBox("Parabéns, ganhou:" & vvermelho * 2 & " €.")
        End Select
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonverde_Click(sender As Object, e As EventArgs) Handles Buttonverde.Click

        vverde = TextBoxverde.Text
        num = CInt(Int((11 * Rnd()) + 1))
        Select Case num
            Case 1, 2, 3, 4, 5
                dinheiro = dinheiro - vverde
                MsgBox("Perdeu:" & vverde & " €.")
        ' 
            Case 6, 7, 8, 9, 10
                dinheiro = dinheiro - vverde
                MsgBox("Perdeu:" & vverde & " €.")
            Case 11
                dinheiro = dinheiro + vverde * 10
                MsgBox("Parabéns, ganhou:" & vverde * 10 & " €.")
        End Select
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub casino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qcasino = qcasino + 1
        TextBoxslotmachine.Enabled = True
        TextBoxverde.Enabled = True
        TextBoxvermelho.Enabled = True
        TextBoxpreto.Enabled = True


    End Sub
End Class