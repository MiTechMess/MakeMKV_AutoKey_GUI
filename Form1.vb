Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear() ' Clear the TextBox before starting the process

        Dim p As New Process()
        ' Read the resource as a Byte array and write it to a temporary file
        Dim exeBytes As Byte() = My.Resources.makemkv_key_reg_final
        Dim exePath As String = Path.Combine(Path.GetTempPath(), "makemkv_key_reg_final.exe")
        File.WriteAllBytes(exePath, exeBytes)
        ' Set the file path of the temporary file as the FileName property
        p.StartInfo.FileName = exePath

        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.Arguments = "-x"
        p.StartInfo.RedirectStandardOutput = True
        AddHandler p.OutputDataReceived, AddressOf OutputHandler
        p.Start()
        p.BeginOutputReadLine()
    End Sub

    Private Sub OutputHandler(sender As Object, args As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(args.Data) Then
            If args.Data.Contains("key_added") Then
                ' Invoke the method on the UI thread
                TextBox1.Invoke(Sub() TextBox1.AppendText("MakeMKV Key updated!" & vbCrLf))

            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        'Show the new form.
        Form2.Show()

    End Sub

End Class