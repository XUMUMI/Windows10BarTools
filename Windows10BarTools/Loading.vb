Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class Loading
    Public FtC As Color
    Public FtCa As Color
    Public Shared Function _MD5(ByVal strSource As String) As String
        Dim fstream As New FileStream(strSource, FileMode.Open, FileAccess.Read)
        Dim dataToHash(fstream.Length - 1) As Byte
        fstream.Read(dataToHash, 0, fstream.Length)
        fstream.Close()
        Dim hashvalue As Byte() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(dataToHash)
        Dim i As Integer
        Dim result As String = ""
        For i = 0 To hashvalue.Length - 1
            result += Hex(hashvalue(i)).ToLower
        Next
        Return result
    End Function

    Dim wmi = GetObject("winmgmts:\\.\root\CIMV2")


    Function GMD5(ByVal e As String) As String
        Dim md5Hasher As MD5 = MD5.Create()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(e))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Function Base64(ByVal e)
        Dim b As Byte(), rt As String
        b = Encoding.GetEncoding(-0).GetBytes(e)
        rt = Convert.ToBase64String(b)
        Return rt
    End Function
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-----------------------------
        '检测机制()
        'If Now.Year <> 2015 And Now.Month <> 9 Then
        '    MsgBox("该副本已过期！")
        '        End
        '        End If
        '--------------------------------
        Show()
        '读取设置
        If Dir("TBtheme") <> "" Then
            Dim themer As New StreamReader("TBtheme")
            Form.themecolor = themer.ReadLine
            Form.lightcolor = themer.ReadLine
            Form.stylecolor = themer.ReadLine
            themer.Close()
        Else
            Form.Writethemetofile()
        End If
        '刷新颜色
        FormColor()
        GC_Tick(sender, e)
        If FtC.R >= 200 And FtC.G >= 200 And FtC.B >= 200 Then BackgroundImage = My.Resources.XOLOGOb Else BackgroundImage = My.Resources.XOLOGO
        ' If Dir("md5.exe") = "" Then
        '    MsgBox("MD5校验插件丢失，可能无法正常计算超过2G的文件的MD5值"， vbInformation, "警告！")
        '   ElseIf _MD5("md5.exe").ToString <> "609f46a341fedeaeec18abf9fb7c9647" Then
        '      MsgBox("MD5校验插件受损，可能无法正常计算超过2G的文件的MD5值"， vbInformation, "警告！")
        '     End If
        Form.Show()
        Visible = False
    End Sub

    Sub 检测机制()
        Try
            If Dir("key") = "" Then
                Beta.ShowDialog()
            Else
                Dim Bm = "XUMUMI"
                Dim boards = wmi.ExecQuery("select * from win32_BaseBoard")
                For Each i In boards
                    If InStr(i.Manufacturer, "To be filled") Then
                        MsgBox("不适用于此计算机")
                        End
                    Else
                        Bm = i.Manufacturer & " " & i.ProDuct
                    End If
                Next
                Dim RrMD5 = GMD5(Bm)
                Dim x = 0
                Do
                    x = x + 1
                    RrMD5 = GMD5(RrMD5)
                    RrMD5 = Base64(RrMD5)
                Loop Until x = 1977
                Dim rk As New StreamReader("key")
                Dim rrk = rk.ReadLine
                rk.Close()
                If rrk <> RrMD5 Then
                    MsgBox("内测码无效！")
                    Kill("key")
                    End
                End If
            End If
        Catch ex As Exception
            MsgBox("副本无效！")
            End
        End Try
    End Sub

    Sub FormColor()
        '主题色
        Form.Bar.BackColor = FtC
        Form.三.BackColor = FtC
        Form.OneB.BackColor = FtC
        Form.TwoB.BackColor = FtC
        Form.ThreeB.BackColor = FtC
        Form.MIN.BackColor = FtC
        Form.ExitB.BackColor = FtC
        Form.logop.BackColor = FtC
        Form.Line1.BackColor = FtC
        Form.BackColor = FtC

        If Form.lightcolor = 1 Then
            Form.SettingsUB.BackColor = Color.FromArgb(242, 242, 242)
            Form.TUB.BackColor = Color.FromArgb(242, 242, 242)
            Form.Settingst.BackColor = Color.FromArgb(242, 242, 242)
            Form.工具标题.BackColor = Color.FromArgb(242, 242, 242)
            Form.设置.BackColor = Color.White
            Form.其他工具.BackColor = Color.White
            Form.FColorG.BackColor = Color.White
            Form.BColorG.BackColor = Color.White
            Form.ICard.BackColor = Color.White
            Form.设置.ForeColor = Color.Black
            Form.其他工具.ForeColor = Color.Black
            Form.FColorG.ForeColor = Color.Black
            Form.BColorG.ForeColor = Color.Black
            Form.Settingst.ForeColor = Color.Black
            Form.工具标题.ForeColor = Color.Black
            Form.ICard.ForeColor = Color.Black
        Else
            Form.SettingsUB.BackColor = Color.FromArgb(64, 64, 64)
            Form.TUB.BackColor = Color.FromArgb(64, 64, 64)
            Form.Settingst.BackColor = Color.FromArgb(64, 64, 64)
            Form.工具标题.BackColor = Color.FromArgb(64, 64, 64)
            Form.设置.BackColor = Color.DimGray
            Form.其他工具.BackColor = Color.DimGray
            Form.FColorG.BackColor = Color.DimGray
            Form.BColorG.BackColor = Color.DimGray
            Form.ICard.BackColor = Color.DimGray
            Form.设置.ForeColor = Color.White
            Form.其他工具.ForeColor = Color.White
            Form.FColorG.ForeColor = Color.White
            Form.BColorG.ForeColor = Color.White
            Form.Settingst.ForeColor = Color.White
            Form.工具标题.ForeColor = Color.White
            Form.ICard.ForeColor = Color.White
        End If

    End Sub

    '读取颜色
    Private Sub GC_Tick(sender As Object, e As EventArgs) Handles GC.Tick
        Try
            If Form.themecolor = 0 Then
                FtC = Color.FromArgb(0, 119, 200)
                FtCa = FtC
            Else
                Dim HEXFC = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", "2936042696")
                HEXFC = Hex(HEXFC) 'BGR
                HEXFC = Strings.Right("00000000" & HEXFC, 8) '补全
                Dim FCA = Mid(HEXFC, 1, 2)
                Dim FCR = Mid(HEXFC, 3, 2)
                Dim FCG = Mid(HEXFC, 5, 2)
                Dim FCB = Mid(HEXFC, 7, 2)
                Dim A = CLng("&H" & FCA)
                Dim R = CLng("&H" & FCR)
                Dim G = CLng("&H" & FCG)
                Dim B = CLng("&H" & FCB)
                FtC = Color.FromArgb(R, G, B)  'RGB
                FtCa = Color.FromArgb(A, R, G, B)  'aRGB
                BackColor = FtC
            End If
        Catch ex As Exception
            Form.themecolor = 1
            Form.lightcolor = 1
            Form.stylecolor = 1
            Form.Writethemetofile()
        End Try
    End Sub
End Class