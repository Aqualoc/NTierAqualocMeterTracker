<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScanning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScanning))
        Me.ButtonScanningPass = New System.Windows.Forms.Button()
        Me.ButtonScanningFail = New System.Windows.Forms.Button()
        Me.TxtScanningConfig = New System.Windows.Forms.TextBox()
        Me.ButtonScanningNext = New System.Windows.Forms.Button()
        Me.LblScanningHeading = New System.Windows.Forms.Label()
        Me.TxtScanningHeading = New System.Windows.Forms.TextBox()
        Me.LblScanningOperator = New System.Windows.Forms.Label()
        Me.TxtScanningOperator = New System.Windows.Forms.TextBox()
        Me.chkScanning = New System.Windows.Forms.CheckBox()
        Me.chkScanningOperator = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFail = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonScanningPass
        '
        Me.ButtonScanningPass.BackColor = System.Drawing.Color.Ivory
        Me.ButtonScanningPass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningPass.Location = New System.Drawing.Point(23, 87)
        Me.ButtonScanningPass.Name = "ButtonScanningPass"
        Me.ButtonScanningPass.Size = New System.Drawing.Size(84, 72)
        Me.ButtonScanningPass.TabIndex = 0
        Me.ButtonScanningPass.Text = "Pass"
        Me.ButtonScanningPass.UseVisualStyleBackColor = False
        '
        'ButtonScanningFail
        '
        Me.ButtonScanningFail.BackColor = System.Drawing.Color.Red
        Me.ButtonScanningFail.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningFail.Location = New System.Drawing.Point(113, 87)
        Me.ButtonScanningFail.Name = "ButtonScanningFail"
        Me.ButtonScanningFail.Size = New System.Drawing.Size(86, 72)
        Me.ButtonScanningFail.TabIndex = 1
        Me.ButtonScanningFail.Text = "Fail"
        Me.ButtonScanningFail.UseVisualStyleBackColor = False
        '
        'TxtScanningConfig
        '
        Me.TxtScanningConfig.Enabled = False
        Me.TxtScanningConfig.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningConfig.Location = New System.Drawing.Point(113, 168)
        Me.TxtScanningConfig.Name = "TxtScanningConfig"
        Me.TxtScanningConfig.Size = New System.Drawing.Size(100, 26)
        Me.TxtScanningConfig.TabIndex = 2
        '
        'ButtonScanningNext
        '
        Me.ButtonScanningNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonScanningNext.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningNext.Location = New System.Drawing.Point(205, 87)
        Me.ButtonScanningNext.Name = "ButtonScanningNext"
        Me.ButtonScanningNext.Size = New System.Drawing.Size(86, 72)
        Me.ButtonScanningNext.TabIndex = 4
        Me.ButtonScanningNext.Text = "Finish"
        Me.ButtonScanningNext.UseVisualStyleBackColor = False
        '
        'LblScanningHeading
        '
        Me.LblScanningHeading.AutoSize = True
        Me.LblScanningHeading.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScanningHeading.Location = New System.Drawing.Point(35, 9)
        Me.LblScanningHeading.Name = "LblScanningHeading"
        Me.LblScanningHeading.Size = New System.Drawing.Size(256, 29)
        Me.LblScanningHeading.TabIndex = 5
        Me.LblScanningHeading.Text = "Barcode Scannned Data:"
        Me.LblScanningHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtScanningHeading
        '
        Me.TxtScanningHeading.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningHeading.Location = New System.Drawing.Point(49, 48)
        Me.TxtScanningHeading.Name = "TxtScanningHeading"
        Me.TxtScanningHeading.Size = New System.Drawing.Size(228, 26)
        Me.TxtScanningHeading.TabIndex = 6
        '
        'LblScanningOperator
        '
        Me.LblScanningOperator.AutoSize = True
        Me.LblScanningOperator.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScanningOperator.Location = New System.Drawing.Point(12, 200)
        Me.LblScanningOperator.Name = "LblScanningOperator"
        Me.LblScanningOperator.Size = New System.Drawing.Size(68, 18)
        Me.LblScanningOperator.TabIndex = 7
        Me.LblScanningOperator.Text = "Operator:"
        '
        'TxtScanningOperator
        '
        Me.TxtScanningOperator.Enabled = False
        Me.TxtScanningOperator.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningOperator.Location = New System.Drawing.Point(113, 200)
        Me.TxtScanningOperator.Name = "TxtScanningOperator"
        Me.TxtScanningOperator.Size = New System.Drawing.Size(100, 26)
        Me.TxtScanningOperator.TabIndex = 8
        '
        'chkScanning
        '
        Me.chkScanning.AutoSize = True
        Me.chkScanning.Location = New System.Drawing.Point(219, 177)
        Me.chkScanning.MinimumSize = New System.Drawing.Size(2, 2)
        Me.chkScanning.Name = "chkScanning"
        Me.chkScanning.Size = New System.Drawing.Size(15, 14)
        Me.chkScanning.TabIndex = 9
        Me.chkScanning.UseVisualStyleBackColor = True
        '
        'chkScanningOperator
        '
        Me.chkScanningOperator.AutoSize = True
        Me.chkScanningOperator.Location = New System.Drawing.Point(219, 206)
        Me.chkScanningOperator.Name = "chkScanningOperator"
        Me.chkScanningOperator.Size = New System.Drawing.Size(15, 14)
        Me.chkScanningOperator.TabIndex = 10
        Me.chkScanningOperator.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(12, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Configuration:"
        '
        'LblFail
        '
        Me.LblFail.AutoSize = True
        Me.LblFail.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFail.Location = New System.Drawing.Point(199, 261)
        Me.LblFail.Name = "LblFail"
        Me.LblFail.Size = New System.Drawing.Size(0, 33)
        Me.LblFail.TabIndex = 12
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.Location = New System.Drawing.Point(28, 261)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(0, 33)
        Me.LblPass.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fail Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Pass Count:"
        '
        'frmScanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(311, 308)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblFail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkScanningOperator)
        Me.Controls.Add(Me.chkScanning)
        Me.Controls.Add(Me.TxtScanningOperator)
        Me.Controls.Add(Me.LblScanningOperator)
        Me.Controls.Add(Me.TxtScanningHeading)
        Me.Controls.Add(Me.LblScanningHeading)
        Me.Controls.Add(Me.ButtonScanningNext)
        Me.Controls.Add(Me.TxtScanningConfig)
        Me.Controls.Add(Me.ButtonScanningFail)
        Me.Controls.Add(Me.ButtonScanningPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmScanning"
        Me.Text = "Scanning Process"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonScanningPass As Button
    Friend WithEvents ButtonScanningFail As Button
    Friend WithEvents TxtScanningConfig As TextBox
    Friend WithEvents ButtonScanningNext As Button
    Friend WithEvents LblScanningHeading As Label
    Friend WithEvents TxtScanningHeading As TextBox
    Friend WithEvents LblScanningOperator As Label
    Friend WithEvents TxtScanningOperator As TextBox
    Friend WithEvents chkScanning As CheckBox
    Friend WithEvents chkScanningOperator As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFail As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
