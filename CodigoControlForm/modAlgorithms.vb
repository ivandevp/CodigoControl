Module modAlgorithms

   Public Function AllegedRC4(ByVal Message As String, ByVal Key As String) As String
      Dim state(255) As Integer
      Dim x As Integer = 0
      Dim y As Integer = 0
      Dim index1 As Integer = 0
      Dim index2 As Integer = 0
      Dim nMen As Integer
      Dim i As Integer
      Dim EncryptedMessage As String = String.Empty
      Try
         For i = 0 To 255
            state(i) = i
         Next
         For i = 0 To 255
            index2 = (Asc(Key(index1)) + state(i) + index2) Mod 256
            Swap(state(i), state(index2))
            index1 = (index1 + 1) Mod Key.Length
         Next
         For i = 0 To Message.Length - 1
            x = (x + 1) Mod 256
            y = (state(x) + y) Mod 256
            Swap(state(x), state(y))
            nMen = Asc(Message(i)) Xor state((state(x) + state(y)) Mod 256)
            EncryptedMessage &= "-" & ZeroFill(Hex(nMen))
         Next

         Return EncryptedMessage.Substring(1, EncryptedMessage.Length - 1)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function Verhoeff(ByVal Cipher As String) As Integer
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
         NumeroInvertido = ReverseNumber(Cipher)
         For i = 0 To NumeroInvertido.Length - 1
            Check = Mul(Check, Per(((i + 1) Mod 8), CInt(NumeroInvertido(i).ToString)))
         Next
         Return Inv(Check)
      Catch ex As Exception
         Throw ex
      End Try

   End Function

   Public Function Base64(ByVal Number As Integer) As String
      Dim Dictionary() As String = New String(63) {
                                                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                                "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                                "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d",
                                                "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                                                "o", "p", "q", "r", "s", "t", "u", "v", "w", "x",
                                                "y", "z", "+", "/"
                                               }
      Dim quotient As Integer = 1, reminder As Integer
      Dim word As String = String.Empty
      Try
         While quotient > 0
            quotient = CInt(Math.Truncate(Number / 64.0))
            reminder = Number Mod 64
            word = Dictionary(reminder) & word
            Number = quotient
         End While
         Return word
      Catch ex As Exception
         Throw ex
      End Try
   End Function

End Module
