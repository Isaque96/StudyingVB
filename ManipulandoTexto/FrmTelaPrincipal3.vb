Public Class FrmTelaPrincipal3
    Dim listaDeCursos As String

    Public Sub New()
        InitializeComponent()
        LblPrj3.Text = "3 - Manipulando Textos"
        BtnClickHere.Text = "CLIQUE PARA VER OS RESULTADOS"
        BtnChar.Text = "CLIQUE PARA OBTER O CHAR"
        LblCurso.Text = "Digite o seu Curso Preferido"
        BtnAdicionar.Text = "Adicione à sua Lista"
        BtnMostraLista.Text = "Mostra a Lista de Cursos"
        BtnGuardarVariaveis.Text = "Clique Aqui"
        Me.Text = "Manipulando Textos"
    End Sub

    Private Sub BtnClickHere_Click(sender As Object, e As EventArgs) Handles BtnClickHere.Click
        Dim primeira As Char = "a"
        MsgBox("O caracter da Variável Primeira Letra é: " + primeira)

        Dim segunda As Char = Chr(65)
        MsgBox("O caracter de Número 65 da Variável Segunda Letra é: " + segunda)

        Dim numeroChar As Integer
        numeroChar = 65
        Dim terceira As Char = Chr(numeroChar)

        numeroChar += 1
        Dim quarta As Char = Chr(numeroChar)

        MsgBox("O caracter de Número 65 da Variável Terceira Letra é: " + terceira +
               " e o Número 66 da Variável Quarta Letra é: " + quarta)
    End Sub

    Private Sub BtnChar_Click(sender As Object, e As EventArgs) Handles BtnChar.Click
        Dim valorChar As Integer = Val(TxtNumeroChar.Text)
        Dim quinta As Char = Chr(valorChar)

        MsgBox("O Caracter para o Número " + valorChar.ToString() + " é " + quinta)
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        Dim cursoDigitado As String = TxtCurso.Text
        listaDeCursos += cursoDigitado + vbCrLf
        TxtListaDeCursos.Text = listaDeCursos
    End Sub

    Private Sub BtnMostraLista_Click(sender As Object, e As EventArgs) Handles BtnMostraLista.Click
        MsgBox(listaDeCursos)
    End Sub

    Private Sub BtnGuardarVariaveis_Click(sender As Object, e As EventArgs) Handles BtnGuardarVariaveis.Click
        Dim idade As Integer = 32
        Dim idadeAlguem As Integer

        idadeAlguem = idade

        MsgBox("Idade é Igual á: " + idade.ToString() + " Idade de Alguém é: " + idadeAlguem.ToString())

        idade = 20

        MsgBox("Idade é Igual á: " + idade.ToString() + " Idade de Alguém é: " + idadeAlguem.ToString())
    End Sub
End Class
