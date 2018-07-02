Module ModuleFibonacci

    Private Function Fibonacci(ByVal n As Integer) As Integer
        Dim a As Integer = 0
        Dim b As Integer = 1

        ' Add up numbers.
        For i As Integer = 0 To n - 1
            Dim temp As Integer = a
            a = b
            b = temp + b
        Next

        Return a
    End Function

    Public Function GetFibonacci(ByVal tot As Integer) As List(Of Integer)
        Dim _result As New List(Of Integer)
        For i As Integer = 0 To tot
            _result.Add(Fibonacci(i))
        Next
        Return _result
    End Function

End Module
