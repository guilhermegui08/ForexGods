Public Class imobiliario
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
        FRMprimcipal.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

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

    Private Sub imobiliario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qi = qi + 1
        madeira = 50000
        minecraft = 500000
        arranha = 9999999
        TextBoxmadeira.Text = madeira
        TextBoxminecraft.Text = minecraft
        TextBoxarranha.Text = arranha
    End Sub

    Private Sub Buttoncomprarcasadesantana_Click(sender As Object, e As EventArgs) Handles Buttoncomprarcasadesantana.Click
        dinheiro = dinheiro - madeira
        MsgBox("Adquiriu a propriedade Casa de Santana: -" & madeira & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttoncasaminecraft_Click(sender As Object, e As EventArgs) Handles Buttoncasaminecraft.Click
        dinheiro = dinheiro - minecraft
        MsgBox("Adquiriu a propriedade Casa do Minecraft: -" & minecraft & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub

    Private Sub Buttonarranhaceus_Click(sender As Object, e As EventArgs) Handles Buttonarranhaceus.Click
        dinheiro = dinheiro - arranha
        MsgBox("Adquiriu a propriedade Arranha céus: -" & arranha & " .")
        If dinheiro < 0 Then Me.Close()
        If dinheiro < 0 Then login.Show()
        If dinheiro < 0 Then MsgBox("O jogo acabou, perdeu todo o dinheiro.")
    End Sub
End Class