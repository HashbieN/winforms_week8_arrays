Public Class Ex1_Array_Listbox

    Private Sub Ex1_Array_Listbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strMessage As String  REM Declare "message" as String 

        Dim intCount As Integer  REM Declare "count" as Integer

        Dim strDdt4a As String()  REM Declare "DDT4A" as String and Array

        REM WARNING: The following line will cause an error if omitted!

        strDdt4a = New String(13) {}  REM Define "DDT4A" with Array size 13

        strDdt4a(0) = "Hashbie"
        strDdt4a(1) = "Alan"
        strDdt4a(2) = "Roslan"
        strDdt4a(3) = "John"
        strDdt4a(4) = "Muhaimin"
        strDdt4a(5) = "Dickson"
        strDdt4a(6) = "Safwan"
        strDdt4a(7) = "Rasyid"
        strDdt4a(8) = "Crystal"
        strDdt4a(9) = "Faustine"
        strDdt4a(10) = "Intan"
        strDdt4a(11) = "Hidayatul"
        strDdt4a(12) = "Shahdayana"
        strDdt4a(13) = "Aiyani"

        Array.Sort(strDdt4a)

        strMessage &= "Line" & vbTab & "Student" & vbNewLine

        For intCount = 0 To strDdt4a.GetUpperBound(0)

            strMessage &= intCount & vbTab & strDdt4a(intCount) & vbNewLine

        Next

        MessageBox.Show(strMessage, "Students of DDT4A", MessageBoxButtons.OK)

    End Sub

End Class