Imports System.ComponentModel
Imports System.IO
Imports System.Media
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions

Public Class MainUI

    Dim BTN_OUTPUT_STATUS_START As String = "START"
    Dim BTN_OUTPUT_STATUS_STOP As String = "STOP"
    ReadOnly BYTE_ONE As Byte() = New Byte() {&HFF}
    ReadOnly BYTE_ZERO As Byte() = New Byte() {&H0}
    Dim CUTTER_ENBL As Boolean = False
    Dim CUTTER_EXPR_TOTAL_DURATION As Long = 0
    Dim CUTTER_FROM As Long = 0
    Dim CUTTER_TO As Long = 0
    Dim DISCARDER_ENBL As Boolean = False
    Dim DISCARDER_PERIOD_FROM As Integer = 0
    Dim DISCARDER_PERIOD_TO As Integer = 0
    Dim DISCARDER_NEXT As Long = 0
    ReadOnly EMPTY_BYTE As Byte() = New Byte() {}
    Public GLOBAL_LANGUAGE As String = ""
    Dim INSERT_BYTE_PAT_PMT As Byte() = New Byte() {}
    Dim INSERT_BYTE_SDT As Byte() = New Byte() {}
    Dim INSERT_BYTE_USER As Byte() = New Byte() {}
    Dim INSERT_CODEC_PAT_PMT As String = ""
    Dim INSERT_COUNT_PAT_PMT As Integer = 0
    Dim INSERT_COUNT_SDT As Integer = 0
    Dim INSERT_COUNT_USER As Integer = 0
    Dim INSERT_ENBL_PAT_PMT As Boolean = False
    Dim INSERT_ENBL_SDT As Boolean = False
    Dim INSERT_ENBL_USER As Boolean = False
    Dim INSERT_PERIOD_PAT_PMT As Integer = 0
    Dim INSERT_PERIOD_SDT As Integer = 0
    Dim INSERT_PERIOD_USER As Integer = 0
    Dim INPUT_RTP As Boolean = False
    Public INPUT_SOURCE As New List(Of String)()
    Dim LSV_PID_IN_HANDLE As Boolean = False
    ReadOnly MAX_PID_NUMBER As Integer = 32
    ReadOnly MAX_TEXT_BIN_LENGTH As Integer = 64 * 8
    Dim MULTILNG_CHINESE As Boolean = False
    Dim OUTPUT_SOURCE As String = ""
    Dim OUTPUT_SOURCE_PREFIX As String = ""
    Dim PID_REWRITE As String = ""
    Dim PROCESSOR_ACTION As String = ""
    Dim PROCESSOR_CURRENT As Integer = 0
    Dim PROCESSOR_CANCEL As Boolean = False
    Dim PROCESSOR_MESSAGE_ERROR As String = ""
    Dim PROCESSOR_MESSAGE_OK As String = ""
    Dim PROCESSOR_REPORTER_COUNT As Integer = -1
    Dim PROCESSOR_RESULT_OK As Boolean = False
    ReadOnly PROCESSOR_STOPWATCH As New Stopwatch
    Dim PROCESSOR_STOPWATCH_PROGRESS As Integer = -1
    Dim PROCESSOR_TOTAL As Integer = 0
    Dim SCRAMBL_SEGMENT_COUNT As Integer = 0
    Dim SCRAMBL_SEGMENT_EVEN As Boolean = True
    Dim STREAM_READ As IO.FileStream = Nothing
    Dim STREAM_READ_CURRENT_LENGTH As Long = 0
    Dim STREAM_READ_CURRENT_M2TS As Boolean = False
    Dim STREAM_READ_CURRENT_OFFSET As Long = 0
    Dim STREAM_READ_EOF As Boolean = False
    Dim STREAM_READ_INDEX As Long = 0
    Dim STREAM_READ_INSERT As Boolean = False
    Dim STREAM_READ_INIT As Boolean = True
    Dim STREAM_READ_PACKET_COUNT As Long = 0
    Dim STREAM_READ_TOTAL_LENGTH As Long = 0
    Dim STREAM_READ_TOTAL_OFFSET As Long = 0
    Dim STREAM_READ_TOTAL_PACKET_COUNT As Long = 0
    Dim STREAM_READER As IO.BinaryReader = Nothing
    Dim STREAM_WRITE As IO.FileStream = Nothing
    Dim STREAM_WRITE_INIT As Boolean = True
    Dim STREAM_WRITE_PACKET_COUNT As Long = 0
    Dim STREAM_WRITE_PACKET_COUNT_TEMP As Long = 0
    Dim STREAM_WRITE_PID As String = ""
    Dim STREAM_WRITE_PID_COUNTE As String = ""
    Dim STREAM_WRITE_SKIP_HEADER As Boolean = False
    Dim STREAM_WRITER As IO.BinaryWriter = Nothing
    Dim TS_PACKET_HEADER_SCRAMBL_BIT_1 As Integer = 0
    Dim TS_PACKET_HEADER_SCRAMBL_BIT_2 As Integer = 0
    Public TS_PACKET_HEADER_SCRAMBL_PID_LIST As New List(Of String)
    ReadOnly TS_PACKET_HEADER_SIZE As Integer = 4
    ReadOnly TS_PACKET_HEADER_SYNC_BYTE As Byte() = New Byte() {&H47}
    ReadOnly TS_PACKET_SIZE As Integer = 188

    Dim TXT_SYNC_IN_HANDLE As Boolean = False
    ReadOnly VERSION_STRING As String() = Application.ProductVersion.ToString.Split(".")

    <DllImport("kernel32.dll")>
    Private Shared Function GetSystemDefaultLangID() As UInt16
    End Function

    Public Shared ReadOnly Property SYSTEM_LANG_ID() As UInt16
        Get
            Return GetSystemDefaultLangID()
        End Get
    End Property

    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _LOC_1 As String = SYSTEM_LANG_ID()
            If _LOC_1 = 2052 Or _LOC_1 = 1028 Or _LOC_1 = 3076 Then
                GLOBAL_LANGUAGE = "zh-CN"
            End If
            Localization()

            LBL_ABOUT_VERSION.Text += VERSION_STRING(0) & "." & VERSION_STRING(1) & "." & VERSION_STRING(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            e.Cancel = 1
            If BGW_PROCESS.IsBusy Then
                If MsgBox("There are tasks in progress. Are you sure to end the tasks and exit the program?", vbQuestion + vbYesNo, "Quit") = vbNo Then
                    Exit Sub
                End If
            End If
            Dispose()
            End
        Catch ex As Exception
            Dispose()
            End
        End Try
    End Sub

    Private Sub Localization()
        Try
            If GLOBAL_LANGUAGE = "zh-CN" Then
                LBL_HEADING_INPUT.Text = "输入"
                LBL_INPUT_SOURCE_FILE.Text = "输入文件："
                LBL_INPUT_READ_SIZE_1.Text = "扫描大小："
                LBL_INPUT_READ_SIZE_2.Text = "KB 上限"
                CHK_INPUT_RTP.Text = "输入 RTP 流"
                CHK_INPUT_AUTO_SCAN.Text = "自动扫描"
                BTN_INPUT_SCAN.Text = "扫描"
                BTN_INPUT_CONCAT.Text = "合并文件"

                LBL_HEADING_PROCESS.Text = "加工"
                CLH_PID_PMT.Text = "流类型"
                TAP_GENERAL.Text = " 常规 "
                LBL_SUBH_PID_LIST.Text = "[ PID 列表 ]"
                LBL_SUBH_PACKET_HEADER.Text = "[ 数据包头 ]"
                CHK_SELECT_ALL_PID.Text = "选择所有 PID"
                BTN_ADD_PID.Text = "添加 PID (&A)"
                BTN_REMOVE_PID.Text = "移除 PID (&R)"
                BTN_PID_MOVE_UP.Text = "向上移动 (&U)"
                BTN_PID_MOVE_DOWN.Text = "向下移动 (&D)"
                CHK_ENBL_PID_FILTER.Text = "使能 PID 过滤器"
                CHK_REMARK_SCRAMBL_TAG.Text = "重写加扰标记为"
                CHK_SCRAMBL_SEGMENT.Text = "基于加扰标记分割输出文件"
                CHK_OVERWRI_PACKET_COUNTER.Text = "重写包计数器"
                CHK_EXTRACT_PAYLOAD.Text = "仅提取有效载荷"

                CLH_PID_ORIGINAL.Text = "原始 PID"
                CLH_PID_OVERWRITE.Text = "重写 PID"

                CHK_ENBL_PAT_PMT.Text = "重建 PAT 和 PMT 表"
                LBL_SUBH_PAT.Text = "[ 节目关联表 (PAT) ]"
                LBL_PAT_PMT_PERIOD_1.Text = "插入周期： 每"
                LBL_PAT_PMT_PERIOD_2.Text = "包"
                LBL_PAT_PMT_TRANSPO_STREAM_ID.Text = "TS 流 ID："
                LBL_PAT_PMT_PROGRAM_NUMBER.Text = "节目号："
                LBL_SUBH_PMT.Text = "[ 节目映射表 (PMT) ]"
                LBL_PAT_PMT_SELECT_PID.Text = "已选择 PID："
                LBL_PAT_PMT_STREAM_TYPE.Text = "流类型："
                CBO_PAT_PMT_STREAM_TYPE.Text = "请选择..."
                CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Text = "音频编码定义"

                CHK_ENBL_SDT.Text = "重建 SDT 表"
                LBL_SDT_PERIOD_1.Text = "插入周期： 每"
                LBL_SDT_PERIOD_2.Text = "包"
                LBL_SDT_TRANSPO_STREAM_ID.Text = "TS 流 ID："
                LBL_SDT_NETWORK_ID.Text = "网络 ID："
                LBL_SDT_SERVICE_ID.Text = "服务 ID："
                LBL_SDT_SERVICE_NAME.Text = "服务名："
                LBL_SDT_SERVICE_PROVIDER.Text = "服务提供商："
                LBL_SDT_SERVICE_TYPE.Text = "服务类型："
                CBO_SDT_SERVICE_TYPE.Text = "请选择..."

                TAP_CUTTER.Text = " 截取 "
                CLH_CUTTER_TASK_NAME.Text = "任务名"
                CLH_CUTTER_START.Text = "起始点"
                CLH_CUTTER_END.Text = "结束点"
                LBL_CUTTER_TOTAL_PACKETS.Text = "包数量："
                LBL_CUTTER_TOTAL_DURATION.Text = "总时长："

                TAP_INSERT.Text = " 插入 "
                CHK_ENBL_INSERT.Text = "循环插入以下 TS 包"
                LBL_INSERT_TS_FILE.Text = "TS 文件："
                LBL_INSERT_PERIOD_1.Text = "插入周期： 每"
                LBL_INSERT_PERIOD_2.Text = "包"

                TAP_DISCARDER.Text = " 丢弃 "
                CHK_ENBL_DISCARDER.Text = "随机丢弃数据包"
                LBL_DISCARDER_PERIOD.Text = "丢弃周期： 每"
                LBL_DISCARDER_PERIOD_PACKETS.Text = "包"

                CHK_ENBL_DDB.Text = "使能 Download Data Block 提取器"
                CHK_DDB_SPLIT.Text = "按块分割输出文件"

                TAP_ANALYZE.Text = " 分析 "
                LBL_ANALYZE_PACKET_HEADER.Text = "TS包头部数据： 0x47"

                TAP_ABOUT.Text = " 关于 "
                LBL_ABOUT_VERSION.Text = "版本："
                LBL_ABOUT_SUMMARY.Text = "TS Finish是一款功能强大的MPEG-TS数据包处理工具。它能够在不更改原始数据包有效负载的情况下修改MPEG-2传输流。它能够根据用户需要添加，修改和提取MPEG-TS数据包。用户可以使用TS Finish重建PAT，PMT和SDT表，或变更特定的PID值。用户可以选择从流中随机丢弃数据包或对数据包进行剪辑。TS Finish为用户提供了编辑MPEG-TS底层数据的便利。"

                LBL_HEADING_OUTPUT.Text = "输出"
                LBL_OUTPUT_DEST_FILE.Text = "目标文件："
                BTN_OUTPUT_STATUS_START = "开始"
                BTN_OUTPUT_START.Text = BTN_OUTPUT_STATUS_START
                BTN_OUTPUT_STATUS_STOP = "停止"
                LBL_STATUS_STANDBY.Text = "处理中"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_INPUT_BROWSE_Click(sender As Object, e As EventArgs) Handles BTN_INPUT_BROWSE.Click
        Try
            If OFD_INPUT_SOURCE_FILE.ShowDialog = DialogResult.OK Then
                TXT_INPUT_SOURCE_FILE.Text = OFD_INPUT_SOURCE_FILE.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_OUTPUT_BROWSE_Click(sender As Object, e As EventArgs) Handles BTN_OUTPUT_BROWSE.Click
        Try
            If SFD_OUTPUT_DEST_FILE.ShowDialog = DialogResult.OK Then
                TXT_OUTPUT_DEST_FILE.Text = SFD_OUTPUT_DEST_FILE.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_INSERT_TS_FILE_Click(sender As Object, e As EventArgs) Handles BTN_INSERT_TS_FILE.Click
        Try
            If OFD_INSERT_TS_FILE.ShowDialog = DialogResult.OK Then
                TXT_INSERT_TS_FILE.Text = OFD_INSERT_TS_FILE.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Try
            Dim DragFilePath As String() = e.Data.GetData(DataFormats.FileDrop)
            If My.Computer.FileSystem.FileExists(DragFilePath(0)) Then
                TXT_INPUT_SOURCE_FILE.Text = DragFilePath(0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_INPUT_SCAN_Click(sender As Object, e As EventArgs) Handles BTN_INPUT_SCAN.Click
        Try
            INPUT_SCAN()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub INPUT_SCAN()
        Try
            If Not BGW_PROCESS.IsBusy Then
                LSV_PID.Items.Clear()
                PROCESSOR_ACTION = "GET_PID"
                STATUS_RESET()
                BGW_PROCESS.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BGW_PROCESS_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_PROCESS.DoWork
        Try
            InvokeControl(LBL_STATUS_STANDBY, Sub(x) x.Visible = True)
            Dim BGW_PROCESS_CONTROL As BackgroundWorker = TryCast(sender, BackgroundWorker)

            If Not PROCESSOR_ACTION = "" Then
                Dim DDB_SPLIT As Boolean = CHK_DDB_SPLIT.Checked
                Dim ENBL_DDB As Boolean = CHK_ENBL_DDB.Checked
                Dim ENBL_PID_FILTER As Boolean = CHK_ENBL_PID_FILTER.Checked
                INPUT_RTP = CHK_INPUT_RTP.Checked
                Dim TS_PACKET_HEADER_COUNTE As Boolean = CHK_OVERWRI_PACKET_COUNTER.Checked
                Dim TS_PACKET_HEADER_SCRAMBL_REMARK As Boolean = CHK_REMARK_SCRAMBL_TAG.Checked
                Dim TS_PACKET_HEADER_SCRAMBL_SEGMENT As Boolean = CHK_SCRAMBL_SEGMENT.Checked

                If ENBL_DDB Then STREAM_WRITE_SKIP_HEADER = True
                Dim DDB_BUFFER As Integer = -1
                Dim DDB_DOWNLOAD_ID As Byte() = BinToBytes(ID_BIN(TXT_DDB_DOWNLOAD_ID.Text, 32))
                Dim DDB_MODULE_ID As Byte() = BinToBytes(ID_BIN(TXT_DDB_MODULE_ID.Text, 16))

                Do
                    If PROCESSOR_CANCEL Then Exit Sub

                    Dim PACKET_DATA As Byte() = GET_PACKET()

                    If PACKET_DATA.Length = TS_PACKET_SIZE Then
                        Dim PACKET_HANDLE As Boolean = True

                        If DISCARDER_ENBL And PROCESSOR_ACTION = "WRITE_COMMON" Then
                            If STREAM_READ_TOTAL_OFFSET < DISCARDER_NEXT Then
                                PACKET_HANDLE = True
                            ElseIf STREAM_READ_TOTAL_OFFSET > DISCARDER_NEXT Then
                                Randomize()
                                Dim _LOC_11 As New System.Random()
                                DISCARDER_NEXT = STREAM_READ_TOTAL_OFFSET + (Int(_LOC_11.Next(DISCARDER_PERIOD_FROM, DISCARDER_PERIOD_TO)) * TS_PACKET_SIZE)
                            ElseIf STREAM_READ_TOTAL_OFFSET = DISCARDER_NEXT Then
                                PACKET_HANDLE = False
                            End If
                        End If

                        If PACKET_HANDLE Then
                            Dim PACKET_HEADER As Byte() = New Byte() {PACKET_DATA(0), PACKET_DATA(1), PACKET_DATA(2), PACKET_DATA(3)}
                            Dim PACKET_HEADER_BIT As New BitArray(PACKET_HEADER)
                            Dim PACKET_PID As Integer = (PACKET_HEADER(1) And &H1F) << 8 Or PACKET_HEADER(2)

                            If PROCESSOR_ACTION = "GET_PID" Then
                                Dim PID_EXIST As Boolean = False
                                Dim _LOC_1 As Integer = LSV_PID.Items.Count

                                For _LOC_2 = 0 To _LOC_1 - 1
                                    Dim _LOC_3 As Integer = _LOC_2
                                    If Invoke(New Func(Of String)(Function() LSV_PID.Items(_LOC_3).SubItems(1).Text)) = PACKET_PID Then
                                        PID_EXIST = True
                                        Exit For
                                    End If
                                Next

                                If Not PID_EXIST Then
                                    InvokeControl(LSV_PID, Sub(x) x.Items.Add(""))
                                    InvokeControl(LSV_PID, Sub(x) x.Items(_LOC_1).SubItems.Add(PACKET_PID))
                                    InvokeControl(LSV_PID, Sub(x) x.Items(_LOC_1).SubItems.Add("0x" & Hex(PACKET_PID)))
                                    InvokeControl(LSV_PID, Sub(x) x.Items(_LOC_1).SubItems.Add(""))
                                End If

                                If (STREAM_READ_TOTAL_OFFSET >= NUM_INPUT_READ_SIZE.Value * 1024) Or STREAM_READ_EOF Then
                                    STREAM_READ_TOTAL_PACKET_COUNT = STREAM_READ_TOTAL_LENGTH / TS_PACKET_SIZE
                                    InvokeControl(LBL_CUTTER_TOTAL_PACKETS_COUNT, Sub(x) x.Text = STREAM_READ_TOTAL_PACKET_COUNT)
                                    Exit Sub
                                End If
                            End If

                            If PROCESSOR_ACTION = "WRITE_COMMON" Then
                                Dim WRITE_PACKET_DO As Boolean = False
                                If STREAM_READ_INSERT Or ((ENBL_PID_FILTER = False Or STREAM_WRITE_PID.Contains("<" & PACKET_PID & ">")) And (Not (INSERT_ENBL_PAT_PMT And PACKET_PID = 0)) And (Not (INSERT_ENBL_SDT And PACKET_PID = 17))) Then
                                    If ENBL_DDB Then
                                        Dim DDB_WRITE_OFFSET As Integer = 0
                                        If DDB_BUFFER <= 0 Then
                                            Dim _LOC_20 As Integer = 1
                                            If PACKET_HEADER_BIT(14) Then _LOC_20 = 0

                                            If PACKET_DATA(5 - _LOC_20) = &H3C And PACKET_DATA(13 - _LOC_20) = &H11 And PACKET_DATA(14 - _LOC_20) = &H3 And (PACKET_DATA(17 - _LOC_20) = DDB_DOWNLOAD_ID(0) And PACKET_DATA(18 - _LOC_20) = DDB_DOWNLOAD_ID(1) And PACKET_DATA(19 - _LOC_20) = DDB_DOWNLOAD_ID(2) And PACKET_DATA(20 - _LOC_20) = DDB_DOWNLOAD_ID(3)) Then
                                                Dim _LOC_17 As Byte() = New Byte(0) {PACKET_DATA(22 - _LOC_20)}
                                                Dim DDB_ADAPTION_LENGTH As Integer = Convert.ToInt32(BytesToHex(_LOC_17), 16)
                                                _LOC_17 = New Byte(1) {PACKET_DATA(23 - _LOC_20), PACKET_DATA(24 - _LOC_20)}
                                                Dim DDB_MESSAGE_LENGTH As Integer = Convert.ToInt32(BytesToHex(_LOC_17), 16)
                                                _LOC_17 = New Byte(1) {PACKET_DATA(25 - _LOC_20 + DDB_ADAPTION_LENGTH), PACKET_DATA(26 - _LOC_20 + DDB_ADAPTION_LENGTH)}
                                                Dim DDB_MODULE_ID_INT As Integer = Convert.ToInt32(BytesToHex(_LOC_17), 16)
                                                Dim _LOC_18 As Byte() = New Byte(1) {PACKET_DATA(29 - _LOC_20 + DDB_ADAPTION_LENGTH), PACKET_DATA(30 - _LOC_20 + DDB_ADAPTION_LENGTH)}
                                                Dim DDB_BLOCK_NUMBER As Integer = Convert.ToInt32(BytesToHex(_LOC_18), 16)

                                                If DDB_MODULE_ID(0) = _LOC_17(0) And DDB_MODULE_ID(1) = _LOC_17(1) Then
                                                    WRITE_PACKET_DO = True
                                                    DDB_WRITE_OFFSET = 31 - _LOC_20 - TS_PACKET_HEADER_SIZE + DDB_ADAPTION_LENGTH
                                                    DDB_BUFFER = DDB_MESSAGE_LENGTH - DDB_ADAPTION_LENGTH - 6

                                                    Dim _LOC_19 As String = DDB_BLOCK_NUMBER
                                                    If DDB_SPLIT = False Then
                                                        STREAM_WRITE_CLOSE()
                                                        If My.Computer.FileSystem.FileExists(OUTPUT_SOURCE) Then My.Computer.FileSystem.WriteAllBytes(IO.Path.GetDirectoryName(OUTPUT_SOURCE) & "\" & IO.Path.GetFileNameWithoutExtension(OUTPUT_SOURCE), My.Computer.FileSystem.ReadAllBytes(OUTPUT_SOURCE), True)
                                                        If DDB_BLOCK_NUMBER = 0 Or Not My.Computer.FileSystem.FileExists(OUTPUT_SOURCE) Then
                                                            _LOC_19 = DateTime.Now.ToString("hhmmss") & "_" & (New Random).Next(1000, 10000)
                                                            If My.Computer.FileSystem.FileExists(OUTPUT_SOURCE) Then My.Computer.FileSystem.DeleteFile(OUTPUT_SOURCE)
                                                            OUTPUT_SOURCE = FILE_NAME_INSERT(OUTPUT_SOURCE_PREFIX, _LOC_19) & ".tmp"
                                                        End If
                                                    Else
                                                        STREAM_WRITE_CLOSE()
                                                        If My.Computer.FileSystem.FileExists(OUTPUT_SOURCE) Then My.Computer.FileSystem.RenameFile(OUTPUT_SOURCE, IO.Path.GetFileNameWithoutExtension(OUTPUT_SOURCE))
                                                        If _LOC_19.Length < 5 Then
                                                            For _LOC_16 = 0 To 4 - _LOC_19.Length
                                                                _LOC_19 = "0" & _LOC_19
                                                            Next
                                                        End If
                                                        OUTPUT_SOURCE = FILE_NAME_INSERT(OUTPUT_SOURCE_PREFIX, _LOC_19) & ".tmp"
                                                    End If
                                                End If
                                            End If
                                        Else
                                            WRITE_PACKET_DO = True
                                        End If

                                        If WRITE_PACKET_DO Then
                                            Dim DDB_WRITE_REDUCE As Integer = 0
                                            If DDB_BUFFER < TS_PACKET_SIZE - TS_PACKET_HEADER_SIZE Then
                                                DDB_WRITE_REDUCE = TS_PACKET_SIZE - TS_PACKET_HEADER_SIZE - DDB_BUFFER
                                            End If
                                            Dim DDB_WRITE_BUFFER As Byte() = New Byte(TS_PACKET_SIZE - TS_PACKET_HEADER_SIZE - DDB_WRITE_OFFSET - DDB_WRITE_REDUCE - 1) {}
                                            Array.Copy(PACKET_DATA, TS_PACKET_HEADER_SIZE + DDB_WRITE_OFFSET, DDB_WRITE_BUFFER, 0, DDB_WRITE_BUFFER.Length)
                                            DDB_BUFFER -= DDB_WRITE_BUFFER.Length
                                            WRITE_PACKET(PACKET_HEADER, DDB_WRITE_BUFFER, False)
                                            WRITE_PACKET_DO = False
                                        End If
                                    Else
                                        If PACKET_HEADER_BIT(31) And TS_PACKET_HEADER_SCRAMBL_SEGMENT Then
                                            Dim _LOC_21 As String = ""
                                            If Not PACKET_HEADER_BIT(30) Then
                                                'EVEN CW
                                                If Not SCRAMBL_SEGMENT_EVEN Or STREAM_WRITE_INIT Then
                                                    SCRAMBL_SEGMENT_EVEN = True
                                                    _LOC_21 += "_E"
                                                End If
                                            Else
                                                'ODD CW
                                                If SCRAMBL_SEGMENT_EVEN Or STREAM_WRITE_INIT Then
                                                    SCRAMBL_SEGMENT_EVEN = False
                                                    _LOC_21 += "_O"
                                                End If
                                            End If

                                            If Not _LOC_21 = "" Then
                                                STREAM_WRITE_CLOSE()
                                                STREAM_WRITE_INIT = True
                                                SCRAMBL_SEGMENT_COUNT += 1
                                                _LOC_21 = SCRAMBL_SEGMENT_COUNT & _LOC_21
                                                If SCRAMBL_SEGMENT_COUNT.ToString.Length < 4 Then
                                                    For _LOC_22 = 0 To 3 - SCRAMBL_SEGMENT_COUNT.ToString.Length
                                                        _LOC_21 = "0" & _LOC_21
                                                    Next
                                                End If
                                                OUTPUT_SOURCE = FILE_NAME_INSERT(OUTPUT_SOURCE_PREFIX, _LOC_21)
                                            End If
                                        End If

                                        If TS_PACKET_HEADER_SCRAMBL_REMARK Then
                                            If TS_PACKET_HEADER_SCRAMBL_PID_LIST.Contains(PACKET_PID) Then
                                                PACKET_HEADER_BIT(31) = TS_PACKET_HEADER_SCRAMBL_BIT_1
                                                PACKET_HEADER_BIT(30) = TS_PACKET_HEADER_SCRAMBL_BIT_2
                                            Else
                                                PACKET_HEADER_BIT(31) = 0
                                                PACKET_HEADER_BIT(30) = 0
                                            End If
                                        End If

                                        If STREAM_READ_INSERT Or TS_PACKET_HEADER_COUNTE Then
                                            Dim _LOC_4 As String = Regex.Match(STREAM_WRITE_PID_COUNTE, "\<" & PACKET_PID & "\|(\d+)\>", RegexOptions.None).Groups(1).Value
                                            Dim _LOC_6 As Integer = 0
                                            If IsNumeric(_LOC_4) Then
                                                Dim _LOC_5 As Integer = Int(_LOC_4)
                                                If PACKET_HEADER_BIT(28) Then
                                                    If _LOC_5 < 15 Then
                                                        _LOC_5 += 1
                                                    Else
                                                        _LOC_5 = 0
                                                    End If
                                                End If
                                                _LOC_6 = _LOC_5
                                                STREAM_WRITE_PID_COUNTE = STREAM_WRITE_PID_COUNTE.Replace("<" & PACKET_PID & "|" & _LOC_4 & ">", "<" & PACKET_PID & "|" & _LOC_5 & ">")
                                            Else
                                                STREAM_WRITE_PID_COUNTE += "<" & PACKET_PID & "|0>"
                                            End If

                                            Dim _LOC_7 As New BitArray(New Byte() {_LOC_6})
                                            PACKET_HEADER_BIT(24) = _LOC_7(0)
                                            PACKET_HEADER_BIT(25) = _LOC_7(1)
                                            PACKET_HEADER_BIT(26) = _LOC_7(2)
                                            PACKET_HEADER_BIT(27) = _LOC_7(3)
                                        End If

                                        If PID_REWRITE.Length > 0 Then
                                            Dim _LOC_8 As Integer = GetOverwritePID(PACKET_PID)
                                            If Not PACKET_PID = _LOC_8 Then
                                                Dim _LOC_9 As New BitArray(New Integer() {_LOC_8})
                                                PACKET_HEADER_BIT(12) = _LOC_9(12)
                                                PACKET_HEADER_BIT(11) = _LOC_9(11)
                                                PACKET_HEADER_BIT(10) = _LOC_9(10)
                                                PACKET_HEADER_BIT(9) = _LOC_9(9)
                                                PACKET_HEADER_BIT(8) = _LOC_9(8)
                                                PACKET_HEADER_BIT(23) = _LOC_9(7)
                                                PACKET_HEADER_BIT(22) = _LOC_9(6)
                                                PACKET_HEADER_BIT(21) = _LOC_9(5)
                                                PACKET_HEADER_BIT(20) = _LOC_9(4)
                                                PACKET_HEADER_BIT(19) = _LOC_9(3)
                                                PACKET_HEADER_BIT(18) = _LOC_9(2)
                                                PACKET_HEADER_BIT(17) = _LOC_9(1)
                                                PACKET_HEADER_BIT(16) = _LOC_9(0)
                                            End If
                                        End If

                                        WRITE_PACKET_DO = True
                                    End If
                                End If

                                If PACKET_HEADER_BIT.Length = 32 And WRITE_PACKET_DO Then
                                    Dim PACKET_PAYLOAD As Byte() = New Byte(TS_PACKET_SIZE - TS_PACKET_HEADER_SIZE - 1) {}
                                    Array.Copy(PACKET_DATA, TS_PACKET_HEADER_SIZE, PACKET_PAYLOAD, 0, TS_PACKET_SIZE - TS_PACKET_HEADER_SIZE)
                                    Dim WRITE_HEADER As Byte() = New Byte(3) {}
                                    PACKET_HEADER_BIT.CopyTo(WRITE_HEADER, 0)
                                    WRITE_PACKET(WRITE_HEADER, PACKET_PAYLOAD)
                                End If

                                Try
                                    If Not PROCESSOR_REPORTER_COUNT = Date.Now.Second() Then
                                        PROCESSOR_REPORTER_COUNT = Date.Now.Second()
                                        If CUTTER_ENBL Then
                                            BGW_PROCESS_CONTROL.ReportProgress(Int(Convert.ToInt64(STREAM_READ_PACKET_COUNT) / (Convert.ToInt64(CUTTER_TO - CUTTER_FROM) / TS_PACKET_SIZE) * 100))
                                        Else
                                            BGW_PROCESS_CONTROL.ReportProgress(Int(STREAM_READ_TOTAL_OFFSET / STREAM_READ_TOTAL_LENGTH * 100))
                                        End If
                                    End If
                                Catch ex As Exception

                                End Try
                            End If
                        End If
                    End If
                Loop Until STREAM_READ_EOF

                Try
                    If ENBL_DDB And My.Computer.FileSystem.FileExists(OUTPUT_SOURCE) Then My.Computer.FileSystem.DeleteFile(OUTPUT_SOURCE)
                Catch ex As Exception

                End Try

                PROCESSOR_RESULT_OK = True
            End If
        Catch ex As Exception
            PROCESSOR_MESSAGE_ERROR = ex.ToString
            PROCESSOR_RESULT_OK = False
            STREAM_READ_CLOSE()
            STREAM_WRITE_CLOSE()
        End Try
    End Sub

    Private Sub BGW_PROCESS_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BGW_PROCESS.ProgressChanged
        Try
            If e.ProgressPercentage > PROCESSOR_STOPWATCH_PROGRESS Then
                PGB_OUTPUT_PROGRESS.Value = e.ProgressPercentage
                PROCESSOR_STOPWATCH_PROGRESS = e.ProgressPercentage
                Text = e.ProgressPercentage & "% - " & System.IO.Path.GetFileName(OUTPUT_SOURCE)

                If PROCESSOR_STOPWATCH.IsRunning Then
                    Dim _LOC_1 As TimeSpan = TimeSpan.FromTicks(PROCESSOR_STOPWATCH.Elapsed.Ticks * (100 - e.ProgressPercentage))
                    If Not PROCESSOR_STOPWATCH_PROGRESS >= 100 And _LOC_1.Days < 1 Then Text += "  (" & String.Format("{0}h {1}m {2}s", _LOC_1.Hours, _LOC_1.Minutes, _LOC_1.Seconds) & ")"
                End If
                PROCESSOR_STOPWATCH.Reset()
                PROCESSOR_STOPWATCH.Start()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BGW_PROCESS_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW_PROCESS.RunWorkerCompleted
        Try
            PROCESSOR_STOPWATCH.Stop()
            PROCESSOR_STOPWATCH.Reset()
        Catch ex As Exception

        End Try

        Try
            InvokeControl(LBL_STATUS_STANDBY, Sub(x) x.Visible = False)
            STREAM_READ_CLOSE()
            STREAM_WRITE_CLOSE()
            PROCESSOR_CONTROL("PROCESSOR_COMPLETE")
        Catch ex As Exception

        End Try
    End Sub

    Private Function GET_PACKET() As Byte()
        Try
            If PROCESSOR_ACTION = "WRITE_COMMON" And (INSERT_ENBL_PAT_PMT Or INSERT_ENBL_SDT Or INSERT_ENBL_USER) Then
                If INSERT_ENBL_PAT_PMT And (STREAM_WRITE_PACKET_COUNT Mod INSERT_PERIOD_PAT_PMT = 0) Then
                    Dim INSERT_TOTAL_PAT_PMT As Integer = Int(INSERT_BYTE_PAT_PMT.Length / TS_PACKET_SIZE)
                    If INSERT_COUNT_PAT_PMT < INSERT_TOTAL_PAT_PMT Then
                        STREAM_READ_INSERT = True
                        Dim INSERT_READ_DATA As Byte() = New Byte(TS_PACKET_SIZE - 1) {}
                        Array.Copy(INSERT_BYTE_PAT_PMT, INSERT_COUNT_PAT_PMT * TS_PACKET_SIZE, INSERT_READ_DATA, 0, TS_PACKET_SIZE)
                        INSERT_COUNT_PAT_PMT += 1
                        Return INSERT_READ_DATA
                    End If
                End If

                If INSERT_ENBL_SDT And (STREAM_WRITE_PACKET_COUNT Mod INSERT_PERIOD_SDT = 0) Then
                    Dim INSERT_TOTAL_SDT As Integer = Int(INSERT_BYTE_SDT.Length / TS_PACKET_SIZE)
                    If INSERT_COUNT_SDT < INSERT_TOTAL_SDT Then
                        STREAM_READ_INSERT = True
                        Dim INSERT_READ_DATA As Byte() = New Byte(TS_PACKET_SIZE - 1) {}
                        Array.Copy(INSERT_BYTE_SDT, INSERT_COUNT_SDT * TS_PACKET_SIZE, INSERT_READ_DATA, 0, TS_PACKET_SIZE)
                        INSERT_COUNT_SDT += 1
                        Return INSERT_READ_DATA
                    End If
                End If

                If INSERT_ENBL_USER And (STREAM_WRITE_PACKET_COUNT Mod INSERT_PERIOD_USER = 0) Then
                    Dim INSERT_TOTAL_USER As Integer = Int(INSERT_BYTE_USER.Length / TS_PACKET_SIZE)
                    If INSERT_COUNT_USER < INSERT_TOTAL_USER Then
                        STREAM_READ_INSERT = True
                        Dim INSERT_READ_DATA As Byte() = New Byte(TS_PACKET_SIZE - 1) {}
                        Array.Copy(INSERT_BYTE_USER, INSERT_COUNT_USER * TS_PACKET_SIZE, INSERT_READ_DATA, 0, TS_PACKET_SIZE)
                        INSERT_COUNT_USER += 1
                        Return INSERT_READ_DATA
                    End If
                End If

                STREAM_READ_INSERT = False
                INSERT_COUNT_PAT_PMT = 0
                INSERT_COUNT_SDT = 0
                INSERT_COUNT_USER = 0
                STREAM_WRITE_PACKET_COUNT += STREAM_WRITE_PACKET_COUNT_TEMP
                STREAM_WRITE_PACKET_COUNT_TEMP = 0
            End If

            If STREAM_READ_INIT Then STREAM_READ_SET_INPUT_SOURCE()

            If INPUT_SOURCE.Count = 0 Or STREAM_READ_INDEX >= INPUT_SOURCE.Count Or (CUTTER_ENBL And CUTTER_TO <= STREAM_READ_TOTAL_OFFSET) Then
                STREAM_READ_EOF = True
                Return EMPTY_BYTE
            End If

            If STREAM_READ_CURRENT_OFFSET <= 0 Then
                STREAM_READ = New IO.FileStream(INPUT_SOURCE(STREAM_READ_INDEX), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
                STREAM_READER = New IO.BinaryReader(STREAM_READ)
                STREAM_READ_CURRENT_OFFSET = 0
                Dim _LOC_4 As New IO.FileInfo(INPUT_SOURCE(STREAM_READ_INDEX))
                STREAM_READ_CURRENT_LENGTH += _LOC_4.Length
                STREAM_READ_CURRENT_M2TS = False
                If _LOC_4.Extension.ToLower = ".m2ts" Then STREAM_READ_CURRENT_M2TS = True
            End If

            Dim READ_DATA As Byte() = EMPTY_BYTE
            Dim END_READ_PACKET As Boolean = False
            Dim CURRENT_EOF As Boolean = False
            Dim RTP_OFFSET As Integer = 0

            Do
                If Not STREAM_READER.BaseStream.Position = STREAM_READ_CURRENT_OFFSET Then
                    STREAM_READER.BaseStream.Position = STREAM_READ_CURRENT_OFFSET
                End If

                If STREAM_READ_CURRENT_M2TS Then
                    READ_DATA = STREAM_READER.ReadBytes(TS_PACKET_SIZE + TS_PACKET_HEADER_SIZE)
                Else
                    READ_DATA = STREAM_READER.ReadBytes(TS_PACKET_SIZE)
                End If

                If (READ_DATA(0) = TS_PACKET_HEADER_SYNC_BYTE(0) And STREAM_READ_CURRENT_M2TS = False) Or (READ_DATA(4) = TS_PACKET_HEADER_SYNC_BYTE(0) And STREAM_READ_CURRENT_M2TS = True) Then
                    STREAM_READ_PACKET_COUNT += 1
                    STREAM_READ_CURRENT_OFFSET += READ_DATA.Length
                    STREAM_READ_TOTAL_OFFSET += READ_DATA.Length
                    END_READ_PACKET = True
                Else
                    If INPUT_RTP Then
                        If RTP_OFFSET <= 0 Then
                            Dim RTP_HEADER_BIT As New BitArray(New Byte() {READ_DATA(0)})
                            Dim _LOC_8 As Integer = 12 + (RTP_HEADER_BIT(0) + RTP_HEADER_BIT(1) * 2 + RTP_HEADER_BIT(2) * 4 + RTP_HEADER_BIT(3) * 8) * 4
                            If RTP_HEADER_BIT(4) Then
                                _LOC_8 += 4
                                _LOC_8 += Int(READ_DATA(_LOC_8 - 2)) * 256 + Int(READ_DATA(_LOC_8 - 1)) * 4
                            End If
                            RTP_OFFSET = _LOC_8
                            STREAM_READ_CURRENT_OFFSET += RTP_OFFSET
                            STREAM_READ_TOTAL_OFFSET += RTP_OFFSET
                        Else
                            RTP_OFFSET = 0
                            STREAM_READ_CURRENT_OFFSET -= RTP_OFFSET - 1
                            STREAM_READ_TOTAL_OFFSET -= RTP_OFFSET - 1
                        End If
                    Else
                        STREAM_READ_CURRENT_OFFSET += 1
                        STREAM_READ_TOTAL_OFFSET += 1
                    End If
                End If

                If STREAM_READ_CURRENT_OFFSET >= STREAM_READ_CURRENT_LENGTH Then
                    CURRENT_EOF = True
                    END_READ_PACKET = True
                End If
            Loop Until END_READ_PACKET

            If CURRENT_EOF Then
                STREAM_READER.Close()
                STREAM_READ.Close()
                STREAM_READ_INDEX += 1
                STREAM_READ_CURRENT_LENGTH = 0
                STREAM_READ_CURRENT_OFFSET = 0

                If STREAM_READ_INDEX >= INPUT_SOURCE.Count Then
                    STREAM_READ_EOF = True
                End If
            End If

            If STREAM_READ_CURRENT_M2TS Then
                Dim READ_DATA_M2TS As Byte() = New Byte(TS_PACKET_SIZE - 1) {}
                Array.Copy(READ_DATA, TS_PACKET_HEADER_SIZE, READ_DATA_M2TS, 0, TS_PACKET_SIZE)
                Return READ_DATA_M2TS
            Else
                Return READ_DATA
            End If
        Catch ex As Exception
            Return EMPTY_BYTE
        End Try
    End Function

    Private Sub STREAM_READ_SET_INPUT_SOURCE()
        Try
            Dim INPUT_SOURCE_USER As String = TXT_INPUT_SOURCE_FILE.Text

            If INPUT_SOURCE_USER.ToUpper.StartsWith("CONCAT:") Then
                For Each _LOC_1 In INPUT_SOURCE_USER.Substring(7, INPUT_SOURCE_USER.Length - 7).Split("|")
                    If Not _LOC_1 = "" And My.Computer.FileSystem.FileExists(_LOC_1) Then INPUT_SOURCE.Add(_LOC_1)
                Next
            Else
                If My.Computer.FileSystem.FileExists(INPUT_SOURCE_USER) Then INPUT_SOURCE.Add(INPUT_SOURCE_USER)
            End If

            Dim _LOC_4 As Integer = 0
            Dim _LOC_5 As Boolean = False
            For Each _LOC_2 In INPUT_SOURCE
                Dim _LOC_3 As New IO.FileInfo(_LOC_2)
                STREAM_READ_TOTAL_LENGTH += _LOC_3.Length
                If CUTTER_ENBL And _LOC_5 = False Then
                    If CUTTER_FROM <= STREAM_READ_TOTAL_LENGTH Then
                        STREAM_READ_INDEX = _LOC_4
                        STREAM_READ = New IO.FileStream(INPUT_SOURCE(STREAM_READ_INDEX), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
                        STREAM_READER = New IO.BinaryReader(STREAM_READ)
                        STREAM_READ_CURRENT_LENGTH = _LOC_3.Length
                        STREAM_READ_CURRENT_OFFSET = STREAM_READ_CURRENT_LENGTH - (STREAM_READ_TOTAL_LENGTH - CUTTER_FROM)
                        STREAM_READ_TOTAL_OFFSET = STREAM_READ_TOTAL_LENGTH - (STREAM_READ_TOTAL_LENGTH - CUTTER_FROM)
                        _LOC_5 = True
                    End If
                End If
                _LOC_4 += 1
            Next

            STREAM_READ_INIT = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WRITE_PACKET(TS_PACKET_HEADER As Byte(), TS_PACKET_PAYLOAD As Byte(), Optional VALIDATE_SIZE As Boolean = True)
        Try
            If STREAM_WRITE_INIT Then
                STREAM_WRITE = New IO.FileStream(OUTPUT_SOURCE, IO.FileMode.Create)
                STREAM_WRITER = New IO.BinaryWriter(STREAM_WRITE)
                STREAM_WRITE_INIT = False
            End If

            If ((TS_PACKET_HEADER.Length = TS_PACKET_HEADER_SIZE) And (TS_PACKET_PAYLOAD.Length = TS_PACKET_SIZE - TS_PACKET_HEADER_SIZE)) Or VALIDATE_SIZE = False Then
                If Not STREAM_WRITE_SKIP_HEADER Then STREAM_WRITER.Write(TS_PACKET_HEADER)
                STREAM_WRITER.Write(TS_PACKET_PAYLOAD)
                If STREAM_READ_INSERT Then
                    STREAM_WRITE_PACKET_COUNT_TEMP += 1
                Else
                    STREAM_WRITE_PACKET_COUNT += 1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub STREAM_READ_CLOSE()
        Try
            STREAM_READER.Close()
            STREAM_READ.Close()
        Catch ex As Exception

        End Try

        Try
            STREAM_READ = Nothing
            STREAM_READ_CURRENT_LENGTH = 0
            STREAM_READ_CURRENT_OFFSET = 0
            STREAM_READ_EOF = False
            STREAM_READ_INDEX = 0
            STREAM_READ_INSERT = False
            STREAM_READ_INIT = True
            STREAM_READ_PACKET_COUNT = 0
            STREAM_READ_TOTAL_LENGTH = 0
            STREAM_READ_TOTAL_OFFSET = 0
            STREAM_READ_TOTAL_PACKET_COUNT = 0
            STREAM_READER = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub STREAM_WRITE_CLOSE()
        Try
            STREAM_WRITER.Close()
            STREAM_WRITE.Close()
        Catch ex As Exception

        End Try

        Try
            STREAM_WRITE = Nothing
            STREAM_WRITE_INIT = True
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function CALC_CRC32_MPEG_2_STRING(ByVal Input As String) As String
        Dim CRC32_Data As UInteger()
        CRC32_Data = HexToUInt(Input)
        Dim CRC32_Result As UInteger = CALC_CRC32_MPEG_2(CRC32_Data, CRC32_Data.Length)
        Dim crcStr As String = (CRC32_Result.ToString("X4"))
        crcStr = If(crcStr.Length = 8, crcStr, "0" & crcStr)
        Return crcStr.Trim
    End Function

    Private Shared Function CALC_CRC32_MPEG_2(Data As UInteger(), Length As Integer) As UInteger
        Dim _LOC_1 As UInteger
        Dim CRC As UInteger = &HFFFFFFFFL, _LOC_2 As UInteger = 0
        While Math.Max(Threading.Interlocked.Decrement(Length), Length + 1) <> 0
            CRC = CRC Xor Data(_LOC_2) << 24
            _LOC_2 += 1
            For _LOC_1 = 0 To 7
                If Not (CRC And &H80000000L) = 0 Then
                    CRC = (CRC << 1) Xor &H4C11DB7
                Else
                    CRC <<= 1
                End If
            Next
        End While
        Return CRC
    End Function

    Private Shared Function HexToUInt(Input As String) As UInteger()
        Input = Input.Replace(" ", "")
        If (Input.Length Mod 2) <> 0 Then Input += " "
        Dim _LOC_1 As UInteger() = New UInteger(Input.Length / 2 - 1) {}
        For _LOC_2 As Integer = 0 To _LOC_1.Length - 1
            _LOC_1(_LOC_2) = Convert.ToByte(Input.Substring(_LOC_2 * 2, 2), 16)
        Next
        Return _LOC_1
    End Function

    Public Shared Function HexToBytes(Hex As String) As Byte()
        Return Enumerable.Range(0, Hex.Length).Where(Function(x) x Mod 2 = 0).[Select](Function(x) Convert.ToByte(Hex.Substring(x, 2), 16)).ToArray()
    End Function

    Public Shared Function BytesToHex(Bytes As Byte()) As String
        Return BitConverter.ToString(Bytes).Replace("-", "").ToUpper
    End Function

    Public Shared Function BytesToBin(Bytes() As Byte) As String
        Dim _LOC_1 As New StringBuilder
        For Each _LOC_2 In Bytes
            _LOC_1.Append(Convert.ToString(_LOC_2, 2).PadLeft(8, "0"))
        Next
        Return _LOC_1.ToString
    End Function

    Public Shared Function BinToBytes(Input As String) As Byte()
        Dim _LOC_1 As Integer = Input.Length / 8
        Dim _LOC_2 As Byte() = New Byte(_LOC_1 - 1) {}
        For _LOC_3 As Integer = 0 To _LOC_1 - 1
            _LOC_2(_LOC_3) = Convert.ToByte(Input.Substring(8 * _LOC_3, 8), 2)
        Next
        Return _LOC_2
    End Function

    Private Function ComByteArray(Array1 As System.Array, Array2 As System.Array) As Byte()
        Dim _LOC_1 As New List(Of Byte)
        For Each _LOC_2 In Array1
            _LOC_1.Add(_LOC_2)
        Next
        For Each _LOC_3 In Array2
            _LOC_1.Add(_LOC_3)
        Next
        Return _LOC_1.ToArray
    End Function

    Public Sub InvokeControl(Of T As Control)(ByVal Control As T, ByVal Action As Action(Of T))
        If Control.InvokeRequired Then
            Control.Invoke(New Action(Of T, Action(Of T))(AddressOf InvokeControl), New Object() {Control, Action})
        Else
            Action(Control)
        End If
    End Sub

    Private Sub RELEASE_MEMORY()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function VerifyData(HexString As String, FILTER_PACKET_SIZE As Integer, FILTER_HEADER_KEYWORD As String) As String
        For _LOC_1 = 0 To (FILTER_PACKET_SIZE * 2) - 1
            If (FILTER_HEADER_KEYWORD = HexString.Substring(_LOC_1 * 2, FILTER_HEADER_KEYWORD.Length)) And (FILTER_HEADER_KEYWORD = HexString.Substring((_LOC_1 * 2) + (FILTER_PACKET_SIZE * 2), FILTER_HEADER_KEYWORD.Length)) And (FILTER_HEADER_KEYWORD = HexString.Substring((_LOC_1 * 2) + (FILTER_PACKET_SIZE * 2) + (FILTER_PACKET_SIZE * 2), FILTER_HEADER_KEYWORD.Length)) Then
                Return _LOC_1
            End If
        Next

        Return "STATUS_ERROR"
    End Function

    Private Sub TXT_INPUT_SOURCE_FILE_TextChanged(sender As Object, e As EventArgs) Handles TXT_INPUT_SOURCE_FILE.TextChanged
        Try
            If CHK_INPUT_AUTO_SCAN.Checked Then
                INPUT_SCAN()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LSV_PID_Click(sender As Object, e As EventArgs) Handles LSV_PID.Click
        Try
            LBL_PAT_PMT_SELECT_PID_PID.Text = LSV_PID.SelectedItems(0).SubItems(1).Text
            TXT_PID_ORIGINAL.Text = LSV_PID.SelectedItems(0).SubItems(1).Text
            If LSV_PID.SelectedItems(0).SubItems(3).Text = "" Then TXT_PAT_PMT_STREAM_TYPE.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CBO_PAT_PMT_STREAM_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_PAT_PMT_STREAM_TYPE.SelectedIndexChanged
        Try
            TXT_PAT_PMT_STREAM_TYPE.Text = CInt("&H" & Regex.Match(CBO_PAT_PMT_STREAM_TYPE.Text, "\(0x(.*)\)", RegexOptions.None).Groups(1).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CBO_PAT_PMT_STREAM_TYPE_DEFINIT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_PAT_PMT_STREAM_TYPE_DEFINIT.SelectedIndexChanged
        Try
            If Not TXT_PAT_PMT_STREAM_TYPE.Text = "" Then
                TXT_PAT_PMT_STREAM_TYPE.Text = TXT_PAT_PMT_STREAM_TYPE.Text.Split(" ")(0) & " (" & CBO_PAT_PMT_STREAM_TYPE_DEFINIT.Text.Split(" ")(0) & ")"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CBO_SDT_SERVICE_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_SDT_SERVICE_TYPE.SelectedIndexChanged
        Try
            TXT_SDT_SERVICE_TYPE.Text = "0x" & Regex.Match(CBO_SDT_SERVICE_TYPE.Text, "\(0x(.*)\)", RegexOptions.None).Groups(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PROCESSOR_CONTROL(CONTROL_STATUS As String)
        Try
            If CONTROL_STATUS = "PROCESSOR_START" Then
                PROCESSOR_ACTION = "WRITE_COMMON"

                PROCESSOR_CURRENT = 0
                PROCESSOR_TOTAL = 1

                PROCESSOR_MULTITASK_PARSER()

                BTN_OUTPUT_START.Text = BTN_OUTPUT_STATUS_STOP
            ElseIf CONTROL_STATUS = "PROCESSOR_COMPLETE" Then
                If PROCESSOR_ACTION.ToUpper.StartsWith("WRITE") Then
                    PROCESSOR_CURRENT += 1
                End If

                If PROCESSOR_ACTION.ToUpper.StartsWith("WRITE") And PROCESSOR_RESULT_OK Then
                    Text = "100% - " & System.IO.Path.GetFileName(OUTPUT_SOURCE) & " [OK]"
                    PGB_OUTPUT_PROGRESS.Value = 100
                    PROCESSOR_RESULT_OK = False
                    PLAY_SOUND_OK()
                End If

                If PROCESSOR_ACTION.ToUpper.StartsWith("WRITE") And PROCESSOR_CANCEL Then
                    Text += " [Abort]"
                    PROCESSOR_CANCEL = False
                    Exit Sub
                End If

                If PROCESSOR_CURRENT >= PROCESSOR_TOTAL Then
                    BTN_OUTPUT_START.Text = BTN_OUTPUT_STATUS_START
                    If Not PROCESSOR_MESSAGE_OK = "" Then MsgBox(PROCESSOR_MESSAGE_OK, vbInformation, "Prompt message")
                    If Not PROCESSOR_MESSAGE_ERROR = "" Then MsgBox(PROCESSOR_MESSAGE_ERROR, vbCritical, "Error message")
                    Exit Sub
                End If
            End If

            If CUTTER_ENBL And PROCESSOR_ACTION = "WRITE_COMMON" Then
                OUTPUT_SOURCE = FILE_NAME_INSERT(OUTPUT_SOURCE_PREFIX, LSV_CUTTER.Items(PROCESSOR_CURRENT).SubItems(0).Text, False)
                CUTTER_FROM = LSV_CUTTER.Items(PROCESSOR_CURRENT).SubItems(1).Text * TS_PACKET_SIZE
                CUTTER_TO = LSV_CUTTER.Items(PROCESSOR_CURRENT).SubItems(2).Text * TS_PACKET_SIZE
                If CUTTER_FROM < 0 Then CUTTER_FROM = 0
                If CUTTER_TO > LBL_CUTTER_TOTAL_PACKETS_COUNT.Text * TS_PACKET_SIZE Then CUTTER_TO = LBL_CUTTER_TOTAL_PACKETS_COUNT.Text * TS_PACKET_SIZE
                PROCESSOR_STOPWATCH_PROGRESS = -1
                STREAM_READ_INIT = True
                INPUT_SOURCE.Clear()
            End If

            If Not BGW_PROCESS.IsBusy Then BGW_PROCESS.RunWorkerAsync()
        Catch ex As Exception

        Finally
            LBL_OUTPUT_PROGRESS.Text = PROCESSOR_CURRENT & "/" & PROCESSOR_TOTAL
        End Try
    End Sub

    Private Sub PROCESSOR_MULTITASK_PARSER()
        Try
            If LSV_CUTTER.Items.Count > 0 Then
                PROCESSOR_TOTAL = LSV_CUTTER.Items.Count
                CUTTER_ENBL = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function FILE_NAME_INSERT(FileName As String, InsertContent As String, Optional AppendMode As Boolean = True)
        Try
            Dim _LOC_1 As String = Path.GetDirectoryName(FileName) & "\" & InsertContent & Path.GetExtension(FileName)
            If AppendMode Or My.Computer.FileSystem.FileExists(_LOC_1) Then
                Return Path.GetDirectoryName(FileName) & "\" & Path.GetFileNameWithoutExtension(FileName) & "_" & InsertContent & Path.GetExtension(FileName)
            Else
                Return _LOC_1
            End If
        Catch ex As Exception
            Return FileName
        End Try
    End Function

    Private Sub BTN_OUTPUT_START_Click(sender As Object, e As EventArgs) Handles BTN_OUTPUT_START.Click
        Try
            If BGW_PROCESS.IsBusy Then
                PROCESSOR_CANCEL = True
                BTN_OUTPUT_START.Text = BTN_OUTPUT_STATUS_START
            Else
                TXT_OUTPUT_DEST_FILE.Text = TXT_OUTPUT_DEST_FILE.Text.Replace("/", "\")
                If TXT_OUTPUT_DEST_FILE.Text.EndsWith(":") Then
                    TXT_OUTPUT_DEST_FILE.Text += "\"
                End If
                If Not TXT_OUTPUT_DEST_FILE.Text.Contains("\") Then
                    TXT_OUTPUT_DEST_FILE.Text = My.Computer.FileSystem.GetParentPath(INPUT_SOURCE(0)) & "\" & TXT_OUTPUT_DEST_FILE.Text
                End If
                If Not TXT_OUTPUT_DEST_FILE.Text.StartsWith("\\") Then TXT_OUTPUT_DEST_FILE.Text = TXT_OUTPUT_DEST_FILE.Text.Replace("\\", "\")
                If IO.Path.GetExtension(TXT_OUTPUT_DEST_FILE.Text) = "" Then TXT_OUTPUT_DEST_FILE.Text += ".ts"
                OUTPUT_SOURCE = TXT_OUTPUT_DEST_FILE.Text
                OUTPUT_SOURCE_PREFIX = OUTPUT_SOURCE

                Try
                    My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(OUTPUT_SOURCE))
                Catch ex As Exception

                End Try

                STATUS_RESET()

                If CHK_ENBL_PID_FILTER.Checked Then
                    For _LOC_1 = 0 To LSV_PID.Items.Count - 1
                        If LSV_PID.Items(_LOC_1).Checked Then STREAM_WRITE_PID += "<" & Int(LSV_PID.Items(_LOC_1).SubItems(1).Text) & ">"
                    Next
                    If STREAM_WRITE_PID = "" Then CHK_ENBL_PID_FILTER.Checked = False
                End If

                If CHK_REMARK_SCRAMBL_TAG.Checked Then
                    If CBO_REMARK_SCRABMBL_TAG.Text.Substring(0, 1) = "1" Then TS_PACKET_HEADER_SCRAMBL_BIT_1 = 1
                    If CBO_REMARK_SCRABMBL_TAG.Text.Substring(1, 1) = "1" Then TS_PACKET_HEADER_SCRAMBL_BIT_2 = 1

                    For _LOC_31 = 0 To LSV_PID.Items.Count - 1
                        Dim _LOC_32 As Integer = Int(LSV_PID.Items(_LOC_31).SubItems(1).Text)
                        If (_LOC_32 >= 32 And _LOC_32 <= 8190) And (Not LSV_PID.Items(_LOC_31).SubItems(3).Text = "") Then
                            TS_PACKET_HEADER_SCRAMBL_PID_LIST.Add(_LOC_32)
                        End If
                    Next
                End If

                If LSV_PID_REWRITE.Items.Count > 0 Then
                    For _LOC_2 = 0 To LSV_PID_REWRITE.Items.Count - 1
                        Dim _LOC_3 As Integer = NormalizePID(LSV_PID_REWRITE.Items(_LOC_2).SubItems(0).Text)
                        Dim _LOC_4 As Integer = NormalizePID(LSV_PID_REWRITE.Items(_LOC_2).SubItems(1).Text)
                        If _LOC_3 > 0 And _LOC_4 > 0 Then
                            PID_REWRITE += "<" & _LOC_3 & "|" & _LOC_4 & ">"
                        End If
                    Next
                End If

                If INSERT_ENBL_PAT_PMT Then BUILD_PAT_PMT()
                If INSERT_ENBL_SDT Then BUILD_SDT()
                If INSERT_ENBL_USER Then INSERT_BYTE_USER = My.Computer.FileSystem.ReadAllBytes(TXT_INSERT_TS_FILE.Text)

                PROCESSOR_CONTROL("PROCESSOR_START")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical, "Task canceled")
        End Try
    End Sub

    Private Sub STATUS_RESET()
        Try
            CUTTER_ENBL = False
            CUTTER_FROM = 0
            CUTTER_TO = 0
            DISCARDER_ENBL = CHK_ENBL_DISCARDER.Checked
            DISCARDER_PERIOD_FROM = NUM_DISCARDER_RANGE_1.Value
            DISCARDER_PERIOD_TO = NUM_DISCARDER_RANGE_2.Value
            DISCARDER_NEXT = 0
            INPUT_RTP = False
            INPUT_SOURCE.Clear()
            INSERT_COUNT_PAT_PMT = 0
            INSERT_COUNT_SDT = 0
            INSERT_COUNT_USER = 0
            INSERT_ENBL_PAT_PMT = CHK_ENBL_PAT_PMT.Checked
            INSERT_ENBL_SDT = CHK_ENBL_SDT.Checked
            INSERT_ENBL_USER = CHK_ENBL_INSERT.Checked
            INSERT_PERIOD_PAT_PMT = NUM_PAT_PMT_PERIOD.Value
            INSERT_PERIOD_SDT = NUM_SDT_PERIOD.Value
            INSERT_PERIOD_USER = NUM_INSERT_PERIOD.Value
            PID_REWRITE = ""
            PROCESSOR_CANCEL = False
            PROCESSOR_CURRENT = 0
            PROCESSOR_MESSAGE_ERROR = ""
            PROCESSOR_MESSAGE_OK = ""
            PROCESSOR_REPORTER_COUNT = -1
            PROCESSOR_RESULT_OK = False
            PROCESSOR_STOPWATCH_PROGRESS = -1
            PROCESSOR_TOTAL = 0
            SCRAMBL_SEGMENT_COUNT = 0
            STREAM_READ_CLOSE()
            STREAM_WRITE_CLOSE()
            STREAM_WRITE_PID = ""
            STREAM_WRITE_PID_COUNTE = ""
            STREAM_WRITE_SKIP_HEADER = CHK_EXTRACT_PAYLOAD.Checked
            STREAM_WRITE_PACKET_COUNT = 0
            STREAM_WRITE_PACKET_COUNT_TEMP = 0
            STREAM_WRITER = Nothing
            TS_PACKET_HEADER_SCRAMBL_BIT_1 = 0
            TS_PACKET_HEADER_SCRAMBL_BIT_2 = 0
            TS_PACKET_HEADER_SCRAMBL_PID_LIST.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BUILD_PAT_PMT()
        Try
            'BEGIN BUILD PAT
            'BEGIN BUILD PAT TS PACKET HEADER
            'Byte 1
            Dim PACKET_DATA_BIN As String = "01000111"  'sync_byte 0x47

            'Byte 2 and Byte 3
            PACKET_DATA_BIN += "0"                      'transport_error_indicator
            PACKET_DATA_BIN += "1"                      'payload_unit_start_indicator
            PACKET_DATA_BIN += "0"                      'transport_priority
            PACKET_DATA_BIN += "0000000000000"          'PID 0x00

            'Byte 4
            PACKET_DATA_BIN += "00"                     'transport_scrambling_control
            PACKET_DATA_BIN += "01"                     'adaptation_field_control
            PACKET_DATA_BIN += "0000"                   'continuity_counte
            'END BUILD PAT TS PACKET HEADER

            'EMPTY BYTE
            PACKET_DATA_BIN += "00000000"

            'BEGIN BUILD PAT TABLE
            'Byte 1
            PACKET_DATA_BIN += "00000000"               'table_id

            'Byte 2 and Byte 3
            PACKET_DATA_BIN += "1"                      'section_syntax_indicator
            PACKET_DATA_BIN += "0"                      'zero
            PACKET_DATA_BIN += "11"                     'reserved
            PACKET_DATA_BIN += "XXXXXXXXXXXX"           'section_length

            Dim _LOC_1 As Integer = PACKET_DATA_BIN.Length

            'Byte 4 and Byte 5
            PACKET_DATA_BIN += ID_BIN(TXT_PAT_PMT_TRANSPO_STREAM_ID.Text, 16)         'transport_stream_id

            'Byte 6
            PACKET_DATA_BIN += "11"                     'reserved
            PACKET_DATA_BIN += "00000"                  'version_number
            PACKET_DATA_BIN += "1"                      'current_next_indicator

            'Byte 7
            PACKET_DATA_BIN += "00000000"               'section_number 0x00

            'Byte 8
            PACKET_DATA_BIN += "00000000"               'last_section_number 0x00

            'Byte 9 and Byte 10
            PACKET_DATA_BIN += ID_BIN(TXT_PAT_PMT_PROGRAM_NUMBER.Text, 16)           'program_number

            'Byte 11 to Byte 12
            PACKET_DATA_BIN += "111"                    'reserved
            PACKET_DATA_BIN += ID_BIN(TXT_PAT_PMT_PID.Text, 13)                      'program_map_PID

            PACKET_DATA_BIN = PACKET_DATA_BIN.Replace("XXXXXXXXXXXX", ID_BIN(Int((PACKET_DATA_BIN.Length - _LOC_1) / 8 + 4), 12))

            'Byte 13 to Byte 16
            PACKET_DATA_BIN += BytesToBin(HexToBytes(CALC_CRC32_MPEG_2_STRING(BytesToHex(BinToBytes(PACKET_DATA_BIN.Substring((TS_PACKET_HEADER_SIZE + 1) * 8, PACKET_DATA_BIN.Length - (TS_PACKET_HEADER_SIZE + 1) * 8))))))

            PACKET_DATA_BIN = BUILD_PACKET_BIN_PADDING(PACKET_DATA_BIN)
            Dim PAT_DATA As String = PACKET_DATA_BIN
            'END BUILD PAT

            'BEGIN BUILD PMT
            'BEGIN BUILD PMT TS PACKET HEADER
            'Byte 1
            PACKET_DATA_BIN = "01000111"                'sync_byte 0x47

            'Byte 2 and Byte 3
            PACKET_DATA_BIN += "0"                      'transport_error_indicator
            PACKET_DATA_BIN += "1"                      'payload_unit_start_indicator
            PACKET_DATA_BIN += "0"                      'transport_priority
            PACKET_DATA_BIN += ID_BIN(TXT_PAT_PMT_PID.Text, 13)                      'PID

            'Byte 4
            PACKET_DATA_BIN += "00"                     'transport_scrambling_control
            PACKET_DATA_BIN += "01"                     'adaptation_field_control
            PACKET_DATA_BIN += "0000"                   'continuity_counte
            'END BUILD PMT TS PACKET HEADER

            'EMPTY BYTE
            PACKET_DATA_BIN += "00000000"

            'BEGIN BUILD PMT TABLE
            'Byte 1
            PACKET_DATA_BIN += "00000010"               'table_id 0x02

            'Byte 2 and Byte 3
            PACKET_DATA_BIN += "1"                      'section_syntax_indicator
            PACKET_DATA_BIN += "0"                      'zero
            PACKET_DATA_BIN += "11"                     'reserved
            PACKET_DATA_BIN += "XXXXXXXXXXXX"           'section_length

            Dim _LOC_2 As Integer = PACKET_DATA_BIN.Length

            'Byte 4 and Byte 5
            PACKET_DATA_BIN += ID_BIN(TXT_PAT_PMT_PROGRAM_NUMBER.Text, 16)           'program_number

            'Byte 6
            PACKET_DATA_BIN += "11"                     'reserved
            PACKET_DATA_BIN += "00000"                  'version_number
            PACKET_DATA_BIN += "1"                      'current_next_indicator

            'Byte 7
            PACKET_DATA_BIN += "00000000"               'section_number 0x00

            'Byte 8
            PACKET_DATA_BIN += "00000000"               'last_section_number 0x00

            'Byte 9 and Byte 10
            PACKET_DATA_BIN += "111"                    'reserved
            PACKET_DATA_BIN += "PPPPPPPPPPPPP"          'PCR_PID

            'Byte 11 and Byte 12
            PACKET_DATA_BIN += "1111"                   'reserved
            PACKET_DATA_BIN += "000000000000"           'program_info_length

            'From Byte 13
            Dim _LOC_3 As Integer = 0
            For _LOC_4 = 0 To LSV_PID.Items.Count - 1
                If Not (CHK_ENBL_PID_FILTER.Checked And LSV_PID.Items(_LOC_4).Checked = False) Then
                    Dim _LOC_5 As Integer = GetOverwritePID(Int(LSV_PID.Items(_LOC_4).SubItems(1).Text))
                    If (_LOC_5 >= 32 And _LOC_5 <= 8190) And (Not LSV_PID.Items(_LOC_4).SubItems(3).Text = "") Then
                        PACKET_DATA_BIN += ID_BIN(LSV_PID.Items(_LOC_4).SubItems(3).Text, 8)                          'stream_type
                        PACKET_DATA_BIN += "111"        'reserved
                        PACKET_DATA_BIN += ID_BIN(_LOC_5, 13)                        'elementary_PID
                        PACKET_DATA_BIN += "1111"       'reserved

                        INSERT_CODEC_PAT_PMT = ""
                        If ID_BIN(LSV_PID.Items(_LOC_4).SubItems(3).Text, 8) = "00000110" Then
                            If INSERT_CODEC_PAT_PMT.Replace("-", "").ToUpper.Contains("AC3") Then
                                'BEGIN BUILD AC-3 ES INFO
                                PACKET_DATA_BIN += "000000000011"                        'ES_info_length 0x03

                                PACKET_DATA_BIN += "01101010"                            'descriptor_tag 0x6A

                                PACKET_DATA_BIN += "00000001"                            'descriptor_length 0x01

                                PACKET_DATA_BIN += "00000000"
                                'END BUILD AC-3 ES INFO
                            ElseIf INSERT_CODEC_PAT_PMT.ToUpper.Contains("DRA") Then
                                'BEGIN BUILD DRA ES INFO
                                PACKET_DATA_BIN += "000000001010"                        'ES_info_length 0x0A

                                'DRA registration descriptor
                                PACKET_DATA_BIN += "00000101"                            'descriptor_tag 0x05

                                PACKET_DATA_BIN += "00000100"                            'descriptor_length 0x04

                                PACKET_DATA_BIN += "01000100010100100100000100110001"    'format_identifier 0x44524131

                                'DRA audio stream descriptor
                                PACKET_DATA_BIN += "10100000"                            'descriptor_tag 0xA0

                                PACKET_DATA_BIN += "00000010"                            'descriptor_length 0x02

                                PACKET_DATA_BIN += "1000"                                'sample_rate_index 0x08

                                PACKET_DATA_BIN += "000010"                              'num_normal_channels 0x02

                                PACKET_DATA_BIN += "00"                                  'num_lfe_channels 0x00

                                PACKET_DATA_BIN += "0"                                   'dra_version_flag

                                PACKET_DATA_BIN += "0"                                   'text_present_flag

                                PACKET_DATA_BIN += "0"                                   'language_present_flag

                                PACKET_DATA_BIN += "0"                                   'reversed
                                'END BUILD DRA ES INFO
                            Else
                                PACKET_DATA_BIN += "000000000000"                        'ES_info_length
                            End If
                        Else
                            PACKET_DATA_BIN += "000000000000"                        'ES_info_length
                        End If

                        If _LOC_3 = 0 Then PACKET_DATA_BIN = PACKET_DATA_BIN.Replace("PPPPPPPPPPPPP", ID_BIN(_LOC_5, 13))
                        _LOC_3 += 1
                    End If
                End If
                If _LOC_3 >= MAX_PID_NUMBER Then Exit For
            Next

            PACKET_DATA_BIN = PACKET_DATA_BIN.Replace("XXXXXXXXXXXX", ID_BIN(Int((PACKET_DATA_BIN.Length - _LOC_2) / 8 + 4), 12))

            'Last 4 Bytes
            PACKET_DATA_BIN += BytesToBin(HexToBytes(CALC_CRC32_MPEG_2_STRING(BytesToHex(BinToBytes(PACKET_DATA_BIN.Substring((TS_PACKET_HEADER_SIZE + 1) * 8, PACKET_DATA_BIN.Length - (TS_PACKET_HEADER_SIZE + 1) * 8))))))

            PACKET_DATA_BIN = BUILD_PACKET_BIN_PADDING(PACKET_DATA_BIN)
            Dim PMT_DATA As String = PACKET_DATA_BIN
            'END BUILD PMT

            INSERT_BYTE_PAT_PMT = ComByteArray(BinToBytes(PAT_DATA), BinToBytes(PMT_DATA))
        Catch ex As Exception

        End Try
    End Sub

    Private Function BUILD_PACKET_BIN_PADDING(Input As String)
        Try
            Input = Input.Trim
            If Input.Length < TS_PACKET_SIZE * 8 Then
                For i = 1 To TS_PACKET_SIZE * 8 - Input.Length
                    Input += "1"
                Next
            End If
            If Input.Length > TS_PACKET_SIZE * 8 Then
                Input = Input.Substring(0, TS_PACKET_SIZE * 8)
            End If
            Return Input
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Function ID_BIN(ID As String, RequiredLength As Integer)
        Try
            ID = ID.Trim
            If ID.Contains(" ") Then
                INSERT_CODEC_PAT_PMT = Regex.Match(ID.Split(" ")(1), "\((.*)\)", RegexOptions.None).Groups(1).Value
                ID = ID.Split(" ")(0)
            End If
            Dim ReturnBIN As String = ""
            If ID.ToUpper.StartsWith("0X") Then
                Dim _LOC_1 As String = ID.ToUpper.Split("X")(1)
                If _LOC_1.Length Mod 2 = 1 Then _LOC_1 = "0" & _LOC_1
                ID = Int(CLng("&H" & _LOC_1))
            End If
            Dim Number As Long = Convert.ToInt64(ID)
            Do While Number > 0
                ReturnBIN = Number Mod 2 & ReturnBIN
                Number \= 2
            Loop
            If RequiredLength < ReturnBIN.Length Then
                ReturnBIN = ReturnBIN.Substring(0, RequiredLength)
            End If
            If RequiredLength > ReturnBIN.Length Then
                For _LOC_2 = 1 To RequiredLength - ReturnBIN.Length
                    ReturnBIN = "0" + ReturnBIN
                Next
            End If
            Return ReturnBIN
        Catch ex As Exception
            Dim ReturnBIN As String = ""
            For _LOC_3 = 1 To RequiredLength
                ReturnBIN += "0"
            Next
            Return ReturnBIN
        End Try
    End Function

    Private Function TEXT_BIN(Text As String)
        Try
            Text = Text.Trim
            Dim ReturnBIN As String = ""
            If Text.ToUpper.StartsWith("0X") Then
                ReturnBIN = BytesToBin(HexToBytes(Text.ToUpper.Split("X")(1)))
            Else
                Dim regX As New Regex("[\u4e00-\u9fa5]")
                If regX.IsMatch(Text) Then
                    MULTILNG_CHINESE = True
                    ReturnBIN = "00010011" & BytesToBin(Encoding.GetEncoding("gb2312").GetBytes(Text))
                Else
                    ReturnBIN = BytesToBin(Encoding.UTF8.GetBytes(Text))
                End If
            End If
            If MAX_TEXT_BIN_LENGTH < ReturnBIN.Length Then
                ReturnBIN = ReturnBIN.Substring(0, MAX_TEXT_BIN_LENGTH)
            End If
            Return ReturnBIN
        Catch ex As Exception
            Return BytesToBin(EMPTY_BYTE)
        End Try
    End Function

    Private Sub BUILD_SDT()
        Try
            'BEGIN BUILD SDT
            'BEGIN BUILD SDT TS PACKET HEADER
            'Byte 1
            Dim PACKET_DATA_BIN As String = "01000111"  'sync_byte 0x47

            'Byte 2 and Byte 3
            PACKET_DATA_BIN += "0"                      'transport_error_indicator
            PACKET_DATA_BIN += "1"                      'payload_unit_start_indicator
            PACKET_DATA_BIN += "0"                      'transport_priority
            PACKET_DATA_BIN += "0000000010001"          'PID 0x11

            'Byte 4
            PACKET_DATA_BIN += "00"                     'transport_scrambling_control
            PACKET_DATA_BIN += "01"                     'adaptation_field_control
            PACKET_DATA_BIN += "0000"                   'continuity_counte
            'END BUILD SDT TS PACKET HEADER

            'EMPTY BYTE
            PACKET_DATA_BIN += "00000000"

            'BEGIN BUILD SDT TABLE
            'Byte 1
            PACKET_DATA_BIN += "01000010"               'table_id 0x42

            'Byte 2 and Byte 3
            PACKET_DATA_BIN += "1"                      'section_syntax_indicator
            PACKET_DATA_BIN += "1"                      'reserved_future_use
            PACKET_DATA_BIN += "11"                     'reserved
            PACKET_DATA_BIN += "XXXXXXXXXXXX"           'section_length

            Dim _LOC_1 As Integer = PACKET_DATA_BIN.Length

            'Byte 4 and Byte 5
            PACKET_DATA_BIN += ID_BIN(TXT_SDT_TRANSPO_STREAM_ID.Text, 16)             'transport_stream_id

            'Byte 6
            PACKET_DATA_BIN += "11"                     'reserved
            PACKET_DATA_BIN += "00000"                  'version_number
            PACKET_DATA_BIN += "1"                      'current_next_indicator

            'Byte 7
            PACKET_DATA_BIN += "00000000"               'section_number 0x00

            'Byte 8
            PACKET_DATA_BIN += "00000000"               'last_section_number 0x00

            'Byte 9 and Byte 10
            PACKET_DATA_BIN += ID_BIN(TXT_SDT_NETWORK_ID.Text, 16)                    'original_network_id

            'Byte 11
            PACKET_DATA_BIN += "11111111"               'reserved_future_use

            'Byte 12 and Byte 13
            PACKET_DATA_BIN += ID_BIN(TXT_SDT_SERVICE_ID.Text, 16)                    'service_id

            'Byte 14
            PACKET_DATA_BIN += "111111"                 'reserved_future_use
            PACKET_DATA_BIN += "0"                      'EIT_schedule_flag
            PACKET_DATA_BIN += "0"                      'EIT_present_following_flag

            'Byte 15 and Byte 16
            PACKET_DATA_BIN += "100"                    'running_status
            PACKET_DATA_BIN += "0"                      'free_CA_mode
            PACKET_DATA_BIN += "YYYYYYYYYYYY"           'descriptors_loop_length

            Dim _LOC_2 As Integer = PACKET_DATA_BIN.Length

            'Byte 17
            PACKET_DATA_BIN += "01001000"               'descriptor_tag 0x48

            'Byte 18
            PACKET_DATA_BIN += "ZZZZZZZZ"               'descriptor_length

            Dim _LOC_3 As Integer = PACKET_DATA_BIN.Length

            'From Byte 19
            PACKET_DATA_BIN += ID_BIN(TXT_SDT_SERVICE_TYPE.Text, 8)                   'service_type

            MULTILNG_CHINESE = False
            Dim _LOC_4 As String = TEXT_BIN(TXT_SDT_SERVICE_PROVIDER.Text)
            PACKET_DATA_BIN += ID_BIN(Int(_LOC_4.Length / 8), 8)                      'service_provider_name_length

            PACKET_DATA_BIN += _LOC_4

            Dim _LOC_5 As String = TEXT_BIN(TXT_SDT_SERVICE_NAME.Text)
            PACKET_DATA_BIN += ID_BIN(Int(_LOC_5.Length / 8), 8)                      'service_name_length

            PACKET_DATA_BIN += _LOC_5

            PACKET_DATA_BIN = PACKET_DATA_BIN.Replace("ZZZZZZZZ", ID_BIN(Int((PACKET_DATA_BIN.Length - _LOC_3) / 8), 8))

            ''BEGIN MULTILNG_CHINESE
            'If MULTILNG_CHINESE Then
            '    PACKET_DATA_BIN += "01011101"           'descriptor_tag 0x5D

            '    PACKET_DATA_BIN += "ZZZZZZZZ"           'descriptor_length

            '    Dim _LOC_6 As Integer = PACKET_DATA_BIN.Length

            '    PACKET_DATA_BIN += "011000110110100001101001"                         'ISO_639_language_code 0x636869 "chi"

            '    PACKET_DATA_BIN += ID_BIN(Int(_LOC_4.Length / 8), 8)                  'service_provider_name_length

            '    PACKET_DATA_BIN += _LOC_4

            '    PACKET_DATA_BIN += ID_BIN(Int(_LOC_5.Length / 8), 8)                  'service_name_length

            '    PACKET_DATA_BIN += _LOC_5

            '    PACKET_DATA_BIN = PACKET_DATA_BIN.Replace("ZZZZZZZZ", ID_BIN(Int((PACKET_DATA_BIN.Length - _LOC_3) / 8), 8))
            'End If
            'MULTILNG_CHINESE = False
            ''END MULTILNG_CHINESE

            PACKET_DATA_BIN = PACKET_DATA_BIN.Replace("YYYYYYYYYYYY", ID_BIN(Int((PACKET_DATA_BIN.Length - _LOC_2) / 8), 12))

            PACKET_DATA_BIN = PACKET_DATA_BIN.Replace("XXXXXXXXXXXX", ID_BIN(Int((PACKET_DATA_BIN.Length - _LOC_1) / 8 + 4), 12))

            'Last 4 Bytes
            PACKET_DATA_BIN += BytesToBin(HexToBytes(CALC_CRC32_MPEG_2_STRING(BytesToHex(BinToBytes(PACKET_DATA_BIN.Substring((TS_PACKET_HEADER_SIZE + 1) * 8, PACKET_DATA_BIN.Length - (TS_PACKET_HEADER_SIZE + 1) * 8))))))

            INSERT_BYTE_SDT = BinToBytes(BUILD_PACKET_BIN_PADDING(PACKET_DATA_BIN))
            'END BUILD SDT
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TXT_PAT_PMT_STREAM_TYPE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PAT_PMT_STREAM_TYPE.TextChanged
        Try
            For _LOC_1 = 0 To LSV_PID.Items.Count - 1
                If LSV_PID.Items(_LOC_1).SubItems(1).Text = LBL_PAT_PMT_SELECT_PID_PID.Text Then
                    LSV_PID.Items(_LOC_1).SubItems(3).Text = TXT_PAT_PMT_STREAM_TYPE.Text
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_ADD_PID_Click(sender As Object, e As EventArgs) Handles BTN_ADD_PID.Click
        Try
            If LSV_PID_IN_HANDLE Then Exit Sub
            LSV_PID_IN_HANDLE = True
            Dim _LOC_1 As Integer = 0
            If TXT_ADD_PID.Text.ToLower.StartsWith("0x") Then
                _LOC_1 = Convert.ToInt32(TXT_ADD_PID.Text.ToLower.Split("x")(1), 16)
            Else
                If IsNumeric(TXT_ADD_PID.Text) Then
                    _LOC_1 = Int(TXT_ADD_PID.Text)
                End If
            End If
            Dim _LOC_2 As Boolean = True
            For _LOC_3 = 0 To LSV_PID.Items.Count - 1
                If LSV_PID.Items(_LOC_3).SubItems(1).Text = _LOC_1 Then
                    _LOC_2 = False
                    Exit For
                End If
            Next
            If _LOC_2 Then
                Dim _LOC_4 As Integer = LSV_PID.Items.Count
                LSV_PID.Items.Add("")
                LSV_PID.Items(_LOC_4).SubItems.Add(_LOC_1)
                LSV_PID.Items(_LOC_4).SubItems.Add("0x" & Hex(_LOC_1))
                LSV_PID.Items(_LOC_4).SubItems.Add("")
                TXT_ADD_PID.Clear()
            End If
        Catch ex As Exception

        Finally
            LSV_PID_IN_HANDLE = False
        End Try
    End Sub

    Private Sub BTN_PID_MOVE_UP_Click(sender As Object, e As EventArgs) Handles BTN_PID_MOVE_UP.Click
        Try
            If LSV_PID_IN_HANDLE Then Exit Sub
            LSV_PID_IN_HANDLE = True
            Dim _LOC_1 As Integer = LSV_PID.SelectedItems(0).Index
            Dim _LOC_2 = LSV_PID.Items(_LOC_1)
            If _LOC_1 > 0 Then
                LSV_PID.Items.RemoveAt(_LOC_1)
                LSV_PID.Items.Insert(_LOC_1 - 1, _LOC_2)
            End If
        Catch ex As Exception

        Finally
            LSV_PID_IN_HANDLE = False
        End Try
    End Sub

    Private Sub BTN_PID_MOVE_DOWN_Click(sender As Object, e As EventArgs) Handles BTN_PID_MOVE_DOWN.Click
        Try
            If LSV_PID_IN_HANDLE Then Exit Sub
            LSV_PID_IN_HANDLE = True
            Dim _LOC_1 As Integer = LSV_PID.SelectedItems(0).Index
            Dim _LOC_2 = LSV_PID.Items(_LOC_1)
            If _LOC_1 < LSV_PID.Items.Count - 1 Then
                LSV_PID.Items.RemoveAt(_LOC_1)
                LSV_PID.Items.Insert(_LOC_1 + 1, _LOC_2)
            End If
        Catch ex As Exception

        Finally
            LSV_PID_IN_HANDLE = False
        End Try
    End Sub

    Private Sub BTN_REMOVE_PID_Click(sender As Object, e As EventArgs) Handles BTN_REMOVE_PID.Click
        Try
            If LSV_PID_IN_HANDLE Then Exit Sub
            LSV_PID_IN_HANDLE = True

            For _LOC_1 = LSV_PID.Items.Count - 1 To 0 Step -1
                If LSV_PID.Items(_LOC_1).Checked Then LSV_PID.Items(_LOC_1).Remove()
            Next
        Catch ex As Exception

        Finally
            LSV_PID_IN_HANDLE = False
        End Try
    End Sub

    Private Sub LSV_PID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSV_PID.SelectedIndexChanged
        Try
            If LSV_PID_IN_HANDLE Then Exit Sub
            LSV_PID_IN_HANDLE = True
            For _LOC_1 = 0 To LSV_PID.SelectedItems.Count - 1
                LSV_PID.SelectedItems(_LOC_1).Checked = True
            Next
        Catch ex As Exception

        Finally
            LSV_PID_IN_HANDLE = False
        End Try
    End Sub

    Private Sub CHK_SELECT_ALL_PID_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SELECT_ALL_PID.CheckedChanged
        Try
            If LSV_PID_IN_HANDLE Then Exit Sub
            LSV_PID_IN_HANDLE = True
            For _LOC_1 = 0 To LSV_PID.Items.Count - 1
                If CHK_SELECT_ALL_PID.Checked Then
                    LSV_PID.Items(_LOC_1).Checked = True
                Else
                    LSV_PID.Items(_LOC_1).Checked = False
                End If
            Next
        Catch ex As Exception

        Finally
            LSV_PID_IN_HANDLE = False
        End Try
    End Sub

    Private Sub TXT_ANALYZE_PACKET_HEADER_TextChanged(sender As Object, e As EventArgs) Handles TXT_ANALYZE_PACKET_HEADER.TextChanged
        Try
            If TXT_ANALYZE_PACKET_HEADER.Text.Length >= 6 Then
                Dim PACKET_HEADER As Byte() = HexToBytes("47" & TXT_ANALYZE_PACKET_HEADER.Text.ToUpper.Substring(0, 6))
                Dim PACKET_HEADER_BIT As New BitArray(PACKET_HEADER)
                Dim PACKET_PID As Integer = (PACKET_HEADER(1) And &H1F) << 8 Or PACKET_HEADER(2)

                Dim _LOC_1 As String = ""
                _LOC_1 += "Sync byte: 0x47" & vbCrLf

                _LOC_1 += "Transport error indicator: " & Int(PACKET_HEADER_BIT(15)) & vbCrLf
                _LOC_1 += "Payload unit start indicator: " & Int(PACKET_HEADER_BIT(14)) & vbCrLf
                _LOC_1 += "Transport priority: " & Int(PACKET_HEADER_BIT(13)) & vbCrLf
                _LOC_1 += "PID: " & PACKET_PID & " (0x" & Hex(PACKET_PID) & ")" & vbCrLf

                Dim _LOC_2 As String = Int(PACKET_HEADER_BIT(31)).ToString & Int(PACKET_HEADER_BIT(30)).ToString
                Dim _LOC_3 As String = ""
                If _LOC_2 = "10" Then _LOC_3 = " (even)"
                If _LOC_2 = "11" Then _LOC_3 = " (odd)"
                If _LOC_2 = "00" Then _LOC_3 = " (none)"
                _LOC_1 += "Transport scrambling control: " & _LOC_2 & _LOC_3 & vbCrLf

                _LOC_2 = Int(PACKET_HEADER_BIT(29)).ToString & Int(PACKET_HEADER_BIT(28)).ToString
                _LOC_3 = ""
                If _LOC_2 = "10" Then _LOC_3 = " (no payload)"
                If _LOC_2 = "11" Then _LOC_3 = " (adaptation used)"
                If _LOC_2 = "01" Then _LOC_3 = " (no adaptation)"
                _LOC_1 += "Adaptation field control: " & _LOC_2 & _LOC_3 & vbCrLf

                Dim _LOC_4 As Integer = Int(PACKET_HEADER_BIT(27)) * 8 + Int(PACKET_HEADER_BIT(26)) * 4 + Int(PACKET_HEADER_BIT(25)) * 2 + Int(PACKET_HEADER_BIT(24))
                _LOC_1 += "Continuity counter: " & _LOC_4.ToString.PadLeft(2, "0") & " (0x" & BytesToHex(New Byte() {_LOC_4}) & ")"

                If TXT_ANALYZE_PACKET_HEADER.Text.Length >= 8 And PACKET_HEADER_BIT(29) And PACKET_HEADER_BIT(28) Then
                    _LOC_4 = Int(HexToBytes(TXT_ANALYZE_PACKET_HEADER.Text.ToUpper.Substring(6, 2))(0))
                    _LOC_1 += vbCrLf & "Adaptation field length: " & _LOC_4.ToString.PadLeft(2, "0") & " (0x" & BytesToHex(New Byte() {_LOC_4}) & ")"
                End If

                TXT_ANALYZE_RESULT.Text = _LOC_1
            Else
                TXT_ANALYZE_RESULT.Clear()
            End If
        Catch ex As Exception
            TXT_ANALYZE_RESULT.Clear()
        End Try
    End Sub

    Private Sub TXT_PAT_PMT_TRANSPO_STREAM_ID_TextChanged(sender As Object, e As EventArgs) Handles TXT_PAT_PMT_TRANSPO_STREAM_ID.TextChanged
        Try
            If TXT_SYNC_IN_HANDLE Then Exit Sub
            TXT_SYNC_IN_HANDLE = True
            TXT_SDT_TRANSPO_STREAM_ID.Text = TXT_PAT_PMT_TRANSPO_STREAM_ID.Text
        Catch ex As Exception

        Finally
            TXT_SYNC_IN_HANDLE = False
        End Try
    End Sub

    Private Sub TXT_SDT_TRANSPO_STREAM_ID_TextChanged(sender As Object, e As EventArgs) Handles TXT_SDT_TRANSPO_STREAM_ID.TextChanged
        Try
            If TXT_SYNC_IN_HANDLE Then Exit Sub
            TXT_SYNC_IN_HANDLE = True
            TXT_PAT_PMT_TRANSPO_STREAM_ID.Text = TXT_SDT_TRANSPO_STREAM_ID.Text
        Catch ex As Exception

        Finally
            TXT_SYNC_IN_HANDLE = False
        End Try
    End Sub

    Private Sub TXT_PAT_PMT_PROGRAM_NUMBER_TextChanged(sender As Object, e As EventArgs) Handles TXT_PAT_PMT_PROGRAM_NUMBER.TextChanged
        Try
            If TXT_SYNC_IN_HANDLE Then Exit Sub
            TXT_SYNC_IN_HANDLE = True
            TXT_SDT_SERVICE_ID.Text = TXT_PAT_PMT_PROGRAM_NUMBER.Text
        Catch ex As Exception

        Finally
            TXT_SYNC_IN_HANDLE = False
        End Try
    End Sub

    Private Sub TXT_SDT_SERVICE_ID_TextChanged(sender As Object, e As EventArgs) Handles TXT_SDT_SERVICE_ID.TextChanged
        Try
            If TXT_SYNC_IN_HANDLE Then Exit Sub
            TXT_SYNC_IN_HANDLE = True
            TXT_PAT_PMT_PROGRAM_NUMBER.Text = TXT_SDT_SERVICE_ID.Text
        Catch ex As Exception

        Finally
            TXT_SYNC_IN_HANDLE = False
        End Try
    End Sub

    Private Sub BTN_CUTTER_ADD_Click(sender As Object, e As EventArgs) Handles BTN_CUTTER_ADD.Click
        Try
            If TXT_CUTTER_TASK_NAME.Text = "" Then Exit Sub
            CUTTER_EXPR_TOTAL_DURATION = CUTTER_EXPR(TXT_CUTTER_TOTAL_DURATION.Text, True)

            Dim _LOC_1 As Integer = LSV_CUTTER.Items.Count
            LSV_CUTTER.Items.Add(TXT_CUTTER_TASK_NAME.Text)
            LSV_CUTTER.Items(_LOC_1).SubItems.Add(CUTTER_EXPR(TXT_CUTTER_START.Text))
            LSV_CUTTER.Items(_LOC_1).SubItems.Add(CUTTER_EXPR(TXT_CUTTER_END.Text))
            TXT_CUTTER_TASK_NAME.Clear()
            TXT_CUTTER_START.Clear()
            TXT_CUTTER_END.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CUTTER_REMOVE_Click(sender As Object, e As EventArgs) Handles BTN_CUTTER_REMOVE.Click
        Try
            For Each _LOC_1 In LSV_CUTTER.SelectedItems
                LSV_CUTTER.Items.Remove(_LOC_1)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_INPUT_CONCAT_Click(sender As Object, e As EventArgs) Handles BTN_INPUT_CONCAT.Click
        Try
            Concatenate.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Function CUTTER_EXPR(Input As String, Optional ReturnSeconds As Boolean = False)
        Try
            Input = Input.ToLower.Replace("：", ":").Replace("k", "000").Replace("m", "000000").Replace("g", "000000000")

            If Input.StartsWith("@") Then
                Dim _LOC_1 As String = ""
                Dim _LOC_2 As String() = Input.Split("@")
                If _LOC_2.Count > 1 Then
                    For _LOC_3 = 0 To _LOC_2(1).Length - 2 Step 2
                        _LOC_1 += _LOC_2(1).Substring(_LOC_3, 2) & ":"
                    Next
                    _LOC_1 = _LOC_1.Substring(0, _LOC_1.Length - 1)
                    Input = _LOC_1
                End If
            End If

            Dim _LOC_5 As Integer = 0
            If Input.Contains(":") Then
                Dim _LOC_4 As String() = Input.Split(":")
                For _LOC_6 = 0 To _LOC_4.Count - 1
                    _LOC_5 += _LOC_4(_LOC_6) * (60 ^ (_LOC_4.Count - _LOC_6 - 1))
                Next
            End If

            If ReturnSeconds Then
                Return _LOC_5
            Else
                If Input.Contains(":") Then
                    Input = _LOC_5 & "/" & CUTTER_EXPR_TOTAL_DURATION
                End If
                If Input.Contains("%") Then
                    Input = Input.Split("%")(0) & "/100"
                End If
                If Input.Contains("/") Then
                    Return Convert.ToInt64(Convert.ToInt64(Input.Split("/")(0)) / Convert.ToInt64(Input.Split("/")(1)) * Convert.ToInt64(LBL_CUTTER_TOTAL_PACKETS_COUNT.Text))
                End If
            End If

            Return Convert.ToInt64(Input)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub PLAY_SOUND_OK()
        Try
            Dim _LOC_1 As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim _LOC_2 As System.IO.Stream = _LOC_1.GetManifestResourceStream("TSFinish.OK.wav")
            Dim _LOC_3 As New SoundPlayer(_LOC_2)
            _LOC_3.Play()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LBL_INPUT_SOURCE_FILE_Click(sender As Object, e As EventArgs) Handles LBL_INPUT_SOURCE_FILE.Click
        Try
            Process.Start("explorer.exe", New IO.FileInfo(TXT_INPUT_SOURCE_FILE.Text).DirectoryName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LBL_OUTPUT_DEST_FILE_Click(sender As Object, e As EventArgs) Handles LBL_OUTPUT_DEST_FILE.Click
        Try
            Process.Start("explorer.exe", New IO.FileInfo(TXT_OUTPUT_DEST_FILE.Text).DirectoryName)
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetOverwritePID(Input As Integer) As Integer
        Try
            Dim _LOC_1 As String = Regex.Match(PID_REWRITE, "\<" & Input & "\|(\d+)\>", RegexOptions.None).Groups(1).Value
            If IsNumeric(_LOC_1) Then
                Return Int(_LOC_1)
            Else
                Return Input
            End If
        Catch ex As Exception
            Return Input
        End Try
    End Function

    Private Function NormalizePID(Input As String) As Integer
        Try
            If Input.ToUpper.StartsWith("0X") Then
                Dim _LOC_1 As String = Input.ToUpper.Split("X")(1)
                If _LOC_1.Length Mod 2 = 1 Then _LOC_1 = "0" & _LOC_1
                Return Int(CLng("&H" & _LOC_1))
            Else
                Return Int(Input)
            End If
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Sub BTN_PID_REWRITE_ADD_Click(sender As Object, e As EventArgs) Handles BTN_PID_REWRITE_ADD.Click
        Try
            If TXT_PID_ORIGINAL.Text = "" Or TXT_PID_OVERWRITE.Text = "" Then Exit Sub
            LSV_PID_REWRITE.Items.Add(TXT_PID_ORIGINAL.Text)
            LSV_PID_REWRITE.Items(LSV_PID_REWRITE.Items.Count - 1).SubItems.Add(TXT_PID_OVERWRITE.Text)
            TXT_PID_ORIGINAL.Clear()
            TXT_PID_OVERWRITE.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_PID_REWRITE_REMOVE_Click(sender As Object, e As EventArgs) Handles BTN_PID_REWRITE_REMOVE.Click
        Try
            For Each _LOC_1 In LSV_PID_REWRITE.SelectedItems
                LSV_PID_REWRITE.Items.Remove(_LOC_1)
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class
