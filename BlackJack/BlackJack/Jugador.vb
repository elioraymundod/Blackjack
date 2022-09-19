'En esta clase se especifican todas las caracteristicas que tiene cada jugador



Public Class Jugador
    Private puntuacion As Integer
    Private puntuacionSecundaria As Integer
    Private dinero As Integer
    Private apuestaActual As Integer
    Private cantidadCartasActuales As Integer
    Public blackjack As Boolean = False
    Public lose As Boolean = False
    Public seguro As Boolean = False
    Public haPerdido As Boolean = False

    'Getters y Setters
    Public Sub setPuntuacion(puntuacion As Integer)
        Me.puntuacion = puntuacion
    End Sub
    Public Sub setPuntuacionSecundaria(puntuacionSecundaria As Integer)
        Me.puntuacionSecundaria = puntuacionSecundaria
    End Sub
    Public Sub setDinero(dinero As Integer)
        Me.dinero = dinero
    End Sub
    Public Sub setApuestaActual(apuestaActual As Integer)
        Me.apuestaActual = apuestaActual
    End Sub
    Public Sub setCantidadCartasActuales(cantidadCartasActuales As Integer)
        Me.cantidadCartasActuales = cantidadCartasActuales
    End Sub
    Public Function getPuntuacion()
        Return puntuacion
    End Function
    Public Function getPuntuacionSecundaria()
        Return puntuacionSecundaria
    End Function
    Public Function getDinero()
        Return dinero
    End Function
    Public Function getApuestaActual()
        Return apuestaActual
    End Function
    Public Function getCantidadCartasActuales()
        Return cantidadCartasActuales
    End Function

    'Otros Metodos
    Public Function mostrarPuntuacion()
        Dim puntuacionstring As String
        If puntuacion = puntuacionSecundaria Then
            puntuacionstring = puntuacion
        Else
            puntuacionstring = puntuacion & " / " & puntuacionSecundaria
        End If
        If puntuacionSecundaria = 21 And cantidadCartasActuales = 2 Then
            puntuacionstring = "BlackJack"
            blackjack = True
        End If
        Return puntuacionstring
    End Function

    Public Function darMejorPuntuacion()
        Dim mejorPuntuacion As Integer
        If puntuacion > puntuacionSecundaria And puntuacion < 21 Then
            mejorPuntuacion = puntuacion
        ElseIf puntuacion < puntuacionSecundaria And puntuacionSecundaria < 21
            mejorPuntuacion = puntuacionSecundaria
        ElseIf puntuacion = puntuacionSecundaria
            mejorPuntuacion = puntuacion
        Else
            If puntuacion < puntuacionSecundaria Then
                mejorPuntuacion = puntuacion
            Else
                mejorPuntuacion = puntuacionSecundaria
            End If
        End If
        If puntuacion = 21 Or puntuacionSecundaria = 21 Then
            mejorPuntuacion = 21
        End If
        Return mejorPuntuacion
    End Function
End Class
