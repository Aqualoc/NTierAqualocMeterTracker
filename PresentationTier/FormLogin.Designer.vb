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
        Me.cboUserName = New System.Windows.Forms.ComboBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cboStation = New System.Windows.Forms.ComboBox()
        Me.StationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsersTableAdapter = New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager()
        Me.StationsTableAdapter = New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter()
        Me.lblVersion = New System.Windows.Forms.Label()
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
        'cboUserName
        '
        Me.cboUserName.DataSource = Me.UsersBindingSource
        Me.cboUserName.DisplayMember = "UserFirstName"
        Me.cboUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUserName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserName.FormattingEnabled = True
        Me.cboUserName.Location = New System.Drawing.Point(178, 98)
        Me.cboUserName.Name = "cboUserName"
        Me.cboUserName.Size = New System.Drawing.Size(190, 28)
        Me.cboUserName.TabIndex = 4
        Me.cboUserName.ValueMember = "UserID"
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
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(176, 149)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(190, 27)
        Me.txtPassword.TabIndex = 5
        '
        'cboStation
        '
        Me.cboStation.DataSource = Me.StationsBindingSource
        Me.cboStation.DisplayMember = "stationFunctions"
        Me.cboStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Location = New System.Drawing.Point(176, 197)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(190, 28)
        Me.cboStation.TabIndex = 6
        Me.cboStation.ValueMember = "StationID"
        '
        'StationsBindingSource
        '
        Me.StationsBindingSource.DataMember = "Stations"
        Me.StationsBindingSource.DataSource = Me.AqualocDataSet
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnExit.Location = New System.Drawing.Point(13, 293)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(441, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(13, 241)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(441, 34)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
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
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(-2, 471)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(113, 13)
        Me.lblVersion.TabIndex = 12
        Me.lblVersion.Text = "Version: {0}.{1}.{2}.{3}"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(467, 489)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboStation)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.cboUserName)
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
    Friend WithEvents cboUserName As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cboStation As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents UsersTableAdapter As DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StationsTableAdapter As DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents StationsBindingSource As BindingSource
    Friend WithEvents lblVersion As Label
End Class
