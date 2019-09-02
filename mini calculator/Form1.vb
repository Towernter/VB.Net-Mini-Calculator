Imports System.Math
Public Class Form1
    Dim signs As Integer
    Dim a, b As Decimal
    Dim contition As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox1.Text <> " 0" Then
            TextBox1.Text += "0"
        Else
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim a As Integer = Val(TextBox1.Text)
        TextBox1.Text = Math.Log(a)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim a As Integer = Val(TextBox1.Text)
        TextBox1.Text = Math.Exp(a)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        contition = True
        a = TextBox1.Text
        signs = "1"
        TextBox1.Text = "0"
        contition = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        contition = True
        a = TextBox1.Text
        signs = "2"
        TextBox1.Text = "0"
        contition = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        contition = True
        a = TextBox1.Text
        signs = "3"
        TextBox1.Text = "0"
        contition = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        contition = True
        a = TextBox1.Text
        signs = "4"
        TextBox1.Text = "0"
        contition = True
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        b = TextBox1.Text
        contition = True
        If signs = 1 Then
            TextBox1.Text = a + b
        ElseIf signs = 2 Then
            TextBox1.Text = a - b
        ElseIf signs = 3 Then
            TextBox1.Text = a * b
        ElseIf signs = 4 Then
            If b = 0 Then
                TextBox1.Text = "ERROR"
            Else
                TextBox1.Text = a / b
            End If

        End If

    End Sub

End Class
