<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtLogIN = New Button()
        Label1 = New Label()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' txtLogIN
        ' 
        txtLogIN.Location = New Point(463, 272)
        txtLogIN.Name = "txtLogIN"
        txtLogIN.Size = New Size(112, 34)
        txtLogIN.TabIndex = 0
        txtLogIN.Text = "Log in"
        txtLogIN.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter your password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(378, 115)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtPassword)
        Controls.Add(Label1)
        Controls.Add(txtLogIN)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLogIN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
End Class
