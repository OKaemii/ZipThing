Imports System
Imports System.IO
Imports System.IO.Compression
Module Module1
    Function add(ByRef a() As String, ByVal item As String)
        If a IsNot Nothing Then
            a.Resize(a, a.Length + 1)
            a(a.Length - 1) = item
        Else
            ReDim a(0)
            a(0) = item
        End If
    End Function
    Sub Main()
        Console.Title = "OKamii's fldr zippr thng!"
        Dim filepath As String = Directory.GetCurrentDirectory()
        Dim di As New IO.DirectoryInfo(filepath)
        Dim folder() As String
        'Console.WriteLine(di)
        Console.WriteLine("==============================================================================")
        Console.WriteLine("Vrsn: 0.0000001 alpha")
        Console.WriteLine("Ownr: OKamii")
        Console.WriteLine("Hw 2 use: ya plnk is exe in d fldr u wnt to zip up al thm fldrs for")
        Console.WriteLine("==============================================================================")
        Console.WriteLine("'ere b al d fldrs tht ye wnt to zip up, prss any key ya lik n it wil strt")
        For Each dir As IO.DirectoryInfo In di.GetDirectories()
            add(folder, dir.ToString)
        Next
        Console.WriteLine("==============================================================================")
        For Each i As String In folder
            Console.WriteLine(i)
        Next
        Console.WriteLine("==============================================================================")
        Console.ReadKey()
        Console.WriteLine("dun do anythng, else i'll shnk ya!!!")
        'Console.WriteLine(folder(0))
        Dim folderpath() As String
        For Each Dir As String In Directory.GetDirectories(di.ToString)
            add(folderpath, Dir)
        Next
        Try
            For i As Integer = 0 To (folder.Length - 1)
                Dim startPath As String = folderpath(i)
                Dim zipPath As String = (di.ToString + "\" + folder(i) + ".zip")
                Console.WriteLine(zipPath)
                ZipFile.CreateFromDirectory(startPath, zipPath)
            Next
        Catch ex As Exception
            Console.WriteLine("Plz del d crrnt zip so i cn mak a nw 1 fam!")
        End Try
        Console.WriteLine("==============================================================================")
        Console.WriteLine("==============================================================================")
        Console.WriteLine("iz dun m8, ya prss somet, n ima go...")
        Console.ReadKey()
    End Sub

End Module
