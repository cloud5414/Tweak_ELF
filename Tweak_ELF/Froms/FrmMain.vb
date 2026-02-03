#Region "名前空間のインポート"
Imports Microsoft.Win32
Imports System.Runtime.InteropServices

#End Region
Public Class FrmMain
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '各コントロールへ値を設定する
            SetControlValues()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ML_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ML_Exit.Click
        Try
            'アプリケーションを終了する
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ML_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ML_Reset.Click
        'ユーザにリセットするか問い合わせる
        'OK -> リセットする
        'キャンセル -> プロシージャを抜ける
        If (MsgBox("デバイスをリセットします。" + vbNewLine + "よろしいですか？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "デバイスのリセット") = MsgBoxResult.Ok) Then
            SetSystemPowerState(Nothing, POWER_STATE_RESET, 0)
        End If

    End Sub

    Private Sub ML_TrunOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ML_TurnOff.Click
        'ユーザにサスペンドするか問い合わせる
        'OK -> サスペンドする
        'キャンセル -> プロシージャを抜ける
        If (MsgBox("サスペンド状態にしますか？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "デバイスのサスペンド") = MsgBoxResult.Ok) Then
            GwesPowerOffSystem()
        End If
    End Sub

    Private Sub ML_WriteValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ML_WriteValues.Click
        '変更した内容を書き込む
        '変更内容をシステムへ反映させるか問い合わせる
        'はい -> コントロールの値を取得し、レジストリへ書き込む
        'いいえ -> プロシージャを抜ける
        Try
            If (MsgBox("内容をシステムへ反映します。" & vbNewLine & "よろしいですか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "設定の反映")) = MsgBoxResult.Yes Then
                GetControlValues()
                WriteRegistryValues()
                'デバイスのリセットを促す
                'はい -> デバイスをリセットする
                'いいえ -> プロシージャを抜ける
                If (MsgBox("システムへ反映しました。" & vbNewLine & "リセットもしますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "デバイスのリセット")) = MsgBoxResult.Yes Then
                    SetSystemPowerState(Nothing, POWER_STATE_RESET, 0)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ML_DisposeValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ML_DisposeValues.Click
        '変更した内容を破棄する
        SetControlValues()

    End Sub

    Private Sub ML_Reload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ML_Reload.Click
        'レジストリから値を再取得する
        LoadRegistryValues()
        SetControlValues()

    End Sub

    Private Sub MR_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MR_About.Click
        'アプリケーションバージョンを表示
        Dim _About As New FrmAbout
        _About.Show()

    End Sub

    Public Sub GetControlValues()
        Try
            'コントロールから値を取得し、変数へ値を設定する
            'SHカメラ設定
            AudioEnable = Ch_AudioEnable.CheckState
            MobileMode = Ch_MobileMode.CheckState
            StillSize = Cbx_StillSize.SelectedIndex
            StillQuality = Cbx_StillQuality.SelectedIndex
            Store = Cbx_Store.SelectedIndex
            VideoTime = Cbx_VideoTime.SelectedIndex

            'Misc設定
            DisableSHReceive = Ch_DisableSHRecive.CheckState
            DisableSetLSbySlide = Ch_DisableSetLSbySlide.CheckState
            BFlagSlide = Ch_BFlagSlide.CheckState

            'GFSDK設定
            USE_DSP = Ch_GFSDK_USE_DSP.CheckState
            USE_DSP_INTERRUPT = Ch_GFSDK_USE_DSP_INTERRUPT.CheckState
            VC1_DEC_USE_DSP = Ch_GFSDK_VC1_DEC_USE_DSP.CheckState
            H264_DEC_USE_DSP = Ch_GFSDK_H264_DEC_USE_DSP.CheckState
            MP4_DEC_USE_DSP = Ch_GFSDK_MP4_DEC_USE_DSP.CheckState
            NVWMV_DOUBLEBUFFER_OVERLAY = Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY.CheckState
            NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED = Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED.CheckState
            GFSDK_PLL2_FREQ = Cbx_PLL2_FREQ.SelectedValue

            'NVDDI
            ENHANCE_2D_PERF = Ch_ENHANCE_2D_PERF.CheckState
            USE_VIDEO_MEMORY_FOR_GPE = Ch_USE_VIDEO_MEMORY_FOR_GPE.CheckState
            EMBEDED_LCD = Cbx_EMBEDED_LCD.Items.Item(Cbx_EMBEDED_LCD.SelectedIndex)

            '無線LAN設定
            WLAN_ScanInterval = Nu_WLANScanInterval.Value

            'リモート
            BitmapPersistCacheSize = Nu_BitmapPersistCacheSize.Value
            BitmapCacheSize = Nu_BitmapCacheSize.Value
            MinSendInterval = Nu_MinSendInterval.Value

            'GUI - 表示
            If (Ch_EnableRealVGA.CheckState = CheckState.Unchecked) Then
                DisplayMode = DisplayDPI(0)
            Else
                DisplayMode = DisplayDPI(1)

            End If

            EnableWindowAnimation = Ch_EnableWindowAnimation.CheckState

            If (Ch_EnableMenuAnimation.Checked = True) Then
                EnableMenuAnimation = 6
            Else
                EnableMenuAnimation = 0
            End If

            AllowChange = Ch_EnableSip.CheckState

            'GUI - フォント
            FontCacheSize = CacheSize(Cbx_FontCacheSize.SelectedIndex)
            NoClearType = Ch_NoClearType.CheckState
            EnableClearTypeIEText = Ch_EnableClearTypeIEText.CheckState
            ClearTypeOffOnRotation = Ch_ClearTypeOffOnRotation.CheckState

            'ストレージ
            If (Cbx_FileSystemCacheSize.SelectedIndex = 0) Then
                FileSystemCacheSize = 0
            Else
                FileSystemCacheSize = 4096
            End If

            'USB
            USBMode = USBModeName(Cbx_USBMode.SelectedIndex)

            'Bluetooth
            A2dpSampleRate = SampleRate(Cbx_A2dpSampleRate.SelectedIndex)
            A2dpStereoMode = Cbx_A2dpStereoMode.SelectedIndex
            A2dpBitPool = Nu_A2dpBitPool.Value
            A2dpMaxBitPool = Nu_A2dpMaxBitPool.Value

            'HID - マウス
            MouseCursorTimeout = MouseCursorShowTime(Cbx_MouseCursor.SelectedIndex)

            '音量
            OutputVolume = OutputVolumeSize(Trb_OutVolume.Value)

            'TCP - RWIN
            TcpWindowSize = Nu_RWIN.Value
            TcpWindowSize = Txt_RWIN.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SetControlValues()
        '各コントロールへ値を設定する。
        Try
            'デバイス情報
            Lbl_Platform.Text = System.Environment.OSVersion.ToString & " " & PlatformDetector.GetPlatform().ToString()
            Lbl_AkuVer.Text = "AKU Ver" & AKU

            'SHカメラ設定
            Ch_AudioEnable.Checked = AudioEnable
            Ch_MobileMode.Checked = MobileMode
            Cbx_StillSize.SelectedIndex = StillSize
            Cbx_StillQuality.SelectedIndex = StillQuality
            Cbx_Store.SelectedIndex = Store
            Cbx_VideoTime.SelectedIndex = VideoTime

            'Misc設定
            Ch_DisableSHRecive.Checked = DisableSHReceive
            Ch_DisableSetLSbySlide.Checked = DisableSetLSbySlide
            Ch_BFlagSlide.Checked = BFlagSlide

            'GFSDK設定
            Ch_GFSDK_USE_DSP.Checked = USE_DSP
            Ch_GFSDK_USE_DSP_INTERRUPT.Checked = USE_DSP_INTERRUPT
            Ch_GFSDK_VC1_DEC_USE_DSP.Checked = VC1_DEC_USE_DSP
            Ch_GFSDK_H264_DEC_USE_DSP.Checked = H264_DEC_USE_DSP
            Ch_GFSDK_MP4_DEC_USE_DSP.Checked = MP4_DEC_USE_DSP
            Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY.Checked = NVWMV_DOUBLEBUFFER_OVERLAY
            Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED.Checked = NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED
            Cbx_PLL2_FREQ.Items.Add(GFSDK_PLL2_FREQ)


            'GFSDK DSP を使用しないならば、関連する項目を無効にする
            If (Ch_GFSDK_USE_DSP.Checked = False) Then
                'Ch_GFSDK_USE_DSP_INTERRUPT.Enabled = False
                Ch_GFSDK_VC1_DEC_USE_DSP.Enabled = False
                Ch_GFSDK_H264_DEC_USE_DSP.Enabled = False
                Ch_GFSDK_MP4_DEC_USE_DSP.Enabled = False

            End If

            'NVDDI
            Ch_ENHANCE_2D_PERF.Checked = ENHANCE_2D_PERF
            Ch_USE_VIDEO_MEMORY_FOR_GPE.Checked = USE_VIDEO_MEMORY_FOR_GPE

            With Cbx_EMBEDED_LCD
                If EMBEDED_LCD = "ddi.dll" Then
                    '.Enabled = False
                    Ch_ENHANCE_2D_PERF.Enabled = False
                    Ch_USE_VIDEO_MEMORY_FOR_GPE.Enabled = False
                    .SelectedIndex = 0

                ElseIf EMBEDED_LCD = "nvddi.dll" Then
                    '.Enabled = False
                    .SelectedIndex = 1

                Else
                    .Enabled = False
                    .Items.Insert(2, EMBEDED_LCD)
                    .SelectedIndex = 2
                    Ch_ENHANCE_2D_PERF.Enabled = False
                    Ch_USE_VIDEO_MEMORY_FOR_GPE.Enabled = False

                End If
            End With


            '無線LAN設定
            Nu_WLANScanInterval.Value = WLAN_ScanInterval

            'リモート
            Nu_BitmapPersistCacheSize.Value = BitmapPersistCacheSize
            Nu_BitmapCacheSize.Value = BitmapCacheSize
            Nu_MinSendInterval.Value = MinSendInterval

            'GUI設定 - 表示
            With Ch_EnableRealVGA
                If (DisplayMode = DisplayDPI(0)) Then
                    .Checked = False
                Else
                    .Checked = True
                End If
            End With

            Ch_EnableWindowAnimation.CheckState = EnableWindowAnimation

            With Ch_EnableMenuAnimation
                If EnableMenuAnimation = 6 Then
                    .Checked = True
                Else
                    .Checked = False
                End If
            End With

            Ch_EnableSip.CheckState = AllowChange

            'GUI設定 - フォント
            With Cbx_FontCacheSize
                Select Case FontCacheSize
                    Case CacheSize(0) '規定値
                        .SelectedIndex = 0

                    Case CacheSize(1) '8 KB
                        .SelectedIndex = 1

                    Case CacheSize(2) '16KB
                        .SelectedIndex = 2

                    Case CacheSize(3) '32KB
                        .SelectedIndex = 3

                    Case CacheSize(4) '128KB
                        .SelectedIndex = 4

                    Case CacheSize(5) '1MB
                        .SelectedIndex = 5

                    Case CacheSize(6) '2MB
                        .SelectedIndex = 6

                    Case CacheSize(7) '4MB
                        .SelectedIndex = 7

                    Case CacheSize(8) '8MB
                        .SelectedIndex = 8

                    Case CacheSize(9) '16MB
                        .SelectedIndex = 9

                    Case Else 'それ以外は規定値を設定
                        .SelectedIndex = 0

                End Select
            End With

            Ch_NoClearType.CheckState = NoClearType
            Ch_EnableClearTypeIEText.CheckState = EnableClearTypeIEText
            Ch_ClearTypeOffOnRotation.CheckState = ClearTypeOffOnRotation

            'ストレージ
            Ch_EnableFileSystemCache.CheckState = EnableFileSystemCache
            With Cbx_FileSystemCacheSize
                Select Case FileSystemCacheSize
                    Case DiskCacheSize(0) '規定値
                        .SelectedIndex = 0

                    Case DiskCacheSize(1) '128KB
                        .SelectedIndex = 1

                    Case DiskCacheSize(2) '256KB
                        .SelectedIndex = 2

                    Case DiskCacheSize(3) '512KB
                        .SelectedIndex = 3

                    Case DiskCacheSize(4) '1MB
                        .SelectedIndex = 4

                    Case DiskCacheSize(5) '2MB
                        .SelectedIndex = 5

                    Case DiskCacheSize(6) '4MB
                        .SelectedIndex = 6

                    Case DiskCacheSize(7) '8MB
                        .SelectedIndex = 7

                    Case Else 'それ以外は規定値を設定
                        .SelectedIndex = 0

                End Select
            End With

            'USB

            If (USBState = 1) Then
                'USB接続中
                Cbx_USBMode.Enabled = False
                Lbl_USBStatus.Visible = True
            Else
                'USB未接続
                Cbx_USBMode.Enabled = True
                Lbl_USBStatus.Visible = False
            End If

            With Cbx_USBMode
                Select Case USBMode
                    Case USBModeName(0) 'ActiveSync (RemoteNDIS)
                        .SelectedIndex = 0

                    Case USBModeName(1) 'ActiveSync (シリアル接続)
                        .SelectedIndex = 1

                    Case USBModeName(2) 'USBモデム
                        .SelectedIndex = 2

                    Case USBModeName(3) 'マスストレージ (miniSD リーダライタ)
                        .SelectedIndex = 3

                    Case Else

                End Select
            End With

            'Bluetooth
            With Cbx_A2dpSampleRate
                Select Case A2dpSampleRate
                    Case SampleRate(0) '規定値
                        .SelectedIndex = 0

                    Case SampleRate(1) '44.1KHz
                        .SelectedIndex = 1

                    Case SampleRate(2) '48KHz
                        .SelectedIndex = 2

                End Select
            End With

            Cbx_A2dpStereoMode.SelectedIndex = A2dpStereoMode
            Nu_A2dpBitPool.Value = A2dpBitPool
            Nu_A2dpMaxBitPool.Value = A2dpMaxBitPool

            'マウスポインタ
            With Cbx_MouseCursor
                Select Case MouseCursorTimeout
                    Case MouseCursorShowTime(0) '1秒
                        .SelectedIndex = 0

                    Case MouseCursorShowTime(1) '5秒
                        .SelectedIndex = 1

                    Case MouseCursorShowTime(2) '10秒
                        .SelectedIndex = 2

                    Case MouseCursorShowTime(3) '15秒
                        .SelectedIndex = 3

                    Case MouseCursorShowTime(4) '30秒
                        .SelectedIndex = 4

                    Case MouseCursorShowTime(5) '60秒
                        .SelectedIndex = 5

                    Case MouseCursorShowTime(6) '120秒
                        .SelectedIndex = 6

                    Case MouseCursorShowTime(7)
                        .SelectedIndex = 7

                    Case Else
                        MsgBox(MouseCursorTimeout)
                        '.SelectedIndex = 0
                End Select
            End With

            '音量
            With Trb_OutVolume
                Select Case OutputVolume
                    Case OutputVolumeSize(0) '音量 Lv.0
                        .Value = 0

                    Case OutputVolumeSize(1) '音量 Lv.1
                        .Value = 1

                    Case OutputVolumeSize(2) '音量 Lv.2
                        .Value = 2

                    Case OutputVolumeSize(3) '音量 Lv.3
                        .Value = 3

                    Case OutputVolumeSize(4) '音量 Lv.4
                        .Value = 4

                    Case OutputVolumeSize(5) '音量 Lv.5
                        .Value = 5

                    Case Else
                        MsgBox(OutputVolume)
                        '.Value = 0
                End Select
            End With

            With Trb_InputVolume
                Select Case InputVolume
                    Case InputVolumeSize(0) '音量 Lv.0
                        .Value = 0

                    Case InputVolumeSize(1) '音量 Lv.1
                        .Value = 1

                    Case InputVolumeSize(2) '音量 Lv.2
                        .Value = 2

                    Case InputVolumeSize(3) '音量 Lv.3
                        .Value = 3

                    Case InputVolumeSize(4) '音量 Lv.4
                        .Value = 4

                    Case InputVolumeSize(5) '音量 Lv.5
                        .Value = 5

                    Case Else
                        MsgBox(InputVolumeSize)
                        '.Value = 0
                End Select
            End With

            'TCP - RWIN
            'MsgBox(TcpWindowSize)

            'Nu_RWIN.Value = CDec(TcpWindowSize)
            Txt_RWIN.Text = TcpWindowSize

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ch_GFSDK_USE_DSP_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_GFSDK_USE_DSP.CheckStateChanged
        'DSPを使わない場合は関連項目を無効にする
        If (Ch_GFSDK_USE_DSP.Checked = True) Then
            'Ch_GFSDK_USE_DSP_INTERRUPT.Enabled = True
            Ch_GFSDK_VC1_DEC_USE_DSP.Enabled = True
            Ch_GFSDK_H264_DEC_USE_DSP.Enabled = True
        Else
            'Ch_GFSDK_USE_DSP_INTERRUPT.Enabled = False
            Ch_GFSDK_VC1_DEC_USE_DSP.Enabled = False
            Ch_GFSDK_H264_DEC_USE_DSP.Enabled = False
        End If
    End Sub

    Private Sub Ch_EnableFileSystemCache_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_EnableFileSystemCache.CheckStateChanged
        If (Ch_EnableFileSystemCache.Checked = False) Then
            Cbx_FileSystemCacheSize.Enabled = False
        Else
            Cbx_FileSystemCacheSize.Enabled = True
        End If
    End Sub

    Private Sub Cbx_USBMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbx_USBMode.SelectedIndexChanged
        'USBがマスストレージモードなら注意書きを表示する
        If (Cbx_USBMode.SelectedIndex = 3) Then
            Lbl_MassNotice.Visible = True
        Else
            Lbl_MassNotice.Visible = False
        End If
    End Sub

    Private Sub Btn_DeleteTaskSwitch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_DeleteTaskSwitch.Click
        '最近使ったプログラム一覧を消去する
        Dim Int_ItemIndex As Integer = 0
        For Int_ItemIndex = 0 To 11
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Shell\TaskSwitch", Int_ItemIndex.ToString, "", Microsoft.Win32.RegistryValueKind.String)

        Next Int_ItemIndex
        MsgBox("履歴を削除しました" + vbNewLine + "リセット後に有効になります", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Tweak ELF")
    End Sub

    Private Sub Ch_MobileMode_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_MobileMode.CheckStateChanged
        If Ch_MobileMode.Checked = True Then
            Cbx_StillSize.SelectedIndex = 1

        End If

    End Sub

    Private Sub Cbx_StillSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbx_StillSize.SelectedIndexChanged
        If Cbx_StillSize.SelectedIndex = 2 Then
            Ch_MobileMode.Checked = False

        End If
    End Sub

    Private Sub Trb_OutVolume_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Trb_OutVolume.ValueChanged
        Lbl_OutputLevel.Text = "Volume Lv." + Trb_OutVolume.Value.ToString

    End Sub

    Private Sub Trb_InputVolume_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Trb_InputVolume.ValueChanged
        Lbl_InputLevel.Text = "Volume Lv." + Trb_InputVolume.Value.ToString

    End Sub

    Private Sub Cbx_EMBEDED_LCD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbx_EMBEDED_LCD.SelectedIndexChanged
        With Cbx_EMBEDED_LCD
            If .SelectedIndex = 0 Then
                Ch_ENHANCE_2D_PERF.Enabled = False
                Ch_USE_VIDEO_MEMORY_FOR_GPE.Enabled = False

            ElseIf .SelectedIndex = 1 Then
                Ch_ENHANCE_2D_PERF.Enabled = True
                Ch_USE_VIDEO_MEMORY_FOR_GPE.Enabled = True

            End If
        End With

    End Sub
End Class