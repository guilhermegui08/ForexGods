Public Class login



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labellogin.Click

    End Sub

    Private Sub Labelnome_Click(sender As Object, e As EventArgs) Handles Labelnome.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNome.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FRMprimcipal.Hide()







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonComecar.Click
        conhecimento = 0
        nome = TextBoxNome.Text
        dinheiro = TextBoxDinheiro.Text
        telefone = TextBoxTelefone.Text
        localizcao = TextBoxLocalização.Text
        qdolar = 0
        qethereum = 0
        qdodgecoin = 0
        qbitcoin = 0
        qclcoin = 0
        qescudo = 0
        vlivro1 = 100
        vlivro2 = 500
        vlivro3 = 1000
        vlivro4 = 1500
        vlivro5 = 5000
        vlivro6 = 50000

        qp = 0
        qf = 0
        qc = 0
        qcasino = 0
        ql = 0
        qs = 0
        qi = 0

        Me.Hide()
        Perfil.Show()
    End Sub

    Private Sub TextBoxDinheiro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDinheiro.TextChanged
        Dim vald As Integer
        vald = IsNumeric(TextBoxDinheiro.Text)
        Dim vall As Integer
        vall = IsNumeric(TextBoxTelefone.Text)

        If vald = True Then ButtonComecar.Enabled = True
        If vall = True Then ButtonComecar.Enabled = True
        If vall = False Then ButtonComecar.Enabled = False
        If vald = False Then ButtonComecar.Enabled = False
    End Sub

    Private Sub TextBoxTelefone_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTelefone.TextChanged
        Dim vald As Integer
        vald = IsNumeric(TextBoxDinheiro.Text)
        Dim vall As Integer
        vall = IsNumeric(TextBoxTelefone.Text)

        If vald = True Then ButtonComecar.Enabled = True
        If vall = True Then ButtonComecar.Enabled = True
        If vall = False Then ButtonComecar.Enabled = False
        If vald = False Then ButtonComecar.Enabled = False
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        FRMprimcipal.Show()
    End Sub
End Class