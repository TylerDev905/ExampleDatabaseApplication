Public Class FormLab10

    'Public DatabaseTable As TableView
    Public Database As Database

    Private Sub FormLab10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Try
        'Create new database instance
        Database = New Database

        Database.ConnectionString = ".\SQLEXPRESS;Database=Master;Trusted_Connection=true;"
        Database.ExecuteSqlFile("")

        'use the connection.txt file for the connection string
        Database.ConnectionString = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\connection.txt")

        'set the default order to employeeId
        Database.Order = "EmployeeId"

        'create the database table
        CreateTable()


        ' Catch ex As Exception
        ' MsgBox("Please check the connection is correct in the connection file or Reinstall the database.")
        'End Try

    End Sub

    Public Sub CreateTable()
        'Clear the database table
        DatabaseTable.Clear()

        'use the table Employee and get the table data
        Database.TableName = "Employee"
        Database.GetTable()
        Database.GetPrimaryKeys()

        'creates the table structure
        DatabaseTable.CreateColumnHeaders(Database.ColumnNames)
        For Each Row As String() In Database.Records.Values
            DatabaseTable.CreateRow(Row)
        Next

        'turn checkboxes on
        DatabaseTable.CheckBoxes = True
        RowsToolStripMenuItem.Checked = True
        ColumnToolStripMenuItem.Checked = False

        'highlight alternating rows then resize the columns to the header size
        DatabaseTable.HighlightAlernatingRows(Color.Crimson, Color.LightSkyBlue, Color.White, Color.Black)
        DatabaseTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click
        'Update the formAddRecord with the proper default strings
        FormAddRecord.Text = "Add Record"
        FormAddRecord.GpDialog.Text = "Add Record"
        FormAddRecord.Type = "Insert"
        FormAddRecord.TbLastname.Text = ""
        FormAddRecord.TbFirstname.Text = ""
        FormAddRecord.TbExtension.Text = ""
        FormAddRecord.CbDepartment.Text = ""
        FormAddRecord.LblError.Text = ""

        'display form
        FormAddRecord.ShowDialog()
    End Sub

    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click

        'get all checked items and delete them
        If DatabaseTable.CheckedItems.Count <> -1 Then
            For Each item As ListViewItem In DatabaseTable.CheckedItems
                Database.DeleteRecord(item.Index)
                If Database.ErrorFlag Then
                    MsgBox(Database.ErrorMsg)
                End If
            Next
            'refresh table
            CreateTable()
        Else
            MsgBox("Please check the items you wish to delete.")
        End If
    End Sub

    Private Sub UpdateRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRecordToolStripMenuItem.Click

        'update the addRecord form to use update default strings
        If DatabaseTable.SelectedIndices.Count = 1 Then
            FormAddRecord.Text = "Update Record"
            FormAddRecord.GpDialog.Text = "Update Record"
            FormAddRecord.Type = "Update"
            FormAddRecord.LblError.Text = ""
            Dim Row As String() = Database.Records(DatabaseTable.SelectedIndices.Item(0))

            'form memory
            FormAddRecord.TbLastname.Text = Row(1)
            FormAddRecord.TbFirstname.Text = Row(2)
            FormAddRecord.TbExtension.Text = Row(3)
            FormAddRecord.CbDepartment.Text = Row(4)
            FormAddRecord.SelectedRow = DatabaseTable.SelectedIndices.Item(0)
            FormAddRecord.ShowDialog()
        Else
            MsgBox("Please select an item from the list.")
        End If
    End Sub

    Private Sub IdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdToolStripMenuItem.Click
        'set order for sorting
        Database.Order = "EmployeeId"
        'toggle Menu item
        toggleMenuItem(IdToolStripMenuItem, SortToolStripMenuItem, True)
    End Sub

    Private Sub FirstnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirstnameToolStripMenuItem.Click
        'set order for sorting
        Database.Order = "Firstname"
        'toggle Menu item
        toggleMenuItem(FirstnameToolStripMenuItem, SortToolStripMenuItem, True)
    End Sub

    Private Sub LastnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LastnameToolStripMenuItem.Click
        'set order for sorting
        Database.Order = "Lastname"
        'toggle Menu item
        toggleMenuItem(LastnameToolStripMenuItem, SortToolStripMenuItem, True)
    End Sub

    Private Sub ExtensionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtensionToolStripMenuItem.Click
        'set order for sorting
        Database.Order = "Extension"
        'toggle Menu item
        toggleMenuItem(ExtensionToolStripMenuItem, SortToolStripMenuItem, True)
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        'set order for sorting
        Database.Order = "Department"
        'toggle Menu item
        toggleMenuItem(DepartmentToolStripMenuItem, SortToolStripMenuItem, True)
    End Sub

    Public Sub toggleMenuItem(Selected As ToolStripMenuItem, Items As ToolStripMenuItem, Refresh As Boolean)
        Dim OldItem As Boolean = Selected.Checked

        'set all items to false
        For Each Item As ToolStripMenuItem In Items.DropDownItems
            Item.Checked = False
        Next

        'set the old item to false
        If OldItem Then
            Selected.Checked = False
        Else

            'refresh
            If Refresh Then
                CreateTable()
            End If
            'set the item to true
            Selected.Checked = True
        End If
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorToolStripMenuItem.Click
        'display author information
        MsgBox(" I William Taylor-Holubeshen, 000305063 certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        'refresh table
        CreateTable()
    End Sub

    Private Sub RowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RowsToolStripMenuItem.Click
        'switch highlight style
        DatabaseTable.HighlightAlernatingRows(Color.Crimson, Color.LightSkyBlue, Color.White, Color.Black)
        toggleMenuItem(RowsToolStripMenuItem, HighlightToolStripMenuItem, False)
    End Sub

    Private Sub ColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnToolStripMenuItem.Click
        'switch highlight style
        DatabaseTable.HighlightAlernatingColumns(Color.Crimson, Color.LightSkyBlue, Color.White, Color.Black)
        toggleMenuItem(ColumnToolStripMenuItem, HighlightToolStripMenuItem, False)
    End Sub

    Private Sub IdSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdSearchToolStripMenuItem.Click
        If (IsNumeric(TbId.Text) Or TbId.Text <> "") Then
            If TbId.Text <= Database.Records.Count Then
                Dim Num As Integer = TbId.Text - 1
                DatabaseTable.Clear()
                DatabaseTable.CreateColumnHeaders(Database.ColumnNames)
                DatabaseTable.CreateRow(Database.Records(Num))
                DatabaseTable.HighlightAlernatingRows(Color.Crimson, Color.LightSkyBlue, Color.White, Color.Black)
            End If
        End If
    End Sub
End Class
