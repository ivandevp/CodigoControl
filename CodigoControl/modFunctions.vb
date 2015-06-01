Module modFunctions

   Public Sub IntercambiarValor(ByRef val1 As String, ByRef val2 As String)
      Dim tmp As String = val2
      val2 = val1
      val1 = tmp
   End Sub

   Public Function RellenaCero(ByVal val As String) As String
      If val.Length = 1 Then
         RellenaCero = "0" & val
      Else
         RellenaCero = val
      End If
   End Function

   Public Function InvierteNumero(ByVal Cifra As String) As String
      Dim sCifraInvertida As String = String.Empty
      For i As Integer = 1 To Cifra.Length
         sCifraInvertida &= Cifra(Cifra.Length - i)
      Next
      Return sCifraInvertida
   End Function

End Module
