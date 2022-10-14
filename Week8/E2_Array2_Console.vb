Public Class E2_Array2_Console
    Private Sub E2_Array2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str_array() As String = {"doggo", "nyanko", "pish"}  REM Declare a string array type

        For Each int_value As String In str_array

            Console.WriteLine(int_value)

        Next

        m(str_array)

        Dim str_array_too(2) As String

        str_array_too(0) = "parkway"
        str_array_too(1) = "l.a."
        str_array_too(2) = "gudang garam"

        For Each int_nilai As String In str_array_too

            Console.WriteLine(int_nilai)

        Next

        m(str_array_too)

    End Sub

    Sub m(ByRef any_array() As String)

        REM Looks like function that has passing value but no return value

        Console.WriteLine(any_array.Length)

    End Sub

End Class