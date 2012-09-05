﻿Public Class frmPL



    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim f1(3), f2(3), z(2) As Decimal

        Pegar_Valores(f1, f2, z)
        Calcular_Metodo_Grafico(f1, f2, z)
        Calcular_Metodo_Simplex(f1, f2, z)

    End Sub

    Sub Pegar_Valores(ByVal f1() As Decimal, ByVal f2() As Decimal, ByVal z() As Decimal)
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

        'pega os fatores do objetivo
        z(1) = v1f3.Text
        z(2) = v2f3.Text
    End Sub

    Sub Calcular_Metodo_Grafico(ByVal f1() As Decimal, ByVal f2() As Decimal, ByVal z() As Decimal)

        'Dim pgraf1(2), pgraf2(2), psolucao(2) As Decimal
        Dim solucoes(3, 2) As Decimal

        'calcular o gráfico da primeira equação
        solucoes(1, 1) = f1(3) / f1(1)  'valor x1
        solucoes(1, 2) = f1(3) / f1(2)  'valor x2
        lblPonto1.Text = "Equação 1: x=" + FormatNumber(solucoes(1, 1), 2) + ", y=" + FormatNumber(solucoes(1, 2), 2)


        'calcular o o gráfico da segunda equação
        solucoes(2, 1) = f2(3) / f2(1)  'valor x1
        solucoes(2, 2) = f2(3) / f2(2)  'valor x2
        lblPonto2.Text = "Equação 2: x=" + FormatNumber(solucoes(2, 1), 2) + ", y=" + FormatNumber(solucoes(2, 2), 2)

        'calcular a soluçao final
        'usando o método de somar as equações
        solucoes(3, 1) = calc_graf_x1(f1, f2)
        solucoes(3, 2) = calc_graf_x2(f1, solucoes(3, 1))
        lblSolucao.Text = "Ponto Solução: x=" + FormatNumber(solucoes(3, 1), 2) + ", y=" + FormatNumber(solucoes(3, 2), 2)
        'desenhar o gráfico
        Desenhar_Grafico(1, solucoes(1, 1), solucoes(1, 2), f1)
        Desenhar_Grafico(2, solucoes(2, 1), solucoes(2, 2), f2)
        Desenhar_Grafico_Solucao(solucoes(3, 1), solucoes(3, 2))

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

    Sub Desenhar_Grafico_Solucao(ByVal x As Decimal, ByVal y As Decimal)

        'monta as linhas tracejadas que identificam o ponto ótimo
        'ou seja, o cruzamento entre as duas linhas das equações

        Chart1.Series(3).Points(0).XValue = 0
        Chart1.Series(3).Points(0).YValues(0) = y
        Chart1.Series(3).Points(1).XValue = x
        Chart1.Series(3).Points(1).YValues(0) = y

        Chart1.Series(2).Points(0).XValue = x
        Chart1.Series(2).Points(0).YValues(0) = 0
        Chart1.Series(2).Points(1).XValue = x
        Chart1.Series(2).Points(1).YValues(0) = y

        Chart1.ResetAutoValues()

        'copia todos os dados do gráfico 1 para o gráfico 2
        For i As Integer = 0 To 3
            Chart2.Series(i) = Chart1.Series(i)
        Next

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

    Sub Calcular_Metodo_Simplex(ByVal f1() As Decimal, ByVal f2() As Decimal, ByVal z() As Decimal)

        Verifica_Ordem_Equacoes(f1, f2, z)
        Simplex_Montar_Quadro_I(f1, f2, z)
    End Sub

    Sub Verifica_Ordem_Equacoes(ByVal f1() As Decimal, ByVal f2() As Decimal, ByVal z() As Decimal)


        If z(1) > z(2) Then
            If f1(3) / f1(1) > f2(3) / f2(1) Then
                Verifica_Ordem_Equacoes_Troca(f1, f2)
            End If
        Else
            If f2(3) / f2(1) > f1(3) / f1(1) Then
                Verifica_Ordem_Equacoes_Troca(f1, f2)
            End If
        End If
    End Sub

    Sub Verifica_Ordem_Equacoes_Troca(ByVal f1() As Decimal, ByVal f2() As Decimal)
        Dim f1_local(3), f2_local(3) As Decimal

        Array.Copy(f1, f1_local, 4)
        Array.Copy(f2, f2_local, 4)
        Array.Copy(f1_local, f2, 4)
        Array.Copy(f2_local, f1, 4)
        txtQuadroI.Text = "trocada a ordem das equações para facilitar o cálculo"
    End Sub

    Sub Simplex_Montar_Quadro_I(ByVal f1() As Decimal, ByVal f2() As Decimal, ByVal z() As Decimal)
        QuadroI.Rows.Clear()

        QuadroI.Rows.Add("F1", CStr(f1(1)), CStr(f1(2)), "1", "0", CStr(f1(3)))
        QuadroI.Rows.Add("F2", CStr(f2(1)), CStr(f2(2)), "0", "1", CStr(f2(3)))
        QuadroI.Rows.Add("Z", CStr(z(1)), CStr(z(2)), "0", "0", "0")


    End Sub

End Class
