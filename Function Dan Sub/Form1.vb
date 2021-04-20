Public Class Form1
    Private Sub Sub1()
        lblOutput1.Text = "Welcome !"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnKlik1.Click
        Sub1()
    End Sub

    Private Sub Sub2()
        Dim strText As String
        strText = txtboxInput1.Text
        lblOutput2.Text = strText
    End Sub
    Private Sub btnKlik2_Click(sender As Object, e As EventArgs) Handles btnKlik2.Click
        Sub2()
    End Sub

    Private Function Sub3()
        Return "Welcome !"
    End Function
    Private Sub btnKlik3_Click(sender As Object, e As EventArgs) Handles btnKlik3.Click
        lblOutput3.Text = Sub3()
    End Sub

    Private Function Sub4()
        Dim strText2 As String
        strText2 = txtboxInput2.Text
        Return strText2
    End Function

    Private Sub btnKlik4_Click(sender As Object, e As EventArgs) Handles btnKlik4.Click
        lblOutput4.Text = Sub4()
    End Sub
End Class
