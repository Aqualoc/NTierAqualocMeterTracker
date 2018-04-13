<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQc
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
        Me.LblStation = New System.Windows.Forms.Label()
        Me.LblProblem = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.LblFix = New System.Windows.Forms.Label()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.LblBatch = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboQcProblem = New System.Windows.Forms.ComboBox()
        Me.cboQcStatus = New System.Windows.Forms.ComboBox()
        Me.cboQcFix = New System.Windows.Forms.ComboBox()
        Me.cboQcStation = New System.Windows.Forms.ComboBox()
        Me.txtQcBarcode = New System.Windows.Forms.TextBox()
        Me.txtQcBatch = New System.Windows.Forms.TextBox()
        Me.txtQcDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblStation
        '
        Me.LblStation.AutoSize = True
        Me.LblStation.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStation.Location = New System.Drawing.Point(16, 75)
        Me.LblStation.Name = "LblStation"
        Me.LblStation.Size = New System.Drawing.Size(68, 25)
        Me.LblStation.TabIndex = 0
        Me.LblStation.Text = "Station"
        '
        'LblProblem
        '
        Me.LblProblem.AutoSize = True
        Me.LblProblem.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProblem.Location = New System.Drawing.Point(306, 71)
        Me.LblProblem.Name = "LblProblem"
        Me.LblProblem.Size = New System.Drawing.Size(80, 25)
        Me.LblProblem.TabIndex = 1
        Me.LblProblem.Text = "Problem"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(306, 256)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(61, 25)
        Me.LblStatus.TabIndex = 2
        Me.LblStatus.Text = "Status"
        '
        'LblDateTime
        '
        Me.LblDateTime.AutoSize = True
        Me.LblDateTime.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateTime.Location = New System.Drawing.Point(16, 259)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(132, 25)
        Me.LblDateTime.TabIndex = 3
        Me.LblDateTime.Text = "Date and Time"
        '
        'LblFix
        '
        Me.LblFix.AutoSize = True
        Me.LblFix.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFix.Location = New System.Drawing.Point(306, 161)
        Me.LblFix.Name = "LblFix"
        Me.LblFix.Size = New System.Drawing.Size(33, 25)
        Me.LblFix.TabIndex = 4
        Me.LblFix.Text = "Fix"
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(16, 131)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(80, 25)
        Me.LblBarcode.TabIndex = 5
        Me.LblBarcode.Text = "Barcode"
        '
        'LblBatch
        '
        Me.LblBatch.AutoSize = True
        Me.LblBatch.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBatch.Location = New System.Drawing.Point(16, 196)
        Me.LblBatch.Name = "LblBatch"
        Me.LblBatch.Size = New System.Drawing.Size(130, 25)
        Me.LblBatch.TabIndex = 6
        Me.LblBatch.Text = "Batch Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 40)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "QC Analysis"
        '
        'cboQcProblem
        '
        Me.cboQcProblem.FormattingEnabled = True
        Me.cboQcProblem.Location = New System.Drawing.Point(403, 73)
        Me.cboQcProblem.Name = "cboQcProblem"
        Me.cboQcProblem.Size = New System.Drawing.Size(111, 21)
        Me.cboQcProblem.TabIndex = 8
        '
        'cboQcStatus
        '
        Me.cboQcStatus.FormattingEnabled = True
        Me.cboQcStatus.Items.AddRange(New Object() {"Repaired", "Scrapped", "Repair Process"})
        Me.cboQcStatus.Location = New System.Drawing.Point(403, 258)
        Me.cboQcStatus.Name = "cboQcStatus"
        Me.cboQcStatus.Size = New System.Drawing.Size(111, 21)
        Me.cboQcStatus.TabIndex = 9
        '
        'cboQcFix
        '
        Me.cboQcFix.FormattingEnabled = True
        Me.cboQcFix.Location = New System.Drawing.Point(403, 161)
        Me.cboQcFix.Name = "cboQcFix"
        Me.cboQcFix.Size = New System.Drawing.Size(111, 21)
        Me.cboQcFix.TabIndex = 10
        '
        'cboQcStation
        '
        Me.cboQcStation.FormattingEnabled = True
        Me.cboQcStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4"})
        Me.cboQcStation.Location = New System.Drawing.Point(146, 75)
        Me.cboQcStation.Name = "cboQcStation"
        Me.cboQcStation.Size = New System.Drawing.Size(111, 21)
        Me.cboQcStation.TabIndex = 11
        '
        'txtQcBarcode
        '
        Me.txtQcBarcode.Location = New System.Drawing.Point(147, 135)
        Me.txtQcBarcode.Name = "txtQcBarcode"
        Me.txtQcBarcode.Size = New System.Drawing.Size(112, 20)
        Me.txtQcBarcode.TabIndex = 12
        '
        'txtQcBatch
        '
        Me.txtQcBatch.Location = New System.Drawing.Point(147, 196)
        Me.txtQcBatch.Name = "txtQcBatch"
        Me.txtQcBatch.Size = New System.Drawing.Size(112, 20)
        Me.txtQcBatch.TabIndex = 13
        '
        'txtQcDate
        '
        Me.txtQcDate.Location = New System.Drawing.Point(147, 259)
        Me.txtQcDate.Name = "txtQcDate"
        Me.txtQcDate.Size = New System.Drawing.Size(112, 20)
        Me.txtQcDate.TabIndex = 14
        '
        'FormQc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(559, 320)
        Me.Controls.Add(Me.txtQcDate)
        Me.Controls.Add(Me.txtQcBatch)
        Me.Controls.Add(Me.txtQcBarcode)
        Me.Controls.Add(Me.cboQcStation)
        Me.Controls.Add(Me.cboQcFix)
        Me.Controls.Add(Me.cboQcStatus)
        Me.Controls.Add(Me.cboQcProblem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblBatch)
        Me.Controls.Add(Me.LblBarcode)
        Me.Controls.Add(Me.LblFix)
        Me.Controls.Add(Me.LblDateTime)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblProblem)
        Me.Controls.Add(Me.LblStation)
        Me.Name = "FormQc"
        Me.Text = "FormQC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStation As Label
    Friend WithEvents LblProblem As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents LblFix As Label
    Friend WithEvents LblBarcode As Label
    Friend WithEvents LblBatch As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboQcProblem As ComboBox
    Friend WithEvents cboQcStatus As ComboBox
    Friend WithEvents cboQcFix As ComboBox
    Friend WithEvents cboQcStation As ComboBox
    Friend WithEvents txtQcBarcode As TextBox
    Friend WithEvents txtQcBatch As TextBox
    Friend WithEvents txtQcDate As TextBox
End Class
