<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaint
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaint))
        Me.TblMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdMain = New System.Windows.Forms.DataGridView()
        Me.DbroyannDataSet = New baby317_maint.dbroyannDataSet()
        Me.TblMAINBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MAINTableAdapter = New baby317_maint.dbroyannDataSetTableAdapters.tbl_MAINTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtMSG_Create = New System.Windows.Forms.TextBox()
        Me.txtMSG_Update = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtID_Update = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID_Delete = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.TblMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbroyannDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMAINBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdMain
        '
        Me.grdMain.AllowUserToAddRows = False
        Me.grdMain.AllowUserToDeleteRows = False
        Me.grdMain.AllowUserToOrderColumns = True
        Me.grdMain.AutoGenerateColumns = False
        Me.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MSGDataGridViewTextBoxColumn})
        Me.grdMain.DataSource = Me.TblMAINBindingSource1
        Me.grdMain.Location = New System.Drawing.Point(12, 312)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.ReadOnly = True
        Me.grdMain.RowTemplate.Height = 33
        Me.grdMain.Size = New System.Drawing.Size(1065, 363)
        Me.grdMain.TabIndex = 0
        '
        'DbroyannDataSet
        '
        Me.DbroyannDataSet.DataSetName = "dbroyannDataSet"
        Me.DbroyannDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMAINBindingSource1
        '
        Me.TblMAINBindingSource1.DataMember = "tbl_MAIN"
        Me.TblMAINBindingSource1.DataSource = Me.DbroyannDataSet
        '
        'Tbl_MAINTableAdapter
        '
        Me.Tbl_MAINTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'MSGDataGridViewTextBoxColumn
        '
        Me.MSGDataGridViewTextBoxColumn.DataPropertyName = "MSG"
        Me.MSGDataGridViewTextBoxColumn.HeaderText = "MSG"
        Me.MSGDataGridViewTextBoxColumn.Name = "MSGDataGridViewTextBoxColumn"
        Me.MSGDataGridViewTextBoxColumn.ReadOnly = True
        Me.MSGDataGridViewTextBoxColumn.Width = 400
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(939, 123)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(138, 40)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtMSG_Create
        '
        Me.txtMSG_Create.Location = New System.Drawing.Point(198, 123)
        Me.txtMSG_Create.Multiline = True
        Me.txtMSG_Create.Name = "txtMSG_Create"
        Me.txtMSG_Create.Size = New System.Drawing.Size(735, 40)
        Me.txtMSG_Create.TabIndex = 2
        '
        'txtMSG_Update
        '
        Me.txtMSG_Update.Location = New System.Drawing.Point(198, 169)
        Me.txtMSG_Update.Multiline = True
        Me.txtMSG_Update.Name = "txtMSG_Update"
        Me.txtMSG_Update.Size = New System.Drawing.Size(605, 40)
        Me.txtMSG_Update.TabIndex = 4
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(939, 169)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 40)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtID_Update
        '
        Me.txtID_Update.Location = New System.Drawing.Point(853, 169)
        Me.txtID_Update.Multiline = True
        Me.txtID_Update.Name = "txtID_Update"
        Me.txtID_Update.Size = New System.Drawing.Size(80, 40)
        Me.txtID_Update.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(809, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(809, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ID:"
        '
        'txtID_Delete
        '
        Me.txtID_Delete.Location = New System.Drawing.Point(853, 215)
        Me.txtID_Delete.Multiline = True
        Me.txtID_Delete.Name = "txtID_Delete"
        Me.txtID_Delete.Size = New System.Drawing.Size(80, 40)
        Me.txtID_Delete.TabIndex = 8
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(939, 215)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(138, 40)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "MSG:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "MSG:"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(939, 261)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(138, 40)
        Me.btnRead.TabIndex = 12
        Me.btnRead.Text = "REFRESH"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(698, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(379, 75)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Baby317 Maintenance Program v1.0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Server: den1.mssql3.gear.host" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database: dbro" &
    "yann"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 687)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID_Delete)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID_Update)
        Me.Controls.Add(Me.txtMSG_Update)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtMSG_Create)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.grdMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaint"
        Me.Text = "Baby v1.0.0"
        CType(Me.TblMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbroyannDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMAINBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblMAINBindingSource As BindingSource
    Friend WithEvents grdMain As DataGridView
    Friend WithEvents DbroyannDataSet As dbroyannDataSet
    Friend WithEvents TblMAINBindingSource1 As BindingSource
    Friend WithEvents Tbl_MAINTableAdapter As dbroyannDataSetTableAdapters.tbl_MAINTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MSGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtMSG_Create As TextBox
    Friend WithEvents txtMSG_Update As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtID_Update As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID_Delete As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRead As Button
    Friend WithEvents lblTitle As Label
End Class
