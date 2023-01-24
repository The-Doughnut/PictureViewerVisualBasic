Public Class Form1
    Dim ImageToLoad As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Application.CommandLineArgs.Count

        If My.Application.CommandLineArgs.Count >= 1 Then
            ImageToLoad = My.Application.CommandLineArgs(0)
        End If

        UpdateImage()
    End Sub

    Private Sub UpdateImage()
        If ImageToLoad <> "" Then
            PictureBox1.Load(ImageToLoad)
        End If
    End Sub

    'Sub Main()
    '    Dim CommandLineArguments As String() = Environment.GetCommandLineArgs

    '    For Each Argument As String In CommandLineArguments
    '        Console.WriteLine(Argument)
    '    Next
    '    Console.Read()
    'End Sub

    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click

        ' Show the Open File dialog. If the user clicks OK, load the
        ' picture that the user chose.
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Clear the picture.
        PictureBox1.Image = Nothing
    End Sub

    Private Sub backgroundButton_Click(sender As Object, e As EventArgs) Handles backgroundButton.Click
        ' Show the colour dialog box. If the user clicks OK, change the
        ' PictureBox control's background to the colour the user chose.
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        ' Close the form
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' If the user selects the Stretch check box, change
        ' the PictureBox's SizeMode property to "Stretch". If the user
        ' clease the check box, change it to "Normal".
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub soundButton_Click(sender As Object, e As EventArgs) Handles soundButton.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            My.Computer.Audio.Play(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub muteButton_Click(sender As Object, e As EventArgs) Handles muteButton.Click
        My.Computer.Audio.Stop()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Label1.Text = My.Application.CommandLineArgs.Count
    End Sub
End Class
