Imports System.Security
Imports System.Text

Public Class Form1
    'Coded by de4dot 

    'instagram : @de4dot 
    'telegram : @YYxYY
    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        NsTextBoxNewSerial.Text = Convert_To_MD5(NsTextBoxSerial.Text & "+" & NsTextBoxPass.Text)
    End Sub
    Public Function Convert_To_MD5(ByVal input As String) As String
        Dim M2De As New Cryptography.MD5CryptoServiceProvider
        Dim Res As String = String.Empty
        Dim TmpDe As String = String.Empty
        Dim Data As Byte() = Encoding.ASCII.GetBytes(input)
        Dim Result As Byte() = M2De.ComputeHash(Data)
        For i As Integer = 0 To Result.Length - 1
            TmpDe = Hex(Result(i))
            If Len(TmpDe) = 1 Then TmpDe = "0" & TmpDe
            Res += TmpDe
        Next
        Return Res
    End Function
    Private Sub NsOnOffBox1_CheckedChanged(sender As Object) Handles NsOnOffBox1.CheckedChanged
        If NsOnOffBox1.Checked = False Then
            End
        End If
    End Sub
End Class
