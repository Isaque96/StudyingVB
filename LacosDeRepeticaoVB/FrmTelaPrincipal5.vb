Public Class FrmTelaPrincipal5
    Public Sub New()
        InitializeComponent()
        LblPrj5.Text = "5 - Laços de Repetição"
        Me.Text = "Laços de Repetição"
        LblPrincipal.Text = "Valor Investido"
        LblRendimento.Text = "Juros (%)"
        LblPeriodos.Text = "Periodos"
        BtnWhile.Text = "Calcular Valor usando While"
        BtnFor.Text = "Calcular Valor usando For"
        GrbGrupo1.Text = "Cálculo do Investimento por While e por For"
        GrbGrupo2.Text = "Cálculo do Investimento Anual"
        LblPrincipal2.Text = "Valor Investido"
        LblRendimentos2.Text = "Juros Mensais(%)"
        LblAnos.Text = "Anos Aplicados"
        LblAcrescimoRendimento.Text = "Acréscimo Juros(%)"
        LblLimite.Text = "Limite"
        BtnCalcula.Text = "Efetua Cálculo"
    End Sub

    Private Sub BtnWhile_Click(sender As Object, e As EventArgs) Handles BtnWhile.Click
        TxbExtrato.Text = String.Empty
        Dim investimento As Double = Val(TxbPrincipal.Text)
        Dim rendimento As Double = Val(TxbRendimentos.Text)
        Dim periodos As Integer = Val(TxbPeriodos.Text)
        Dim contador As Integer = 1
        Dim extrato As String = String.Empty

        While contador <= periodos
            investimento += (investimento * (rendimento / 100))
            extrato += "O Saldo do Investimento no mês " + contador.ToString() + " é " + investimento.ToString() + vbCrLf
            contador += 1
        End While
        TxbExtrato.Text = extrato

        ' MsgBox("O Valor do Investimento após " + periodos.ToString() + " meses é: " + investimento.ToString())
    End Sub

    Private Sub BtnFor_Click(sender As Object, e As EventArgs) Handles BtnFor.Click
        TxbExtrato.Text = String.Empty
        Dim investimento As Double = Val(TxbPrincipal.Text)
        Dim rendimento As Double = Val(TxbRendimentos.Text)
        Dim periodos As Integer = Val(TxbPeriodos.Text)
        Dim extrato As String = String.Empty

        For i As Integer = 1 To periodos
            investimento += (investimento * (rendimento / 100))
            extrato += "O Saldo do Investimento no mês " + i.ToString() + " é " + investimento.ToString() + vbCrLf
        Next

        TxbExtrato.Text = extrato
    End Sub

    Private Sub BtnCalcula_Click(sender As Object, e As EventArgs) Handles BtnCalcula.Click
        Dim investimento As Double = Val(TxbPrincipal2.Text)
        Dim rendimento As Double = Val(TxbRendimentos2.Text)
        Dim anos As Integer = Val(TxbAnos.Text)
        Dim acrescimoDosJuros As Double = Val(TxbAcrescimoRendimentos.Text)
        Dim limite As Double = Val(TxbLimite.Text)
        Dim extrato As String = String.Empty
        Dim contadorMeses As Integer = 1
        Dim executouExitFor As Boolean = False

        For i As Integer = 1 To anos
            For j = 1 To 12
                investimento += (investimento * (rendimento / 100))
                extrato += "O Saldo do Investimento no mês " + contadorMeses.ToString() + " é " + investimento.ToString() _
                    + " usando a Taxa " + rendimento.ToString() + "% mês" + vbCrLf

                If investimento >= limite Then
                    extrato += "O Investimento atingiu o Limite" + vbCrLf
                    executouExitFor = True
                    Exit For
                End If

                contadorMeses += 1
            Next

            If executouExitFor Then
                Exit For
            End If

            rendimento += rendimento * acrescimoDosJuros / 100
        Next

        TxbExtrato2.Text = extrato
    End Sub
End Class
