Public Class Form1
    Private Sub btnCalcularPromedio_Click(sender As Object, e As EventArgs)
        ' Definir el arreglo de calificaciones de los estudiantes
        Dim calificaciones(,) As Double = {{7.5, 8.2}, {6.9, 7.8}, {8.1, 7.2}, {9.5, 9.0}, {7.8, 8.3}}

        ' Calcular el promedio de calificaciones de cada estudiante
        Dim promedioEstudiantes(4) As Double
        For i As Integer = 0 To 4
            Dim suma As Double = 0
            For j As Integer = 0 To 1
                suma += calificaciones(i, j)
            Next
            promedioEstudiantes(i) = suma / 2
        Next

        ' Calcular el promedio de calificaciones de toda la clase
        Dim sumaTotal As Double = 0
        For i As Integer = 0 To 4
            sumaTotal += promedioEstudiantes(i)
        Next
        Dim promedioClase As Double = sumaTotal / 5

        ' Mostrar los resultados en los controles de la interfaz
        txtPromedioEstudiante1.Text = promedioEstudiantes(0).ToString("F2")
        txtPromedioEstudiante2.Text = promedioEstudiantes(1).ToString("F2")
        txtPromedioEstudiante3.Text = promedioEstudiantes(2).ToString("F2")
        txtPromedioEstudiante4.Text = promedioEstudiantes(3).ToString("F2")
        txtPromedioEstudiante5.Text = promedioEstudiantes(4).ToString("F2")
        txtPromedioClase.Text = promedioClase.ToString("F2")
    End Sub
End Class

