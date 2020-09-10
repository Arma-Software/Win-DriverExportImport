<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.bExportChoose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExportToFolderPath = New System.Windows.Forms.TextBox()
        Me.pbExport = New System.Windows.Forms.PictureBox()
        Me.bExportStart = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bImportChoose = New System.Windows.Forms.Button()
        Me.txtImportFromFolderPath = New System.Windows.Forms.TextBox()
        Me.pbImport = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bImportStart = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.pbImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(483, 185)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.bExportChoose)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtExportToFolderPath)
        Me.TabPage1.Controls.Add(Me.pbExport)
        Me.TabPage1.Controls.Add(Me.bExportStart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(475, 159)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Export"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'bExportChoose
        '
        Me.bExportChoose.Location = New System.Drawing.Point(313, 21)
        Me.bExportChoose.Name = "bExportChoose"
        Me.bExportChoose.Size = New System.Drawing.Size(28, 23)
        Me.bExportChoose.TabIndex = 5
        Me.bExportChoose.Text = "..."
        Me.bExportChoose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Export To Folder:"
        '
        'txtExportToFolderPath
        '
        Me.txtExportToFolderPath.Location = New System.Drawing.Point(11, 23)
        Me.txtExportToFolderPath.Name = "txtExportToFolderPath"
        Me.txtExportToFolderPath.Size = New System.Drawing.Size(296, 20)
        Me.txtExportToFolderPath.TabIndex = 3
        '
        'pbExport
        '
        Me.pbExport.Image = Global.DriverExportImport.My.Resources.Resources.iconfinder_Thumbs_Up_669646
        Me.pbExport.Location = New System.Drawing.Point(347, 6)
        Me.pbExport.Name = "pbExport"
        Me.pbExport.Size = New System.Drawing.Size(120, 112)
        Me.pbExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbExport.TabIndex = 2
        Me.pbExport.TabStop = False
        '
        'bExportStart
        '
        Me.bExportStart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bExportStart.Location = New System.Drawing.Point(3, 124)
        Me.bExportStart.Name = "bExportStart"
        Me.bExportStart.Size = New System.Drawing.Size(469, 32)
        Me.bExportStart.TabIndex = 1
        Me.bExportStart.Text = "Export"
        Me.bExportStart.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.bImportChoose)
        Me.TabPage2.Controls.Add(Me.txtImportFromFolderPath)
        Me.TabPage2.Controls.Add(Me.pbImport)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.bImportStart)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(475, 159)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Import"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bImportChoose
        '
        Me.bImportChoose.Location = New System.Drawing.Point(315, 22)
        Me.bImportChoose.Name = "bImportChoose"
        Me.bImportChoose.Size = New System.Drawing.Size(28, 23)
        Me.bImportChoose.TabIndex = 5
        Me.bImportChoose.Text = "..."
        Me.bImportChoose.UseVisualStyleBackColor = True
        '
        'txtImportFromFolderPath
        '
        Me.txtImportFromFolderPath.Location = New System.Drawing.Point(11, 24)
        Me.txtImportFromFolderPath.Name = "txtImportFromFolderPath"
        Me.txtImportFromFolderPath.Size = New System.Drawing.Size(296, 20)
        Me.txtImportFromFolderPath.TabIndex = 4
        '
        'pbImport
        '
        Me.pbImport.Image = Global.DriverExportImport.My.Resources.Resources.iconfinder_Thumbs_Up_669646
        Me.pbImport.Location = New System.Drawing.Point(349, 6)
        Me.pbImport.Name = "pbImport"
        Me.pbImport.Size = New System.Drawing.Size(120, 112)
        Me.pbImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImport.TabIndex = 3
        Me.pbImport.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Import Form Folder:"
        '
        'bImportStart
        '
        Me.bImportStart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bImportStart.Location = New System.Drawing.Point(3, 124)
        Me.bImportStart.Name = "bImportStart"
        Me.bImportStart.Size = New System.Drawing.Size(469, 32)
        Me.bImportStart.TabIndex = 0
        Me.bImportStart.Text = "Import"
        Me.bImportStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 185)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pbExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pbImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents bExportChoose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExportToFolderPath As TextBox
    Friend WithEvents pbExport As PictureBox
    Friend WithEvents bExportStart As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents bImportStart As Button
    Friend WithEvents pbImport As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bImportChoose As Button
    Friend WithEvents txtImportFromFolderPath As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
