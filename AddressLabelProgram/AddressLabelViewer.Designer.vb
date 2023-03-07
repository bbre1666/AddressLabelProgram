<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddressLabel
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
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.LabelPreview = New System.Windows.Forms.GroupBox()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.StreetName = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.Label()
        Me.ZipCode = New System.Windows.Forms.Label()
        Me.PerviewLableButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(119, 42)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(189, 27)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(119, 83)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(189, 27)
        Me.LastNameTextBox.TabIndex = 1
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(119, 132)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(189, 27)
        Me.StreetTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(119, 180)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(189, 27)
        Me.CityTextBox.TabIndex = 3
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(119, 229)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(189, 27)
        Me.StateTextBox.TabIndex = 4
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(119, 282)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(189, 27)
        Me.ZipCodeTextBox.TabIndex = 5
        '
        'LabelPreview
        '
        Me.LabelPreview.Location = New System.Drawing.Point(429, 30)
        Me.LabelPreview.Name = "LabelPreview"
        Me.LabelPreview.Size = New System.Drawing.Size(345, 281)
        Me.LabelPreview.TabIndex = 6
        Me.LabelPreview.TabStop = False
        Me.LabelPreview.Text = "LabelPreview"
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(33, 42)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(80, 20)
        Me.FirstName.TabIndex = 7
        Me.FirstName.Text = "Frist Name"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(33, 86)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(79, 20)
        Me.LastName.TabIndex = 8
        Me.LastName.Text = "Last Name"
        '
        'StreetName
        '
        Me.StreetName.AutoSize = True
        Me.StreetName.Location = New System.Drawing.Point(21, 135)
        Me.StreetName.Name = "StreetName"
        Me.StreetName.Size = New System.Drawing.Size(92, 20)
        Me.StreetName.TabIndex = 9
        Me.StreetName.Text = "Street Name"
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(60, 187)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(34, 20)
        Me.City.TabIndex = 10
        Me.City.Text = "City"
        '
        'State
        '
        Me.State.AutoSize = True
        Me.State.Location = New System.Drawing.Point(60, 232)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(43, 20)
        Me.State.TabIndex = 11
        Me.State.Text = "State"
        '
        'ZipCode
        '
        Me.ZipCode.AutoSize = True
        Me.ZipCode.Location = New System.Drawing.Point(42, 285)
        Me.ZipCode.Name = "ZipCode"
        Me.ZipCode.Size = New System.Drawing.Size(70, 20)
        Me.ZipCode.TabIndex = 12
        Me.ZipCode.Text = "Zip Code"
        '
        'PerviewLableButton
        '
        Me.PerviewLableButton.Location = New System.Drawing.Point(472, 378)
        Me.PerviewLableButton.Name = "PerviewLableButton"
        Me.PerviewLableButton.Size = New System.Drawing.Size(100, 51)
        Me.PerviewLableButton.TabIndex = 13
        Me.PerviewLableButton.Text = "Preview Label"
        Me.PerviewLableButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(578, 378)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 51)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(684, 378)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 51)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddressLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PerviewLableButton)
        Me.Controls.Add(Me.ZipCode)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.StreetName)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.LabelPreview)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "AddressLabel"
        Me.Text = "AddressLabel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents LabelPreview As GroupBox
    Friend WithEvents FirstName As Label
    Friend WithEvents LastName As Label
    Friend WithEvents StreetName As Label
    Friend WithEvents City As Label
    Friend WithEvents State As Label
    Friend WithEvents ZipCode As Label
    Friend WithEvents PerviewLableButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip As ToolTip
End Class
