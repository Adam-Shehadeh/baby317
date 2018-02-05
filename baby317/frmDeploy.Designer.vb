<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeploy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeploy))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnDisableStartup = New System.Windows.Forms.Button()
        Me.btnEnableStartup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Bahnschrift", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(595, 370)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 47)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(13, 13)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(699, 354)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisableStartup
        '
        Me.btnDisableStartup.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnDisableStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisableStartup.Font = New System.Drawing.Font("Bahnschrift", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisableStartup.Location = New System.Drawing.Point(194, 370)
        Me.btnDisableStartup.Name = "btnDisableStartup"
        Me.btnDisableStartup.Size = New System.Drawing.Size(176, 47)
        Me.btnDisableStartup.TabIndex = 2
        Me.btnDisableStartup.Text = "Disable Startup"
        Me.btnDisableStartup.UseVisualStyleBackColor = False
        '
        'btnEnableStartup
        '
        Me.btnEnableStartup.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnEnableStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnableStartup.Font = New System.Drawing.Font("Bahnschrift", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnableStartup.Location = New System.Drawing.Point(12, 370)
        Me.btnEnableStartup.Name = "btnEnableStartup"
        Me.btnEnableStartup.Size = New System.Drawing.Size(176, 47)
        Me.btnEnableStartup.TabIndex = 3
        Me.btnEnableStartup.Text = "Enable Startup"
        Me.btnEnableStartup.UseVisualStyleBackColor = False
        '
        'frmDeploy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(724, 429)
        Me.Controls.Add(Me.btnEnableStartup)
        Me.Controls.Add(Me.btnDisableStartup)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDeploy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baby v1.0.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnDisableStartup As Button
    Friend WithEvents btnEnableStartup As Button
End Class
