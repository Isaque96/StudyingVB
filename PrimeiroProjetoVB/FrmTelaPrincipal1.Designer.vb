<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal1
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
        Me.LblPrj1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnClickHere
        '
        Me.BtnClickHere.Location = New System.Drawing.Point(134, 129)
        Me.BtnClickHere.Name = "BtnClickHere"
        Me.BtnClickHere.Size = New System.Drawing.Size(75, 23)
        Me.BtnClickHere.TabIndex = 0
        Me.BtnClickHere.Text = "Clique AQUI"
        Me.BtnClickHere.UseVisualStyleBackColor = True
        '
        'LblPrj1
        '
        Me.LblPrj1.AutoSize = True
        Me.LblPrj1.Location = New System.Drawing.Point(61, 54)
        Me.LblPrj1.Name = "LblPrj1"
        Me.LblPrj1.Size = New System.Drawing.Size(95, 13)
        Me.LblPrj1.TabIndex = 1
        Me.LblPrj1.Text = "1 - Primeiro Projeto"
        '
        'FrmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 311)
        Me.Controls.Add(Me.LblPrj1)
        Me.Controls.Add(Me.BtnClickHere)
        Me.Name = "FrmTelaPrincipal"
        Me.Text = "Aplicação Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClickHere As Button
    Friend WithEvents LblPrj1 As Label
End Class
