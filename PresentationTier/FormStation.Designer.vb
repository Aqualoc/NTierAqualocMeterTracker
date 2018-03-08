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
        Me.TxtScanningHeading = New System.Windows.Forms.TextBox()
        Me.LblScanningOperator = New System.Windows.Forms.Label()
        Me.TxtScanningOperator = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonScanningPass
        '
        Me.ButtonScanningPass.BackColor = System.Drawing.Color.Ivory
        Me.ButtonScanningPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanningPass.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningPass.Location = New System.Drawing.Point(12, 218)
        Me.ButtonScanningPass.Name = "ButtonScanningPass"
        Me.ButtonScanningPass.Size = New System.Drawing.Size(142, 72)
        Me.ButtonScanningPass.TabIndex = 0
        Me.ButtonScanningPass.Text = "Pass"
        Me.ButtonScanningPass.UseVisualStyleBackColor = False
        '
        'ButtonScanningFail
        '
        Me.ButtonScanningFail.BackColor = System.Drawing.Color.Red
        Me.ButtonScanningFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanningFail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningFail.Location = New System.Drawing.Point(160, 218)
        Me.ButtonScanningFail.Name = "ButtonScanningFail"
        Me.ButtonScanningFail.Size = New System.Drawing.Size(139, 72)
        Me.ButtonScanningFail.TabIndex = 1
        Me.ButtonScanningFail.Text = "Fail"
        Me.ButtonScanningFail.UseVisualStyleBackColor = False
        '
        'TxtScanningConfig
        '
        Me.TxtScanningConfig.Enabled = False
        Me.TxtScanningConfig.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningConfig.Location = New System.Drawing.Point(149, 45)
        Me.TxtScanningConfig.Name = "TxtScanningConfig"
        Me.TxtScanningConfig.Size = New System.Drawing.Size(100, 22)
        Me.TxtScanningConfig.TabIndex = 2
        '
        'ButtonScanningNext
        '
        Me.ButtonScanningNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonScanningNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanningNext.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonScanningNext.Location = New System.Drawing.Point(12, 334)
        Me.ButtonScanningNext.Name = "ButtonScanningNext"
        Me.ButtonScanningNext.Size = New System.Drawing.Size(287, 72)
        Me.ButtonScanningNext.TabIndex = 4
        Me.ButtonScanningNext.Text = "Finish"
        Me.ButtonScanningNext.UseVisualStyleBackColor = False
        '
        'TxtScanningHeading
        '
        Me.TxtScanningHeading.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningHeading.Location = New System.Drawing.Point(51, 175)
        Me.TxtScanningHeading.Name = "TxtScanningHeading"
        Me.TxtScanningHeading.Size = New System.Drawing.Size(228, 22)
        Me.TxtScanningHeading.TabIndex = 6
        '
        'LblScanningOperator
        '
        Me.LblScanningOperator.AutoSize = True
        Me.LblScanningOperator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScanningOperator.Location = New System.Drawing.Point(48, 77)
        Me.LblScanningOperator.Name = "LblScanningOperator"
        Me.LblScanningOperator.Size = New System.Drawing.Size(57, 13)
        Me.LblScanningOperator.TabIndex = 7
        Me.LblScanningOperator.Text = "Operator:"
        '
        'TxtScanningOperator
        '
        Me.TxtScanningOperator.Enabled = False
        Me.TxtScanningOperator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningOperator.Location = New System.Drawing.Point(149, 77)
        Me.TxtScanningOperator.Name = "TxtScanningOperator"
        Me.TxtScanningOperator.Size = New System.Drawing.Size(100, 22)
        Me.TxtScanningOperator.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(48, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Configuration:"
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.Location = New System.Drawing.Point(35, 293)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(0, 13)
        Me.LblPass.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fail Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Pass Count:"
        '
        'frmScanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(311, 418)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtScanningOperator)
        Me.Controls.Add(Me.LblScanningOperator)
        Me.Controls.Add(Me.TxtScanningHeading)
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
    Friend WithEvents TxtScanningHeading As TextBox
    Friend WithEvents LblScanningOperator As Label
    Friend WithEvents TxtScanningOperator As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
