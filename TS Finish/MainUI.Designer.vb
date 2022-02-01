<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.LBL_HEADING_INPUT = New System.Windows.Forms.Label()
        Me.LBL_INPUT_SOURCE_FILE = New System.Windows.Forms.Label()
        Me.LBL_HEADING_PROCESS = New System.Windows.Forms.Label()
        Me.LBL_HEADING_OUTPUT = New System.Windows.Forms.Label()
        Me.TAC_PROCESS = New System.Windows.Forms.TabControl()
        Me.TAP_GENERAL = New System.Windows.Forms.TabPage()
        Me.CBO_REMARK_SCRABMBL_TAG = New System.Windows.Forms.ComboBox()
        Me.CHK_SCRAMBL_SEGMENT = New System.Windows.Forms.CheckBox()
        Me.CHK_SELECT_ALL_PID = New System.Windows.Forms.CheckBox()
        Me.CHK_EXTRACT_PAYLOAD = New System.Windows.Forms.CheckBox()
        Me.LBL_SUBH_PACKET_HEADER = New System.Windows.Forms.Label()
        Me.TXT_ADD_PID = New System.Windows.Forms.TextBox()
        Me.BTN_ADD_PID = New System.Windows.Forms.Button()
        Me.LBL_SUBH_PID_LIST = New System.Windows.Forms.Label()
        Me.BTN_PID_MOVE_DOWN = New System.Windows.Forms.Button()
        Me.BTN_PID_MOVE_UP = New System.Windows.Forms.Button()
        Me.BTN_REMOVE_PID = New System.Windows.Forms.Button()
        Me.CHK_OVERWRI_PACKET_COUNTER = New System.Windows.Forms.CheckBox()
        Me.CHK_REMARK_SCRAMBL_TAG = New System.Windows.Forms.CheckBox()
        Me.CHK_ENBL_PID_FILTER = New System.Windows.Forms.CheckBox()
        Me.TAP_PID = New System.Windows.Forms.TabPage()
        Me.TXT_PID_OVERWRITE = New System.Windows.Forms.TextBox()
        Me.BTN_PID_REWRITE_REMOVE = New System.Windows.Forms.Button()
        Me.BTN_PID_REWRITE_ADD = New System.Windows.Forms.Button()
        Me.TXT_PID_ORIGINAL = New System.Windows.Forms.TextBox()
        Me.LSV_PID_REWRITE = New System.Windows.Forms.ListView()
        Me.CLH_PID_ORIGINAL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLH_PID_OVERWRITE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TAP_PAT_PMT = New System.Windows.Forms.TabPage()
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT = New System.Windows.Forms.ComboBox()
        Me.LBL_PAT_PMT_PERIOD_2 = New System.Windows.Forms.Label()
        Me.LBL_PAT_PMT_PERIOD_1 = New System.Windows.Forms.Label()
        Me.NUM_PAT_PMT_PERIOD = New System.Windows.Forms.NumericUpDown()
        Me.LBL_PAT_PMT_SELECT_PID_PID = New System.Windows.Forms.Label()
        Me.LBL_PAT_PMT_SELECT_PID = New System.Windows.Forms.Label()
        Me.CBO_PAT_PMT_STREAM_TYPE = New System.Windows.Forms.ComboBox()
        Me.LBL_PAT_PMT_STREAM_TYPE = New System.Windows.Forms.Label()
        Me.TXT_PAT_PMT_STREAM_TYPE = New System.Windows.Forms.TextBox()
        Me.LBL_SUBH_PMT = New System.Windows.Forms.Label()
        Me.LBL_PAT_PMT_PID = New System.Windows.Forms.Label()
        Me.TXT_PAT_PMT_PID = New System.Windows.Forms.TextBox()
        Me.LBL_PAT_PMT_PROGRAM_NUMBER = New System.Windows.Forms.Label()
        Me.LBL_PAT_PMT_TRANSPO_STREAM_ID = New System.Windows.Forms.Label()
        Me.TXT_PAT_PMT_PROGRAM_NUMBER = New System.Windows.Forms.TextBox()
        Me.TXT_PAT_PMT_TRANSPO_STREAM_ID = New System.Windows.Forms.TextBox()
        Me.CHK_ENBL_PAT_PMT = New System.Windows.Forms.CheckBox()
        Me.LBL_SUBH_PAT = New System.Windows.Forms.Label()
        Me.TAP_SDT = New System.Windows.Forms.TabPage()
        Me.LBL_SDT_PERIOD_2 = New System.Windows.Forms.Label()
        Me.LBL_SDT_PERIOD_1 = New System.Windows.Forms.Label()
        Me.NUM_SDT_PERIOD = New System.Windows.Forms.NumericUpDown()
        Me.CBO_SDT_SERVICE_TYPE = New System.Windows.Forms.ComboBox()
        Me.LBL_SDT_SERVICE_TYPE = New System.Windows.Forms.Label()
        Me.TXT_SDT_SERVICE_TYPE = New System.Windows.Forms.TextBox()
        Me.LBL_SDT_SERVICE_PROVIDER = New System.Windows.Forms.Label()
        Me.TXT_SDT_SERVICE_PROVIDER = New System.Windows.Forms.TextBox()
        Me.LBL_SDT_SERVICE_NAME = New System.Windows.Forms.Label()
        Me.TXT_SDT_SERVICE_NAME = New System.Windows.Forms.TextBox()
        Me.LBL_SDT_SERVICE_ID = New System.Windows.Forms.Label()
        Me.TXT_SDT_SERVICE_ID = New System.Windows.Forms.TextBox()
        Me.LBL_SDT_NETWORK_ID = New System.Windows.Forms.Label()
        Me.LBL_SDT_TRANSPO_STREAM_ID = New System.Windows.Forms.Label()
        Me.TXT_SDT_NETWORK_ID = New System.Windows.Forms.TextBox()
        Me.TXT_SDT_TRANSPO_STREAM_ID = New System.Windows.Forms.TextBox()
        Me.CHK_ENBL_SDT = New System.Windows.Forms.CheckBox()
        Me.TAP_CUTTER = New System.Windows.Forms.TabPage()
        Me.TXT_CUTTER_TOTAL_DURATION = New System.Windows.Forms.TextBox()
        Me.LBL_CUTTER_TOTAL_DURATION = New System.Windows.Forms.Label()
        Me.LBL_CUTTER_TOTAL_PACKETS_COUNT = New System.Windows.Forms.Label()
        Me.LBL_CUTTER_TOTAL_PACKETS = New System.Windows.Forms.Label()
        Me.BTN_CUTTER_REMOVE = New System.Windows.Forms.Button()
        Me.BTN_CUTTER_ADD = New System.Windows.Forms.Button()
        Me.TXT_CUTTER_END = New System.Windows.Forms.TextBox()
        Me.TXT_CUTTER_START = New System.Windows.Forms.TextBox()
        Me.TXT_CUTTER_TASK_NAME = New System.Windows.Forms.TextBox()
        Me.LSV_CUTTER = New System.Windows.Forms.ListView()
        Me.CLH_CUTTER_TASK_NAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLH_CUTTER_START = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLH_CUTTER_END = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TAP_INSERT = New System.Windows.Forms.TabPage()
        Me.LBL_INSERT_PERIOD_2 = New System.Windows.Forms.Label()
        Me.LBL_INSERT_PERIOD_1 = New System.Windows.Forms.Label()
        Me.NUM_INSERT_PERIOD = New System.Windows.Forms.NumericUpDown()
        Me.BTN_INSERT_TS_FILE = New System.Windows.Forms.Button()
        Me.LBL_INSERT_TS_FILE = New System.Windows.Forms.Label()
        Me.TXT_INSERT_TS_FILE = New System.Windows.Forms.TextBox()
        Me.CHK_ENBL_INSERT = New System.Windows.Forms.CheckBox()
        Me.TAP_DISCARDER = New System.Windows.Forms.TabPage()
        Me.NUM_DISCARDER_RANGE_2 = New System.Windows.Forms.NumericUpDown()
        Me.LBL_DISCARDER_PERIOD_TO = New System.Windows.Forms.Label()
        Me.LBL_DISCARDER_PERIOD_PACKETS = New System.Windows.Forms.Label()
        Me.LBL_DISCARDER_PERIOD = New System.Windows.Forms.Label()
        Me.NUM_DISCARDER_RANGE_1 = New System.Windows.Forms.NumericUpDown()
        Me.CHK_ENBL_DISCARDER = New System.Windows.Forms.CheckBox()
        Me.TAP_DDB = New System.Windows.Forms.TabPage()
        Me.CHK_DDB_SPLIT = New System.Windows.Forms.CheckBox()
        Me.LBL_DDB_MODULE_ID = New System.Windows.Forms.Label()
        Me.TXT_DDB_MODULE_ID = New System.Windows.Forms.TextBox()
        Me.LBL_DDB_DOWNLOAD_ID = New System.Windows.Forms.Label()
        Me.TXT_DDB_DOWNLOAD_ID = New System.Windows.Forms.TextBox()
        Me.CHK_ENBL_DDB = New System.Windows.Forms.CheckBox()
        Me.TAP_ANALYZE = New System.Windows.Forms.TabPage()
        Me.TXT_ANALYZE_RESULT = New System.Windows.Forms.TextBox()
        Me.TXT_ANALYZE_PACKET_HEADER = New System.Windows.Forms.TextBox()
        Me.LBL_ANALYZE_PACKET_HEADER = New System.Windows.Forms.Label()
        Me.TAP_ABOUT = New System.Windows.Forms.TabPage()
        Me.LBL_ABOUT_SUMMARY = New System.Windows.Forms.Label()
        Me.LBL_ABOUT_VERSION = New System.Windows.Forms.Label()
        Me.LBL_ABOUT_TITLE = New System.Windows.Forms.Label()
        Me.PIC_ABOUT_BADGE = New System.Windows.Forms.PictureBox()
        Me.TXT_INPUT_SOURCE_FILE = New System.Windows.Forms.TextBox()
        Me.BTN_INPUT_BROWSE = New System.Windows.Forms.Button()
        Me.CHK_INPUT_AUTO_SCAN = New System.Windows.Forms.CheckBox()
        Me.BTN_INPUT_SCAN = New System.Windows.Forms.Button()
        Me.LBL_INPUT_READ_SIZE_1 = New System.Windows.Forms.Label()
        Me.NUM_INPUT_READ_SIZE = New System.Windows.Forms.NumericUpDown()
        Me.LBL_INPUT_READ_SIZE_2 = New System.Windows.Forms.Label()
        Me.LSV_PID = New System.Windows.Forms.ListView()
        Me.CLH_PID_ENBL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLH_PID_DEC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLH_PID_HEX = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLH_PID_PMT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PGB_OUTPUT_PROGRESS = New System.Windows.Forms.ProgressBar()
        Me.LBL_OUTPUT_PROGRESS = New System.Windows.Forms.Label()
        Me.BTN_OUTPUT_START = New System.Windows.Forms.Button()
        Me.TXT_OUTPUT_DEST_FILE = New System.Windows.Forms.TextBox()
        Me.LBL_OUTPUT_DEST_FILE = New System.Windows.Forms.Label()
        Me.BTN_OUTPUT_BROWSE = New System.Windows.Forms.Button()
        Me.BTN_INPUT_CONCAT = New System.Windows.Forms.Button()
        Me.OFD_INPUT_SOURCE_FILE = New System.Windows.Forms.OpenFileDialog()
        Me.SFD_OUTPUT_DEST_FILE = New System.Windows.Forms.SaveFileDialog()
        Me.OFD_INSERT_TS_FILE = New System.Windows.Forms.OpenFileDialog()
        Me.BGW_PROCESS = New System.ComponentModel.BackgroundWorker()
        Me.LBL_STATUS_STANDBY = New System.Windows.Forms.Label()
        Me.CHK_INPUT_RTP = New System.Windows.Forms.CheckBox()
        Me.TAC_PROCESS.SuspendLayout()
        Me.TAP_GENERAL.SuspendLayout()
        Me.TAP_PID.SuspendLayout()
        Me.TAP_PAT_PMT.SuspendLayout()
        CType(Me.NUM_PAT_PMT_PERIOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAP_SDT.SuspendLayout()
        CType(Me.NUM_SDT_PERIOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAP_CUTTER.SuspendLayout()
        Me.TAP_INSERT.SuspendLayout()
        CType(Me.NUM_INSERT_PERIOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAP_DISCARDER.SuspendLayout()
        CType(Me.NUM_DISCARDER_RANGE_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_DISCARDER_RANGE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAP_DDB.SuspendLayout()
        Me.TAP_ANALYZE.SuspendLayout()
        Me.TAP_ABOUT.SuspendLayout()
        CType(Me.PIC_ABOUT_BADGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_INPUT_READ_SIZE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_HEADING_INPUT
        '
        Me.LBL_HEADING_INPUT.BackColor = System.Drawing.Color.Blue
        Me.LBL_HEADING_INPUT.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_HEADING_INPUT.ForeColor = System.Drawing.Color.White
        Me.LBL_HEADING_INPUT.Location = New System.Drawing.Point(12, 7)
        Me.LBL_HEADING_INPUT.Name = "LBL_HEADING_INPUT"
        Me.LBL_HEADING_INPUT.Size = New System.Drawing.Size(984, 25)
        Me.LBL_HEADING_INPUT.TabIndex = 1001
        Me.LBL_HEADING_INPUT.Text = "INPUT"
        Me.LBL_HEADING_INPUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_INPUT_SOURCE_FILE
        '
        Me.LBL_INPUT_SOURCE_FILE.AutoSize = True
        Me.LBL_INPUT_SOURCE_FILE.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_INPUT_SOURCE_FILE.Location = New System.Drawing.Point(12, 41)
        Me.LBL_INPUT_SOURCE_FILE.Name = "LBL_INPUT_SOURCE_FILE"
        Me.LBL_INPUT_SOURCE_FILE.Size = New System.Drawing.Size(97, 21)
        Me.LBL_INPUT_SOURCE_FILE.TabIndex = 1101
        Me.LBL_INPUT_SOURCE_FILE.Text = "Source File:"
        '
        'LBL_HEADING_PROCESS
        '
        Me.LBL_HEADING_PROCESS.BackColor = System.Drawing.Color.Yellow
        Me.LBL_HEADING_PROCESS.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_HEADING_PROCESS.ForeColor = System.Drawing.Color.Purple
        Me.LBL_HEADING_PROCESS.Location = New System.Drawing.Point(12, 112)
        Me.LBL_HEADING_PROCESS.Name = "LBL_HEADING_PROCESS"
        Me.LBL_HEADING_PROCESS.Size = New System.Drawing.Size(984, 25)
        Me.LBL_HEADING_PROCESS.TabIndex = 2001
        Me.LBL_HEADING_PROCESS.Text = "PROCESS"
        Me.LBL_HEADING_PROCESS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_HEADING_OUTPUT
        '
        Me.LBL_HEADING_OUTPUT.BackColor = System.Drawing.Color.Brown
        Me.LBL_HEADING_OUTPUT.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_HEADING_OUTPUT.ForeColor = System.Drawing.Color.White
        Me.LBL_HEADING_OUTPUT.Location = New System.Drawing.Point(12, 432)
        Me.LBL_HEADING_OUTPUT.Name = "LBL_HEADING_OUTPUT"
        Me.LBL_HEADING_OUTPUT.Size = New System.Drawing.Size(984, 25)
        Me.LBL_HEADING_OUTPUT.TabIndex = 3
        Me.LBL_HEADING_OUTPUT.Text = "OUTPUT"
        Me.LBL_HEADING_OUTPUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TAC_PROCESS
        '
        Me.TAC_PROCESS.Controls.Add(Me.TAP_GENERAL)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_PID)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_PAT_PMT)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_SDT)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_CUTTER)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_INSERT)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_DISCARDER)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_DDB)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_ANALYZE)
        Me.TAC_PROCESS.Controls.Add(Me.TAP_ABOUT)
        Me.TAC_PROCESS.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TAC_PROCESS.Location = New System.Drawing.Point(357, 142)
        Me.TAC_PROCESS.Name = "TAC_PROCESS"
        Me.TAC_PROCESS.SelectedIndex = 0
        Me.TAC_PROCESS.Size = New System.Drawing.Size(638, 280)
        Me.TAC_PROCESS.TabIndex = 2201
        '
        'TAP_GENERAL
        '
        Me.TAP_GENERAL.Controls.Add(Me.CBO_REMARK_SCRABMBL_TAG)
        Me.TAP_GENERAL.Controls.Add(Me.CHK_SCRAMBL_SEGMENT)
        Me.TAP_GENERAL.Controls.Add(Me.CHK_SELECT_ALL_PID)
        Me.TAP_GENERAL.Controls.Add(Me.CHK_EXTRACT_PAYLOAD)
        Me.TAP_GENERAL.Controls.Add(Me.LBL_SUBH_PACKET_HEADER)
        Me.TAP_GENERAL.Controls.Add(Me.TXT_ADD_PID)
        Me.TAP_GENERAL.Controls.Add(Me.BTN_ADD_PID)
        Me.TAP_GENERAL.Controls.Add(Me.LBL_SUBH_PID_LIST)
        Me.TAP_GENERAL.Controls.Add(Me.BTN_PID_MOVE_DOWN)
        Me.TAP_GENERAL.Controls.Add(Me.BTN_PID_MOVE_UP)
        Me.TAP_GENERAL.Controls.Add(Me.BTN_REMOVE_PID)
        Me.TAP_GENERAL.Controls.Add(Me.CHK_OVERWRI_PACKET_COUNTER)
        Me.TAP_GENERAL.Controls.Add(Me.CHK_REMARK_SCRAMBL_TAG)
        Me.TAP_GENERAL.Controls.Add(Me.CHK_ENBL_PID_FILTER)
        Me.TAP_GENERAL.Location = New System.Drawing.Point(4, 29)
        Me.TAP_GENERAL.Name = "TAP_GENERAL"
        Me.TAP_GENERAL.Padding = New System.Windows.Forms.Padding(3)
        Me.TAP_GENERAL.Size = New System.Drawing.Size(630, 247)
        Me.TAP_GENERAL.TabIndex = 0
        Me.TAP_GENERAL.Text = " GENERAL "
        Me.TAP_GENERAL.UseVisualStyleBackColor = True
        '
        'CBO_REMARK_SCRABMBL_TAG
        '
        Me.CBO_REMARK_SCRABMBL_TAG.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBO_REMARK_SCRABMBL_TAG.FormattingEnabled = True
        Me.CBO_REMARK_SCRABMBL_TAG.Items.AddRange(New Object() {"00 (none)", "01 (reserved)", "10 (even)", "11 (odd)"})
        Me.CBO_REMARK_SCRABMBL_TAG.Location = New System.Drawing.Point(450, 70)
        Me.CBO_REMARK_SCRABMBL_TAG.Name = "CBO_REMARK_SCRABMBL_TAG"
        Me.CBO_REMARK_SCRABMBL_TAG.Size = New System.Drawing.Size(116, 27)
        Me.CBO_REMARK_SCRABMBL_TAG.TabIndex = 3106
        Me.CBO_REMARK_SCRABMBL_TAG.Text = "00 (none)"
        '
        'CHK_SCRAMBL_SEGMENT
        '
        Me.CHK_SCRAMBL_SEGMENT.AutoSize = True
        Me.CHK_SCRAMBL_SEGMENT.Location = New System.Drawing.Point(224, 101)
        Me.CHK_SCRAMBL_SEGMENT.Name = "CHK_SCRAMBL_SEGMENT"
        Me.CHK_SCRAMBL_SEGMENT.Size = New System.Drawing.Size(291, 24)
        Me.CHK_SCRAMBL_SEGMENT.TabIndex = 3107
        Me.CHK_SCRAMBL_SEGMENT.Text = "Scrambling tag based segmentation"
        Me.CHK_SCRAMBL_SEGMENT.UseVisualStyleBackColor = True
        '
        'CHK_SELECT_ALL_PID
        '
        Me.CHK_SELECT_ALL_PID.AutoSize = True
        Me.CHK_SELECT_ALL_PID.Location = New System.Drawing.Point(16, 41)
        Me.CHK_SELECT_ALL_PID.Name = "CHK_SELECT_ALL_PID"
        Me.CHK_SELECT_ALL_PID.Size = New System.Drawing.Size(131, 24)
        Me.CHK_SELECT_ALL_PID.TabIndex = 3003
        Me.CHK_SELECT_ALL_PID.Text = "Select All PIDs"
        Me.CHK_SELECT_ALL_PID.UseVisualStyleBackColor = True
        '
        'CHK_EXTRACT_PAYLOAD
        '
        Me.CHK_EXTRACT_PAYLOAD.AutoSize = True
        Me.CHK_EXTRACT_PAYLOAD.Location = New System.Drawing.Point(224, 161)
        Me.CHK_EXTRACT_PAYLOAD.Name = "CHK_EXTRACT_PAYLOAD"
        Me.CHK_EXTRACT_PAYLOAD.Size = New System.Drawing.Size(203, 24)
        Me.CHK_EXTRACT_PAYLOAD.TabIndex = 3111
        Me.CHK_EXTRACT_PAYLOAD.Text = "Extract only the payload"
        Me.CHK_EXTRACT_PAYLOAD.UseVisualStyleBackColor = True
        '
        'LBL_SUBH_PACKET_HEADER
        '
        Me.LBL_SUBH_PACKET_HEADER.AutoSize = True
        Me.LBL_SUBH_PACKET_HEADER.Location = New System.Drawing.Point(220, 12)
        Me.LBL_SUBH_PACKET_HEADER.Name = "LBL_SUBH_PACKET_HEADER"
        Me.LBL_SUBH_PACKET_HEADER.Size = New System.Drawing.Size(133, 20)
        Me.LBL_SUBH_PACKET_HEADER.TabIndex = 3101
        Me.LBL_SUBH_PACKET_HEADER.Text = "[ Packet Header ]"
        '
        'TXT_ADD_PID
        '
        Me.TXT_ADD_PID.Location = New System.Drawing.Point(16, 72)
        Me.TXT_ADD_PID.Name = "TXT_ADD_PID"
        Me.TXT_ADD_PID.Size = New System.Drawing.Size(150, 27)
        Me.TXT_ADD_PID.TabIndex = 3005
        '
        'BTN_ADD_PID
        '
        Me.BTN_ADD_PID.Location = New System.Drawing.Point(16, 105)
        Me.BTN_ADD_PID.Name = "BTN_ADD_PID"
        Me.BTN_ADD_PID.Size = New System.Drawing.Size(150, 28)
        Me.BTN_ADD_PID.TabIndex = 3007
        Me.BTN_ADD_PID.Text = "&Add PID"
        Me.BTN_ADD_PID.UseVisualStyleBackColor = True
        '
        'LBL_SUBH_PID_LIST
        '
        Me.LBL_SUBH_PID_LIST.AutoSize = True
        Me.LBL_SUBH_PID_LIST.Location = New System.Drawing.Point(12, 12)
        Me.LBL_SUBH_PID_LIST.Name = "LBL_SUBH_PID_LIST"
        Me.LBL_SUBH_PID_LIST.Size = New System.Drawing.Size(80, 20)
        Me.LBL_SUBH_PID_LIST.TabIndex = 3001
        Me.LBL_SUBH_PID_LIST.Text = "[ PID List ]"
        '
        'BTN_PID_MOVE_DOWN
        '
        Me.BTN_PID_MOVE_DOWN.Location = New System.Drawing.Point(16, 201)
        Me.BTN_PID_MOVE_DOWN.Name = "BTN_PID_MOVE_DOWN"
        Me.BTN_PID_MOVE_DOWN.Size = New System.Drawing.Size(150, 28)
        Me.BTN_PID_MOVE_DOWN.TabIndex = 3013
        Me.BTN_PID_MOVE_DOWN.Text = "Move &Down"
        Me.BTN_PID_MOVE_DOWN.UseVisualStyleBackColor = True
        '
        'BTN_PID_MOVE_UP
        '
        Me.BTN_PID_MOVE_UP.Location = New System.Drawing.Point(16, 169)
        Me.BTN_PID_MOVE_UP.Name = "BTN_PID_MOVE_UP"
        Me.BTN_PID_MOVE_UP.Size = New System.Drawing.Size(150, 28)
        Me.BTN_PID_MOVE_UP.TabIndex = 3011
        Me.BTN_PID_MOVE_UP.Text = "Move &Up"
        Me.BTN_PID_MOVE_UP.UseVisualStyleBackColor = True
        '
        'BTN_REMOVE_PID
        '
        Me.BTN_REMOVE_PID.Location = New System.Drawing.Point(16, 137)
        Me.BTN_REMOVE_PID.Name = "BTN_REMOVE_PID"
        Me.BTN_REMOVE_PID.Size = New System.Drawing.Size(150, 28)
        Me.BTN_REMOVE_PID.TabIndex = 3009
        Me.BTN_REMOVE_PID.Text = "&Remove PID"
        Me.BTN_REMOVE_PID.UseVisualStyleBackColor = True
        '
        'CHK_OVERWRI_PACKET_COUNTER
        '
        Me.CHK_OVERWRI_PACKET_COUNTER.AutoSize = True
        Me.CHK_OVERWRI_PACKET_COUNTER.Location = New System.Drawing.Point(224, 131)
        Me.CHK_OVERWRI_PACKET_COUNTER.Name = "CHK_OVERWRI_PACKET_COUNTER"
        Me.CHK_OVERWRI_PACKET_COUNTER.Size = New System.Drawing.Size(214, 24)
        Me.CHK_OVERWRI_PACKET_COUNTER.TabIndex = 3109
        Me.CHK_OVERWRI_PACKET_COUNTER.Text = "Overwrite packet counter"
        Me.CHK_OVERWRI_PACKET_COUNTER.UseVisualStyleBackColor = True
        '
        'CHK_REMARK_SCRAMBL_TAG
        '
        Me.CHK_REMARK_SCRAMBL_TAG.AutoSize = True
        Me.CHK_REMARK_SCRAMBL_TAG.Location = New System.Drawing.Point(224, 71)
        Me.CHK_REMARK_SCRAMBL_TAG.Name = "CHK_REMARK_SCRAMBL_TAG"
        Me.CHK_REMARK_SCRAMBL_TAG.Size = New System.Drawing.Size(220, 24)
        Me.CHK_REMARK_SCRAMBL_TAG.TabIndex = 3105
        Me.CHK_REMARK_SCRAMBL_TAG.Text = "Re-mark scrambling tag as"
        Me.CHK_REMARK_SCRAMBL_TAG.UseVisualStyleBackColor = True
        '
        'CHK_ENBL_PID_FILTER
        '
        Me.CHK_ENBL_PID_FILTER.AutoSize = True
        Me.CHK_ENBL_PID_FILTER.Checked = True
        Me.CHK_ENBL_PID_FILTER.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_ENBL_PID_FILTER.Location = New System.Drawing.Point(224, 41)
        Me.CHK_ENBL_PID_FILTER.Name = "CHK_ENBL_PID_FILTER"
        Me.CHK_ENBL_PID_FILTER.Size = New System.Drawing.Size(142, 24)
        Me.CHK_ENBL_PID_FILTER.TabIndex = 3103
        Me.CHK_ENBL_PID_FILTER.Text = "Enable PID filter"
        Me.CHK_ENBL_PID_FILTER.UseVisualStyleBackColor = True
        '
        'TAP_PID
        '
        Me.TAP_PID.Controls.Add(Me.TXT_PID_OVERWRITE)
        Me.TAP_PID.Controls.Add(Me.BTN_PID_REWRITE_REMOVE)
        Me.TAP_PID.Controls.Add(Me.BTN_PID_REWRITE_ADD)
        Me.TAP_PID.Controls.Add(Me.TXT_PID_ORIGINAL)
        Me.TAP_PID.Controls.Add(Me.LSV_PID_REWRITE)
        Me.TAP_PID.Location = New System.Drawing.Point(4, 29)
        Me.TAP_PID.Name = "TAP_PID"
        Me.TAP_PID.Size = New System.Drawing.Size(630, 247)
        Me.TAP_PID.TabIndex = 10
        Me.TAP_PID.Text = " PID "
        Me.TAP_PID.UseVisualStyleBackColor = True
        '
        'TXT_PID_OVERWRITE
        '
        Me.TXT_PID_OVERWRITE.Location = New System.Drawing.Point(263, 214)
        Me.TXT_PID_OVERWRITE.Name = "TXT_PID_OVERWRITE"
        Me.TXT_PID_OVERWRITE.Size = New System.Drawing.Size(248, 27)
        Me.TXT_PID_OVERWRITE.TabIndex = 3913
        '
        'BTN_PID_REWRITE_REMOVE
        '
        Me.BTN_PID_REWRITE_REMOVE.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_PID_REWRITE_REMOVE.Location = New System.Drawing.Point(593, 214)
        Me.BTN_PID_REWRITE_REMOVE.Name = "BTN_PID_REWRITE_REMOVE"
        Me.BTN_PID_REWRITE_REMOVE.Size = New System.Drawing.Size(27, 27)
        Me.BTN_PID_REWRITE_REMOVE.TabIndex = 3923
        Me.BTN_PID_REWRITE_REMOVE.Text = "-"
        Me.BTN_PID_REWRITE_REMOVE.UseVisualStyleBackColor = True
        '
        'BTN_PID_REWRITE_ADD
        '
        Me.BTN_PID_REWRITE_ADD.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_PID_REWRITE_ADD.Location = New System.Drawing.Point(564, 214)
        Me.BTN_PID_REWRITE_ADD.Name = "BTN_PID_REWRITE_ADD"
        Me.BTN_PID_REWRITE_ADD.Size = New System.Drawing.Size(27, 27)
        Me.BTN_PID_REWRITE_ADD.TabIndex = 3921
        Me.BTN_PID_REWRITE_ADD.Text = "+"
        Me.BTN_PID_REWRITE_ADD.UseVisualStyleBackColor = True
        '
        'TXT_PID_ORIGINAL
        '
        Me.TXT_PID_ORIGINAL.Location = New System.Drawing.Point(10, 214)
        Me.TXT_PID_ORIGINAL.Name = "TXT_PID_ORIGINAL"
        Me.TXT_PID_ORIGINAL.Size = New System.Drawing.Size(248, 27)
        Me.TXT_PID_ORIGINAL.TabIndex = 3911
        '
        'LSV_PID_REWRITE
        '
        Me.LSV_PID_REWRITE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LSV_PID_REWRITE.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CLH_PID_ORIGINAL, Me.CLH_PID_OVERWRITE})
        Me.LSV_PID_REWRITE.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LSV_PID_REWRITE.FullRowSelect = True
        Me.LSV_PID_REWRITE.HideSelection = False
        Me.LSV_PID_REWRITE.Location = New System.Drawing.Point(10, 9)
        Me.LSV_PID_REWRITE.Name = "LSV_PID_REWRITE"
        Me.LSV_PID_REWRITE.Size = New System.Drawing.Size(610, 199)
        Me.LSV_PID_REWRITE.TabIndex = 3901
        Me.LSV_PID_REWRITE.UseCompatibleStateImageBehavior = False
        Me.LSV_PID_REWRITE.View = System.Windows.Forms.View.Details
        '
        'CLH_PID_ORIGINAL
        '
        Me.CLH_PID_ORIGINAL.Text = "Original PID"
        Me.CLH_PID_ORIGINAL.Width = 250
        '
        'CLH_PID_OVERWRITE
        '
        Me.CLH_PID_OVERWRITE.Text = "Overwrite PID"
        Me.CLH_PID_OVERWRITE.Width = 250
        '
        'TAP_PAT_PMT
        '
        Me.TAP_PAT_PMT.Controls.Add(Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_PERIOD_2)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_PERIOD_1)
        Me.TAP_PAT_PMT.Controls.Add(Me.NUM_PAT_PMT_PERIOD)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_SELECT_PID_PID)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_SELECT_PID)
        Me.TAP_PAT_PMT.Controls.Add(Me.CBO_PAT_PMT_STREAM_TYPE)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_STREAM_TYPE)
        Me.TAP_PAT_PMT.Controls.Add(Me.TXT_PAT_PMT_STREAM_TYPE)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_SUBH_PMT)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_PID)
        Me.TAP_PAT_PMT.Controls.Add(Me.TXT_PAT_PMT_PID)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_PROGRAM_NUMBER)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_PAT_PMT_TRANSPO_STREAM_ID)
        Me.TAP_PAT_PMT.Controls.Add(Me.TXT_PAT_PMT_PROGRAM_NUMBER)
        Me.TAP_PAT_PMT.Controls.Add(Me.TXT_PAT_PMT_TRANSPO_STREAM_ID)
        Me.TAP_PAT_PMT.Controls.Add(Me.CHK_ENBL_PAT_PMT)
        Me.TAP_PAT_PMT.Controls.Add(Me.LBL_SUBH_PAT)
        Me.TAP_PAT_PMT.Location = New System.Drawing.Point(4, 29)
        Me.TAP_PAT_PMT.Name = "TAP_PAT_PMT"
        Me.TAP_PAT_PMT.Padding = New System.Windows.Forms.Padding(3)
        Me.TAP_PAT_PMT.Size = New System.Drawing.Size(630, 247)
        Me.TAP_PAT_PMT.TabIndex = 1
        Me.TAP_PAT_PMT.Text = " PAT/PMT "
        Me.TAP_PAT_PMT.UseVisualStyleBackColor = True
        '
        'CBO_PAT_PMT_STREAM_TYPE_DEFINIT
        '
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.FormattingEnabled = True
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Items.AddRange(New Object() {"AC-3 Audio", "DRA Audio"})
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Location = New System.Drawing.Point(475, 208)
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Name = "CBO_PAT_PMT_STREAM_TYPE_DEFINIT"
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Size = New System.Drawing.Size(138, 27)
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.TabIndex = 5607
        Me.CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Text = "Codec definition"
        '
        'LBL_PAT_PMT_PERIOD_2
        '
        Me.LBL_PAT_PMT_PERIOD_2.AutoSize = True
        Me.LBL_PAT_PMT_PERIOD_2.Location = New System.Drawing.Point(308, 82)
        Me.LBL_PAT_PMT_PERIOD_2.Name = "LBL_PAT_PMT_PERIOD_2"
        Me.LBL_PAT_PMT_PERIOD_2.Size = New System.Drawing.Size(64, 20)
        Me.LBL_PAT_PMT_PERIOD_2.TabIndex = 5107
        Me.LBL_PAT_PMT_PERIOD_2.Text = "Packets"
        '
        'LBL_PAT_PMT_PERIOD_1
        '
        Me.LBL_PAT_PMT_PERIOD_1.AutoSize = True
        Me.LBL_PAT_PMT_PERIOD_1.Location = New System.Drawing.Point(13, 81)
        Me.LBL_PAT_PMT_PERIOD_1.Name = "LBL_PAT_PMT_PERIOD_1"
        Me.LBL_PAT_PMT_PERIOD_1.Size = New System.Drawing.Size(106, 20)
        Me.LBL_PAT_PMT_PERIOD_1.TabIndex = 5103
        Me.LBL_PAT_PMT_PERIOD_1.Text = "Insert Period:"
        '
        'NUM_PAT_PMT_PERIOD
        '
        Me.NUM_PAT_PMT_PERIOD.Location = New System.Drawing.Point(177, 79)
        Me.NUM_PAT_PMT_PERIOD.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NUM_PAT_PMT_PERIOD.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUM_PAT_PMT_PERIOD.Name = "NUM_PAT_PMT_PERIOD"
        Me.NUM_PAT_PMT_PERIOD.Size = New System.Drawing.Size(125, 27)
        Me.NUM_PAT_PMT_PERIOD.TabIndex = 5105
        Me.NUM_PAT_PMT_PERIOD.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'LBL_PAT_PMT_SELECT_PID_PID
        '
        Me.LBL_PAT_PMT_SELECT_PID_PID.AutoSize = True
        Me.LBL_PAT_PMT_SELECT_PID_PID.Location = New System.Drawing.Point(363, 180)
        Me.LBL_PAT_PMT_SELECT_PID_PID.Name = "LBL_PAT_PMT_SELECT_PID_PID"
        Me.LBL_PAT_PMT_SELECT_PID_PID.Size = New System.Drawing.Size(18, 20)
        Me.LBL_PAT_PMT_SELECT_PID_PID.TabIndex = 5505
        Me.LBL_PAT_PMT_SELECT_PID_PID.Text = "0"
        '
        'LBL_PAT_PMT_SELECT_PID
        '
        Me.LBL_PAT_PMT_SELECT_PID.AutoSize = True
        Me.LBL_PAT_PMT_SELECT_PID.Location = New System.Drawing.Point(252, 180)
        Me.LBL_PAT_PMT_SELECT_PID.Name = "LBL_PAT_PMT_SELECT_PID"
        Me.LBL_PAT_PMT_SELECT_PID.Size = New System.Drawing.Size(105, 20)
        Me.LBL_PAT_PMT_SELECT_PID.TabIndex = 5503
        Me.LBL_PAT_PMT_SELECT_PID.Text = "Selected PID:"
        '
        'CBO_PAT_PMT_STREAM_TYPE
        '
        Me.CBO_PAT_PMT_STREAM_TYPE.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBO_PAT_PMT_STREAM_TYPE.FormattingEnabled = True
        Me.CBO_PAT_PMT_STREAM_TYPE.Items.AddRange(New Object() {"AVC (0x1B)", "HEVC (0x24)", "MPEG-1 Video (0x01)", "MPEG-2 Video (0x02)", "MPEG-4 Video (0x10)", "AVS+ (0x42)", "AVS2 (0xD2)", "AVS3 Video (0xD4)", "VC-1 (0xEA)", "LPCM (0x80)", "MPEG-1 Audio (0x03)", "MPEG-2 Audio (0x04)", "AAC (0x0F)", "AAC LATM (0x11)", "AC-3 (0x81)", "E-AC-3 (0x84)", "DRA (0x06)", "AVS3 Audio (0xD3)", "DTS (0x82)", "Dolby TrueHD (0x83)", "DTS-HD (0x85)", "DTS-MA (0x86)", "PGS (0x90)", "IGS (0x91)", "Text Subtitle (0x92)"})
        Me.CBO_PAT_PMT_STREAM_TYPE.Location = New System.Drawing.Point(256, 208)
        Me.CBO_PAT_PMT_STREAM_TYPE.Name = "CBO_PAT_PMT_STREAM_TYPE"
        Me.CBO_PAT_PMT_STREAM_TYPE.Size = New System.Drawing.Size(186, 27)
        Me.CBO_PAT_PMT_STREAM_TYPE.TabIndex = 5605
        Me.CBO_PAT_PMT_STREAM_TYPE.Text = "Please select..."
        '
        'LBL_PAT_PMT_STREAM_TYPE
        '
        Me.LBL_PAT_PMT_STREAM_TYPE.AutoSize = True
        Me.LBL_PAT_PMT_STREAM_TYPE.Location = New System.Drawing.Point(13, 211)
        Me.LBL_PAT_PMT_STREAM_TYPE.Name = "LBL_PAT_PMT_STREAM_TYPE"
        Me.LBL_PAT_PMT_STREAM_TYPE.Size = New System.Drawing.Size(105, 20)
        Me.LBL_PAT_PMT_STREAM_TYPE.TabIndex = 5601
        Me.LBL_PAT_PMT_STREAM_TYPE.Text = "Stream Type:"
        '
        'TXT_PAT_PMT_STREAM_TYPE
        '
        Me.TXT_PAT_PMT_STREAM_TYPE.Location = New System.Drawing.Point(125, 208)
        Me.TXT_PAT_PMT_STREAM_TYPE.Name = "TXT_PAT_PMT_STREAM_TYPE"
        Me.TXT_PAT_PMT_STREAM_TYPE.Size = New System.Drawing.Size(125, 27)
        Me.TXT_PAT_PMT_STREAM_TYPE.TabIndex = 5603
        '
        'LBL_SUBH_PMT
        '
        Me.LBL_SUBH_PMT.AutoSize = True
        Me.LBL_SUBH_PMT.Location = New System.Drawing.Point(13, 180)
        Me.LBL_SUBH_PMT.Name = "LBL_SUBH_PMT"
        Me.LBL_SUBH_PMT.Size = New System.Drawing.Size(218, 20)
        Me.LBL_SUBH_PMT.TabIndex = 5501
        Me.LBL_SUBH_PMT.Text = "[ Program Map Table (PMT) ]"
        '
        'LBL_PAT_PMT_PID
        '
        Me.LBL_PAT_PMT_PID.AutoSize = True
        Me.LBL_PAT_PMT_PID.Location = New System.Drawing.Point(334, 142)
        Me.LBL_PAT_PMT_PID.Name = "LBL_PAT_PMT_PID"
        Me.LBL_PAT_PMT_PID.Size = New System.Drawing.Size(74, 20)
        Me.LBL_PAT_PMT_PID.TabIndex = 5401
        Me.LBL_PAT_PMT_PID.Text = "PMT PID:"
        '
        'TXT_PAT_PMT_PID
        '
        Me.TXT_PAT_PMT_PID.Location = New System.Drawing.Point(414, 139)
        Me.TXT_PAT_PMT_PID.Name = "TXT_PAT_PMT_PID"
        Me.TXT_PAT_PMT_PID.Size = New System.Drawing.Size(125, 27)
        Me.TXT_PAT_PMT_PID.TabIndex = 5403
        Me.TXT_PAT_PMT_PID.Text = "32"
        '
        'LBL_PAT_PMT_PROGRAM_NUMBER
        '
        Me.LBL_PAT_PMT_PROGRAM_NUMBER.AutoSize = True
        Me.LBL_PAT_PMT_PROGRAM_NUMBER.Location = New System.Drawing.Point(12, 142)
        Me.LBL_PAT_PMT_PROGRAM_NUMBER.Name = "LBL_PAT_PMT_PROGRAM_NUMBER"
        Me.LBL_PAT_PMT_PROGRAM_NUMBER.Size = New System.Drawing.Size(140, 20)
        Me.LBL_PAT_PMT_PROGRAM_NUMBER.TabIndex = 5301
        Me.LBL_PAT_PMT_PROGRAM_NUMBER.Text = "Program Number:"
        '
        'LBL_PAT_PMT_TRANSPO_STREAM_ID
        '
        Me.LBL_PAT_PMT_TRANSPO_STREAM_ID.AutoSize = True
        Me.LBL_PAT_PMT_TRANSPO_STREAM_ID.Location = New System.Drawing.Point(12, 112)
        Me.LBL_PAT_PMT_TRANSPO_STREAM_ID.Name = "LBL_PAT_PMT_TRANSPO_STREAM_ID"
        Me.LBL_PAT_PMT_TRANSPO_STREAM_ID.Size = New System.Drawing.Size(159, 20)
        Me.LBL_PAT_PMT_TRANSPO_STREAM_ID.TabIndex = 5201
        Me.LBL_PAT_PMT_TRANSPO_STREAM_ID.Text = "Transport Stream ID:"
        '
        'TXT_PAT_PMT_PROGRAM_NUMBER
        '
        Me.TXT_PAT_PMT_PROGRAM_NUMBER.Location = New System.Drawing.Point(177, 139)
        Me.TXT_PAT_PMT_PROGRAM_NUMBER.Name = "TXT_PAT_PMT_PROGRAM_NUMBER"
        Me.TXT_PAT_PMT_PROGRAM_NUMBER.Size = New System.Drawing.Size(125, 27)
        Me.TXT_PAT_PMT_PROGRAM_NUMBER.TabIndex = 5303
        Me.TXT_PAT_PMT_PROGRAM_NUMBER.Text = "1"
        '
        'TXT_PAT_PMT_TRANSPO_STREAM_ID
        '
        Me.TXT_PAT_PMT_TRANSPO_STREAM_ID.Location = New System.Drawing.Point(177, 109)
        Me.TXT_PAT_PMT_TRANSPO_STREAM_ID.Name = "TXT_PAT_PMT_TRANSPO_STREAM_ID"
        Me.TXT_PAT_PMT_TRANSPO_STREAM_ID.Size = New System.Drawing.Size(125, 27)
        Me.TXT_PAT_PMT_TRANSPO_STREAM_ID.TabIndex = 5203
        Me.TXT_PAT_PMT_TRANSPO_STREAM_ID.Text = "1"
        '
        'CHK_ENBL_PAT_PMT
        '
        Me.CHK_ENBL_PAT_PMT.AutoSize = True
        Me.CHK_ENBL_PAT_PMT.Location = New System.Drawing.Point(16, 12)
        Me.CHK_ENBL_PAT_PMT.Name = "CHK_ENBL_PAT_PMT"
        Me.CHK_ENBL_PAT_PMT.Size = New System.Drawing.Size(233, 24)
        Me.CHK_ENBL_PAT_PMT.TabIndex = 5001
        Me.CHK_ENBL_PAT_PMT.Text = "Rebuild PAT and PMT tables"
        Me.CHK_ENBL_PAT_PMT.UseVisualStyleBackColor = True
        '
        'LBL_SUBH_PAT
        '
        Me.LBL_SUBH_PAT.AutoSize = True
        Me.LBL_SUBH_PAT.Location = New System.Drawing.Point(12, 50)
        Me.LBL_SUBH_PAT.Name = "LBL_SUBH_PAT"
        Me.LBL_SUBH_PAT.Size = New System.Drawing.Size(265, 20)
        Me.LBL_SUBH_PAT.TabIndex = 5101
        Me.LBL_SUBH_PAT.Text = "[ Program Association Table (PAT) ]"
        '
        'TAP_SDT
        '
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_PERIOD_2)
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_PERIOD_1)
        Me.TAP_SDT.Controls.Add(Me.NUM_SDT_PERIOD)
        Me.TAP_SDT.Controls.Add(Me.CBO_SDT_SERVICE_TYPE)
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_SERVICE_TYPE)
        Me.TAP_SDT.Controls.Add(Me.TXT_SDT_SERVICE_TYPE)
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_SERVICE_PROVIDER)
        Me.TAP_SDT.Controls.Add(Me.TXT_SDT_SERVICE_PROVIDER)
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_SERVICE_NAME)
        Me.TAP_SDT.Controls.Add(Me.TXT_SDT_SERVICE_NAME)
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_SERVICE_ID)
        Me.TAP_SDT.Controls.Add(Me.TXT_SDT_SERVICE_ID)
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_NETWORK_ID)
        Me.TAP_SDT.Controls.Add(Me.LBL_SDT_TRANSPO_STREAM_ID)
        Me.TAP_SDT.Controls.Add(Me.TXT_SDT_NETWORK_ID)
        Me.TAP_SDT.Controls.Add(Me.TXT_SDT_TRANSPO_STREAM_ID)
        Me.TAP_SDT.Controls.Add(Me.CHK_ENBL_SDT)
        Me.TAP_SDT.Location = New System.Drawing.Point(4, 29)
        Me.TAP_SDT.Name = "TAP_SDT"
        Me.TAP_SDT.Size = New System.Drawing.Size(630, 247)
        Me.TAP_SDT.TabIndex = 2
        Me.TAP_SDT.Text = " SDT "
        Me.TAP_SDT.UseVisualStyleBackColor = True
        '
        'LBL_SDT_PERIOD_2
        '
        Me.LBL_SDT_PERIOD_2.AutoSize = True
        Me.LBL_SDT_PERIOD_2.Location = New System.Drawing.Point(543, 14)
        Me.LBL_SDT_PERIOD_2.Name = "LBL_SDT_PERIOD_2"
        Me.LBL_SDT_PERIOD_2.Size = New System.Drawing.Size(64, 20)
        Me.LBL_SDT_PERIOD_2.TabIndex = 6007
        Me.LBL_SDT_PERIOD_2.Text = "Packets"
        '
        'LBL_SDT_PERIOD_1
        '
        Me.LBL_SDT_PERIOD_1.AutoSize = True
        Me.LBL_SDT_PERIOD_1.Location = New System.Drawing.Point(248, 13)
        Me.LBL_SDT_PERIOD_1.Name = "LBL_SDT_PERIOD_1"
        Me.LBL_SDT_PERIOD_1.Size = New System.Drawing.Size(106, 20)
        Me.LBL_SDT_PERIOD_1.TabIndex = 6003
        Me.LBL_SDT_PERIOD_1.Text = "Insert Period:"
        '
        'NUM_SDT_PERIOD
        '
        Me.NUM_SDT_PERIOD.Location = New System.Drawing.Point(412, 11)
        Me.NUM_SDT_PERIOD.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NUM_SDT_PERIOD.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUM_SDT_PERIOD.Name = "NUM_SDT_PERIOD"
        Me.NUM_SDT_PERIOD.Size = New System.Drawing.Size(125, 27)
        Me.NUM_SDT_PERIOD.TabIndex = 6005
        Me.NUM_SDT_PERIOD.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'CBO_SDT_SERVICE_TYPE
        '
        Me.CBO_SDT_SERVICE_TYPE.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CBO_SDT_SERVICE_TYPE.FormattingEnabled = True
        Me.CBO_SDT_SERVICE_TYPE.Items.AddRange(New Object() {"digital television (0x01)", "digital radio sound (0x02)", "Teletext (0x03)", "FM radio (0x07)", "advanced codec digital radio sound (0x0A)", "data broadcast (0x0C)", "MPEG-2 HD digital television (0x11)", "H.264/AVC SD digital television (0x16)", "H.264/AVC HD digital television (0x19)", "HEVC digital television (0x1F)"})
        Me.CBO_SDT_SERVICE_TYPE.Location = New System.Drawing.Point(308, 207)
        Me.CBO_SDT_SERVICE_TYPE.Name = "CBO_SDT_SERVICE_TYPE"
        Me.CBO_SDT_SERVICE_TYPE.Size = New System.Drawing.Size(300, 27)
        Me.CBO_SDT_SERVICE_TYPE.TabIndex = 6213
        Me.CBO_SDT_SERVICE_TYPE.Text = "Please select..."
        '
        'LBL_SDT_SERVICE_TYPE
        '
        Me.LBL_SDT_SERVICE_TYPE.AutoSize = True
        Me.LBL_SDT_SERVICE_TYPE.Location = New System.Drawing.Point(12, 210)
        Me.LBL_SDT_SERVICE_TYPE.Name = "LBL_SDT_SERVICE_TYPE"
        Me.LBL_SDT_SERVICE_TYPE.Size = New System.Drawing.Size(103, 20)
        Me.LBL_SDT_SERVICE_TYPE.TabIndex = 6209
        Me.LBL_SDT_SERVICE_TYPE.Text = "Service type:"
        '
        'TXT_SDT_SERVICE_TYPE
        '
        Me.TXT_SDT_SERVICE_TYPE.Location = New System.Drawing.Point(177, 207)
        Me.TXT_SDT_SERVICE_TYPE.Name = "TXT_SDT_SERVICE_TYPE"
        Me.TXT_SDT_SERVICE_TYPE.Size = New System.Drawing.Size(125, 27)
        Me.TXT_SDT_SERVICE_TYPE.TabIndex = 6211
        '
        'LBL_SDT_SERVICE_PROVIDER
        '
        Me.LBL_SDT_SERVICE_PROVIDER.AutoSize = True
        Me.LBL_SDT_SERVICE_PROVIDER.Location = New System.Drawing.Point(12, 179)
        Me.LBL_SDT_SERVICE_PROVIDER.Name = "LBL_SDT_SERVICE_PROVIDER"
        Me.LBL_SDT_SERVICE_PROVIDER.Size = New System.Drawing.Size(133, 20)
        Me.LBL_SDT_SERVICE_PROVIDER.TabIndex = 6205
        Me.LBL_SDT_SERVICE_PROVIDER.Text = "Service provider:"
        '
        'TXT_SDT_SERVICE_PROVIDER
        '
        Me.TXT_SDT_SERVICE_PROVIDER.Location = New System.Drawing.Point(177, 176)
        Me.TXT_SDT_SERVICE_PROVIDER.Name = "TXT_SDT_SERVICE_PROVIDER"
        Me.TXT_SDT_SERVICE_PROVIDER.Size = New System.Drawing.Size(431, 27)
        Me.TXT_SDT_SERVICE_PROVIDER.TabIndex = 6207
        '
        'LBL_SDT_SERVICE_NAME
        '
        Me.LBL_SDT_SERVICE_NAME.AutoSize = True
        Me.LBL_SDT_SERVICE_NAME.Location = New System.Drawing.Point(12, 148)
        Me.LBL_SDT_SERVICE_NAME.Name = "LBL_SDT_SERVICE_NAME"
        Me.LBL_SDT_SERVICE_NAME.Size = New System.Drawing.Size(110, 20)
        Me.LBL_SDT_SERVICE_NAME.TabIndex = 6201
        Me.LBL_SDT_SERVICE_NAME.Text = "Service name:"
        '
        'TXT_SDT_SERVICE_NAME
        '
        Me.TXT_SDT_SERVICE_NAME.Location = New System.Drawing.Point(177, 145)
        Me.TXT_SDT_SERVICE_NAME.Name = "TXT_SDT_SERVICE_NAME"
        Me.TXT_SDT_SERVICE_NAME.Size = New System.Drawing.Size(431, 27)
        Me.TXT_SDT_SERVICE_NAME.TabIndex = 6203
        '
        'LBL_SDT_SERVICE_ID
        '
        Me.LBL_SDT_SERVICE_ID.AutoSize = True
        Me.LBL_SDT_SERVICE_ID.Location = New System.Drawing.Point(12, 108)
        Me.LBL_SDT_SERVICE_ID.Name = "LBL_SDT_SERVICE_ID"
        Me.LBL_SDT_SERVICE_ID.Size = New System.Drawing.Size(85, 20)
        Me.LBL_SDT_SERVICE_ID.TabIndex = 6109
        Me.LBL_SDT_SERVICE_ID.Text = "Service ID:"
        '
        'TXT_SDT_SERVICE_ID
        '
        Me.TXT_SDT_SERVICE_ID.Location = New System.Drawing.Point(177, 105)
        Me.TXT_SDT_SERVICE_ID.Name = "TXT_SDT_SERVICE_ID"
        Me.TXT_SDT_SERVICE_ID.Size = New System.Drawing.Size(125, 27)
        Me.TXT_SDT_SERVICE_ID.TabIndex = 6111
        Me.TXT_SDT_SERVICE_ID.Text = "1"
        '
        'LBL_SDT_NETWORK_ID
        '
        Me.LBL_SDT_NETWORK_ID.AutoSize = True
        Me.LBL_SDT_NETWORK_ID.Location = New System.Drawing.Point(12, 78)
        Me.LBL_SDT_NETWORK_ID.Name = "LBL_SDT_NETWORK_ID"
        Me.LBL_SDT_NETWORK_ID.Size = New System.Drawing.Size(95, 20)
        Me.LBL_SDT_NETWORK_ID.TabIndex = 6105
        Me.LBL_SDT_NETWORK_ID.Text = "Network ID:"
        '
        'LBL_SDT_TRANSPO_STREAM_ID
        '
        Me.LBL_SDT_TRANSPO_STREAM_ID.AutoSize = True
        Me.LBL_SDT_TRANSPO_STREAM_ID.Location = New System.Drawing.Point(12, 47)
        Me.LBL_SDT_TRANSPO_STREAM_ID.Name = "LBL_SDT_TRANSPO_STREAM_ID"
        Me.LBL_SDT_TRANSPO_STREAM_ID.Size = New System.Drawing.Size(159, 20)
        Me.LBL_SDT_TRANSPO_STREAM_ID.TabIndex = 6101
        Me.LBL_SDT_TRANSPO_STREAM_ID.Text = "Transport Stream ID:"
        '
        'TXT_SDT_NETWORK_ID
        '
        Me.TXT_SDT_NETWORK_ID.Location = New System.Drawing.Point(177, 74)
        Me.TXT_SDT_NETWORK_ID.Name = "TXT_SDT_NETWORK_ID"
        Me.TXT_SDT_NETWORK_ID.Size = New System.Drawing.Size(125, 27)
        Me.TXT_SDT_NETWORK_ID.TabIndex = 6107
        Me.TXT_SDT_NETWORK_ID.Text = "1"
        '
        'TXT_SDT_TRANSPO_STREAM_ID
        '
        Me.TXT_SDT_TRANSPO_STREAM_ID.Location = New System.Drawing.Point(177, 44)
        Me.TXT_SDT_TRANSPO_STREAM_ID.Name = "TXT_SDT_TRANSPO_STREAM_ID"
        Me.TXT_SDT_TRANSPO_STREAM_ID.Size = New System.Drawing.Size(125, 27)
        Me.TXT_SDT_TRANSPO_STREAM_ID.TabIndex = 6103
        Me.TXT_SDT_TRANSPO_STREAM_ID.Text = "1"
        '
        'CHK_ENBL_SDT
        '
        Me.CHK_ENBL_SDT.AutoSize = True
        Me.CHK_ENBL_SDT.Location = New System.Drawing.Point(16, 12)
        Me.CHK_ENBL_SDT.Name = "CHK_ENBL_SDT"
        Me.CHK_ENBL_SDT.Size = New System.Drawing.Size(117, 24)
        Me.CHK_ENBL_SDT.TabIndex = 6001
        Me.CHK_ENBL_SDT.Text = "Rebuild SDT"
        Me.CHK_ENBL_SDT.UseVisualStyleBackColor = True
        '
        'TAP_CUTTER
        '
        Me.TAP_CUTTER.Controls.Add(Me.TXT_CUTTER_TOTAL_DURATION)
        Me.TAP_CUTTER.Controls.Add(Me.LBL_CUTTER_TOTAL_DURATION)
        Me.TAP_CUTTER.Controls.Add(Me.LBL_CUTTER_TOTAL_PACKETS_COUNT)
        Me.TAP_CUTTER.Controls.Add(Me.LBL_CUTTER_TOTAL_PACKETS)
        Me.TAP_CUTTER.Controls.Add(Me.BTN_CUTTER_REMOVE)
        Me.TAP_CUTTER.Controls.Add(Me.BTN_CUTTER_ADD)
        Me.TAP_CUTTER.Controls.Add(Me.TXT_CUTTER_END)
        Me.TAP_CUTTER.Controls.Add(Me.TXT_CUTTER_START)
        Me.TAP_CUTTER.Controls.Add(Me.TXT_CUTTER_TASK_NAME)
        Me.TAP_CUTTER.Controls.Add(Me.LSV_CUTTER)
        Me.TAP_CUTTER.Location = New System.Drawing.Point(4, 29)
        Me.TAP_CUTTER.Name = "TAP_CUTTER"
        Me.TAP_CUTTER.Size = New System.Drawing.Size(630, 247)
        Me.TAP_CUTTER.TabIndex = 3
        Me.TAP_CUTTER.Text = " CUTTER "
        Me.TAP_CUTTER.UseVisualStyleBackColor = True
        '
        'TXT_CUTTER_TOTAL_DURATION
        '
        Me.TXT_CUTTER_TOTAL_DURATION.Location = New System.Drawing.Point(416, 214)
        Me.TXT_CUTTER_TOTAL_DURATION.Name = "TXT_CUTTER_TOTAL_DURATION"
        Me.TXT_CUTTER_TOTAL_DURATION.Size = New System.Drawing.Size(142, 27)
        Me.TXT_CUTTER_TOTAL_DURATION.TabIndex = 7407
        '
        'LBL_CUTTER_TOTAL_DURATION
        '
        Me.LBL_CUTTER_TOTAL_DURATION.AutoSize = True
        Me.LBL_CUTTER_TOTAL_DURATION.Location = New System.Drawing.Point(293, 217)
        Me.LBL_CUTTER_TOTAL_DURATION.Name = "LBL_CUTTER_TOTAL_DURATION"
        Me.LBL_CUTTER_TOTAL_DURATION.Size = New System.Drawing.Size(117, 20)
        Me.LBL_CUTTER_TOTAL_DURATION.TabIndex = 7405
        Me.LBL_CUTTER_TOTAL_DURATION.Text = "Total Duration:"
        '
        'LBL_CUTTER_TOTAL_PACKETS_COUNT
        '
        Me.LBL_CUTTER_TOTAL_PACKETS_COUNT.AutoSize = True
        Me.LBL_CUTTER_TOTAL_PACKETS_COUNT.Location = New System.Drawing.Point(121, 217)
        Me.LBL_CUTTER_TOTAL_PACKETS_COUNT.Name = "LBL_CUTTER_TOTAL_PACKETS_COUNT"
        Me.LBL_CUTTER_TOTAL_PACKETS_COUNT.Size = New System.Drawing.Size(18, 20)
        Me.LBL_CUTTER_TOTAL_PACKETS_COUNT.TabIndex = 7403
        Me.LBL_CUTTER_TOTAL_PACKETS_COUNT.Text = "0"
        '
        'LBL_CUTTER_TOTAL_PACKETS
        '
        Me.LBL_CUTTER_TOTAL_PACKETS.AutoSize = True
        Me.LBL_CUTTER_TOTAL_PACKETS.Location = New System.Drawing.Point(6, 217)
        Me.LBL_CUTTER_TOTAL_PACKETS.Name = "LBL_CUTTER_TOTAL_PACKETS"
        Me.LBL_CUTTER_TOTAL_PACKETS.Size = New System.Drawing.Size(109, 20)
        Me.LBL_CUTTER_TOTAL_PACKETS.TabIndex = 7401
        Me.LBL_CUTTER_TOTAL_PACKETS.Text = "Total Packets:"
        '
        'BTN_CUTTER_REMOVE
        '
        Me.BTN_CUTTER_REMOVE.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CUTTER_REMOVE.Location = New System.Drawing.Point(593, 181)
        Me.BTN_CUTTER_REMOVE.Name = "BTN_CUTTER_REMOVE"
        Me.BTN_CUTTER_REMOVE.Size = New System.Drawing.Size(27, 27)
        Me.BTN_CUTTER_REMOVE.TabIndex = 7303
        Me.BTN_CUTTER_REMOVE.Text = "-"
        Me.BTN_CUTTER_REMOVE.UseVisualStyleBackColor = True
        '
        'BTN_CUTTER_ADD
        '
        Me.BTN_CUTTER_ADD.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_CUTTER_ADD.Location = New System.Drawing.Point(564, 181)
        Me.BTN_CUTTER_ADD.Name = "BTN_CUTTER_ADD"
        Me.BTN_CUTTER_ADD.Size = New System.Drawing.Size(27, 27)
        Me.BTN_CUTTER_ADD.TabIndex = 7301
        Me.BTN_CUTTER_ADD.Text = "+"
        Me.BTN_CUTTER_ADD.UseVisualStyleBackColor = True
        '
        'TXT_CUTTER_END
        '
        Me.TXT_CUTTER_END.Location = New System.Drawing.Point(416, 181)
        Me.TXT_CUTTER_END.Name = "TXT_CUTTER_END"
        Me.TXT_CUTTER_END.Size = New System.Drawing.Size(142, 27)
        Me.TXT_CUTTER_END.TabIndex = 7205
        '
        'TXT_CUTTER_START
        '
        Me.TXT_CUTTER_START.Location = New System.Drawing.Point(268, 181)
        Me.TXT_CUTTER_START.Name = "TXT_CUTTER_START"
        Me.TXT_CUTTER_START.Size = New System.Drawing.Size(142, 27)
        Me.TXT_CUTTER_START.TabIndex = 7203
        '
        'TXT_CUTTER_TASK_NAME
        '
        Me.TXT_CUTTER_TASK_NAME.Location = New System.Drawing.Point(10, 181)
        Me.TXT_CUTTER_TASK_NAME.Name = "TXT_CUTTER_TASK_NAME"
        Me.TXT_CUTTER_TASK_NAME.Size = New System.Drawing.Size(252, 27)
        Me.TXT_CUTTER_TASK_NAME.TabIndex = 7201
        '
        'LSV_CUTTER
        '
        Me.LSV_CUTTER.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LSV_CUTTER.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CLH_CUTTER_TASK_NAME, Me.CLH_CUTTER_START, Me.CLH_CUTTER_END})
        Me.LSV_CUTTER.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LSV_CUTTER.FullRowSelect = True
        Me.LSV_CUTTER.HideSelection = False
        Me.LSV_CUTTER.Location = New System.Drawing.Point(10, 9)
        Me.LSV_CUTTER.Name = "LSV_CUTTER"
        Me.LSV_CUTTER.Size = New System.Drawing.Size(610, 164)
        Me.LSV_CUTTER.TabIndex = 7001
        Me.LSV_CUTTER.UseCompatibleStateImageBehavior = False
        Me.LSV_CUTTER.View = System.Windows.Forms.View.Details
        '
        'CLH_CUTTER_TASK_NAME
        '
        Me.CLH_CUTTER_TASK_NAME.Text = "Task Name"
        Me.CLH_CUTTER_TASK_NAME.Width = 250
        '
        'CLH_CUTTER_START
        '
        Me.CLH_CUTTER_START.Text = "Start Packet"
        Me.CLH_CUTTER_START.Width = 150
        '
        'CLH_CUTTER_END
        '
        Me.CLH_CUTTER_END.Text = "End Packet"
        Me.CLH_CUTTER_END.Width = 150
        '
        'TAP_INSERT
        '
        Me.TAP_INSERT.Controls.Add(Me.LBL_INSERT_PERIOD_2)
        Me.TAP_INSERT.Controls.Add(Me.LBL_INSERT_PERIOD_1)
        Me.TAP_INSERT.Controls.Add(Me.NUM_INSERT_PERIOD)
        Me.TAP_INSERT.Controls.Add(Me.BTN_INSERT_TS_FILE)
        Me.TAP_INSERT.Controls.Add(Me.LBL_INSERT_TS_FILE)
        Me.TAP_INSERT.Controls.Add(Me.TXT_INSERT_TS_FILE)
        Me.TAP_INSERT.Controls.Add(Me.CHK_ENBL_INSERT)
        Me.TAP_INSERT.Location = New System.Drawing.Point(4, 29)
        Me.TAP_INSERT.Name = "TAP_INSERT"
        Me.TAP_INSERT.Size = New System.Drawing.Size(630, 247)
        Me.TAP_INSERT.TabIndex = 6
        Me.TAP_INSERT.Text = " INSERT "
        Me.TAP_INSERT.UseVisualStyleBackColor = True
        '
        'LBL_INSERT_PERIOD_2
        '
        Me.LBL_INSERT_PERIOD_2.AutoSize = True
        Me.LBL_INSERT_PERIOD_2.Location = New System.Drawing.Point(307, 77)
        Me.LBL_INSERT_PERIOD_2.Name = "LBL_INSERT_PERIOD_2"
        Me.LBL_INSERT_PERIOD_2.Size = New System.Drawing.Size(64, 20)
        Me.LBL_INSERT_PERIOD_2.TabIndex = 4105
        Me.LBL_INSERT_PERIOD_2.Text = "Packets"
        '
        'LBL_INSERT_PERIOD_1
        '
        Me.LBL_INSERT_PERIOD_1.AutoSize = True
        Me.LBL_INSERT_PERIOD_1.Location = New System.Drawing.Point(12, 77)
        Me.LBL_INSERT_PERIOD_1.Name = "LBL_INSERT_PERIOD_1"
        Me.LBL_INSERT_PERIOD_1.Size = New System.Drawing.Size(106, 20)
        Me.LBL_INSERT_PERIOD_1.TabIndex = 4101
        Me.LBL_INSERT_PERIOD_1.Text = "Insert Period:"
        '
        'NUM_INSERT_PERIOD
        '
        Me.NUM_INSERT_PERIOD.Location = New System.Drawing.Point(176, 75)
        Me.NUM_INSERT_PERIOD.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NUM_INSERT_PERIOD.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUM_INSERT_PERIOD.Name = "NUM_INSERT_PERIOD"
        Me.NUM_INSERT_PERIOD.Size = New System.Drawing.Size(125, 27)
        Me.NUM_INSERT_PERIOD.TabIndex = 4103
        Me.NUM_INSERT_PERIOD.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'BTN_INSERT_TS_FILE
        '
        Me.BTN_INSERT_TS_FILE.Location = New System.Drawing.Point(582, 41)
        Me.BTN_INSERT_TS_FILE.Name = "BTN_INSERT_TS_FILE"
        Me.BTN_INSERT_TS_FILE.Size = New System.Drawing.Size(35, 30)
        Me.BTN_INSERT_TS_FILE.TabIndex = 4007
        Me.BTN_INSERT_TS_FILE.Text = "..."
        Me.BTN_INSERT_TS_FILE.UseVisualStyleBackColor = True
        '
        'LBL_INSERT_TS_FILE
        '
        Me.LBL_INSERT_TS_FILE.AutoSize = True
        Me.LBL_INSERT_TS_FILE.Location = New System.Drawing.Point(12, 45)
        Me.LBL_INSERT_TS_FILE.Name = "LBL_INSERT_TS_FILE"
        Me.LBL_INSERT_TS_FILE.Size = New System.Drawing.Size(60, 20)
        Me.LBL_INSERT_TS_FILE.TabIndex = 4003
        Me.LBL_INSERT_TS_FILE.Text = "TS File:"
        '
        'TXT_INSERT_TS_FILE
        '
        Me.TXT_INSERT_TS_FILE.Location = New System.Drawing.Point(93, 42)
        Me.TXT_INSERT_TS_FILE.Name = "TXT_INSERT_TS_FILE"
        Me.TXT_INSERT_TS_FILE.ReadOnly = True
        Me.TXT_INSERT_TS_FILE.Size = New System.Drawing.Size(485, 27)
        Me.TXT_INSERT_TS_FILE.TabIndex = 4005
        '
        'CHK_ENBL_INSERT
        '
        Me.CHK_ENBL_INSERT.AutoSize = True
        Me.CHK_ENBL_INSERT.Location = New System.Drawing.Point(16, 12)
        Me.CHK_ENBL_INSERT.Name = "CHK_ENBL_INSERT"
        Me.CHK_ENBL_INSERT.Size = New System.Drawing.Size(239, 24)
        Me.CHK_ENBL_INSERT.TabIndex = 4001
        Me.CHK_ENBL_INSERT.Text = "Periodically insert TS packets"
        Me.CHK_ENBL_INSERT.UseVisualStyleBackColor = True
        '
        'TAP_DISCARDER
        '
        Me.TAP_DISCARDER.Controls.Add(Me.NUM_DISCARDER_RANGE_2)
        Me.TAP_DISCARDER.Controls.Add(Me.LBL_DISCARDER_PERIOD_TO)
        Me.TAP_DISCARDER.Controls.Add(Me.LBL_DISCARDER_PERIOD_PACKETS)
        Me.TAP_DISCARDER.Controls.Add(Me.LBL_DISCARDER_PERIOD)
        Me.TAP_DISCARDER.Controls.Add(Me.NUM_DISCARDER_RANGE_1)
        Me.TAP_DISCARDER.Controls.Add(Me.CHK_ENBL_DISCARDER)
        Me.TAP_DISCARDER.Location = New System.Drawing.Point(4, 29)
        Me.TAP_DISCARDER.Name = "TAP_DISCARDER"
        Me.TAP_DISCARDER.Size = New System.Drawing.Size(630, 247)
        Me.TAP_DISCARDER.TabIndex = 7
        Me.TAP_DISCARDER.Text = " DISCARD "
        Me.TAP_DISCARDER.UseVisualStyleBackColor = True
        '
        'NUM_DISCARDER_RANGE_2
        '
        Me.NUM_DISCARDER_RANGE_2.Location = New System.Drawing.Point(303, 42)
        Me.NUM_DISCARDER_RANGE_2.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NUM_DISCARDER_RANGE_2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUM_DISCARDER_RANGE_2.Name = "NUM_DISCARDER_RANGE_2"
        Me.NUM_DISCARDER_RANGE_2.Size = New System.Drawing.Size(125, 27)
        Me.NUM_DISCARDER_RANGE_2.TabIndex = 6917
        Me.NUM_DISCARDER_RANGE_2.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'LBL_DISCARDER_PERIOD_TO
        '
        Me.LBL_DISCARDER_PERIOD_TO.AutoSize = True
        Me.LBL_DISCARDER_PERIOD_TO.Location = New System.Drawing.Point(282, 45)
        Me.LBL_DISCARDER_PERIOD_TO.Name = "LBL_DISCARDER_PERIOD_TO"
        Me.LBL_DISCARDER_PERIOD_TO.Size = New System.Drawing.Size(15, 20)
        Me.LBL_DISCARDER_PERIOD_TO.TabIndex = 6915
        Me.LBL_DISCARDER_PERIOD_TO.Text = "-"
        '
        'LBL_DISCARDER_PERIOD_PACKETS
        '
        Me.LBL_DISCARDER_PERIOD_PACKETS.AutoSize = True
        Me.LBL_DISCARDER_PERIOD_PACKETS.Location = New System.Drawing.Point(434, 45)
        Me.LBL_DISCARDER_PERIOD_PACKETS.Name = "LBL_DISCARDER_PERIOD_PACKETS"
        Me.LBL_DISCARDER_PERIOD_PACKETS.Size = New System.Drawing.Size(64, 20)
        Me.LBL_DISCARDER_PERIOD_PACKETS.TabIndex = 6919
        Me.LBL_DISCARDER_PERIOD_PACKETS.Text = "Packets"
        '
        'LBL_DISCARDER_PERIOD
        '
        Me.LBL_DISCARDER_PERIOD.AutoSize = True
        Me.LBL_DISCARDER_PERIOD.Location = New System.Drawing.Point(12, 45)
        Me.LBL_DISCARDER_PERIOD.Name = "LBL_DISCARDER_PERIOD"
        Me.LBL_DISCARDER_PERIOD.Size = New System.Drawing.Size(119, 20)
        Me.LBL_DISCARDER_PERIOD.TabIndex = 6911
        Me.LBL_DISCARDER_PERIOD.Text = "Discard Period:"
        '
        'NUM_DISCARDER_RANGE_1
        '
        Me.NUM_DISCARDER_RANGE_1.Location = New System.Drawing.Point(151, 42)
        Me.NUM_DISCARDER_RANGE_1.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NUM_DISCARDER_RANGE_1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUM_DISCARDER_RANGE_1.Name = "NUM_DISCARDER_RANGE_1"
        Me.NUM_DISCARDER_RANGE_1.Size = New System.Drawing.Size(125, 27)
        Me.NUM_DISCARDER_RANGE_1.TabIndex = 6913
        Me.NUM_DISCARDER_RANGE_1.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'CHK_ENBL_DISCARDER
        '
        Me.CHK_ENBL_DISCARDER.AutoSize = True
        Me.CHK_ENBL_DISCARDER.Location = New System.Drawing.Point(16, 12)
        Me.CHK_ENBL_DISCARDER.Name = "CHK_ENBL_DISCARDER"
        Me.CHK_ENBL_DISCARDER.Size = New System.Drawing.Size(218, 24)
        Me.CHK_ENBL_DISCARDER.TabIndex = 6901
        Me.CHK_ENBL_DISCARDER.Text = "Randomly discard packets"
        Me.CHK_ENBL_DISCARDER.UseVisualStyleBackColor = True
        '
        'TAP_DDB
        '
        Me.TAP_DDB.Controls.Add(Me.CHK_DDB_SPLIT)
        Me.TAP_DDB.Controls.Add(Me.LBL_DDB_MODULE_ID)
        Me.TAP_DDB.Controls.Add(Me.TXT_DDB_MODULE_ID)
        Me.TAP_DDB.Controls.Add(Me.LBL_DDB_DOWNLOAD_ID)
        Me.TAP_DDB.Controls.Add(Me.TXT_DDB_DOWNLOAD_ID)
        Me.TAP_DDB.Controls.Add(Me.CHK_ENBL_DDB)
        Me.TAP_DDB.Location = New System.Drawing.Point(4, 29)
        Me.TAP_DDB.Name = "TAP_DDB"
        Me.TAP_DDB.Size = New System.Drawing.Size(630, 247)
        Me.TAP_DDB.TabIndex = 8
        Me.TAP_DDB.Text = " DDB "
        Me.TAP_DDB.UseVisualStyleBackColor = True
        '
        'CHK_DDB_SPLIT
        '
        Me.CHK_DDB_SPLIT.AutoSize = True
        Me.CHK_DDB_SPLIT.Location = New System.Drawing.Point(16, 110)
        Me.CHK_DDB_SPLIT.Name = "CHK_DDB_SPLIT"
        Me.CHK_DDB_SPLIT.Size = New System.Drawing.Size(160, 24)
        Me.CHK_DDB_SPLIT.TabIndex = 8941
        Me.CHK_DDB_SPLIT.Text = "Split file by blocks"
        Me.CHK_DDB_SPLIT.UseVisualStyleBackColor = True
        '
        'LBL_DDB_MODULE_ID
        '
        Me.LBL_DDB_MODULE_ID.AutoSize = True
        Me.LBL_DDB_MODULE_ID.Location = New System.Drawing.Point(12, 78)
        Me.LBL_DDB_MODULE_ID.Name = "LBL_DDB_MODULE_ID"
        Me.LBL_DDB_MODULE_ID.Size = New System.Drawing.Size(89, 20)
        Me.LBL_DDB_MODULE_ID.TabIndex = 8931
        Me.LBL_DDB_MODULE_ID.Text = "Module ID:"
        '
        'TXT_DDB_MODULE_ID
        '
        Me.TXT_DDB_MODULE_ID.Location = New System.Drawing.Point(177, 75)
        Me.TXT_DDB_MODULE_ID.Name = "TXT_DDB_MODULE_ID"
        Me.TXT_DDB_MODULE_ID.Size = New System.Drawing.Size(125, 27)
        Me.TXT_DDB_MODULE_ID.TabIndex = 8933
        '
        'LBL_DDB_DOWNLOAD_ID
        '
        Me.LBL_DDB_DOWNLOAD_ID.AutoSize = True
        Me.LBL_DDB_DOWNLOAD_ID.Location = New System.Drawing.Point(12, 48)
        Me.LBL_DDB_DOWNLOAD_ID.Name = "LBL_DDB_DOWNLOAD_ID"
        Me.LBL_DDB_DOWNLOAD_ID.Size = New System.Drawing.Size(106, 20)
        Me.LBL_DDB_DOWNLOAD_ID.TabIndex = 8921
        Me.LBL_DDB_DOWNLOAD_ID.Text = "Download ID:"
        '
        'TXT_DDB_DOWNLOAD_ID
        '
        Me.TXT_DDB_DOWNLOAD_ID.Location = New System.Drawing.Point(177, 44)
        Me.TXT_DDB_DOWNLOAD_ID.Name = "TXT_DDB_DOWNLOAD_ID"
        Me.TXT_DDB_DOWNLOAD_ID.Size = New System.Drawing.Size(125, 27)
        Me.TXT_DDB_DOWNLOAD_ID.TabIndex = 8923
        '
        'CHK_ENBL_DDB
        '
        Me.CHK_ENBL_DDB.AutoSize = True
        Me.CHK_ENBL_DDB.Location = New System.Drawing.Point(16, 12)
        Me.CHK_ENBL_DDB.Name = "CHK_ENBL_DDB"
        Me.CHK_ENBL_DDB.Size = New System.Drawing.Size(305, 24)
        Me.CHK_ENBL_DDB.TabIndex = 8901
        Me.CHK_ENBL_DDB.Text = "Enable Download Data Block extractor"
        Me.CHK_ENBL_DDB.UseVisualStyleBackColor = True
        '
        'TAP_ANALYZE
        '
        Me.TAP_ANALYZE.Controls.Add(Me.TXT_ANALYZE_RESULT)
        Me.TAP_ANALYZE.Controls.Add(Me.TXT_ANALYZE_PACKET_HEADER)
        Me.TAP_ANALYZE.Controls.Add(Me.LBL_ANALYZE_PACKET_HEADER)
        Me.TAP_ANALYZE.Location = New System.Drawing.Point(4, 29)
        Me.TAP_ANALYZE.Name = "TAP_ANALYZE"
        Me.TAP_ANALYZE.Size = New System.Drawing.Size(630, 247)
        Me.TAP_ANALYZE.TabIndex = 9
        Me.TAP_ANALYZE.Text = " ANALYZE "
        Me.TAP_ANALYZE.UseVisualStyleBackColor = True
        '
        'TXT_ANALYZE_RESULT
        '
        Me.TXT_ANALYZE_RESULT.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TXT_ANALYZE_RESULT.Location = New System.Drawing.Point(20, 44)
        Me.TXT_ANALYZE_RESULT.Multiline = True
        Me.TXT_ANALYZE_RESULT.Name = "TXT_ANALYZE_RESULT"
        Me.TXT_ANALYZE_RESULT.ReadOnly = True
        Me.TXT_ANALYZE_RESULT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_ANALYZE_RESULT.Size = New System.Drawing.Size(591, 193)
        Me.TXT_ANALYZE_RESULT.TabIndex = 7911
        '
        'TXT_ANALYZE_PACKET_HEADER
        '
        Me.TXT_ANALYZE_PACKET_HEADER.Location = New System.Drawing.Point(199, 9)
        Me.TXT_ANALYZE_PACKET_HEADER.Name = "TXT_ANALYZE_PACKET_HEADER"
        Me.TXT_ANALYZE_PACKET_HEADER.Size = New System.Drawing.Size(164, 27)
        Me.TXT_ANALYZE_PACKET_HEADER.TabIndex = 7903
        '
        'LBL_ANALYZE_PACKET_HEADER
        '
        Me.LBL_ANALYZE_PACKET_HEADER.AutoSize = True
        Me.LBL_ANALYZE_PACKET_HEADER.Location = New System.Drawing.Point(16, 12)
        Me.LBL_ANALYZE_PACKET_HEADER.Name = "LBL_ANALYZE_PACKET_HEADER"
        Me.LBL_ANALYZE_PACKET_HEADER.Size = New System.Drawing.Size(178, 20)
        Me.LBL_ANALYZE_PACKET_HEADER.TabIndex = 7901
        Me.LBL_ANALYZE_PACKET_HEADER.Text = "TS packet header: 0x47"
        '
        'TAP_ABOUT
        '
        Me.TAP_ABOUT.Controls.Add(Me.LBL_ABOUT_SUMMARY)
        Me.TAP_ABOUT.Controls.Add(Me.LBL_ABOUT_VERSION)
        Me.TAP_ABOUT.Controls.Add(Me.LBL_ABOUT_TITLE)
        Me.TAP_ABOUT.Controls.Add(Me.PIC_ABOUT_BADGE)
        Me.TAP_ABOUT.Location = New System.Drawing.Point(4, 29)
        Me.TAP_ABOUT.Name = "TAP_ABOUT"
        Me.TAP_ABOUT.Size = New System.Drawing.Size(630, 247)
        Me.TAP_ABOUT.TabIndex = 5
        Me.TAP_ABOUT.Text = " ABOUT "
        Me.TAP_ABOUT.UseVisualStyleBackColor = True
        '
        'LBL_ABOUT_SUMMARY
        '
        Me.LBL_ABOUT_SUMMARY.Location = New System.Drawing.Point(133, 74)
        Me.LBL_ABOUT_SUMMARY.Name = "LBL_ABOUT_SUMMARY"
        Me.LBL_ABOUT_SUMMARY.Size = New System.Drawing.Size(481, 173)
        Me.LBL_ABOUT_SUMMARY.TabIndex = 9005
        Me.LBL_ABOUT_SUMMARY.Text = resources.GetString("LBL_ABOUT_SUMMARY.Text")
        '
        'LBL_ABOUT_VERSION
        '
        Me.LBL_ABOUT_VERSION.AutoSize = True
        Me.LBL_ABOUT_VERSION.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LBL_ABOUT_VERSION.Location = New System.Drawing.Point(133, 46)
        Me.LBL_ABOUT_VERSION.Name = "LBL_ABOUT_VERSION"
        Me.LBL_ABOUT_VERSION.Size = New System.Drawing.Size(76, 21)
        Me.LBL_ABOUT_VERSION.TabIndex = 9003
        Me.LBL_ABOUT_VERSION.Text = "Version: "
        '
        'LBL_ABOUT_TITLE
        '
        Me.LBL_ABOUT_TITLE.AutoSize = True
        Me.LBL_ABOUT_TITLE.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_ABOUT_TITLE.Location = New System.Drawing.Point(132, 15)
        Me.LBL_ABOUT_TITLE.Name = "LBL_ABOUT_TITLE"
        Me.LBL_ABOUT_TITLE.Size = New System.Drawing.Size(97, 26)
        Me.LBL_ABOUT_TITLE.TabIndex = 9001
        Me.LBL_ABOUT_TITLE.Text = "TS Finish"
        '
        'PIC_ABOUT_BADGE
        '
        Me.PIC_ABOUT_BADGE.Image = CType(resources.GetObject("PIC_ABOUT_BADGE.Image"), System.Drawing.Image)
        Me.PIC_ABOUT_BADGE.Location = New System.Drawing.Point(16, 18)
        Me.PIC_ABOUT_BADGE.Name = "PIC_ABOUT_BADGE"
        Me.PIC_ABOUT_BADGE.Size = New System.Drawing.Size(100, 100)
        Me.PIC_ABOUT_BADGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_ABOUT_BADGE.TabIndex = 124
        Me.PIC_ABOUT_BADGE.TabStop = False
        '
        'TXT_INPUT_SOURCE_FILE
        '
        Me.TXT_INPUT_SOURCE_FILE.Location = New System.Drawing.Point(115, 37)
        Me.TXT_INPUT_SOURCE_FILE.MaxLength = 1073741824
        Me.TXT_INPUT_SOURCE_FILE.Name = "TXT_INPUT_SOURCE_FILE"
        Me.TXT_INPUT_SOURCE_FILE.ReadOnly = True
        Me.TXT_INPUT_SOURCE_FILE.Size = New System.Drawing.Size(663, 29)
        Me.TXT_INPUT_SOURCE_FILE.TabIndex = 1111
        '
        'BTN_INPUT_BROWSE
        '
        Me.BTN_INPUT_BROWSE.Location = New System.Drawing.Point(782, 37)
        Me.BTN_INPUT_BROWSE.Name = "BTN_INPUT_BROWSE"
        Me.BTN_INPUT_BROWSE.Size = New System.Drawing.Size(35, 30)
        Me.BTN_INPUT_BROWSE.TabIndex = 1113
        Me.BTN_INPUT_BROWSE.Text = "..."
        Me.BTN_INPUT_BROWSE.UseVisualStyleBackColor = True
        '
        'CHK_INPUT_AUTO_SCAN
        '
        Me.CHK_INPUT_AUTO_SCAN.AutoSize = True
        Me.CHK_INPUT_AUTO_SCAN.Checked = True
        Me.CHK_INPUT_AUTO_SCAN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_INPUT_AUTO_SCAN.Location = New System.Drawing.Point(723, 73)
        Me.CHK_INPUT_AUTO_SCAN.Name = "CHK_INPUT_AUTO_SCAN"
        Me.CHK_INPUT_AUTO_SCAN.Size = New System.Drawing.Size(172, 25)
        Me.CHK_INPUT_AUTO_SCAN.TabIndex = 1221
        Me.CHK_INPUT_AUTO_SCAN.Text = "Automatically scan"
        Me.CHK_INPUT_AUTO_SCAN.UseVisualStyleBackColor = True
        '
        'BTN_INPUT_SCAN
        '
        Me.BTN_INPUT_SCAN.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_INPUT_SCAN.Location = New System.Drawing.Point(904, 37)
        Me.BTN_INPUT_SCAN.Name = "BTN_INPUT_SCAN"
        Me.BTN_INPUT_SCAN.Size = New System.Drawing.Size(91, 65)
        Me.BTN_INPUT_SCAN.TabIndex = 1901
        Me.BTN_INPUT_SCAN.Text = "SCAN"
        Me.BTN_INPUT_SCAN.UseVisualStyleBackColor = True
        '
        'LBL_INPUT_READ_SIZE_1
        '
        Me.LBL_INPUT_READ_SIZE_1.AutoSize = True
        Me.LBL_INPUT_READ_SIZE_1.Location = New System.Drawing.Point(12, 74)
        Me.LBL_INPUT_READ_SIZE_1.Name = "LBL_INPUT_READ_SIZE_1"
        Me.LBL_INPUT_READ_SIZE_1.Size = New System.Drawing.Size(87, 21)
        Me.LBL_INPUT_READ_SIZE_1.TabIndex = 1201
        Me.LBL_INPUT_READ_SIZE_1.Text = "Read Size:"
        '
        'NUM_INPUT_READ_SIZE
        '
        Me.NUM_INPUT_READ_SIZE.Increment = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.NUM_INPUT_READ_SIZE.Location = New System.Drawing.Point(115, 71)
        Me.NUM_INPUT_READ_SIZE.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NUM_INPUT_READ_SIZE.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUM_INPUT_READ_SIZE.Name = "NUM_INPUT_READ_SIZE"
        Me.NUM_INPUT_READ_SIZE.Size = New System.Drawing.Size(150, 29)
        Me.NUM_INPUT_READ_SIZE.TabIndex = 1203
        Me.NUM_INPUT_READ_SIZE.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'LBL_INPUT_READ_SIZE_2
        '
        Me.LBL_INPUT_READ_SIZE_2.AutoSize = True
        Me.LBL_INPUT_READ_SIZE_2.Location = New System.Drawing.Point(271, 74)
        Me.LBL_INPUT_READ_SIZE_2.Name = "LBL_INPUT_READ_SIZE_2"
        Me.LBL_INPUT_READ_SIZE_2.Size = New System.Drawing.Size(112, 21)
        Me.LBL_INPUT_READ_SIZE_2.TabIndex = 1205
        Me.LBL_INPUT_READ_SIZE_2.Text = "KB Maximum"
        '
        'LSV_PID
        '
        Me.LSV_PID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LSV_PID.CheckBoxes = True
        Me.LSV_PID.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CLH_PID_ENBL, Me.CLH_PID_DEC, Me.CLH_PID_HEX, Me.CLH_PID_PMT})
        Me.LSV_PID.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSV_PID.FullRowSelect = True
        Me.LSV_PID.HideSelection = False
        Me.LSV_PID.Location = New System.Drawing.Point(13, 142)
        Me.LSV_PID.Name = "LSV_PID"
        Me.LSV_PID.Size = New System.Drawing.Size(338, 280)
        Me.LSV_PID.TabIndex = 2101
        Me.LSV_PID.UseCompatibleStateImageBehavior = False
        Me.LSV_PID.View = System.Windows.Forms.View.Details
        '
        'CLH_PID_ENBL
        '
        Me.CLH_PID_ENBL.Text = ""
        Me.CLH_PID_ENBL.Width = 30
        '
        'CLH_PID_DEC
        '
        Me.CLH_PID_DEC.Text = "PID"
        Me.CLH_PID_DEC.Width = 80
        '
        'CLH_PID_HEX
        '
        Me.CLH_PID_HEX.Text = "PID (Hex)"
        Me.CLH_PID_HEX.Width = 80
        '
        'CLH_PID_PMT
        '
        Me.CLH_PID_PMT.Text = "Stream Type"
        Me.CLH_PID_PMT.Width = 120
        '
        'PGB_OUTPUT_PROGRESS
        '
        Me.PGB_OUTPUT_PROGRESS.Location = New System.Drawing.Point(215, 499)
        Me.PGB_OUTPUT_PROGRESS.MarqueeAnimationSpeed = 10
        Me.PGB_OUTPUT_PROGRESS.Name = "PGB_OUTPUT_PROGRESS"
        Me.PGB_OUTPUT_PROGRESS.Size = New System.Drawing.Size(579, 25)
        Me.PGB_OUTPUT_PROGRESS.TabIndex = 10101
        '
        'LBL_OUTPUT_PROGRESS
        '
        Me.LBL_OUTPUT_PROGRESS.BackColor = System.Drawing.Color.Transparent
        Me.LBL_OUTPUT_PROGRESS.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_OUTPUT_PROGRESS.Location = New System.Drawing.Point(800, 499)
        Me.LBL_OUTPUT_PROGRESS.Name = "LBL_OUTPUT_PROGRESS"
        Me.LBL_OUTPUT_PROGRESS.Size = New System.Drawing.Size(100, 25)
        Me.LBL_OUTPUT_PROGRESS.TabIndex = 10103
        Me.LBL_OUTPUT_PROGRESS.Text = "0/0"
        Me.LBL_OUTPUT_PROGRESS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_OUTPUT_START
        '
        Me.BTN_OUTPUT_START.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_OUTPUT_START.Location = New System.Drawing.Point(905, 462)
        Me.BTN_OUTPUT_START.Name = "BTN_OUTPUT_START"
        Me.BTN_OUTPUT_START.Size = New System.Drawing.Size(91, 62)
        Me.BTN_OUTPUT_START.TabIndex = 10901
        Me.BTN_OUTPUT_START.Text = "START"
        Me.BTN_OUTPUT_START.UseVisualStyleBackColor = True
        '
        'TXT_OUTPUT_DEST_FILE
        '
        Me.TXT_OUTPUT_DEST_FILE.Location = New System.Drawing.Point(147, 462)
        Me.TXT_OUTPUT_DEST_FILE.MaxLength = 1073741824
        Me.TXT_OUTPUT_DEST_FILE.Name = "TXT_OUTPUT_DEST_FILE"
        Me.TXT_OUTPUT_DEST_FILE.Size = New System.Drawing.Size(713, 29)
        Me.TXT_OUTPUT_DEST_FILE.TabIndex = 10003
        '
        'LBL_OUTPUT_DEST_FILE
        '
        Me.LBL_OUTPUT_DEST_FILE.AutoSize = True
        Me.LBL_OUTPUT_DEST_FILE.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_OUTPUT_DEST_FILE.Location = New System.Drawing.Point(12, 465)
        Me.LBL_OUTPUT_DEST_FILE.Name = "LBL_OUTPUT_DEST_FILE"
        Me.LBL_OUTPUT_DEST_FILE.Size = New System.Drawing.Size(129, 21)
        Me.LBL_OUTPUT_DEST_FILE.TabIndex = 10001
        Me.LBL_OUTPUT_DEST_FILE.Text = "Destination file:"
        '
        'BTN_OUTPUT_BROWSE
        '
        Me.BTN_OUTPUT_BROWSE.Location = New System.Drawing.Point(864, 462)
        Me.BTN_OUTPUT_BROWSE.Name = "BTN_OUTPUT_BROWSE"
        Me.BTN_OUTPUT_BROWSE.Size = New System.Drawing.Size(35, 30)
        Me.BTN_OUTPUT_BROWSE.TabIndex = 10005
        Me.BTN_OUTPUT_BROWSE.Text = "..."
        Me.BTN_OUTPUT_BROWSE.UseVisualStyleBackColor = True
        '
        'BTN_INPUT_CONCAT
        '
        Me.BTN_INPUT_CONCAT.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_INPUT_CONCAT.Location = New System.Drawing.Point(821, 37)
        Me.BTN_INPUT_CONCAT.Name = "BTN_INPUT_CONCAT"
        Me.BTN_INPUT_CONCAT.Size = New System.Drawing.Size(78, 30)
        Me.BTN_INPUT_CONCAT.TabIndex = 1121
        Me.BTN_INPUT_CONCAT.Text = "CONCAT"
        Me.BTN_INPUT_CONCAT.UseVisualStyleBackColor = True
        '
        'OFD_INPUT_SOURCE_FILE
        '
        Me.OFD_INPUT_SOURCE_FILE.Filter = "Transport Stream|*.ts;*.m2ts|All Files|*.*"
        '
        'SFD_OUTPUT_DEST_FILE
        '
        Me.SFD_OUTPUT_DEST_FILE.Filter = "Transport Stream|*.ts|All Files|*.*"
        '
        'OFD_INSERT_TS_FILE
        '
        Me.OFD_INSERT_TS_FILE.Filter = "Transport Stream|*.ts|All Files|*.*"
        '
        'BGW_PROCESS
        '
        Me.BGW_PROCESS.WorkerReportsProgress = True
        '
        'LBL_STATUS_STANDBY
        '
        Me.LBL_STATUS_STANDBY.BackColor = System.Drawing.Color.Orange
        Me.LBL_STATUS_STANDBY.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LBL_STATUS_STANDBY.ForeColor = System.Drawing.Color.White
        Me.LBL_STATUS_STANDBY.Location = New System.Drawing.Point(12, 499)
        Me.LBL_STATUS_STANDBY.Name = "LBL_STATUS_STANDBY"
        Me.LBL_STATUS_STANDBY.Size = New System.Drawing.Size(129, 25)
        Me.LBL_STATUS_STANDBY.TabIndex = 10011
        Me.LBL_STATUS_STANDBY.Text = "PROCESSING"
        Me.LBL_STATUS_STANDBY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_STATUS_STANDBY.Visible = False
        '
        'CHK_INPUT_RTP
        '
        Me.CHK_INPUT_RTP.AutoSize = True
        Me.CHK_INPUT_RTP.Location = New System.Drawing.Point(550, 73)
        Me.CHK_INPUT_RTP.Name = "CHK_INPUT_RTP"
        Me.CHK_INPUT_RTP.Size = New System.Drawing.Size(160, 25)
        Me.CHK_INPUT_RTP.TabIndex = 1211
        Me.CHK_INPUT_RTP.Text = "RTP stream input"
        Me.CHK_INPUT_RTP.UseVisualStyleBackColor = True
        '
        'MainUI
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.CHK_INPUT_RTP)
        Me.Controls.Add(Me.LBL_STATUS_STANDBY)
        Me.Controls.Add(Me.BTN_INPUT_CONCAT)
        Me.Controls.Add(Me.BTN_OUTPUT_BROWSE)
        Me.Controls.Add(Me.LBL_OUTPUT_DEST_FILE)
        Me.Controls.Add(Me.TXT_OUTPUT_DEST_FILE)
        Me.Controls.Add(Me.BTN_OUTPUT_START)
        Me.Controls.Add(Me.LBL_OUTPUT_PROGRESS)
        Me.Controls.Add(Me.PGB_OUTPUT_PROGRESS)
        Me.Controls.Add(Me.LSV_PID)
        Me.Controls.Add(Me.NUM_INPUT_READ_SIZE)
        Me.Controls.Add(Me.LBL_INPUT_READ_SIZE_2)
        Me.Controls.Add(Me.LBL_INPUT_READ_SIZE_1)
        Me.Controls.Add(Me.BTN_INPUT_SCAN)
        Me.Controls.Add(Me.CHK_INPUT_AUTO_SCAN)
        Me.Controls.Add(Me.TXT_INPUT_SOURCE_FILE)
        Me.Controls.Add(Me.BTN_INPUT_BROWSE)
        Me.Controls.Add(Me.TAC_PROCESS)
        Me.Controls.Add(Me.LBL_HEADING_OUTPUT)
        Me.Controls.Add(Me.LBL_HEADING_PROCESS)
        Me.Controls.Add(Me.LBL_INPUT_SOURCE_FILE)
        Me.Controls.Add(Me.LBL_HEADING_INPUT)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 576)
        Me.MinimumSize = New System.Drawing.Size(1024, 576)
        Me.Name = "MainUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TS Finish"
        Me.TAC_PROCESS.ResumeLayout(False)
        Me.TAP_GENERAL.ResumeLayout(False)
        Me.TAP_GENERAL.PerformLayout()
        Me.TAP_PID.ResumeLayout(False)
        Me.TAP_PID.PerformLayout()
        Me.TAP_PAT_PMT.ResumeLayout(False)
        Me.TAP_PAT_PMT.PerformLayout()
        CType(Me.NUM_PAT_PMT_PERIOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAP_SDT.ResumeLayout(False)
        Me.TAP_SDT.PerformLayout()
        CType(Me.NUM_SDT_PERIOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAP_CUTTER.ResumeLayout(False)
        Me.TAP_CUTTER.PerformLayout()
        Me.TAP_INSERT.ResumeLayout(False)
        Me.TAP_INSERT.PerformLayout()
        CType(Me.NUM_INSERT_PERIOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAP_DISCARDER.ResumeLayout(False)
        Me.TAP_DISCARDER.PerformLayout()
        CType(Me.NUM_DISCARDER_RANGE_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_DISCARDER_RANGE_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAP_DDB.ResumeLayout(False)
        Me.TAP_DDB.PerformLayout()
        Me.TAP_ANALYZE.ResumeLayout(False)
        Me.TAP_ANALYZE.PerformLayout()
        Me.TAP_ABOUT.ResumeLayout(False)
        Me.TAP_ABOUT.PerformLayout()
        CType(Me.PIC_ABOUT_BADGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_INPUT_READ_SIZE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_HEADING_INPUT As Label
    Friend WithEvents LBL_INPUT_SOURCE_FILE As Label
    Friend WithEvents LBL_HEADING_PROCESS As Label
    Friend WithEvents LBL_HEADING_OUTPUT As Label
    Friend WithEvents TAC_PROCESS As TabControl
    Friend WithEvents TAP_GENERAL As TabPage
    Friend WithEvents TAP_PAT_PMT As TabPage
    Friend WithEvents TXT_INPUT_SOURCE_FILE As TextBox
    Friend WithEvents BTN_INPUT_BROWSE As Button
    Friend WithEvents CHK_INPUT_AUTO_SCAN As CheckBox
    Friend WithEvents BTN_INPUT_SCAN As Button
    Friend WithEvents LBL_INPUT_READ_SIZE_1 As Label
    Friend WithEvents NUM_INPUT_READ_SIZE As NumericUpDown
    Friend WithEvents LBL_INPUT_READ_SIZE_2 As Label
    Public WithEvents LSV_PID As ListView
    Friend WithEvents CLH_PID_ENBL As ColumnHeader
    Friend WithEvents CLH_PID_DEC As ColumnHeader
    Friend WithEvents CLH_PID_HEX As ColumnHeader
    Friend WithEvents CLH_PID_PMT As ColumnHeader
    Friend WithEvents PGB_OUTPUT_PROGRESS As ProgressBar
    Friend WithEvents LBL_OUTPUT_PROGRESS As Label
    Friend WithEvents BTN_OUTPUT_START As Button
    Friend WithEvents TXT_OUTPUT_DEST_FILE As TextBox
    Friend WithEvents LBL_OUTPUT_DEST_FILE As Label
    Friend WithEvents BTN_OUTPUT_BROWSE As Button
    Friend WithEvents TAP_SDT As TabPage
    Friend WithEvents TAP_CUTTER As TabPage
    Friend WithEvents TAP_ABOUT As TabPage
    Friend WithEvents CHK_ENBL_PID_FILTER As CheckBox
    Friend WithEvents CHK_REMARK_SCRAMBL_TAG As CheckBox
    Friend WithEvents CHK_OVERWRI_PACKET_COUNTER As CheckBox
    Friend WithEvents TXT_ADD_PID As TextBox
    Friend WithEvents BTN_ADD_PID As Button
    Friend WithEvents LBL_SUBH_PID_LIST As Label
    Friend WithEvents BTN_PID_MOVE_DOWN As Button
    Friend WithEvents BTN_PID_MOVE_UP As Button
    Friend WithEvents BTN_REMOVE_PID As Button
    Friend WithEvents LBL_SUBH_PACKET_HEADER As Label
    Friend WithEvents LBL_SUBH_PAT As Label
    Friend WithEvents CHK_ENBL_PAT_PMT As CheckBox
    Friend WithEvents TXT_PAT_PMT_TRANSPO_STREAM_ID As TextBox
    Friend WithEvents TXT_PAT_PMT_PROGRAM_NUMBER As TextBox
    Friend WithEvents LBL_PAT_PMT_PROGRAM_NUMBER As Label
    Friend WithEvents LBL_PAT_PMT_TRANSPO_STREAM_ID As Label
    Friend WithEvents LBL_PAT_PMT_PID As Label
    Friend WithEvents TXT_PAT_PMT_PID As TextBox
    Friend WithEvents LBL_SUBH_PMT As Label
    Friend WithEvents LBL_PAT_PMT_STREAM_TYPE As Label
    Friend WithEvents TXT_PAT_PMT_STREAM_TYPE As TextBox
    Friend WithEvents CBO_PAT_PMT_STREAM_TYPE As ComboBox
    Friend WithEvents LBL_PAT_PMT_SELECT_PID_PID As Label
    Friend WithEvents LBL_PAT_PMT_SELECT_PID As Label
    Friend WithEvents PIC_ABOUT_BADGE As PictureBox
    Friend WithEvents LBL_ABOUT_TITLE As Label
    Friend WithEvents LBL_ABOUT_VERSION As Label
    Friend WithEvents LBL_ABOUT_SUMMARY As Label
    Public WithEvents LSV_CUTTER As ListView
    Friend WithEvents CLH_CUTTER_TASK_NAME As ColumnHeader
    Friend WithEvents CLH_CUTTER_START As ColumnHeader
    Friend WithEvents CLH_CUTTER_END As ColumnHeader
    Friend WithEvents TXT_CUTTER_END As TextBox
    Friend WithEvents TXT_CUTTER_START As TextBox
    Friend WithEvents TXT_CUTTER_TASK_NAME As TextBox
    Friend WithEvents BTN_CUTTER_REMOVE As Button
    Friend WithEvents BTN_CUTTER_ADD As Button
    Friend WithEvents LBL_CUTTER_TOTAL_PACKETS As Label
    Friend WithEvents TXT_CUTTER_TOTAL_DURATION As TextBox
    Friend WithEvents LBL_CUTTER_TOTAL_DURATION As Label
    Friend WithEvents LBL_CUTTER_TOTAL_PACKETS_COUNT As Label
    Friend WithEvents BTN_INPUT_CONCAT As Button
    Friend WithEvents CHK_EXTRACT_PAYLOAD As CheckBox
    Friend WithEvents TAP_INSERT As TabPage
    Friend WithEvents LBL_PAT_PMT_PERIOD_1 As Label
    Friend WithEvents NUM_PAT_PMT_PERIOD As NumericUpDown
    Friend WithEvents LBL_PAT_PMT_PERIOD_2 As Label
    Friend WithEvents CHK_ENBL_INSERT As CheckBox
    Friend WithEvents BTN_INSERT_TS_FILE As Button
    Friend WithEvents LBL_INSERT_TS_FILE As Label
    Friend WithEvents TXT_INSERT_TS_FILE As TextBox
    Friend WithEvents LBL_INSERT_PERIOD_2 As Label
    Friend WithEvents LBL_INSERT_PERIOD_1 As Label
    Friend WithEvents NUM_INSERT_PERIOD As NumericUpDown
    Friend WithEvents CHK_ENBL_SDT As CheckBox
    Friend WithEvents LBL_SDT_NETWORK_ID As Label
    Friend WithEvents LBL_SDT_TRANSPO_STREAM_ID As Label
    Friend WithEvents TXT_SDT_NETWORK_ID As TextBox
    Friend WithEvents TXT_SDT_TRANSPO_STREAM_ID As TextBox
    Friend WithEvents LBL_SDT_SERVICE_ID As Label
    Friend WithEvents TXT_SDT_SERVICE_ID As TextBox
    Friend WithEvents LBL_SDT_SERVICE_NAME As Label
    Friend WithEvents TXT_SDT_SERVICE_NAME As TextBox
    Friend WithEvents LBL_SDT_SERVICE_TYPE As Label
    Friend WithEvents TXT_SDT_SERVICE_TYPE As TextBox
    Friend WithEvents LBL_SDT_SERVICE_PROVIDER As Label
    Friend WithEvents TXT_SDT_SERVICE_PROVIDER As TextBox
    Friend WithEvents CBO_SDT_SERVICE_TYPE As ComboBox
    Friend WithEvents LBL_SDT_PERIOD_2 As Label
    Friend WithEvents LBL_SDT_PERIOD_1 As Label
    Friend WithEvents NUM_SDT_PERIOD As NumericUpDown
    Friend WithEvents OFD_INPUT_SOURCE_FILE As OpenFileDialog
    Friend WithEvents SFD_OUTPUT_DEST_FILE As SaveFileDialog
    Friend WithEvents OFD_INSERT_TS_FILE As OpenFileDialog
    Friend WithEvents BGW_PROCESS As System.ComponentModel.BackgroundWorker
    Friend WithEvents LBL_STATUS_STANDBY As Label
    Friend WithEvents CHK_SELECT_ALL_PID As CheckBox
    Friend WithEvents TAP_DISCARDER As TabPage
    Friend WithEvents CHK_ENBL_DISCARDER As CheckBox
    Friend WithEvents NUM_DISCARDER_RANGE_2 As NumericUpDown
    Friend WithEvents LBL_DISCARDER_PERIOD_TO As Label
    Friend WithEvents LBL_DISCARDER_PERIOD_PACKETS As Label
    Friend WithEvents LBL_DISCARDER_PERIOD As Label
    Friend WithEvents NUM_DISCARDER_RANGE_1 As NumericUpDown
    Friend WithEvents CHK_SCRAMBL_SEGMENT As CheckBox
    Friend WithEvents TAP_DDB As TabPage
    Friend WithEvents CHK_ENBL_DDB As CheckBox
    Friend WithEvents LBL_DDB_MODULE_ID As Label
    Friend WithEvents TXT_DDB_MODULE_ID As TextBox
    Friend WithEvents LBL_DDB_DOWNLOAD_ID As Label
    Friend WithEvents TXT_DDB_DOWNLOAD_ID As TextBox
    Friend WithEvents CHK_DDB_SPLIT As CheckBox
    Friend WithEvents TAP_ANALYZE As TabPage
    Friend WithEvents TXT_ANALYZE_PACKET_HEADER As TextBox
    Friend WithEvents LBL_ANALYZE_PACKET_HEADER As Label
    Friend WithEvents TXT_ANALYZE_RESULT As TextBox
    Friend WithEvents CBO_REMARK_SCRABMBL_TAG As ComboBox
    Friend WithEvents TAP_PID As TabPage
    Friend WithEvents CHK_INPUT_RTP As CheckBox
    Friend WithEvents BTN_PID_REWRITE_REMOVE As Button
    Friend WithEvents BTN_PID_REWRITE_ADD As Button
    Friend WithEvents TXT_PID_ORIGINAL As TextBox
    Public WithEvents LSV_PID_REWRITE As ListView
    Friend WithEvents CLH_PID_ORIGINAL As ColumnHeader
    Friend WithEvents CLH_PID_OVERWRITE As ColumnHeader
    Friend WithEvents TXT_PID_OVERWRITE As TextBox
    Friend WithEvents CBO_PAT_PMT_STREAM_TYPE_DEFINIT As ComboBox
End Class
