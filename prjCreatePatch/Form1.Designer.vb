<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtOldMsiPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewMsiPath = New System.Windows.Forms.TextBox()
        Me.btnChooseOldMSI = New System.Windows.Forms.Button()
        Me.btnChooseNewMSI = New System.Windows.Forms.Button()
        Me.btnCreatePatch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultPath = New System.Windows.Forms.TextBox()
        Me.btnOldImageCreate = New System.Windows.Forms.Button()
        Me.btnNewImageCreate = New System.Windows.Forms.Button()
        Me.btnEraseTmp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOldMsiPath
        '
        Me.txtOldMsiPath.Location = New System.Drawing.Point(12, 40)
        Me.txtOldMsiPath.Name = "txtOldMsiPath"
        Me.txtOldMsiPath.Size = New System.Drawing.Size(554, 23)
        Me.txtOldMsiPath.TabIndex = 0
        Me.txtOldMsiPath.Text = "C:\Temp\3\OldMSI\setup.msi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Path to old MSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Path to new MSI"
        '
        'txtNewMsiPath
        '
        Me.txtNewMsiPath.Location = New System.Drawing.Point(12, 100)
        Me.txtNewMsiPath.Name = "txtNewMsiPath"
        Me.txtNewMsiPath.Size = New System.Drawing.Size(554, 23)
        Me.txtNewMsiPath.TabIndex = 2
        Me.txtNewMsiPath.Text = "C:\Temp\3\NewMSI\setup.msi"
        '
        'btnChooseOldMSI
        '
        Me.btnChooseOldMSI.Location = New System.Drawing.Point(573, 40)
        Me.btnChooseOldMSI.Name = "btnChooseOldMSI"
        Me.btnChooseOldMSI.Size = New System.Drawing.Size(36, 23)
        Me.btnChooseOldMSI.TabIndex = 4
        Me.btnChooseOldMSI.Text = "..."
        Me.btnChooseOldMSI.UseVisualStyleBackColor = True
        '
        'btnChooseNewMSI
        '
        Me.btnChooseNewMSI.Location = New System.Drawing.Point(573, 99)
        Me.btnChooseNewMSI.Name = "btnChooseNewMSI"
        Me.btnChooseNewMSI.Size = New System.Drawing.Size(36, 23)
        Me.btnChooseNewMSI.TabIndex = 5
        Me.btnChooseNewMSI.Text = "..."
        Me.btnChooseNewMSI.UseVisualStyleBackColor = True
        '
        'btnCreatePatch
        '
        Me.btnCreatePatch.Location = New System.Drawing.Point(615, 161)
        Me.btnCreatePatch.Name = "btnCreatePatch"
        Me.btnCreatePatch.Size = New System.Drawing.Size(112, 23)
        Me.btnCreatePatch.TabIndex = 6
        Me.btnCreatePatch.Text = "Create Patch"
        Me.btnCreatePatch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(573, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Result path"
        '
        'txtResultPath
        '
        Me.txtResultPath.Location = New System.Drawing.Point(12, 161)
        Me.txtResultPath.Name = "txtResultPath"
        Me.txtResultPath.Size = New System.Drawing.Size(554, 23)
        Me.txtResultPath.TabIndex = 7
        Me.txtResultPath.Text = "C:\Temp\3\Output\"
        '
        'btnOldImageCreate
        '
        Me.btnOldImageCreate.Location = New System.Drawing.Point(615, 40)
        Me.btnOldImageCreate.Name = "btnOldImageCreate"
        Me.btnOldImageCreate.Size = New System.Drawing.Size(112, 24)
        Me.btnOldImageCreate.TabIndex = 10
        Me.btnOldImageCreate.Text = "CreateImage"
        Me.btnOldImageCreate.UseVisualStyleBackColor = True
        '
        'btnNewImageCreate
        '
        Me.btnNewImageCreate.Location = New System.Drawing.Point(615, 100)
        Me.btnNewImageCreate.Name = "btnNewImageCreate"
        Me.btnNewImageCreate.Size = New System.Drawing.Size(112, 24)
        Me.btnNewImageCreate.TabIndex = 11
        Me.btnNewImageCreate.Text = "CreateImage"
        Me.btnNewImageCreate.UseVisualStyleBackColor = True
        '
        'btnEraseTmp
        '
        Me.btnEraseTmp.Location = New System.Drawing.Point(12, 207)
        Me.btnEraseTmp.Name = "btnEraseTmp"
        Me.btnEraseTmp.Size = New System.Drawing.Size(112, 23)
        Me.btnEraseTmp.TabIndex = 12
        Me.btnEraseTmp.Text = "Erase TMP"
        Me.btnEraseTmp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 251)
        Me.Controls.Add(Me.btnEraseTmp)
        Me.Controls.Add(Me.btnNewImageCreate)
        Me.Controls.Add(Me.btnOldImageCreate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResultPath)
        Me.Controls.Add(Me.btnCreatePatch)
        Me.Controls.Add(Me.btnChooseNewMSI)
        Me.Controls.Add(Me.btnChooseOldMSI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNewMsiPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOldMsiPath)
        Me.Name = "Form1"
        Me.Text = "Create Path"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOldMsiPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewMsiPath As TextBox
    Friend WithEvents btnChooseOldMSI As Button
    Friend WithEvents btnChooseNewMSI As Button
    Friend WithEvents btnCreatePatch As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultPath As TextBox
    Friend WithEvents btnOldImageCreate As Button
    Friend WithEvents btnNewImageCreate As Button
    Friend WithEvents btnEraseTmp As Button
End Class
