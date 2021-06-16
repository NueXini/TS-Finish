Public Class Concatenate
    Private Sub BTN_CONCAT_OK_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_OK.Click
        Try
            If LST_CONCAT_FILE.Items.Count < 1 Then Exit Sub
            Dim _LOC_1 As String = "CONCAT:"
            For _LOC_2 = 0 To LST_CONCAT_FILE.Items.Count - 1
                _LOC_1 += LST_CONCAT_FILE.Items(_LOC_2) & "|"
            Next
            MainUI.TXT_INPUT_SOURCE_FILE.Text = _LOC_1.Substring(0, _LOC_1.Length - 1)
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Concatenate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            e.Cancel = 1
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Concatenate_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Concatenate_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Try
            Dim DragFilePath As String() = e.Data.GetData(DataFormats.FileDrop)
            For Each _LOC_1 In DragFilePath
                LST_CONCAT_FILE.Items.Add(_LOC_1)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_IMPORT_FILES_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_IMPORT_FILES.Click
        Try
            If OFD_CONCAT_IMPORT.ShowDialog = DialogResult.OK Then
                For Each _LOC_1 In OFD_CONCAT_IMPORT.FileNames
                    LST_CONCAT_FILE.Items.Add(_LOC_1)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_REMOVE_ALL_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_REMOVE_ALL.Click
        Try
            LST_CONCAT_FILE.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_REMOVE_FILES_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_REMOVE_FILE.Click
        Try
            For Each _LOC_1 In LST_CONCAT_FILE.SelectedItems
                LST_CONCAT_FILE.Items.Remove(_LOC_1)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_MOVE_UP_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_MOVE_UP.Click
        Try
            If LST_CONCAT_FILE.SelectedIndex > 0 Then
                Dim _LOC_1 As Integer = LST_CONCAT_FILE.SelectedIndex - 1
                LST_CONCAT_FILE.Items.Insert(_LOC_1, LST_CONCAT_FILE.SelectedItem)
                LST_CONCAT_FILE.Items.RemoveAt(LST_CONCAT_FILE.SelectedIndex)
                LST_CONCAT_FILE.SelectedIndex = _LOC_1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_MOVE_DOWN_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_MOVE_DOWN.Click
        Try
            If LST_CONCAT_FILE.SelectedIndex < LST_CONCAT_FILE.Items.Count - 1 Then
                Dim _LOC_1 As Integer = LST_CONCAT_FILE.SelectedIndex + 2
                LST_CONCAT_FILE.Items.Insert(_LOC_1, LST_CONCAT_FILE.SelectedItem)
                LST_CONCAT_FILE.Items.RemoveAt(LST_CONCAT_FILE.SelectedIndex)
                LST_CONCAT_FILE.SelectedIndex = _LOC_1 - 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_MOVE_TOP_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_MOVE_TOP.Click
        Try
            Dim _LOC_1 As Integer = LST_CONCAT_FILE.SelectedIndex
            Dim _LOC_2 As String = LST_CONCAT_FILE.Items(_LOC_1)
            LST_CONCAT_FILE.Items.RemoveAt(_LOC_1)
            LST_CONCAT_FILE.Items.Insert(0, _LOC_2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_MOVE_BOTTOM_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_MOVE_BOTTOM.Click
        Try
            Dim _LOC_1 As Integer = LST_CONCAT_FILE.SelectedIndex
            Dim _LOC_2 As String = LST_CONCAT_FILE.Items(_LOC_1)
            LST_CONCAT_FILE.Items.RemoveAt(_LOC_1)
            LST_CONCAT_FILE.Items.Add(_LOC_2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CONCAT_START_COPY_Click(sender As Object, e As EventArgs) Handles BTN_CONCAT_START_COPY.Click
        Try
            If LST_CONCAT_FILE.Items.Count < 1 Then Exit Sub
            If SFD_CONCAT_COPY.ShowDialog = DialogResult.OK Then
                Dim _LOC_1 As String = ""
                For Each _LOC_2 In LST_CONCAT_FILE.Items
                    _LOC_1 += Chr(34) & _LOC_2 & Chr(34) & "+"
                Next
                Process.Start("cmd.exe", "/K copy /B " & _LOC_1.Substring(0, _LOC_1.Length - 1) & " " & Chr(34) & SFD_CONCAT_COPY.FileName & Chr(34))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Concatenate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Localization()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Localization()
        Try
            If MainUI.GLOBAL_LANGUAGE = "zh-CN" Then
                Text = "合并文件"
                BTN_CONCAT_IMPORT_FILES.Text = "导入文件 (&I)"
                BTN_CONCAT_REMOVE_FILE.Text = "移除文件 (&R)"
                BTN_CONCAT_REMOVE_ALL.Text = "移除全部 (&A)"
                BTN_CONCAT_MOVE_UP.Text = "向上移动 (&U)"
                BTN_CONCAT_MOVE_DOWN.Text = "向下移动 (&D)"
                BTN_CONCAT_MOVE_TOP.Text = "移至顶部 (&T)"
                BTN_CONCAT_MOVE_BOTTOM.Text = "移至底部 (&B)"
                BTN_CONCAT_START_COPY.Text = "开始复制 (&C)"
                BTN_CONCAT_OK.Text = "确定 (&O)"
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class