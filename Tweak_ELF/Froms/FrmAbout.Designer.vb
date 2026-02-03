<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmAbout
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer
    Private MainMenu As System.Windows.Forms.MainMenu

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.LblAppName = New System.Windows.Forms.Label
        Me.LblVersion = New System.Windows.Forms.Label
        Me.Lbl_Copyright = New System.Windows.Forms.Label
        Me.InputPanel = New Microsoft.WindowsCE.Forms.InputPanel
        Me.SuspendLayout()
        '
        'LblAppName
        '
        Me.LblAppName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.LblAppName.Location = New System.Drawing.Point(9, 10)
        Me.LblAppName.Name = "LblAppName"
        Me.LblAppName.Size = New System.Drawing.Size(117, 23)
        Me.LblAppName.Text = "Tweak ELF"
        '
        'LblVersion
        '
        Me.LblVersion.Location = New System.Drawing.Point(9, 42)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(82, 19)
        Me.LblVersion.Text = "Version"
        '
        'Lbl_Copyright
        '
        Me.Lbl_Copyright.Location = New System.Drawing.Point(9, 71)
        Me.Lbl_Copyright.Name = "Lbl_Copyright"
        Me.Lbl_Copyright.Size = New System.Drawing.Size(246, 20)
        Me.Lbl_Copyright.Text = "Copyright (C) ProjectSkynet 2007"
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(320, 188)
        Me.Controls.Add(Me.Lbl_Copyright)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblAppName)
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu
        Me.MinimizeBox = False
        Me.Name = "FrmAbout"
        Me.Text = "About This..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblAppName As System.Windows.Forms.Label
    Friend WithEvents LblVersion As System.Windows.Forms.Label
    Friend WithEvents Lbl_Copyright As System.Windows.Forms.Label
    Friend WithEvents InputPanel As Microsoft.WindowsCE.Forms.InputPanel
End Class
