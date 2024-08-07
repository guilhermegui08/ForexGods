<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conversor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(conversor))
        Me.textboxHoras = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Labelcélcius = New System.Windows.Forms.Label()
        Me.GroupBoxConverter = New System.Windows.Forms.GroupBox()
        Me.RadiobtnKelvin = New System.Windows.Forms.RadioButton()
        Me.radiobtnfahrenheit = New System.Windows.Forms.RadioButton()
        Me.btnconverter = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.TextBoxmostrar = New System.Windows.Forms.TextBox()
        Me.TextBoxconverter = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxConverter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textboxHoras
        '
        Me.textboxHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxHoras.ForeColor = System.Drawing.Color.DarkRed
        Me.textboxHoras.Location = New System.Drawing.Point(81, 12)
        Me.textboxHoras.Name = "textboxHoras"
        Me.textboxHoras.ReadOnly = True
        Me.textboxHoras.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textboxHoras.Size = New System.Drawing.Size(146, 35)
        Me.textboxHoras.TabIndex = 0
        Me.textboxHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'Labelcélcius
        '
        Me.Labelcélcius.AutoSize = True
        Me.Labelcélcius.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcélcius.Location = New System.Drawing.Point(64, 64)
        Me.Labelcélcius.Name = "Labelcélcius"
        Me.Labelcélcius.Size = New System.Drawing.Size(209, 29)
        Me.Labelcélcius.TabIndex = 1
        Me.Labelcélcius.Text = "Graus em Célcius:"
        '
        'GroupBoxConverter
        '
        Me.GroupBoxConverter.Controls.Add(Me.RadiobtnKelvin)
        Me.GroupBoxConverter.Controls.Add(Me.radiobtnfahrenheit)
        Me.GroupBoxConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxConverter.Location = New System.Drawing.Point(17, 137)
        Me.GroupBoxConverter.Name = "GroupBoxConverter"
        Me.GroupBoxConverter.Size = New System.Drawing.Size(297, 85)
        Me.GroupBoxConverter.TabIndex = 2
        Me.GroupBoxConverter.TabStop = False
        Me.GroupBoxConverter.Text = "Converter para:"
        '
        'RadiobtnKelvin
        '
        Me.RadiobtnKelvin.AutoSize = True
        Me.RadiobtnKelvin.Location = New System.Drawing.Point(174, 33)
        Me.RadiobtnKelvin.Name = "RadiobtnKelvin"
        Me.RadiobtnKelvin.Size = New System.Drawing.Size(97, 33)
        Me.RadiobtnKelvin.TabIndex = 1
        Me.RadiobtnKelvin.TabStop = True
        Me.RadiobtnKelvin.Text = "Kelvin"
        Me.RadiobtnKelvin.UseVisualStyleBackColor = True
        '
        'radiobtnfahrenheit
        '
        Me.radiobtnfahrenheit.AutoSize = True
        Me.radiobtnfahrenheit.Location = New System.Drawing.Point(6, 33)
        Me.radiobtnfahrenheit.Name = "radiobtnfahrenheit"
        Me.radiobtnfahrenheit.Size = New System.Drawing.Size(146, 33)
        Me.radiobtnfahrenheit.TabIndex = 0
        Me.radiobtnfahrenheit.TabStop = True
        Me.radiobtnfahrenheit.Text = "Fahrenheit"
        Me.radiobtnfahrenheit.UseVisualStyleBackColor = True
        '
        'btnconverter
        '
        Me.btnconverter.BackColor = System.Drawing.Color.Navy
        Me.btnconverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconverter.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnconverter.Location = New System.Drawing.Point(58, 240)
        Me.btnconverter.Name = "btnconverter"
        Me.btnconverter.Size = New System.Drawing.Size(184, 39)
        Me.btnconverter.TabIndex = 3
        Me.btnconverter.Text = "Converter"
        Me.btnconverter.UseVisualStyleBackColor = False
        '
        'btnlimpar
        '
        Me.btnlimpar.BackColor = System.Drawing.Color.Navy
        Me.btnlimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnlimpar.Location = New System.Drawing.Point(342, 291)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(134, 39)
        Me.btnlimpar.TabIndex = 4
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Navy
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnSair.Location = New System.Drawing.Point(554, 291)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(134, 39)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'TextBoxmostrar
        '
        Me.TextBoxmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxmostrar.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBoxmostrar.Location = New System.Drawing.Point(17, 295)
        Me.TextBoxmostrar.Name = "TextBoxmostrar"
        Me.TextBoxmostrar.ReadOnly = True
        Me.TextBoxmostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxmostrar.Size = New System.Drawing.Size(297, 35)
        Me.TextBoxmostrar.TabIndex = 6
        '
        'TextBoxconverter
        '
        Me.TextBoxconverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxconverter.Location = New System.Drawing.Point(107, 96)
        Me.TextBoxconverter.Name = "TextBoxconverter"
        Me.TextBoxconverter.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxconverter.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ForexGods.My.Resources.Resources.frio2
        Me.PictureBox1.Location = New System.Drawing.Point(342, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'conversor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 353)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxconverter)
        Me.Controls.Add(Me.TextBoxmostrar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btnconverter)
        Me.Controls.Add(Me.GroupBoxConverter)
        Me.Controls.Add(Me.Labelcélcius)
        Me.Controls.Add(Me.textboxHoras)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "conversor"
        Me.Text = "conversor"
        Me.GroupBoxConverter.ResumeLayout(False)
        Me.GroupBoxConverter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxHoras As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Labelcélcius As Label
    Friend WithEvents GroupBoxConverter As GroupBox
    Friend WithEvents RadiobtnKelvin As RadioButton
    Friend WithEvents radiobtnfahrenheit As RadioButton
    Friend WithEvents btnconverter As Button
    Friend WithEvents btnlimpar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents TextBoxmostrar As TextBox
    Friend WithEvents TextBoxconverter As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
