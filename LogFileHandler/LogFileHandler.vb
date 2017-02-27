'Jeffrey Martin
'Project 1 Log File Handler
'CIS 212
'2/27/2017

'******************************Maintance Notes*********************************
'This library can be easily updated to support writing to addition file types. To add  
'another file type add the file type to the Enum FileType list (located in Variables),
'to the Select Case (located in constructor), and to the Select Case (located in 
'WriteToLog subroutine). An additional subroutine may be needed to be written if the
'ones currently in the Private Subroutines region will not support the new file type.

#Region "NAMESPACES"

Imports System.IO

#End Region 'END NAMESPACES

''' <summary>
''' Library for a Log File Handler
''' </summary>
Public Class LogFileHandler

#Region "VARIABLES"

    '*****************Enum Varables*******************

    'Hold the file types that the log file can handle
    Enum FileType
        CSV
        SQLServerDatabase
    End Enum

    '*****************Backing Fields*******************

    'Holds the combined path and name of the file to be written to.
    Private _filePathName As String
    'Holds the data type of file to be written to. 
    Private _fileTypeChosen As FileType

    '*****************Constants************************

    'Holds the path of the file to be written to.
    Private Const FILE_PATH As String = ""
    Private Const DEFAULT_FILE_NAME As String = "logfile.csv"


#End Region ' END VARIABLES

#Region "CONSTRUCTORS"

    ''' <summary>
    ''' LogFileHandler requires a file name to be instantiated. 
    ''' </summary>
    ''' <param name="fileName">String</param>
    Public Sub New(ByVal fileName As String)

        'Validate fileName and if not a valid file name use the default file name.
        If Not (IsValidFileName(fileName)) Then
            fileName = DEFAULT_FILE_NAME
        End If

        'Combine the file path with the file name into a single variable.
        _filePathName = FILE_PATH + fileName

        'Pull out the file extension.
        Dim splitFileName() As String = Split(fileName, ".")

        'Check what type of file extesnion exist and Assign the type to the _fileTypeChosen variable.
        'Unknown types default to a csv file. While it is redundant to have a case for csv and the 
        'default to be csv, it is done so that the default can be changed  to any file type without 
        'having to worry about adding csv as a case. 
        Select Case splitFileName(1).Trim

            Case "csv"
                _fileTypeChosen = FileType.CSV

            Case "mdf"
                _fileTypeChosen = FileType.SQLServerDatabase

            Case Else
                _fileTypeChosen = FileType.CSV

        End Select

    End Sub

#End Region 'END CONSTRUCTORS

#Region "PUBLIC SUBROUTINES"

    ''' <summary>
    ''' Calls the appropriate subroutine that will handle the interface for the file type.
    ''' </summary>
    ''' <param name="textualKey">String</param>
    ''' <param name="loggedMessage">String</param>
    Public Function WriteToLog(ByVal textualKey As String, ByVal loggedMessage As String) As String

        'String to hole error message to be returned by function.  If not overwritten with a pass error
        'message will be returned.
        Dim errorString As String = "Error Not Processed"

        'Check the value assigned to _fileTypeChosen at instantiation then call the approptirate subroutine.
        'Note that any formating of the data should be done here (inside each case) so that the method called 
        'only has to handle the input and output of the data. This increases reusabilty to the methods called.
        Select Case _fileTypeChosen

            Case FileType.CSV
                'Format the data into a single string for appending to a text file.
                Dim outputString As String = textualKey + "," + New DateTime().ToString() + "," + loggedMessage
                errorString = WriteToTextFile(outputString)

            Case FileType.SQLServerDatabase
                'Format the data into the three fields that will be used in the database.
                errorString = WriteToSQLServerDatabase(textualKey, New DateTime(), loggedMessage)

        End Select

        Return errorString

    End Function

#End Region 'END PUBLIC SUBROUTINES

#Region "PRIVATE FUNCTIONS"

    ''' <summary>
    ''' Validates the characters in the string passed in and returns true if they string contains characters
    ''' that can be used as a filename.
    ''' </summary>
    ''' <param name="nameTest">String</param>
    ''' <returns>Boolean</returns>
    Private Function IsValidFileName(ByVal nameTest As String) As Boolean

        'Create a boolean and set to true to be used on return if the passed in string is valid.
        'Note this is used to maintain the one entrance and exit rule of a function/subroutine. The
        'method would run more efficently if "Return False" was used at each place "returnedBool = False"
        'was used and "Return True" was used at then end of the function instead of "Return returnedBool."
        Dim returnedBool As Boolean = True

        'Check if there is nothing in nameTest, if so than it is not a valid name.
        If nameTest Is Nothing Then
            returnedBool = False

        Else
            'Loop through all the possible bad character types
            For Each badChar As Char In Path.GetInvalidPathChars

                'Check to see if the bad chacter is in the passed in string, and if so than it is not
                'a valid name.
                If InStr(nameTest, badChar) > 0 Then
                    returnedBool = False
                End If

            Next

        End If

        Return returnedBool

    End Function

    ''' <summary>
    ''' Function to create a new file and add the passed in string to it or 
    ''' to append the string to the file if it allready exists. Returns error
    ''' message if generated.
    ''' </summary>
    ''' <param name="outputString">String</param>
    Private Function WriteToTextFile(ByVal outputString As String) As String

        'String to hold error message. Passed unless error occors.
        Dim errorString As String = "Passed"

        'Create a variable that will hold the StreamWrite. Empty due to how it will be constructed
        'based upon if there is a file that allready exist or not.
        Dim streamWriter As StreamWriter = Nothing

        Try

            'If the file to be written to exist than open the file to be appeneded.
            If My.Computer.FileSystem.FileExists(_filePathName) Then
                streamWriter = New StreamWriter(_filePathName, True)

                'If the file to written to does not exist than create it and open it.
            Else
                streamWriter = New StreamWriter(_filePathName, False)
            End If

            'Write the output string to the end of the file.
            streamWriter.WriteLine(outputString)

        Catch ex As Exception

            'Change the errorString to include an error message as the write failed.
            errorString = "Error writing to File, Contact Adminstrator." + Environment.NewLine() + ex.ToString()

        Finally

            'If the streamWriter has been opened, close it.
            If streamWriter IsNot Nothing Then
                streamWriter.Close()
            End If

        End Try

        Return errorString

    End Function

    Private Function WriteToSQLServerDatabase(ByVal textualKey As String, ByVal dateTime As DateTime, ByVal loggedMessage As String) As String

        Dim errorString As String = "Error WriteToSQLServerDatabase function has not been written." +
                                    Environment.NewLine + "Contact Adminstrator."

        'Not written per project instructions.

        Return errorString

    End Function

#End Region 'END PRIVATE FUNCTIONS

End Class
