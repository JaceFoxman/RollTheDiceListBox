'Jason Permann
'Spring 2025
'RCET2265
'Roll The Dice List Box
'https://github.com/JaceFoxman/RollTheDiceListBox.git

Option Explicit On
Option Strict On
Public Class RollTheDiceListBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ''' <summary>
    ''' Removes all text from list box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DataListBox.Items.Clear()
    End Sub
    ''' <summary>
    ''' When button pressed run RollTheDice code
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollTheDice()
    End Sub
    ''' <summary>
    ''' Closes program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Refrenced code from another project in repository
    'https://github.com/JaceFoxman/RollTheDice.git
    Sub RollTheDice()
        Dim randomNumber(12) As Integer
        Dim rowOne As String
        Dim rowTwo As String

        For i = 1 To 1000
            randomNumber(RNG(1, 12)) += 1
        Next

        DataListBox.Items.Add("Roll of the Dice".PadLeft(40))
        DataListBox.Items.Add(StrDup(80, "-"))

        For i = 2 To UBound(randomNumber)
            rowOne &= ($"{CStr(i).PadLeft(4)}  |") '&= allows horizontal formatting
        Next

        For i = 2 To UBound(randomNumber)
            rowTwo &= ($"{CStr(randomNumber(i)).PadLeft(4)}  |") '&= allows horizontal formatting
        Next

        DataListBox.Items.Add(rowOne)
        DataListBox.Items.Add(vbNewLine
                              )

        DataListBox.Items.Add(rowTwo)
        DataListBox.Items.Add(vbNewLine
                              )
    End Sub

    Function RNG(min As Integer, max As Integer) As Integer
        Dim value As Single
        Randomize()
        value = Rnd()
        value *= max - min
        value += min
        Return CInt(Math.Ceiling(value))
    End Function

End Class
