<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.lblAuthNumber = New System.Windows.Forms.Label()
      Me.lblReceiptNumber = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.lblNIT = New System.Windows.Forms.Label()
      Me.lblSalesAmount = New System.Windows.Forms.Label()
      Me.lblSalesDate = New System.Windows.Forms.Label()
      Me.lblKey = New System.Windows.Forms.Label()
      Me.txtAuthNumber = New System.Windows.Forms.TextBox()
      Me.txtSalesAmount = New System.Windows.Forms.TextBox()
      Me.txtSalesDate = New System.Windows.Forms.TextBox()
      Me.txtNIT = New System.Windows.Forms.TextBox()
      Me.txtReceiptNumber = New System.Windows.Forms.TextBox()
      Me.txtKey = New System.Windows.Forms.TextBox()
      Me.btnOk = New System.Windows.Forms.Button()
      Me.lblControlCode = New System.Windows.Forms.Label()
      Me.txtControlCode = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'lblAuthNumber
      '
      Me.lblAuthNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAuthNumber.Location = New System.Drawing.Point(16, 30)
      Me.lblAuthNumber.Name = "lblAuthNumber"
      Me.lblAuthNumber.Size = New System.Drawing.Size(160, 23)
      Me.lblAuthNumber.TabIndex = 0
      Me.lblAuthNumber.Text = "Número de Autorización:"
      Me.lblAuthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblReceiptNumber
      '
      Me.lblReceiptNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReceiptNumber.Location = New System.Drawing.Point(16, 70)
      Me.lblReceiptNumber.Name = "lblReceiptNumber"
      Me.lblReceiptNumber.Size = New System.Drawing.Size(160, 23)
      Me.lblReceiptNumber.TabIndex = 0
      Me.lblReceiptNumber.Text = "Número de Factura:"
      Me.lblReceiptNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label2
      '
      Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 144)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(160, 23)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Número de Autorización:"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblNIT
      '
      Me.lblNIT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNIT.Location = New System.Drawing.Point(16, 110)
      Me.lblNIT.Name = "lblNIT"
      Me.lblNIT.Size = New System.Drawing.Size(160, 23)
      Me.lblNIT.TabIndex = 0
      Me.lblNIT.Text = "NIT/CI del Cliente:"
      Me.lblNIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblSalesAmount
      '
      Me.lblSalesAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSalesAmount.Location = New System.Drawing.Point(16, 190)
      Me.lblSalesAmount.Name = "lblSalesAmount"
      Me.lblSalesAmount.Size = New System.Drawing.Size(160, 23)
      Me.lblSalesAmount.TabIndex = 0
      Me.lblSalesAmount.Text = "Monto de la Transacción:"
      Me.lblSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblSalesDate
      '
      Me.lblSalesDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSalesDate.Location = New System.Drawing.Point(16, 150)
      Me.lblSalesDate.Name = "lblSalesDate"
      Me.lblSalesDate.Size = New System.Drawing.Size(160, 23)
      Me.lblSalesDate.TabIndex = 0
      Me.lblSalesDate.Text = "Fecha de la Transacción:"
      Me.lblSalesDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'lblKey
      '
      Me.lblKey.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblKey.Location = New System.Drawing.Point(16, 230)
      Me.lblKey.Name = "lblKey"
      Me.lblKey.Size = New System.Drawing.Size(160, 23)
      Me.lblKey.TabIndex = 0
      Me.lblKey.Text = "Llave de Dosificación:"
      Me.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtAuthNumber
      '
      Me.txtAuthNumber.Location = New System.Drawing.Point(192, 32)
      Me.txtAuthNumber.Name = "txtAuthNumber"
      Me.txtAuthNumber.Size = New System.Drawing.Size(264, 21)
      Me.txtAuthNumber.TabIndex = 0
      '
      'txtSalesAmount
      '
      Me.txtSalesAmount.Location = New System.Drawing.Point(192, 192)
      Me.txtSalesAmount.Name = "txtSalesAmount"
      Me.txtSalesAmount.Size = New System.Drawing.Size(264, 21)
      Me.txtSalesAmount.TabIndex = 4
      '
      'txtSalesDate
      '
      Me.txtSalesDate.Location = New System.Drawing.Point(192, 152)
      Me.txtSalesDate.Name = "txtSalesDate"
      Me.txtSalesDate.Size = New System.Drawing.Size(264, 21)
      Me.txtSalesDate.TabIndex = 3
      '
      'txtNIT
      '
      Me.txtNIT.Location = New System.Drawing.Point(192, 112)
      Me.txtNIT.Name = "txtNIT"
      Me.txtNIT.Size = New System.Drawing.Size(264, 21)
      Me.txtNIT.TabIndex = 2
      '
      'txtReceiptNumber
      '
      Me.txtReceiptNumber.Location = New System.Drawing.Point(192, 72)
      Me.txtReceiptNumber.Name = "txtReceiptNumber"
      Me.txtReceiptNumber.Size = New System.Drawing.Size(264, 21)
      Me.txtReceiptNumber.TabIndex = 1
      '
      'txtKey
      '
      Me.txtKey.Location = New System.Drawing.Point(192, 232)
      Me.txtKey.Name = "txtKey"
      Me.txtKey.Size = New System.Drawing.Size(264, 21)
      Me.txtKey.TabIndex = 5
      '
      'btnOk
      '
      Me.btnOk.Location = New System.Drawing.Point(344, 272)
      Me.btnOk.Name = "btnOk"
      Me.btnOk.Size = New System.Drawing.Size(112, 32)
      Me.btnOk.TabIndex = 6
      Me.btnOk.Text = "GENERAR"
      Me.btnOk.UseVisualStyleBackColor = True
      '
      'lblControlCode
      '
      Me.lblControlCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblControlCode.Location = New System.Drawing.Point(16, 320)
      Me.lblControlCode.Name = "lblControlCode"
      Me.lblControlCode.Size = New System.Drawing.Size(160, 23)
      Me.lblControlCode.TabIndex = 0
      Me.lblControlCode.Text = "Código de Control:"
      Me.lblControlCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtControlCode
      '
      Me.txtControlCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtControlCode.Location = New System.Drawing.Point(192, 320)
      Me.txtControlCode.Name = "txtControlCode"
      Me.txtControlCode.Size = New System.Drawing.Size(264, 23)
      Me.txtControlCode.TabIndex = 0
      Me.txtControlCode.Text = "Generated Code"
      Me.txtControlCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(478, 385)
      Me.Controls.Add(Me.btnOk)
      Me.Controls.Add(Me.txtKey)
      Me.Controls.Add(Me.txtReceiptNumber)
      Me.Controls.Add(Me.txtNIT)
      Me.Controls.Add(Me.txtSalesDate)
      Me.Controls.Add(Me.txtSalesAmount)
      Me.Controls.Add(Me.txtAuthNumber)
      Me.Controls.Add(Me.lblSalesDate)
      Me.Controls.Add(Me.txtControlCode)
      Me.Controls.Add(Me.lblControlCode)
      Me.Controls.Add(Me.lblKey)
      Me.Controls.Add(Me.lblSalesAmount)
      Me.Controls.Add(Me.lblNIT)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.lblReceiptNumber)
      Me.Controls.Add(Me.lblAuthNumber)
      Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.MaximizeBox = False
      Me.Name = "frmMain"
      Me.ShowIcon = False
      Me.Text = "Código de Control"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblAuthNumber As System.Windows.Forms.Label
   Friend WithEvents lblReceiptNumber As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblNIT As System.Windows.Forms.Label
   Friend WithEvents lblSalesAmount As System.Windows.Forms.Label
   Friend WithEvents lblSalesDate As System.Windows.Forms.Label
   Friend WithEvents lblKey As System.Windows.Forms.Label
   Friend WithEvents txtAuthNumber As System.Windows.Forms.TextBox
   Friend WithEvents txtSalesAmount As System.Windows.Forms.TextBox
   Friend WithEvents txtSalesDate As System.Windows.Forms.TextBox
   Friend WithEvents txtNIT As System.Windows.Forms.TextBox
   Friend WithEvents txtReceiptNumber As System.Windows.Forms.TextBox
   Friend WithEvents txtKey As System.Windows.Forms.TextBox
   Friend WithEvents btnOk As System.Windows.Forms.Button
   Friend WithEvents lblControlCode As System.Windows.Forms.Label
   Friend WithEvents txtControlCode As System.Windows.Forms.Label

End Class
