Public Class FrmTelaPrincipal1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BtnClickHereToShow(sender As Object, e As EventArgs) Handles BtnClickHere.Click
        MsgBox("Olá Mundo!", MsgBoxStyle.MsgBoxHelp, "Mensagem Importante!")
    End Sub
End Class
