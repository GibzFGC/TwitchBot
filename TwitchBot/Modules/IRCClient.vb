Imports System.IO
Imports System.Net.Sockets

Module IRCClient

    Public username As String
    Private channelc As String

    Private tcpClient As TcpClient
    Private inputStream As StreamReader
    Private outputStream As StreamWriter

    Sub IrcClient(ip As String, port As Integer, username As String, password As String)

        tcpClient = New TcpClient(ip, port)
        inputStream = New StreamReader(tcpClient.GetStream())
        outputStream = New StreamWriter(tcpClient.GetStream())

        outputStream.WriteLine("PASS " + password)
        outputStream.WriteLine("NICK " + username)
        outputStream.WriteLine("USER " + username + " 8 * :" + username)
        outputStream.Flush()

    End Sub

    Sub joinRoom(channel As String)

        channelc = channel
        outputStream.WriteLine("JOIN #" + channel)
        outputStream.Flush()

    End Sub

    Sub sendIrcMessage(message As String)

        outputStream.WriteLine(message)
        outputStream.Flush()

    End Sub

    Sub sendChatMessage(message As String)

        sendIrcMessage(":" + username + "!" + username + "@" + ".tmi.twitch.tv PRIVMSG #" + channelc + " :" + message)

    End Sub

    Sub ircConnected()

        Dim formt As New TwitchForm

        If tcpClient.Connected Then
            formt.updateFormTitle("TwitchBot: Connected")
        Else
            formt.updateFormTitle("TwitchBot: Unable to Connect")
        End If

    End Sub

    Function readMessage()

        Dim Message As String = inputStream.ReadLine()
        Return Message

    End Function

End Module