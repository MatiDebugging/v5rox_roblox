Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button3.Visible = True
        Button4.Visible = False
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        MenuButton.Visible = False
        Panel1.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button9.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MenuButton.Visible = True
        Panel1.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button9.Visible = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MenuButton.Visible = True
        Panel1.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button9.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox2.Text = "" Then
            MsgBox("You have to enter a key first.", MsgBoxStyle.OkOnly, "Rox")
        Else
            MsgBox("Welcome back!", MsgBoxStyle.OkOnly, "Rox")
            Button7.Visible = False
            TextBox2.Visible = False
            Label3.Visible = False
            Label2.Visible = False
            Panel2.Visible = False
            Label1.Visible = True
            Button6.Visible = False
            Button5.Visible = False
            Panel1.Visible = False
            MenuButton.Visible = True
            Button1.Visible = True
            Button3.Visible = True
            Button8.Visible = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OpenFileDialog1.Filter = ".rplugin FILES | *.rplugin"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            MsgBox(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog1.Filter = "Executable | *.exe"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            MsgBox(OpenFileDialog1.FileName, MsgBoxStyle.OkOnly, "ROX-MENU")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
