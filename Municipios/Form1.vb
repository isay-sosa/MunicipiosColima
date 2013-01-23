Public Class Form1    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As New Colima
        If tiempo.Checked Then
            Ruta.Text = m.Ruta(Origen.Text, Destino.Text, 0)
        ElseIf distancia.Checked Then
            Ruta.Text = m.Ruta(Origen.Text, Destino.Text, 1)
        End If
    End Sub

    Private Sub Invertir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Invertir.LinkClicked
        Dim temp As String = Origen.Text
        Origen.Text = Destino.Text
        Destino.Text = temp
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim m As New Colima
        If tiempo2.Checked Then
            Resultado.Text = m.Arbol(0)
        ElseIf distancia2.Checked Then
            Resultado.Text = m.Arbol(1)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Origen.Text = Origen.Items(0).ToString
        Destino.Text = Destino.Items(1).ToString
    End Sub
End Class
