Imports System.Reflection
Imports System.Text.RegularExpressions

Public Class Form1
    Dim aire As New Aire

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If (txtMarca.Text = "" Or Val(txtFrigorias.Text) <= 0 Or txtPais.Text = "" Or (rbFrioSolo.Checked = False And rbFrioCalor.Checked = False)) Then
            MsgBox("Error, datos incorrectos o faltantes", vbOKOnly + vbExclamation)
        Else
            If (txtMarca.TextLength < 3 Or txtPais.TextLength < 3) Then
                MsgBox("Error, longitudes incorrectas", vbOKOnly + vbExclamation)
            Else
                If (chSplit.Checked = True) Then
                    If rbFrioSolo.Checked = True Then
                        aire = New Aire(txtMarca.Text, Val(txtFrigorias.Text), True, txtPais.Text, True, aire.TempInicial(), False)
                    End If
                    If rbFrioCalor.Checked = True Then
                        aire = New Aire(txtMarca.Text, Val(txtFrigorias.Text), True, txtPais.Text, False, aire.TempInicial(), False)
                    End If

                Else
                    If rbFrioSolo.Checked = True Then
                        aire = New Aire(txtMarca.Text, Val(txtFrigorias.Text), False, txtPais.Text, True, aire.TempInicial(), False)
                    End If
                    If rbFrioCalor.Checked = True Then
                        aire = New Aire(txtMarca.Text, Val(txtFrigorias.Text), False, txtPais.Text, False, aire.TempInicial(), False)

                    End If
                End If
                MsgBox("Aire acondicionado dado de alta")
                btnModelo.Enabled = True

                btnPower.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        If (aire.POWER()) = False Then
            lblOn.Text = ""
            btnOn.Text = ""
            btnMas.Enabled = False
            btnMenos.Enabled = False
            btnMin.Enabled = False
            btnMax.Enabled = False
        Else

            lblOn.Text = "ON"
            btnOn.Text = aire.Temperatura
            btnMas.Enabled = True
            btnMenos.Enabled = True
            btnMin.Enabled = True
            btnMax.Enabled = True
        End If


    End Sub

    Private Sub btnModelo_Click(sender As Object, e As EventArgs) Handles btnModelo.Click

        txtModelo.Text = aire.ModeloC()

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        btnOn.Text = aire.BAJAR()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        btnOn.Text = aire.SUBIR()
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        btnOn.Text = aire.BAJAR(InputBox("Ingrese los grados a bajar"))
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        btnOn.Text = aire.SUBIR(InputBox("Ingrese los grados a subir"))
    End Sub

    Private Sub chSplit_CheckedChanged(sender As Object, e As EventArgs) Handles chSplit.CheckedChanged

    End Sub
End Class
