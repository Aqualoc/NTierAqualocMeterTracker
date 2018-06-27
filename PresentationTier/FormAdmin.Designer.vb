<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnCreateStation = New System.Windows.Forms.Button()
        Me.btnCreateStickers = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartQcPointBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.PartTableAdapter()
        Me.UsersTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter()
        Me.StationsTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter()
        Me.TableAdapterManager1 = New DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartQcPointBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateUser
        '
        Me.btnCreateUser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateUser.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.Location = New System.Drawing.Point(180, 108)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(113, 50)
        Me.btnCreateUser.TabIndex = 2
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = False
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(61, 255)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(113, 50)
        Me.btnDeleteUser.TabIndex = 4
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnCreateStation
        '
        Me.btnCreateStation.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCreateStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateStation.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateStation.Location = New System.Drawing.Point(61, 108)
        Me.btnCreateStation.Name = "btnCreateStation"
        Me.btnCreateStation.Size = New System.Drawing.Size(113, 50)
        Me.btnCreateStation.TabIndex = 1
        Me.btnCreateStation.Text = "Create Station"
        Me.btnCreateStation.UseVisualStyleBackColor = False
        '
        'btnCreateStickers
        '
        Me.btnCreateStickers.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCreateStickers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateStickers.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateStickers.Location = New System.Drawing.Point(299, 108)
        Me.btnCreateStickers.Name = "btnCreateStickers"
        Me.btnCreateStickers.Size = New System.Drawing.Size(113, 50)
        Me.btnCreateStickers.TabIndex = 3
        Me.btnCreateStickers.Text = "Create Stickers"
        Me.btnCreateStickers.UseVisualStyleBackColor = False
        '
        'ComboBox3
        '
        Me.ComboBox3.DisplayMember = "UserID"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(40, 215)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(189, 29)
        Me.ComboBox3.TabIndex = 11
        Me.ComboBox3.ValueMember = "UserID"
        '
        'ComboBox4
        '
        Me.ComboBox4.DisplayMember = "StationID"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(252, 215)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(195, 29)
        Me.ComboBox4.TabIndex = 12
        Me.ComboBox4.ValueMember = "StationID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Please click on the procedure you wish to perfrom."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Select an item to delete"
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(40, 331)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(184, 52)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(263, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 52)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AqualocDataSet
        '
        Me.AqualocDataSet.DataSetName = "AqualocDataSet"
        Me.AqualocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataMember = "Part"
        Me.PartBindingSource.DataSource = Me.AqualocDataSet
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AqualocDataSet
        '
        'PartQcPointBindingSource
        '
        Me.PartQcPointBindingSource.DataMember = "PartQcPoint"
        Me.PartQcPointBindingSource.DataSource = Me.AqualocDataSet
        '
        'PartTableAdapter1
        '
        Me.PartTableAdapter1.ClearBeforeFill = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'StationsTableAdapter1
        '
        Me.StationsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AssemblyTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PartAssemblyTableAdapter = Nothing
        Me.TableAdapterManager1.PartQcPointTableAdapter = Nothing
        Me.TableAdapterManager1.PartTableAdapter = Me.PartTableAdapter1
        Me.TableAdapterManager1.StationsTableAdapter = Me.StationsTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Me.UsersTableAdapter1
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(481, 419)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.btnCreateStickers)
        Me.Controls.Add(Me.btnCreateStation)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormAdmin"
        Me.Text = "Admin"
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartQcPointBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnCreateStation As Button
    Friend WithEvents btnCreateStickers As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonExit As Button
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents PartBindingSource As BindingSource
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents PartQcPointBindingSource As BindingSource
    Friend WithEvents PartTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.PartTableAdapter
    Friend WithEvents UsersTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents StationsTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
    Friend WithEvents TableAdapterManager1 As DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager
End Class
