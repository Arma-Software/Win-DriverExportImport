Public Class Form1

    Private Function exportAllDriversRecursive(path As String)
        Try
            Process.Start("powershell", "Export-WindowsDriver -Online -Destination " & path)
            pbExport.Visible = True
        Catch ex As Exception

        End Try
        Return True
    End Function

    Private Function importAllDriversRecursive(path As String)

        Try
            Process.Start("powershell", "Dism /online /Add-Driver /Driver:" & path & " /Recurse")
            pbImport.Visible = True
        Catch ex As Exception

        End Try

        Return True
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pbImport.Visible = False
        pbExport.Visible = False

        Dim i As Integer = 0

        For Each s As String In Environment.GetCommandLineArgs()
            If i > 0 Then
                Select Case s
                    Case "import"
                        importAllDriversRecursive(Environment.GetCommandLineArgs(2).ToString())
                        Me.Close()
                    Case "export"
                        exportAllDriversRecursive(Environment.GetCommandLineArgs(2).ToString())
                        Me.Close()
                End Select
            End If
            i += 1
        Next

    End Sub

    Private Sub bExportStart_Click(sender As Object, e As EventArgs) Handles bExportStart.Click

        exportAllDriversRecursive(txtExportToFolderPath.Text.ToString())

    End Sub

    Private Sub bImportStart_Click(sender As Object, e As EventArgs) Handles bImportStart.Click

        importAllDriversRecursive(txtImportFromFolderPath.Text.ToString())

    End Sub

    Private Sub bImportChoose_Click(sender As Object, e As EventArgs) Handles bImportChoose.Click

        pbImport.Visible = False
        pbExport.Visible = False

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            txtImportFromFolderPath.Text = FolderBrowserDialog1.SelectedPath.ToString()

        End If

    End Sub

    Private Sub bExportChoose_Click(sender As Object, e As EventArgs) Handles bExportChoose.Click

        pbImport.Visible = False
        pbExport.Visible = False

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            txtExportToFolderPath.Text = FolderBrowserDialog1.SelectedPath.ToString()

        End If

    End Sub
End Class
