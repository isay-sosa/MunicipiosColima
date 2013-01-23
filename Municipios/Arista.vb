Public Class Arista
    Private vOrigen, vDestino As Vertice
    Private vPeso(1) As Double
    Private vSeleccion As Boolean = False

    Sub New()

    End Sub

    Sub New(ByVal Origen As Vertice, ByVal Destino As Vertice, ByVal min As Integer, ByVal km As Double)
        Me.Origen = Origen
        Me.Destino = Destino
        Me.Peso(0) = min
        Me.Peso(1) = km
    End Sub

    Public Property Peso(ByVal posicion As Double)
        Get
            Return vPeso(posicion)
        End Get
        Set(ByVal value)
            vPeso(posicion) = value
        End Set
    End Property

    Public Property Seleccion()
        Get
            Return vSeleccion
        End Get
        Set(ByVal value)
            vSeleccion = value
        End Set
    End Property

    Public Property Origen()
        Get
            Return vOrigen
        End Get
        Set(ByVal value)
            vOrigen = value
        End Set
    End Property

    Public Property Destino()
        Get
            Return vDestino
        End Get
        Set(ByVal value)
            vDestino = value
        End Set
    End Property
End Class
