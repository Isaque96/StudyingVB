<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal4
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClickHere = New System.Windows.Forms.Button()
        Me.LblPrj4 = New System.Windows.Forms.Label()
        Me.LblIdade = New System.Windows.Forms.Label()
        Me.TxbIdade = New System.Windows.Forms.TextBox()
        Me.TxbResultado = New System.Windows.Forms.TextBox()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.GpbPais = New System.Windows.Forms.GroupBox()
        Me.RdbSim = New System.Windows.Forms.RadioButton()
        Me.RdbNao = New System.Windows.Forms.RadioButton()
        Me.GpbPais.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClickHere
        '
        Me.BtnClickHere.Location = New System.Drawing.Point(63, 132)
        Me.BtnClickHere.Name = "BtnClickHere"
        Me.BtnClickHere.Size = New System.Drawing.Size(226, 33)
        Me.BtnClickHere.TabIndex = 0
        Me.BtnClickHere.Text = "Clique AQUI"
        Me.BtnClickHere.UseVisualStyleBackColor = True
        '
        'LblPrj4
        '
        Me.LblPrj4.AutoSize = True
        Me.LblPrj4.Location = New System.Drawing.Point(123, 27)
        Me.LblPrj4.Name = "LblPrj4"
        Me.LblPrj4.Size = New System.Drawing.Size(95, 13)
        Me.LblPrj4.TabIndex = 1
        Me.LblPrj4.Text = "1 - Primeiro Projeto"
        '
        'LblIdade
        '
        Me.LblIdade.AutoSize = True
        Me.LblIdade.Location = New System.Drawing.Point(60, 93)
        Me.LblIdade.Name = "LblIdade"
        Me.LblIdade.Size = New System.Drawing.Size(37, 13)
        Me.LblIdade.TabIndex = 2
        Me.LblIdade.Text = "Idade:"
        '
        'TxbIdade
        '
        Me.TxbIdade.Location = New System.Drawing.Point(103, 90)
        Me.TxbIdade.Name = "TxbIdade"
        Me.TxbIdade.Size = New System.Drawing.Size(52, 20)
        Me.TxbIdade.TabIndex = 3
        '
        'TxbResultado
        '
        Me.TxbResultado.Location = New System.Drawing.Point(12, 192)
        Me.TxbResultado.Name = "TxbResultado"
        Me.TxbResultado.Size = New System.Drawing.Size(326, 20)
        Me.TxbResultado.TabIndex = 4
        '
        'LblResultado
        '
        Me.LblResultado.AutoSize = True
        Me.LblResultado.Location = New System.Drawing.Point(63, 173)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(55, 13)
        Me.LblResultado.TabIndex = 5
        Me.LblResultado.Text = "Resultado"
        '
        'GpbPais
        '
        Me.GpbPais.Controls.Add(Me.RdbNao)
        Me.GpbPais.Controls.Add(Me.RdbSim)
        Me.GpbPais.Location = New System.Drawing.Point(161, 54)
        Me.GpbPais.Name = "GpbPais"
        Me.GpbPais.Size = New System.Drawing.Size(159, 72)
        Me.GpbPais.TabIndex = 6
        Me.GpbPais.TabStop = False
        Me.GpbPais.Text = "GroupBox1"
        '
        'RdbSim
        '
        Me.RdbSim.AutoSize = True
        Me.RdbSim.Location = New System.Drawing.Point(7, 20)
        Me.RdbSim.Name = "RdbSim"
        Me.RdbSim.Size = New System.Drawing.Size(90, 17)
        Me.RdbSim.TabIndex = 0
        Me.RdbSim.TabStop = True
        Me.RdbSim.Text = "RadioButton1"
        Me.RdbSim.UseVisualStyleBackColor = True
        '
        'RdbNao
        '
        Me.RdbNao.AutoSize = True
        Me.RdbNao.Location = New System.Drawing.Point(7, 44)
        Me.RdbNao.Name = "RdbNao"
        Me.RdbNao.Size = New System.Drawing.Size(90, 17)
        Me.RdbNao.TabIndex = 1
        Me.RdbNao.TabStop = True
        Me.RdbNao.Text = "RadioButton1"
        Me.RdbNao.UseVisualStyleBackColor = True
        '
        'FrmTelaPrincipal4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 277)
        Me.Controls.Add(Me.GpbPais)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.TxbResultado)
        Me.Controls.Add(Me.TxbIdade)
        Me.Controls.Add(Me.LblIdade)
        Me.Controls.Add(Me.LblPrj4)
        Me.Controls.Add(Me.BtnClickHere)
        Me.Name = "FrmTelaPrincipal4"
        Me.Text = "Aplicação Hello World"
        Me.GpbPais.ResumeLayout(False)
        Me.GpbPais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClickHere As Button
    Friend WithEvents LblPrj4 As Label
    Friend WithEvents LblIdade As Label
    Friend WithEvents TxbIdade As TextBox
    Friend WithEvents TxbResultado As TextBox
    Friend WithEvents LblResultado As Label
    Friend WithEvents GpbPais As GroupBox
    Friend WithEvents RdbSim As RadioButton
    Friend WithEvents RdbNao As RadioButton
End Class
