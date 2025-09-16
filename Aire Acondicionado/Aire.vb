Imports Microsoft.VisualBasic.Devices

Public Class Aire
    Private _Marca As String
    Private _Frigorias As Integer
    Private _Split As Boolean
    Private _Pais As String
    Private _FrioSolo As Boolean
    Private _Temperatura As Integer
    Private _Encendido As Boolean
    Private _Modelo As String


    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            Dim Longi As Integer
            Dim aux As Integer

            Longi = Len(value)
            For i = 0 To Longi - 1
                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Error con la marca")
            Else
                _Marca = value
            End If
        End Set
    End Property

    Public Property Frigorias As Integer
        Get
            Return _Frigorias
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Frigorias = value
            Else
                MsgBox("Error con las frigorias")
            End If
        End Set
    End Property

    Public Property Split As Boolean
        Get
            Return _Split
        End Get
        Set(value As Boolean)

            _Split = value
            Dim max As Integer
            Dim min As Integer

            If _Split = True Then
                If FrioSolo = True Then
                    max = 25
                    min = 17
                Else
                    max = 31
                    min = 17
                End If
            Else
                If FrioSolo = True Then
                    max = 24
                    min = 18
                Else
                    max = 30
                    min = 18
                End If
            End If


            If Temperatura < min Then
                Temperatura = min
            End If
            If Temperatura > max Then
                    Temperatura = max
                End If

        End Set
    End Property
    Public Property Pais As String
        Get
            Return _Pais
        End Get
        Set(value As String)
            Dim Longi As Integer
            Dim aux As Integer

            Longi = Len(value)
            For i = 0 To Longi - 1
                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Error con el pais")
            Else
                _Pais = value.ToUpper()
            End If
        End Set
    End Property

    Public Property FrioSolo As Boolean
        Get
            Return _FrioSolo
        End Get
        Set(value As Boolean)
            _FrioSolo = value
        End Set
    End Property

    Public Property Temperatura As Integer
        Get
            Return _Temperatura
        End Get
        Set(value As Integer)
            Dim max As Integer
            Dim min As Integer
            If (Split = True) Then
                If (FrioSolo = True) Then
                    max = 25
                    min = 17
                    If value <= max And value >= min Then
                        _Temperatura = value
                    Else
                        MsgBox("Error con la temperatura")
                    End If
                Else
                    max = 31
                    min = 17
                    If value <= max And value >= min Then
                        _Temperatura = value
                    Else
                        MsgBox("Error con la temperatura")
                    End If
                End If
            Else
                If (FrioSolo = True) Then
                    max = 24
                    min = 18
                    If value <= max And value >= min Then
                        _Temperatura = value
                    Else
                        MsgBox("Error con la temperatura")
                    End If
                Else
                    max = 30
                    min = 18
                    If value <= max And value >= min Then
                        _Temperatura = value
                    Else
                        MsgBox("Error con la temperatura")
                    End If
                End If
            End If



        End Set
    End Property
    Public Property Encendido As Boolean
        Get
            Return _Encendido
        End Get
        Set(value As Boolean)
            _Encendido = value
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(value As String)
            Dim Longi As Integer
            Dim aux As Integer

            Longi = Len(value)
            For i = 0 To Longi - 1
                If String.IsNullOrWhiteSpace(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Error con el modelo")
            Else
                _Modelo = value
            End If
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(Marca As String, Frigorias As Integer, Split As Boolean, Pais As String, FrioSolo As Boolean, Temperatura As Integer, Encendido As Boolean)
        Me.Marca = Marca
        Me.Frigorias = Frigorias
        Me.Split = Split
        Me.Pais = Pais
        Me.FrioSolo = FrioSolo
        Me.Encendido = Encendido
        Me.Temperatura = TempInicial()


    End Sub
    Public Function ModeloC()
        If FrioSolo = True Then
            If Split = True Then
                Me.Modelo = Marca.Substring(0, 3) & Frigorias & Pais.Substring(0, 3) & "FS" + "/S"
            Else
                Me.Modelo = Marca.Substring(0, 3) & Frigorias & Pais.Substring(0, 3) & "FS"
            End If
        Else
            If Split = True Then
                Me.Modelo = Marca.Substring(0, 3) & Frigorias & Pais.Substring(0, 3) & "FC" + "/S"
            Else
                Me.Modelo = Marca.Substring(0, 3) & Frigorias & Pais.Substring(0, 3) & "FC"
            End If
        End If
        Return Me.Modelo
    End Function
    Public Function TempInicial()
        Dim min As Integer
        If (Split = True) Then

            min = 17
            Temperatura = min

        Else
            min = 18
            Temperatura = min
        End If
        Return Temperatura
    End Function
    Public Function POWER()
        If (Encendido = True) Then
            Encendido = False
        Else
            Encendido = True
        End If
        Return Encendido
    End Function
    Public Function SUBIR()
        Dim max As Integer
        If (Split = True) Then
            If (FrioSolo = True) Then
                max = 25
                Temperatura = max

            Else
                max = 31
                Temperatura = max
            End If
        Else
            If (FrioSolo = True) Then
                max = 24
                Temperatura = max

            Else
                max = 30
                Temperatura = max
            End If
        End If
        Return Temperatura
    End Function
    Public Function SUBIR(grados As Integer)
        Dim max As Integer
        If (Split = True) Then
            If (FrioSolo = True) Then
                max = 25
                If (Temperatura + grados) > max Then
                    Temperatura = max
                Else
                    Temperatura = Temperatura + grados
                End If

            Else
                max = 31
                If (Temperatura + grados) > max Then
                    Temperatura = max
                Else
                    Temperatura = Temperatura + grados
                End If
            End If
        Else
            If (FrioSolo = True) Then
                max = 24
                If (Temperatura + grados) > max Then
                    Temperatura = max
                Else
                    Temperatura = Temperatura + grados
                End If

            Else
                max = 30
                If (Temperatura + grados) > max Then
                    Temperatura = max
                Else
                    Temperatura = Temperatura + grados
                End If
            End If
        End If
        Return Temperatura
    End Function

    Public Function BAJAR()
        Dim min As Integer
        If (Split = True) Then

            min = 17
                Temperatura = min

        Else
            min = 18
            Temperatura = min
        End If
        Return Temperatura
    End Function
    Public Function BAJAR(grados As Integer)
        Dim min As Integer
        If (Split = True) Then
            min = 17
            If (Temperatura - grados) < min Then
                Temperatura = min
            Else
                Temperatura = Temperatura - grados
            End If

        Else
            min = 18
            If (Temperatura - grados) < min Then
                Temperatura = min
            Else
                Temperatura = Temperatura - grados
            End If
        End If
        Return Temperatura
    End Function
End Class
