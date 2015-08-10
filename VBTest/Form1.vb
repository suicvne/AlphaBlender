Imports MikeSantiago.AlphaBlender


Public Class Form1
    Dim fd As New OpenFileDialog()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Font = SystemFonts.MessageBoxFont
        fd.Filter = "Image files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"
    End Sub

    Private Sub Form1_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        MessageBox.Show("Double click the image/empty image to bring up the file chooser dialog to load your image :)" + vbNewLine + "Double click the resulting image to save it to a png.")
    End Sub

    Private Sub ImagePictureBox_DoubleClick(sender As Object, e As EventArgs) Handles ImagePictureBox.DoubleClick
        fd.Title = "Select image to load"
        If fd.ShowDialog() = DialogResult.OK Then
            Try
                ImagePictureBox.Image = Image.FromFile(fd.FileName)
                CheckForBlend()
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub MaskPictureBox_DoubleClick(sender As Object, e As EventArgs) Handles MaskPictureBox.DoubleClick
        fd.Title = "Select mask to load"
        If fd.ShowDialog() Then
            Try
                MaskPictureBox.Image = Image.FromFile(fd.FileName)
                CheckForBlend()
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub CheckForBlend()
        If ImagePictureBox.Image IsNot Nothing Then
            If MaskPictureBox.Image IsNot Nothing Then
                Dim ABP As New AlphaBlendedImage(ImagePictureBox.Image, MaskPictureBox.Image)
                CombinedPictureBox.Image = ABP.AlphaBlendSprites()
            End If
        End If
    End Sub

    Private Sub CombinedPictureBox_DoubleClick(sender As Object, e As EventArgs) Handles CombinedPictureBox.DoubleClick
        Dim sfd As New SaveFileDialog()
        sfd.Title = "Select where to save the result to."
        sfd.Filter = "Portable Network Graphic (*.png)|*.png"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                CombinedPictureBox.Image.Save(sfd.FileName, Imaging.ImageFormat.Png)
                MsgBox("Image saved!")
            Catch ex As Exception
                MsgBox("ERROR: " + ex.Message)
            End Try
        End If
    End Sub
End Class
