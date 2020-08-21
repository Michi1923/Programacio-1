﻿Public Class Form1
    Private Sub btnConvertirMoneda_Click(sender As Object, e As EventArgs) Handles btnConvertirMoneda.Click
        Dim Cant = txtCantMoneda.Text, Valor As Double

        Select Case cboMoneda1.SelectedIndex
            Case 1 'Dolar estadonidense a
                'Dolar estadonidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = (Valor)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.84458
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 106.129
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 8.747063
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000085
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 3.565875
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 22.14568
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.76276
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1.32155
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 6.9207
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Euro a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 1.184195
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 125.5955003
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 10.35796585
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0001
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 4.223600643
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 26.21389206
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.90314
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1.564775
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 8.1961
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 3 'Yen a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.00941565
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.00796
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 0.0830478319
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0000008003
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.0338534852
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 0.2094891
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.0071943966
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.012459
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 0.0651749
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 4 'Colon de El Salvador a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.1134721
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.0958459113
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 12.04160251
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0000096
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.4078704706
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 2.523381212
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.0866285726
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.150063448
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 0.7856921676
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 5 'Bitcoin a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 11865.4
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 10003.06614
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 1255216.935
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 103893.7627
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 42305.62094
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 261877.4679
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 8975.670585
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 15640.61925
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 82026.03195
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 6 'Sol Peruano a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.2805695
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.2365481454
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 29.68285025
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 2.456674117
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000024
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 6.207569
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.212227
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.3697278
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 1.940390605
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 7 'Peso Mexicano a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.0452965
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.038178627
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 4.791259177
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 0.3965517068
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0000038
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.161404854
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.0342515
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.0596825
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 0.3130784359
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 8 'Libra Esterlina a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 1.3216
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 1.11397664
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 139.8175
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 0.3965517068
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.00011
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 4.711757
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 29.19641703
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1.742714349
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 9.14074503
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Dolar Canadiense a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.758445
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.6394
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 80.2424931
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 6.641008678
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000064
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 2.704223895
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 16.74665184
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.573915
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 5.245477637
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Yuan a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.14459434
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.1218919586
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 15.29779198
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 1.266071945
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000012
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.51554548
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 3.192136947
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.1094094762
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.1906404075
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
        End Select
    End Sub

    Private Sub btnConvertirVolumen_Click(sender As Object, e As EventArgs) Handles btnConvertirVolumen.Click
        Dim Cant = txtCantVolumen.Text, Valor

        Select Case cboVolumen1.SelectedIndex
            Case 1 'Cucharadita EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 0.333333
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 0.300781
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.020537156237482691
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.16666
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 4.92892
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.00492892
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.000174063
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.00130208
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.0000049289
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Cucharada EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 3
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 0.902344
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.0616115
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.5
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 14.7868
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.0147868
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.00052219
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.00390625
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000014787
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 3 'Pulgada Cubica a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 3.32468
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 1.10823
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.0682794
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.554113
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 16.3871
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.0163871
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.000578704
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.000578704
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000014787
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 4 'Taza EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 48.6922
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 16.2307
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 14.6457
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 8.11537
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 240
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.24
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.00847552
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.0634013
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.00024
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 5 'Onza Liquida EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 6
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 2
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 1.80469
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.123223
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 29.5735
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.0295735
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.00104438
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.0078125
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000029574
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 6 'Mililitro a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 0.202884
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 0.067628
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 0.0610237
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.00416667
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.033814
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.001
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.000035315
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.000264172
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000001
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 7 'Litro a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 202.884
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 67.628
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 61.0237
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 4.16667
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 33.814
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 1000
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.0353147
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.264172
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.001
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 8 'Pie Cubico a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 5745.04
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 1915.01
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 1728
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 117.987
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 957.506
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 28316.8
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 28.3168
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 7.48052
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.0283168
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Galon EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 769
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 256
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 231
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 15.7725
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 128
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 3785.41
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 3.78541
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.133681
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.00378541
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Metro Cubico a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 202884
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 67628
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 61023.7
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 4166.67
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 33814
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 1000000.0
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 1000
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 35.3147
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 264.172
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
        End Select
    End Sub
End Class
