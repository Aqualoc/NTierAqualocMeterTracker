<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LblloginHeading = New System.Windows.Forms.Label()
        Me.LblLoginLog = New System.Windows.Forms.Label()
        Me.LblLoginPassword = New System.Windows.Forms.Label()
        Me.LblLoginStation = New System.Windows.Forms.Label()
        Me.cboLogin = New System.Windows.Forms.ComboBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.cboLoginStation = New System.Windows.Forms.ComboBox()
        Me.StationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbLoginCancel = New System.Windows.Forms.Button()
        Me.cmbLoginOk = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsersTableAdapter = New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager()
        Me.StationsTableAdapter = New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblloginHeading
        '
        Me.LblloginHeading.AutoSize = True
        Me.LblloginHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblloginHeading.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblloginHeading.Location = New System.Drawing.Point(82, 35)
        Me.LblloginHeading.Name = "LblloginHeading"
        Me.LblloginHeading.Size = New System.Drawing.Size(275, 32)
        Me.LblloginHeading.TabIndex = 0
        Me.LblloginHeading.Text = "Please Login to Proceed:"
        Me.LblloginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLoginLog
        '
        Me.LblLoginLog.AutoSize = True
        Me.LblLoginLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLoginLog.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoginLog.Location = New System.Drawing.Point(74, 101)
        Me.LblLoginLog.Name = "LblLoginLog"
        Me.LblLoginLog.Size = New System.Drawing.Size(59, 25)
        Me.LblLoginLog.TabIndex = 1
        Me.LblLoginLog.Text = "User :"
        '
        'LblLoginPassword
        '
        Me.LblLoginPassword.AutoSize = True
        Me.LblLoginPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLoginPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoginPassword.Location = New System.Drawing.Point(74, 149)
        Me.LblLoginPassword.Name = "LblLoginPassword"
        Me.LblLoginPassword.Size = New System.Drawing.Size(100, 25)
        Me.LblLoginPassword.TabIndex = 2
        Me.LblLoginPassword.Text = "Password :"
        '
        'LblLoginStation
        '
        Me.LblLoginStation.AutoSize = True
        Me.LblLoginStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLoginStation.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoginStation.Location = New System.Drawing.Point(74, 200)
        Me.LblLoginStation.Name = "LblLoginStation"
        Me.LblLoginStation.Size = New System.Drawing.Size(79, 25)
        Me.LblLoginStation.TabIndex = 3
        Me.LblLoginStation.Text = "Station :"
        '
        'cboLogin
        '
        Me.cboLogin.DataSource = Me.UsersBindingSource
        Me.cboLogin.DisplayMember = "UserFirstName"
        Me.cboLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLogin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLogin.FormattingEnabled = True
        Me.cboLogin.Location = New System.Drawing.Point(178, 98)
        Me.cboLogin.Name = "cboLogin"
        Me.cboLogin.Size = New System.Drawing.Size(190, 28)
        Me.cboLogin.TabIndex = 4
        Me.cboLogin.ValueMember = "UserID"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AqualocDataSet
        '
        'AqualocDataSet
        '
        Me.AqualocDataSet.DataSetName = "AqualocDataSet"
        Me.AqualocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginPassword.Location = New System.Drawing.Point(176, 149)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtLoginPassword.Size = New System.Drawing.Size(190, 27)
        Me.txtLoginPassword.TabIndex = 5
        '
        'cboLoginStation
        '
        Me.cboLoginStation.DataSource = Me.StationsBindingSource
        Me.cboLoginStation.DisplayMember = "stationFunctions"
        Me.cboLoginStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoginStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLoginStation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoginStation.FormattingEnabled = True
        Me.cboLoginStation.Location = New System.Drawing.Point(176, 197)
        Me.cboLoginStation.Name = "cboLoginStation"
        Me.cboLoginStation.Size = New System.Drawing.Size(190, 28)
        Me.cboLoginStation.TabIndex = 6
        Me.cboLoginStation.ValueMember = "StationID"
        '
        'StationsBindingSource
        '
        Me.StationsBindingSource.DataMember = "Stations"
        Me.StationsBindingSource.DataSource = Me.AqualocDataSet
        '
        'cmbLoginCancel
        '
        Me.cmbLoginCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLoginCancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cmbLoginCancel.Location = New System.Drawing.Point(13, 293)
        Me.cmbLoginCancel.Name = "cmbLoginCancel"
        Me.cmbLoginCancel.Size = New System.Drawing.Size(441, 34)
        Me.cmbLoginCancel.TabIndex = 7
        Me.cmbLoginCancel.Text = "Exit"
        Me.cmbLoginCancel.UseVisualStyleBackColor = False
        '
        'cmbLoginOk
        '
        Me.cmbLoginOk.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbLoginOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLoginOk.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoginOk.Location = New System.Drawing.Point(13, 241)
        Me.cmbLoginOk.Name = "cmbLoginOk"
        Me.cmbLoginOk.Size = New System.Drawing.Size(441, 34)
        Me.cmbLoginOk.TabIndex = 8
        Me.cmbLoginOk.Text = "Login"
        Me.cmbLoginOk.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 372)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(463, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.meterQcPointTableAdapter = Nothing
        Me.TableAdapterManager.MetersTableAdapter = Nothing
        Me.TableAdapterManager.StationsTableAdapter = Me.StationsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'StationsTableAdapter
        '
        Me.StationsTableAdapter.ClearBeforeFill = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(467, 489)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbLoginOk)
        Me.Controls.Add(Me.cmbLoginCancel)
        Me.Controls.Add(Me.cboLoginStation)
        Me.Controls.Add(Me.txtLoginPassword)
        Me.Controls.Add(Me.cboLogin)
        Me.Controls.Add(Me.LblLoginStation)
        Me.Controls.Add(Me.LblLoginPassword)
        Me.Controls.Add(Me.LblLoginLog)
        Me.Controls.Add(Me.LblloginHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblloginHeading As Label
    Friend WithEvents LblLoginLog As Label
    Friend WithEvents LblLoginPassword As Label
    Friend WithEvents LblLoginStation As Label
    Friend WithEvents cboLogin As ComboBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents cboLoginStation As ComboBox
    Friend WithEvents cmbLoginCancel As Button
    Friend WithEvents cmbLoginOk As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents UsersTableAdapter As DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StationsTableAdapter As DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents StationsBindingSource As BindingSource
End Class
