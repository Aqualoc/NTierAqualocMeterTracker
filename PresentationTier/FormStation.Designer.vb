<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStation
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
        Me.ButtonScanFeedback = New System.Windows.Forms.Button()
        Me.TxtScanBox = New System.Windows.Forms.TextBox()
        Me.LblScanningOperator = New System.Windows.Forms.Label()
        Me.TextBoxCurrentOperator = New System.Windows.Forms.TextBox()
        Me.LabelFailCount = New System.Windows.Forms.Label()
        Me.LabelPassCount = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.TextBoxCurrentStation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.StationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartQcPointBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AqualocDataSet1 = New DataEntityTier.AqualocDataSet()
        Me.TableAdapterManager1 = New DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter()
        Me.StationsTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter()
        Me.PartTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.PartTableAdapter()
        Me.PartQcPointTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.PartQcPointTableAdapter()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartQcPointBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AqualocDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonScanFeedback
        '
        Me.ButtonScanFeedback.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonScanFeedback.Enabled = False
        Me.ButtonScanFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanFeedback.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanFeedback.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonScanFeedback.Location = New System.Drawing.Point(13, 207)
        Me.ButtonScanFeedback.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonScanFeedback.Name = "ButtonScanFeedback"
        Me.ButtonScanFeedback.Size = New System.Drawing.Size(383, 110)
        Me.ButtonScanFeedback.TabIndex = 4
        Me.ButtonScanFeedback.UseVisualStyleBackColor = False
        '
        'TxtScanBox
        '
        Me.TxtScanBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanBox.Location = New System.Drawing.Point(13, 164)
        Me.TxtScanBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtScanBox.Name = "TxtScanBox"
        Me.TxtScanBox.Size = New System.Drawing.Size(383, 33)
        Me.TxtScanBox.TabIndex = 6
        '
        'LblScanningOperator
        '
        Me.LblScanningOperator.AutoSize = True
        Me.LblScanningOperator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScanningOperator.Location = New System.Drawing.Point(71, 55)
        Me.LblScanningOperator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblScanningOperator.Name = "LblScanningOperator"
        Me.LblScanningOperator.Size = New System.Drawing.Size(72, 20)
        Me.LblScanningOperator.TabIndex = 7
        Me.LblScanningOperator.Text = "Operator:"
        '
        'TextBoxCurrentOperator
        '
        Me.TextBoxCurrentOperator.Enabled = False
        Me.TextBoxCurrentOperator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCurrentOperator.Location = New System.Drawing.Point(206, 55)
        Me.TextBoxCurrentOperator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxCurrentOperator.Name = "TextBoxCurrentOperator"
        Me.TextBoxCurrentOperator.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxCurrentOperator.TabIndex = 8
        '
        'LabelFailCount
        '
        Me.LabelFailCount.AutoSize = True
        Me.LabelFailCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFailCount.Location = New System.Drawing.Point(233, 360)
        Me.LabelFailCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFailCount.Name = "LabelFailCount"
        Me.LabelFailCount.Size = New System.Drawing.Size(0, 20)
        Me.LabelFailCount.TabIndex = 14
        '
        'LabelPassCount
        '
        Me.LabelPassCount.AutoSize = True
        Me.LabelPassCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassCount.Location = New System.Drawing.Point(40, 360)
        Me.LabelPassCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassCount.Name = "LabelPassCount"
        Me.LabelPassCount.Size = New System.Drawing.Size(0, 20)
        Me.LabelPassCount.TabIndex = 15
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.Location = New System.Drawing.Point(47, 345)
        Me.LblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(0, 20)
        Me.LblPass.TabIndex = 13
        '
        'TextBoxCurrentStation
        '
        Me.TextBoxCurrentStation.Enabled = False
        Me.TextBoxCurrentStation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCurrentStation.Location = New System.Drawing.Point(206, 101)
        Me.TextBoxCurrentStation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxCurrentStation.Name = "TextBoxCurrentStation"
        Me.TextBoxCurrentStation.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxCurrentStation.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Station"
        '
        'AqualocDataSet
        '
        Me.AqualocDataSet.DataSetName = "AqualocDataSet"
        Me.AqualocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StationsBindingSource
        '
        Me.StationsBindingSource.DataMember = "Stations"
        Me.StationsBindingSource.DataSource = Me.AqualocDataSet
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
        'PartBindingSource
        '
        Me.PartBindingSource.DataMember = "Part"
        Me.PartBindingSource.DataSource = Me.AqualocDataSet
        '
        'AqualocDataSet1
        '
        Me.AqualocDataSet1.DataSetName = "AqualocDataSet"
        Me.AqualocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AssemblyTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PartAssemblyTableAdapter = Nothing
        Me.TableAdapterManager1.PartQcPointTableAdapter = Me.PartQcPointTableAdapter1
        Me.TableAdapterManager1.PartTableAdapter = Me.PartTableAdapter1
        Me.TableAdapterManager1.StationsTableAdapter = Me.StationsTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Me.UsersTableAdapter1
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'StationsTableAdapter1
        '
        Me.StationsTableAdapter1.ClearBeforeFill = True
        '
        'PartTableAdapter1
        '
        Me.PartTableAdapter1.ClearBeforeFill = True
        '
        'PartQcPointTableAdapter1
        '
        Me.PartQcPointTableAdapter1.ClearBeforeFill = True
        '
        'FormStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(548, 605)
        Me.Controls.Add(Me.TextBoxCurrentStation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPassCount)
        Me.Controls.Add(Me.LabelFailCount)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.TextBoxCurrentOperator)
        Me.Controls.Add(Me.LblScanningOperator)
        Me.Controls.Add(Me.TxtScanBox)
        Me.Controls.Add(Me.ButtonScanFeedback)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStation"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station"
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartQcPointBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AqualocDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonScanFeedback As Button
    Friend WithEvents TxtScanBox As TextBox
    Friend WithEvents LblScanningOperator As Label
    Friend WithEvents TextBoxCurrentOperator As TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents LabelFailCount As Label
    Friend WithEvents LabelPassCount As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents TextBoxCurrentStation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents StationsBindingSource As BindingSource
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents PartQcPointBindingSource As BindingSource
    Friend WithEvents PartBindingSource As BindingSource
    Friend WithEvents AqualocDataSet1 As DataEntityTier.AqualocDataSet
    Friend WithEvents TableAdapterManager1 As DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PartQcPointTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.PartQcPointTableAdapter
    Friend WithEvents PartTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.PartTableAdapter
    Friend WithEvents StationsTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
    Friend WithEvents UsersTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
End Class
