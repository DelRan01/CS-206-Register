<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StdIdLabel As System.Windows.Forms.Label
        Dim FnameLabel As System.Windows.Forms.Label
        Dim LnameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim SchlrshpLabel As System.Windows.Forms.Label
        Dim TuipaidLabel As System.Windows.Forms.Label
        Dim PrevcredsLabel As System.Windows.Forms.Label
        Dim GpaLabel As System.Windows.Forms.Label
        Dim MomnameLabel As System.Windows.Forms.Label
        Dim DadnameLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.RegisterDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterSet = New Register.RegisterSet()
        Me.StdIdTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SchlrshpCheckBox = New System.Windows.Forms.CheckBox()
        Me.TuipaidCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrevcredsTextBox = New System.Windows.Forms.TextBox()
        Me.GpaTextBox = New System.Windows.Forms.TextBox()
        Me.MomnameTextBox = New System.Windows.Forms.TextBox()
        Me.DadnameTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CounterLBL = New System.Windows.Forms.Label()
        Me.TitleLBL = New System.Windows.Forms.Label()
        Me.fnameSEARCHBAR = New System.Windows.Forms.TextBox()
        Me.SearchLBL = New System.Windows.Forms.Label()
        Me.RegisterTableAdapter = New Register.RegisterSetTableAdapters.RegisterTableAdapter()
        Me.TableAdapterManager = New Register.RegisterSetTableAdapters.TableAdapterManager()
        Me.TeachMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenNewUserFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.BackBTN = New System.Windows.Forms.Button()
        Me.LastBTN = New System.Windows.Forms.Button()
        Me.NextBTN = New System.Windows.Forms.Button()
        Me.PreviousBTN = New System.Windows.Forms.Button()
        Me.FirstBTN = New System.Windows.Forms.Button()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.DeleteBTN = New System.Windows.Forms.Button()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.PrintDialogReg = New System.Windows.Forms.PrintDialog()
        Me.PrintDocumentReg = New System.Drawing.Printing.PrintDocument()
        StdIdLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        LnameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        SchlrshpLabel = New System.Windows.Forms.Label()
        TuipaidLabel = New System.Windows.Forms.Label()
        PrevcredsLabel = New System.Windows.Forms.Label()
        GpaLabel = New System.Windows.Forms.Label()
        MomnameLabel = New System.Windows.Forms.Label()
        DadnameLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.RegisterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeachMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StdIdLabel
        '
        StdIdLabel.AutoSize = True
        StdIdLabel.BackColor = System.Drawing.Color.White
        StdIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StdIdLabel.Location = New System.Drawing.Point(8, 108)
        StdIdLabel.Name = "StdIdLabel"
        StdIdLabel.Size = New System.Drawing.Size(68, 13)
        StdIdLabel.TabIndex = 2
        StdIdLabel.Text = "Student Id:   "
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.BackColor = System.Drawing.Color.White
        FnameLabel.Location = New System.Drawing.Point(8, 134)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(69, 13)
        FnameLabel.TabIndex = 4
        FnameLabel.Text = "First Name:   "
        '
        'LnameLabel
        '
        LnameLabel.AutoSize = True
        LnameLabel.BackColor = System.Drawing.Color.White
        LnameLabel.Location = New System.Drawing.Point(8, 160)
        LnameLabel.Name = "LnameLabel"
        LnameLabel.Size = New System.Drawing.Size(70, 13)
        LnameLabel.TabIndex = 6
        LnameLabel.Text = "Last Name:   "
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.White
        AgeLabel.Location = New System.Drawing.Point(8, 186)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(69, 13)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Student Age:"
        '
        'SchlrshpLabel
        '
        SchlrshpLabel.AutoSize = True
        SchlrshpLabel.BackColor = System.Drawing.Color.White
        SchlrshpLabel.Location = New System.Drawing.Point(602, 105)
        SchlrshpLabel.Name = "SchlrshpLabel"
        SchlrshpLabel.Size = New System.Drawing.Size(164, 13)
        SchlrshpLabel.TabIndex = 10
        SchlrshpLabel.Text = "Is the student on a Schollarship?:"
        '
        'TuipaidLabel
        '
        TuipaidLabel.AutoSize = True
        TuipaidLabel.BackColor = System.Drawing.Color.White
        TuipaidLabel.Location = New System.Drawing.Point(602, 126)
        TuipaidLabel.Name = "TuipaidLabel"
        TuipaidLabel.Size = New System.Drawing.Size(165, 13)
        TuipaidLabel.TabIndex = 12
        TuipaidLabel.Text = "Is the students Tuition Paid?:       "
        '
        'PrevcredsLabel
        '
        PrevcredsLabel.AutoSize = True
        PrevcredsLabel.BackColor = System.Drawing.Color.White
        PrevcredsLabel.Location = New System.Drawing.Point(296, 108)
        PrevcredsLabel.Name = "PrevcredsLabel"
        PrevcredsLabel.Size = New System.Drawing.Size(86, 13)
        PrevcredsLabel.TabIndex = 14
        PrevcredsLabel.Text = "Previous Credits:"
        '
        'GpaLabel
        '
        GpaLabel.AutoSize = True
        GpaLabel.BackColor = System.Drawing.Color.White
        GpaLabel.Location = New System.Drawing.Point(296, 134)
        GpaLabel.Name = "GpaLabel"
        GpaLabel.Size = New System.Drawing.Size(87, 13)
        GpaLabel.TabIndex = 16
        GpaLabel.Text = "Student GPA:     "
        '
        'MomnameLabel
        '
        MomnameLabel.AutoSize = True
        MomnameLabel.BackColor = System.Drawing.Color.White
        MomnameLabel.Location = New System.Drawing.Point(296, 160)
        MomnameLabel.Name = "MomnameLabel"
        MomnameLabel.Size = New System.Drawing.Size(88, 13)
        MomnameLabel.TabIndex = 18
        MomnameLabel.Text = "Mothers Name:   "
        '
        'DadnameLabel
        '
        DadnameLabel.AutoSize = True
        DadnameLabel.BackColor = System.Drawing.Color.White
        DadnameLabel.Location = New System.Drawing.Point(296, 186)
        DadnameLabel.Name = "DadnameLabel"
        DadnameLabel.Size = New System.Drawing.Size(88, 13)
        DadnameLabel.TabIndex = 20
        DadnameLabel.Text = "Fathers Name:    "
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.Color.White
        DateLabel.Location = New System.Drawing.Point(602, 157)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(158, 13)
        DateLabel.TabIndex = 22
        DateLabel.Text = "Date the student Registered:     "
        '
        'RegisterDataGridView
        '
        Me.RegisterDataGridView.AutoGenerateColumns = False
        Me.RegisterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegisterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.RegisterDataGridView.DataSource = Me.RegisterBindingSource
        Me.RegisterDataGridView.Location = New System.Drawing.Point(12, 325)
        Me.RegisterDataGridView.Name = "RegisterDataGridView"
        Me.RegisterDataGridView.Size = New System.Drawing.Size(822, 220)
        Me.RegisterDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "stdId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "stdId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "lname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "schlrshp"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "schlrshp"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "tuipaid"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "tuipaid"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "prevcreds"
        Me.DataGridViewTextBoxColumn5.HeaderText = "prevcreds"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "gpa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "gpa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "momname"
        Me.DataGridViewTextBoxColumn7.HeaderText = "momname"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "dadname"
        Me.DataGridViewTextBoxColumn8.HeaderText = "dadname"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'RegisterBindingSource
        '
        Me.RegisterBindingSource.DataMember = "Register"
        Me.RegisterBindingSource.DataSource = Me.RegisterSet
        '
        'RegisterSet
        '
        Me.RegisterSet.DataSetName = "RegisterSet"
        Me.RegisterSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StdIdTextBox
        '
        Me.StdIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "stdId", True))
        Me.StdIdTextBox.Location = New System.Drawing.Point(84, 105)
        Me.StdIdTextBox.Name = "StdIdTextBox"
        Me.StdIdTextBox.Size = New System.Drawing.Size(135, 20)
        Me.StdIdTextBox.TabIndex = 3
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(84, 131)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.FnameTextBox.TabIndex = 5
        '
        'LnameTextBox
        '
        Me.LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "lname", True))
        Me.LnameTextBox.Location = New System.Drawing.Point(84, 157)
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.LnameTextBox.TabIndex = 7
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(84, 183)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(135, 20)
        Me.AgeTextBox.TabIndex = 9
        '
        'SchlrshpCheckBox
        '
        Me.SchlrshpCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RegisterBindingSource, "schlrshp", True))
        Me.SchlrshpCheckBox.Location = New System.Drawing.Point(768, 100)
        Me.SchlrshpCheckBox.Name = "SchlrshpCheckBox"
        Me.SchlrshpCheckBox.Size = New System.Drawing.Size(50, 24)
        Me.SchlrshpCheckBox.TabIndex = 11
        Me.SchlrshpCheckBox.UseVisualStyleBackColor = True
        '
        'TuipaidCheckBox
        '
        Me.TuipaidCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RegisterBindingSource, "tuipaid", True))
        Me.TuipaidCheckBox.Location = New System.Drawing.Point(768, 121)
        Me.TuipaidCheckBox.Name = "TuipaidCheckBox"
        Me.TuipaidCheckBox.Size = New System.Drawing.Size(50, 24)
        Me.TuipaidCheckBox.TabIndex = 13
        Me.TuipaidCheckBox.UseVisualStyleBackColor = True
        '
        'PrevcredsTextBox
        '
        Me.PrevcredsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "prevcreds", True))
        Me.PrevcredsTextBox.Location = New System.Drawing.Point(388, 105)
        Me.PrevcredsTextBox.Name = "PrevcredsTextBox"
        Me.PrevcredsTextBox.Size = New System.Drawing.Size(135, 20)
        Me.PrevcredsTextBox.TabIndex = 15
        '
        'GpaTextBox
        '
        Me.GpaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "gpa", True))
        Me.GpaTextBox.Location = New System.Drawing.Point(388, 131)
        Me.GpaTextBox.Name = "GpaTextBox"
        Me.GpaTextBox.Size = New System.Drawing.Size(135, 20)
        Me.GpaTextBox.TabIndex = 17
        '
        'MomnameTextBox
        '
        Me.MomnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "momname", True))
        Me.MomnameTextBox.Location = New System.Drawing.Point(388, 157)
        Me.MomnameTextBox.Name = "MomnameTextBox"
        Me.MomnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.MomnameTextBox.TabIndex = 19
        '
        'DadnameTextBox
        '
        Me.DadnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisterBindingSource, "dadname", True))
        Me.DadnameTextBox.Location = New System.Drawing.Point(388, 183)
        Me.DadnameTextBox.Name = "DadnameTextBox"
        Me.DadnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.DadnameTextBox.TabIndex = 21
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegisterBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(603, 175)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 23
        '
        'CounterLBL
        '
        Me.CounterLBL.AutoSize = True
        Me.CounterLBL.BackColor = System.Drawing.Color.White
        Me.CounterLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CounterLBL.Location = New System.Drawing.Point(165, 238)
        Me.CounterLBL.Name = "CounterLBL"
        Me.CounterLBL.Size = New System.Drawing.Size(71, 25)
        Me.CounterLBL.TabIndex = 31
        Me.CounterLBL.Text = "Label1"
        '
        'TitleLBL
        '
        Me.TitleLBL.AutoSize = True
        Me.TitleLBL.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLBL.Location = New System.Drawing.Point(3, 35)
        Me.TitleLBL.Name = "TitleLBL"
        Me.TitleLBL.Size = New System.Drawing.Size(582, 65)
        Me.TitleLBL.TabIndex = 32
        Me.TitleLBL.Text = "High School Registration"
        '
        'fnameSEARCHBAR
        '
        Me.fnameSEARCHBAR.Location = New System.Drawing.Point(177, 295)
        Me.fnameSEARCHBAR.MaxLength = 25
        Me.fnameSEARCHBAR.Name = "fnameSEARCHBAR"
        Me.fnameSEARCHBAR.Size = New System.Drawing.Size(100, 20)
        Me.fnameSEARCHBAR.TabIndex = 36
        '
        'SearchLBL
        '
        Me.SearchLBL.AutoSize = True
        Me.SearchLBL.BackColor = System.Drawing.Color.White
        Me.SearchLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchLBL.Location = New System.Drawing.Point(11, 296)
        Me.SearchLBL.Name = "SearchLBL"
        Me.SearchLBL.Size = New System.Drawing.Size(160, 17)
        Me.SearchLBL.TabIndex = 37
        Me.SearchLBL.Text = "Search by First Name:   "
        '
        'RegisterTableAdapter
        '
        Me.RegisterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegisterTableAdapter = Me.RegisterTableAdapter
        Me.TableAdapterManager.UpdateOrder = Register.RegisterSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TeachMenuStrip
        '
        Me.TeachMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.TeachMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TeachMenuStrip.Name = "TeachMenuStrip"
        Me.TeachMenuStrip.Size = New System.Drawing.Size(854, 24)
        Me.TeachMenuStrip.TabIndex = 38
        Me.TeachMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenNewUserFormToolStripMenuItem, Me.ExitApplicationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenNewUserFormToolStripMenuItem
        '
        Me.OpenNewUserFormToolStripMenuItem.Name = "OpenNewUserFormToolStripMenuItem"
        Me.OpenNewUserFormToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.OpenNewUserFormToolStripMenuItem.Text = "Open New User Form"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearFormToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ClearFormToolStripMenuItem.Text = "Clear Form"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutRegisterToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutRegisterToolStripMenuItem
        '
        Me.AboutRegisterToolStripMenuItem.Name = "AboutRegisterToolStripMenuItem"
        Me.AboutRegisterToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AboutRegisterToolStripMenuItem.Text = "About Register"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AboutDeveloperToolStripMenuItem.Text = "About Developer"
        '
        'CloseBTN
        '
        Me.CloseBTN.BackgroundImage = Global.Register.My.Resources.Resources.CloseButton
        Me.CloseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBTN.Location = New System.Drawing.Point(694, 551)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(140, 60)
        Me.CloseBTN.TabIndex = 34
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'BackBTN
        '
        Me.BackBTN.BackgroundImage = Global.Register.My.Resources.Resources.BackButton
        Me.BackBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackBTN.Location = New System.Drawing.Point(11, 551)
        Me.BackBTN.Name = "BackBTN"
        Me.BackBTN.Size = New System.Drawing.Size(140, 60)
        Me.BackBTN.TabIndex = 33
        Me.BackBTN.UseVisualStyleBackColor = True
        '
        'LastBTN
        '
        Me.LastBTN.BackgroundImage = Global.Register.My.Resources.Resources.FinalItem
        Me.LastBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LastBTN.Location = New System.Drawing.Point(315, 223)
        Me.LastBTN.Name = "LastBTN"
        Me.LastBTN.Size = New System.Drawing.Size(70, 60)
        Me.LastBTN.TabIndex = 30
        Me.LastBTN.UseVisualStyleBackColor = True
        '
        'NextBTN
        '
        Me.NextBTN.BackgroundImage = Global.Register.My.Resources.Resources.NextItem
        Me.NextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextBTN.Location = New System.Drawing.Point(239, 223)
        Me.NextBTN.Name = "NextBTN"
        Me.NextBTN.Size = New System.Drawing.Size(70, 60)
        Me.NextBTN.TabIndex = 29
        Me.NextBTN.UseVisualStyleBackColor = True
        '
        'PreviousBTN
        '
        Me.PreviousBTN.BackgroundImage = Global.Register.My.Resources.Resources.LastItem
        Me.PreviousBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviousBTN.Location = New System.Drawing.Point(89, 223)
        Me.PreviousBTN.Name = "PreviousBTN"
        Me.PreviousBTN.Size = New System.Drawing.Size(70, 60)
        Me.PreviousBTN.TabIndex = 28
        Me.PreviousBTN.UseVisualStyleBackColor = True
        '
        'FirstBTN
        '
        Me.FirstBTN.BackgroundImage = Global.Register.My.Resources.Resources.FirstItem
        Me.FirstBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FirstBTN.Location = New System.Drawing.Point(13, 223)
        Me.FirstBTN.Name = "FirstBTN"
        Me.FirstBTN.Size = New System.Drawing.Size(70, 60)
        Me.FirstBTN.TabIndex = 27
        Me.FirstBTN.UseVisualStyleBackColor = True
        '
        'AddBTN
        '
        Me.AddBTN.BackgroundImage = Global.Register.My.Resources.Resources.AddItem
        Me.AddBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddBTN.Location = New System.Drawing.Point(447, 223)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(70, 60)
        Me.AddBTN.TabIndex = 26
        Me.AddBTN.UseVisualStyleBackColor = True
        '
        'DeleteBTN
        '
        Me.DeleteBTN.BackgroundImage = Global.Register.My.Resources.Resources.DeleteItem
        Me.DeleteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteBTN.Location = New System.Drawing.Point(535, 223)
        Me.DeleteBTN.Name = "DeleteBTN"
        Me.DeleteBTN.Size = New System.Drawing.Size(70, 60)
        Me.DeleteBTN.TabIndex = 25
        Me.DeleteBTN.UseVisualStyleBackColor = True
        '
        'SaveBTN
        '
        Me.SaveBTN.BackgroundImage = Global.Register.My.Resources.Resources.SaveItem
        Me.SaveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveBTN.Location = New System.Drawing.Point(625, 223)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(70, 60)
        Me.SaveBTN.TabIndex = 24
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'PrintDialogReg
        '
        Me.PrintDialogReg.UseEXDialog = True
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.CancelButton = Me.CloseBTN
        Me.ClientSize = New System.Drawing.Size(854, 631)
        Me.Controls.Add(Me.SearchLBL)
        Me.Controls.Add(Me.fnameSEARCHBAR)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.BackBTN)
        Me.Controls.Add(Me.TitleLBL)
        Me.Controls.Add(Me.CounterLBL)
        Me.Controls.Add(Me.LastBTN)
        Me.Controls.Add(Me.NextBTN)
        Me.Controls.Add(Me.PreviousBTN)
        Me.Controls.Add(Me.FirstBTN)
        Me.Controls.Add(Me.AddBTN)
        Me.Controls.Add(Me.DeleteBTN)
        Me.Controls.Add(Me.SaveBTN)
        Me.Controls.Add(StdIdLabel)
        Me.Controls.Add(Me.StdIdTextBox)
        Me.Controls.Add(FnameLabel)
        Me.Controls.Add(Me.FnameTextBox)
        Me.Controls.Add(LnameLabel)
        Me.Controls.Add(Me.LnameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(SchlrshpLabel)
        Me.Controls.Add(Me.SchlrshpCheckBox)
        Me.Controls.Add(TuipaidLabel)
        Me.Controls.Add(Me.TuipaidCheckBox)
        Me.Controls.Add(PrevcredsLabel)
        Me.Controls.Add(Me.PrevcredsTextBox)
        Me.Controls.Add(GpaLabel)
        Me.Controls.Add(Me.GpaTextBox)
        Me.Controls.Add(MomnameLabel)
        Me.Controls.Add(Me.MomnameTextBox)
        Me.Controls.Add(DadnameLabel)
        Me.Controls.Add(Me.DadnameTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.RegisterDataGridView)
        Me.Controls.Add(Me.TeachMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.TeachMenuStrip
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Registration"
        CType(Me.RegisterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeachMenuStrip.ResumeLayout(False)
        Me.TeachMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterSet As RegisterSet
    Friend WithEvents RegisterBindingSource As BindingSource
    Friend WithEvents RegisterTableAdapter As RegisterSetTableAdapters.RegisterTableAdapter
    Friend WithEvents TableAdapterManager As RegisterSetTableAdapters.TableAdapterManager
    Friend WithEvents RegisterDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents StdIdTextBox As TextBox
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents LnameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents SchlrshpCheckBox As CheckBox
    Friend WithEvents TuipaidCheckBox As CheckBox
    Friend WithEvents PrevcredsTextBox As TextBox
    Friend WithEvents GpaTextBox As TextBox
    Friend WithEvents MomnameTextBox As TextBox
    Friend WithEvents DadnameTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents SaveBTN As Button
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents AddBTN As Button
    Friend WithEvents FirstBTN As Button
    Friend WithEvents PreviousBTN As Button
    Friend WithEvents NextBTN As Button
    Friend WithEvents LastBTN As Button
    Friend WithEvents CounterLBL As Label
    Friend WithEvents TitleLBL As Label
    Friend WithEvents BackBTN As Button
    Friend WithEvents CloseBTN As Button
    Friend WithEvents fnameSEARCHBAR As TextBox
    Friend WithEvents SearchLBL As Label
    Friend WithEvents TeachMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenNewUserFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutRegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialogReg As PrintDialog
    Friend WithEvents PrintDocumentReg As Printing.PrintDocument
End Class
