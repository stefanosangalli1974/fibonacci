Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome to Fibonacci application"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim _result As New List(Of Integer)
        _result = GetFibonacci(CType(txtN.Text, Integer))

        RichTextBox1.Clear()
        For Each _number As Integer In _result
            RichTextBox1.AppendText(String.Format("{0}{1}", _number, vbCrLf))
            RichTextBox1.ScrollToCaret()
        Next

    End Sub

End Class
