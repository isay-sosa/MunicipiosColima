Public Class Vertice
    Private vValor
    Private vEtiqueta(1)
    Private vCaminos() As Arista
    Private vChecked As Boolean = False

    Sub New()
        vEtiqueta(0) = 0
        vEtiqueta(1) = ""
    End Sub

    Sub New(ByVal valor)
        vValor = valor        
    End Sub

    Public Property Valor()
        Get
            Return vValor
        End Get
        Set(ByVal value)
            vValor = value
        End Set
    End Property

    Public Sub Etiqueta(ByVal valor As Double, ByVal origen As String)
        vEtiqueta(0) = valor
        vEtiqueta(1) = origen
    End Sub

    Public Function Etiqueta(ByVal posicion As Byte)
        Return vEtiqueta(posicion)
    End Function

    Public Sub RedimCaminos(ByVal numeroElementos As Byte)
        ReDim vCaminos(numeroElementos - 1)        
    End Sub

    Public Property Caminos(ByVal posicion As Byte)
        Get
            Return vCaminos(posicion)
        End Get
        Set(ByVal value)
            vCaminos(posicion) = value
        End Set
    End Property

    Public Function N_Caminos() As Integer
        Return vCaminos.Length
    End Function

    Public Property Checked()
        Get
            Return vChecked
        End Get
        Set(ByVal value)
            vChecked = value
        End Set
    End Property
End Class
