Public Class FormAddRecord
    Public Database As Database
    Public SelectedRow As Integer
    Public Type As String

    Private Sub FormAddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database = New Database

        'use the connection string from the text file
        Database.ConnectionString = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\connection.txt")
        'use the database table Departments
        Database.TableName = "Departments"
        'get the department names
        Database.QueryString = "Select DepartmentName FROM Departments"
        Dim Departments As Dictionary(Of Integer, String()) = Database.GetRecords()
        CbDepartment.Items.Clear()
        'add each department name to the checkbox
        For Each Department As String() In Departments.Values
            CbDepartment.Items.Add(Department.GetValue(0))
        Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'if the form has been changed
        If TbFirstname.Text <> "" And TbLastname.Text <> "" And TbExtension.Text <> "" And CbDepartment.SelectedIndex <> -1 Then

            'is the extension a number
            If IsNumeric(TbExtension.Text) Then

                'use the table Employee
                FormLab10.Database.TableName = "Employee"
                Dim values As String() = {TbFirstname.Text, TbLastname.Text, TbExtension.Text, CbDepartment.SelectedItem}

                'inserting mode?
                If Type = "Insert" Then
                    FormLab10.Database.InsertRecord({2, 1, 3, 4}, values)
                Else
                    'Updating mode?
                    FormLab10.Database.UpdateRecord(SelectedRow, {2, 1, 3, 4}, values)
                End If

                'was there an error?
                If FormLab10.Database.ErrorFlag Then
                    MsgBox(FormLab10.Database.ErrorMsg)
                End If
                LblError.Text = ""
            Else
                LblError.Text = "Extension must be numeric and 4 digits in length."
            End If
        Else
            LblError.Text = "Please ensure all fields are filled out and that you have selected a department."
        End If
        'refresh the table
        FormLab10.CreateTable()
    End Sub

    Public Sub Clear()
        'clear all textboxes
        TbFirstname.Text = ""
        TbLastname.Text = ""
        TbExtension.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Clear()
    End Sub
End Class