Module modStart

   Sub Main()
      Dim oAlleged As New AllegedRC4
      Dim oVerhoeff As New Verhoeff
      Dim oBase64 As New Base64
      Dim sMensaje As String = String.Empty
      Dim sKey As String = String.Empty
      Dim sCifra As String = String.Empty
      Dim sOption As String = String.Empty
      Dim iOption As Integer = 0, iNumero As Integer = 0
      Dim bContinue As Boolean = True
      Try
         While bContinue
            Console.WriteLine("---------------------")
            Console.WriteLine("Seleccione Algoritmo: ")
            Console.WriteLine("---------------------")
            Console.WriteLine("1. AllegedRC4")
            Console.WriteLine("2. Verhoeff")
            Console.WriteLine("3. Base64")
            Console.WriteLine("0. Salir")
            Console.WriteLine("---------------------")
            iOption = CInt(Console.ReadLine())
            Select Case iOption
               Case 1
                  Console.WriteLine("Ingrese el mensaje : ")
                  sMensaje = Console.ReadLine()
                  Console.WriteLine("Ingrese el Key : ")
                  sKey = Console.ReadLine()
                  Console.WriteLine("La cadena cifrada es : " & oAlleged.CifrarMensaje(sMensaje, sKey))
                  Console.WriteLine("---------------------------------")
               Case 2
                  Console.WriteLine("Verhoeff :" & vbCrLf & "Ingrese Cifra:")
                  sCifra = Console.ReadLine()
                  Console.WriteLine("El dígito verificador es : " & oVerhoeff.ObtenerVerhoeff(sCifra))
               Case 3
                  Console.WriteLine("Ingrese número :")
                  iNumero = CInt(Console.ReadLine)
                  Console.WriteLine("La palabra es : " & oBase64.Base64(iNumero))
               Case 0
                  bContinue = False
               Case Else
                  Console.WriteLine("Desea continuar? (y/n)")
                  sOption = Console.ReadLine()
                  If sOption.ToUpper.Equals("N") Then
                     bContinue = False
                  End If
            End Select
            If bContinue Then
               Console.WriteLine("Desea continuar? (y/n)")
               sOption = Console.ReadLine()
               If sOption.ToUpper.Equals("N") Then
                  bContinue = False
               End If
            End If
         End While

      Catch ex As Exception
         Console.WriteLine(ex.Message)
      Finally
         'oAlleged = Nothing
         oVerhoeff = Nothing
         Console.ReadLine()
      End Try
   End Sub

End Module
