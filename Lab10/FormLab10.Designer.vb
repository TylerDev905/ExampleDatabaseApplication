<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLab10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLab10))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.IdSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbId = New System.Windows.Forms.ToolStripTextBox()
        Me.DatabaseTable = New Lab10.TableView()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.HelpToolStripMenuItem, Me.SortToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(665, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecordToolStripMenuItem, Me.UpdateRecordToolStripMenuItem, Me.DeleteRecordToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ManageToolStripMenuItem.Text = "Records"
        '
        'AddRecordToolStripMenuItem
        '
        Me.AddRecordToolStripMenuItem.Image = CType(resources.GetObject("AddRecordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem"
        Me.AddRecordToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddRecordToolStripMenuItem.Text = "Add Record"
        '
        'UpdateRecordToolStripMenuItem
        '
        Me.UpdateRecordToolStripMenuItem.Image = CType(resources.GetObject("UpdateRecordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateRecordToolStripMenuItem.Name = "UpdateRecordToolStripMenuItem"
        Me.UpdateRecordToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateRecordToolStripMenuItem.Text = "Update Record"
        '
        'DeleteRecordToolStripMenuItem
        '
        Me.DeleteRecordToolStripMenuItem.Image = CType(resources.GetObject("DeleteRecordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem"
        Me.DeleteRecordToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteRecordToolStripMenuItem.Text = "Delete Records"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.HighlightToolStripMenuItem, Me.AuthorToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.HelpToolStripMenuItem.Text = "Application"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'HighlightToolStripMenuItem
        '
        Me.HighlightToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColumnToolStripMenuItem, Me.RowsToolStripMenuItem})
        Me.HighlightToolStripMenuItem.Image = CType(resources.GetObject("HighlightToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HighlightToolStripMenuItem.Name = "HighlightToolStripMenuItem"
        Me.HighlightToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.HighlightToolStripMenuItem.Text = "Highlight"
        '
        'ColumnToolStripMenuItem
        '
        Me.ColumnToolStripMenuItem.Name = "ColumnToolStripMenuItem"
        Me.ColumnToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ColumnToolStripMenuItem.Text = "Columns"
        '
        'RowsToolStripMenuItem
        '
        Me.RowsToolStripMenuItem.Checked = True
        Me.RowsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RowsToolStripMenuItem.Name = "RowsToolStripMenuItem"
        Me.RowsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RowsToolStripMenuItem.Text = "Rows"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Image = CType(resources.GetObject("AuthorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AuthorToolStripMenuItem.Text = "Author"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdToolStripMenuItem, Me.FirstnameToolStripMenuItem, Me.LastnameToolStripMenuItem, Me.ExtensionToolStripMenuItem, Me.DepartmentToolStripMenuItem})
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'IdToolStripMenuItem
        '
        Me.IdToolStripMenuItem.Checked = True
        Me.IdToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IdToolStripMenuItem.Name = "IdToolStripMenuItem"
        Me.IdToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.IdToolStripMenuItem.Text = "EmployeeId"
        '
        'FirstnameToolStripMenuItem
        '
        Me.FirstnameToolStripMenuItem.Name = "FirstnameToolStripMenuItem"
        Me.FirstnameToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.FirstnameToolStripMenuItem.Text = "Firstname"
        '
        'LastnameToolStripMenuItem
        '
        Me.LastnameToolStripMenuItem.Name = "LastnameToolStripMenuItem"
        Me.LastnameToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.LastnameToolStripMenuItem.Text = "Lastname"
        '
        'ExtensionToolStripMenuItem
        '
        Me.ExtensionToolStripMenuItem.Name = "ExtensionToolStripMenuItem"
        Me.ExtensionToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExtensionToolStripMenuItem.Text = "Extension"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 328)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(665, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdSearchToolStripMenuItem, Me.TbId})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'IdSearchToolStripMenuItem
        '
        Me.IdSearchToolStripMenuItem.Name = "IdSearchToolStripMenuItem"
        Me.IdSearchToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.IdSearchToolStripMenuItem.Text = "Id Search"
        '
        'TbId
        '
        Me.TbId.MaxLength = 5
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 23)
        '
        'DatabaseTable
        '
        Me.DatabaseTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatabaseTable.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.DatabaseTable.FullRowSelect = True
        Me.DatabaseTable.GridLines = True
        Me.DatabaseTable.Location = New System.Drawing.Point(0, 24)
        Me.DatabaseTable.Margin = New System.Windows.Forms.Padding(2)
        Me.DatabaseTable.Name = "DatabaseTable"
        Me.DatabaseTable.Size = New System.Drawing.Size(665, 326)
        Me.DatabaseTable.TabIndex = 1
        Me.DatabaseTable.UseCompatibleStateImageBehavior = False
        Me.DatabaseTable.View = System.Windows.Forms.View.Details
        '
        'FormLab10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 350)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DatabaseTable)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormLab10"
        Me.Text = "Phonebook - William.Taylor-Holubeshen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseTable As Lab10.TableView
    Friend WithEvents SortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirstnameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LastnameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtensionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighlightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents IdSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbId As System.Windows.Forms.ToolStripTextBox

End Class
