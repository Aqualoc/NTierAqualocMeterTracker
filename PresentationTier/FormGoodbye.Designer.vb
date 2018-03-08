<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinal))
        Me.LblFinalHeading = New System.Windows.Forms.Label()
        Me.TxtFinalHeading = New System.Windows.Forms.TextBox()
        Me.ButtonFinalLogout = New System.Windows.Forms.Button()
        Me.ButtonFinalBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblFinalHeading
        '
        Me.LblFinalHeading.AutoSize = True
        Me.LblFinalHeading.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinalHeading.Location = New System.Drawing.Point(15, 9)
        Me.LblFinalHeading.Name = "LblFinalHeading"
        Me.LblFinalHeading.Size = New System.Drawing.Size(282, 29)
        Me.LblFinalHeading.TabIndex = 6
        Me.LblFinalHeading.Text = "Number Of Items Scanned:"
        '
        'TxtFinalHeading
        '
        Me.TxtFinalHeading.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFinalHeading.Location = New System.Drawing.Point(57, 65)
        Me.TxtFinalHeading.Name = "TxtFinalHeading"
        Me.TxtFinalHeading.Size = New System.Drawing.Size(193, 26)
        Me.TxtFinalHeading.TabIndex = 7
        '
        'ButtonFinalLogout
        '
        Me.ButtonFinalLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonFinalLogout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFinalLogout.Location = New System.Drawing.Point(31, 118)
        Me.ButtonFinalLogout.Name = "ButtonFinalLogout"
        Me.ButtonFinalLogout.Size = New System.Drawing.Size(116, 53)
        Me.ButtonFinalLogout.TabIndex = 8
        Me.ButtonFinalLogout.Text = "Logout"
        Me.ButtonFinalLogout.UseVisualStyleBackColor = False
        '
        'ButtonFinalBack
        '
        Me.ButtonFinalBack.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonFinalBack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFinalBack.Location = New System.Drawing.Point(166, 118)
        Me.ButtonFinalBack.Name = "ButtonFinalBack"
        Me.ButtonFinalBack.Size = New System.Drawing.Size(116, 53)
        Me.ButtonFinalBack.TabIndex = 9
        Me.ButtonFinalBack.Text = "Back "
        Me.ButtonFinalBack.UseVisualStyleBackColor = False
        '
        'frmFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(311, 197)
        Me.Controls.Add(Me.ButtonFinalBack)
        Me.Controls.Add(Me.ButtonFinalLogout)
        Me.Controls.Add(Me.TxtFinalHeading)
        Me.Controls.Add(Me.LblFinalHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFinal"
        Me.Text = "Final Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFinalHeading As Label
    Friend WithEvents TxtFinalHeading As TextBox
    Friend WithEvents ButtonFinalLogout As Button
    Friend WithEvents ButtonFinalBack As Button
End Class
