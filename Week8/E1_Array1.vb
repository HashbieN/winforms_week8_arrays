Imports ModCreateArray

Public Class E1_Array1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnForm.Click

        Dim str_output As String  REM Declare an output (string)

        Dim int_i As Integer  REM Declare an integer variable

        Dim int_array As Integer()  REM Declare an array with integer type (int array)

        int_array = New Integer(9) {}  REM Create new array with size 9

        str_output &= "Subscript " & vbTab & "Value" & vbCrLf   REM Prints headers for arrays

        REM Display values in array using for loop

        For int_i = 0 To int_array.GetUpperBound(0)

            REM Prints output for every increment in array

            str_output &= int_i & vbTab & int_array(int_i) & vbCrLf

        Next

        REM Prints an overview of array in terms of array length

        str_output &= vbCrLf & "The array contains " & int_array.Length & " elements."

        MessageBox.Show(str_output, "Array of Integer Values",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtForm.TextChanged



    End Sub
End Class
