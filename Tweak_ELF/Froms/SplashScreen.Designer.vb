<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SplashScreen
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Lbl_AppTitle = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Lbl_AppTitle
        '
        Me.Lbl_AppTitle.Location = New System.Drawing.Point(19, 35)
        Me.Lbl_AppTitle.Name = "Lbl_AppTitle"
        Me.Lbl_AppTitle.Size = New System.Drawing.Size(114, 33)
        Me.Lbl_AppTitle.Text = "Label1"
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(160, 120)
        Me.Controls.Add(Me.Lbl_AppTitle)
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.Text = "SplashScreen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_AppTitle As System.Windows.Forms.Label
End Class
