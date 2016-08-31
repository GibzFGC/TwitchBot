Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class AddaCommand

    Public data_source As String = Application.StartupPath & "\Data\core.sqlite"
    Public SQLconnect As SQLiteConnection = New SQLiteConnection("Data Source=" & data_source)

    Private Sub CancelBtn1_Click(sender As Object, e As EventArgs) Handles CancelBtn1.Click

        Me.Close()

    End Sub

    Private Sub SaveBtn1_Click(sender As Object, e As EventArgs) Handles SaveBtn1.Click

        SQLconnect.ConnectionString = "Data Source=" & data_source & ";"
        SQLconnect.Open()

        Dim SQLcommand1 As SQLiteCommand

        SQLcommand1 = SQLconnect.CreateCommand
        SQLcommand1.CommandText = "INSERT INTO mgsbot_commands VALUES (@command, @value)"

        Dim commandString As SQLiteParameter = New SQLiteParameter("@command")
        Dim valueString As SQLiteParameter = New SQLiteParameter("@value")

        SQLcommand1.Parameters.Add(commandString)
        SQLcommand1.Parameters.Add(valueString)

        commandString.Value = CommandTxt1.Text
        valueString.Value = ValueTxt1.Text

        SQLcommand1.ExecuteNonQuery()

        SQLcommand1.Dispose()

        SQLconnect.Close()

        IRCClient.sendChatMessage("The command: " + CommandTxt1.Text + " has been added to the bot.")

        Me.Close()

    End Sub

    Private Sub AddaCommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
