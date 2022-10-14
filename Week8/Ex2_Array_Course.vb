REM Assalamualaikum Sir Azlan

REM My name is Hashbie. My student ID is 20DDT20F2028.


Public Class Ex2_Array_Course
    Private Sub Ex2_Array_Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str_Message As String  REM This is a string

        Dim int_i As Integer  REM This is an integer

        Dim str_Course As String()
        Dim int_Marks As Integer()  REM This is a string + array



        str_Course = New String(6) {}

        str_Course(0) = "DFC 40243" & vbTab & "System Analysis and Design"
        str_Course(1) = "DFP 40182" & vbTab & "Software Requirement and Design"
        str_Course(2) = "DFP 40203" & vbTab & "Python Programming"
        str_Course(3) = "DFP 40233" & vbTab & "Visual Basic Programming"
        str_Course(4) = "DFP 40263" & vbTab & "Secure Mobile Computing"
        str_Course(5) = "DFT 40163" & vbTab & "Web Design Technologies"

        int_Marks = New Integer(5) {}  REM WARNING: YOU MUST GIVE ARRAY A NUMBER. IF NOT, ERROR!

        int_Marks(0) = 50
        int_Marks(1) = 25
        int_Marks(2) = 50
        int_Marks(3) = 50
        int_Marks(4) = 25
        int_Marks(5) = 50


        str_Message &= "Name: Hashbie Nazray Nazarinie bin Mohammad" & vbNewLine &
            "Student ID: 20DDT20F2028" & vbTab & "Class: DDT4A" & vbNewLine & vbNewLine

        For int_i = 0 To int_Marks.GetUpperBound(0)   REM For syntax Is For... To... Next

            If int_i = 1 Then

                str_Message &= str_Course(int_i) & vbTab & int_Marks(int_i) & " %" & vbNewLine

            Else

                REM WARNING: MUST DEFINE COUNTER i=0 TO STOP ERROR!

                str_Message &= str_Course(int_i) & vbTab & vbTab & int_Marks(int_i) & " %" & vbNewLine

                REM WARNING: DON'T FORGET NEXT, IF FORGET ERROR!

            End If

        Next

        str_Message &= vbNewLine & "Pay RM5 to remove ads. "


        MessageBox.Show(str_Message)

    End Sub
End Class