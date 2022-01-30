Imports ControleDeFluxoVB
Imports CriandoVariaveisVB
Imports LacosDeRepeticaoVB
Imports ManipulandoTexto
Imports PrimeiroProjetoVB

Public Class FrmTelaPrincipal
    Public Sub New()
        InitializeComponent()

        Me.Text = "Projeto Principal"
        Btn1.Text = "1 - Primeiro Projeto"
        Btn2.Text = "2 - Criando Variáveis"
        Btn3.Text = "3 - Manipulando Textos"
        Btn4.Text = "4 - Controle de Fluxo"
        Btn5.Text = "5 - Laços de Repetição"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim form As New FrmTelaPrincipal1
        form.ShowDialog()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim form As New FrmTelaPrincipal2
        form.ShowDialog()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Dim form As New FrmTelaPrincipal3
        form.ShowDialog()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Dim form As New FrmTelaPrincipal4
        form.ShowDialog()
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Dim form As New FrmTelaPrincipal5
        form.ShowDialog()
    End Sub
End Class
