Public Class frmMain

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
      Dim sAuthNumber As String = String.Empty
      Dim sReceiptNumber As String = String.Empty
      Dim sCustomerNIT As String = String.Empty
      Dim sSalesDate As String = String.Empty
      Dim sSalesAmount As String = String.Empty
      Dim sKey As String = String.Empty
      Dim sVerhoefDiggits As String = String.Empty
      Dim dSalesAmount As Double = 0.0
      Try
         sAuthNumber = txtAuthNumber.Text.ToString.Trim
         sReceiptNumber = txtReceiptNumber.Text.ToString.Trim
         sCustomerNIT = txtNIT.Text.ToString.Trim
         sSalesDate = txtSalesDate.Text.ToString.Trim
         sSalesAmount = CDbl(txtSalesAmount.Text.ToString.Trim.Replace(",", ".")).ToString("#")
         'dSalesAmount = CDbl(sSalesAmount)
         'sSalesAmount = dSalesAmount.ToString("n")
         sKey = txtKey.Text.ToString.Trim
         ' Step 1
         For i As Integer = 1 To 2
            sReceiptNumber &= Verhoeff(sReceiptNumber)
            sCustomerNIT &= Verhoeff(sCustomerNIT)
            sSalesDate &= Verhoeff(sSalesDate)
            sSalesAmount &= Verhoeff(sSalesAmount)
         Next

         sVerhoefDiggits = (CLng(sReceiptNumber) + CLng(sCustomerNIT) + CLng(sSalesDate) + CLng(sSalesAmount)).ToString

         For i As Integer = 1 To 5
            sVerhoefDiggits &= Verhoeff(sVerhoefDiggits)
         Next

         sVerhoefDiggits = sVerhoefDiggits.Substring(sVerhoefDiggits.Length - 5, 5)
         Dim sTmp1 As String = String.Empty, sTmp2 As String = String.Empty, sTmp3 As String = String.Empty, sTmp4 As String = String.Empty, sTmp5 As String = String.Empty
         Dim sMessage As String = String.Empty, sKeyTmp As String = String.Empty, sAllegedRC4 As String = String.Empty
         Dim iTmpLength As Integer = 0, ST As Integer = 0, SP1 As Integer = 0, SP2 As Integer = 0, SP3 As Integer = 0, SP4 As Integer = 0, SP5 As Integer = 0
         ' Step 2
         For i As Integer = 1 To 5
            iTmpLength = CInt(sVerhoefDiggits(i - 1).ToString) + 1
            Select Case i
               Case 1
                  sTmp1 = sKey.Substring(0, iTmpLength)
               Case 2
                  sTmp2 = sKey.Substring(sTmp1.Length, iTmpLength)
               Case 3
                  sTmp3 = sKey.Substring(sTmp1.Length + sTmp2.Length, iTmpLength)
               Case 4
                  sTmp4 = sKey.Substring(sTmp1.Length + sTmp2.Length + sTmp3.Length, iTmpLength)
               Case 5
                  sTmp5 = sKey.Substring(sTmp1.Length + sTmp2.Length + sTmp3.Length + sTmp4.Length, iTmpLength)
            End Select
         Next

         sTmp1 = sAuthNumber & sTmp1
         sTmp2 = sReceiptNumber & sTmp2
         sTmp3 = sCustomerNIT & sTmp3
         sTmp4 = sSalesDate & sTmp4
         sTmp5 = sSalesAmount & sTmp5

         'Step 3
         sMessage = sTmp1 & sTmp2 & sTmp3 & sTmp4 & sTmp5
         sKeyTmp = sKey & sVerhoefDiggits

         sAllegedRC4 = AllegedRC4(sMessage, sKeyTmp)
         sAllegedRC4 = sAllegedRC4.Replace("-", "")

         ' Step 4
         For i As Integer = 0 To sAllegedRC4.Length - 1
            ST += Asc(sAllegedRC4(i))
         Next

         For i As Integer = 1 To 5
            For j As Integer = 0 To sAllegedRC4.Length / 5
               If ((j * 5) + i - 1) >= sAllegedRC4.Length Then
                  Continue For
               End If
               Select Case i
                  Case 1
                     SP1 += Asc(sAllegedRC4((j * 5) + i - 1))
                  Case 2
                     SP2 += Asc(sAllegedRC4((j * 5) + i - 1))
                  Case 3
                     SP3 += Asc(sAllegedRC4((j * 5) + i - 1))
                  Case 4
                     SP4 += Asc(sAllegedRC4((j * 5) + i - 1))
                  Case 5
                     SP5 += Asc(sAllegedRC4((j * 5) + i - 1))
               End Select
            Next
         Next

         ' Step 5
         Dim iTmp1 As Integer = 0, iTmp2 As Integer = 0, iTmp3 As Integer = 0, iTmp4 As Integer = 0, iTmp5 As Integer = 0
         iTmp1 = CInt(Math.Truncate(ST * SP1 / (CInt(sVerhoefDiggits(0).ToString) + 1)))
         iTmp2 = CInt(Math.Truncate(ST * SP2 / (CInt(sVerhoefDiggits(1).ToString) + 1)))
         iTmp3 = CInt(Math.Truncate(ST * SP3 / (CInt(sVerhoefDiggits(2).ToString) + 1)))
         iTmp4 = CInt(Math.Truncate(ST * SP4 / (CInt(sVerhoefDiggits(3).ToString) + 1)))
         iTmp5 = CInt(Math.Truncate(ST * SP5 / (CInt(sVerhoefDiggits(4).ToString) + 1)))

         Dim sBase64Tmp As String = Base64((iTmp1 + iTmp2 + iTmp3 + iTmp4 + iTmp5).ToString)

         ' Step 6
         sAllegedRC4 = AllegedRC4(sBase64Tmp, sKeyTmp)

         ' Generated Code
         Me.txtControlCode.Text = sAllegedRC4
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub
End Class
