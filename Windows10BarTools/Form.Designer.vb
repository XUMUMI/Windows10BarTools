<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.刷新 = New System.Windows.Forms.Timer(Me.components)
        Me.屏幕分辨率 = New System.Windows.Forms.Label()
        Me.当前计算机名 = New System.Windows.Forms.Label()
        Me.XXY = New System.Windows.Forms.Label()
        Me.当前用户 = New System.Windows.Forms.Label()
        Me.运行时间 = New System.Windows.Forms.Label()
        Me.显卡 = New System.Windows.Forms.Label()
        Me.内存信息 = New System.Windows.Forms.Label()
        Me.中央处理器信息 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.Label()
        Me.显卡型号 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.CPU = New System.Windows.Forms.Label()
        Me.Memory = New System.Windows.Forms.Label()
        Me.CPUINFO = New System.Windows.Forms.Label()
        Me.系统版本 = New System.Windows.Forms.Label()
        Me.Systeminfo = New System.Windows.Forms.Label()
        Me.MBar = New System.Windows.Forms.ProgressBar()
        Me.主板型号 = New System.Windows.Forms.Label()
        Me.Board = New System.Windows.Forms.Label()
        Me.P1 = New System.Windows.Forms.Timer(Me.components)
        Me.P2 = New System.Windows.Forms.Timer(Me.components)
        Me.P3 = New System.Windows.Forms.Timer(Me.components)
        Me.Pz = New System.Windows.Forms.Timer(Me.components)
        Me.Ps = New System.Windows.Forms.Timer(Me.components)
        Me.Openhosts = New System.Windows.Forms.OpenFileDialog()
        Me.OpenMD5 = New System.Windows.Forms.OpenFileDialog()
        Me.tMD5 = New System.Windows.Forms.Timer(Me.components)
        Me.ICard = New System.Windows.Forms.GroupBox()
        Me.硬件信息 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.PictureBox()
        Me.CBar = New System.Windows.Forms.ProgressBar()
        Me.系统信息 = New System.Windows.Forms.Label()
        Me.CPUP = New System.Windows.Forms.Label()
        Me.其他工具 = New System.Windows.Forms.GroupBox()
        Me.CleanBar = New System.Windows.Forms.ProgressBar()
        Me.Line3 = New System.Windows.Forms.PictureBox()
        Me.Line2 = New System.Windows.Forms.PictureBox()
        Me.工具标题 = New System.Windows.Forms.Label()
        Me.AKAC = New System.Windows.Forms.Button()
        Me.Updater = New System.Windows.Forms.Button()
        Me.services = New System.Windows.Forms.Button()
        Me.regedit = New System.Windows.Forms.Button()
        Me.msconfig = New System.Windows.Forms.Button()
        Me.gpedit = New System.Windows.Forms.Button()
        Me.MD5B = New System.Windows.Forms.Button()
        Me.UNUACICON = New System.Windows.Forms.Button()
        Me.clean = New System.Windows.Forms.Button()
        Me.Ohosts = New System.Windows.Forms.Button()
        Me.颜色校正 = New System.Windows.Forms.Button()
        Me.INSKMS = New System.Windows.Forms.Button()
        Me.test = New System.Windows.Forms.Button()
        Me.TUB = New System.Windows.Forms.PictureBox()
        Me.CPUT = New System.Windows.Forms.Timer(Me.components)
        Me.窗口位置限制 = New System.Windows.Forms.Timer(Me.components)
        Me.Start = New System.Windows.Forms.Timer(Me.components)
        Me.EndT = New System.Windows.Forms.Timer(Me.components)
        Me.设置 = New System.Windows.Forms.GroupBox()
        Me.V = New System.Windows.Forms.Label()
        Me.BColorG = New System.Windows.Forms.GroupBox()
        Me.BColorB = New System.Windows.Forms.RadioButton()
        Me.BColorL = New System.Windows.Forms.RadioButton()
        Me.FColorG = New System.Windows.Forms.GroupBox()
        Me.FColorS = New System.Windows.Forms.RadioButton()
        Me.FColorC = New System.Windows.Forms.RadioButton()
        Me.Settingst = New System.Windows.Forms.Label()
        Me.SettingsUB = New System.Windows.Forms.PictureBox()
        Me.StyleG = New System.Windows.Forms.GroupBox()
        Me.ColorfullRB = New System.Windows.Forms.RadioButton()
        Me.FlatRB = New System.Windows.Forms.RadioButton()
        Me.向上滚 = New System.Windows.Forms.Timer(Me.components)
        Me.向下滚 = New System.Windows.Forms.Timer(Me.components)
        Me.MIN = New System.Windows.Forms.Button()
        Me.ExitB = New System.Windows.Forms.Button()
        Me.ThreeB = New System.Windows.Forms.Button()
        Me.TwoB = New System.Windows.Forms.Button()
        Me.OneB = New System.Windows.Forms.Button()
        Me.三 = New System.Windows.Forms.Button()
        Me.Bar = New System.Windows.Forms.PictureBox()
        Me.logop = New System.Windows.Forms.PictureBox()
        Me.ICard.SuspendLayout()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.其他工具.SuspendLayout()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.设置.SuspendLayout()
        Me.BColorG.SuspendLayout()
        Me.FColorG.SuspendLayout()
        CType(Me.SettingsUB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StyleG.SuspendLayout()
        CType(Me.Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '刷新
        '
        Me.刷新.Enabled = True
        Me.刷新.Interval = 1
        '
        '屏幕分辨率
        '
        Me.屏幕分辨率.AutoSize = True
        Me.屏幕分辨率.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.屏幕分辨率.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.屏幕分辨率.Location = New System.Drawing.Point(72, 315)
        Me.屏幕分辨率.Margin = New System.Windows.Forms.Padding(0)
        Me.屏幕分辨率.Name = "屏幕分辨率"
        Me.屏幕分辨率.Size = New System.Drawing.Size(90, 21)
        Me.屏幕分辨率.TabIndex = 13
        Me.屏幕分辨率.Text = "屏幕分辨率"
        '
        '当前计算机名
        '
        Me.当前计算机名.AutoSize = True
        Me.当前计算机名.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.当前计算机名.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.当前计算机名.Location = New System.Drawing.Point(71, 94)
        Me.当前计算机名.Margin = New System.Windows.Forms.Padding(0)
        Me.当前计算机名.Name = "当前计算机名"
        Me.当前计算机名.Size = New System.Drawing.Size(106, 21)
        Me.当前计算机名.TabIndex = 5
        Me.当前计算机名.Text = "当前计算机名"
        '
        'XXY
        '
        Me.XXY.AutoSize = True
        Me.XXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.XXY.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.XXY.Location = New System.Drawing.Point(72, 339)
        Me.XXY.Margin = New System.Windows.Forms.Padding(0)
        Me.XXY.Name = "XXY"
        Me.XXY.Size = New System.Drawing.Size(73, 20)
        Me.XXY.TabIndex = 14
        Me.XXY.Text = "检测中……"
        '
        '当前用户
        '
        Me.当前用户.AutoSize = True
        Me.当前用户.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.当前用户.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.当前用户.Location = New System.Drawing.Point(71, 173)
        Me.当前用户.Margin = New System.Windows.Forms.Padding(0)
        Me.当前用户.Name = "当前用户"
        Me.当前用户.Size = New System.Drawing.Size(74, 21)
        Me.当前用户.TabIndex = 8
        Me.当前用户.Text = "当前用户"
        '
        '运行时间
        '
        Me.运行时间.AutoSize = True
        Me.运行时间.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.运行时间.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.运行时间.Location = New System.Drawing.Point(72, 245)
        Me.运行时间.Margin = New System.Windows.Forms.Padding(0)
        Me.运行时间.Name = "运行时间"
        Me.运行时间.Size = New System.Drawing.Size(90, 21)
        Me.运行时间.TabIndex = 10
        Me.运行时间.Text = "已开机时间"
        '
        '显卡
        '
        Me.显卡.AutoSize = True
        Me.显卡.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.显卡.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.显卡.Location = New System.Drawing.Point(72, 547)
        Me.显卡.Margin = New System.Windows.Forms.Padding(0)
        Me.显卡.Name = "显卡"
        Me.显卡.Size = New System.Drawing.Size(74, 21)
        Me.显卡.TabIndex = 18
        Me.显卡.Text = "显卡型号"
        '
        '内存信息
        '
        Me.内存信息.AutoSize = True
        Me.内存信息.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.内存信息.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.内存信息.Location = New System.Drawing.Point(70, 616)
        Me.内存信息.Margin = New System.Windows.Forms.Padding(0)
        Me.内存信息.Name = "内存信息"
        Me.内存信息.Size = New System.Drawing.Size(74, 21)
        Me.内存信息.TabIndex = 7
        Me.内存信息.Text = "内存信息"
        '
        '中央处理器信息
        '
        Me.中央处理器信息.AutoSize = True
        Me.中央处理器信息.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.中央处理器信息.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.中央处理器信息.Location = New System.Drawing.Point(73, 730)
        Me.中央处理器信息.Margin = New System.Windows.Forms.Padding(0)
        Me.中央处理器信息.Name = "中央处理器信息"
        Me.中央处理器信息.Size = New System.Drawing.Size(122, 21)
        Me.中央处理器信息.TabIndex = 11
        Me.中央处理器信息.Text = "中央处理器信息"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ID.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ID.Location = New System.Drawing.Point(72, 125)
        Me.ID.Margin = New System.Windows.Forms.Padding(0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(73, 20)
        Me.ID.TabIndex = 6
        Me.ID.Text = "检测中……"
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.User.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.User.Location = New System.Drawing.Point(72, 198)
        Me.User.Margin = New System.Windows.Forms.Padding(0)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(73, 20)
        Me.User.TabIndex = 9
        Me.User.Text = "检测中……"
        '
        '显卡型号
        '
        Me.显卡型号.AutoSize = True
        Me.显卡型号.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.显卡型号.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.显卡型号.Location = New System.Drawing.Point(73, 574)
        Me.显卡型号.Margin = New System.Windows.Forms.Padding(0)
        Me.显卡型号.Name = "显卡型号"
        Me.显卡型号.Size = New System.Drawing.Size(73, 20)
        Me.显卡型号.TabIndex = 19
        Me.显卡型号.Text = "检测中……"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Time.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Time.Location = New System.Drawing.Point(72, 270)
        Me.Time.Margin = New System.Windows.Forms.Padding(0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(73, 20)
        Me.Time.TabIndex = 12
        Me.Time.Text = "检测中……"
        '
        'CPU
        '
        Me.CPU.AutoSize = True
        Me.CPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPU.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.CPU.Location = New System.Drawing.Point(73, 851)
        Me.CPU.Margin = New System.Windows.Forms.Padding(0)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(73, 20)
        Me.CPU.TabIndex = 24
        Me.CPU.Text = "检测中……"
        '
        'Memory
        '
        Me.Memory.AutoSize = True
        Me.Memory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Memory.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.Memory.Location = New System.Drawing.Point(71, 685)
        Me.Memory.Margin = New System.Windows.Forms.Padding(0)
        Me.Memory.Name = "Memory"
        Me.Memory.Size = New System.Drawing.Size(73, 20)
        Me.Memory.TabIndex = 21
        Me.Memory.Text = "检测中……"
        '
        'CPUINFO
        '
        Me.CPUINFO.AutoSize = True
        Me.CPUINFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUINFO.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.CPUINFO.Location = New System.Drawing.Point(73, 825)
        Me.CPUINFO.Margin = New System.Windows.Forms.Padding(0)
        Me.CPUINFO.Name = "CPUINFO"
        Me.CPUINFO.Size = New System.Drawing.Size(73, 20)
        Me.CPUINFO.TabIndex = 23
        Me.CPUINFO.Text = "检测中……"
        '
        '系统版本
        '
        Me.系统版本.AutoSize = True
        Me.系统版本.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.系统版本.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.系统版本.Location = New System.Drawing.Point(72, 383)
        Me.系统版本.Margin = New System.Windows.Forms.Padding(0)
        Me.系统版本.Name = "系统版本"
        Me.系统版本.Size = New System.Drawing.Size(74, 21)
        Me.系统版本.TabIndex = 15
        Me.系统版本.Text = "系统版本"
        '
        'Systeminfo
        '
        Me.Systeminfo.AutoSize = True
        Me.Systeminfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Systeminfo.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Systeminfo.Location = New System.Drawing.Point(72, 408)
        Me.Systeminfo.Margin = New System.Windows.Forms.Padding(0)
        Me.Systeminfo.Name = "Systeminfo"
        Me.Systeminfo.Size = New System.Drawing.Size(73, 20)
        Me.Systeminfo.TabIndex = 17
        Me.Systeminfo.Text = "检测中……"
        '
        'MBar
        '
        Me.MBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.MBar.Location = New System.Drawing.Point(73, 651)
        Me.MBar.Margin = New System.Windows.Forms.Padding(0)
        Me.MBar.Name = "MBar"
        Me.MBar.Size = New System.Drawing.Size(136, 23)
        Me.MBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.MBar.TabIndex = 3
        '
        '主板型号
        '
        Me.主板型号.AutoSize = True
        Me.主板型号.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.主板型号.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.主板型号.Location = New System.Drawing.Point(73, 906)
        Me.主板型号.Margin = New System.Windows.Forms.Padding(0)
        Me.主板型号.Name = "主板型号"
        Me.主板型号.Size = New System.Drawing.Size(74, 21)
        Me.主板型号.TabIndex = 16
        Me.主板型号.Text = "主板型号"
        '
        'Board
        '
        Me.Board.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Board.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.Board.Location = New System.Drawing.Point(73, 933)
        Me.Board.Margin = New System.Windows.Forms.Padding(0)
        Me.Board.Name = "Board"
        Me.Board.Size = New System.Drawing.Size(301, 62)
        Me.Board.TabIndex = 22
        Me.Board.Text = "检测中……"
        '
        'P1
        '
        Me.P1.Interval = 1
        '
        'P2
        '
        Me.P2.Interval = 1
        '
        'P3
        '
        Me.P3.Interval = 1
        '
        'Pz
        '
        Me.Pz.Interval = 10
        '
        'Ps
        '
        Me.Ps.Interval = 1
        '
        'Openhosts
        '
        Me.Openhosts.Filter = "hosts文件|hosts"
        '
        'tMD5
        '
        Me.tMD5.Interval = 1
        '
        'ICard
        '
        Me.ICard.BackColor = System.Drawing.Color.White
        Me.ICard.Controls.Add(Me.硬件信息)
        Me.ICard.Controls.Add(Me.Line1)
        Me.ICard.Controls.Add(Me.CBar)
        Me.ICard.Controls.Add(Me.MBar)
        Me.ICard.Controls.Add(Me.系统信息)
        Me.ICard.Controls.Add(Me.当前计算机名)
        Me.ICard.Controls.Add(Me.ID)
        Me.ICard.Controls.Add(Me.内存信息)
        Me.ICard.Controls.Add(Me.当前用户)
        Me.ICard.Controls.Add(Me.User)
        Me.ICard.Controls.Add(Me.运行时间)
        Me.ICard.Controls.Add(Me.中央处理器信息)
        Me.ICard.Controls.Add(Me.Time)
        Me.ICard.Controls.Add(Me.屏幕分辨率)
        Me.ICard.Controls.Add(Me.XXY)
        Me.ICard.Controls.Add(Me.系统版本)
        Me.ICard.Controls.Add(Me.主板型号)
        Me.ICard.Controls.Add(Me.Systeminfo)
        Me.ICard.Controls.Add(Me.显卡)
        Me.ICard.Controls.Add(Me.显卡型号)
        Me.ICard.Controls.Add(Me.CPUP)
        Me.ICard.Controls.Add(Me.Memory)
        Me.ICard.Controls.Add(Me.Board)
        Me.ICard.Controls.Add(Me.CPUINFO)
        Me.ICard.Controls.Add(Me.CPU)
        Me.ICard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ICard.ForeColor = System.Drawing.Color.Black
        Me.ICard.Location = New System.Drawing.Point(12, 115)
        Me.ICard.Margin = New System.Windows.Forms.Padding(0)
        Me.ICard.Name = "ICard"
        Me.ICard.Size = New System.Drawing.Size(410, 1050)
        Me.ICard.TabIndex = 10
        Me.ICard.TabStop = False
        Me.ICard.Text = "硬件信息"
        '
        '硬件信息
        '
        Me.硬件信息.AutoSize = True
        Me.硬件信息.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.硬件信息.Location = New System.Drawing.Point(70, 494)
        Me.硬件信息.Margin = New System.Windows.Forms.Padding(0)
        Me.硬件信息.Name = "硬件信息"
        Me.硬件信息.Size = New System.Drawing.Size(96, 28)
        Me.硬件信息.TabIndex = 0
        Me.硬件信息.Text = "硬件信息"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Line1.Location = New System.Drawing.Point(6, 464)
        Me.Line1.Margin = New System.Windows.Forms.Padding(0)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(422, 5)
        Me.Line1.TabIndex = 1
        Me.Line1.TabStop = False
        '
        'CBar
        '
        Me.CBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.CBar.Location = New System.Drawing.Point(73, 767)
        Me.CBar.Margin = New System.Windows.Forms.Padding(0)
        Me.CBar.Name = "CBar"
        Me.CBar.Size = New System.Drawing.Size(136, 23)
        Me.CBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CBar.TabIndex = 2
        '
        '系统信息
        '
        Me.系统信息.AutoSize = True
        Me.系统信息.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.系统信息.Location = New System.Drawing.Point(69, 47)
        Me.系统信息.Margin = New System.Windows.Forms.Padding(0)
        Me.系统信息.Name = "系统信息"
        Me.系统信息.Size = New System.Drawing.Size(96, 28)
        Me.系统信息.TabIndex = 4
        Me.系统信息.Text = "系统信息"
        '
        'CPUP
        '
        Me.CPUP.AutoSize = True
        Me.CPUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CPUP.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.CPUP.Location = New System.Drawing.Point(73, 801)
        Me.CPUP.Margin = New System.Windows.Forms.Padding(0)
        Me.CPUP.Name = "CPUP"
        Me.CPUP.Size = New System.Drawing.Size(73, 20)
        Me.CPUP.TabIndex = 20
        Me.CPUP.Text = "检测中……"
        '
        '其他工具
        '
        Me.其他工具.BackColor = System.Drawing.Color.White
        Me.其他工具.Controls.Add(Me.CleanBar)
        Me.其他工具.Controls.Add(Me.Line3)
        Me.其他工具.Controls.Add(Me.Line2)
        Me.其他工具.Controls.Add(Me.工具标题)
        Me.其他工具.Controls.Add(Me.AKAC)
        Me.其他工具.Controls.Add(Me.Updater)
        Me.其他工具.Controls.Add(Me.services)
        Me.其他工具.Controls.Add(Me.regedit)
        Me.其他工具.Controls.Add(Me.msconfig)
        Me.其他工具.Controls.Add(Me.gpedit)
        Me.其他工具.Controls.Add(Me.MD5B)
        Me.其他工具.Controls.Add(Me.UNUACICON)
        Me.其他工具.Controls.Add(Me.clean)
        Me.其他工具.Controls.Add(Me.Ohosts)
        Me.其他工具.Controls.Add(Me.颜色校正)
        Me.其他工具.Controls.Add(Me.INSKMS)
        Me.其他工具.Controls.Add(Me.test)
        Me.其他工具.Controls.Add(Me.TUB)
        Me.其他工具.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.其他工具.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.其他工具.ForeColor = System.Drawing.Color.Black
        Me.其他工具.Location = New System.Drawing.Point(40, 139)
        Me.其他工具.Margin = New System.Windows.Forms.Padding(0)
        Me.其他工具.Name = "其他工具"
        Me.其他工具.Padding = New System.Windows.Forms.Padding(0)
        Me.其他工具.Size = New System.Drawing.Size(384, 626)
        Me.其他工具.TabIndex = 7
        Me.其他工具.TabStop = False
        Me.其他工具.Text = "其他工具"
        Me.其他工具.Visible = False
        '
        'CleanBar
        '
        Me.CleanBar.Location = New System.Drawing.Point(0, 305)
        Me.CleanBar.Margin = New System.Windows.Forms.Padding(0)
        Me.CleanBar.Name = "CleanBar"
        Me.CleanBar.Size = New System.Drawing.Size(379, 40)
        Me.CleanBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CleanBar.TabIndex = 15
        Me.CleanBar.Visible = False
        '
        'Line3
        '
        Me.Line3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Line3.Location = New System.Drawing.Point(21, 392)
        Me.Line3.Margin = New System.Windows.Forms.Padding(0)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(350, 1)
        Me.Line3.TabIndex = 0
        Me.Line3.TabStop = False
        '
        'Line2
        '
        Me.Line2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Line2.Location = New System.Drawing.Point(22, 214)
        Me.Line2.Margin = New System.Windows.Forms.Padding(0)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(350, 1)
        Me.Line2.TabIndex = 1
        Me.Line2.TabStop = False
        '
        '工具标题
        '
        Me.工具标题.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.工具标题.AutoSize = True
        Me.工具标题.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.工具标题.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.工具标题.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.工具标题.Location = New System.Drawing.Point(17, 8)
        Me.工具标题.Margin = New System.Windows.Forms.Padding(0)
        Me.工具标题.Name = "工具标题"
        Me.工具标题.Size = New System.Drawing.Size(261, 28)
        Me.工具标题.TabIndex = 2
        Me.工具标题.Text = "工具(按住Shift键显示更多)"
        '
        'AKAC
        '
        Me.AKAC.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.AKAC
        Me.AKAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AKAC.FlatAppearance.BorderSize = 0
        Me.AKAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AKAC.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AKAC.Location = New System.Drawing.Point(0, 173)
        Me.AKAC.Margin = New System.Windows.Forms.Padding(0)
        Me.AKAC.Name = "AKAC"
        Me.AKAC.Size = New System.Drawing.Size(380, 40)
        Me.AKAC.TabIndex = 3
        Me.AKAC.Text = "AKAC                                             "
        Me.AKAC.UseVisualStyleBackColor = True
        '
        'Updater
        '
        Me.Updater.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Updater
        Me.Updater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Updater.FlatAppearance.BorderSize = 0
        Me.Updater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Updater.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Updater.Location = New System.Drawing.Point(0, 91)
        Me.Updater.Margin = New System.Windows.Forms.Padding(0)
        Me.Updater.Name = "Updater"
        Me.Updater.Size = New System.Drawing.Size(380, 40)
        Me.Updater.TabIndex = 3
        Me.Updater.Text = "升级到Windows 10                           "
        Me.Updater.UseVisualStyleBackColor = True
        '
        'services
        '
        Me.services.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Servers
        Me.services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.services.FlatAppearance.BorderSize = 0
        Me.services.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.services.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.services.Location = New System.Drawing.Point(0, 570)
        Me.services.Margin = New System.Windows.Forms.Padding(0)
        Me.services.Name = "services"
        Me.services.Size = New System.Drawing.Size(380, 40)
        Me.services.TabIndex = 5
        Me.services.Text = "服务                                                "
        Me.services.UseVisualStyleBackColor = True
        '
        'regedit
        '
        Me.regedit.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.regedit
        Me.regedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.regedit.FlatAppearance.BorderSize = 0
        Me.regedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.regedit.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.regedit.Location = New System.Drawing.Point(0, 440)
        Me.regedit.Margin = New System.Windows.Forms.Padding(0)
        Me.regedit.Name = "regedit"
        Me.regedit.Size = New System.Drawing.Size(380, 40)
        Me.regedit.TabIndex = 6
        Me.regedit.Text = "手动编辑注册表                                 "
        Me.regedit.UseVisualStyleBackColor = True
        '
        'msconfig
        '
        Me.msconfig.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.实用配置工具
        Me.msconfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.msconfig.FlatAppearance.BorderSize = 0
        Me.msconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.msconfig.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.msconfig.Location = New System.Drawing.Point(0, 526)
        Me.msconfig.Margin = New System.Windows.Forms.Padding(0)
        Me.msconfig.Name = "msconfig"
        Me.msconfig.Size = New System.Drawing.Size(380, 40)
        Me.msconfig.TabIndex = 7
        Me.msconfig.Text = "系统配置常用工具                             "
        Me.msconfig.UseVisualStyleBackColor = True
        '
        'gpedit
        '
        Me.gpedit.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.组策略
        Me.gpedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gpedit.FlatAppearance.BorderSize = 0
        Me.gpedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpedit.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gpedit.Location = New System.Drawing.Point(0, 397)
        Me.gpedit.Margin = New System.Windows.Forms.Padding(0)
        Me.gpedit.Name = "gpedit"
        Me.gpedit.Size = New System.Drawing.Size(380, 40)
        Me.gpedit.TabIndex = 8
        Me.gpedit.Text = "组策略                                              "
        Me.gpedit.UseVisualStyleBackColor = True
        '
        'MD5B
        '
        Me.MD5B.AllowDrop = True
        Me.MD5B.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.MD5
        Me.MD5B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MD5B.FlatAppearance.BorderSize = 0
        Me.MD5B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MD5B.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MD5B.Location = New System.Drawing.Point(0, 220)
        Me.MD5B.Margin = New System.Windows.Forms.Padding(0)
        Me.MD5B.Name = "MD5B"
        Me.MD5B.Size = New System.Drawing.Size(380, 40)
        Me.MD5B.TabIndex = 9
        Me.MD5B.Text = "检测文件MD5值                               "
        Me.MD5B.UseVisualStyleBackColor = True
        '
        'UNUACICON
        '
        Me.UNUACICON.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.NOUACICON
        Me.UNUACICON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UNUACICON.FlatAppearance.BorderSize = 0
        Me.UNUACICON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UNUACICON.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UNUACICON.Location = New System.Drawing.Point(0, 349)
        Me.UNUACICON.Margin = New System.Windows.Forms.Padding(0)
        Me.UNUACICON.Name = "UNUACICON"
        Me.UNUACICON.Size = New System.Drawing.Size(380, 40)
        Me.UNUACICON.TabIndex = 10
        Me.UNUACICON.Text = "去除小盾牌                                       "
        Me.UNUACICON.UseVisualStyleBackColor = True
        '
        'clean
        '
        Me.clean.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Clean
        Me.clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clean.FlatAppearance.BorderSize = 0
        Me.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clean.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.clean.Location = New System.Drawing.Point(0, 305)
        Me.clean.Margin = New System.Windows.Forms.Padding(0)
        Me.clean.Name = "clean"
        Me.clean.Size = New System.Drawing.Size(380, 40)
        Me.clean.TabIndex = 10
        Me.clean.Text = "系统垃圾清理                                   "
        Me.clean.UseVisualStyleBackColor = True
        '
        'Ohosts
        '
        Me.Ohosts.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Hosts
        Me.Ohosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Ohosts.FlatAppearance.BorderSize = 0
        Me.Ohosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ohosts.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Ohosts.Location = New System.Drawing.Point(0, 262)
        Me.Ohosts.Margin = New System.Windows.Forms.Padding(0)
        Me.Ohosts.Name = "Ohosts"
        Me.Ohosts.Size = New System.Drawing.Size(380, 40)
        Me.Ohosts.TabIndex = 10
        Me.Ohosts.Text = "一键更换hosts                                 "
        Me.Ohosts.UseVisualStyleBackColor = True
        '
        '颜色校正
        '
        Me.颜色校正.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Color
        Me.颜色校正.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.颜色校正.FlatAppearance.BorderSize = 0
        Me.颜色校正.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.颜色校正.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.颜色校正.Location = New System.Drawing.Point(0, 483)
        Me.颜色校正.Margin = New System.Windows.Forms.Padding(0)
        Me.颜色校正.Name = "颜色校正"
        Me.颜色校正.Size = New System.Drawing.Size(380, 40)
        Me.颜色校正.TabIndex = 11
        Me.颜色校正.Text = "颜色校准                                          "
        Me.颜色校正.UseVisualStyleBackColor = True
        '
        'INSKMS
        '
        Me.INSKMS.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.key
        Me.INSKMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.INSKMS.Enabled = False
        Me.INSKMS.FlatAppearance.BorderSize = 0
        Me.INSKMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.INSKMS.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.INSKMS.Location = New System.Drawing.Point(0, 133)
        Me.INSKMS.Margin = New System.Windows.Forms.Padding(0)
        Me.INSKMS.Name = "INSKMS"
        Me.INSKMS.Size = New System.Drawing.Size(380, 40)
        Me.INSKMS.TabIndex = 12
        Me.INSKMS.Text = "安装KMS密钥                                   "
        Me.INSKMS.UseVisualStyleBackColor = True
        '
        'test
        '
        Me.test.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.test
        Me.test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.test.FlatAppearance.BorderSize = 0
        Me.test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.test.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.test.Location = New System.Drawing.Point(0, 49)
        Me.test.Margin = New System.Windows.Forms.Padding(0)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(380, 40)
        Me.test.TabIndex = 13
        Me.test.Text = "检测系统激活状态                              "
        Me.test.UseVisualStyleBackColor = True
        '
        'TUB
        '
        Me.TUB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TUB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TUB.Location = New System.Drawing.Point(-10, -3)
        Me.TUB.Margin = New System.Windows.Forms.Padding(0)
        Me.TUB.Name = "TUB"
        Me.TUB.Size = New System.Drawing.Size(409, 51)
        Me.TUB.TabIndex = 14
        Me.TUB.TabStop = False
        '
        'CPUT
        '
        Me.CPUT.Enabled = True
        Me.CPUT.Interval = 1000
        '
        '窗口位置限制
        '
        Me.窗口位置限制.Interval = 1
        '
        'Start
        '
        Me.Start.Enabled = True
        Me.Start.Interval = 1
        '
        'EndT
        '
        Me.EndT.Interval = 1
        '
        '设置
        '
        Me.设置.BackColor = System.Drawing.Color.White
        Me.设置.Controls.Add(Me.V)
        Me.设置.Controls.Add(Me.BColorG)
        Me.设置.Controls.Add(Me.FColorG)
        Me.设置.Controls.Add(Me.Settingst)
        Me.设置.Controls.Add(Me.SettingsUB)
        Me.设置.Controls.Add(Me.StyleG)
        Me.设置.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.设置.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.设置.ForeColor = System.Drawing.Color.Black
        Me.设置.Location = New System.Drawing.Point(42, 139)
        Me.设置.Margin = New System.Windows.Forms.Padding(0)
        Me.设置.Name = "设置"
        Me.设置.Padding = New System.Windows.Forms.Padding(0)
        Me.设置.Size = New System.Drawing.Size(380, 622)
        Me.设置.TabIndex = 15
        Me.设置.TabStop = False
        Me.设置.Visible = False
        '
        'V
        '
        Me.V.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.V.Location = New System.Drawing.Point(-1, 426)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(378, 91)
        Me.V.TabIndex = 19
        Me.V.Text = "作者：XUMUMI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "邮箱：XUMUMI@outlook.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "版本：1.1.2"
        Me.V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BColorG
        '
        Me.BColorG.Controls.Add(Me.BColorB)
        Me.BColorG.Controls.Add(Me.BColorL)
        Me.BColorG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BColorG.Location = New System.Drawing.Point(16, 161)
        Me.BColorG.Name = "BColorG"
        Me.BColorG.Size = New System.Drawing.Size(351, 100)
        Me.BColorG.TabIndex = 17
        Me.BColorG.TabStop = False
        Me.BColorG.Text = "背景色调"
        '
        'BColorB
        '
        Me.BColorB.AutoSize = True
        Me.BColorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BColorB.Location = New System.Drawing.Point(18, 60)
        Me.BColorB.Margin = New System.Windows.Forms.Padding(0)
        Me.BColorB.Name = "BColorB"
        Me.BColorB.Size = New System.Drawing.Size(59, 25)
        Me.BColorB.TabIndex = 15
        Me.BColorB.Text = "深色"
        Me.BColorB.UseVisualStyleBackColor = True
        '
        'BColorL
        '
        Me.BColorL.AutoSize = True
        Me.BColorL.Checked = True
        Me.BColorL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BColorL.Location = New System.Drawing.Point(18, 30)
        Me.BColorL.Margin = New System.Windows.Forms.Padding(0)
        Me.BColorL.Name = "BColorL"
        Me.BColorL.Size = New System.Drawing.Size(59, 25)
        Me.BColorL.TabIndex = 15
        Me.BColorL.TabStop = True
        Me.BColorL.Text = "浅色"
        Me.BColorL.UseVisualStyleBackColor = True
        '
        'FColorG
        '
        Me.FColorG.Controls.Add(Me.FColorS)
        Me.FColorG.Controls.Add(Me.FColorC)
        Me.FColorG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FColorG.Location = New System.Drawing.Point(16, 269)
        Me.FColorG.Name = "FColorG"
        Me.FColorG.Size = New System.Drawing.Size(351, 100)
        Me.FColorG.TabIndex = 16
        Me.FColorG.TabStop = False
        Me.FColorG.Text = "色彩主题"
        '
        'FColorS
        '
        Me.FColorS.AutoSize = True
        Me.FColorS.Checked = True
        Me.FColorS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FColorS.Location = New System.Drawing.Point(19, 28)
        Me.FColorS.Margin = New System.Windows.Forms.Padding(0)
        Me.FColorS.Name = "FColorS"
        Me.FColorS.Size = New System.Drawing.Size(139, 25)
        Me.FColorS.TabIndex = 15
        Me.FColorS.TabStop = True
        Me.FColorS.Text = "跟随系统主题色"
        Me.FColorS.UseVisualStyleBackColor = True
        '
        'FColorC
        '
        Me.FColorC.AutoSize = True
        Me.FColorC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FColorC.Location = New System.Drawing.Point(19, 59)
        Me.FColorC.Margin = New System.Windows.Forms.Padding(0)
        Me.FColorC.Name = "FColorC"
        Me.FColorC.Size = New System.Drawing.Size(123, 25)
        Me.FColorC.TabIndex = 15
        Me.FColorC.Text = "使用默认主题"
        Me.FColorC.UseVisualStyleBackColor = True
        '
        'Settingst
        '
        Me.Settingst.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Settingst.AutoSize = True
        Me.Settingst.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Settingst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settingst.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Settingst.ForeColor = System.Drawing.Color.Black
        Me.Settingst.Location = New System.Drawing.Point(14, 8)
        Me.Settingst.Margin = New System.Windows.Forms.Padding(0)
        Me.Settingst.Name = "Settingst"
        Me.Settingst.Size = New System.Drawing.Size(54, 28)
        Me.Settingst.TabIndex = 2
        Me.Settingst.Text = "设置"
        '
        'SettingsUB
        '
        Me.SettingsUB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsUB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SettingsUB.Location = New System.Drawing.Point(0, -4)
        Me.SettingsUB.Margin = New System.Windows.Forms.Padding(0)
        Me.SettingsUB.Name = "SettingsUB"
        Me.SettingsUB.Size = New System.Drawing.Size(382, 51)
        Me.SettingsUB.TabIndex = 14
        Me.SettingsUB.TabStop = False
        '
        'StyleG
        '
        Me.StyleG.Controls.Add(Me.ColorfullRB)
        Me.StyleG.Controls.Add(Me.FlatRB)
        Me.StyleG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StyleG.Location = New System.Drawing.Point(16, 55)
        Me.StyleG.Name = "StyleG"
        Me.StyleG.Size = New System.Drawing.Size(351, 100)
        Me.StyleG.TabIndex = 17
        Me.StyleG.TabStop = False
        Me.StyleG.Text = "配色方案"
        '
        'ColorfullRB
        '
        Me.ColorfullRB.AutoSize = True
        Me.ColorfullRB.Checked = True
        Me.ColorfullRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorfullRB.Location = New System.Drawing.Point(19, 28)
        Me.ColorfullRB.Margin = New System.Windows.Forms.Padding(0)
        Me.ColorfullRB.Name = "ColorfullRB"
        Me.ColorfullRB.Size = New System.Drawing.Size(59, 25)
        Me.ColorfullRB.TabIndex = 15
        Me.ColorfullRB.TabStop = True
        Me.ColorfullRB.Text = "搭配"
        Me.ColorfullRB.UseVisualStyleBackColor = True
        '
        'FlatRB
        '
        Me.FlatRB.AutoSize = True
        Me.FlatRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatRB.Location = New System.Drawing.Point(19, 59)
        Me.FlatRB.Margin = New System.Windows.Forms.Padding(0)
        Me.FlatRB.Name = "FlatRB"
        Me.FlatRB.Size = New System.Drawing.Size(59, 25)
        Me.FlatRB.TabIndex = 15
        Me.FlatRB.Text = "纯色"
        Me.FlatRB.UseVisualStyleBackColor = True
        '
        '向上滚
        '
        Me.向上滚.Interval = 1
        '
        '向下滚
        '
        Me.向下滚.Interval = 1
        '
        'MIN
        '
        Me.MIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.MIN.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.MINw
        Me.MIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MIN.FlatAppearance.BorderSize = 0
        Me.MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MIN.ForeColor = System.Drawing.Color.Transparent
        Me.MIN.Location = New System.Drawing.Point(-4, 530)
        Me.MIN.Margin = New System.Windows.Forms.Padding(0)
        Me.MIN.Name = "MIN"
        Me.MIN.Size = New System.Drawing.Size(48, 45)
        Me.MIN.TabIndex = 5
        Me.MIN.UseVisualStyleBackColor = False
        '
        'ExitB
        '
        Me.ExitB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExitB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ExitB.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Closew
        Me.ExitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExitB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ExitB.FlatAppearance.BorderSize = 0
        Me.ExitB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExitB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ExitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitB.ForeColor = System.Drawing.Color.Transparent
        Me.ExitB.Location = New System.Drawing.Point(-4, 575)
        Me.ExitB.Margin = New System.Windows.Forms.Padding(0)
        Me.ExitB.Name = "ExitB"
        Me.ExitB.Size = New System.Drawing.Size(48, 45)
        Me.ExitB.TabIndex = 6
        Me.ExitB.UseVisualStyleBackColor = False
        '
        'ThreeB
        '
        Me.ThreeB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ThreeB.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Settings2
        Me.ThreeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ThreeB.FlatAppearance.BorderSize = 0
        Me.ThreeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThreeB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ThreeB.Location = New System.Drawing.Point(-4, 482)
        Me.ThreeB.Margin = New System.Windows.Forms.Padding(0)
        Me.ThreeB.Name = "ThreeB"
        Me.ThreeB.Size = New System.Drawing.Size(48, 48)
        Me.ThreeB.TabIndex = 4
        Me.ThreeB.UseVisualStyleBackColor = False
        '
        'TwoB
        '
        Me.TwoB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TwoB.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.tools2
        Me.TwoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TwoB.FlatAppearance.BorderSize = 0
        Me.TwoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TwoB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TwoB.Location = New System.Drawing.Point(-4, 97)
        Me.TwoB.Margin = New System.Windows.Forms.Padding(0)
        Me.TwoB.Name = "TwoB"
        Me.TwoB.Size = New System.Drawing.Size(48, 48)
        Me.TwoB.TabIndex = 3
        Me.TwoB.UseVisualStyleBackColor = False
        '
        'OneB
        '
        Me.OneB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.OneB.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.Home
        Me.OneB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OneB.FlatAppearance.BorderSize = 0
        Me.OneB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OneB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.OneB.Location = New System.Drawing.Point(-4, 49)
        Me.OneB.Margin = New System.Windows.Forms.Padding(0)
        Me.OneB.Name = "OneB"
        Me.OneB.Size = New System.Drawing.Size(48, 48)
        Me.OneB.TabIndex = 2
        Me.OneB.UseVisualStyleBackColor = False
        '
        '三
        '
        Me.三.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.三.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.三_L
        Me.三.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.三.FlatAppearance.BorderSize = 0
        Me.三.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.三.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.三.Location = New System.Drawing.Point(-4, 1)
        Me.三.Margin = New System.Windows.Forms.Padding(0)
        Me.三.Name = "三"
        Me.三.Size = New System.Drawing.Size(48, 48)
        Me.三.TabIndex = 1
        Me.三.UseVisualStyleBackColor = False
        '
        'Bar
        '
        Me.Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bar.Location = New System.Drawing.Point(0, -5)
        Me.Bar.Margin = New System.Windows.Forms.Padding(0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(44, 2000)
        Me.Bar.TabIndex = 6
        Me.Bar.TabStop = False
        '
        'logop
        '
        Me.logop.BackgroundImage = Global.Windows10BarTools.My.Resources.Resources.XOLOGO
        Me.logop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logop.Location = New System.Drawing.Point(42, 0)
        Me.logop.Margin = New System.Windows.Forms.Padding(0)
        Me.logop.Name = "logop"
        Me.logop.Size = New System.Drawing.Size(379, 138)
        Me.logop.TabIndex = 8
        Me.logop.TabStop = False
        '
        'Form
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 620)
        Me.Controls.Add(Me.MIN)
        Me.Controls.Add(Me.ExitB)
        Me.Controls.Add(Me.ThreeB)
        Me.Controls.Add(Me.TwoB)
        Me.Controls.Add(Me.OneB)
        Me.Controls.Add(Me.三)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.设置)
        Me.Controls.Add(Me.其他工具)
        Me.Controls.Add(Me.logop)
        Me.Controls.Add(Me.ICard)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows10BarTools"
        Me.ICard.ResumeLayout(False)
        Me.ICard.PerformLayout()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.其他工具.ResumeLayout(False)
        Me.其他工具.PerformLayout()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.设置.ResumeLayout(False)
        Me.设置.PerformLayout()
        Me.BColorG.ResumeLayout(False)
        Me.BColorG.PerformLayout()
        Me.FColorG.ResumeLayout(False)
        Me.FColorG.PerformLayout()
        CType(Me.SettingsUB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StyleG.ResumeLayout(False)
        Me.StyleG.PerformLayout()
        CType(Me.Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 刷新 As Timer
    Friend WithEvents 屏幕分辨率 As Label
    Friend WithEvents 当前计算机名 As Label
    Friend WithEvents XXY As Label
    Friend WithEvents 当前用户 As Label
    Friend WithEvents 运行时间 As Label
    Friend WithEvents 显卡 As Label
    Friend WithEvents 内存信息 As Label
    Friend WithEvents 中央处理器信息 As Label
    Friend WithEvents ID As Label
    Friend WithEvents User As Label
    Friend WithEvents 显卡型号 As Label
    Friend WithEvents Time As Label
    Friend WithEvents CPU As Label
    Friend WithEvents Memory As Label
    Friend WithEvents CPUINFO As Label
    Friend WithEvents 系统版本 As Label
    Friend WithEvents Systeminfo As Label
    Friend WithEvents Bar As PictureBox
    Friend WithEvents 三 As Button
    Friend WithEvents OneB As Button
    Friend WithEvents ExitB As Button
    Friend WithEvents P1 As Timer
    Friend WithEvents P2 As Timer
    Friend WithEvents P3 As Timer
    Friend WithEvents TwoB As Button
    Friend WithEvents ThreeB As Button
    Friend WithEvents MBar As ProgressBar
    Friend WithEvents 主板型号 As Label
    Friend WithEvents Board As Label
    Friend WithEvents Pz As Timer
    Friend WithEvents Ps As Timer
    Friend WithEvents Openhosts As OpenFileDialog
    Friend WithEvents OpenMD5 As OpenFileDialog
    Friend WithEvents tMD5 As Timer
    Friend WithEvents ICard As GroupBox
    Friend WithEvents 系统信息 As Label
    Friend WithEvents Line1 As PictureBox
    Friend WithEvents 硬件信息 As Label
    Friend WithEvents CBar As ProgressBar
    Friend WithEvents 其他工具 As GroupBox
    Friend WithEvents Updater As Button
    Friend WithEvents services As Button
    Friend WithEvents regedit As Button
    Friend WithEvents msconfig As Button
    Friend WithEvents gpedit As Button
    Friend WithEvents MD5B As Button
    Friend WithEvents Ohosts As Button
    Friend WithEvents 颜色校正 As Button
    Friend WithEvents INSKMS As Button
    Friend WithEvents test As Button
    Friend WithEvents 工具标题 As Label
    Friend WithEvents TUB As PictureBox
    Friend WithEvents Line2 As PictureBox
    Friend WithEvents CPUT As Timer
    Friend WithEvents CPUP As Label
    Friend WithEvents 窗口位置限制 As Timer
    Friend WithEvents logop As PictureBox
    Friend WithEvents MIN As Button
    Friend WithEvents Start As Timer
    Friend WithEvents UNUACICON As Button
    Friend WithEvents clean As Button
    Friend WithEvents EndT As Timer
    Friend WithEvents 设置 As GroupBox
    Friend WithEvents Settingst As Label
    Friend WithEvents SettingsUB As PictureBox
    Friend WithEvents FColorS As RadioButton
    Friend WithEvents FColorC As RadioButton
    Friend WithEvents CleanBar As ProgressBar
    Friend WithEvents AKAC As Button
    Friend WithEvents FColorG As GroupBox
    Friend WithEvents BColorG As GroupBox
    Friend WithEvents BColorB As RadioButton
    Friend WithEvents BColorL As RadioButton
    Friend WithEvents 向上滚 As Timer
    Friend WithEvents 向下滚 As Timer
    Friend WithEvents V As Label
    Friend WithEvents StyleG As GroupBox
    Friend WithEvents ColorfullRB As RadioButton
    Friend WithEvents FlatRB As RadioButton
    Friend WithEvents Line3 As PictureBox
End Class
