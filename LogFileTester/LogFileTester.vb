




Public Class LogFileTester
    Enum FileType
        CSV
        SQLServerDatabase
    End Enum

    'Holds the data type of file to be written to. 
    Private _fileTypeChosen As FileType
    Private _fileName As String = ""

    Private _logFileHandler As LogFileHandler.LogFileHandler

    Private Const CSV As String = "Comma Seperated File"
    Private Const CSV_FILE As String = "testCSVLog.csv"
    Private Const SQL_SERVER As String = "SQL Server"
    Private Const SQL_SERVER_File As String = "testSQLServerLog.mdf"

    Private csvProcessor As CSVProcessor = New CSVProcessor()



    Private Sub LogFileTester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Log File Tester"
        FileTypeGroupBox.Text = "Choose File Type to Test"
        FileTypeRadioButton1.Text = CSV
        FileTypeRadioButton2.Text = SQL_SERVER
        RadioButtonInfoLabel.Text = ""
        AddMockDataButton.Text = "Add Mock Data to File"
        DeleteFileButton.Text = "Delete File"
        ClearResultsButton.Text = "Clear Results Label"
        ReadFileButtonButton.Text = "Read File into Results Label"
        ResultsLabel.Text = ""

    End Sub

    Private Sub FileTypeRadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles FileTypeRadioButton1.CheckedChanged, FileTypeRadioButton2.CheckedChanged

        Dim checkedRadioButton As RadioButton = sender

        Select Case checkedRadioButton.Text
            Case CSV
                RadioButtonInfoLabel.Text = "File Name: " + CSV_FILE
                _logFileHandler = New LogFileHandler.LogFileHandler(CSV_FILE)
            Case SQL_SERVER
                RadioButtonInfoLabel.Text = "File Name: " + SQL_SERVER_File
                _logFileHandler = New LogFileHandler.LogFileHandler(SQL_SERVER_File)
        End Select

        ResultsLabel.Text = ""

    End Sub

    Private Sub AddMockDataButton_Click(sender As Object, e As EventArgs) Handles AddMockDataButton.Click

        Dim errorResults As String = "Error Results" + Environment.NewLine()

        For index As Integer = 1 To 10
            errorResults = _logFileHandler.WriteToLog("Test_Data", "Log Event " + index.ToString())

            ResultsLabel.Text += "Error Result for write to log " + index.ToString() + ": " + errorResults + Environment.NewLine()

        Next

    End Sub

    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click
        ResultsLabel.Text = ""
    End Sub

    Private Sub DeleteFileButton_Click(sender As Object, e As EventArgs) Handles DeleteFileButton.Click
        ResultsLabel.Text = csvProcessor.DeleteFile(CSV_FILE)
    End Sub

    Private Sub ReadFileButtonButton_Click(sender As Object, e As EventArgs) Handles ReadFileButtonButton.Click
        ResultsLabel.Text = csvProcessor.ReadFile(CSV_FILE)
    End Sub
End Class
