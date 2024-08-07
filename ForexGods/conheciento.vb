Public Class conheciento
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
        FRMprimcipal.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PáginaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaPrincipalToolStripMenuItem.Click
        Me.Close()
        Perfil.Show()
    End Sub

    Private Sub ForexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForexToolStripMenuItem.Click
        Me.Close()
        forex.Show()
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

    Private Sub CasinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasinoToolStripMenuItem.Click
        Me.Close()
        casino.Show()
    End Sub

    Private Sub conheciento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qc = qc + 1
        TextBoxlivro1.Text = vlivro1
        TextBoxlivro2.Text = vlivro2
        TextBoxlivro3.Text = vlivro3
        TextBoxlivro4.Text = vlivro4
        TextBoxlivro5.Text = vlivro5
        TextBoxlivro6.Text = vlivro6

        If conhecimento >= 1 Then Buttonlivro1.Enabled = False
        If conhecimento >= 2 Then Buttonlivro2.Enabled = False And Buttonlivro1.Enabled = False
        If conhecimento >= 3 Then Buttonlivro3.Enabled = False And Buttonlivro2.Enabled = False And Buttonlivro1.Enabled = False
        If conhecimento >= 4 Then Buttonlivro4.Enabled = False And Buttonlivro3.Enabled = False And Buttonlivro2.Enabled = False And Buttonlivro1.Enabled = False
        If conhecimento >= 5 Then Buttonlivro5.Enabled = False And Buttonlivro4.Enabled = False And Buttonlivro3.Enabled = False And Buttonlivro2.Enabled = False And Buttonlivro1.Enabled = False
        If conhecimento >= 6 Then Buttonlivro6.Enabled = False And Buttonlivro5.Enabled = False And Buttonlivro4.Enabled = False And Buttonlivro3.Enabled = False And Buttonlivro2.Enabled = False And Buttonlivro1.Enabled = False
    End Sub

    Private Sub Buttonlivro1_Click(sender As Object, e As EventArgs) Handles Buttonlivro1.Click
        dinheiro = dinheiro - vlivro1
        conhecimento = conhecimento + 1
        Buttonlivro1.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonlivro2.Click
        dinheiro = dinheiro - vlivro2
        conhecimento = conhecimento + 1
        Buttonlivro2.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Buttonlivro3.Click
        dinheiro = dinheiro - vlivro3
        conhecimento = conhecimento + 1
        Buttonlivro3.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Buttonlivro4.Click
        dinheiro = dinheiro - vlivro4
        conhecimento = conhecimento + 1
        Buttonlivro4.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Buttonlivro5.Click
        dinheiro = dinheiro - vlivro5
        conhecimento = conhecimento + 1
        Buttonlivro5.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Buttonlivro6.Click
        dinheiro = dinheiro - vlivro6
        conhecimento = conhecimento + 1
        Buttonlivro6.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub
End Class