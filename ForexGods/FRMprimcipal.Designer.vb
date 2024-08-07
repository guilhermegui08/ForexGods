<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMprimcipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMprimcipal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnForexGods = New System.Windows.Forms.Button()
        Me.btnConversor = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.LabelNome = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(760, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnForexGods
        '
        Me.btnForexGods.BackColor = System.Drawing.Color.Red
        Me.btnForexGods.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForexGods.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForexGods.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnForexGods.Location = New System.Drawing.Point(34, 459)
        Me.btnForexGods.Name = "btnForexGods"
        Me.btnForexGods.Size = New System.Drawing.Size(356, 50)
        Me.btnForexGods.TabIndex = 1
        Me.btnForexGods.Text = "Forex Gods"
        Me.btnForexGods.UseVisualStyleBackColor = False
        '
        'btnConversor
        '
        Me.btnConversor.BackColor = System.Drawing.Color.LawnGreen
        Me.btnConversor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConversor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConversor.Location = New System.Drawing.Point(34, 515)
        Me.btnConversor.Name = "btnConversor"
        Me.btnConversor.Size = New System.Drawing.Size(356, 50)
        Me.btnConversor.TabIndex = 2
        Me.btnConversor.Text = "Conversor de Temperaturas"
        Me.btnConversor.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Red
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(34, 571)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(356, 50)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNome.Location = New System.Drawing.Point(956, 648)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(296, 24)
        Me.LabelNome.TabIndex = 4
        Me.LabelNome.Text = "Guilherme Guilherme nº9 12ºB"
        '
        'FRMprimcipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ForexGods.My.Resources.Resources.forexgods
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnConversor)
        Me.Controls.Add(Me.btnForexGods)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMprimcipal"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnForexGods As Button
    Friend WithEvents btnConversor As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents LabelNome As Label
End Class
