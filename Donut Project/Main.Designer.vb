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
        Me.grpDoughnutOps = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.grpCoffeeOps = New System.Windows.Forms.GroupBox()
        Me.radCapp = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.grpCalcs = New System.Windows.Forms.GroupBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTotalDueOut = New System.Windows.Forms.Label()
        Me.lblSalesTaxOut = New System.Windows.Forms.Label()
        Me.lblSubtotalOut = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDoughnutOps.SuspendLayout()
        Me.grpCoffeeOps.SuspendLayout()
        Me.grpCalcs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDoughnutOps
        '
        Me.grpDoughnutOps.Controls.Add(Me.radFilled)
        Me.grpDoughnutOps.Controls.Add(Me.radChocolate)
        Me.grpDoughnutOps.Controls.Add(Me.radSugar)
        Me.grpDoughnutOps.Controls.Add(Me.radGlazed)
        Me.grpDoughnutOps.Location = New System.Drawing.Point(83, 66)
        Me.grpDoughnutOps.Name = "grpDoughnutOps"
        Me.grpDoughnutOps.Size = New System.Drawing.Size(200, 180)
        Me.grpDoughnutOps.TabIndex = 0
        Me.grpDoughnutOps.TabStop = False
        Me.grpDoughnutOps.Text = "Doughnut Choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(26, 142)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Padding = New System.Windows.Forms.Padding(5)
        Me.radFilled.Size = New System.Drawing.Size(122, 31)
        Me.radFilled.TabIndex = 3
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(26, 105)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Padding = New System.Windows.Forms.Padding(5)
        Me.radChocolate.Size = New System.Drawing.Size(152, 31)
        Me.radChocolate.TabIndex = 2
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "&Chocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(26, 68)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Padding = New System.Windows.Forms.Padding(5)
        Me.radSugar.Size = New System.Drawing.Size(127, 31)
        Me.radSugar.TabIndex = 1
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(26, 31)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Padding = New System.Windows.Forms.Padding(5)
        Me.radGlazed.Size = New System.Drawing.Size(134, 31)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'grpCoffeeOps
        '
        Me.grpCoffeeOps.Controls.Add(Me.radCapp)
        Me.grpCoffeeOps.Controls.Add(Me.radRegular)
        Me.grpCoffeeOps.Controls.Add(Me.radNone)
        Me.grpCoffeeOps.Location = New System.Drawing.Point(83, 280)
        Me.grpCoffeeOps.Name = "grpCoffeeOps"
        Me.grpCoffeeOps.Size = New System.Drawing.Size(200, 136)
        Me.grpCoffeeOps.TabIndex = 1
        Me.grpCoffeeOps.TabStop = False
        Me.grpCoffeeOps.Text = "Coffee Choices"
        '
        'radCapp
        '
        Me.radCapp.AutoSize = True
        Me.radCapp.Location = New System.Drawing.Point(26, 103)
        Me.radCapp.Name = "radCapp"
        Me.radCapp.Size = New System.Drawing.Size(153, 21)
        Me.radCapp.TabIndex = 3
        Me.radCapp.TabStop = True
        Me.radCapp.Text = "Ca&ppuccino ($2.75)"
        Me.radCapp.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(26, 66)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(129, 21)
        Me.radRegular.TabIndex = 2
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(26, 30)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(63, 21)
        Me.radNone.TabIndex = 1
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'grpCalcs
        '
        Me.grpCalcs.Controls.Add(Me.lblTotalDue)
        Me.grpCalcs.Controls.Add(Me.lblSalesTax)
        Me.grpCalcs.Controls.Add(Me.lblSubtotal)
        Me.grpCalcs.Controls.Add(Me.lblTotalDueOut)
        Me.grpCalcs.Controls.Add(Me.lblSalesTaxOut)
        Me.grpCalcs.Controls.Add(Me.lblSubtotalOut)
        Me.grpCalcs.Location = New System.Drawing.Point(330, 66)
        Me.grpCalcs.Name = "grpCalcs"
        Me.grpCalcs.Size = New System.Drawing.Size(223, 180)
        Me.grpCalcs.TabIndex = 2
        Me.grpCalcs.TabStop = False
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(16, 125)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(74, 17)
        Me.lblTotalDue.TabIndex = 5
        Me.lblTotalDue.Text = "Total Due:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(16, 87)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(74, 17)
        Me.lblSalesTax.TabIndex = 4
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(16, 45)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(64, 17)
        Me.lblSubtotal.TabIndex = 3
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTotalDueOut
        '
        Me.lblTotalDueOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDueOut.Location = New System.Drawing.Point(96, 124)
        Me.lblTotalDueOut.Name = "lblTotalDueOut"
        Me.lblTotalDueOut.Size = New System.Drawing.Size(100, 30)
        Me.lblTotalDueOut.TabIndex = 2
        '
        'lblSalesTaxOut
        '
        Me.lblSalesTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesTaxOut.Location = New System.Drawing.Point(96, 74)
        Me.lblSalesTaxOut.Name = "lblSalesTaxOut"
        Me.lblSalesTaxOut.Size = New System.Drawing.Size(100, 30)
        Me.lblSalesTaxOut.TabIndex = 1
        '
        'lblSubtotalOut
        '
        Me.lblSubtotalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotalOut.Location = New System.Drawing.Point(95, 32)
        Me.lblSubtotalOut.Name = "lblSubtotalOut"
        Me.lblSubtotalOut.Size = New System.Drawing.Size(100, 30)
        Me.lblSubtotalOut.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Our doughnuts and coffee are the best in town!"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(433, 280)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(120, 40)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(433, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 443)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpCalcs)
        Me.Controls.Add(Me.grpCoffeeOps)
        Me.Controls.Add(Me.grpDoughnutOps)
        Me.Name = "frmMain"
        Me.Text = "Donut Shoppe"
        Me.grpDoughnutOps.ResumeLayout(False)
        Me.grpDoughnutOps.PerformLayout()
        Me.grpCoffeeOps.ResumeLayout(False)
        Me.grpCoffeeOps.PerformLayout()
        Me.grpCalcs.ResumeLayout(False)
        Me.grpCalcs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpDoughnutOps As GroupBox
    Friend WithEvents grpCoffeeOps As GroupBox
    Friend WithEvents grpCalcs As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents radCapp As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTotalDueOut As Label
    Friend WithEvents lblSalesTaxOut As Label
    Friend WithEvents lblSubtotalOut As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
