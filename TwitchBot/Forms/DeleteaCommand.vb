Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class DeleteaCommand

    Public data_source As String = Application.StartupPath & "\Data\core.sqlite"
    Public SQLconnect As SQLiteConnection = New SQLiteConnection("Data Source=" & data_source)

    Private Sub CancelBtn1_Click(sender As Object, e As EventArgs) Handles CancelBtn1.Click
        Me.Close()
    End Sub

    Private Sub DeleteBtn1_Click(sender As Object, e As EventArgs) Handles DeleteBtn1.Click

        SQLconnect.ConnectionString = "Data Source=" & data_source & ";"
        SQLconnect.Open()

        Dim SQLcommand As SQLiteCommand

        SQLcommand = SQLconnect.CreateCommand

        SQLcommand.CommandText = "DELETE FROM mgsbot_commands WHERE command = '" + CommandTxt1.Text + "'"
        SQLcommand.ExecuteNonQuery()

        SQLcommand.Dispose()

        SQLconnect.Close()

        IRCClient.sendChatMessage("The command: " + CommandTxt1.Text + " has been deleted from the bot.")

        Me.Close()

    End Sub
End Class
