<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E1_Array1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnForm = New System.Windows.Forms.Button()
        Me.txtForm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnForm
        '
        Me.btnForm.Location = New System.Drawing.Point(713, 361)
        Me.btnForm.Name = "btnForm"
        Me.btnForm.Size = New System.Drawing.Size(75, 23)
        Me.btnForm.TabIndex = 0
        Me.btnForm.Text = "Button1"
        Me.btnForm.UseVisualStyleBackColor = True
        '
        'txtForm
        '
        Me.txtForm.Location = New System.Drawing.Point(13, 13)
        Me.txtForm.Multiline = True
        Me.txtForm.Name = "txtForm"
        Me.txtForm.Size = New System.Drawing.Size(210, 371)
        Me.txtForm.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtForm)
        Me.Controls.Add(Me.btnForm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnForm As Button
    Friend WithEvents txtForm As TextBox
End Class
