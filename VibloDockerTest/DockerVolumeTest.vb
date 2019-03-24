Imports System.IO

Module DockerVolumeTest

    Sub Main()
        Dim now As DateTime = DateTime.Now
        Dim logFileName = now.ToString("yyyyMMdd") & ".log"
        Dim content = now.ToString() & Environment.NewLine

        Dim aPath As String = AppDomain.CurrentDomain.BaseDirectory

        Dim writer As New StreamWriter(aPath & "\Log\" & logFileName, True, Text.Encoding.UTF8)
        writer.Write(content)
        writer.Close()
    End Sub

End Module
