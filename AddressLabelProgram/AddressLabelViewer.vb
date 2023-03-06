Option Explicit On
Option Strict On

'Baden Brenner
'RECT 0265
'Spring 2023
'Adress Lable Program
'https://github.com/bbre1666/AddressLabelProgram.git

Imports System.IO.Compression

Public Class AddressLabel
    Function ValidInput() As Boolean
        Dim allValid As Boolean = True
        Dim zip As Integer
        Try
            zip = CInt(ZipCodeTextBox.Text)
        Catch ex As Exception
            AccumulateMessage("Zip Code must be a number")
            ZipCodeTextBox.Focus()
            allValid = False
        End Try

        If StateTextBox.Text = "" Then
            AccumulateMessage("State must be entered")
            StateTextBox.Focus()
            allValid = False
        End If

        If CityTextBox.Text = "" Then
            AccumulateMessage("City must be entered")
            CityTextBox.Focus()
            allValid = False
        End If

        If StreetTextBox.Text = "" Then
            AccumulateMessage("Street name must be entered")
            StreetTextBox.Focus()
            allValid = False
        End If

        If LastNameTextBox.Text = "" Then
            AccumulateMessage("Last name must be entered")
            LastNameTextBox.Focus()
            allValid = False
        End If

        If FirstNameTextBox.Text = "" Then
            AccumulateMessage("First name must be entered")
            FirstNameTextBox.Focus()
            allValid = False
        End If

        If AccumulateMessage() <> "" Then
            MsgBox(AccumulateMessage())
            AccumulateMessage(, True)
            allValid = False
        End If
        Return allValid
    End Function

    Private Function AccumulateMessage(Optional newMessage As String = "", Optional clear As Boolean = False) As String
        Static _message As String
        Select Case clear
            Case False
                If newMessage <> "" Then
                    _message &= newMessage & vbCrLf
                End If
            Case Else
                _message = ""
        End Select
        Return _message

    End Function

    Private Function Summary(Optional addRecord As Boolean = True) As String
        Static _summary As String
        'example of output
        'First last
        'Street Address
        'City State Zip code
        If addRecord Then
            _summary &= $"{FirstNameTextBox.Text} {LastNameTextBox.Text}" & vbNewLine
            _summary &= $"{StreetTextBox.Text}" & vbNewLine
            _summary &= $"{CityTextBox.Text}" & "," & $" {StateTextBox.Text} {ZipCodeTextBox.Text}"
        End If
        Return _summary
    End Function

    Private Sub Clear()
        'resete to dafalt 
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        LabelPreview.Text = ""
        'clears the stored values 
        AccumulateMessage(, True)
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles PerviewLableButton.Click
        'if the imput is valid thatn the lable will display
        If ValidInput() Then
            Summary()
            Clear()
        End If
        LabelPreview.Text = Summary(False)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()
    End Sub
End Class

