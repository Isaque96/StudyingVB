Public Class FrmTelaPrincipal2
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BtnClickHere_Click(sender As Object, e As EventArgs) Handles BtnNumerosInteiros.Click
        Dim idade As Integer = 12
        MsgBox("O valor da Idade é: " + idade.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        idade *= 5
        MsgBox("O valor da Idade multiplicado por 5 é: " + idade.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        idade += 10
        MsgBox("O valor da Idade multiplicado por 5 e acrescido de 10 é: " + idade.ToString(), MsgBoxStyle.MsgBoxSetForeground)
    End Sub

    Private Sub BtnPontoFlutuantes_Click(sender As Object, e As EventArgs) Handles BtnPontoFlutuantes.Click
        Dim valor As Double = 9.5
        MsgBox("O Variável valor é: " + valor.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        valor = 5 / 2
        MsgBox("O Variável valor é: " + valor.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador
        MsgBox("O Variável valor é: " + valor.ToString(), MsgBoxStyle.MsgBoxSetForeground)
    End Sub

    Private Sub BtnConversaoNumeros_Click(sender As Object, e As EventArgs) Handles BtnConversaoNumeros.Click
        Dim salario As Double
        salario = 1345.45

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O valor do Salário é " + salario.ToString() + " e do Salário Inteiro é " + salarioInteiro.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        Dim salarioGrande As Long
        salarioGrande = 1300000000000000000

        MsgBox("O valor do Salário Grande é " + salarioGrande.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        Dim salarioPequeno As Short
        salarioPequeno = 1

        MsgBox("O valor do Salário Pequeno é " + salarioPequeno.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        Dim salarioMinusculo As SByte
        salarioMinusculo = 10

        MsgBox("O valor do Salário Minúsculo é " + salarioMinusculo.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        Dim valorDouble As Double
        valorDouble = 9.232141241

        MsgBox("O valor da Variável Double é " + valorDouble.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        Dim valorDecimal As Decimal
        valorDecimal = 9.12412591385136

        MsgBox("O valor da Variável Decimal é " + valorDecimal.ToString(), MsgBoxStyle.MsgBoxSetForeground)
    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        Dim numerador As Double
        Dim denominador As Double

        numerador = TxtNumerador.Text
        denominador = TxtDenominador.Text

        Dim resultadoDouble As Double
        resultadoDouble = numerador / denominador

        MsgBox("O Resultado da Divisão do Numerador " + numerador.ToString() + " com o Denominador " _
               + denominador.ToString() + " é(em Double) " + resultadoDouble.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        Dim resultadoDecimal As Decimal
        resultadoDecimal = numerador / denominador

        MsgBox("O Resultado da Divisão do Numerador " + numerador.ToString() + " com o Denominador " _
               + denominador.ToString() + " é(em Decimal) " + resultadoDecimal.ToString(), MsgBoxStyle.MsgBoxSetForeground)

        TxtDouble.Text = resultadoDouble.ToString()
        TxtDecimal.Text = resultadoDecimal.ToString()
    End Sub
End Class
