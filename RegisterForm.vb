Imports System.Data.SqlClient
Imports System.Drawing.Printing


Public Class RegisterForm
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub RegisterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RegisterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegisterSet)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegisterSet.Register' table. You can move, or remove it, as needed.
        Me.RegisterTableAdapter.Fill(Me.RegisterSet.Register)

        myConn = New SqlConnection("Initial Catalog=Northwind;" &
"Data Source=localhost;Integrated Security=SSPI;")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT IsAdmin FROM Users"

        Dim cmd As SqlCommand = New SqlCommand("Select isadmin from user")
        Dim dt As DataTable = New DataTable()
        If (dt.Rows.Count = 0) Then
            Me.OpenNewUserFormToolStripMenuItem.Visible = True
        Else
            Me.OpenNewUserFormToolStripMenuItem.Visible = False
        End If


    End Sub

    'THIS CODE ALLOWS ALL BUTTON FUNCTIONALITY

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        Me.Validate()
        Me.RegisterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegisterSet)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        Dim result As DialogResult = MessageBox.Show("Save Data?",
                              "Register",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try
                Me.RegisterBindingSource.RemoveCurrent()
            Catch ex As Exception

            End Try
        Else

        End If
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        Try
            Me.RegisterBindingSource.AddNew()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FirstBTN_Click(sender As Object, e As EventArgs) Handles FirstBTN.Click
        Me.RegisterBindingSource.MoveFirst()
    End Sub

    Private Sub PreviousBTN_Click(sender As Object, e As EventArgs) Handles PreviousBTN.Click
        Me.RegisterBindingSource.MovePrevious()
    End Sub

    Private Sub NextBTN_Click(sender As Object, e As EventArgs) Handles NextBTN.Click
        Me.RegisterBindingSource.MoveNext()
    End Sub

    Private Sub LastBTN_Click(sender As Object, e As EventArgs) Handles LastBTN.Click
        Me.RegisterBindingSource.MoveLast()
    End Sub

    Private Sub RegisterBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles RegisterBindingSource.CurrentChanged
        Me.CounterLBL.Text = Me.RegisterBindingSource.Position + 1 & " of " & Me.RegisterBindingSource.Count
    End Sub

    'THIS IS A MESSAGE BOX ASKING IF YOU WISH TO CLOSE THE APPLICATION
    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Dim result As DialogResult = MessageBox.Show("Close Applicatoin?",
                              "Register",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        Else

        End If
    End Sub

    'THIS IS A MESSAGE BOX ASKING IF YOU WISH TO CLOSE THE APPLICATION
    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Dim result As DialogResult = MessageBox.Show("Return to Login?",
                              "Register",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Login.UsernameTB.Clear()
            Login.PasswordTB.Clear()
            Me.Hide()
            Login.Show()
        Else

        End If
    End Sub

    Private Sub fnameSEARCHBAR_TextChanged(sender As Object, e As EventArgs) Handles fnameSEARCHBAR.TextChanged
        Me.RegisterBindingSource.Filter = "fname LIKE '" & fnameSEARCHBAR.Text & "%'"
    End Sub

    Private Sub OpenNewUserFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNewUserFormToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Open New User Form?",
                              "Register",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Me.Hide()
            NewUser.Show()
        Else

        End If
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFormToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Do you wish to clear the form?",
                              "Register",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            FnameTextBox.Clear()
            LnameTextBox.Clear()
            AgeTextBox.Clear()
            PrevcredsTextBox.Clear()
            GpaTextBox.Clear()
            MomnameTextBox.Clear()
            DadnameTextBox.Clear()
            SchlrshpCheckBox.Checked = False
            TuipaidCheckBox.Checked = False
            DateDateTimePicker.Checked = False
        Else

        End If
    End Sub

    Private Sub AboutRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutRegisterToolStripMenuItem.Click
        Me.Hide()
        AboutPro.Show()
    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        Me.Hide()
        AboutDev.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialogReg.Document = PrintDocumentReg
        PrintDialogReg.PrinterSettings = PrintDocumentReg.PrinterSettings
        PrintDialogReg.AllowSomePages = True

        If PrintDialogReg.ShowDialog = DialogResult.OK Then
            PrintDocumentReg.PrinterSettings = PrintDialogReg.PrinterSettings
            PrintDocumentReg.Print()
        End If
    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Close Applicatoin?",
                              "Register",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        Else

        End If
    End Sub
End Class
