Public Class fmHakkinda

    Private Sub frmHakkinda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = "Yazar : K.Murat BAÞEREN" & vbCrLf & vbCrLf & "...::: FreeWareSoft Copyright :::..."

        Me.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\InfoImg.jpg")
    End Sub

    Private Sub NicePanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NicePanel1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub lblSorularBaslik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSorularBaslik.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class