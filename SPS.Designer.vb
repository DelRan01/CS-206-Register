<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPS
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
        Me.components = New System.ComponentModel.Container()
        Me.RegTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RegProgBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'RegTimer
        '
        Me.RegTimer.Enabled = True
        Me.RegTimer.Interval = 50
        '
        'RegProgBar
        '
        Me.RegProgBar.Location = New System.Drawing.Point(-1, 175)
        Me.RegProgBar.Name = "RegProgBar"
        Me.RegProgBar.Size = New System.Drawing.Size(436, 36)
        Me.RegProgBar.TabIndex = 0
        '
        'SPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Register.My.Resources.Resources.Screenshot_2023_03_31_211607
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 211)
        Me.Controls.Add(Me.RegProgBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SPS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegTimer As Timer
    Friend WithEvents RegProgBar As ProgressBar
End Class
