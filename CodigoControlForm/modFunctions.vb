Module modFunctions

   Public Sub Swap(ByRef val1 As String, ByRef val2 As String)
      Dim tmp As String = val2
      val2 = val1
      val1 = tmp
   End Sub

   Public Function ZeroFill(ByVal val As String) As String
      If val.Length = 1 Then
         ZeroFill = "0" & val
      Else
         ZeroFill = val
      End If
   End Function

   Public Function ReverseNumber(ByVal Cipher As String) As String
      Dim sReversedNumber As String = String.Empty
      For i As Integer = 1 To Cipher.Length
         sReversedNumber &= Cipher(Cipher.Length - i)
      Next
      Return sReversedNumber
   End Function

End Module
