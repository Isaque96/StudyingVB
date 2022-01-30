<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTelaPrincipal2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnNumerosInteiros = New System.Windows.Forms.Button()
        Me.LblPrj2 = New System.Windows.Forms.Label()
        Me.BtnPontoFlutuantes = New System.Windows.Forms.Button()
        Me.BtnConversaoNumeros = New System.Windows.Forms.Button()
        Me.TxtNumerador = New System.Windows.Forms.TextBox()
        Me.TxtDenominador = New System.Windows.Forms.TextBox()
        Me.BtnResultado = New System.Windows.Forms.Button()
        Me.TxtDouble = New System.Windows.Forms.TextBox()
        Me.TxtDecimal = New System.Windows.Forms.TextBox()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.LblDouble = New System.Windows.Forms.Label()
        Me.LblDecimal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnNumerosInteiros
        '
        Me.BtnNumerosInteiros.Location = New System.Drawing.Point(12, 50)
        Me.BtnNumerosInteiros.Name = "BtnNumerosInteiros"
        Me.BtnNumerosInteiros.Size = New System.Drawing.Size(160, 29)
        Me.BtnNumerosInteiros.TabIndex = 0
        Me.BtnNumerosInteiros.Text = "Exemplos Números Inteiros"
        Me.BtnNumerosInteiros.UseVisualStyleBackColor = True
        '
        'LblPrj2
        '
        Me.LblPrj2.AutoSize = True
        Me.LblPrj2.Location = New System.Drawing.Point(191, 9)
        Me.LblPrj2.Name = "LblPrj2"
        Me.LblPrj2.Size = New System.Drawing.Size(104, 13)
        Me.LblPrj2.TabIndex = 1
        Me.LblPrj2.Text = "2 - Criando Variáveis"
        '
        'BtnPontoFlutuantes
        '
        Me.BtnPontoFlutuantes.Location = New System.Drawing.Point(12, 85)
        Me.BtnPontoFlutuantes.Name = "BtnPontoFlutuantes"
        Me.BtnPontoFlutuantes.Size = New System.Drawing.Size(202, 29)
        Me.BtnPontoFlutuantes.TabIndex = 2
        Me.BtnPontoFlutuantes.Text = "Exemplos de Números Fracionados"
        Me.BtnPontoFlutuantes.UseVisualStyleBackColor = True
        '
        'BtnConversaoNumeros
        '
        Me.BtnConversaoNumeros.Location = New System.Drawing.Point(12, 120)
        Me.BtnConversaoNumeros.Name = "BtnConversaoNumeros"
        Me.BtnConversaoNumeros.Size = New System.Drawing.Size(202, 29)
        Me.BtnConversaoNumeros.TabIndex = 3
        Me.BtnConversaoNumeros.Text = "Exemplos de Conversão de Números"
        Me.BtnConversaoNumeros.UseVisualStyleBackColor = True
        '
        'TxtNumerador
        '
        Me.TxtNumerador.Location = New System.Drawing.Point(333, 50)
        Me.TxtNumerador.Name = "TxtNumerador"
        Me.TxtNumerador.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumerador.TabIndex = 4
        '
        'TxtDenominador
        '
        Me.TxtDenominador.Location = New System.Drawing.Point(333, 76)
        Me.TxtDenominador.Name = "TxtDenominador"
        Me.TxtDenominador.Size = New System.Drawing.Size(100, 20)
        Me.TxtDenominador.TabIndex = 5
        '
        'BtnResultado
        '
        Me.BtnResultado.Location = New System.Drawing.Point(333, 102)
        Me.BtnResultado.Name = "BtnResultado"
        Me.BtnResultado.Size = New System.Drawing.Size(100, 23)
        Me.BtnResultado.TabIndex = 6
        Me.BtnResultado.Text = "RESULTADO"
        Me.BtnResultado.UseVisualStyleBackColor = True
        '
        'TxtDouble
        '
        Me.TxtDouble.Enabled = False
        Me.TxtDouble.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDouble.Location = New System.Drawing.Point(127, 199)
        Me.TxtDouble.Name = "TxtDouble"
        Me.TxtDouble.Size = New System.Drawing.Size(306, 20)
        Me.TxtDouble.TabIndex = 7
        '
        'TxtDecimal
        '
        Me.TxtDecimal.Enabled = False
        Me.TxtDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDecimal.Location = New System.Drawing.Point(127, 225)
        Me.TxtDecimal.Name = "TxtDecimal"
        Me.TxtDecimal.Size = New System.Drawing.Size(306, 20)
        Me.TxtDecimal.TabIndex = 8
        '
        'LblResultado
        '
        Me.LblResultado.AutoSize = True
        Me.LblResultado.Location = New System.Drawing.Point(256, 170)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(76, 13)
        Me.LblResultado.TabIndex = 9
        Me.LblResultado.Text = "RESULTADO:"
        '
        'LblDouble
        '
        Me.LblDouble.AutoSize = True
        Me.LblDouble.Location = New System.Drawing.Point(80, 202)
        Me.LblDouble.Name = "LblDouble"
        Me.LblDouble.Size = New System.Drawing.Size(41, 13)
        Me.LblDouble.TabIndex = 10
        Me.LblDouble.Text = "Double"
        '
        'LblDecimal
        '
        Me.LblDecimal.AutoSize = True
        Me.LblDecimal.Location = New System.Drawing.Point(80, 228)
        Me.LblDecimal.Name = "LblDecimal"
        Me.LblDecimal.Size = New System.Drawing.Size(45, 13)
        Me.LblDecimal.TabIndex = 11
        Me.LblDecimal.Text = "Decimal"
        '
        'FrmTelaPrincipal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 264)
        Me.Controls.Add(Me.LblDecimal)
        Me.Controls.Add(Me.LblDouble)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.TxtDecimal)
        Me.Controls.Add(Me.TxtDouble)
        Me.Controls.Add(Me.BtnResultado)
        Me.Controls.Add(Me.TxtDenominador)
        Me.Controls.Add(Me.TxtNumerador)
        Me.Controls.Add(Me.BtnConversaoNumeros)
        Me.Controls.Add(Me.BtnPontoFlutuantes)
        Me.Controls.Add(Me.LblPrj2)
        Me.Controls.Add(Me.BtnNumerosInteiros)
        Me.Name = "FrmTelaPrincipal2"
        Me.Text = "Aplicação Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNumerosInteiros As Button
    Friend WithEvents LblPrj2 As Label
    Friend WithEvents BtnPontoFlutuantes As Button
    Friend WithEvents BtnConversaoNumeros As Button
    Friend WithEvents TxtNumerador As TextBox
    Friend WithEvents TxtDenominador As TextBox
    Friend WithEvents BtnResultado As Button
    Friend WithEvents TxtDouble As TextBox
    Friend WithEvents TxtDecimal As TextBox
    Friend WithEvents LblResultado As Label
    Friend WithEvents LblDouble As Label
    Friend WithEvents LblDecimal As Label
End Class
