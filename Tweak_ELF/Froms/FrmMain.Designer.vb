<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.ML_File = New System.Windows.Forms.MenuItem
        Me.ML_WriteValues = New System.Windows.Forms.MenuItem
        Me.ML_DisposeValues = New System.Windows.Forms.MenuItem
        Me.ML_Reload = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.ML_Power = New System.Windows.Forms.MenuItem
        Me.ML_TurnOff = New System.Windows.Forms.MenuItem
        Me.ML_Reset = New System.Windows.Forms.MenuItem
        Me.ML_Line1 = New System.Windows.Forms.MenuItem
        Me.ML_Exit = New System.Windows.Forms.MenuItem
        Me.MR_Menu = New System.Windows.Forms.MenuItem
        Me.MR_About = New System.Windows.Forms.MenuItem
        Me.Tb_Remote = New System.Windows.Forms.TabPage
        Me.Lbl_RemoteNotice = New System.Windows.Forms.Label
        Me.Nu_MinSendInterval = New System.Windows.Forms.NumericUpDown
        Me.Nu_BitmapCacheSize = New System.Windows.Forms.NumericUpDown
        Me.Nu_BitmapPersistCacheSize = New System.Windows.Forms.NumericUpDown
        Me.Lbl_MinSendInterval = New System.Windows.Forms.Label
        Me.Lbl_BitmapCacheSize = New System.Windows.Forms.Label
        Me.Lbl_BitmapPersistCacheSize = New System.Windows.Forms.Label
        Me.Tb_WLAN = New System.Windows.Forms.TabPage
        Me.Nu_WLANScanInterval = New System.Windows.Forms.NumericUpDown
        Me.Lbl_WLANScanInterval = New System.Windows.Forms.Label
        Me.Tb_GFSDK = New System.Windows.Forms.TabPage
        Me.Cbx_PLL2_FREQ = New System.Windows.Forms.ComboBox
        Me.Lbl_PLL2_FREQ = New System.Windows.Forms.Label
        Me.Ch_GFSDK_MP4_DEC_USE_DSP = New System.Windows.Forms.CheckBox
        Me.Ch_GFSDK_H264_DEC_USE_DSP = New System.Windows.Forms.CheckBox
        Me.Ch_GFSDK_USE_DSP = New System.Windows.Forms.CheckBox
        Me.Ch_GFSDK_USE_DSP_INTERRUPT = New System.Windows.Forms.CheckBox
        Me.Ch_GFSDK_VC1_DEC_USE_DSP = New System.Windows.Forms.CheckBox
        Me.Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED = New System.Windows.Forms.CheckBox
        Me.Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY = New System.Windows.Forms.CheckBox
        Me.Tb_Misc = New System.Windows.Forms.TabPage
        Me.Pnl_DisableSlideRotation = New System.Windows.Forms.Panel
        Me.Lbl_DisableSetLSbyS_Notice = New System.Windows.Forms.Label
        Me.Ch_DisableSetLSbySlide = New System.Windows.Forms.CheckBox
        Me.Ch_DisableSHRecive = New System.Windows.Forms.CheckBox
        Me.Ch_BFlagSlide = New System.Windows.Forms.CheckBox
        Me.Tb_ShCamera = New System.Windows.Forms.TabPage
        Me.PnlSHCameraCommon = New System.Windows.Forms.Panel
        Me.Lbl_Store = New System.Windows.Forms.Label
        Me.Lbl_SHCameraCommon = New System.Windows.Forms.Label
        Me.Cbx_Store = New System.Windows.Forms.ComboBox
        Me.Ch_MobileMode = New System.Windows.Forms.CheckBox
        Me.PnlVideo = New System.Windows.Forms.Panel
        Me.Lbl_Video = New System.Windows.Forms.Label
        Me.Ch_AudioEnable = New System.Windows.Forms.CheckBox
        Me.Cbx_VideoTime = New System.Windows.Forms.ComboBox
        Me.Lbl_VideoTime = New System.Windows.Forms.Label
        Me.PnlPicture = New System.Windows.Forms.Panel
        Me.Lbl_ZoomNotice = New System.Windows.Forms.Label
        Me.Lbl_Picture = New System.Windows.Forms.Label
        Me.Cbx_StillQuality = New System.Windows.Forms.ComboBox
        Me.Lbl_StillSize = New System.Windows.Forms.Label
        Me.Lbl_StillQuality = New System.Windows.Forms.Label
        Me.Cbx_StillSize = New System.Windows.Forms.ComboBox
        Me.Tb_Device = New System.Windows.Forms.TabPage
        Me.Lbl_Notice = New System.Windows.Forms.Label
        Me.Lbl_Platform = New System.Windows.Forms.Label
        Me.Lbl_AkuVer = New System.Windows.Forms.Label
        Me.Lbl_NorVer = New System.Windows.Forms.Label
        Me.Lbl_NandVer = New System.Windows.Forms.Label
        Me.Lbl_FlashVer = New System.Windows.Forms.Label
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.Tb_GUI = New System.Windows.Forms.TabPage
        Me.Ch_EnableRealVGA = New System.Windows.Forms.CheckBox
        Me.Btn_DeleteTaskSwitch = New System.Windows.Forms.Button
        Me.Lbl_DeleteTaskSwitch = New System.Windows.Forms.Label
        Me.Ch_EnableSip = New System.Windows.Forms.CheckBox
        Me.Ch_EnableMenuAnimation = New System.Windows.Forms.CheckBox
        Me.Ch_EnableWindowAnimation = New System.Windows.Forms.CheckBox
        Me.Tb_Fonts = New System.Windows.Forms.TabPage
        Me.Ch_ClearTypeOffOnRotation = New System.Windows.Forms.CheckBox
        Me.Ch_EnableClearTypeIEText = New System.Windows.Forms.CheckBox
        Me.Ch_NoClearType = New System.Windows.Forms.CheckBox
        Me.Cbx_FontCacheSize = New System.Windows.Forms.ComboBox
        Me.Lbl_FontCacheSize = New System.Windows.Forms.Label
        Me.Tb_Strage = New System.Windows.Forms.TabPage
        Me.Cbx_FileSystemCacheSize = New System.Windows.Forms.ComboBox
        Me.Lbl_FileSystemCacheSize = New System.Windows.Forms.Label
        Me.Ch_EnableFileSystemCache = New System.Windows.Forms.CheckBox
        Me.Tb_NVDDI = New System.Windows.Forms.TabPage
        Me.Lbl_EMBEDED_LCD = New System.Windows.Forms.Label
        Me.Cbx_EMBEDED_LCD = New System.Windows.Forms.ComboBox
        Me.Ch_USE_VIDEO_MEMORY_FOR_GPE = New System.Windows.Forms.CheckBox
        Me.Ch_ENHANCE_2D_PERF = New System.Windows.Forms.CheckBox
        Me.Tb_Bluetooth = New System.Windows.Forms.TabPage
        Me.Pnl_AGateway = New System.Windows.Forms.Panel
        Me.Lbl_AudioGateway = New System.Windows.Forms.Label
        Me.Pnl_A2dp = New System.Windows.Forms.Panel
        Me.Nu_A2dpMaxBitPool = New System.Windows.Forms.NumericUpDown
        Me.Nu_A2dpBitPool = New System.Windows.Forms.NumericUpDown
        Me.Lbl_A2dpMaxBitPool = New System.Windows.Forms.Label
        Me.Lbl_A2dpBitPool = New System.Windows.Forms.Label
        Me.Cbx_A2dpStereoMode = New System.Windows.Forms.ComboBox
        Me.Lbl_A2dpStereoMode = New System.Windows.Forms.Label
        Me.Cbx_A2dpSampleRate = New System.Windows.Forms.ComboBox
        Me.Lbl_A2dpSampleRate = New System.Windows.Forms.Label
        Me.Lbl_A2dp = New System.Windows.Forms.Label
        Me.Tb_USB = New System.Windows.Forms.TabPage
        Me.Lbl_MassNotice = New System.Windows.Forms.Label
        Me.Lbl_USBStatus = New System.Windows.Forms.Label
        Me.Cbx_USBMode = New System.Windows.Forms.ComboBox
        Me.Lbl_USBMode = New System.Windows.Forms.Label
        Me.Tb_HID = New System.Windows.Forms.TabPage
        Me.Cbx_MouseCursor = New System.Windows.Forms.ComboBox
        Me.Lbl_MouseCursor = New System.Windows.Forms.Label
        Me.Tb_Audio = New System.Windows.Forms.TabPage
        Me.Lbl_InputLevel = New System.Windows.Forms.Label
        Me.Lbl_OutputLevel = New System.Windows.Forms.Label
        Me.Trb_InputVolume = New System.Windows.Forms.TrackBar
        Me.Trb_OutVolume = New System.Windows.Forms.TrackBar
        Me.Lbl_InputVolumeSize = New System.Windows.Forms.Label
        Me.Lbl_OutputVolumeSize = New System.Windows.Forms.Label
        Me.Tb_Network = New System.Windows.Forms.TabPage
        Me.Pnl_RWIN = New System.Windows.Forms.Panel
        Me.Txt_RWIN = New System.Windows.Forms.TextBox
        Me.Nu_RWIN = New System.Windows.Forms.NumericUpDown
        Me.Lb_RWIN = New System.Windows.Forms.Label
        Me.Lbl_HSDPA = New System.Windows.Forms.Label
        Me.Tb_Remote.SuspendLayout()
        Me.Tb_WLAN.SuspendLayout()
        Me.Tb_GFSDK.SuspendLayout()
        Me.Tb_Misc.SuspendLayout()
        Me.Pnl_DisableSlideRotation.SuspendLayout()
        Me.Tb_ShCamera.SuspendLayout()
        Me.PnlSHCameraCommon.SuspendLayout()
        Me.PnlVideo.SuspendLayout()
        Me.PnlPicture.SuspendLayout()
        Me.Tb_Device.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.Tb_GUI.SuspendLayout()
        Me.Tb_Fonts.SuspendLayout()
        Me.Tb_Strage.SuspendLayout()
        Me.Tb_NVDDI.SuspendLayout()
        Me.Tb_Bluetooth.SuspendLayout()
        Me.Pnl_AGateway.SuspendLayout()
        Me.Pnl_A2dp.SuspendLayout()
        Me.Tb_USB.SuspendLayout()
        Me.Tb_HID.SuspendLayout()
        Me.Tb_Audio.SuspendLayout()
        Me.Tb_Network.SuspendLayout()
        Me.Pnl_RWIN.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.Add(Me.ML_File)
        Me.MainMenu.MenuItems.Add(Me.MR_Menu)
        '
        'ML_File
        '
        Me.ML_File.MenuItems.Add(Me.ML_WriteValues)
        Me.ML_File.MenuItems.Add(Me.ML_DisposeValues)
        Me.ML_File.MenuItems.Add(Me.ML_Reload)
        Me.ML_File.MenuItems.Add(Me.MenuItem1)
        Me.ML_File.MenuItems.Add(Me.ML_Power)
        Me.ML_File.MenuItems.Add(Me.ML_Line1)
        Me.ML_File.MenuItems.Add(Me.ML_Exit)
        Me.ML_File.Text = "ファイル"
        '
        'ML_WriteValues
        '
        Me.ML_WriteValues.Text = "変更内容書込(&U)"
        '
        'ML_DisposeValues
        '
        Me.ML_DisposeValues.Text = "変更内容破棄(&D)"
        '
        'ML_Reload
        '
        Me.ML_Reload.Text = "情報再取得(&R)"
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "-"
        '
        'ML_Power
        '
        Me.ML_Power.MenuItems.Add(Me.ML_TurnOff)
        Me.ML_Power.MenuItems.Add(Me.ML_Reset)
        Me.ML_Power.Text = "パワーマネジメント(&P)"
        '
        'ML_TurnOff
        '
        Me.ML_TurnOff.Text = "サスペンド (&S)"
        '
        'ML_Reset
        '
        Me.ML_Reset.Text = "ソフトリセット(&R)"
        '
        'ML_Line1
        '
        Me.ML_Line1.Text = "-"
        '
        'ML_Exit
        '
        Me.ML_Exit.Text = "終了(&X)"
        '
        'MR_Menu
        '
        Me.MR_Menu.MenuItems.Add(Me.MR_About)
        Me.MR_Menu.Text = "メニュー"
        '
        'MR_About
        '
        Me.MR_About.Text = "About...(A)"
        '
        'Tb_Remote
        '
        Me.Tb_Remote.AutoScroll = True
        Me.Tb_Remote.Controls.Add(Me.Lbl_RemoteNotice)
        Me.Tb_Remote.Controls.Add(Me.Nu_MinSendInterval)
        Me.Tb_Remote.Controls.Add(Me.Nu_BitmapCacheSize)
        Me.Tb_Remote.Controls.Add(Me.Nu_BitmapPersistCacheSize)
        Me.Tb_Remote.Controls.Add(Me.Lbl_MinSendInterval)
        Me.Tb_Remote.Controls.Add(Me.Lbl_BitmapCacheSize)
        Me.Tb_Remote.Controls.Add(Me.Lbl_BitmapPersistCacheSize)
        Me.Tb_Remote.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Remote.Name = "Tb_Remote"
        Me.Tb_Remote.Size = New System.Drawing.Size(312, 162)
        Me.Tb_Remote.Text = "リモート接続"
        '
        'Lbl_RemoteNotice
        '
        Me.Lbl_RemoteNotice.ForeColor = System.Drawing.Color.Red
        Me.Lbl_RemoteNotice.Location = New System.Drawing.Point(7, 84)
        Me.Lbl_RemoteNotice.Name = "Lbl_RemoteNotice"
        Me.Lbl_RemoteNotice.Size = New System.Drawing.Size(195, 29)
        Me.Lbl_RemoteNotice.Text = "※リモートデスクトップがインストールされていません"
        Me.Lbl_RemoteNotice.Visible = False
        '
        'Nu_MinSendInterval
        '
        Me.Nu_MinSendInterval.Location = New System.Drawing.Point(141, 59)
        Me.Nu_MinSendInterval.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Nu_MinSendInterval.Name = "Nu_MinSendInterval"
        Me.Nu_MinSendInterval.Size = New System.Drawing.Size(80, 22)
        Me.Nu_MinSendInterval.TabIndex = 2
        '
        'Nu_BitmapCacheSize
        '
        Me.Nu_BitmapCacheSize.Location = New System.Drawing.Point(141, 30)
        Me.Nu_BitmapCacheSize.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.Nu_BitmapCacheSize.Name = "Nu_BitmapCacheSize"
        Me.Nu_BitmapCacheSize.Size = New System.Drawing.Size(80, 22)
        Me.Nu_BitmapCacheSize.TabIndex = 1
        '
        'Nu_BitmapPersistCacheSize
        '
        Me.Nu_BitmapPersistCacheSize.Location = New System.Drawing.Point(141, 3)
        Me.Nu_BitmapPersistCacheSize.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Nu_BitmapPersistCacheSize.Name = "Nu_BitmapPersistCacheSize"
        Me.Nu_BitmapPersistCacheSize.Size = New System.Drawing.Size(80, 22)
        Me.Nu_BitmapPersistCacheSize.TabIndex = 0
        '
        'Lbl_MinSendInterval
        '
        Me.Lbl_MinSendInterval.Location = New System.Drawing.Point(7, 61)
        Me.Lbl_MinSendInterval.Name = "Lbl_MinSendInterval"
        Me.Lbl_MinSendInterval.Size = New System.Drawing.Size(140, 20)
        Me.Lbl_MinSendInterval.Text = "Min Send Interval"
        '
        'Lbl_BitmapCacheSize
        '
        Me.Lbl_BitmapCacheSize.Location = New System.Drawing.Point(7, 33)
        Me.Lbl_BitmapCacheSize.Name = "Lbl_BitmapCacheSize"
        Me.Lbl_BitmapCacheSize.Size = New System.Drawing.Size(140, 20)
        Me.Lbl_BitmapCacheSize.Text = "BitmapCacheSize"
        '
        'Lbl_BitmapPersistCacheSize
        '
        Me.Lbl_BitmapPersistCacheSize.Location = New System.Drawing.Point(7, 7)
        Me.Lbl_BitmapPersistCacheSize.Name = "Lbl_BitmapPersistCacheSize"
        Me.Lbl_BitmapPersistCacheSize.Size = New System.Drawing.Size(140, 20)
        Me.Lbl_BitmapPersistCacheSize.Text = "BitmapPersistCacheSize"
        '
        'Tb_WLAN
        '
        Me.Tb_WLAN.AutoScroll = True
        Me.Tb_WLAN.Controls.Add(Me.Nu_WLANScanInterval)
        Me.Tb_WLAN.Controls.Add(Me.Lbl_WLANScanInterval)
        Me.Tb_WLAN.Location = New System.Drawing.Point(0, 0)
        Me.Tb_WLAN.Name = "Tb_WLAN"
        Me.Tb_WLAN.Size = New System.Drawing.Size(312, 162)
        Me.Tb_WLAN.Text = "無線LAN"
        '
        'Nu_WLANScanInterval
        '
        Me.Nu_WLANScanInterval.Location = New System.Drawing.Point(173, 7)
        Me.Nu_WLANScanInterval.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Nu_WLANScanInterval.Name = "Nu_WLANScanInterval"
        Me.Nu_WLANScanInterval.Size = New System.Drawing.Size(60, 22)
        Me.Nu_WLANScanInterval.TabIndex = 0
        '
        'Lbl_WLANScanInterval
        '
        Me.Lbl_WLANScanInterval.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_WLANScanInterval.Name = "Lbl_WLANScanInterval"
        Me.Lbl_WLANScanInterval.Size = New System.Drawing.Size(140, 20)
        Me.Lbl_WLANScanInterval.Text = "*無線LANのスキャン間隔"
        '
        'Tb_GFSDK
        '
        Me.Tb_GFSDK.AutoScroll = True
        Me.Tb_GFSDK.Controls.Add(Me.Cbx_PLL2_FREQ)
        Me.Tb_GFSDK.Controls.Add(Me.Lbl_PLL2_FREQ)
        Me.Tb_GFSDK.Controls.Add(Me.Ch_GFSDK_MP4_DEC_USE_DSP)
        Me.Tb_GFSDK.Controls.Add(Me.Ch_GFSDK_H264_DEC_USE_DSP)
        Me.Tb_GFSDK.Controls.Add(Me.Ch_GFSDK_USE_DSP)
        Me.Tb_GFSDK.Controls.Add(Me.Ch_GFSDK_USE_DSP_INTERRUPT)
        Me.Tb_GFSDK.Controls.Add(Me.Ch_GFSDK_VC1_DEC_USE_DSP)
        Me.Tb_GFSDK.Controls.Add(Me.Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED)
        Me.Tb_GFSDK.Controls.Add(Me.Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY)
        Me.Tb_GFSDK.Location = New System.Drawing.Point(0, 0)
        Me.Tb_GFSDK.Name = "Tb_GFSDK"
        Me.Tb_GFSDK.Size = New System.Drawing.Size(320, 165)
        Me.Tb_GFSDK.Text = "GFSDK"
        '
        'Cbx_PLL2_FREQ
        '
        Me.Cbx_PLL2_FREQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.Cbx_PLL2_FREQ.Items.Add("24000")
        Me.Cbx_PLL2_FREQ.Items.Add("48000")
        Me.Cbx_PLL2_FREQ.Location = New System.Drawing.Point(125, 186)
        Me.Cbx_PLL2_FREQ.Name = "Cbx_PLL2_FREQ"
        Me.Cbx_PLL2_FREQ.Size = New System.Drawing.Size(167, 22)
        Me.Cbx_PLL2_FREQ.TabIndex = 6
        Me.Cbx_PLL2_FREQ.Visible = False
        '
        'Lbl_PLL2_FREQ
        '
        Me.Lbl_PLL2_FREQ.Location = New System.Drawing.Point(7, 187)
        Me.Lbl_PLL2_FREQ.Name = "Lbl_PLL2_FREQ"
        Me.Lbl_PLL2_FREQ.Size = New System.Drawing.Size(112, 23)
        Me.Lbl_PLL2_FREQ.Text = "GFSDK_PLL2_FREQ"
        Me.Lbl_PLL2_FREQ.Visible = False
        '
        'Ch_GFSDK_MP4_DEC_USE_DSP
        '
        Me.Ch_GFSDK_MP4_DEC_USE_DSP.Location = New System.Drawing.Point(21, 59)
        Me.Ch_GFSDK_MP4_DEC_USE_DSP.Name = "Ch_GFSDK_MP4_DEC_USE_DSP"
        Me.Ch_GFSDK_MP4_DEC_USE_DSP.Size = New System.Drawing.Size(180, 20)
        Me.Ch_GFSDK_MP4_DEC_USE_DSP.TabIndex = 3
        Me.Ch_GFSDK_MP4_DEC_USE_DSP.Text = "DSP でMP4をデコードする"
        '
        'Ch_GFSDK_H264_DEC_USE_DSP
        '
        Me.Ch_GFSDK_H264_DEC_USE_DSP.Location = New System.Drawing.Point(21, 85)
        Me.Ch_GFSDK_H264_DEC_USE_DSP.Name = "Ch_GFSDK_H264_DEC_USE_DSP"
        Me.Ch_GFSDK_H264_DEC_USE_DSP.Size = New System.Drawing.Size(180, 20)
        Me.Ch_GFSDK_H264_DEC_USE_DSP.TabIndex = 3
        Me.Ch_GFSDK_H264_DEC_USE_DSP.Text = "DSP でH.264をデコードする"
        '
        'Ch_GFSDK_USE_DSP
        '
        Me.Ch_GFSDK_USE_DSP.Enabled = False
        Me.Ch_GFSDK_USE_DSP.Location = New System.Drawing.Point(3, 7)
        Me.Ch_GFSDK_USE_DSP.Name = "Ch_GFSDK_USE_DSP"
        Me.Ch_GFSDK_USE_DSP.Size = New System.Drawing.Size(225, 20)
        Me.Ch_GFSDK_USE_DSP.TabIndex = 0
        Me.Ch_GFSDK_USE_DSP.Text = "DSPを使う"
        '
        'Ch_GFSDK_USE_DSP_INTERRUPT
        '
        Me.Ch_GFSDK_USE_DSP_INTERRUPT.Enabled = False
        Me.Ch_GFSDK_USE_DSP_INTERRUPT.Location = New System.Drawing.Point(21, 33)
        Me.Ch_GFSDK_USE_DSP_INTERRUPT.Name = "Ch_GFSDK_USE_DSP_INTERRUPT"
        Me.Ch_GFSDK_USE_DSP_INTERRUPT.Size = New System.Drawing.Size(180, 20)
        Me.Ch_GFSDK_USE_DSP_INTERRUPT.TabIndex = 1
        Me.Ch_GFSDK_USE_DSP_INTERRUPT.Text = "DSP の割込みを使う"
        '
        'Ch_GFSDK_VC1_DEC_USE_DSP
        '
        Me.Ch_GFSDK_VC1_DEC_USE_DSP.Location = New System.Drawing.Point(21, 111)
        Me.Ch_GFSDK_VC1_DEC_USE_DSP.Name = "Ch_GFSDK_VC1_DEC_USE_DSP"
        Me.Ch_GFSDK_VC1_DEC_USE_DSP.Size = New System.Drawing.Size(180, 20)
        Me.Ch_GFSDK_VC1_DEC_USE_DSP.TabIndex = 2
        Me.Ch_GFSDK_VC1_DEC_USE_DSP.Text = "DSP でVC1をデコードする"
        '
        'Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED
        '
        Me.Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED.Location = New System.Drawing.Point(7, 163)
        Me.Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED.Name = "Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED"
        Me.Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED.Size = New System.Drawing.Size(297, 20)
        Me.Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED.TabIndex = 4
        Me.Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED.Text = "NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED"
        '
        'Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY
        '
        Me.Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY.Location = New System.Drawing.Point(7, 137)
        Me.Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY.Name = "Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY"
        Me.Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY.Size = New System.Drawing.Size(285, 20)
        Me.Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY.TabIndex = 4
        Me.Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY.Text = "GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY"
        '
        'Tb_Misc
        '
        Me.Tb_Misc.AutoScroll = True
        Me.Tb_Misc.Controls.Add(Me.Pnl_DisableSlideRotation)
        Me.Tb_Misc.Controls.Add(Me.Ch_BFlagSlide)
        Me.Tb_Misc.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Misc.Name = "Tb_Misc"
        Me.Tb_Misc.Size = New System.Drawing.Size(312, 162)
        Me.Tb_Misc.Text = "Misc"
        '
        'Pnl_DisableSlideRotation
        '
        Me.Pnl_DisableSlideRotation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Pnl_DisableSlideRotation.Controls.Add(Me.Lbl_DisableSetLSbyS_Notice)
        Me.Pnl_DisableSlideRotation.Controls.Add(Me.Ch_DisableSetLSbySlide)
        Me.Pnl_DisableSlideRotation.Controls.Add(Me.Ch_DisableSHRecive)
        Me.Pnl_DisableSlideRotation.Location = New System.Drawing.Point(3, 29)
        Me.Pnl_DisableSlideRotation.Name = "Pnl_DisableSlideRotation"
        Me.Pnl_DisableSlideRotation.Size = New System.Drawing.Size(210, 89)
        '
        'Lbl_DisableSetLSbyS_Notice
        '
        Me.Lbl_DisableSetLSbyS_Notice.ForeColor = System.Drawing.Color.Red
        Me.Lbl_DisableSetLSbyS_Notice.Location = New System.Drawing.Point(3, 48)
        Me.Lbl_DisableSetLSbyS_Notice.Name = "Lbl_DisableSetLSbyS_Notice"
        Me.Lbl_DisableSetLSbyS_Notice.Size = New System.Drawing.Size(207, 35)
        Me.Lbl_DisableSetLSbyS_Notice.Text = "※電源OFF/ON、ワンセグを起動すると設定が解除されます"
        '
        'Ch_DisableSetLSbySlide
        '
        Me.Ch_DisableSetLSbySlide.Location = New System.Drawing.Point(3, 3)
        Me.Ch_DisableSetLSbySlide.Name = "Ch_DisableSetLSbySlide"
        Me.Ch_DisableSetLSbySlide.Size = New System.Drawing.Size(180, 20)
        Me.Ch_DisableSetLSbySlide.TabIndex = 1
        Me.Ch_DisableSetLSbySlide.Text = "スライドで画面回転しない"
        '
        'Ch_DisableSHRecive
        '
        Me.Ch_DisableSHRecive.Location = New System.Drawing.Point(3, 25)
        Me.Ch_DisableSHRecive.Name = "Ch_DisableSHRecive"
        Me.Ch_DisableSHRecive.Size = New System.Drawing.Size(150, 20)
        Me.Ch_DisableSHRecive.TabIndex = 2
        Me.Ch_DisableSHRecive.Text = "青色LEDを点灯しない"
        '
        'Ch_BFlagSlide
        '
        Me.Ch_BFlagSlide.Location = New System.Drawing.Point(3, 3)
        Me.Ch_BFlagSlide.Name = "Ch_BFlagSlide"
        Me.Ch_BFlagSlide.Size = New System.Drawing.Size(160, 20)
        Me.Ch_BFlagSlide.TabIndex = 0
        Me.Ch_BFlagSlide.Text = "スライドで電源をONする"
        '
        'Tb_ShCamera
        '
        Me.Tb_ShCamera.AutoScroll = True
        Me.Tb_ShCamera.Controls.Add(Me.PnlSHCameraCommon)
        Me.Tb_ShCamera.Controls.Add(Me.PnlVideo)
        Me.Tb_ShCamera.Controls.Add(Me.PnlPicture)
        Me.Tb_ShCamera.Location = New System.Drawing.Point(0, 0)
        Me.Tb_ShCamera.Name = "Tb_ShCamera"
        Me.Tb_ShCamera.Size = New System.Drawing.Size(312, 162)
        Me.Tb_ShCamera.Text = "SHカメラ"
        '
        'PnlSHCameraCommon
        '
        Me.PnlSHCameraCommon.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlSHCameraCommon.Controls.Add(Me.Lbl_Store)
        Me.PnlSHCameraCommon.Controls.Add(Me.Lbl_SHCameraCommon)
        Me.PnlSHCameraCommon.Controls.Add(Me.Cbx_Store)
        Me.PnlSHCameraCommon.Controls.Add(Me.Ch_MobileMode)
        Me.PnlSHCameraCommon.Location = New System.Drawing.Point(3, 3)
        Me.PnlSHCameraCommon.Name = "PnlSHCameraCommon"
        Me.PnlSHCameraCommon.Size = New System.Drawing.Size(207, 64)
        '
        'Lbl_Store
        '
        Me.Lbl_Store.Location = New System.Drawing.Point(3, 16)
        Me.Lbl_Store.Name = "Lbl_Store"
        Me.Lbl_Store.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_Store.Text = "保存先"
        '
        'Lbl_SHCameraCommon
        '
        Me.Lbl_SHCameraCommon.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Lbl_SHCameraCommon.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_SHCameraCommon.Name = "Lbl_SHCameraCommon"
        Me.Lbl_SHCameraCommon.Size = New System.Drawing.Size(60, 20)
        Me.Lbl_SHCameraCommon.Text = "共通設定"
        '
        'Cbx_Store
        '
        Me.Cbx_Store.Items.Add("マイ ピクチャ")
        Me.Cbx_Store.Items.Add("miniSD カード")
        Me.Cbx_Store.Location = New System.Drawing.Point(75, 14)
        Me.Cbx_Store.Name = "Cbx_Store"
        Me.Cbx_Store.Size = New System.Drawing.Size(120, 22)
        Me.Cbx_Store.TabIndex = 0
        '
        'Ch_MobileMode
        '
        Me.Ch_MobileMode.Location = New System.Drawing.Point(3, 39)
        Me.Ch_MobileMode.Name = "Ch_MobileMode"
        Me.Ch_MobileMode.Size = New System.Drawing.Size(80, 20)
        Me.Ch_MobileMode.TabIndex = 1
        Me.Ch_MobileMode.Text = "x2 ズーム"
        '
        'PnlVideo
        '
        Me.PnlVideo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlVideo.Controls.Add(Me.Lbl_Video)
        Me.PnlVideo.Controls.Add(Me.Ch_AudioEnable)
        Me.PnlVideo.Controls.Add(Me.Cbx_VideoTime)
        Me.PnlVideo.Controls.Add(Me.Lbl_VideoTime)
        Me.PnlVideo.Location = New System.Drawing.Point(3, 173)
        Me.PnlVideo.Name = "PnlVideo"
        Me.PnlVideo.Size = New System.Drawing.Size(207, 67)
        '
        'Lbl_Video
        '
        Me.Lbl_Video.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Video.Name = "Lbl_Video"
        Me.Lbl_Video.Size = New System.Drawing.Size(60, 20)
        Me.Lbl_Video.Text = "動画設定"
        '
        'Ch_AudioEnable
        '
        Me.Ch_AudioEnable.Location = New System.Drawing.Point(3, 18)
        Me.Ch_AudioEnable.Name = "Ch_AudioEnable"
        Me.Ch_AudioEnable.Size = New System.Drawing.Size(140, 20)
        Me.Ch_AudioEnable.TabIndex = 4
        Me.Ch_AudioEnable.Text = "音声録音ON"
        '
        'Cbx_VideoTime
        '
        Me.Cbx_VideoTime.Items.Add("15秒")
        Me.Cbx_VideoTime.Items.Add("30秒")
        Me.Cbx_VideoTime.Items.Add("制限無し")
        Me.Cbx_VideoTime.Location = New System.Drawing.Point(75, 39)
        Me.Cbx_VideoTime.Name = "Cbx_VideoTime"
        Me.Cbx_VideoTime.Size = New System.Drawing.Size(120, 22)
        Me.Cbx_VideoTime.TabIndex = 5
        '
        'Lbl_VideoTime
        '
        Me.Lbl_VideoTime.Location = New System.Drawing.Point(4, 41)
        Me.Lbl_VideoTime.Name = "Lbl_VideoTime"
        Me.Lbl_VideoTime.Size = New System.Drawing.Size(60, 20)
        Me.Lbl_VideoTime.Text = "録画時間"
        '
        'PnlPicture
        '
        Me.PnlPicture.BackColor = System.Drawing.Color.Gainsboro
        Me.PnlPicture.Controls.Add(Me.Lbl_ZoomNotice)
        Me.PnlPicture.Controls.Add(Me.Lbl_Picture)
        Me.PnlPicture.Controls.Add(Me.Cbx_StillQuality)
        Me.PnlPicture.Controls.Add(Me.Lbl_StillSize)
        Me.PnlPicture.Controls.Add(Me.Lbl_StillQuality)
        Me.PnlPicture.Controls.Add(Me.Cbx_StillSize)
        Me.PnlPicture.Location = New System.Drawing.Point(3, 73)
        Me.PnlPicture.Name = "PnlPicture"
        Me.PnlPicture.Size = New System.Drawing.Size(207, 97)
        '
        'Lbl_ZoomNotice
        '
        Me.Lbl_ZoomNotice.ForeColor = System.Drawing.Color.Red
        Me.Lbl_ZoomNotice.Location = New System.Drawing.Point(4, 18)
        Me.Lbl_ZoomNotice.Name = "Lbl_ZoomNotice"
        Me.Lbl_ZoomNotice.Size = New System.Drawing.Size(200, 20)
        Me.Lbl_ZoomNotice.Text = "※x2 と SXGAは同時利用できません"
        '
        'Lbl_Picture
        '
        Me.Lbl_Picture.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Picture.Name = "Lbl_Picture"
        Me.Lbl_Picture.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_Picture.Text = "静止画設定"
        '
        'Cbx_StillQuality
        '
        Me.Cbx_StillQuality.Items.Add("低画質")
        Me.Cbx_StillQuality.Items.Add("標準")
        Me.Cbx_StillQuality.Items.Add("高画質")
        Me.Cbx_StillQuality.Location = New System.Drawing.Point(75, 67)
        Me.Cbx_StillQuality.Name = "Cbx_StillQuality"
        Me.Cbx_StillQuality.Size = New System.Drawing.Size(120, 22)
        Me.Cbx_StillQuality.TabIndex = 3
        '
        'Lbl_StillSize
        '
        Me.Lbl_StillSize.Location = New System.Drawing.Point(3, 39)
        Me.Lbl_StillSize.Name = "Lbl_StillSize"
        Me.Lbl_StillSize.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_StillSize.Text = "撮影サイズ"
        '
        'Lbl_StillQuality
        '
        Me.Lbl_StillQuality.Location = New System.Drawing.Point(4, 69)
        Me.Lbl_StillQuality.Name = "Lbl_StillQuality"
        Me.Lbl_StillQuality.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_StillQuality.Text = "画質"
        '
        'Cbx_StillSize
        '
        Me.Cbx_StillSize.Items.Add("320x240 (QVGA)")
        Me.Cbx_StillSize.Items.Add("640x480 (VGA)")
        Me.Cbx_StillSize.Items.Add("1280x1024 (SXGA)")
        Me.Cbx_StillSize.Location = New System.Drawing.Point(75, 39)
        Me.Cbx_StillSize.Name = "Cbx_StillSize"
        Me.Cbx_StillSize.Size = New System.Drawing.Size(120, 22)
        Me.Cbx_StillSize.TabIndex = 2
        '
        'Tb_Device
        '
        Me.Tb_Device.Controls.Add(Me.Lbl_Notice)
        Me.Tb_Device.Controls.Add(Me.Lbl_Platform)
        Me.Tb_Device.Controls.Add(Me.Lbl_AkuVer)
        Me.Tb_Device.Controls.Add(Me.Lbl_NorVer)
        Me.Tb_Device.Controls.Add(Me.Lbl_NandVer)
        Me.Tb_Device.Controls.Add(Me.Lbl_FlashVer)
        Me.Tb_Device.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Device.Name = "Tb_Device"
        Me.Tb_Device.Size = New System.Drawing.Size(320, 165)
        Me.Tb_Device.Text = "デバイス情報"
        '
        'Lbl_Notice
        '
        Me.Lbl_Notice.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Notice.Location = New System.Drawing.Point(3, 122)
        Me.Lbl_Notice.Name = "Lbl_Notice"
        Me.Lbl_Notice.Size = New System.Drawing.Size(260, 20)
        Me.Lbl_Notice.Text = "「*」付きの項目はデバイスのリセットが必要です"
        '
        'Lbl_Platform
        '
        Me.Lbl_Platform.Location = New System.Drawing.Point(7, 22)
        Me.Lbl_Platform.Name = "Lbl_Platform"
        Me.Lbl_Platform.Size = New System.Drawing.Size(200, 40)
        Me.Lbl_Platform.Text = "OS"
        '
        'Lbl_AkuVer
        '
        Me.Lbl_AkuVer.Location = New System.Drawing.Point(7, 62)
        Me.Lbl_AkuVer.Name = "Lbl_AkuVer"
        Me.Lbl_AkuVer.Size = New System.Drawing.Size(120, 20)
        Me.Lbl_AkuVer.Text = "AKU Ver"
        '
        'Lbl_NorVer
        '
        Me.Lbl_NorVer.Location = New System.Drawing.Point(7, 182)
        Me.Lbl_NorVer.Name = "Lbl_NorVer"
        Me.Lbl_NorVer.Size = New System.Drawing.Size(120, 20)
        Me.Lbl_NorVer.Text = "NOR Ver."
        Me.Lbl_NorVer.Visible = False
        '
        'Lbl_NandVer
        '
        Me.Lbl_NandVer.Location = New System.Drawing.Point(7, 162)
        Me.Lbl_NandVer.Name = "Lbl_NandVer"
        Me.Lbl_NandVer.Size = New System.Drawing.Size(120, 20)
        Me.Lbl_NandVer.Text = "NAND Ver."
        Me.Lbl_NandVer.Visible = False
        '
        'Lbl_FlashVer
        '
        Me.Lbl_FlashVer.Location = New System.Drawing.Point(7, 142)
        Me.Lbl_FlashVer.Name = "Lbl_FlashVer"
        Me.Lbl_FlashVer.Size = New System.Drawing.Size(120, 20)
        Me.Lbl_FlashVer.Text = "Flash Ver."
        Me.Lbl_FlashVer.Visible = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Tb_Device)
        Me.TabControl.Controls.Add(Me.Tb_Misc)
        Me.TabControl.Controls.Add(Me.Tb_GUI)
        Me.TabControl.Controls.Add(Me.Tb_Fonts)
        Me.TabControl.Controls.Add(Me.Tb_Strage)
        Me.TabControl.Controls.Add(Me.Tb_GFSDK)
        Me.TabControl.Controls.Add(Me.Tb_NVDDI)
        Me.TabControl.Controls.Add(Me.Tb_ShCamera)
        Me.TabControl.Controls.Add(Me.Tb_WLAN)
        Me.TabControl.Controls.Add(Me.Tb_Bluetooth)
        Me.TabControl.Controls.Add(Me.Tb_USB)
        Me.TabControl.Controls.Add(Me.Tb_HID)
        Me.TabControl.Controls.Add(Me.Tb_Audio)
        Me.TabControl.Controls.Add(Me.Tb_Network)
        Me.TabControl.Controls.Add(Me.Tb_Remote)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(320, 188)
        Me.TabControl.TabIndex = 0
        '
        'Tb_GUI
        '
        Me.Tb_GUI.AutoScroll = True
        Me.Tb_GUI.Controls.Add(Me.Ch_EnableRealVGA)
        Me.Tb_GUI.Controls.Add(Me.Btn_DeleteTaskSwitch)
        Me.Tb_GUI.Controls.Add(Me.Lbl_DeleteTaskSwitch)
        Me.Tb_GUI.Controls.Add(Me.Ch_EnableSip)
        Me.Tb_GUI.Controls.Add(Me.Ch_EnableMenuAnimation)
        Me.Tb_GUI.Controls.Add(Me.Ch_EnableWindowAnimation)
        Me.Tb_GUI.Location = New System.Drawing.Point(0, 0)
        Me.Tb_GUI.Name = "Tb_GUI"
        Me.Tb_GUI.Size = New System.Drawing.Size(312, 162)
        Me.Tb_GUI.Text = "GUI"
        '
        'Ch_EnableRealVGA
        '
        Me.Ch_EnableRealVGA.Location = New System.Drawing.Point(3, 3)
        Me.Ch_EnableRealVGA.Name = "Ch_EnableRealVGA"
        Me.Ch_EnableRealVGA.Size = New System.Drawing.Size(189, 20)
        Me.Ch_EnableRealVGA.TabIndex = 0
        Me.Ch_EnableRealVGA.Text = "*高解像度モードを使用する"
        '
        'Btn_DeleteTaskSwitch
        '
        Me.Btn_DeleteTaskSwitch.Location = New System.Drawing.Point(159, 104)
        Me.Btn_DeleteTaskSwitch.Name = "Btn_DeleteTaskSwitch"
        Me.Btn_DeleteTaskSwitch.Size = New System.Drawing.Size(54, 20)
        Me.Btn_DeleteTaskSwitch.TabIndex = 4
        Me.Btn_DeleteTaskSwitch.Text = "消去(&C)"
        '
        'Lbl_DeleteTaskSwitch
        '
        Me.Lbl_DeleteTaskSwitch.Location = New System.Drawing.Point(4, 104)
        Me.Lbl_DeleteTaskSwitch.Name = "Lbl_DeleteTaskSwitch"
        Me.Lbl_DeleteTaskSwitch.Size = New System.Drawing.Size(150, 20)
        Me.Lbl_DeleteTaskSwitch.Text = "*最近使ったプログラム一覧"
        '
        'Ch_EnableSip
        '
        Me.Ch_EnableSip.Location = New System.Drawing.Point(3, 29)
        Me.Ch_EnableSip.Name = "Ch_EnableSip"
        Me.Ch_EnableSip.Size = New System.Drawing.Size(200, 20)
        Me.Ch_EnableSip.TabIndex = 1
        Me.Ch_EnableSip.Text = "*ソフトキーボードを使用する"
        '
        'Ch_EnableMenuAnimation
        '
        Me.Ch_EnableMenuAnimation.Location = New System.Drawing.Point(3, 81)
        Me.Ch_EnableMenuAnimation.Name = "Ch_EnableMenuAnimation"
        Me.Ch_EnableMenuAnimation.Size = New System.Drawing.Size(200, 20)
        Me.Ch_EnableMenuAnimation.TabIndex = 3
        Me.Ch_EnableMenuAnimation.Text = "*メニューをアニメーションさせる"
        '
        'Ch_EnableWindowAnimation
        '
        Me.Ch_EnableWindowAnimation.Location = New System.Drawing.Point(3, 55)
        Me.Ch_EnableWindowAnimation.Name = "Ch_EnableWindowAnimation"
        Me.Ch_EnableWindowAnimation.Size = New System.Drawing.Size(200, 20)
        Me.Ch_EnableWindowAnimation.TabIndex = 2
        Me.Ch_EnableWindowAnimation.Text = "*ウィンドウをアニメーションさせる"
        '
        'Tb_Fonts
        '
        Me.Tb_Fonts.Controls.Add(Me.Ch_ClearTypeOffOnRotation)
        Me.Tb_Fonts.Controls.Add(Me.Ch_EnableClearTypeIEText)
        Me.Tb_Fonts.Controls.Add(Me.Ch_NoClearType)
        Me.Tb_Fonts.Controls.Add(Me.Cbx_FontCacheSize)
        Me.Tb_Fonts.Controls.Add(Me.Lbl_FontCacheSize)
        Me.Tb_Fonts.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Fonts.Name = "Tb_Fonts"
        Me.Tb_Fonts.Size = New System.Drawing.Size(312, 162)
        Me.Tb_Fonts.Text = "フォント"
        '
        'Ch_ClearTypeOffOnRotation
        '
        Me.Ch_ClearTypeOffOnRotation.Location = New System.Drawing.Point(3, 86)
        Me.Ch_ClearTypeOffOnRotation.Name = "Ch_ClearTypeOffOnRotation"
        Me.Ch_ClearTypeOffOnRotation.Size = New System.Drawing.Size(220, 20)
        Me.Ch_ClearTypeOffOnRotation.TabIndex = 3
        Me.Ch_ClearTypeOffOnRotation.Text = "画面回転でクリアタイプを無効にする"
        '
        'Ch_EnableClearTypeIEText
        '
        Me.Ch_EnableClearTypeIEText.Location = New System.Drawing.Point(3, 60)
        Me.Ch_EnableClearTypeIEText.Name = "Ch_EnableClearTypeIEText"
        Me.Ch_EnableClearTypeIEText.Size = New System.Drawing.Size(220, 20)
        Me.Ch_EnableClearTypeIEText.TabIndex = 2
        Me.Ch_EnableClearTypeIEText.Text = "IE Mobileでクリアタイプを有効にする"
        '
        'Ch_NoClearType
        '
        Me.Ch_NoClearType.Location = New System.Drawing.Point(3, 34)
        Me.Ch_NoClearType.Name = "Ch_NoClearType"
        Me.Ch_NoClearType.Size = New System.Drawing.Size(220, 20)
        Me.Ch_NoClearType.TabIndex = 1
        Me.Ch_NoClearType.Text = "画面の設定からクリアタイプを隠す"
        '
        'Cbx_FontCacheSize
        '
        Me.Cbx_FontCacheSize.Items.Add("規定値")
        Me.Cbx_FontCacheSize.Items.Add("8 KB")
        Me.Cbx_FontCacheSize.Items.Add("16 KB")
        Me.Cbx_FontCacheSize.Items.Add("32 KB")
        Me.Cbx_FontCacheSize.Items.Add("128 KB")
        Me.Cbx_FontCacheSize.Items.Add("1 MB")
        Me.Cbx_FontCacheSize.Items.Add("2 MB")
        Me.Cbx_FontCacheSize.Items.Add("4 MB")
        Me.Cbx_FontCacheSize.Items.Add("8 MB")
        Me.Cbx_FontCacheSize.Items.Add("16 MB")
        Me.Cbx_FontCacheSize.Location = New System.Drawing.Point(139, 6)
        Me.Cbx_FontCacheSize.Name = "Cbx_FontCacheSize"
        Me.Cbx_FontCacheSize.Size = New System.Drawing.Size(80, 22)
        Me.Cbx_FontCacheSize.TabIndex = 0
        '
        'Lbl_FontCacheSize
        '
        Me.Lbl_FontCacheSize.Location = New System.Drawing.Point(3, 8)
        Me.Lbl_FontCacheSize.Name = "Lbl_FontCacheSize"
        Me.Lbl_FontCacheSize.Size = New System.Drawing.Size(130, 20)
        Me.Lbl_FontCacheSize.Text = "*フォントキャッシュサイズ"
        '
        'Tb_Strage
        '
        Me.Tb_Strage.AutoScroll = True
        Me.Tb_Strage.Controls.Add(Me.Cbx_FileSystemCacheSize)
        Me.Tb_Strage.Controls.Add(Me.Lbl_FileSystemCacheSize)
        Me.Tb_Strage.Controls.Add(Me.Ch_EnableFileSystemCache)
        Me.Tb_Strage.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Strage.Name = "Tb_Strage"
        Me.Tb_Strage.Size = New System.Drawing.Size(312, 162)
        Me.Tb_Strage.Text = "ストレージ"
        '
        'Cbx_FileSystemCacheSize
        '
        Me.Cbx_FileSystemCacheSize.Items.Add("規定値")
        Me.Cbx_FileSystemCacheSize.Items.Add("128 KB")
        Me.Cbx_FileSystemCacheSize.Items.Add("256 KB")
        Me.Cbx_FileSystemCacheSize.Items.Add("512 KB")
        Me.Cbx_FileSystemCacheSize.Items.Add("1 MB")
        Me.Cbx_FileSystemCacheSize.Items.Add("2 MB")
        Me.Cbx_FileSystemCacheSize.Items.Add("4 MB")
        Me.Cbx_FileSystemCacheSize.Items.Add("8 MB")
        Me.Cbx_FileSystemCacheSize.Location = New System.Drawing.Point(153, 31)
        Me.Cbx_FileSystemCacheSize.Name = "Cbx_FileSystemCacheSize"
        Me.Cbx_FileSystemCacheSize.Size = New System.Drawing.Size(80, 22)
        Me.Cbx_FileSystemCacheSize.TabIndex = 1
        '
        'Lbl_FileSystemCacheSize
        '
        Me.Lbl_FileSystemCacheSize.Location = New System.Drawing.Point(21, 33)
        Me.Lbl_FileSystemCacheSize.Name = "Lbl_FileSystemCacheSize"
        Me.Lbl_FileSystemCacheSize.Size = New System.Drawing.Size(130, 20)
        Me.Lbl_FileSystemCacheSize.Text = "ディスクキャッシュサイズ"
        '
        'Ch_EnableFileSystemCache
        '
        Me.Ch_EnableFileSystemCache.Location = New System.Drawing.Point(3, 7)
        Me.Ch_EnableFileSystemCache.Name = "Ch_EnableFileSystemCache"
        Me.Ch_EnableFileSystemCache.Size = New System.Drawing.Size(200, 20)
        Me.Ch_EnableFileSystemCache.TabIndex = 0
        Me.Ch_EnableFileSystemCache.Text = "*ディスクキャッシュを有効にする"
        '
        'Tb_NVDDI
        '
        Me.Tb_NVDDI.Controls.Add(Me.Lbl_EMBEDED_LCD)
        Me.Tb_NVDDI.Controls.Add(Me.Cbx_EMBEDED_LCD)
        Me.Tb_NVDDI.Controls.Add(Me.Ch_USE_VIDEO_MEMORY_FOR_GPE)
        Me.Tb_NVDDI.Controls.Add(Me.Ch_ENHANCE_2D_PERF)
        Me.Tb_NVDDI.Location = New System.Drawing.Point(0, 0)
        Me.Tb_NVDDI.Name = "Tb_NVDDI"
        Me.Tb_NVDDI.Size = New System.Drawing.Size(312, 162)
        Me.Tb_NVDDI.Text = "NVDDI"
        '
        'Lbl_EMBEDED_LCD
        '
        Me.Lbl_EMBEDED_LCD.Location = New System.Drawing.Point(7, 7)
        Me.Lbl_EMBEDED_LCD.Name = "Lbl_EMBEDED_LCD"
        Me.Lbl_EMBEDED_LCD.Size = New System.Drawing.Size(105, 18)
        Me.Lbl_EMBEDED_LCD.Text = "ディスプレイドライバ"
        Me.Lbl_EMBEDED_LCD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cbx_EMBEDED_LCD
        '
        Me.Cbx_EMBEDED_LCD.Items.Add("ddi.dll")
        Me.Cbx_EMBEDED_LCD.Items.Add("nvddi.dll")
        Me.Cbx_EMBEDED_LCD.Location = New System.Drawing.Point(118, 7)
        Me.Cbx_EMBEDED_LCD.Name = "Cbx_EMBEDED_LCD"
        Me.Cbx_EMBEDED_LCD.Size = New System.Drawing.Size(106, 22)
        Me.Cbx_EMBEDED_LCD.TabIndex = 6
        '
        'Ch_USE_VIDEO_MEMORY_FOR_GPE
        '
        Me.Ch_USE_VIDEO_MEMORY_FOR_GPE.Location = New System.Drawing.Point(7, 61)
        Me.Ch_USE_VIDEO_MEMORY_FOR_GPE.Name = "Ch_USE_VIDEO_MEMORY_FOR_GPE"
        Me.Ch_USE_VIDEO_MEMORY_FOR_GPE.Size = New System.Drawing.Size(217, 20)
        Me.Ch_USE_VIDEO_MEMORY_FOR_GPE.TabIndex = 5
        Me.Ch_USE_VIDEO_MEMORY_FOR_GPE.Text = "USE_VIDEO_MEMORY_FOR_GPE"
        '
        'Ch_ENHANCE_2D_PERF
        '
        Me.Ch_ENHANCE_2D_PERF.Location = New System.Drawing.Point(7, 35)
        Me.Ch_ENHANCE_2D_PERF.Name = "Ch_ENHANCE_2D_PERF"
        Me.Ch_ENHANCE_2D_PERF.Size = New System.Drawing.Size(217, 20)
        Me.Ch_ENHANCE_2D_PERF.TabIndex = 5
        Me.Ch_ENHANCE_2D_PERF.Text = "ENHANCE_2D_PERF"
        '
        'Tb_Bluetooth
        '
        Me.Tb_Bluetooth.Controls.Add(Me.Pnl_AGateway)
        Me.Tb_Bluetooth.Controls.Add(Me.Pnl_A2dp)
        Me.Tb_Bluetooth.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Bluetooth.Name = "Tb_Bluetooth"
        Me.Tb_Bluetooth.Size = New System.Drawing.Size(312, 162)
        Me.Tb_Bluetooth.Text = "Bluetooth"
        '
        'Pnl_AGateway
        '
        Me.Pnl_AGateway.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Pnl_AGateway.Controls.Add(Me.Lbl_AudioGateway)
        Me.Pnl_AGateway.Location = New System.Drawing.Point(3, 157)
        Me.Pnl_AGateway.Name = "Pnl_AGateway"
        Me.Pnl_AGateway.Size = New System.Drawing.Size(226, 60)
        Me.Pnl_AGateway.Visible = False
        '
        'Lbl_AudioGateway
        '
        Me.Lbl_AudioGateway.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_AudioGateway.Name = "Lbl_AudioGateway"
        Me.Lbl_AudioGateway.Size = New System.Drawing.Size(130, 20)
        Me.Lbl_AudioGateway.Text = "AudioGatewayの設定"
        Me.Lbl_AudioGateway.Visible = False
        '
        'Pnl_A2dp
        '
        Me.Pnl_A2dp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Pnl_A2dp.Controls.Add(Me.Nu_A2dpMaxBitPool)
        Me.Pnl_A2dp.Controls.Add(Me.Nu_A2dpBitPool)
        Me.Pnl_A2dp.Controls.Add(Me.Lbl_A2dpMaxBitPool)
        Me.Pnl_A2dp.Controls.Add(Me.Lbl_A2dpBitPool)
        Me.Pnl_A2dp.Controls.Add(Me.Cbx_A2dpStereoMode)
        Me.Pnl_A2dp.Controls.Add(Me.Lbl_A2dpStereoMode)
        Me.Pnl_A2dp.Controls.Add(Me.Cbx_A2dpSampleRate)
        Me.Pnl_A2dp.Controls.Add(Me.Lbl_A2dpSampleRate)
        Me.Pnl_A2dp.Controls.Add(Me.Lbl_A2dp)
        Me.Pnl_A2dp.Location = New System.Drawing.Point(3, 7)
        Me.Pnl_A2dp.Name = "Pnl_A2dp"
        Me.Pnl_A2dp.Size = New System.Drawing.Size(226, 144)
        '
        'Nu_A2dpMaxBitPool
        '
        Me.Nu_A2dpMaxBitPool.Location = New System.Drawing.Point(119, 103)
        Me.Nu_A2dpMaxBitPool.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Nu_A2dpMaxBitPool.Name = "Nu_A2dpMaxBitPool"
        Me.Nu_A2dpMaxBitPool.Size = New System.Drawing.Size(82, 22)
        Me.Nu_A2dpMaxBitPool.TabIndex = 3
        '
        'Nu_A2dpBitPool
        '
        Me.Nu_A2dpBitPool.Location = New System.Drawing.Point(119, 74)
        Me.Nu_A2dpBitPool.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Nu_A2dpBitPool.Name = "Nu_A2dpBitPool"
        Me.Nu_A2dpBitPool.Size = New System.Drawing.Size(82, 22)
        Me.Nu_A2dpBitPool.TabIndex = 2
        '
        'Lbl_A2dpMaxBitPool
        '
        Me.Lbl_A2dpMaxBitPool.Location = New System.Drawing.Point(3, 105)
        Me.Lbl_A2dpMaxBitPool.Name = "Lbl_A2dpMaxBitPool"
        Me.Lbl_A2dpMaxBitPool.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_A2dpMaxBitPool.Text = "MaxBitPool："
        '
        'Lbl_A2dpBitPool
        '
        Me.Lbl_A2dpBitPool.Location = New System.Drawing.Point(3, 76)
        Me.Lbl_A2dpBitPool.Name = "Lbl_A2dpBitPool"
        Me.Lbl_A2dpBitPool.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_A2dpBitPool.Text = "BitPool："
        '
        'Cbx_A2dpStereoMode
        '
        Me.Cbx_A2dpStereoMode.Items.Add("Stereo")
        Me.Cbx_A2dpStereoMode.Items.Add("JointStereo")
        Me.Cbx_A2dpStereoMode.Location = New System.Drawing.Point(119, 46)
        Me.Cbx_A2dpStereoMode.Name = "Cbx_A2dpStereoMode"
        Me.Cbx_A2dpStereoMode.Size = New System.Drawing.Size(82, 22)
        Me.Cbx_A2dpStereoMode.TabIndex = 1
        '
        'Lbl_A2dpStereoMode
        '
        Me.Lbl_A2dpStereoMode.Location = New System.Drawing.Point(3, 48)
        Me.Lbl_A2dpStereoMode.Name = "Lbl_A2dpStereoMode"
        Me.Lbl_A2dpStereoMode.Size = New System.Drawing.Size(90, 20)
        Me.Lbl_A2dpStereoMode.Text = "ステレオモード："
        '
        'Cbx_A2dpSampleRate
        '
        Me.Cbx_A2dpSampleRate.Items.Add("規定値")
        Me.Cbx_A2dpSampleRate.Items.Add("44.1 KHz")
        Me.Cbx_A2dpSampleRate.Items.Add("48 KHz")
        Me.Cbx_A2dpSampleRate.Location = New System.Drawing.Point(119, 18)
        Me.Cbx_A2dpSampleRate.Name = "Cbx_A2dpSampleRate"
        Me.Cbx_A2dpSampleRate.Size = New System.Drawing.Size(82, 22)
        Me.Cbx_A2dpSampleRate.TabIndex = 0
        '
        'Lbl_A2dpSampleRate
        '
        Me.Lbl_A2dpSampleRate.Location = New System.Drawing.Point(3, 20)
        Me.Lbl_A2dpSampleRate.Name = "Lbl_A2dpSampleRate"
        Me.Lbl_A2dpSampleRate.Size = New System.Drawing.Size(110, 20)
        Me.Lbl_A2dpSampleRate.Text = "サンプリングレート："
        '
        'Lbl_A2dp
        '
        Me.Lbl_A2dp.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_A2dp.Name = "Lbl_A2dp"
        Me.Lbl_A2dp.Size = New System.Drawing.Size(81, 20)
        Me.Lbl_A2dp.Text = "A2DPの設定"
        '
        'Tb_USB
        '
        Me.Tb_USB.Controls.Add(Me.Lbl_MassNotice)
        Me.Tb_USB.Controls.Add(Me.Lbl_USBStatus)
        Me.Tb_USB.Controls.Add(Me.Cbx_USBMode)
        Me.Tb_USB.Controls.Add(Me.Lbl_USBMode)
        Me.Tb_USB.Location = New System.Drawing.Point(0, 0)
        Me.Tb_USB.Name = "Tb_USB"
        Me.Tb_USB.Size = New System.Drawing.Size(312, 162)
        Me.Tb_USB.Text = "USB"
        '
        'Lbl_MassNotice
        '
        Me.Lbl_MassNotice.Location = New System.Drawing.Point(3, 74)
        Me.Lbl_MassNotice.Name = "Lbl_MassNotice"
        Me.Lbl_MassNotice.Size = New System.Drawing.Size(210, 62)
        Me.Lbl_MassNotice.Text = "※マスストレージモードは認識に1分以上掛かる事があります。このモードで接続中はデバイスからSDカードの内容を参照することが出来ません。"
        '
        'Lbl_USBStatus
        '
        Me.Lbl_USBStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_USBStatus.ForeColor = System.Drawing.Color.Red
        Me.Lbl_USBStatus.Location = New System.Drawing.Point(3, 54)
        Me.Lbl_USBStatus.Name = "Lbl_USBStatus"
        Me.Lbl_USBStatus.Size = New System.Drawing.Size(210, 20)
        Me.Lbl_USBStatus.Text = "※USB接続中は設定変更できません"
        Me.Lbl_USBStatus.Visible = False
        '
        'Cbx_USBMode
        '
        Me.Cbx_USBMode.Items.Add("ActiveSync (RemoteNDIS)")
        Me.Cbx_USBMode.Items.Add("ActiveSync (シリアル接続)")
        Me.Cbx_USBMode.Items.Add("USB モデム")
        Me.Cbx_USBMode.Items.Add("マスストレージ (miniSD リーダライタ)")
        Me.Cbx_USBMode.Location = New System.Drawing.Point(3, 29)
        Me.Cbx_USBMode.Name = "Cbx_USBMode"
        Me.Cbx_USBMode.Size = New System.Drawing.Size(210, 22)
        Me.Cbx_USBMode.TabIndex = 0
        '
        'Lbl_USBMode
        '
        Me.Lbl_USBMode.Location = New System.Drawing.Point(3, 6)
        Me.Lbl_USBMode.Name = "Lbl_USBMode"
        Me.Lbl_USBMode.Size = New System.Drawing.Size(100, 20)
        Me.Lbl_USBMode.Text = "USB接続モード："
        '
        'Tb_HID
        '
        Me.Tb_HID.Controls.Add(Me.Cbx_MouseCursor)
        Me.Tb_HID.Controls.Add(Me.Lbl_MouseCursor)
        Me.Tb_HID.Location = New System.Drawing.Point(0, 0)
        Me.Tb_HID.Name = "Tb_HID"
        Me.Tb_HID.Size = New System.Drawing.Size(312, 162)
        Me.Tb_HID.Text = "HID"
        '
        'Cbx_MouseCursor
        '
        Me.Cbx_MouseCursor.Items.Add("1 秒")
        Me.Cbx_MouseCursor.Items.Add("5 秒")
        Me.Cbx_MouseCursor.Items.Add("10 秒")
        Me.Cbx_MouseCursor.Items.Add("15 秒")
        Me.Cbx_MouseCursor.Items.Add("30 秒")
        Me.Cbx_MouseCursor.Items.Add("1 分")
        Me.Cbx_MouseCursor.Items.Add("3 分")
        Me.Cbx_MouseCursor.Items.Add("1 時間")
        Me.Cbx_MouseCursor.Location = New System.Drawing.Point(141, 3)
        Me.Cbx_MouseCursor.Name = "Cbx_MouseCursor"
        Me.Cbx_MouseCursor.Size = New System.Drawing.Size(65, 22)
        Me.Cbx_MouseCursor.TabIndex = 0
        '
        'Lbl_MouseCursor
        '
        Me.Lbl_MouseCursor.Location = New System.Drawing.Point(3, 4)
        Me.Lbl_MouseCursor.Name = "Lbl_MouseCursor"
        Me.Lbl_MouseCursor.Size = New System.Drawing.Size(132, 20)
        Me.Lbl_MouseCursor.Text = "マウスポインタ表示時間"
        '
        'Tb_Audio
        '
        Me.Tb_Audio.Controls.Add(Me.Lbl_InputLevel)
        Me.Tb_Audio.Controls.Add(Me.Lbl_OutputLevel)
        Me.Tb_Audio.Controls.Add(Me.Trb_InputVolume)
        Me.Tb_Audio.Controls.Add(Me.Trb_OutVolume)
        Me.Tb_Audio.Controls.Add(Me.Lbl_InputVolumeSize)
        Me.Tb_Audio.Controls.Add(Me.Lbl_OutputVolumeSize)
        Me.Tb_Audio.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Audio.Name = "Tb_Audio"
        Me.Tb_Audio.Size = New System.Drawing.Size(312, 162)
        Me.Tb_Audio.Text = "音量"
        '
        'Lbl_InputLevel
        '
        Me.Lbl_InputLevel.Location = New System.Drawing.Point(198, 104)
        Me.Lbl_InputLevel.Name = "Lbl_InputLevel"
        Me.Lbl_InputLevel.Size = New System.Drawing.Size(93, 22)
        Me.Lbl_InputLevel.Text = "InputLevel"
        '
        'Lbl_OutputLevel
        '
        Me.Lbl_OutputLevel.Location = New System.Drawing.Point(198, 23)
        Me.Lbl_OutputLevel.Name = "Lbl_OutputLevel"
        Me.Lbl_OutputLevel.Size = New System.Drawing.Size(93, 22)
        Me.Lbl_OutputLevel.Text = "OutputLevel"
        '
        'Trb_InputVolume
        '
        Me.Trb_InputVolume.LargeChange = 1
        Me.Trb_InputVolume.Location = New System.Drawing.Point(3, 98)
        Me.Trb_InputVolume.Maximum = 5
        Me.Trb_InputVolume.Name = "Trb_InputVolume"
        Me.Trb_InputVolume.Size = New System.Drawing.Size(185, 28)
        Me.Trb_InputVolume.TabIndex = 1
        Me.Trb_InputVolume.Value = 3
        '
        'Trb_OutVolume
        '
        Me.Trb_OutVolume.Enabled = False
        Me.Trb_OutVolume.LargeChange = 1
        Me.Trb_OutVolume.Location = New System.Drawing.Point(3, 18)
        Me.Trb_OutVolume.Maximum = 5
        Me.Trb_OutVolume.Name = "Trb_OutVolume"
        Me.Trb_OutVolume.Size = New System.Drawing.Size(185, 28)
        Me.Trb_OutVolume.TabIndex = 0
        Me.Trb_OutVolume.Value = 3
        '
        'Lbl_InputVolumeSize
        '
        Me.Lbl_InputVolumeSize.Location = New System.Drawing.Point(3, 74)
        Me.Lbl_InputVolumeSize.Name = "Lbl_InputVolumeSize"
        Me.Lbl_InputVolumeSize.Size = New System.Drawing.Size(64, 21)
        Me.Lbl_InputVolumeSize.Text = "入力音量"
        '
        'Lbl_OutputVolumeSize
        '
        Me.Lbl_OutputVolumeSize.Location = New System.Drawing.Point(3, 4)
        Me.Lbl_OutputVolumeSize.Name = "Lbl_OutputVolumeSize"
        Me.Lbl_OutputVolumeSize.Size = New System.Drawing.Size(64, 21)
        Me.Lbl_OutputVolumeSize.Text = "出力音量"
        '
        'Tb_Network
        '
        Me.Tb_Network.Controls.Add(Me.Pnl_RWIN)
        Me.Tb_Network.Location = New System.Drawing.Point(0, 0)
        Me.Tb_Network.Name = "Tb_Network"
        Me.Tb_Network.Size = New System.Drawing.Size(312, 162)
        Me.Tb_Network.Text = "TCP/IP"
        '
        'Pnl_RWIN
        '
        Me.Pnl_RWIN.BackColor = System.Drawing.Color.Gainsboro
        Me.Pnl_RWIN.Controls.Add(Me.Txt_RWIN)
        Me.Pnl_RWIN.Controls.Add(Me.Nu_RWIN)
        Me.Pnl_RWIN.Controls.Add(Me.Lb_RWIN)
        Me.Pnl_RWIN.Controls.Add(Me.Lbl_HSDPA)
        Me.Pnl_RWIN.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_RWIN.Name = "Pnl_RWIN"
        Me.Pnl_RWIN.Size = New System.Drawing.Size(234, 116)
        '
        'Txt_RWIN
        '
        Me.Txt_RWIN.Location = New System.Drawing.Point(3, 41)
        Me.Txt_RWIN.MaxLength = 10
        Me.Txt_RWIN.Name = "Txt_RWIN"
        Me.Txt_RWIN.Size = New System.Drawing.Size(142, 21)
        Me.Txt_RWIN.TabIndex = 0
        Me.Txt_RWIN.Text = "0"
        '
        'Nu_RWIN
        '
        Me.Nu_RWIN.Increment = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.Nu_RWIN.Location = New System.Drawing.Point(4, 68)
        Me.Nu_RWIN.Maximum = New Decimal(New Integer() {16777215, 0, 0, 0})
        Me.Nu_RWIN.Name = "Nu_RWIN"
        Me.Nu_RWIN.Size = New System.Drawing.Size(141, 22)
        Me.Nu_RWIN.TabIndex = 0
        Me.Nu_RWIN.Visible = False
        '
        'Lb_RWIN
        '
        Me.Lb_RWIN.Location = New System.Drawing.Point(3, 0)
        Me.Lb_RWIN.Name = "Lb_RWIN"
        Me.Lb_RWIN.Size = New System.Drawing.Size(81, 18)
        Me.Lb_RWIN.Text = "RWINの設定"
        '
        'Lbl_HSDPA
        '
        Me.Lbl_HSDPA.Location = New System.Drawing.Point(3, 18)
        Me.Lbl_HSDPA.Name = "Lbl_HSDPA"
        Me.Lbl_HSDPA.Size = New System.Drawing.Size(199, 20)
        Me.Lbl_HSDPA.Text = "GlobeTrotter Module 3G+ Modem"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(320, 188)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "Tweak ELF"
        Me.Tb_Remote.ResumeLayout(False)
        Me.Tb_WLAN.ResumeLayout(False)
        Me.Tb_GFSDK.ResumeLayout(False)
        Me.Tb_Misc.ResumeLayout(False)
        Me.Pnl_DisableSlideRotation.ResumeLayout(False)
        Me.Tb_ShCamera.ResumeLayout(False)
        Me.PnlSHCameraCommon.ResumeLayout(False)
        Me.PnlVideo.ResumeLayout(False)
        Me.PnlPicture.ResumeLayout(False)
        Me.Tb_Device.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.Tb_GUI.ResumeLayout(False)
        Me.Tb_Fonts.ResumeLayout(False)
        Me.Tb_Strage.ResumeLayout(False)
        Me.Tb_NVDDI.ResumeLayout(False)
        Me.Tb_Bluetooth.ResumeLayout(False)
        Me.Pnl_AGateway.ResumeLayout(False)
        Me.Pnl_A2dp.ResumeLayout(False)
        Me.Tb_USB.ResumeLayout(False)
        Me.Tb_HID.ResumeLayout(False)
        Me.Tb_Audio.ResumeLayout(False)
        Me.Tb_Network.ResumeLayout(False)
        Me.Pnl_RWIN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ML_File As System.Windows.Forms.MenuItem
    Friend WithEvents MR_Menu As System.Windows.Forms.MenuItem
    Friend WithEvents ML_Exit As System.Windows.Forms.MenuItem
    Friend WithEvents ML_Line1 As System.Windows.Forms.MenuItem
    Friend WithEvents ML_Reset As System.Windows.Forms.MenuItem
    Friend WithEvents MR_About As System.Windows.Forms.MenuItem
    Friend WithEvents ML_TurnOff As System.Windows.Forms.MenuItem
    Friend WithEvents ML_Power As System.Windows.Forms.MenuItem
    Friend WithEvents ML_Reload As System.Windows.Forms.MenuItem
    Friend WithEvents ML_DisposeValues As System.Windows.Forms.MenuItem
    Friend WithEvents ML_WriteValues As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Tb_Remote As System.Windows.Forms.TabPage
    Friend WithEvents Nu_MinSendInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Nu_BitmapCacheSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Nu_BitmapPersistCacheSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_MinSendInterval As System.Windows.Forms.Label
    Friend WithEvents Lbl_BitmapCacheSize As System.Windows.Forms.Label
    Friend WithEvents Lbl_BitmapPersistCacheSize As System.Windows.Forms.Label
    Friend WithEvents Tb_WLAN As System.Windows.Forms.TabPage
    Friend WithEvents Nu_WLANScanInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_WLANScanInterval As System.Windows.Forms.Label
    Friend WithEvents Tb_GFSDK As System.Windows.Forms.TabPage
    Friend WithEvents Ch_GFSDK_H264_DEC_USE_DSP As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_GFSDK_USE_DSP As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_GFSDK_USE_DSP_INTERRUPT As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_GFSDK_VC1_DEC_USE_DSP As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY As System.Windows.Forms.CheckBox
    Friend WithEvents Tb_Misc As System.Windows.Forms.TabPage
    Friend WithEvents Ch_BFlagSlide As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_DisableSetLSbyS_Notice As System.Windows.Forms.Label
    Friend WithEvents Ch_DisableSetLSbySlide As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_DisableSHRecive As System.Windows.Forms.CheckBox
    Friend WithEvents Tb_ShCamera As System.Windows.Forms.TabPage
    Friend WithEvents PnlSHCameraCommon As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Store As System.Windows.Forms.Label
    Friend WithEvents PnlVideo As System.Windows.Forms.Panel
    Friend WithEvents Ch_AudioEnable As System.Windows.Forms.CheckBox
    Friend WithEvents Cbx_VideoTime As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_VideoTime As System.Windows.Forms.Label
    Friend WithEvents PnlPicture As System.Windows.Forms.Panel
    Friend WithEvents Lbl_ZoomNotice As System.Windows.Forms.Label
    Friend WithEvents Cbx_StillQuality As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_StillSize As System.Windows.Forms.Label
    Friend WithEvents Lbl_StillQuality As System.Windows.Forms.Label
    Friend WithEvents Cbx_StillSize As System.Windows.Forms.ComboBox
    Friend WithEvents Cbx_Store As System.Windows.Forms.ComboBox
    Friend WithEvents Ch_MobileMode As System.Windows.Forms.CheckBox
    Friend WithEvents Tb_Device As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Platform As System.Windows.Forms.Label
    Friend WithEvents Lbl_AkuVer As System.Windows.Forms.Label
    Friend WithEvents Lbl_NorVer As System.Windows.Forms.Label
    Friend WithEvents Lbl_NandVer As System.Windows.Forms.Label
    Friend WithEvents Lbl_FlashVer As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Lbl_SHCameraCommon As System.Windows.Forms.Label
    Friend WithEvents Lbl_Picture As System.Windows.Forms.Label
    Friend WithEvents Lbl_Video As System.Windows.Forms.Label
    Friend WithEvents Tb_GUI As System.Windows.Forms.TabPage
    Friend WithEvents Tb_Strage As System.Windows.Forms.TabPage
    Friend WithEvents Ch_EnableFileSystemCache As System.Windows.Forms.CheckBox
    Friend WithEvents Cbx_FileSystemCacheSize As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_FileSystemCacheSize As System.Windows.Forms.Label
    Friend WithEvents Ch_EnableRealVGA As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_EnableWindowAnimation As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_EnableMenuAnimation As System.Windows.Forms.CheckBox
    Friend WithEvents Tb_USB As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_USBMode As System.Windows.Forms.Label
    Friend WithEvents Cbx_USBMode As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_USBStatus As System.Windows.Forms.Label
    Friend WithEvents Lbl_Notice As System.Windows.Forms.Label
    Friend WithEvents Lbl_MassNotice As System.Windows.Forms.Label
    Friend WithEvents Pnl_DisableSlideRotation As System.Windows.Forms.Panel
    Friend WithEvents Btn_DeleteTaskSwitch As System.Windows.Forms.Button
    Friend WithEvents Lbl_DeleteTaskSwitch As System.Windows.Forms.Label
    Friend WithEvents Tb_Bluetooth As System.Windows.Forms.TabPage
    Friend WithEvents Pnl_A2dp As System.Windows.Forms.Panel
    Friend WithEvents Lbl_A2dpSampleRate As System.Windows.Forms.Label
    Friend WithEvents Lbl_A2dp As System.Windows.Forms.Label
    Friend WithEvents Cbx_A2dpStereoMode As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_A2dpStereoMode As System.Windows.Forms.Label
    Friend WithEvents Cbx_A2dpSampleRate As System.Windows.Forms.ComboBox
    Friend WithEvents Pnl_AGateway As System.Windows.Forms.Panel
    Friend WithEvents Nu_A2dpBitPool As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_A2dpBitPool As System.Windows.Forms.Label
    Friend WithEvents Lbl_RemoteNotice As System.Windows.Forms.Label
    Friend WithEvents Lbl_AudioGateway As System.Windows.Forms.Label
    Friend WithEvents Nu_A2dpMaxBitPool As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_A2dpMaxBitPool As System.Windows.Forms.Label
    Friend WithEvents Tb_Fonts As System.Windows.Forms.TabPage
    Friend WithEvents Ch_ClearTypeOffOnRotation As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_EnableClearTypeIEText As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_NoClearType As System.Windows.Forms.CheckBox
    Friend WithEvents Cbx_FontCacheSize As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_FontCacheSize As System.Windows.Forms.Label
    Friend WithEvents Ch_EnableSip As System.Windows.Forms.CheckBox
    Friend WithEvents Tb_HID As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_MouseCursor As System.Windows.Forms.Label
    Friend WithEvents Cbx_MouseCursor As System.Windows.Forms.ComboBox
    Friend WithEvents Tb_Audio As System.Windows.Forms.TabPage
    Friend WithEvents Trb_OutVolume As System.Windows.Forms.TrackBar
    Friend WithEvents Lbl_InputVolumeSize As System.Windows.Forms.Label
    Friend WithEvents Lbl_OutputVolumeSize As System.Windows.Forms.Label
    Friend WithEvents Trb_InputVolume As System.Windows.Forms.TrackBar
    Friend WithEvents Tb_Network As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_HSDPA As System.Windows.Forms.Label
    Friend WithEvents Pnl_RWIN As System.Windows.Forms.Panel
    Friend WithEvents Lb_RWIN As System.Windows.Forms.Label
    Friend WithEvents Nu_RWIN As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_OutputLevel As System.Windows.Forms.Label
    Friend WithEvents Lbl_InputLevel As System.Windows.Forms.Label
    Friend WithEvents Txt_RWIN As System.Windows.Forms.TextBox
    Friend WithEvents Ch_NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED As System.Windows.Forms.CheckBox
    Friend WithEvents Tb_NVDDI As System.Windows.Forms.TabPage
    Friend WithEvents Ch_ENHANCE_2D_PERF As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_USE_VIDEO_MEMORY_FOR_GPE As System.Windows.Forms.CheckBox
    Friend WithEvents Cbx_EMBEDED_LCD As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_EMBEDED_LCD As System.Windows.Forms.Label
    Friend WithEvents Ch_GFSDK_MP4_DEC_USE_DSP As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_PLL2_FREQ As System.Windows.Forms.Label
    Friend WithEvents Cbx_PLL2_FREQ As System.Windows.Forms.ComboBox

End Class
