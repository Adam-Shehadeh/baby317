Imports baby317_lib
Imports Microsoft.Win32

Public Class frmDeploy

    Private Sub frmDeploy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = GetRandomMessage()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Function GetRandomMessage() As String
        Dim index As Integer = 0
        Dim data As List(Of RowModel) = READ()
        Dim rnd As New Random()
        Dim msg As String = ""

        Randomize()
        index = rnd.Next(1, data.Count + 1)


        index -= 1 'List index in VB starts at 1, DB starts at 0
        msg = data(index).MSG

        Return msg
    End Function

    Private Sub AddOnStartUp()
        Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath, RegistryValueKind.String)
    End Sub

    Private Sub RemoveOnStartUp()
        Try
            Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnDisableStartup_Click(sender As Object, e As EventArgs) Handles btnDisableStartup.Click
        RemoveOnStartUp()
    End Sub

    Private Sub btnEnableStartup_Click(sender As Object, e As EventArgs) Handles btnEnableStartup.Click
        AddOnStartUp()
    End Sub
End Class
