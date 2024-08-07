
Public Class Perfil

    Private Sub fxgods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        qp = qp + 1
        FRMprimcipal.Hide()
        TextBoxnome.Text = nome
        TextBoxtelefone.Text = telefone
        TextBoxlocalização.Text = localizcao
        TextBoxDinheiro.Text = dinheiro
        TextBoxcohecimento.Text = conhecimento
        TextBoxqp.Text = qp
        TextBoxqf.Text = qf
        TextBoxqc.Text = qc
        TextBoxql.Text = ql
        TextBoxqs.Text = qs
        TextBoxqi.Text = qi
        TextBoxqcasino.Text = qcasino

        If dinheiro < 10 Then xp = 1
        If dinheiro < 100 Then xp = 2
        If dinheiro < 1000 Then xp = 3
        If dinheiro < 10000 Then xp = 4
        If dinheiro < 100000 Then xp = 5
        If dinheiro < 1000000 Then xp = 6
        If dinheiro < 10000000 Then xp = 7
        If dinheiro < 100000000 Then xp = 8
        If dinheiro < 100000000 Then xp = 9
        If dinheiro >= 100000000 Then xp = 10
        TextBoxxp.Text = xp
    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
        FRMprimcipal.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PáginaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaPrincipalToolStripMenuItem.Click

    End Sub

    Private Sub ForexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForexToolStripMenuItem.Click
        Me.Close()
        forex.Show()



    End Sub

    Private Sub EnsinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnsinoToolStripMenuItem.Click
        Me.Close()
        conheciento.Show()

    End Sub

    Private Sub LojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LojaToolStripMenuItem.Click

    End Sub

    Private Sub LojaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LojaToolStripMenuItem1.Click
        Me.Close()
        loja.Show()

    End Sub

    Private Sub StandAutomóvelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandAutomóvelToolStripMenuItem.Click
        Me.Close()
        Stand.Show()
    End Sub

    Private Sub ImobiliárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImobiliárioToolStripMenuItem.Click
        Me.Close()
        imobiliario.Show()
    End Sub

    Private Sub CasinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasinoToolStripMenuItem.Click
        Me.Close()
        casino.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxcohecimento.TextChanged

    End Sub
End Class