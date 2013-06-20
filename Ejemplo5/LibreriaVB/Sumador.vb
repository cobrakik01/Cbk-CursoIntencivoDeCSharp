Namespace LibreriaVb
    Public Class Sumador
        Public Function Sumar(ByVal n1 As String, ByVal n2 As String) As Integer
            Dim suma As Integer = 0
            suma = String.Concat((Integer.Parse(n1) + Integer.Parse(n2)))
            Return suma
        End Function
    End Class
End Namespace