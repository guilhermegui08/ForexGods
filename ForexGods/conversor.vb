Public Class conversor
    Private Sub textboxHoras_TextChanged(sender As Object, e As EventArgs) Handles textboxHoras.TextChanged


    End Sub

    Private Sub TextBoxmostrar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxmostrar.TextChanged
        TextBoxmostrar.ReadOnly = True
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Dim Msg, Style, Title, Help, Ctxt, Response, MyString
        Msg = "❓ Tem a certeza que deseja sair?"

        Title = "AVISO"



        Response = MsgBox(Msg, MsgBoxStyle.YesNo, Title)
        If Response = vbYes Then
            Me.Close()
        Else
            MyString = "No"
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub conversor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        TextBoxmostrar.AutoSize = True

        PictureBox1.Image = (ForexGods.My.Resources.Resources.globofrio)
        btnconverter.Enabled = False

    End Sub

    Private Sub Labelcélcius_Click(sender As Object, e As EventArgs) Handles Labelcélcius.Click

    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        TextBoxconverter.Text = ""
        TextBoxmostrar.Text = ""
        radiobtnfahrenheit.Checked = False
        RadiobtnKelvin.Checked = False
        PictureBox1.Image = (ForexGods.My.Resources.Resources.globofrio)
    End Sub

    Private Sub btnconverter_Click(sender As Object, e As EventArgs) Handles btnconverter.Click
        If radiobtnfahrenheit.Checked = False And RadiobtnKelvin.Checked = False Then MsgBox("Deve escolher uma das opções!!!!", , " AVISO")
        If radiobtnfahrenheit.Checked = False And RadiobtnKelvin.Checked = False Then PictureBox1.Image = (ForexGods.My.Resources.Resources.globofrio)
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text < 1 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.frio)
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text < 1 Then MsgBox("❌ Está muito frio! Não saia de casa!!", , "Aviso")
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text >= 1 And TextBoxconverter.Text <= 15 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.frio2)
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text >= 1 And TextBoxconverter.Text <= 15 Then MsgBox("ℹ️ Está frio! Agasalhe-se antes de sair!!", , "Aviso")
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text >= 16 And TextBoxconverter.Text <= 24 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.termometro)
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text >= 16 And TextBoxconverter.Text <= 24 Then MsgBox("ℹ️ Está um dia perfeito para sair!!", , "Aviso")
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text >= 25 And TextBoxconverter.Text <= 29 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.termometro2)
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text >= 25 And TextBoxconverter.Text <= 29 Then MsgBox("ℹ️ Está um dia perfeito para sair!!", , "Aviso")
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text > 29 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.termometro2)
        If RadiobtnKelvin.Checked = True And TextBoxconverter.Text > 29 Then MsgBox("❌ Está muito Calor! Nem pense em sair de casa!!", , "Aviso")
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text < 1 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.frio)
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text < 1 Then MsgBox("❌ Está muito frio! Não saia de casa!!", , "Aviso")
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text >= 1 And TextBoxconverter.Text <= 15 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.frio2)
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text >= 1 And TextBoxconverter.Text <= 15 Then MsgBox("ℹ️ Está frio! Agasalhe-se antes de sair!!", , "Aviso")
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text >= 16 And TextBoxconverter.Text <= 24 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.termometro)
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text >= 16 And TextBoxconverter.Text <= 24 Then MsgBox("ℹ️ Está um dia perfeito para sair!!", , "Aviso")
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text >= 25 And TextBoxconverter.Text <= 29 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.termometro2)
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text >= 25 And TextBoxconverter.Text <= 29 Then MsgBox("ℹ️ Está um dia perfeito para sair!!", , "Aviso")
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text > 29 Then PictureBox1.Image = (ForexGods.My.Resources.Resources.termometro2)
        If radiobtnfahrenheit.Checked = True And TextBoxconverter.Text > 29 Then MsgBox("❌ Está muito Calor! Nem pense em sair de casa!!", , "Aviso")
        If radiobtnfahrenheit.Checked = True Then TextBoxmostrar.Text = (TextBoxconverter.Text * 1.8) + 32 & " Fahrenheit"
        If RadiobtnKelvin.Checked = True Then TextBoxmostrar.Text = TextBoxconverter.Text + 273.15 & " Kelvin"

    End Sub

    Private Sub TextBoxconverter_TextChanged(sender As Object, e As EventArgs) Handles TextBoxconverter.TextChanged
        Dim valnum As Integer
        valnum = IsNumeric(TextBoxconverter.Text)
        If valnum = True Then btnconverter.Enabled = True
        If valnum = False Then btnconverter.Enabled = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        textboxHoras.Text = TimeOfDay
    End Sub
End Class