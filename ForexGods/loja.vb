Public Class loja


    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
        FRMprimcipal.Show()
    End Sub

    Private Sub PáginaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaPrincipalToolStripMenuItem.Click
        Me.Close()
        Perfil.Show()
    End Sub

    Private Sub ForexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForexToolStripMenuItem.Click
        Me.Close()
        forex.Show()
    End Sub

    Private Sub EnsinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnsinoToolStripMenuItem.Click
        Me.Close()
        conheciento.Show()
    End Sub

    Private Sub ImobiliárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImobiliárioToolStripMenuItem.Click
        Me.Close()
        imobiliario.Show()
    End Sub

    Private Sub StandAutomóvelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandAutomóvelToolStripMenuItem.Click
        Me.Close()
        Stand.Show()
    End Sub

    Private Sub CasinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasinoToolStripMenuItem.Click
        Me.Close()
        casino.Show()
    End Sub

    Private Sub loja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ql = ql + 1
        telemovel = 500
        tijolosupreme = 1000
        computador = 1500
        drone = 2000
        impressora = 100
        cafe = 400
        TextBoxtelemovel.Text = telemovel
        TextBoxtijolo.Text = tijolosupreme
        TextBoxcomputador.Text = computador
        TextBoxdrone.Text = 2000
        TextBoximpressora.Text = 100
        TextBoxcafe.Text = 400

    End Sub

    Private Sub Buttontelemovel_Click(sender As Object, e As EventArgs) Handles Buttontelemovel.Click
        dinheiro = dinheiro - telemovel
        MsgBox("Adquiriu um telemovel : -" & telemovel & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttontijolo_Click(sender As Object, e As EventArgs) Handles Buttontijolo.Click
        dinheiro = dinheiro - tijolosupreme
        MsgBox("Adquiriu um Tijolo da Supreme: -" & tijolosupreme & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncomputador_Click(sender As Object, e As EventArgs) Handles Buttoncomputador.Click
        dinheiro = dinheiro - computador
        MsgBox("Adquiriu um computador : -" & computador & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttondrone_Click(sender As Object, e As EventArgs) Handles Buttondrone.Click
        dinheiro = dinheiro - drone
        MsgBox("Adquiriu um Drone : -" & drone & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonimpressora_Click(sender As Object, e As EventArgs) Handles Buttonimpressora.Click
        dinheiro = dinheiro - impressora
        MsgBox("Adquiriu uma Impressora : -" & impressora & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncafe_Click(sender As Object, e As EventArgs) Handles Buttoncafe.Click
        dinheiro = dinheiro - cafe
        MsgBox("Adquiriu uma máquina de café : -" & cafe & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub
End Class