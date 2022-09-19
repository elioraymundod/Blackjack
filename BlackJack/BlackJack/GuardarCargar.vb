'En esta clase estan los metodos para guardar o cargar partidas

Imports System.IO

Public Class GuardarCargar
    Private dineroJugadores As New Microsoft.VisualBasic.Collection()
    Private numeroJugadores As Integer
    Private dineroInicial As Integer
    Private apuestaMinima As Integer
    Private reglaDouble As Boolean
    Private reglaDoubleN As Integer
    Private meta As Integer
    Private _streamreader As StreamReader
    Private _streamwriter As StreamWriter
    Private _filestream As FileStream

    Public Sub setDatos(numeroJugadores As Integer, dineroInicial As Integer, apuestaMinima As Integer, reglaDouble As Boolean, meta As Integer, dineroJugadores As Microsoft.VisualBasic.Collection)
        Me.numeroJugadores = numeroJugadores
        Me.dineroInicial = dineroInicial
        Me.apuestaMinima = apuestaMinima
        Me.reglaDouble = reglaDouble
        Me.meta = meta
        Me.dineroJugadores = dineroJugadores
    End Sub

    Public Function getDineroJugadores()
        Return dineroJugadores
    End Function
    Public Function getNumeroJugadores()
        Return numeroJugadores
    End Function
    Public Function getDineroInicial()
        Return dineroInicial
    End Function
    Public Function getApuestaMinima()
        Return apuestaMinima
    End Function
    Public Function getReglaDouble()
        Return reglaDouble
    End Function
    Public Function getMeta()
        Return meta
    End Function

    Public Sub escribirArchivo(direccionArchivo As String)
        Try
            _filestream = File.Create(direccionArchivo)
            _filestream.Close()
            _streamwriter = My.Computer.FileSystem.OpenTextFileWriter(direccionArchivo, False)
            _streamwriter.WriteLine(numeroJugadores)
            _streamwriter.WriteLine(dineroInicial)
            _streamwriter.WriteLine(apuestaMinima)
            _streamwriter.WriteLine(meta)
            If reglaDouble Then
                _streamwriter.WriteLine(1)
            Else
                _streamwriter.WriteLine(0)
            End If
            For i = 1 To numeroJugadores
                _streamwriter.WriteLine("-" & i)
                _streamwriter.WriteLine(dineroJugadores.Item(i))
            Next
            _streamwriter.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al escribir el archivo")
        End Try
    End Sub

    Public Sub leerArchivo(direccionArchivo As String)
        dineroJugadores.Clear()
        Try
            _streamreader = New StreamReader(direccionArchivo)
            numeroJugadores = _streamreader.ReadLine
            dineroInicial = _streamreader.ReadLine
            apuestaMinima = _streamreader.ReadLine
            meta = _streamreader.ReadLine
            reglaDoubleN = _streamreader.ReadLine
            If reglaDoubleN = 1 Then
                reglaDouble = True
            ElseIf reglaDoubleN = 0
                reglaDouble = False
            End If
            For i = 1 To numeroJugadores
                _streamreader.ReadLine()
                dineroJugadores.Add(_streamreader.ReadLine)
            Next
            _streamreader.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al leer el archivo")
        End Try
    End Sub
End Class
