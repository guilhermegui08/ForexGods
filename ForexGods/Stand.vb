
Public Class Stand

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
        FRMprimcipal.Show()

    End Sub

    Private Sub ImobiliárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImobiliárioToolStripMenuItem.Click
        Me.Close()
        imobiliario.Show()
    End Sub

    Private Sub LojaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LojaToolStripMenuItem1.Click
        Me.Close()
        loja.Show()
    End Sub

    Private Sub CasinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasinoToolStripMenuItem.Click
        Me.Close()
        casino.Show()
    End Sub

    Private Sub EnsinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnsinoToolStripMenuItem.Click
        Me.Close()
        conheciento.Show()

    End Sub

    Private Sub ForexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForexToolStripMenuItem.Click
        Me.Close()
        forex.Show()
    End Sub

    Private Sub PáginaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaPrincipalToolStripMenuItem.Click
        Me.Close()
        Perfil.Show()
    End Sub

    Private Sub Stand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qs = qs + 1
        panda = 5000
        lemon = 100000
        autocarro = 200000
        formula1 = 6000000
        TextBoxautocarro.Text = autocarro
        TextBoxpanda.Text = panda
        TextBoxlemon.Text = lemon
        TextBoxformula1.Text = formula1



    End Sub

    Private Sub Buttoncarro1_Click(sender As Object, e As EventArgs) Handles Buttoncarro1.Click
        dinheiro = dinheiro - panda
        MsgBox("Adquiriu um Fiat Panda : -" & panda & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncarro2_Click(sender As Object, e As EventArgs) Handles Buttoncarro2.Click
        dinheiro = dinheiro - lemon
        MsgBox("Adquiriu um Lemon Car : -" & lemon & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncarro3_Click(sender As Object, e As EventArgs) Handles Buttoncarro3.Click
        dinheiro = dinheiro - autocarro
        MsgBox("Adquiriu um Autocarro : -" & autocarro & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncarro4_Click(sender As Object, e As EventArgs) Handles Buttoncarro4.Click
        dinheiro = dinheiro - formula1
        MsgBox("Adquiriu um carro de Formula1 : -" & formula1 & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub
End Class