Public Class Base64

   Public Function Base64(ByVal Numero As Integer) As String
      Dim Diccionario() As String = New String(63) {
                                                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                                "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                                "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d",
                                                "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                                                "o", "p", "q", "r", "s", "t", "u", "v", "w", "x",
                                                "y", "z", "+", "/"
                                               }
      Dim cociente As Integer = 1, resto As Integer
      Dim palabra As String = String.Empty
      Try
         While cociente > 0
            cociente = CInt(Math.Truncate(Numero / 64.0))
            resto = Numero Mod 64
            palabra = Diccionario(resto) & palabra
            Numero = cociente
         End While
         Return palabra
      Catch ex As Exception
         Throw ex
      End Try
   End Function

End Class
