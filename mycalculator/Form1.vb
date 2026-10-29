Public Class Form1
    Dim firstNum As Double = 0
    Dim secondNum As Double = 0
    Dim operation As String = ""
    Dim isOperationPerformed As Boolean = False

    ' 1. Тооны товчлуурууд дарагдах үед ажиллах код
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim b As Button = CType(sender, Button)

        If (txtDisplay.Text = "0") Or (isOperationPerformed) Then
            txtDisplay.Text = ""
        End If

        isOperationPerformed = False
        txtDisplay.Text = txtDisplay.Text + b.Text
    End Sub

    ' 2. Үйлдлийн товчлуурууд (+, -, *, /) дарагдах үед
    Private Sub Operation_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click
        Dim b As Button = CType(sender, Button)

        firstNum = Val(txtDisplay.Text)
        operation = b.Text
        isOperationPerformed = True
    End Sub

    ' 3. Арилгах товч (C)
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        firstNum = 0
        secondNum = 0
        operation = ""
    End Sub

    ' 4. Тэнцүү товч (=) болон бодолт хийх хэсэг
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondNum = Val(txtDisplay.Text)

        Select Case operation
            Case "+"
                txtDisplay.Text = (firstNum + secondNum).ToString()
            Case "-"
                txtDisplay.Text = (firstNum - secondNum).ToString()
            Case "*"
                txtDisplay.Text = (firstNum * secondNum).ToString()
            Case "/"
                If secondNum <> 0 Then
                    txtDisplay.Text = (firstNum / secondNum).ToString()
                Else
                    txtDisplay.Text = "Error"
                End If
        End Select

        isOperationPerformed = True
    End Sub
End Class