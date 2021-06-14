Imports System.IO
Imports System.Threading

Public Class clConverter

    Public sNewMSIPath As String = ""
    Public sOLDMSIPath As String = ""
    Public sResultPath As String = ""



    Sub New()

    End Sub


    Sub PrepareResultFolder()
        Dim di As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "..\..\..\Tools\")

        My.Computer.FileSystem.CopyFile(di.FullName & "patch.pcp", sResultPath & "patch.pcp", overwrite:=True)
        My.Computer.FileSystem.CopyFile(di.FullName & "MsiMsp.exe", sResultPath & "MsiMsp.exe", overwrite:=True)
        My.Computer.FileSystem.CopyFile(di.FullName & "patchwiz.dll", sResultPath & "patchwiz.dll", overwrite:=True)



        'Создаем папку Patch
        Dim diRP As DirectoryInfo = New DirectoryInfo(sResultPath)
        Dim folder As String = diRP.FullName & "\Patch\"
        Directory.CreateDirectory(folder)

    End Sub

    Function CreateImageFolder(isOld As Boolean) As String
        Dim folder As String

        If isOld Then
            folder = sResultPath & "\" & "TargetImage"
        Else
            folder = sResultPath & "\" & "UpgradedImage"
        End If

        Directory.CreateDirectory(folder)
        Return folder

    End Function

    Function CreateBatFile(PathToMSI As String, FileName As String, Comand As String) As String

        Dim fi As FileInfo = New FileInfo(PathToMSI)
        Dim folder = fi.Directory().FullName
        Dim FilePath As String = folder & "\" & FileName
        File.Create(FilePath).Dispose()

        Dim objWriter As New StreamWriter(FilePath)

        objWriter.WriteLine(Comand & vbCrLf)

        objWriter.Close()

        Return FilePath

    End Function


    Sub CreateImages()
        CreateImage(sOLDMSIPath, "OldImageCreate.bat", True)

        CreateImage(sNewMSIPath, "NewImageCreate.bat", False)

    End Sub

    Sub CreateImage(sMSIPath As String, sBatFileName As String, isOld As Boolean)

        'msiexec /qb /a C:\Temp\2\setup.msi TARGETDIR=C:\Temp\2\Image 

        Dim sMsiImageCreate As String

        'Создаем команду создания имеджа старой инсталляции
        sMsiImageCreate = "msiexec /qb /a " & sMSIPath & " TARGETDIR=" & CreateImageFolder(isOld)
        'Создаем батник с командой на создания имеджа
        Dim sFullBatFileName As String = CreateBatFile(sMSIPath, sBatFileName, sMsiImageCreate)

        'Запускаем  батник 
        Process.Start(sFullBatFileName)


    End Sub

    Sub CreatePatch()
        Dim com0 As String = "chdir " & sResultPath
        Dim com1 As String = "msimsp -s patch.pcp -p Patch\patch.msp -l Patch\patch.log -f Patch\Tmp -d"
        Dim com As String = com0 & vbCrLf & com1

        Dim sPatchBatFileName As String = CreateBatFile(sResultPath, "CreatePatch.bat", com)



        Process.Start("explorer.exe", sResultPath & "CreatePatch.bat")


    End Sub

    Sub DelFile(FileName As String)
        If File.Exists(FileName) Then
            My.Computer.FileSystem.DeleteFile(FileName)
        End If

    End Sub

    Sub EraseTmp()


        Dim x As Integer
        Dim paths() As String = IO.Directory.GetFiles(sResultPath)
        If paths.Length > 0 Then
            For x = 0 To paths.Length - 1
                IO.File.Delete(paths(x))
            Next
        End If

        Dim pathsDir() As String = IO.Directory.GetDirectories(sResultPath)
        If pathsDir.Length > 0 Then
            For x = 0 To pathsDir.Length - 1
                If pathsDir(x) <> sResultPath & "Patch" Then
                    Directory.Delete(pathsDir(x), True)
                End If
            Next
        End If

        Dim sTMPDir As String = sResultPath & "Patch\TMP"
        If Directory.Exists(sTMPDir) Then
            Directory.Delete(sTMPDir, True)
        End If

        MessageBox.Show("Successful!", "TMP data is erased!")

    End Sub
End Class
