<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Concatenate
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Concatenate))
        Me.LST_CONCAT_FILE = New System.Windows.Forms.ListBox()
        Me.BTN_CONCAT_IMPORT_FILES = New System.Windows.Forms.Button()
        Me.BTN_CONCAT_REMOVE_FILE = New System.Windows.Forms.Button()
        Me.BTN_CONCAT_MOVE_UP = New System.Windows.Forms.Button()
        Me.BTN_CONCAT_MOVE_DOWN = New System.Windows.Forms.Button()
        Me.BTN_CONCAT_START_COPY = New System.Windows.Forms.Button()
        Me.BTN_CONCAT_OK = New System.Windows.Forms.Button()
        Me.BTN_CONCAT_MOVE_TOP = New System.Windows.Forms.Button()
        Me.BTN_CONCAT_MOVE_BOTTOM = New System.Windows.Forms.Button()
        Me.OFD_CONCAT_IMPORT = New System.Windows.Forms.OpenFileDialog()
        Me.BTN_CONCAT_REMOVE_ALL = New System.Windows.Forms.Button()
        Me.SFD_CONCAT_COPY = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'LST_CONCAT_FILE
        '
        Me.LST_CONCAT_FILE.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LST_CONCAT_FILE.FormattingEnabled = True
        Me.LST_CONCAT_FILE.HorizontalScrollbar = True
        Me.LST_CONCAT_FILE.ItemHeight = 20
        Me.LST_CONCAT_FILE.Location = New System.Drawing.Point(9, 8)
        Me.LST_CONCAT_FILE.Name = "LST_CONCAT_FILE"
        Me.LST_CONCAT_FILE.Size = New System.Drawing.Size(615, 424)
        Me.LST_CONCAT_FILE.TabIndex = 1001
        '
        'BTN_CONCAT_IMPORT_FILES
        '
        Me.BTN_CONCAT_IMPORT_FILES.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_IMPORT_FILES.Location = New System.Drawing.Point(630, 24)
        Me.BTN_CONCAT_IMPORT_FILES.Name = "BTN_CONCAT_IMPORT_FILES"
        Me.BTN_CONCAT_IMPORT_FILES.Size = New System.Drawing.Size(144, 34)
        Me.BTN_CONCAT_IMPORT_FILES.TabIndex = 1101
        Me.BTN_CONCAT_IMPORT_FILES.Text = "&Import Files"
        Me.BTN_CONCAT_IMPORT_FILES.UseVisualStyleBackColor = True
        '
        'BTN_CONCAT_REMOVE_FILE
        '
        Me.BTN_CONCAT_REMOVE_FILE.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_REMOVE_FILE.Location = New System.Drawing.Point(630, 64)
        Me.BTN_CONCAT_REMOVE_FILE.Name = "BTN_CONCAT_REMOVE_FILE"
        Me.BTN_CONCAT_REMOVE_FILE.Size = New System.Drawing.Size(144, 34)
        Me.BTN_CONCAT_REMOVE_FILE.TabIndex = 1105
        Me.BTN_CONCAT_REMOVE_FILE.Text = "&Remove File"
        Me.BTN_CONCAT_REMOVE_FILE.UseVisualStyleBackColor = True
        '
        'BTN_CONCAT_MOVE_UP
        '
        Me.BTN_CONCAT_MOVE_UP.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_MOVE_UP.Location = New System.Drawing.Point(630, 144)
        Me.BTN_CONCAT_MOVE_UP.Name = "BTN_CONCAT_MOVE_UP"
        Me.BTN_CONCAT_MOVE_UP.Size = New System.Drawing.Size(144, 34)
        Me.BTN_CONCAT_MOVE_UP.TabIndex = 1109
        Me.BTN_CONCAT_MOVE_UP.Text = "Move &Up"
        Me.BTN_CONCAT_MOVE_UP.UseVisualStyleBackColor = True
        '
        'BTN_CONCAT_MOVE_DOWN
        '
        Me.BTN_CONCAT_MOVE_DOWN.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_MOVE_DOWN.Location = New System.Drawing.Point(630, 184)
        Me.BTN_CONCAT_MOVE_DOWN.Name = "BTN_CONCAT_MOVE_DOWN"
        Me.BTN_CONCAT_MOVE_DOWN.Size = New System.Drawing.Size(144, 34)
        Me.BTN_CONCAT_MOVE_DOWN.TabIndex = 1113
        Me.BTN_CONCAT_MOVE_DOWN.Text = "Move &Down"
        Me.BTN_CONCAT_MOVE_DOWN.UseVisualStyleBackColor = True
        '
        'BTN_CONCAT_START_COPY
        '
        Me.BTN_CONCAT_START_COPY.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_START_COPY.Location = New System.Drawing.Point(630, 313)
        Me.BTN_CONCAT_START_COPY.Name = "BTN_CONCAT_START_COPY"
        Me.BTN_CONCAT_START_COPY.Size = New System.Drawing.Size(144, 57)
        Me.BTN_CONCAT_START_COPY.TabIndex = 2001
        Me.BTN_CONCAT_START_COPY.Text = "START &COPY"
        Me.BTN_CONCAT_START_COPY.UseVisualStyleBackColor = True
        '
        'BTN_CONCAT_OK
        '
        Me.BTN_CONCAT_OK.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_OK.Location = New System.Drawing.Point(630, 376)
        Me.BTN_CONCAT_OK.Name = "BTN_CONCAT_OK"
        Me.BTN_CONCAT_OK.Size = New System.Drawing.Size(144, 57)
        Me.BTN_CONCAT_OK.TabIndex = 2003
        Me.BTN_CONCAT_OK.Text = "&OK"
        Me.BTN_CONCAT_OK.UseVisualStyleBackColor = True
        '
        'BTN_CONCAT_MOVE_TOP
        '
        Me.BTN_CONCAT_MOVE_TOP.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_MOVE_TOP.Location = New System.Drawing.Point(630, 224)
        Me.BTN_CONCAT_MOVE_TOP.Name = "BTN_CONCAT_MOVE_TOP"
        Me.BTN_CONCAT_MOVE_TOP.Size = New System.Drawing.Size(144, 34)
        Me.BTN_CONCAT_MOVE_TOP.TabIndex = 1117
        Me.BTN_CONCAT_MOVE_TOP.Text = "Move &Top"
        Me.BTN_CONCAT_MOVE_TOP.UseVisualStyleBackColor = True
        '
        'BTN_CONCAT_MOVE_BOTTOM
        '
        Me.BTN_CONCAT_MOVE_BOTTOM.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_MOVE_BOTTOM.Location = New System.Drawing.Point(630, 264)
        Me.BTN_CONCAT_MOVE_BOTTOM.Name = "BTN_CONCAT_MOVE_BOTTOM"
        Me.BTN_CONCAT_MOVE_BOTTOM.Size = New System.Drawing.Size(144, 34)
        Me.BTN_CONCAT_MOVE_BOTTOM.TabIndex = 1121
        Me.BTN_CONCAT_MOVE_BOTTOM.Text = "Move &Bottom"
        Me.BTN_CONCAT_MOVE_BOTTOM.UseVisualStyleBackColor = True
        '
        'OFD_CONCAT_IMPORT
        '
        Me.OFD_CONCAT_IMPORT.Filter = "Transport Stream|*.ts;*.m2ts|All Files|*.*"
        Me.OFD_CONCAT_IMPORT.Multiselect = True
        '
        'BTN_CONCAT_REMOVE_ALL
        '
        Me.BTN_CONCAT_REMOVE_ALL.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CONCAT_REMOVE_ALL.Location = New System.Drawing.Point(630, 104)
        Me.BTN_CONCAT_REMOVE_ALL.Name = "BTN_CONCAT_REMOVE_ALL"
        Me.BTN_CONCAT_REMOVE_ALL.Size = New System.Drawing.Size(144, 34)
        Me.BTN_CONCAT_REMOVE_ALL.TabIndex = 1107
        Me.BTN_CONCAT_REMOVE_ALL.Text = "Remove &All"
        Me.BTN_CONCAT_REMOVE_ALL.UseVisualStyleBackColor = True
        '
        'SFD_CONCAT_COPY
        '
        Me.SFD_CONCAT_COPY.Filter = "Transport Stream|*.ts|All Files|*.*"
        '
        'Concatenate
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.BTN_CONCAT_REMOVE_ALL)
        Me.Controls.Add(Me.BTN_CONCAT_MOVE_BOTTOM)
        Me.Controls.Add(Me.BTN_CONCAT_MOVE_TOP)
        Me.Controls.Add(Me.BTN_CONCAT_OK)
        Me.Controls.Add(Me.BTN_CONCAT_START_COPY)
        Me.Controls.Add(Me.BTN_CONCAT_MOVE_DOWN)
        Me.Controls.Add(Me.BTN_CONCAT_MOVE_UP)
        Me.Controls.Add(Me.BTN_CONCAT_REMOVE_FILE)
        Me.Controls.Add(Me.BTN_CONCAT_IMPORT_FILES)
        Me.Controls.Add(Me.LST_CONCAT_FILE)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Concatenate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concatenate"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LST_CONCAT_FILE As ListBox
    Friend WithEvents BTN_CONCAT_IMPORT_FILES As Button
    Friend WithEvents BTN_CONCAT_REMOVE_FILE As Button
    Friend WithEvents BTN_CONCAT_MOVE_UP As Button
    Friend WithEvents BTN_CONCAT_MOVE_DOWN As Button
    Friend WithEvents BTN_CONCAT_START_COPY As Button
    Friend WithEvents BTN_CONCAT_OK As Button
    Friend WithEvents BTN_CONCAT_MOVE_TOP As Button
    Friend WithEvents BTN_CONCAT_MOVE_BOTTOM As Button
    Friend WithEvents OFD_CONCAT_IMPORT As OpenFileDialog
    Friend WithEvents BTN_CONCAT_REMOVE_ALL As Button
    Friend WithEvents SFD_CONCAT_COPY As SaveFileDialog
End Class
