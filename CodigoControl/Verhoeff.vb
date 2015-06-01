Public Class Verhoeff

   Public Function ObtenerVerhoeff(ByVal Cifra As String) As Integer
      Dim Mul(,) As Integer = New Integer(9, 9) {
                                    {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
                                    {1, 2, 3, 4, 0, 6, 7, 8, 9, 5},
                                    {2, 3, 4, 0, 1, 7, 8, 9, 5, 6},
                                    {3, 4, 0, 1, 2, 8, 9, 5, 6, 7},
                                    {4, 0, 1, 2, 3, 9, 5, 6, 7, 8},
                                    {5, 9, 8, 7, 6, 0, 4, 3, 2, 1},
                                    {6, 5, 9, 8, 7, 1, 0, 4, 3, 2},
                                    {7, 6, 5, 9, 8, 2, 1, 0, 4, 3},
                                    {8, 7, 6, 5, 9, 3, 2, 1, 0, 4},
                                    {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
                                   }
      Dim Per(,) As Integer = New Integer(7, 9) {
                                    {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
                                    {1, 5, 7, 6, 2, 8, 3, 0, 9, 4},
                                    {5, 8, 0, 3, 7, 9, 6, 1, 4, 2},
                                    {8, 9, 1, 6, 0, 4, 3, 5, 2, 7},
                                    {9, 4, 5, 3, 1, 2, 6, 8, 7, 0},
                                    {4, 2, 8, 6, 5, 7, 3, 9, 0, 1},
                                    {2, 7, 9, 3, 8, 0, 6, 4, 1, 5},
                                    {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}
                                   }
      Dim Inv() As Integer = New Integer(9) {0, 4, 3, 2, 1, 5, 6, 7, 8, 9}
      Dim Check As Integer = 0, i As Integer
      Dim NumeroInvertido As String

      Try
         NumeroInvertido = InvierteNumero(Cifra)
         For i = 0 To NumeroInvertido.Length - 1
            Check = Mul(Check, Per(((i + 1) Mod 8), CInt(NumeroInvertido(i).ToString)))
         Next
         Return Inv(Check)
      Catch ex As Exception
         Throw ex
      End Try

   End Function

End Class
