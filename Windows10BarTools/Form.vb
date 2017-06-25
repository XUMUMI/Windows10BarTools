Imports IWshRuntimeLibrary
Imports System.Security.Cryptography
Imports System.Text
Imports System.ComponentModel
Imports Microsoft.Win32
Imports System.Security.Principal
Imports System.IO
Imports System.Threading


Public Class Form

    Public themecolor = 1
    Public lightcolor = 1
    Public stylecolor = 1

    'cmd 返回值
    Public Function Cmd(ByVal Command As String) As String
        Dim process As New Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardInput = True
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.Start()
        process.StandardInput.WriteLine(Command)
        process.StandardInput.WriteLine("exit")
        Dim Result As String = process.StandardOutput.ReadToEnd()
        process.Close()
        Return Result
    End Function


    '阴影
    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const GCL_STYLE As Integer = (-26)
    '声明Win32 API
    Public Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Public Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer

    Private Structure SYSTEM_INFO
        Dim dwOemID As Integer
        Dim dwPageSize As Integer
        Dim lpMinimumApplicationAddress As Integer
        Dim lpMaximumApplicationAddress As Integer
        Dim dwActiveProcessorMask As Integer
        Dim dwNumberOrfProcessors As Integer
        Dim dwProcessorType As Integer
        Dim dwAllocationGranularity As Integer
        Dim dwReserved As Integer
    End Structure

    Public WshShell As New WshShell
    Public fso As New FileSystemObject
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Dim 操作系统, CPU型号, CPU最大频率, 显卡型号im
    Dim wmi = GetObject("winmgmts:\\.\root\CIMV2")
    Private PfmcCounter As New PerformanceCounter("Processor", "% Processor Time", "_Total")
    Dim bit As String
    Dim page = 1
    Private Declare Sub GetSystemInfo Lib "kernel32" Alias "GetSystemInfo" (ByRef lpSystemInfo As SYSTEM_INFO)

    Private Sub Start_Tick(sender As Object, e As EventArgs) Handles Start.Tick
        Height = Height + 15
        Location = New Point(Location.X, Location.Y - 7)
        If Height >= 620 Then
            Start.Enabled = False
            Height = 620
            Location = New Point(Location.X, Screen.PrimaryScreen.WorkingArea.Height / 2 - 310)
        End If
    End Sub

    Public Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        '版本
        '  V.Text = String.Format("版本 {0}", My.Application.Info.Version.ToString)


        '调用阴影绘制
        SetClassLong(Handle, GCL_STYLE, GetClassLong(Handle, GCL_STYLE) Or CS_DROPSHADOW)

        Height = 140
        Location = New Point(Loading.Location.X - 40, Loading.Location.Y)
        '系统信息
        If Environment.Is64BitOperatingSystem = True Then bit = "X64" Else bit = "X86"
        Dim 版本 = WshShell.RegRead("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\ProductName")
        'Dim 补丁 = WshShell.RegRead("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\CSDVersion")
        操作系统 = 版本
        Systeminfo.Text = 操作系统 & " " & bit
        Dim 编号 = WshShell.RegRead("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\CurrentBuildNumber")
        Try
            If Not 编号 >= 10240 Then Updater.Enabled = True Else Updater.Enabled = False
        Catch ex As Exception
            Updater.Enabled = True
        End Try
        'CPU信息
        Dim cpu = wmi.ExecQuery("select * from win32_processor")
        For Each objItem In cpu
            CPU型号 = objItem.Name
        Next
        CPUINFO.Text = CPU型号
        '显卡信息
        Dim display = wmi.ExecQuery("select * from win32_VideoController")
        For Each i In display
            显卡型号im = i.Name
        Next
        显卡型号.Text = 显卡型号im
        '分辨率
        Dim dpi = CType(Registry.CurrentUser.OpenSubKey("Control Panel\Desktop\WindowMetrics").GetValue("AppliedDPI"), Integer)
        Dim Percent = dpi / 96
        屏幕分辨率.Text = "屏幕分辨率(" & Percent * 100 & "%)"
        For i As Integer = 1 To Screen.AllScreens.Count
            If XXY.Text = "检测中……" Then
                XXY.Text = Screen.AllScreens(i - 1).Bounds.Width * Percent & "×" & Screen.AllScreens(i - 1).Bounds.Height * Percent
            Else
                XXY.Text &= "," & Screen.AllScreens(i - 1).Bounds.Width * Percent & "×" & Screen.AllScreens(i - 1).Bounds.Height * Percent
            End If
        Next

        'System
        If 操作系统 = "Windows 10 Pro" Or 操作系统 = "Windows 10 Pro N" Or 操作系统 = "Windows 10 Enterprise" Or 操作系统 = "Windows 10 Enterprise N" Or 操作系统 = "Windows 10 Education" Or
          操作系统 = "Windows 10 Education N" Or 操作系统 = "Windows 10 Enterprise LSTB" Or 操作系统 = "Windows 10 Enterprise LSTB N" Then INSKMS.Enabled = True

        '主板信息
        Dim Bm = "检测中……"
        Dim boards = wmi.ExecQuery("select * from win32_BaseBoard")
        For Each i In boards
            If InStr(i.Manufacturer, "To be filled") Then
                Bm = "检测失败！"
            Else
                Bm = i.Manufacturer & " " & i.ProDuct
            End If
        Next
        Board.Text = Bm
    End Sub
    'shift
    Dim ShiftButton = 0
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Shift = True Then ShiftButton = 1
    End Sub

    Private Sub Form_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.Shift = False Then ShiftButton = 0
    End Sub

    '拖动
    Dim 鼠标X = MousePosition.X, 鼠标Y = MousePosition.Y

    Private Sub AMouseDown(sender As Object, e As MouseEventArgs) Handles Bar.MouseDown, logop.MouseDown, TUB.MouseDown, 工具标题.MouseDown, Settingst.MouseDown, SettingsUB.MouseDown
        鼠标X = e.X
        鼠标Y = e.Y
    End Sub
    Private Sub AMouseMove(sender As Object, e As MouseEventArgs) Handles Bar.MouseMove, logop.MouseMove, TUB.MouseMove, 工具标题.MouseMove, Settingst.MouseMove, SettingsUB.MouseMove
        If e.Button = MouseButtons.Left Then Location = New Point(Location.X + e.X - 鼠标X, Location.Y + e.Y - 鼠标Y)
    End Sub

    Private Sub ICard_MouseDown(sender As Object, e As MouseEventArgs) Handles ICard.MouseDown, 系统信息.MouseDown, 当前计算机名.MouseDown, ID.MouseDown, 当前用户.MouseDown,
User.MouseDown, 运行时间.MouseDown, Time.MouseDown, 屏幕分辨率.MouseDown, XXY.MouseDown, 系统版本.MouseDown, Systeminfo.MouseDown, 硬件信息.MouseDown, 显卡型号.MouseDown, 显卡.MouseDown,
内存信息.MouseDown, MBar.MouseDown, Memory.MouseDown, 中央处理器信息.MouseDown, CBar.MouseDown, CPUP.MouseDown, CPUINFO.MouseDown, CPU.MouseDown, 主板型号.MouseDown, Board.MouseDown
        鼠标Y = e.Y
    End Sub

    Private Sub ICard_MouseMove(sender As Object, e As MouseEventArgs) Handles ICard.MouseMove, 系统信息.MouseMove, 当前计算机名.MouseMove, ID.MouseMove, 当前用户.MouseMove,
User.MouseMove, 运行时间.MouseMove, Time.MouseMove, 屏幕分辨率.MouseMove, XXY.MouseMove, 系统版本.MouseMove, Systeminfo.MouseMove, 硬件信息.MouseMove, 显卡型号.MouseMove, 显卡.MouseMove,
内存信息.MouseMove, MBar.MouseMove, Memory.MouseMove, 中央处理器信息.MouseMove, CBar.MouseMove, CPUP.MouseMove, CPUINFO.MouseMove, CPU.MouseMove, 主板型号.MouseMove, Board.MouseMove
        If ICard.Location.Y + e.Y - 鼠标Y >= -385 And ICard.Location.Y + e.Y - 鼠标Y <= 115 Then If e.Button = MouseButtons.Left Then ICard.Location = New Point(ICard.Location.X, ICard.Location.Y + e.Y - 鼠标Y)
    End Sub

    Private Sub 窗口位置限制_Tick(sender As Object, e As EventArgs) Handles 窗口位置限制.Tick
        Dim 屏幕宽 = Screen.PrimaryScreen.WorkingArea.Width, 屏幕高 = Screen.PrimaryScreen.WorkingArea.Height
        If Not MouseButtons = MouseButtons.Left Then
            If Location.X < 0 Then Location = New Point(0, Location.Y)
            If Location.X + Width > 屏幕宽 Then Location = New Point(屏幕宽 - Width, Location.Y)
            If Location.Y + Height > 屏幕高 Then Location = New Point(Location.X, 屏幕高 - Height)
            If Location.Y < 0 Then Location = New Point(Location.X, 0)
        End If
    End Sub

    Private Sub 刷新_Tick(sender As Object, e As EventArgs) Handles 刷新.Tick
        '背景色
        test.FlatAppearance.BorderColor = test.BackColor
        Updater.FlatAppearance.BorderColor = Updater.BackColor
        INSKMS.FlatAppearance.BorderColor = INSKMS.BackColor
        AKAC.FlatAppearance.BorderColor = AKAC.BackColor
        MD5B.FlatAppearance.BorderColor = MD5B.BackColor
        Ohosts.FlatAppearance.BorderColor = Ohosts.BackColor
        clean.FlatAppearance.BorderColor = clean.BackColor
        UNUACICON.FlatAppearance.BorderColor = UNUACICON.BackColor
        gpedit.FlatAppearance.BorderColor = gpedit.BackColor
        regedit.FlatAppearance.BorderColor = regedit.BackColor
        颜色校正.FlatAppearance.BorderColor = 颜色校正.BackColor
        msconfig.FlatAppearance.BorderColor = msconfig.BackColor
        services.FlatAppearance.BorderColor = services.BackColor

        If 其他工具.ForeColor = Color.Black Then
            test.BackgroundImage = My.Resources.test
            Updater.BackgroundImage = My.Resources.Updater
            INSKMS.BackgroundImage = My.Resources.key
            AKAC.BackgroundImage = My.Resources.AKAC
            MD5B.BackgroundImage = My.Resources.MD5
            Ohosts.BackgroundImage = My.Resources.Hosts
            clean.BackgroundImage = My.Resources.Clean
            UNUACICON.BackgroundImage = My.Resources.NOUACICON
            gpedit.BackgroundImage = My.Resources.组策略
            regedit.BackgroundImage = My.Resources.regedit
            颜色校正.BackgroundImage = My.Resources.Color
            msconfig.BackgroundImage = My.Resources.实用配置工具
            services.BackgroundImage = My.Resources.Servers
        Else
            test.BackgroundImage = My.Resources.testw
            Updater.BackgroundImage = My.Resources.Updaterw
            INSKMS.BackgroundImage = My.Resources.keyw
            AKAC.BackgroundImage = My.Resources.AKACw
            MD5B.BackgroundImage = My.Resources.MD5w
            Ohosts.BackgroundImage = My.Resources.Hostsw
            clean.BackgroundImage = My.Resources.Cleanw
            UNUACICON.BackgroundImage = My.Resources.NOUACICONw
            gpedit.BackgroundImage = My.Resources.组策略w
            regedit.BackgroundImage = My.Resources.regeditw
            颜色校正.BackgroundImage = My.Resources.Colorw
            msconfig.BackgroundImage = My.Resources.实用配置工具w
            services.BackgroundImage = My.Resources.Serversw
        End If

        '主题色
        Bar.BackColor = Loading.FtC
        三.BackColor = Loading.FtC
        OneB.BackColor = Loading.FtC
        TwoB.BackColor = Loading.FtC
        ThreeB.BackColor = Loading.FtC
        MIN.BackColor = Loading.FtC
        ExitB.BackColor = Loading.FtC
        logop.BackColor = Loading.FtC
        Line1.BackColor = Loading.FtC
        BackColor = Loading.FtC
        三.FlatAppearance.BorderColor = Loading.FtC
        OneB.FlatAppearance.BorderColor = Loading.FtC
        TwoB.FlatAppearance.BorderColor = Loading.FtC
        ThreeB.FlatAppearance.BorderColor = Loading.FtC
        MIN.FlatAppearance.BorderColor = Loading.FtC
        ExitB.FlatAppearance.BorderColor = Loading.FtC

        If Loading.FtC.R >= 200 And Loading.FtC.G >= 200 And Loading.FtC.B >= 200 Then
            logop.BackgroundImage = My.Resources.XOLOGOb
            三.BackgroundImage = My.Resources.三_Lb
            OneB.BackgroundImage = My.Resources.Homeb
            TwoB.BackgroundImage = My.Resources.toolsb
            ThreeB.BackgroundImage = My.Resources.Settingsb
            MIN.BackgroundImage = My.Resources.MINb
            ExitB.BackgroundImage = My.Resources.Closeb
        Else
            logop.BackgroundImage = My.Resources.XOLOGO
            三.BackgroundImage = My.Resources.三_L
            OneB.BackgroundImage = My.Resources.Home
            TwoB.BackgroundImage = My.Resources.tools2
            ThreeB.BackgroundImage = My.Resources.Settings2
            MIN.BackgroundImage = My.Resources.MINw
            ExitB.BackgroundImage = My.Resources.Closew
        End If

        Try
            If stylecolor = 1 Then
                If lightcolor = 1 Then
                    SettingsUB.BackColor = Color.FromArgb(242, 242, 242)
                    TUB.BackColor = Color.FromArgb(242, 242, 242)
                    Settingst.BackColor = Color.FromArgb(242, 242, 242)
                    工具标题.BackColor = Color.FromArgb(242, 242, 242)
                    设置.BackColor = Color.White
                    其他工具.BackColor = Color.White
                    FColorG.BackColor = Color.White
                    BColorG.BackColor = Color.White
                    StyleG.BackColor = Color.White
                    ICard.BackColor = Color.White
                    设置.ForeColor = Color.Black
                    其他工具.ForeColor = Color.Black
                    FColorG.ForeColor = Color.Black
                    BColorG.ForeColor = Color.Black
                    StyleG.ForeColor = Color.Black
                    Settingst.ForeColor = Color.Black
                    工具标题.ForeColor = Color.Black
                    ICard.ForeColor = Color.Black
                Else
                    SettingsUB.BackColor = Color.FromArgb(64, 64, 64)
                    TUB.BackColor = Color.FromArgb(64, 64, 64)
                    Settingst.BackColor = Color.FromArgb(64, 64, 64)
                    工具标题.BackColor = Color.FromArgb(64, 64, 64)
                    设置.BackColor = Color.DimGray
                    其他工具.BackColor = Color.DimGray
                    FColorG.BackColor = Color.DimGray
                    BColorG.BackColor = Color.DimGray
                    StyleG.BackColor = Color.DimGray
                    ICard.BackColor = Color.DimGray
                    设置.ForeColor = Color.White
                    其他工具.ForeColor = Color.White
                    FColorG.ForeColor = Color.White
                    BColorG.ForeColor = Color.White
                    StyleG.ForeColor = Color.White
                    Settingst.ForeColor = Color.White
                    工具标题.ForeColor = Color.White
                    ICard.ForeColor = Color.White
                End If
            Else
                SettingsUB.BackColor = Loading.FtC
                TUB.BackColor = Loading.FtC
                Settingst.BackColor = Loading.FtC
                工具标题.BackColor = Loading.FtC
                设置.BackColor = Loading.FtC
                其他工具.BackColor = Loading.FtC
                FColorG.BackColor = Loading.FtC
                BColorG.BackColor = Loading.FtC
                StyleG.BackColor = Loading.FtC
                ICard.BackColor = Loading.FtC
                If Loading.FtC.R >= 200 And Loading.FtC.G >= 200 And Loading.FtC.B >= 200 Then
                    设置.ForeColor = Color.Black
                    其他工具.ForeColor = Color.Black
                    FColorG.ForeColor = Color.Black
                    BColorG.ForeColor = Color.Black
                    StyleG.ForeColor = Color.Black
                    Settingst.ForeColor = Color.Black
                    工具标题.ForeColor = Color.Black
                    ICard.ForeColor = Color.Black
                Else
                    设置.ForeColor = Color.White
                    其他工具.ForeColor = Color.White
                    FColorG.ForeColor = Color.White
                    BColorG.ForeColor = Color.White
                    StyleG.ForeColor = Color.White
                    Settingst.ForeColor = Color.White
                    工具标题.ForeColor = Color.White
                    ICard.ForeColor = Color.White
                End If
            End If
        Catch ex As Exception
            themecolor = 1
            lightcolor = 1
            stylecolor = 1
            Writethemetofile()
        End Try

        '错误规避
        If Visible = True Then Loading.Hide()
        If Start.Enabled = False And EndT.Enabled = False Then Height = 620

        '主题
        If themecolor = 1 Then FColorS.Checked = True Else FColorC.Checked = True
        If lightcolor = 1 Then BColorL.Checked = True Else BColorB.Checked = True
        If stylecolor = 1 Then ColorfullRB.Checked = True Else FlatRB.Checked = True

        'CB
        If CB <> "" Then
            My.Computer.Clipboard.SetText(CB)
            CB = ""
        End If

        'Information
        ID.Text = Net.Dns.GetHostName
        User.Text = Environment.UserName
        Dim ss = CStr(Environment.TickCount） / 1000
        Dim S = Int(ss) Mod 60
        Dim M = (Int(Int(ss) / 60)) Mod 60
        Dim H = Int(Int(Int(ss) / 60) / 60)
        Dim ms As String = CStr(Environment.TickCount） - Int(ss) * 1000
        ms = Strings.Right("000" & ms, 3)
        Dim D = Int(ss / 3600 / 24)
        '  ss = ss - S * 60
        Time.Text = D & "天 " & H & "小时 " & M & "分 " & S & "秒 " ' & ms & "毫秒"

        Dim cpuInfo As New SYSTEM_INFO()
        GetSystemInfo(cpuInfo)
        CPU.Text = "OEMID：" & cpuInfo.dwOemID.ToString() & " 页面大小：" & cpuInfo.dwPageSize

        Dim BR = Loading.FtCa.R - 10
        If BR < 0 Then BR = -BR
        If BR > 255 Then BR = BR - 20

        Dim BG = Loading.FtCa.G - 10
        If BG < 0 Then BG = -BG
        If BG > 255 Then BG = BG - 20

        Dim BB = Loading.FtCa.B - 10
        If BB < 0 Then BB = -BB
        If BB > 255 Then BB = BB - 20

        Dim NBG As Color = Color.FromArgb(Loading.FtCa.A, BR, BG, BB)
        If page = 1 Then
            OneB.BackColor = NBG
            TwoB.BackColor = Loading.FtC
            ThreeB.BackColor = Loading.FtC
        End If
        If page = 2 Then
            OneB.BackColor = Loading.FtC
            TwoB.BackColor = NBG
            ThreeB.BackColor = Loading.FtC
        End If
        If page = 3 Then
            OneB.BackColor = Loading.FtC
            TwoB.BackColor = Loading.FtC
            ThreeB.BackColor = NBG
        End If


        'shift button
        If 三.Focused = False And OneB.Focused = False And TwoB.Focused = False And ThreeB.Focused = False And
            INSKMS.Focused = False And test.Focused = False And UNUACICON.Focused = False And Ohosts.Focused = False And
            clean.Focused = False And regedit.Focused = False And MIN.Focused = False And ExitB.Focused = False Then ShiftButton = 0
        If ShiftButton = 1 Then
            INSKMS.Text = "卸载密钥                                         "
            test.Text = "详细的系统激活状态                           "
            UNUACICON.Text = "恢复小盾牌                                       "
            Ohosts.Text = "还原hosts                                        "
            clean.Text = "详细清理信息                                   "
            regedit.Text = "快速定位注册表                                 "
        Else
            INSKMS.Text = "安装KMS密钥                                   "
            test.Text = "检测系统激活状态                              "
            UNUACICON.Text = "去除小盾牌                                       "
            Ohosts.Text = "一键更换hosts                                 "
            clean.Text = "系统垃圾清理                                   "
            regedit.Text = "手动编辑注册表                                 "
        End If
        'cbar
        CleanBar.Value = cstep
        If cleant.IsAlive = False Then CleanBar.Visible = False

    End Sub

    Private Sub CPUT_Tick(sender As Object, e As EventArgs) Handles CPUT.Tick
        Dim cu As Integer = PfmcCounter.NextValue
        CBar.Value = cu
        CPUP.Text = cu & "%"
        '内存
        Dim memtmp1 As Integer = Val(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024
        Dim memtmp2 As Integer = Val(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024
        Dim memtmp3 As Integer = (memtmp2 - memtmp1) / memtmp2 * 100
        Memory.Text = CStr(memtmp2 - memtmp1) + " MB / " + memtmp2.ToString + " MB"
        MBar.Value = ((memtmp2 - memtmp1) / memtmp2) * 100
    End Sub

    Private Sub MIN_Click(sender As Object, e As EventArgs) Handles MIN.Click
        WindowState = 1
    End Sub

    Private Sub KEY(sender As Object, e As EventArgs)
        Try
            Dim ID As WindowsIdentity = WindowsIdentity.GetCurrent()
            Dim P As WindowsPrincipal = New WindowsPrincipal(ID)
            If P.IsInRole(WindowsBuiltInRole.Administrator) Then
                If 操作系统 = "Windows 10 Pro" Or 操作系统 = "Windows 10 Pro N" Or 操作系统 = "Windows 10 Enterprise" Or 操作系统 = "Windows 10 Enterprise N" Or 操作系统 = "Windows 10 Education" Or
            操作系统 = "Windows 10 Education N" Or 操作系统 = "Windows 10 Enterprise LSTB" Or 操作系统 = "Windows 10 Enterprise LSTB N" Then
                    '    Shell("cmd.exe /c slmgr.vbs -upk >nul")
                    If 操作系统 = "Windows 10 Pro" Then
                        Shell("cmd.exe /c slmgr.vbs -ipk W269N-WFGWX-YVC9B-4J6C9-T83GX")
                    ElseIf 操作系统 = "Windows 10 Pro N"
                        Shell("cmd.exe /c slmgr.vbs -ipk MH37W-N47XK-V7XM9-C7227-GCQG9")
                    ElseIf 操作系统 = "Windows 10 Enterprise"
                        Shell("cmd.exe /c slmgr.vbs -ipk NPPR9-FWDCX-D2C8J-H872K-2YT43")
                    ElseIf 操作系统 = "Windows 10 Enterprise N"
                        Shell("cmd.exe /c slmgr.vbs -ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4")
                    ElseIf 操作系统 = "Windows 10 Education"
                        Shell("cmd.exe /c slmgr.vbs -ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2")
                    ElseIf 操作系统 = "Windows 10 Education N"
                        Shell("cmd.exe /c slmgr.vbs -ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ")
                    ElseIf 操作系统 = "Windows 10 Enterprise LSTB"
                        Shell("cmd.exe /c slmgr.vbs -ipk WNMTR-4C88C-JK8YV-HQ7T2-76DF9")
                    ElseIf 操作系统 = "Windows 10 Enterprise LSTB N"
                        Shell("cmd.exe /c slmgr.vbs -ipk 2F77B-TNFGY-69QQF-B8YKP-D69TJ")
                    End If
                    Shell("cmd.exe /c slmgr.vbs /skms 45.78.2.15")
                    Shell("cmd.exe /c slmgr.vbs /ato")
                    Shell("cmd.exe /c slmgr.vbs /dlv")
                Else
                    MsgBox("不适合此操作系统!")
                End If
            Else
                MsgBox("请以管理员身份运行！")
            End If
        Catch ex As Exception
            MsgBox("激活失败！")
        End Try
    End Sub

    Private Sub ICONw_DoubleClick(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub 颜色校正_Click(sender As Object, e As EventArgs) Handles 颜色校正.Click
        Process.Start(Environment.SystemDirectory & "\dccw.exe")
    End Sub

    Private Sub INSKMS_Click(sender As Object, e As EventArgs) Handles INSKMS.Click
        If ShiftButton = 1 Then
            If MsgBox("你真的要卸载密钥？"， vbYesNo, "警告！") = MsgBoxResult.Yes Then Shell("cmd.exe /c slmgr.vbs -upk")
        Else
            If MsgBox("将会安装KMS密钥，如果您的系统是正版，请不要进行此操作！" & vbCrLf & "此功能仅供交流学习使用！请勿用于商业用途" _
                & vbCrLf & "使用此功能导致一切后果由使用者自行承担，作者概不负责"， vbYesNo, "警告！") = MsgBoxResult.Yes Then KEY(sender, e)
        End If
    End Sub

    ' 动画
    Dim t = 0
    Private Sub 向上滚_Tick(sender As Object, e As EventArgs) Handles 向上滚.Tick
        t = t + 1
        ICard.Location = New Point(ICard.Location.X, ICard.Location.Y - 25)
        If ICard.Location.Y <= -385 Then
            ICard.Location = New Point(ICard.Location.X, -385)
            向上滚.Enabled = False
        End If
        If t = 8 Then
            向上滚.Enabled = False
            t = 0
        End If
    End Sub

    Private Sub 向下滚_Tick(sender As Object, e As EventArgs) Handles 向下滚.Tick
        t = t + 1
        ICard.Location = New Point(ICard.Location.X, ICard.Location.Y + 25)
        If ICard.Location.Y >= 115 Then
            ICard.Location = New Point(ICard.Location.X, 115)
            向下滚.Enabled = False
        End If
        If t = 8 Then
            向下滚.Enabled = False
            t = 0
        End If
    End Sub

    Private Sub P1_Tick(sender As Object, e As EventArgs) Handles P1.Tick
        If page = 3 Then
            设置.Location = New Point(设置.Location.X, 设置.Location.Y + 15)
            If 设置.Location.Y >= 139 Then
                设置.Location = New Point(设置.Location.X, 139)
                设置.Visible = False
                page = 2
            End If
        ElseIf page = 2 Then
            其他工具.Location = New Point(其他工具.Location.X, 其他工具.Location.Y + 15)
            If 其他工具.Location.Y >= 139 Then
                P1.Enabled = False
                其他工具.Location = New Point(其他工具.Location.X, 139)
                其他工具.Visible = False
                page = 1
            End If
        Else P1.Enabled = False
        End If
    End Sub


    Private Sub P2_Tick(sender As Object, e As EventArgs) Handles P2.Tick
        If page = 3 Then
            设置.Location = New Point(设置.Location.X, 设置.Location.Y + 15)
            If 设置.Location.Y >= 139 Then
                设置.Location = New Point(设置.Location.X, 139)
                设置.Visible = False
                page = 1
            End If
        ElseIf page = 1 Then
            其他工具.Visible = True
            其他工具.Location = New Point(其他工具.Location.X, 其他工具.Location.Y - 15)
            If 其他工具.Location.Y <= 0 Then
                P2.Enabled = False
                其他工具.Location = New Point(其他工具.Location.X, 0)
                page = 2
            End If
        Else P2.Enabled = False
        End If
    End Sub

    Private Sub P3_Tick(sender As Object, e As EventArgs) Handles P3.Tick
        If page = 1 Then
            设置.Visible = True
            设置.Location = New Point(设置.Location.X, 设置.Location.Y - 15)
            If 设置.Location.Y <= 0 Then
                P3.Enabled = False
                设置.Location = New Point(设置.Location.X, 0)
                page = 3
            End If
        ElseIf page = 2 Then
            其他工具.Location = New Point(其他工具.Location.X, 其他工具.Location.Y + 15)
            If 其他工具.Location.Y >= 139 Then
                其他工具.Location = New Point(其他工具.Location.X, 139)
                其他工具.Visible = False
                page = 1
            End If
        Else P3.Enabled = False
        End If
    End Sub

    Private Sub Pz_Tick(sender As Object, e As EventArgs) Handles Pz.Tick
        Bar.Width = Bar.Width + 20
        三.Width = 三.Width + 20
        OneB.Width = OneB.Width + 20
        TwoB.Width = TwoB.Width + 20
        ThreeB.Width = ThreeB.Width + 20
        MIN.Width = ExitB.Width + 20
        ExitB.Width = ExitB.Width + 20
        If Bar.Width >= 200 Then
            Bar.Width = 200
            三.Width = 204
            OneB.Width = 204
            TwoB.Width = 204
            ThreeB.Width = 204
            MIN.Width = 204
            ExitB.Width = 204
            Pz.Enabled = False
        End If
    End Sub

    Private Sub Ps_Tick(sender As Object, e As EventArgs) Handles Ps.Tick
        Bar.Width = Bar.Width - 50
        三.Width = 三.Width - 50
        OneB.Width = OneB.Width - 50
        TwoB.Width = TwoB.Width - 50
        ThreeB.Width = ThreeB.Width - 50
        MIN.Width = ExitB.Width - 50
        ExitB.Width = ExitB.Width - 50
        If Bar.Width <= 44 Then
            Bar.Width = 44
            三.Width = 48
            OneB.Width = 48
            TwoB.Width = 48
            ThreeB.Width = 48
            MIN.Width = 48
            ExitB.Width = 48
            Ps.Enabled = False
        End If
    End Sub


    '切换
    Private Sub 三_Click(sender As Object, e As EventArgs) Handles 三.Click
        If Pz.Enabled = False And Ps.Enabled = False Then
            If Bar.Width = 200 Then Ps.Enabled = True
            If Bar.Width = 44 Then Pz.Enabled = True
        End If
    End Sub


    Private Sub OneB_Click(sender As Object, e As EventArgs) Handles OneB.Click
        If P2.Enabled = False And P3.Enabled = False Then P1.Enabled = True
    End Sub

    Private Sub TwoB_Click(sender As Object, e As EventArgs) Handles TwoB.Click
        If P1.Enabled = False And P3.Enabled = False Then P2.Enabled = True
    End Sub
    Private Sub ThreeB_Click(sender As Object, e As EventArgs) Handles ThreeB.Click
        If P1.Enabled = False And P2.Enabled = False Then P3.Enabled = True
    End Sub

    Private Sub test_Click(sender As Object, e As EventArgs) Handles test.Click
        If ShiftButton = 1 Then Shell("cmd.exe /c slmgr.vbs -dlv ", 0) Else Shell("cmd.exe /c slmgr.vbs -xpr ", 0)
    End Sub

    ' UACICON
    Private Sub 写入注册表()
        Dim exedir As String = "%systemroot%\system32\imageres.dll,197"
        Dim key1 As RegistryKey = Registry.LocalMachine
        Dim key2 As RegistryKey = key1.CreateSubKey("software")
        Dim key3 As RegistryKey = key2.CreateSubKey("microsoft")
        Dim key4 As RegistryKey = key3.CreateSubKey("windows")
        Dim key5 As RegistryKey = key4.CreateSubKey("currentversion")
        Dim key6 As RegistryKey = key5.CreateSubKey("explorer")
        Dim key7 As RegistryKey = key6.CreateSubKey("Shell Icons")
        key7.SetValue("29", exedir)
        key7.SetValue("77", exedir)
    End Sub
    Private Sub 删除注册表()
        Dim key1 As RegistryKey = Registry.LocalMachine
        Dim key2 As RegistryKey = key1.CreateSubKey("software")
        Dim key3 As RegistryKey = key2.CreateSubKey("microsoft")
        Dim key4 As RegistryKey = key3.CreateSubKey("windows")
        Dim key5 As RegistryKey = key4.CreateSubKey("currentversion")
        Dim key6 As RegistryKey = key5.CreateSubKey("explorer")
        Dim key7 As RegistryKey = key6.CreateSubKey("Shell Icons")
        key6.DeleteSubKey("Shell Icons")
    End Sub
    Private Sub UNUACICON_Click(sender As Object, e As EventArgs) Handles UNUACICON.Click
        Dim ID As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim P As WindowsPrincipal = New WindowsPrincipal(ID)
        If P.IsInRole(WindowsBuiltInRole.Administrator) Then
            If ShiftButton = 1 Then
                Shell("taskkill /f /im explorer.exe", 0)
                删除注册表()
                rse()
            Else
                Shell("taskkill /f /im explorer.exe", 0)
                写入注册表()
                rse()
            End If
        Else
            MsgBox("请以管理员身份运行！")
        End If
    End Sub

    Sub rse()
        Thread.Sleep(1000)
        Shell("explorer.exe", 0)
    End Sub

    Private Sub Updater_Click(sender As Object, e As EventArgs) Handles Updater.Click
        If bit = "X64" Then
            If Dir("MediaCreationToolx64.exe") <> "" Then Process.Start("MediaCreationToolx64.exe") Else MsgBox("错误!没有找到升级助手！您可以在http://www.microsoft.com/zh-cn/software-download/windows10进行下载")
        Else
            If Dir("MediaCreationTool.exe") <> "" Then Process.Start("MediaCreationTool.exe") Else MsgBox("错误!没有找到升级助手！您可以在http://www.microsoft.com/zh-cn/software-download/windows10进行下载")
        End If
    End Sub

    Private Sub AKAC_Click(sender As Object, e As EventArgs) Handles AKAC.Click
        If Dir("AKAC.exe") <> "" Then Process.Start("AKAC.exe"） Else MsgBox("错误!没有找到AKAC！")
    End Sub
    'link
    Private Sub logop_DoubleClick(sender As Object, e As EventArgs) Handles logop.DoubleClick
        Process.Start("http://www.win10bar.com"）
    End Sub

    'hosts
    Private Sub Ohosts_Click(sender As Object, e As EventArgs) Handles Ohosts.Click
        Try
            Dim ID As WindowsIdentity = WindowsIdentity.GetCurrent()
            Dim P As WindowsPrincipal = New WindowsPrincipal(ID)
            If P.IsInRole(WindowsBuiltInRole.Administrator) Then
                Dim oldhosts = Environment.SystemDirectory & "\drivers\etc\hosts"
                Dim nohosts = Environment.SystemDirectory & "\drivers\etc\hosts.old"
                If ShiftButton = 1 Then
                    If nohosts <> "" Then
                        If oldhosts <> "" Then Kill(oldhosts)
                        Rename(nohosts, oldhosts)
                        If Dir(nohosts) <> "" Then Kill(nohosts)
                        MsgBox("还原完毕")
                    Else
                        MsgBox("没有找到备份")
                    End If
                Else
                    'Read
                    Openhosts.FileName = ""
                    Openhosts.ShowDialog()
                    Dim nhosts = Openhosts.FileName
                    'Backup
                    If Dir(nohosts) <> "" Then Kill(nohosts)
                    If Dir(oldhosts) <> "" Then Rename(oldhosts, nohosts)
                    'Copy
                    If nhosts <> "" Then
                        FileCopy(nhosts, oldhosts）
                        'Refresh
                        Shell("cmd /k ipconfig/flushdns", 0)
                        MsgBox("更换完毕")
                    Else MsgBox("操作被取消或文件读取失败")
                    End If
                End If
            Else MsgBox("请以管理员身份运行！")
            End If
        Catch ex As Exception
            MsgBox("操作失败")
        End Try
    End Sub

    'MD5
    Delegate Sub DelegateHandler(ByVal 参数 As String)
    Dim MD5R As Thread = New Thread(AddressOf R)

    Function GMD5(ByVal P As String) As String
        Try
            Dim md5Hasher As MD5 = MD5.Create()
            Dim originalDate As Byte() = My.Computer.FileSystem.ReadAllBytes(P)
            Dim data As Byte() = md5Hasher.ComputeHash(originalDate)
            Dim sBuilder As New StringBuilder()
            Dim i As Integer
            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next i
            Return sBuilder.ToString()
        Catch ex As Exception
            ' If Dir("md5.exe") <> "" Then
            ' Shell("cmd /k md5 -tdext -n " & OpenMD5.FileName & "> tmp", 0)
            ' tMD5.Enabled = True
            ' Else
            MsgBox("文件大小请不要超过2G") '("MD5校验插件丢失！", vbInformation, "错误！")
            ' MD5B.Text = "检测文件MD5值                               "
            ' MD5B.Enabled = True
            ' End If
            Return Nothing
        End Try
    End Function

    Private Sub MD5B_Click(sender As Object, e As EventArgs) Handles MD5B.Click
        OpenMD5.FileName = ""
        OpenMD5.ShowDialog()
        filetomd5()
    End Sub

    Sub filetomd5()
        Try
            'If Dir("tmp") <> "" Then Kill("tmp")
            If OpenMD5.FileName <> "" Then
                'MsgBox("请等待一会……" & vbCrLf & "文件越大，耗时越长！" & vbCrLf & "若出现假死，请不要强制关闭。任务完成后会自动恢复响应！")
                MD5B.Text = "正在计算……                                      "
                MD5B.Enabled = False
                If MD5R.IsAlive = False Then MD5R.Start()
            End If
        Catch ex As Exception
            MsgBox("检测失败！")
            MD5B.Text = "检测文件MD5值                               "
            MD5B.Enabled = True
        End Try
    End Sub

    Private Sub tMD5_Tick(sender As Object, e As EventArgs) ' Handles tMD5.Tick
        If Dir("tmp") <> "" Then
            MD5B.Text = "正在计算……                                      "
            MD5B.Enabled = False
            Dim R = 0
            If Dir("tmp") <> "" Then
                Try
                    Dim rMD5 As New StreamReader("tmp")
                    If rMD5.ReadLine <> "" Then R = 1
                    rMD5.Close()
                Catch ex As Exception
                    R = 0
                End Try
            End If

            If R = 1 Then
                tMD5.Enabled = False
                R = 0
                Dim rMD5 As New StreamReader("tmp")
                Dim RrMD5 = rMD5.ReadLine
                If MsgBox("该文件MD5值为:" & RrMD5 & vbCrLf & "点击" & Chr(34) & "是" & Chr(34) & "以复制", vbYesNo) = MsgBoxResult.Yes Then My.Computer.Clipboard.SetText(RrMD5)
                MD5B.Text = "检测文件MD5值                               "
                MD5B.Enabled = True
                rMD5.Close()
                If Dir("tmp") <> "" Then Kill("tmp")
            End If
        End If
    End Sub
    Dim CB As String = ""
    Private Sub R(ByVal str As String)
        If GMD5(OpenMD5.FileName) <> "" Then
            Dim RrMD5 = GMD5(OpenMD5.FileName)
            If MsgBox("该文件MD5值为:" & RrMD5 & vbCrLf & "点击" & Chr(34) & "是" & Chr(34) & "以复制", vbYesNo) = MsgBoxResult.Yes Then CB = RrMD5 ' My.Computer.Clipboard.SetText(RrMD5)
        End If
        MD5B.Text = "检测文件MD5值                               "
        MD5B.Enabled = True
        MD5R = New Thread(AddressOf R)
    End Sub

    '拖放
    Private Sub MD5B_DragEnter(sender As Object, e As DragEventArgs) Handles MD5B.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then e.Effect = DragDropEffects.Copy Else e.Effect = DragDropEffects.None
    End Sub

    Private Sub MD5B_DragDrop(sender As Object, e As DragEventArgs) Handles MD5B.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
                Dim f As String() = e.Data.GetData(DataFormats.FileDrop)
                For Each File As String In f
                    If fso.FileExists(File) = True Then OpenMD5.FileName = File
                Next
                filetomd5()
            End If
        Catch ex As Exception
            MsgBox("检测失败")
        End Try
    End Sub

    'clean
    Dim cstep = 0
    Dim cleant As Thread = New Thread(AddressOf cleancmd)
    Private Sub clean_Click(sender As Object, e As EventArgs) Handles clean.Click
        Dim ID As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim P As WindowsPrincipal = New WindowsPrincipal(ID)
        If P.IsInRole(WindowsBuiltInRole.Administrator) Then
            If ShiftButton = 1 Then
                MsgBox(Cmd("del /f /s /q %systemdrive%\*.tmp"))
                MsgBox(Cmd("del /f /s /q %systemdrive%\*._mp"))
                MsgBox(Cmd("del /f /s /q %systemdrive%\*.log"))
                MsgBox(Cmd("del /f /s /q %systemdrive%\*.gid"))
                MsgBox(Cmd("del /f /s /q %systemdrive%\*.chk"))
                MsgBox(Cmd("del /f /s /q %systemdrive%\*.old"))
                MsgBox(Cmd("del /f /s /q %systemdrive%\recycled\*.*"))
                MsgBox(Cmd("del /f /s /q %windir%\*.bak"))
                MsgBox(Cmd("del /f /s /q %windir%\prefetch\*.*"))
                MsgBox(Cmd("rd /s /q %windir%\temp & md %windir%\temp"))
                MsgBox(Cmd("del /f /q %userprofile%\cookies\*.*"))
                MsgBox(Cmd("del /f /q %userprofile%\recent\*.*"))
                MsgBox(Cmd("rmdir /s /q %tmp%"))
            Else
                cstep = 0
                CleanBar.Show()
                If cleant.IsAlive = False Then cleant.Start()
            End If
        Else MsgBox("请以管理员身份运行")
        End If
    End Sub

    Public Sub cleancmd()
        cstep = 12
        Cmd("del /f /s /q %systemdrive%\*.tmp")
        cstep = 25
        Cmd("del /f /s /q %systemdrive%\*._mp")
        cstep = 37
        Cmd("del /f /s /q %systemdrive%\*.log")
        cstep = 50
        Cmd("del /f /s /q %systemdrive%\*.gid")
        cstep = 62
        Cmd("del /f /s /q %systemdrive%\*.chk")
        cstep = 75
        Cmd("del /f /s /q %systemdrive%\*.old")
        cstep = 87
        Cmd("del /f /s /q %windir%\*.bak")
        cstep = 100
        Cmd("rmdir /s /q %tmp%")
        cleant = New Thread(AddressOf cleancmd)
        MsgBox("清理完毕")
    End Sub

    'Others
    Private Sub gpedit_Click(sender As Object, e As EventArgs) Handles gpedit.Click
        Try
            Process.Start("gpedit.msc")
        Catch ex As Exception
            MsgBox("启动组策略失败！")
        End Try
    End Sub

    Private Sub msconfig_Click(sender As Object, e As EventArgs) Handles msconfig.Click
        Try
            Process.Start(“msconfig")
        Catch ex As Exception
            MsgBox("启动系统实用配置工具失败！")
        End Try
    End Sub

    Private Sub regedit_Click(sender As Object, e As EventArgs) Handles regedit.Click
        If ShiftButton = 1 Then
            JumptoReg()
        Else
            Try
                Process.Start("regedit")
            Catch ex As Exception
                MsgBox("启动注册表编辑器失败！")
            End Try
        End If

    End Sub

    Sub JumptoReg()
        Dim dir As String = InputBox("输入要跳转到的注册表值(完整的标准路径)")
        If dir <> "" Then
            Dim key1 As RegistryKey = Registry.CurrentUser
            Dim key2 As RegistryKey = key1.CreateSubKey("software")
            Dim key3 As RegistryKey = key2.CreateSubKey("microsoft")
            Dim key4 As RegistryKey = key3.CreateSubKey("windows")
            Dim key5 As RegistryKey = key4.CreateSubKey("CurrentVersion")
            Dim key6 As RegistryKey = key5.CreateSubKey("Applets")
            Dim key7 As RegistryKey = key6.CreateSubKey("Regedit")
            key7.SetValue("Lastkey", dir)

            Dim i As Integer
            Dim proc As Process()
            If Process.GetProcessesByName("regedit").Length > 0 Then
                proc = Process.GetProcessesByName("regedit")
                For i = 0 To proc.Length - 1
                    proc(i).Kill()
                Next
            End If
            proc = Nothing

            Process.Start("regedit")
        End If
    End Sub

    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        Try
            Process.Start("services.msc")
        Catch ex As Exception
            MsgBox("启动服务失败！")
        End Try
    End Sub
    'Close
    Private Sub Form_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Writethemetofile()
        e.Cancel = True
        EndT.Enabled = True
    End Sub

    Private Sub ExitB_Click(sender As Object, e As EventArgs) Handles ExitB.Click
        Close()
    End Sub

    Private Sub Endt_Tick(sender As Object, e As EventArgs) Handles EndT.Tick
        Try
            Height = Height - 29
            If Height <= 30 Then
                EndT.Enabled = False
                Height = 1
                Close()
                End
            End If
        Catch ex As Exception
            End
        End Try
    End Sub

    '滚啊滚
    Private Sub ICard_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If 向下滚.Enabled = False And 向上滚.Enabled = False Then
            If e.Delta > 0 Then 向下滚.Enabled = True
            If e.Delta < 0 Then 向上滚.Enabled = True
        End If
    End Sub

    ' Theme
    Private Sub FColorS_Click(sender As Object, e As EventArgs) Handles FColorS.Click
        themecolor = 1
        Writethemetofile()
    End Sub

    Private Sub FColorC_Click(sender As Object, e As EventArgs) Handles FColorC.Click
        themecolor = 0
        Writethemetofile()
    End Sub

    Private Sub BColorB_Click(sender As Object, e As EventArgs) Handles BColorB.Click
        lightcolor = 0
        Writethemetofile()
    End Sub

    Private Sub BColorL_Click(sender As Object, e As EventArgs) Handles BColorL.Click
        lightcolor = 1
        Writethemetofile()
    End Sub

    Private Sub ColorfullRB_Click(sender As Object, e As EventArgs) Handles ColorfullRB.Click
        stylecolor = 1
        Writethemetofile()
    End Sub

    Private Sub FlatRB_Click(sender As Object, e As EventArgs) Handles FlatRB.Click
        stylecolor = 0
        Writethemetofile()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    '弹回
    Private Sub AClick(sender As Object, e As EventArgs) Handles 屏幕分辨率.Click, 当前计算机名.Click,
       XXY.Click, 当前用户.Click, 运行时间.Click, 显卡.Click, 内存信息.Click, 中央处理器信息.Click, ID.Click,
      User.Click, 显卡型号.Click, Time.Click, CPU.Click, Memory.Click, CPUINFO.Click, 系统版本.Click, Systeminfo.Click, MBar.Click, 主板型号.Click, Board.Click, ThreeB.Click, TwoB.Click, OneB.Click,
      三.Click, Bar.Click, ExitB.Click, logop.Click, ICard.Click, 其他工具.Click, 设置.Click,
       Updater.Click, services.Click, regedit.Click, msconfig.Click, gpedit.Click, MD5B.Click, Ohosts.Click,
       颜色校正.Click, INSKMS.Click, test.Click, 硬件信息.Click, CBar.Click, 系统信息.Click, CPUP.Click,
       TUB.Click, MIN.Click, UNUACICON.Click, clean.Click, CleanBar.Click, AKAC.Click, FColorS.Click, FColorC.Click, FColorG.Click， BColorG.Click, BColorB.Click, BColorL.Click,
       V.Click, StyleG.Click, SettingsUB.Click, V.Click, Line1.Click, Line2.Click, Line3.Click
        If Pz.Enabled = False And Ps.Enabled = False Then
            If Bar.Width = 200 Then Ps.Enabled = True
        End If
    End Sub

    Public Sub Writethemetofile()
        Try
            Dim themew As New StreamWriter("TBtheme")
            themew.WriteLine(themecolor)
            themew.WriteLine(lightcolor)
            themew.WriteLine(stylecolor)
            themew.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class
