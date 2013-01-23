Public Class Colima
    Private Municipios(9), vInicio As Vertice

    ''' <summary>
    ''' Se genera un grafo de la distribución de los municipios y sus caminos del Estado de Colima
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        Municipios(0) = New Vertice("Armeria")
        Municipios(1) = New Vertice("Colima")
        Municipios(2) = New Vertice("Comala")
        Municipios(3) = New Vertice("Coquimatlan")
        Municipios(4) = New Vertice("Cuauhtemoc")
        Municipios(5) = New Vertice("Ixtlahuacan")
        Municipios(6) = New Vertice("Manzanillo")
        Municipios(7) = New Vertice("Minatitlan")
        Municipios(8) = New Vertice("Tecoman")
        Municipios(9) = New Vertice("Villa de Alvarez")

        Municipios(0).RedimCaminos(3)
        Municipios(0).Caminos(0) = New Arista(Municipios(0), Municipios(6), 41, 48.3) 'Armeria-Manzanillo, 41min, 48.3km
        Municipios(0).Caminos(1) = New Arista(Municipios(0), Municipios(1), 46, 54.2)
        Municipios(0).Caminos(2) = New Arista(Municipios(0), Municipios(8), 17, 15.1)

        Municipios(1).RedimCaminos(6)
        Municipios(1).Caminos(0) = New Arista(Municipios(1), Municipios(2), 18, 11.3)                        
        Municipios(1).Caminos(1) = New Arista(Municipios(1), Municipios(0), 46, 54.2)
        Municipios(1).Caminos(2) = New Arista(Municipios(1), Municipios(8), 38, 47.3)
        Municipios(1).Caminos(3) = New Arista(Municipios(1), Municipios(5), 36, 37.3)
        Municipios(1).Caminos(4) = New Arista(Municipios(1), Municipios(4), 19, 19.5)
        Municipios(1).Caminos(5) = New Arista(Municipios(1), Municipios(9), 10, 4)

        Municipios(2).RedimCaminos(3)
        Municipios(2).Caminos(0) = New Arista(Municipios(2), Municipios(7), 65, 55)
        Municipios(2).Caminos(1) = New Arista(Municipios(2), Municipios(9), 14, 8.2)
        Municipios(2).Caminos(2) = New Arista(Municipios(2), Municipios(4), 31, 25.1)

        Municipios(3).RedimCaminos(4)
        Municipios(3).Caminos(0) = New Arista(Municipios(3), Municipios(6), 85, 98.6)
        Municipios(3).Caminos(1) = New Arista(Municipios(3), Municipios(1), 18, 11.3)
        Municipios(3).Caminos(2) = New Arista(Municipios(3), Municipios(9), 18, 11.2)
        Municipios(3).Caminos(3) = New Arista(Municipios(3), Municipios(7), 47, 28.6)

        Municipios(4).RedimCaminos(3)
        Municipios(4).Caminos(0) = New Arista(Municipios(4), Municipios(2), 31, 25.1)
        Municipios(4).Caminos(1) = New Arista(Municipios(4), Municipios(9), 29, 23.4)
        Municipios(4).Caminos(2) = New Arista(Municipios(4), Municipios(1), 19, 19.5)

        Municipios(5).RedimCaminos(2)
        Municipios(5).Caminos(0) = New Arista(Municipios(5), Municipios(1), 36, 37.3)
        Municipios(5).Caminos(1) = New Arista(Municipios(5), Municipios(8), 25, 27.6)

        Municipios(6).RedimCaminos(3)
        Municipios(6).Caminos(0) = New Arista(Municipios(6), Municipios(7), 64, 59.9)
        Municipios(6).Caminos(1) = New Arista(Municipios(6), Municipios(3), 85, 98.6)
        Municipios(6).Caminos(2) = New Arista(Municipios(6), Municipios(0), 41, 48.3)

        Municipios(7).RedimCaminos(4)
        Municipios(7).Caminos(0) = New Arista(Municipios(7), Municipios(6), 64, 59.9)
        Municipios(7).Caminos(1) = New Arista(Municipios(7), Municipios(3), 47, 28.6)
        Municipios(7).Caminos(2) = New Arista(Municipios(7), Municipios(9), 63, 55.2)
        Municipios(7).Caminos(3) = New Arista(Municipios(7), Municipios(2), 65, 55)

        Municipios(8).RedimCaminos(3)
        Municipios(8).Caminos(0) = New Arista(Municipios(8), Municipios(0), 17, 15.1)
        Municipios(8).Caminos(1) = New Arista(Municipios(8), Municipios(5), 25, 27.6)
        Municipios(8).Caminos(2) = New Arista(Municipios(8), Municipios(1), 38, 47.3)

        Municipios(9).RedimCaminos(5)
        Municipios(9).Caminos(0) = New Arista(Municipios(9), Municipios(7), 63, 55.2)
        Municipios(9).Caminos(1) = New Arista(Municipios(9), Municipios(3), 18, 11.2)
        Municipios(9).Caminos(2) = New Arista(Municipios(9), Municipios(1), 10, 4)
        Municipios(9).Caminos(3) = New Arista(Municipios(9), Municipios(4), 29, 23.4)
        Municipios(9).Caminos(4) = New Arista(Municipios(9), Municipios(2), 14, 8.2)
    End Sub

    ''' <summary>
    ''' Configura el vertice de Inicio y crea las etiquetas de los municipios adyacentes a él
    ''' </summary>
    ''' <param name="origen">Es el nombre que se buscará en la lista de municipios para ser configurado</param>
    ''' <remarks></remarks>
    Private Sub Inicio(ByVal origen As String)
        For i As Byte = 0 To Municipios.Length - 1
            If Municipios(i).Valor = origen Then
                vInicio = Municipios(i)
                Exit For
            End If
        Next
        vInicio.Etiqueta(0, "-")
        vInicio.Checked = True
    End Sub

    ''' <summary>
    ''' Busca el peso más pequeño de los vertices y dicho vertice es regresado
    ''' </summary>
    ''' <returns>Regresa el vertice con el menor peso</returns>
    ''' <remarks></remarks>
    Private Function nuevoTemp() As Vertice
        Dim temp As Vertice

        For i As Byte = 0 To Municipios.Length - 1
            For j As Byte = 0 To Municipios(i).N_Caminos - 1
                If Not Municipios(i).Caminos(j).Destino.Checked Then
                    If Municipios(i).Caminos(j).Destino.Etiqueta(0) <> 0 Then
                        If temp Is Nothing Then
                            temp = Municipios(i).Caminos(j).Destino
                        Else
                            If temp.Etiqueta(0) > Municipios(i).Caminos(j).Destino.Etiqueta(0) Then temp = Municipios(i).Caminos(j).Destino
                        End If
                    End If
                End If
            Next
        Next

        Return temp
    End Function

    ''' <summary>
    ''' Genera la ruta del vertice de Inicio al de Destino
    ''' </summary>
    ''' <param name="origen">Nombre del vertice que será el origen de la ruta</param>
    ''' <param name="destino">Nombre del vertice que será el destino de la ruta</param>
    ''' <param name="peso">Entre 0 y 1, siendo 0 el valor de los minutos y 1 el valor de los kilometros</param>
    ''' <returns>Regresa la ruta del vertice de origen al de destino</returns>
    ''' <remarks></remarks>
    Public Function Ruta(ByVal origen As String, ByVal destino As String, ByVal peso As Byte) As String
        Dim temp As Vertice

        Inicio(origen)
        For i As Byte = 0 To vInicio.N_Caminos - 1            
            If vInicio.Caminos(i).Destino.Etiqueta(0) > (vInicio.Etiqueta(0) + vInicio.Caminos(i).Peso(peso)) Or vInicio.Caminos(i).Destino.Etiqueta(0) = 0 And Not vInicio.Caminos(i).Destino.Checked Then
                vInicio.Caminos(i).Destino.Etiqueta(vInicio.Etiqueta(0) + vInicio.Caminos(i).Peso(peso), vInicio.Valor)
            End If            

            If temp Is Nothing Then
                temp = vInicio.Caminos(i).Destino
            Else
                If temp.Etiqueta(0) > vInicio.Caminos(i).Destino.Etiqueta(0) Then temp = vInicio.Caminos(i).Destino
            End If
        Next

        While temp IsNot Nothing
            For i As Byte = 0 To temp.N_Caminos - 1                
                If temp.Caminos(i).Destino.Etiqueta(0) > (temp.Etiqueta(0) + temp.Caminos(i).Peso(peso)) Or temp.Caminos(i).Destino.Etiqueta(0) = 0 And Not temp.Caminos(i).Destino.Checked Then
                    temp.Caminos(i).Destino.Etiqueta(temp.Etiqueta(0) + temp.Caminos(i).Peso(peso), temp.Valor)
                End If                
            Next
            temp.Checked = True
            temp = nuevoTemp()
        End While

        Return ImprimirRuta(origen, destino, peso)
    End Function

    ''' <summary>
    ''' Genera la ruta en una cadena
    ''' </summary>
    ''' <param name="origen">Vertice de origen de la ruta</param>
    ''' <param name="destino">Vertice de destino de la ruta</param>
    ''' <param name="peso">Entre 0 y 1, siendo 0 el valor de los minutos y 1 el valor de los kilometros</param>
    ''' <returns>Regresa en una cadena la ruta del vertice de origen al vertice de destino</returns>
    ''' <remarks></remarks>
    Private Function ImprimirRuta(ByVal origen As String, ByVal destino As String, ByVal peso As Byte) As String
        Dim ruta As String = ""
        Dim temp As Vertice

        For i As Byte = 0 To Municipios.Length - 1
            If Municipios(i).Valor = destino Then
                temp = Municipios(i)
                If peso = 0 Then
                    ruta = " (" & temp.Etiqueta(0) & "min)"
                Else
                    ruta = " (" & temp.Etiqueta(0) & "km)"
                End If

                While origen <> temp.Valor
                    ruta = " -> " & temp.Valor & ruta

                    For j As Byte = 0 To Municipios.Length - 1
                        If Municipios(j).Valor = temp.Etiqueta(1) Then
                            temp = Municipios(j)
                            Exit For
                        End If
                    Next
                End While
                Exit For
            End If
        Next

        ruta = origen & ruta
        Return ruta
    End Function

    ''' <summary>
    ''' Se recorre todos los caminos de la ciudad Actual en busca de ciclos
    ''' </summary>
    ''' <param name="ciudadActual">Valor en el cual se esta buscando</param>
    ''' <param name="ciudadAnterior">Valor de donde se viene buscando</param>
    ''' <param name="inicio">Valor desde donde se empezó a recorrer</param>
    ''' <returns>Regresa True si existe ciclo y False si no hay ciclo</returns>
    ''' <remarks></remarks>
    Private Function Recorrer(ByVal ciudadActual As Vertice, ByVal ciudadAnterior As Vertice, ByVal inicio As String) As Boolean
        Dim ciclo As Boolean = False

        For i As Byte = 0 To ciudadActual.N_Caminos - 1
            If ciudadActual.Caminos(i).Seleccion Then
                If ciudadAnterior IsNot Nothing Then If ciudadActual.Caminos(i).Destino.Valor = ciudadAnterior.Valor Then Continue For
                If ciudadActual.Caminos(i).Destino.Valor = inicio Then
                    Return True
                Else
                    ciclo = Recorrer(ciudadActual.Caminos(i).Destino, ciudadActual, inicio)
                End If
                If ciclo Then Return ciclo
            End If
        Next

        Return ciclo
    End Function

    ''' <summary>
    ''' Genera el arbol minimo a partir de un grafo (sin ciclos)
    ''' </summary>
    ''' <param name="opcion">0 siendo a partir de minutos, 1 a partir de kilometros</param>
    ''' <returns>Regresa en una cadena la forma en la que está unido el arbol recien creado</returns>
    ''' <remarks></remarks>
    Public Function Arbol(ByVal opcion As Byte) As String
        Dim peso As Double
        Dim contador As Byte
        Dim temp As Vertice
        Dim camino As Arista

        For i As Byte = 0 To Municipios.Length - 1
            For j As Byte = 0 To Municipios(i).N_Caminos - 1
                If Municipios(i).Caminos(j).Peso(opcion) = 0 Then Continue For
                If peso = 0 Then peso = Municipios(i).Caminos(j).Peso(opcion)
                If Municipios(i).Caminos(j).Peso(opcion) <= peso Then
                    peso = Municipios(i).Caminos(j).Peso(opcion)
                    temp = Municipios(i)
                    camino = Municipios(i).Caminos(j)
                End If
            Next
        Next

        If Not camino.Seleccion Then
            camino.Seleccion = True
            For i As Byte = 0 To camino.Destino.N_Caminos - 1
                If camino.Destino.Caminos(i).Destino.Valor = temp.Valor Then
                    camino.Destino.Caminos(i).Seleccion = True
                    Exit For
                End If
            Next
            If Not Recorrer(temp, Nothing, temp.Valor) Then
                temp.Checked = True
                camino.Destino.Checked = True
                camino.Peso(opcion) = 0
                For i As Byte = 0 To camino.Destino.N_Caminos - 1
                    If camino.Destino.Caminos(i).Destino.Valor = temp.Valor Then
                        camino.Destino.Caminos(i).Peso(opcion) = 0
                        Exit For
                    End If
                Next
            Else
                camino.Seleccion = False
                camino.Peso(opcion) = 0
                For i As Byte = 0 To camino.Destino.N_Caminos - 1
                    If camino.Destino.Caminos(i).Destino.Valor = temp.Valor Then
                        camino.Destino.Caminos(i).Seleccion = False
                        camino.Destino.Caminos(i).Peso(opcion) = 0
                        Exit For
                    End If
                Next
            End If
        End If

        For i As Byte = 0 To Municipios.Length - 1
            If Municipios(i).Checked Then contador += 1
        Next
        If contador < 10 Then Arbol(opcion)

        Return ImprimirArbol()
    End Function

    ''' <summary>
    ''' Genera en una cadena el arbol minimo
    ''' </summary>
    ''' <returns>Regresa el arbol minimo en una cadena</returns>
    ''' <remarks></remarks>
    Private Function ImprimirArbol() As String
        Dim cadena As String = ""

        For i As Byte = 0 To Municipios.Length - 1
            For j As Byte = 0 To Municipios(i).N_Caminos - 1
                If Municipios(i).Caminos(j).Seleccion Then cadena &= Municipios(i).Valor & " -> " & Municipios(i).Caminos(j).Destino.Valor & vbCrLf
            Next
        Next

        Return cadena
    End Function
End Class
