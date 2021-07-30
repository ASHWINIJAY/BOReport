Imports AppUtility.UI.Notification
Imports Insimbi
Public Class frmLogin
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        _username = UCase(txtUserName.Text)
        Dim result = BLL.Users.Login(_username, txtPassword.Text)
        If result IsNot Nothing Then
            _department = result.Item1
            _appFolderEstimation = result.Item2
            _office365user = result.Item3
            _office365password = result.Item4
            DialogResult = DialogResult.OK
        Else
            ErrorMsg("Login failed!")
            txtPassword.Text = ""
            txtPassword.Focus()
        End If
    End Sub
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtUserName.Focus()
    End Sub
End Class