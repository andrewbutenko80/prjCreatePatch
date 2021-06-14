Public Class Form1
    Private Conv As clConverter = New clConverter()

    Private Sub btnCreatePatch_Click(sender As Object, e As EventArgs) Handles btnCreatePatch.Click

        'Подгатавливаем выходную папку (кидаем туда *.pcp и все что связанно с msimsp)
        Conv.PrepareResultFolder()

        Conv.CreatePatch()



    End Sub

    Private Sub btnOldImageCreate_Click(sender As Object, e As EventArgs) Handles btnOldImageCreate.Click
        Conv.CreateImage(Conv.sOLDMSIPath, "OldImageCreate.bat", True)
    End Sub

    Private Sub btnNewImageCreate_Click(sender As Object, e As EventArgs) Handles btnNewImageCreate.Click
        Conv.CreateImage(Conv.sNewMSIPath, "NewImageCreate.bat", False)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conv.sNewMSIPath = txtNewMsiPath.Text
        Conv.sOLDMSIPath = txtOldMsiPath.Text
        Conv.sResultPath = txtResultPath.Text
    End Sub

    Private Sub btnEraseTmp_Click(sender As Object, e As EventArgs) Handles btnEraseTmp.Click
        Conv.EraseTmp()
    End Sub
End Class
