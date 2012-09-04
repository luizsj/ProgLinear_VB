Public Class frmPL



    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim f1(3), f2(3) As Decimal
        'Dim pgraf1(2), pgraf2(2), psolucao(2) As Decimal
        Dim solucoes(3, 2) As Decimal
        Dim valtemp As Decimal

        'verifica se todos os valores estão preenchidos
        Verifica_Preenchimento()

        'pega os fatores da primeira fórmula
        f1(1) = CDec(v1f1.Text) 'fator do x1, formula 1
        f1(2) = CDec(v2f1.Text) 'fator do x2, formula 1
        f1(3) = CDec(d1f1.Text) 'valor da restrição, formula 1

        'pega os fatores da segunda fórmula
        f2(1) = CDec(v1f2.Text) 'fator do x1, formula 2
        f2(2) = CDec(v2f2.Text) 'fator do x2, formula 2
        f2(3) = CDec(d1f2.Text) 'valor da restrição, formula 2

        'calcular o 1o. ponto do gráfico
        solucoes(1, 1) = f1(3) / f1(1)  'valor x1
        solucoes(1, 2) = f1(3) / f1(2)  'valor x2
        lblPonto1.Text = "Ponto 1: x=" + FormatNumber(solucoes(1, 1), 2) + ", y=" + FormatNumber(solucoes(1, 2), 2)


        'calcular o 2o. ponto do gráfico
        solucoes(2, 1) = f2(3) / f2(1)  'valor x1
        solucoes(2, 2) = f2(3) / f2(2)  'valor x2
        lblPonto2.Text = "Ponto 2: x=" + FormatNumber(solucoes(2, 1), 2) + ", y=" + FormatNumber(solucoes(2, 2), 2)

        'calcular a soluçao final
        'usando o método de somar as equações
        solucoes(3, 1) = calc_graf_x1(f1, f2)
        solucoes(3, 2) = calc_graf_x2(f1, solucoes(3, 1))
        lblSolucao.Text = "Solução: x=" + FormatNumber(solucoes(3, 1), 2) + ", y=" + FormatNumber(solucoes(3, 2), 2)
        'desenhar o gráfico
        Desenhar_Grafico(1, solucoes(1, 1), solucoes(1, 2), f1)
        Desenhar_Grafico(2, solucoes(2, 1), solucoes(2, 2), f2)

        Montar_Objetivo(solucoes(3, 1), solucoes(3, 2))
    End Sub

    Sub Montar_Objetivo(ByVal x1 As Decimal, ByVal x2 As Decimal)
        Dim resultado As Decimal
        lblObjetivo.Text = "Z = " + v1f3.Text + "x + " + v2f3.Text + "y"
        resultado = CDec(v1f3.Text) * x1 + CDec(v2f3.Text) * x2
        lblfinal.Text = "resultado: " + FormatNumber(resultado, 2)

    End Sub

    Sub Verifica_Preenchimento()
        Verifica_Controle(1, v1f1)
        Verifica_Controle(2, v2f1)
        Verifica_Controle(3, d1f1)
        Verifica_Controle(4, v1f2)
        Verifica_Controle(5, v2f2)
        Verifica_Controle(6, d1f2)
    End Sub

    Sub Verifica_Controle(ByVal valorpadrao As Decimal, ByVal controle As TextBox)
        Dim teste As Decimal

        '   If controle.Text = "" Then
        '
        'End If
        
        Try
            teste = CDec(controle.Text)
        Catch ex As Exception
            controle.Text = CStr(valorpadrao)
            MessageBox.Show("Um dos campos não está preenchido corretamente!" + Asc(13) + Asc(10) + "Usando valor padrão: " + CStr(valorpadrao))
        End Try


    End Sub


    Sub Desenhar_Grafico(ByVal serie As Integer, ByVal x As Decimal, ByVal y As Decimal, ByVal equacao() As Decimal)

        serie = serie - 1
        Chart1.Series(serie).Points(0).XValue = x
        Chart1.Series(serie).Points(1).YValues(0) = y
        Chart1.Series(serie).LegendText = CStr(equacao(1)) + "x + " + CStr(equacao(2)) + "y <= " + CStr(equacao(3))

        Chart1.ResetAutoValues()

    End Sub

    Function calc_graf_x2(ByVal f1() As Decimal, ByVal x1 As Decimal) As Decimal
        Dim f1_local(3) As Decimal

        Array.Copy(f1, f1_local, 4)
        f1_local(1) = f1_local(1) * x1      'é o mesmo que substituir o x1 na equação
        f1_local(3) = f1_local(3) - f1_local(1)   'é o mesmo que isolar o x2
        f1_local(2) = f1_local(3) / f1_local(2)   'é o mesmo que calcular o valor de x2

        calc_graf_x2 = f1_local(2)

    End Function


    Function calc_graf_x1(ByVal f1() As Decimal, ByVal f2() As Decimal) As Decimal
        Dim fator, resultado As Decimal
        Dim f1_local(3), f2_local(3) As Decimal

        Array.Copy(f1, f1_local, 4)
        Array.Copy(f2, f2_local, 4)
        'descobrir por quanto multiplicar a f2 para zerar o X2
        fator = -(f1_local(2) / f2_local(2))

        'os 3 passos a seguir é o mesmo que multiplicar a equação 2 pelo fator
        f2_local(1) = f2_local(1) * fator
        f2_local(2) = f2_local(2) * fator
        f2_local(3) = f2_local(3) * fator

        'a seguir, executa a soma das equações
        f1_local(1) = f1_local(1) + f2_local(1)
        f1_local(2) = f1_local(2) + f2_local(2)
        f1_local(3) = f1_local(3) + f2_local(3)

        If (f1_local(2) = 0) Then
            'se o método de soma zerou o x2, calcular o x1
            resultado = f1_local(3) / f1_local(1)
        Else
            resultado = 0
        End If

        calc_graf_x1 = resultado

    End Function

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
