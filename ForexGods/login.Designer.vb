<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxDinheiro = New System.Windows.Forms.TextBox()
        Me.TextBoxLocalização = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefone = New System.Windows.Forms.TextBox()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.Labeldinheiro = New System.Windows.Forms.Label()
        Me.Labellocalizacao = New System.Windows.Forms.Label()
        Me.Labeltelefone = New System.Windows.Forms.Label()
        Me.Labelnome = New System.Windows.Forms.Label()
        Me.labellogin = New System.Windows.Forms.Label()
        Me.ButtonComecar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.TextBoxDinheiro)
        Me.Panel1.Controls.Add(Me.TextBoxLocalização)
        Me.Panel1.Controls.Add(Me.TextBoxTelefone)
        Me.Panel1.Controls.Add(Me.TextBoxNome)
        Me.Panel1.Controls.Add(Me.Labeldinheiro)
        Me.Panel1.Controls.Add(Me.Labellocalizacao)
        Me.Panel1.Controls.Add(Me.Labeltelefone)
        Me.Panel1.Controls.Add(Me.Labelnome)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(62, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 170)
        Me.Panel1.TabIndex = 0
        '
        'TextBoxDinheiro
        '
        Me.TextBoxDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDinheiro.Location = New System.Drawing.Point(238, 125)
        Me.TextBoxDinheiro.Name = "TextBoxDinheiro"
        Me.TextBoxDinheiro.Size = New System.Drawing.Size(234, 31)
        Me.TextBoxDinheiro.TabIndex = 8
        '
        'TextBoxLocalização
        '
        Me.TextBoxLocalização.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLocalização.Location = New System.Drawing.Point(238, 88)
        Me.TextBoxLocalização.Name = "TextBoxLocalização"
        Me.TextBoxLocalização.Size = New System.Drawing.Size(234, 31)
        Me.TextBoxLocalização.TabIndex = 7
        '
        'TextBoxTelefone
        '
        Me.TextBoxTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefone.Location = New System.Drawing.Point(238, 51)
        Me.TextBoxTelefone.Name = "TextBoxTelefone"
        Me.TextBoxTelefone.Size = New System.Drawing.Size(234, 31)
        Me.TextBoxTelefone.TabIndex = 6
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNome.Location = New System.Drawing.Point(238, 16)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(234, 31)
        Me.TextBoxNome.TabIndex = 5
        '
        'Labeldinheiro
        '
        Me.Labeldinheiro.AutoSize = True
        Me.Labeldinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldinheiro.Location = New System.Drawing.Point(17, 119)
        Me.Labeldinheiro.Name = "Labeldinheiro"
        Me.Labeldinheiro.Size = New System.Drawing.Size(154, 37)
        Me.Labeldinheiro.TabIndex = 4
        Me.Labeldinheiro.Text = "Dinheiro "
        '
        'Labellocalizacao
        '
        Me.Labellocalizacao.AutoSize = True
        Me.Labellocalizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labellocalizacao.Location = New System.Drawing.Point(17, 82)
        Me.Labellocalizacao.Name = "Labellocalizacao"
        Me.Labellocalizacao.Size = New System.Drawing.Size(198, 37)
        Me.Labellocalizacao.TabIndex = 3
        Me.Labellocalizacao.Text = "Localização"
        '
        'Labeltelefone
        '
        Me.Labeltelefone.AutoSize = True
        Me.Labeltelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltelefone.Location = New System.Drawing.Point(17, 45)
        Me.Labeltelefone.Name = "Labeltelefone"
        Me.Labeltelefone.Size = New System.Drawing.Size(148, 37)
        Me.Labeltelefone.TabIndex = 2
        Me.Labeltelefone.Text = "Telefone"
        '
        'Labelnome
        '
        Me.Labelnome.AutoSize = True
        Me.Labelnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnome.Location = New System.Drawing.Point(17, 13)
        Me.Labelnome.Name = "Labelnome"
        Me.Labelnome.Size = New System.Drawing.Size(107, 37)
        Me.Labelnome.TabIndex = 1
        Me.Labelnome.Text = "Nome"
        '
        'labellogin
        '
        Me.labellogin.AutoSize = True
        Me.labellogin.BackColor = System.Drawing.Color.Red
        Me.labellogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labellogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labellogin.Location = New System.Drawing.Point(-7, 0)
        Me.labellogin.Name = "labellogin"
        Me.labellogin.Size = New System.Drawing.Size(101, 37)
        Me.labellogin.TabIndex = 0
        Me.labellogin.Text = "Login"
        '
        'ButtonComecar
        '
        Me.ButtonComecar.BackColor = System.Drawing.Color.Red
        Me.ButtonComecar.Enabled = False
        Me.ButtonComecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonComecar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonComecar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonComecar.Location = New System.Drawing.Point(62, 258)
        Me.ButtonComecar.Name = "ButtonComecar"
        Me.ButtonComecar.Size = New System.Drawing.Size(171, 49)
        Me.ButtonComecar.TabIndex = 1
        Me.ButtonComecar.Text = "Começar"
        Me.ButtonComecar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Controls.Add(Me.labellogin)
        Me.Panel2.Location = New System.Drawing.Point(62, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 38)
        Me.Panel2.TabIndex = 2
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Red
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(896, 619)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(356, 50)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ForexGods.My.Resources.Resources.forexgods
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ButtonComecar)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labellogin As Label
    Friend WithEvents Labeldinheiro As Label
    Friend WithEvents Labellocalizacao As Label
    Friend WithEvents Labeltelefone As Label
    Friend WithEvents Labelnome As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents TextBoxDinheiro As TextBox
    Friend WithEvents TextBoxLocalização As TextBox
    Friend WithEvents TextBoxTelefone As TextBox
    Friend WithEvents ButtonComecar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSair As Button
End Class
