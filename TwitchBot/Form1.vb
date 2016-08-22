Public Class Form1

    Private Sub TwitchLogin1_Click(sender As Object, e As EventArgs) Handles TwitchLogin1.Click

        If TwitchRemember1.CheckState = CheckState.Checked Then

            My.Settings.TwitchUser = TwitchUser1.Text
            My.Settings.TwitchOAuth = TwitchOAuth1.Text
            My.Settings.TwitchChannel = TwitchChannel1.Text

            My.Settings.TwitchRemember = True
            My.Settings.Save()

            Dim TwitchForm As New TwitchForm
            TwitchForm.Show()

        Else

            Dim TwitchForm As New TwitchForm
            TwitchForm.twitchUser = TwitchUser1.Text
            TwitchForm.twitchOAuth = TwitchOAuth1.Text
            TwitchForm.twitchChannel = TwitchChannel1.Text
            TwitchForm.Show()

        End If

        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.TwitchRemember = True Then
            Dim TwitchForm As New TwitchForm
            TwitchForm.Show()

            Me.Close()
        End If

    End Sub
End Class
