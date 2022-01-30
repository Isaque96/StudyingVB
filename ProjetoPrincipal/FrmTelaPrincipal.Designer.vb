<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Btn5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn4, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(273, 277)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Btn1
        '
        Me.Btn1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn1.Location = New System.Drawing.Point(49, 16)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(174, 23)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Button1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn2.Location = New System.Drawing.Point(49, 71)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(174, 23)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "Button2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn3.Location = New System.Drawing.Point(49, 126)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(174, 23)
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "Button3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn4.Location = New System.Drawing.Point(49, 181)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(174, 23)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "Button4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn5.Location = New System.Drawing.Point(49, 237)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(174, 23)
        Me.Btn5.TabIndex = 4
        Me.Btn5.Text = "Button5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'FrmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 277)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmTelaPrincipal"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn4 As Button
End Class
