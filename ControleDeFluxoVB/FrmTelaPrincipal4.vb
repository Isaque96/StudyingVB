Public Class FrmTelaPrincipal4
    Public Sub New()
        InitializeComponent()
        LblPrj4.Text = "4 - Controle de Fluxo"
        BtnClickHere.Text = "Checagem da Permissão de Entrada"
        Me.Text = "Controle de Fluxo"
        RdbSim.Text = "Sim"
        RdbNao.Text = "Não"
        GpbPais.Text = "Acompanhado dos Pais?"
    End Sub

    Private Sub BtnClickHere_Click(sender As Object, e As EventArgs) Handles BtnClickHere.Click
        Dim idade As Integer
        idade = TxbIdade.Text

        Dim acompanhadaPais As String

        If RdbSim.Checked Then
            acompanhadaPais = "S"
        Else
            acompanhadaPais = "N"
        End If

        Dim podeEntrar As Boolean = (idade >= 18) Or (acompanhadaPais = "S" And idade >= 16)
        Dim naoPodeEntrar As Boolean = (acompanhadaPais = "N" And idade >= 16) Or (idade < 16)

        Dim mensagemAdicional As String = String.Empty
        If acompanhadaPais = "S" Then
            mensagemAdicional = "Está acompanhado"
        Else
            mensagemAdicional = "Não está acompanhado"
        End If

        If podeEntrar Then
            TxbResultado.ForeColor = Color.Green
            TxbResultado.Text = "Permissão para Assistir a peça Concedida, " + mensagemAdicional
        ElseIf naoPodeEntrar Then
            TxbResultado.ForeColor = Color.Red
            TxbResultado.Text = "Sem Permissão para Entrar, " + mensagemAdicional
        End If
    End Sub
End Class
