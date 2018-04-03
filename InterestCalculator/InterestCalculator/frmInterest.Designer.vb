<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterest
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
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblAnnualInterestRate = New System.Windows.Forms.Label()
        Me.lblTimesCompounded = New System.Windows.Forms.Label()
        Me.lblSimpleInterest = New System.Windows.Forms.Label()
        Me.lblCompoundInterest = New System.Windows.Forms.Label()
        Me.lblContinuous = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtTimesCompounded = New System.Windows.Forms.TextBox()
        Me.txtSimpleInterest = New System.Windows.Forms.TextBox()
        Me.txtCompoundInterest = New System.Windows.Forms.TextBox()
        Me.txtContinuousCompounding = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(29, 22)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(47, 13)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Principal"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(29, 53)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(34, 13)
        Me.lblYears.TabIndex = 1
        Me.lblYears.Text = "Years"
        '
        'lblAnnualInterestRate
        '
        Me.lblAnnualInterestRate.AutoSize = True
        Me.lblAnnualInterestRate.Location = New System.Drawing.Point(29, 84)
        Me.lblAnnualInterestRate.Name = "lblAnnualInterestRate"
        Me.lblAnnualInterestRate.Size = New System.Drawing.Size(104, 13)
        Me.lblAnnualInterestRate.TabIndex = 2
        Me.lblAnnualInterestRate.Text = "Annual Interest Rate"
        '
        'lblTimesCompounded
        '
        Me.lblTimesCompounded.AutoSize = True
        Me.lblTimesCompounded.Location = New System.Drawing.Point(29, 115)
        Me.lblTimesCompounded.Name = "lblTimesCompounded"
        Me.lblTimesCompounded.Size = New System.Drawing.Size(128, 13)
        Me.lblTimesCompounded.TabIndex = 3
        Me.lblTimesCompounded.Text = "Times Compounded/Year"
        '
        'lblSimpleInterest
        '
        Me.lblSimpleInterest.AutoSize = True
        Me.lblSimpleInterest.Location = New System.Drawing.Point(29, 167)
        Me.lblSimpleInterest.Name = "lblSimpleInterest"
        Me.lblSimpleInterest.Size = New System.Drawing.Size(76, 13)
        Me.lblSimpleInterest.TabIndex = 4
        Me.lblSimpleInterest.Text = "Simple Interest"
        '
        'lblCompoundInterest
        '
        Me.lblCompoundInterest.AutoSize = True
        Me.lblCompoundInterest.Location = New System.Drawing.Point(29, 198)
        Me.lblCompoundInterest.Name = "lblCompoundInterest"
        Me.lblCompoundInterest.Size = New System.Drawing.Size(96, 13)
        Me.lblCompoundInterest.TabIndex = 5
        Me.lblCompoundInterest.Text = "Compound Interest"
        '
        'lblContinuous
        '
        Me.lblContinuous.AutoSize = True
        Me.lblContinuous.Location = New System.Drawing.Point(29, 229)
        Me.lblContinuous.Name = "lblContinuous"
        Me.lblContinuous.Size = New System.Drawing.Size(128, 13)
        Me.lblContinuous.TabIndex = 6
        Me.lblContinuous.Text = "Continuous Compounding"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(185, 19)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipal.TabIndex = 7
        Me.txtPrincipal.Text = "6000"
        Me.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(185, 49)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 8
        Me.txtYears.Text = "7"
        Me.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(185, 79)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestRate.TabIndex = 9
        Me.txtInterestRate.Text = "4.0"
        Me.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTimesCompounded
        '
        Me.txtTimesCompounded.Location = New System.Drawing.Point(185, 109)
        Me.txtTimesCompounded.Name = "txtTimesCompounded"
        Me.txtTimesCompounded.Size = New System.Drawing.Size(100, 20)
        Me.txtTimesCompounded.TabIndex = 10
        Me.txtTimesCompounded.Text = "12"
        Me.txtTimesCompounded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSimpleInterest
        '
        Me.txtSimpleInterest.ForeColor = System.Drawing.Color.Blue
        Me.txtSimpleInterest.Location = New System.Drawing.Point(185, 164)
        Me.txtSimpleInterest.Name = "txtSimpleInterest"
        Me.txtSimpleInterest.ReadOnly = True
        Me.txtSimpleInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtSimpleInterest.TabIndex = 11
        Me.txtSimpleInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCompoundInterest
        '
        Me.txtCompoundInterest.ForeColor = System.Drawing.Color.Blue
        Me.txtCompoundInterest.Location = New System.Drawing.Point(185, 195)
        Me.txtCompoundInterest.Name = "txtCompoundInterest"
        Me.txtCompoundInterest.ReadOnly = True
        Me.txtCompoundInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtCompoundInterest.TabIndex = 12
        Me.txtCompoundInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContinuousCompounding
        '
        Me.txtContinuousCompounding.ForeColor = System.Drawing.Color.Blue
        Me.txtContinuousCompounding.Location = New System.Drawing.Point(185, 226)
        Me.txtContinuousCompounding.Name = "txtContinuousCompounding"
        Me.txtContinuousCompounding.ReadOnly = True
        Me.txtContinuousCompounding.Size = New System.Drawing.Size(100, 20)
        Me.txtContinuousCompounding.TabIndex = 13
        Me.txtContinuousCompounding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(210, 264)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(23, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 3)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "lblDivider"
        '
        'frmInterest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtContinuousCompounding)
        Me.Controls.Add(Me.txtCompoundInterest)
        Me.Controls.Add(Me.txtSimpleInterest)
        Me.Controls.Add(Me.txtTimesCompounded)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblContinuous)
        Me.Controls.Add(Me.lblCompoundInterest)
        Me.Controls.Add(Me.lblSimpleInterest)
        Me.Controls.Add(Me.lblTimesCompounded)
        Me.Controls.Add(Me.lblAnnualInterestRate)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Name = "frmInterest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple vs. Compound Interest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipal As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents lblAnnualInterestRate As Label
    Friend WithEvents lblTimesCompounded As Label
    Friend WithEvents lblSimpleInterest As Label
    Friend WithEvents lblCompoundInterest As Label
    Friend WithEvents lblContinuous As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtTimesCompounded As TextBox
    Friend WithEvents txtSimpleInterest As TextBox
    Friend WithEvents txtCompoundInterest As TextBox
    Friend WithEvents txtContinuousCompounding As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
End Class
