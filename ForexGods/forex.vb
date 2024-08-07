Public Class forex

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
        FRMprimcipal.Show()
    End Sub

    Private Sub PáginaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaPrincipalToolStripMenuItem.Click
        Me.Close()
        Perfil.Show()


    End Sub

    Private Sub EnsinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnsinoToolStripMenuItem.Click
        Me.Close()
        conheciento.Show()
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

    Private Sub forex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qf = qf + 1
        TextBoxqdolar.Text = qdolar
        TextBoxqethereum.Text = qethereum
        TextBoxqdodgecoin.Text = qdodgecoin
        TextBoxqbitcoin.Text = qbitcoin
        TextBoxqclcoin.Text = qclcoin
        TextBoxqescudo.Text = qescudo
        vvendadolar = CInt(Int((10 * Rnd()) + 1))
        vcompradolar = CInt(Int((10 * Rnd()) + 1))
        vvendaethereum = CInt(Int((100 * Rnd()) + 10))
        vcompraethereum = CInt(Int((100 * Rnd()) + 10))
        vvendadodgecoin = CInt(Int((1000 * Rnd()) + 100))
        vcompradodgecoin = CInt(Int((1000 * Rnd()) + 100))
        vvendabitcoin = CInt(Int((100000 * Rnd()) + 10000))
        vcomprabitcoin = CInt(Int((100000 * Rnd()) + 10000))
        vvendaclcoin = CInt(Int((1000000 * Rnd()) + 100000))
        vcompraclcoin = CInt(Int((1000000 * Rnd()) + 100000))
        vvendaescudo = CInt(Int((10000000 * Rnd()) + 1000000))
        vcompraescudo = CInt(Int((10000000 * Rnd()) + 1000000))
        valorvendadolar.Text = vvendadolar
        valorcompradolar.Text = vcompradolar
        valorvendaethereum.Text = vvendaethereum
        valorcompraethereum.Text = vcompraethereum
        valorcompradodgecoin.Text = vcompradodgecoin
        valorvendadodgecoin.Text = vvendadodgecoin
        valorvendabitcoin.Text = vvendabitcoin
        valorcomprabitcoin.Text = vcomprabitcoin
        valorcompraclcoin.Text = vcomprabitcoin
        valorvendaclcoin.Text = vvendaclcoin
        valorcompraescudo.Text = vcompraescudo
        valorvendaescudo.Text = vvendaescudo

        If qdolar >= 1 Then Buttonvenderdolar.Enabled = True
        If qethereum >= 1 Then ButtonvenderEthereum.Enabled = True
        If qdodgecoin >= 1 Then Buttonvenderdodgecoin.Enabled = True
        If qbitcoin >= 1 Then Buttonvenderbitcoin.Enabled = True
        If qclcoin >= 1 Then Buttonvenderclcoin.Enabled = True
        If qescudo >= 1 Then Buttonvenderescudo.Enabled = True

        If conhecimento >= 1 Then GroupBoxdolar.Enabled = True
        If conhecimento >= 2 Then GroupBoxethereum.Enabled = True And GroupBoxdolar.Enabled = True
        If conhecimento >= 3 Then GroupBoxdodgecoin.Enabled = True And GroupBoxethereum.Enabled = True And GroupBoxdolar.Enabled = True
        If conhecimento >= 4 Then GroupBoxbitcoin.Enabled = True And GroupBoxdodgecoin.Enabled = True And GroupBoxethereum.Enabled = True And GroupBoxdolar.Enabled = True
        If conhecimento >= 5 Then GroupBoxclcoin.Enabled = True And GroupBoxbitcoin.Enabled = True And GroupBoxdodgecoin.Enabled = True And GroupBoxethereum.Enabled = True And GroupBoxdolar.Enabled = True
        If conhecimento >= 6 Then GroupBoxEscudo.Enabled = True And GroupBoxclcoin.Enabled = True And GroupBoxbitcoin.Enabled = True And GroupBoxdodgecoin.Enabled = True And GroupBoxethereum.Enabled = True And GroupBoxdolar.Enabled = True



    End Sub

    Private Sub valorcompradodgecoin_TextChanged(sender As Object, e As EventArgs) Handles valorcompradodgecoin.TextChanged

    End Sub

    Private Sub TextBoxqdolar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxqdolar.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador = Second(TimeOfDay)
        vvendadolar = CInt(Int((10 * Rnd()) + 1))
        vcompradolar = CInt(Int((10 * Rnd()) + 1))
        vvendaethereum = CInt(Int((100 * Rnd()) + 10))
        vcompraethereum = CInt(Int((100 * Rnd()) + 10))
        vvendadodgecoin = CInt(Int((1000 * Rnd()) + 100))
        vcompradodgecoin = CInt(Int((1000 * Rnd()) + 100))
        vvendabitcoin = CInt(Int((100000 * Rnd()) + 10000))
        vcomprabitcoin = CInt(Int((100000 * Rnd()) + 10000))
        vvendaclcoin = CInt(Int((1000000 * Rnd()) + 100000))
        vcompraclcoin = CInt(Int((1000000 * Rnd()) + 100000))
        vvendaescudo = CInt(Int((10000000 * Rnd()) + 1000000))
        vcompraescudo = CInt(Int((10000000 * Rnd()) + 1000000))
        valorvendadolar.Text = vvendadolar
        valorcompradolar.Text = vcompradolar
        valorvendaethereum.Text = vvendaethereum
        valorcompraethereum.Text = vcompraethereum
        valorcompradodgecoin.Text = vcompradodgecoin
        valorvendadodgecoin.Text = vvendadodgecoin
        valorvendabitcoin.Text = vvendabitcoin
        valorcomprabitcoin.Text = vcomprabitcoin
        valorcompraclcoin.Text = vcomprabitcoin
        valorvendaclcoin.Text = vvendaclcoin
        valorcompraescudo.Text = vcompraescudo
        valorvendaescudo.Text = vvendaescudo


    End Sub

    Private Sub Buttoncomprardolar_Click(sender As Object, e As EventArgs) Handles Buttoncomprardolar.Click
        dinheiro = dinheiro - vcompradolar
        qdolar = qdolar + 1
        TextBoxqdolar.Text = qdolar
        Buttonvenderdolar.Enabled = True
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub ButtoncomprarEthereum_Click(sender As Object, e As EventArgs) Handles ButtoncomprarEthereum.Click
        dinheiro = dinheiro - vcompraethereum
        qethereum = qethereum + 1
        TextBoxqethereum.Text = qethereum
        ButtonvenderEthereum.Enabled = True
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncomprardodgecoing_Click(sender As Object, e As EventArgs) Handles Buttoncomprardodgecoing.Click
        dinheiro = dinheiro - vcompradodgecoin
        qdodgecoin = qdodgecoin + 1
        TextBoxqdodgecoin.Text = qdodgecoin
        Buttonvenderdodgecoin.Enabled = True
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncomprarbitcoin_Click(sender As Object, e As EventArgs) Handles Buttoncomprarbitcoin.Click
        dinheiro = dinheiro - vcomprabitcoin
        qbitcoin = qbitcoin + 1
        TextBoxqbitcoin.Text = qbitcoin
        Buttonvenderbitcoin.Enabled = True
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncomprarclcoin_Click(sender As Object, e As EventArgs) Handles Buttoncomprarclcoin.Click
        dinheiro = dinheiro - vcompraclcoin
        qclcoin = qclcoin + 1
        TextBoxqclcoin.Text = qclcoin
        Buttonvenderclcoin.Enabled = True
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncomprarescudo_Click(sender As Object, e As EventArgs) Handles Buttoncomprarescudo.Click
        dinheiro = dinheiro - vcompraescudo
        qescudo = qescudo + 1
        TextBoxqescudo.Text = qescudo
        Buttonvenderescudo.Enabled = True
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonvenderdolar_Click(sender As Object, e As EventArgs) Handles Buttonvenderdolar.Click
        dinheiro = dinheiro + vvendadolar
        qdolar = qdolar - 1
        TextBoxqdolar.Text = qdolar
        If qdolar <= 0 Then Buttonvenderdolar.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub ButtonvenderEthereum_Click(sender As Object, e As EventArgs) Handles ButtonvenderEthereum.Click
        dinheiro = dinheiro + vvendaethereum
        qethereum = qethereum - 1
        TextBoxqethereum.Text = qethereum
        If qethereum <= 0 Then ButtonvenderEthereum.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonvenderdodgecoing_Click(sender As Object, e As EventArgs) Handles Buttonvenderdodgecoin.Click
        dinheiro = dinheiro + vvendadodgecoin
        qdodgecoin = qdodgecoin - 1
        TextBoxqdodgecoin.Text = qdodgecoin
        If qdodgecoin <= 0 Then Buttonvenderdodgecoin.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonvenderbitcoin_Click(sender As Object, e As EventArgs) Handles Buttonvenderbitcoin.Click
        dinheiro = dinheiro + vvendabitcoin
        qbitcoin = qbitcoin - 1
        TextBoxqbitcoin.Text = qbitcoin
        If qbitcoin <= 0 Then Buttonvenderbitcoin.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonvenderclcoin_Click(sender As Object, e As EventArgs) Handles Buttonvenderclcoin.Click
        dinheiro = dinheiro + vvendaclcoin
        qclcoin = qclcoin - 1
        TextBoxqclcoin.Text = qclcoin
        If qclcoin <= 0 Then Buttonvenderclcoin.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonvenderescudo_Click(sender As Object, e As EventArgs) Handles Buttonvenderescudo.Click
        dinheiro = dinheiro + vvendaescudo
        qescudo = qescudo - 1
        TextBoxqescudo.Text = qescudo
        If qescudo <= 0 Then Buttonvenderescudo.Enabled = False
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub
End Class