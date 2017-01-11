<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnVerifyAddress = New System.Windows.Forms.Button()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZipcode = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnVerifyAddress
        '
        Me.btnVerifyAddress.AutoSize = True
        Me.btnVerifyAddress.Location = New System.Drawing.Point(15, 162)
        Me.btnVerifyAddress.Name = "btnVerifyAddress"
        Me.btnVerifyAddress.Size = New System.Drawing.Size(263, 23)
        Me.btnVerifyAddress.TabIndex = 0
        Me.btnVerifyAddress.Text = "Verify Address"
        Me.btnVerifyAddress.UseVisualStyleBackColor = True
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(12, 15)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(57, 13)
        Me.lblAddress1.TabIndex = 1
        Me.lblAddress1.Text = "Address 1:"
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Location = New System.Drawing.Point(12, 44)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(57, 13)
        Me.lblAddress2.TabIndex = 2
        Me.lblAddress2.Text = "Address 2:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(12, 73)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 3
        Me.lblCity.Text = "City:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(12, 102)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "State:"
        '
        'lblZipcode
        '
        Me.lblZipcode.AutoSize = True
        Me.lblZipcode.Location = New System.Drawing.Point(12, 131)
        Me.lblZipcode.Name = "lblZipcode"
        Me.lblZipcode.Size = New System.Drawing.Size(49, 13)
        Me.lblZipcode.TabIndex = 5
        Me.lblZipcode.Text = "Zipcode:"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(18, 196)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(45, 13)
        Me.lblResults.TabIndex = 7
        Me.lblResults.Text = "Results:"
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(87, 12)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(191, 20)
        Me.txtAddress1.TabIndex = 8
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(87, 41)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(191, 20)
        Me.txtAddress2.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(87, 70)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(191, 20)
        Me.txtCity.TabIndex = 10
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(87, 99)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(191, 20)
        Me.txtState.TabIndex = 11
        '
        'txtZipcode
        '
        Me.txtZipcode.Location = New System.Drawing.Point(87, 128)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(191, 20)
        Me.txtZipcode.TabIndex = 12
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(15, 212)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(263, 253)
        Me.txtResults.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 477)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtZipcode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblZipcode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress2)
        Me.Controls.Add(Me.lblAddress1)
        Me.Controls.Add(Me.btnVerifyAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smarty Street - VB .NET Sample App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerifyAddress As Button
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZipcode As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents txtResults As TextBox
End Class
