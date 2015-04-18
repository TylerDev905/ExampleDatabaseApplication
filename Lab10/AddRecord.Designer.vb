<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddRecord))
        Me.GpDialog = New System.Windows.Forms.GroupBox()
        Me.LblError = New System.Windows.Forms.Label()
        Me.CbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbExtension = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbLastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbFirstname = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GpDialog.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpDialog
        '
        Me.GpDialog.Controls.Add(Me.LblError)
        Me.GpDialog.Controls.Add(Me.CbDepartment)
        Me.GpDialog.Controls.Add(Me.Label4)
        Me.GpDialog.Controls.Add(Me.Label3)
        Me.GpDialog.Controls.Add(Me.TbExtension)
        Me.GpDialog.Controls.Add(Me.Label2)
        Me.GpDialog.Controls.Add(Me.TbLastname)
        Me.GpDialog.Controls.Add(Me.Label1)
        Me.GpDialog.Controls.Add(Me.TbFirstname)
        Me.GpDialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpDialog.Location = New System.Drawing.Point(12, 12)
        Me.GpDialog.Name = "GpDialog"
        Me.GpDialog.Size = New System.Drawing.Size(316, 233)
        Me.GpDialog.TabIndex = 0
        Me.GpDialog.TabStop = False
        Me.GpDialog.Text = "Add Record"
        '
        'LblError
        '
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.IndianRed
        Me.LblError.Location = New System.Drawing.Point(6, 180)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(304, 50)
        Me.LblError.TabIndex = 9
        Me.LblError.Text = " "
        Me.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbDepartment
        '
        Me.CbDepartment.FormattingEnabled = True
        Me.CbDepartment.Location = New System.Drawing.Point(132, 138)
        Me.CbDepartment.MaxLength = 4
        Me.CbDepartment.Name = "CbDepartment"
        Me.CbDepartment.Size = New System.Drawing.Size(178, 24)
        Me.CbDepartment.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Extension"
        '
        'TbExtension
        '
        Me.TbExtension.Location = New System.Drawing.Point(243, 107)
        Me.TbExtension.MaxLength = 4
        Me.TbExtension.Name = "TbExtension"
        Me.TbExtension.Size = New System.Drawing.Size(67, 22)
        Me.TbExtension.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lastname"
        '
        'TbLastname
        '
        Me.TbLastname.Location = New System.Drawing.Point(132, 79)
        Me.TbLastname.Name = "TbLastname"
        Me.TbLastname.Size = New System.Drawing.Size(178, 22)
        Me.TbLastname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Firstname"
        '
        'TbFirstname
        '
        Me.TbFirstname.Location = New System.Drawing.Point(132, 51)
        Me.TbFirstname.Name = "TbFirstname"
        Me.TbFirstname.Size = New System.Drawing.Size(178, 22)
        Me.TbFirstname.TabIndex = 0
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(12, 251)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(99, 34)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(117, 251)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(106, 34)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(229, 251)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(99, 34)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FormAddRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 297)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GpDialog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAddRecord"
        Me.Text = "Add Record"
        Me.GpDialog.ResumeLayout(False)
        Me.GpDialog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpDialog As System.Windows.Forms.GroupBox
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents CbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbExtension As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbFirstname As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
End Class
