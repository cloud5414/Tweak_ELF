#Region "名前空間のインポート"
Imports Microsoft.Win32
Imports System.Runtime.InteropServices

#End Region

Module Common
#Region "共通変数"
    Public AppTitle As String = "Tweak ELF"
    Public AppVer As String = "1.7.3"
    Public AppCopyright As String = "Copyright(C) Project Skynet 2007-2008"

    Public F_Main As New FrmMain

    'デバイス情報
    'Public Flash As Integer
    'Public NOR As Integer
    Public AKU As String

    'SHカメラ
    Public AudioEnable As Integer
    Public ForceStopVideo As Integer
    Public MobileMode As Integer
    Public StillSize As Integer
    Public StillQuality As Integer
    Public Store As Integer
    Public VideoTime As Integer

    'Misc
    Public DisableSHReceive As Integer
    Public DisableSetLSbySlide As Integer
    Public BFlagSlide As Integer

    'GFSDK
    Public USE_DSP As Integer
    Public USE_DSP_INTERRUPT As Integer
    Public VC1_DEC_USE_DSP As Integer
    Public H264_DEC_USE_DSP As Integer
    Public MP4_DEC_USE_DSP As Integer
    Public NVWMV_DOUBLEBUFFER_OVERLAY As Integer
    Public NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED As Integer
    Public GFSDK_3D_PERF_MODE As Integer
    Public GFSDK_PLL2_FREQ As Integer

    'NVDDI
    Public EMBEDED_LCD As String
    Public ENHANCE_2D_PERF As Integer
    Public USE_VIDEO_MEMORY_FOR_GPE As Integer

    '無線LAN
    Public WLAN_ScanInterval As Integer

    'リモートデスクトップ
    Public BitmapPersistCacheSize As Integer
    Public BitmapCacheSize As Integer
    Public MinSendInterval As Integer

    'GUI - 表示
    Public MenuAnimationMode As Integer
    Public DisplayMode As Integer
    Public DisplayDPI() As Integer = {192, 96}
    Public EnableWindowAnimation As Integer
    Public EnableMenuAnimation As Integer

    'GUI - フォント
    Public FontCacheSize As Integer
    Public CacheSize() As Integer = {0, 8192, 16384, 32768, 131072, 1048576, 2097152, 4194304, 8388608, 16777216}
    Public NoClearType As Integer
    Public EnableClearTypeIEText As Integer
    Public ClearTypeOffOnRotation As Integer
    Public AllowChange As Integer

    'ストレージ
    Public EnableFileSystemCache As Integer
    Public FileSystemCacheSize As Decimal
    Public DiskCacheSize() As Decimal = {0, 128, 256, 512, 1024, 2048, 4096, 8192}

    'USB
    Public USBMode As String
    Public USBState As Integer
    Public USBModeName() As String = {"RNDIS", "Serial_Class", "USBSER_Class", "Mass_Storage_Class"}

    'Bluetooth
    Public BluetoothStatus As Integer
    Public A2dpSampleRate As Integer
    Public A2dpStereoMode As Integer
    Public A2dpBitPool As Integer
    Public A2dpMaxBitPool As Integer
    Public SampleRate() As Integer = {0, 44100, 48000}

    'パワーマネジメント
    Public Const POWER_STATE_RESET As Integer = &H800000

    'HID - マウス
    Public MouseCursorShowTime() As Integer = {1000, 5000, 10000, 15000, 30000, 60000, 180000, 3600000}
    Public MouseCursorTimeout As Integer

    '音量
    Public OutputVolumeSize() As Long = {0, 858993459, 1717986918, -1717986919, -858993460, -1}
    Public InputVolumeSize() As Integer = {0, 10922, 21845, 32767, 43690, 65535}
    Public OutputVolume As Long
    Public InputVolume As Integer

    'TCP - RWIN
    Public TcpWindowSize As Decimal

    'Opera.ini
    'Public OperaIniPath As String = "\\Applicattion Data\Opera\Opera.ini"

#End Region

#Region "ライブラリの宣言"

    Declare Function SetSystemPowerState Lib "Coredll.dll" (ByVal psState As String, ByVal stateFlags As Integer, ByVal options As Integer) As Integer
    Declare Function KernelIoControl     Lib "CoreDll.dll" (ByVal dwIoControlCode As Int32, ByVal lpInBuf As IntPtr, ByVal nInBufSize As Int32, ByVal lpOutBuf() As Byte, ByVal nOutBufSize As Int32, ByRef lpBytesReturned As Int32) As Boolean
    Declare Sub      GwesPowerOffSystem  Lib "CoreDll.dll" ()
    'Declare Sub GetFlashVer Lib "SHGETVERLIB.dll" ()
    'Declare Sub GetNorVer Lib "SHGETVERLIB.dll" ()
    'Declare Sub GetRomVer Lib "SHGETVERLIB.dll" ()

    '<DllImport("SHGETVERLIB.dll", CharSet:=CharSet.Auto)> Public Function GetNorVer() As String
    'End Function

    '<DllImport("SHGETVERLIB.dll", CharSet:=CharSet.Auto)> Public Function GetFlashVer() As String
    'End Function

    '<DllImport("SHGETVERLIB.dll", CharSet:=CharSet.Auto)> Public Function GetRomVer() As String
    'End Function

#End Region

    Public Sub Main()
        Try
            'スプラッシュ画面を表示する
            'Dim _Splsh As New SplashScreen
            '_Splsh.Show()

            'レジストリの値を取得する
            LoadRegistryValues()

            'NANDバージョンを取得する
            'NAND = GetRomVer()

            'メインフォームを表示する
            Application.Run(F_Main)

        Catch ex As Exception
            'システムメッセージを表示する
            MsgBox(ex.Message.ToString())

        End Try
    End Sub

    Public Sub LoadRegistryValues()
        'レジストリから値を取得し、変数へ格納します
        Try
            'デバイス情報
            AKU = Registry.GetValue("HKEY_LOCAL_MACHINE\System\Versions", "Aku", "UnKnown")

            'SHカメラ設定
            AudioEnable = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "AudioEnable", 0)
            ForceStopVideo = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "ForceStopVideo", 0)
            MobileMode = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "MobileMode", 0)
            StillSize = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "StillSize", 0)
            StillQuality = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "StillQuality", 0)
            Store = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "Store", 0)
            VideoTime = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "VideoTime", 0)

            'Misc設定
            DisableSHReceive = Registry.GetValue("HKEY_CURRENT_USER\Software\Sharp\PhoneStatus", "DisableSHReceive", 0)
            DisableSetLSbySlide = Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DEVICEMAP\KEYBD", "DisableSetLSbySlide", 0)
            BFlagSlide = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\BuiltIn\Battery", "BFlagSlide", 0)

            'GFSDK設定
            USE_DSP = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_USE_DSP", 0)
            USE_DSP_INTERRUPT = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_USE_DSP_INTERRUPT", 0)
            VC1_DEC_USE_DSP = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_VC1_DEC_USE_DSP", 0)
            H264_DEC_USE_DSP = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_H264_DEC_USE_DSP", 0)
            MP4_DEC_USE_DSP = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_MP4_DEC_USE_DSP", 0)
            NVWMV_DOUBLEBUFFER_OVERLAY = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY", 0)
            NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED", 0)
            'GFSDK_PLL2_FREQ = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_PLL2_FREQ", 24000)

            'NVDDI
            ENHANCE_2D_PERF = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\NVDDI", "ENHANCE_2D_PERF", 0)
            USE_VIDEO_MEMORY_FOR_GPE = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\NVDDI", "USE_VIDEO_MEMORY_FOR_GPE", 0)
            EMBEDED_LCD = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\Display\Active\組み込み LCD", "Dll", "ddi.dll")

            '無線LAN設定
            WLAN_ScanInterval = Registry.GetValue("HKEY_LOCAL_MACHINE\ControlPanel\WiFi", "ScanInterval", 0)

            'リモートデスクトップ設定
            BitmapPersistCacheSize = Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Terminal Server Client", "BitmapPersistCacheSize", 0)
            BitmapCacheSize = Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Terminal Server Client", "BitmapCacheSize", 0)
            MinSendInterval = Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Terminal Server Client", "Min Send Interval", 0)

            'GUI - 表示
            DisplayMode = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\Display\GPE", "LogicalPixelsY", 192)
            EnableWindowAnimation = Registry.GetValue("HKEY_LOCAL_MACHINE\System\GWE", "Animate", 0)
            EnableMenuAnimation = Registry.GetValue("HKEY_LOCAL_MACHINE\System\GWE\Menu", "Anitype", 0)

            'GUI - フォント
            FontCacheSize = Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\GDI\GLYPHCACHE\", "limit", 0)
            NoClearType = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Shell", "NoClearType", 0)
            EnableClearTypeIEText = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ClearTypeText", 0)
            ClearTypeOffOnRotation = Registry.GetValue("HKEY_LOCAL_MACHINE\System\GDI\ClearTypeSettings", "OffOnRotation", 0)
            AllowChange = Registry.GetValue("HKEY_CURRENT_USER\ControlPanel\Sip", "AllowChange", 0)

            'ストレージ
            EnableFileSystemCache = Registry.GetValue("HKEY_LOCAL_MACHINE\System\StorageManager\FATFS\", "EnableCache", 0)
            FileSystemCacheSize = Registry.GetValue("HKEY_LOCAL_MACHINE\System\StorageManager\FATFS\", "CacheSize", 0)

            'USB
            USBMode = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\USB\FunctionDrivers", "DefaultClientDriver", "RNDIS")
            USBState = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\USB\FunctionDrivers", "UsbCableDetect", 0)

            'Bluetooth
            A2dpSampleRate = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "SampleRate", 0)
            A2dpStereoMode = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "UseJointStereo", 0)
            A2dpBitPool = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "BitPool", 0)
            A2dpMaxBitPool = Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "MaxBitPool", 0)

            'HID - マウス
            MouseCursorTimeout = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\HID", "CursorTimeout", 1)

            '音量
            OutputVolume = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\BuiltIn\WaveDev\ShConfig", "InitVolume", 0)
            InputVolume = Registry.GetValue("HKEY_LOCAL_MACHINE\Drivers\BuiltIn\WaveDev\ShConfig", "InputVolume", 0)

            'TCP - RWIN
            TcpWindowSize = Registry.GetValue("HKEY_LOCAL_MACHINE\Comm\GlobeTrotter Module 3G+ Modem\Parms\TcpIp", "TCPWindowSize", 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub WriteRegistryValues()
        Try
            'SHカメラ設定
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "AudioEnable", AudioEnable, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "ForceStopVideo", ForceStopVideo, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "MobileMode", MobileMode, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "StillSize", StillSize, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "StillQuality", StillQuality, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "Store", Store, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\Camera", "VideoTime", VideoTime, RegistryValueKind.DWord)

            'Misc設定
            Registry.SetValue("HKEY_CURRENT_USER\Software\Sharp\PhoneStatus", "DisableSHReceive", DisableSHReceive, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\HARDWARE\DEVICEMAP\KEYBD", "DisableSetLSbySlide", DisableSetLSbySlide, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\BuiltIn\Battery", "BFlagSlide", BFlagSlide, RegistryValueKind.DWord)

            'GFSDK設定
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_USE_DSP", USE_DSP, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_USE_DSP_INTERRUPT", USE_DSP_INTERRUPT, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_VC1_DEC_USE_DSP", VC1_DEC_USE_DSP, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_H264_DEC_USE_DSP", H264_DEC_USE_DSP, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_MP4_DEC_USE_DSP", MP4_DEC_USE_DSP, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_NVWMV_DOUBLEBUFFER_OVERLAY", NVWMV_DOUBLEBUFFER_OVERLAY, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED", NVDSHOW_DISPLAY_FULL_SCREEN_STRETCHED, RegistryValueKind.DWord)
            'Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\GFSDK", "GFSDK_PLL2_FREQ", GFSDK_PLL2_FREQ, RegistryValueKind.DWord)

            'NVDDI
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\NVDDI", "ENHANCE_2D_PERF", ENHANCE_2D_PERF, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\NVIDIA Corporation\NVDDI", "USE_VIDEO_MEMORY_FOR_GPE", USE_VIDEO_MEMORY_FOR_GPE, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\Display\Active\組み込み LCD", "Dll", EMBEDED_LCD, RegistryValueKind.String)

            '無線LAN設定
            Registry.SetValue("HKEY_LOCAL_MACHINE\ControlPanel\WiFi", "ScanInterval", WLAN_ScanInterval, RegistryValueKind.DWord)

            'リモートデスクトップ設定
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Terminal Server Client", "BitmapCacheSize", BitmapCacheSize, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Terminal Server Client", "BitmapPersistCacheSize", BitmapPersistCacheSize, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Terminal Server Client", "Min Send Interval", MinSendInterval, RegistryValueKind.DWord)

            'GUI - 表示
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\Display\GPE", "LogicalPixelsY", DisplayMode, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\Display\GPE", "LogicalPixelsX", DisplayMode, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\System\GWE", "Animate", EnableWindowAnimation, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\System\GWE\Menu", "Anitype", EnableMenuAnimation, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_CURRENT_USER\ControlPanel\Sip", "AllowChange", AllowChange, RegistryValueKind.DWord)

            'GUI - フォント
            Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\GDI\GLYPHCACHE\", "limit", FontCacheSize, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Shell", "NoClearType", NoClearType, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ClearTypeText", EnableClearTypeIEText, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\System\GDI\ClearTypeSettings", "OffOnRotation", ClearTypeOffOnRotation, RegistryValueKind.DWord)

            'ストレージ
            Registry.SetValue("HKEY_LOCAL_MACHINE\System\StorageManager\FATFS\", "EnableCache", EnableFileSystemCache, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\System\StorageManager\FATFS\", "CacheSize", FileSystemCacheSize, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\System\StorageManager\Filters\fsreplxfilt\", "ReplStoreCacheSize", FileSystemCacheSize, RegistryValueKind.DWord)

            'USB
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\USB\FunctionDrivers", "DefaultClientDriver", USBMode, RegistryValueKind.String)

            'Bluetooth
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "SampleRate", A2dpSampleRate, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "UseJointStereo", A2dpStereoMode, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "BitPool", A2dpBitPool, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Bluetooth\A2DP\Settings", "MaxBitPool", A2dpMaxBitPool, RegistryValueKind.DWord)

            'HID - マウス
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\HID", "CursorTimeout", MouseCursorTimeout, RegistryValueKind.DWord)

            '音量
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\BuiltIn\WaveDev\ShConfig", "InitVolume", OutputVolume, RegistryValueKind.DWord)
            Registry.SetValue("HKEY_LOCAL_MACHINE\Drivers\BuiltIn\WaveDev\ShConfig", "InputVolume", InputVolume, RegistryValueKind.DWord)

            'TCP - RWIN
            Registry.SetValue("HKEY_LOCAL_MACHINE\Comm\GlobeTrotter Module 3G+ Modem\Parms\TcpIp", "TCPWindowSize", TcpWindowSize, RegistryValueKind.DWord)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Class PlatformDetector

        Declare Function SystemParametersInfo Lib "Coredll.dll" (ByVal uiAction As System.UInt32, ByVal uiParam As System.UInt32, ByVal pvParam As System.Text.StringBuilder, ByVal fWinIni As System.UInt32) As Boolean

        Private Shared SPI_GETPLATFORMTYPE As System.UInt32 = 257

        Public Shared Function GetPlatform() As Platform
            Dim plat As Platform = Platform.Unknown
            Select Case System.Environment.OSVersion.Platform
                Case PlatformID.Win32NT
                    plat = Platform.Win32NT
                Case PlatformID.Win32S
                    plat = Platform.Win32S
                Case PlatformID.Win32Windows
                    plat = Platform.Win32Windows
                Case PlatformID.WinCE
                    plat = CheckWinCEPlatform()
            End Select

            Return plat

        End Function

        Shared Function CheckWinCEPlatform() As Platform
            Dim plat As Platform = Platform.WindowsCE
            Dim strbuild As New System.Text.StringBuilder(200)
            SystemParametersInfo(SPI_GETPLATFORMTYPE, 200, strbuild, 0)
            Dim str As String = strbuild.ToString()
            Select Case str
                Case "PocketPC"
                    plat = Platform.PocketPC
                Case "SmartPhone"
                    plat = Platform.Smartphone
            End Select
            Return plat

        End Function
    End Class

    Public Enum Platform
        PocketPC
        WindowsCE
        Smartphone
        Win32NT
        Win32S
        Win32Windows
        Unknown
    End Enum

    'INI ファイル操作の為の宣言
    '<DllImport("KERNEL32.DLL")> Public Function WritePrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    'End Function

    '<DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)> Public Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As System.Text.StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    'End Function

    '<DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)> Public Function GetPrivateProfileInt(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer
    'End Function

End Module
