Imports System.Net
Imports System.Security
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Form1

#Region "Program Rights"

    'Coded by Ahmed Al'jabari - de4dot 

    'instagram : @de4dot 
    'telegram : @YYxYY

#End Region
#Region "Note"

    'Bot_Token : You can get it from @Botfather in telegram
    'Telegram_id : You can get it from @myidbot in telegram
    'Encrypt_Pass : Coder Choose it in Admin Activtion V1.2

    'Code Arrangement in Pastebin : Encrypted_Serial ( from Admin Activtion V1.2 ) @ Username ( Coder Choose it ) | Telgeram_ID ( from @myidbot in telegram )
    'EX : F8A8C16C14808E66BB57A3BB98DA6600@Ahmed|123831251

    'Dont forget send /start to bot!

#End Region
#Region "Variables"

    Dim Code As String
    Dim Expaire_OFF As Boolean
    Dim ComputerSerial As String = Convert_To_MD5(Principal.WindowsIdentity.GetCurrent.User.Value)

    Dim Encrypt_Pass As String = "de4dot"
    Dim Bot_Token As String = "631701631:AAEo1mOWEJzdx3u3PXfgfKm0TMZlVm0Grkg"

    Dim Pastebin As String = New WebClient().DownloadString("https://pastebin.com/raw/9hyJfwSu")

#End Region

    Public Function Convert_To_MD5(ByVal input As String) As String
        Dim M22 As New Cryptography.MD5CryptoServiceProvider
        Dim Data As Byte()
        Dim Result As Byte()
        Dim Res As String = ""
        Dim Tmp As String = ""
        Data = Encoding.ASCII.GetBytes(input)
        Result = M22.ComputeHash(Data)
        For i As Integer = 0 To Result.Length - 1
            Tmp = Hex(Result(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Res += Tmp
        Next
        Return Res
    End Function
    Function Gen_Random_Code(Length As Integer) As String
        Dim str As String = Nothing
        Dim rnd As New Random
        For i As Integer = 0 To Length - 1
            Dim chrInt As Integer = 0
            Do
                chrInt = rnd.Next(30, 122)
                If (chrInt >= 48 And chrInt <= 57) Then
                    Exit Do
                End If
            Loop
            str &= Chr(chrInt)
        Next
        Return str
    End Function
    Sub Send_Code_To_Telegram(code As String)
        If NsTextBoxUsername.Text <> "Username" Then
            Try

                Dim Telegram_User_ID As String = Regex.Match(Pastebin, ".+?@" & NsTextBoxUsername.Text & "\|(\d+)").Groups(1).Value
                MsgBox(Telegram_User_ID)
                ServicePointManager.SecurityProtocol = 3072

                Dim webClient As New WebClient
                Dim result As String = webClient.DownloadString("https://api.telegram.org/bot" & Bot_Token & "/sendMessage?chat_id=" & Telegram_User_ID & "&text=Code : " & code)

            Catch ex As Exception
                MsgBox(ex.Message,, "Login System - @de4dot")
            End Try
        Else
            MsgBox("Enter Username",, "Login System - @de4dot")
        End If
    End Sub
    Sub Code_Expaire()
        For i As Integer = 0 To 60
            Thread.Sleep(1000)
            Invoke(Sub() Label2.Text += 1)
            If Expaire_OFF = True Then Exit Sub
        Next
        Invoke(Sub() Label2.Text = 0)
        Code = Gen_Random_Code(15)
        MsgBox("Code Expaire",, "Login System - @de4dot")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NsTextBoxSerialCode.Text = ComputerSerial
    End Sub
    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        Code = Gen_Random_Code(5)
        Task.Factory.StartNew(Sub() Send_Code_To_Telegram(Code))
        Task.Factory.StartNew(Sub() Code_Expaire())
    End Sub
    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        If NsTextBoxTelegramCode.Text = Code And Pastebin.Contains(Convert_To_MD5(ComputerSerial & "+" & Encrypt_Pass)) Then
            Expaire_OFF = True
            MsgBox("Login Success",, "Login System - @de4dot")
        Else
            MsgBox("Login Failed", , "Login System - @de4dot")
        End If
    End Sub
    Private Sub NsOnOffBox1_CheckedChanged(sender As Object) Handles NsOnOffBox1.CheckedChanged
        If NsOnOffBox1.Checked = False Then
            End
        End If
    End Sub
End Class