Public Class AllegedRC4

   Public Function CifrarMensaje(ByVal Mensaje As String, ByVal Key As String) As String
      Dim state(255) As Integer
      Dim x As Integer = 0
      Dim y As Integer = 0
      Dim index1 As Integer = 0
      Dim index2 As Integer = 0
      Dim nMen As Integer
      Dim i As Integer
      Dim MensajeCifrado As String = String.Empty
      Try
         For i = 0 To 255
            state(i) = i
         Next
         For i = 0 To 255
            index2 = (Asc(Key(index1)) + state(i) + index2) Mod 256
            IntercambiarValor(state(i), state(index2))
            index1 = (index1 + 1) Mod Key.Length
         Next
         For i = 0 To Mensaje.Length - 1
            x = (x + 1) Mod 256
            y = (state(x) + y) Mod 256
            IntercambiarValor(state(x), state(y))
            nMen = Asc(Mensaje(i)) Xor state((state(x) + state(y)) Mod 256)
            MensajeCifrado &= "-" & RellenaCero(Hex(nMen))
         Next

         Return MensajeCifrado.Substring(1, MensajeCifrado.Length - 1)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

End Class
