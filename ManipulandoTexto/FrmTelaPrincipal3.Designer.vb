<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTelaPrincipal3
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
        Me.BtnClickHere = New System.Windows.Forms.Button()
        Me.LblPrj3 = New System.Windows.Forms.Label()
        Me.BtnChar = New System.Windows.Forms.Button()
        Me.TxtNumeroChar = New System.Windows.Forms.TextBox()
        Me.LblCurso = New System.Windows.Forms.Label()
        Me.TxtCurso = New System.Windows.Forms.TextBox()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.TxtListaDeCursos = New System.Windows.Forms.TextBox()
        Me.BtnMostraLista = New System.Windows.Forms.Button()
        Me.BtnGuardarVariaveis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClickHere
        '
        Me.BtnClickHere.Location = New System.Drawing.Point(12, 65)
        Me.BtnClickHere.Name = "BtnClickHere"
        Me.BtnClickHere.Size = New System.Drawing.Size(254, 64)
        Me.BtnClickHere.TabIndex = 0
        Me.BtnClickHere.Text = "Clique AQUI"
        Me.BtnClickHere.UseVisualStyleBackColor = True
        '
        'LblPrj3
        '
        Me.LblPrj3.AutoSize = True
        Me.LblPrj3.Location = New System.Drawing.Point(93, 9)
        Me.LblPrj3.Name = "LblPrj3"
        Me.LblPrj3.Size = New System.Drawing.Size(95, 13)
        Me.LblPrj3.TabIndex = 1
        Me.LblPrj3.Text = "1 - Primeiro Projeto"
        '
        'BtnChar
        '
        Me.BtnChar.Location = New System.Drawing.Point(364, 65)
        Me.BtnChar.Name = "BtnChar"
        Me.BtnChar.Size = New System.Drawing.Size(184, 23)
        Me.BtnChar.TabIndex = 2
        Me.BtnChar.Text = "Button1"
        Me.BtnChar.UseVisualStyleBackColor = True
        '
        'TxtNumeroChar
        '
        Me.TxtNumeroChar.Location = New System.Drawing.Point(401, 39)
        Me.TxtNumeroChar.Name = "TxtNumeroChar"
        Me.TxtNumeroChar.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumeroChar.TabIndex = 3
        '
        'LblCurso
        '
        Me.LblCurso.AutoSize = True
        Me.LblCurso.Location = New System.Drawing.Point(13, 173)
        Me.LblCurso.Name = "LblCurso"
        Me.LblCurso.Size = New System.Drawing.Size(39, 13)
        Me.LblCurso.TabIndex = 4
        Me.LblCurso.Text = "Label1"
        '
        'TxtCurso
        '
        Me.TxtCurso.Location = New System.Drawing.Point(12, 200)
        Me.TxtCurso.Name = "TxtCurso"
        Me.TxtCurso.Size = New System.Drawing.Size(254, 20)
        Me.TxtCurso.TabIndex = 5
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Location = New System.Drawing.Point(305, 198)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(243, 23)
        Me.BtnAdicionar.TabIndex = 6
        Me.BtnAdicionar.Text = "Button1"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'TxtListaDeCursos
        '
        Me.TxtListaDeCursos.Location = New System.Drawing.Point(12, 227)
        Me.TxtListaDeCursos.Multiline = True
        Me.TxtListaDeCursos.Name = "TxtListaDeCursos"
        Me.TxtListaDeCursos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtListaDeCursos.Size = New System.Drawing.Size(536, 131)
        Me.TxtListaDeCursos.TabIndex = 7
        '
        'BtnMostraLista
        '
        Me.BtnMostraLista.Location = New System.Drawing.Point(305, 106)
        Me.BtnMostraLista.Name = "BtnMostraLista"
        Me.BtnMostraLista.Size = New System.Drawing.Size(243, 23)
        Me.BtnMostraLista.TabIndex = 8
        Me.BtnMostraLista.Text = "Button1"
        Me.BtnMostraLista.UseVisualStyleBackColor = True
        '
        'BtnGuardarVariaveis
        '
        Me.BtnGuardarVariaveis.Location = New System.Drawing.Point(305, 135)
        Me.BtnGuardarVariaveis.Name = "BtnGuardarVariaveis"
        Me.BtnGuardarVariaveis.Size = New System.Drawing.Size(243, 23)
        Me.BtnGuardarVariaveis.TabIndex = 9
        Me.BtnGuardarVariaveis.Text = "Button1"
        Me.BtnGuardarVariaveis.UseVisualStyleBackColor = True
        '
        'FrmTelaPrincipal3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 370)
        Me.Controls.Add(Me.BtnGuardarVariaveis)
        Me.Controls.Add(Me.BtnMostraLista)
        Me.Controls.Add(Me.TxtListaDeCursos)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.TxtCurso)
        Me.Controls.Add(Me.LblCurso)
        Me.Controls.Add(Me.TxtNumeroChar)
        Me.Controls.Add(Me.BtnChar)
        Me.Controls.Add(Me.LblPrj3)
        Me.Controls.Add(Me.BtnClickHere)
        Me.Name = "FrmTelaPrincipal3"
        Me.Text = "Aplicação Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClickHere As Button
    Friend WithEvents LblPrj3 As Label
    Friend WithEvents BtnChar As Button
    Friend WithEvents TxtNumeroChar As TextBox
    Friend WithEvents LblCurso As Label
    Friend WithEvents TxtCurso As TextBox
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TxtListaDeCursos As TextBox
    Friend WithEvents BtnMostraLista As Button
    Friend WithEvents BtnGuardarVariaveis As Button
End Class
