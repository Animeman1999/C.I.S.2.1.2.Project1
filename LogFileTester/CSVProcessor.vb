
Imports System.IO

Public Class CSVProcessor

    Public Function ReadFile(ByVal fileName As String) As String

        Dim inputString As String

        Try
            If My.Computer.FileSystem.FileExists(fileName) Then
                inputString = My.Computer.FileSystem.ReadAllText(fileName)
            Else
                inputString = fileName + " is not present, so can not read."
            End If


        Catch ex As Exception
            inputString = "Error Reading File, Contact Adminstrator." + Environment.NewLine() + ex.ToString()

        End Try

        Return inputString
    End Function

    Public Function DeleteFile(ByVal fileName As String) As String

        Dim errorString As String = "Error " + fileName + " not deleted, Contact Administrator"

        Try
            If My.Computer.FileSystem.FileExists(fileName) Then
                My.Computer.FileSystem.DeleteFile(fileName)
                errorString = fileName + " was deleted."
            Else
                errorString = fileName + " was not present so no need to delete."
            End If

        Catch ex As Exception
            errorString = "Error " + fileName + " not deleted, Contact Administrator" +
                          Environment.NewLine() + ex.ToString()
        End Try

        Return errorString
    End Function
End Class
