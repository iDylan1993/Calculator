Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Class MainWindow

    Dim memory1 As String
    Dim memory2 As String
    Dim memory3 As String

    Dim resultgive As Boolean = True

    Dim plus As Double
    Dim minus As Double

    Dim square As Double
    Dim sign As Char

    Dim nm1 As Double
    Dim nm2 As Double
    Dim nm3 As Double
    Private Sub Button0_Click(sender As Object, e As RoutedEventArgs) Handles button0.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As RoutedEventArgs) Handles button3.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As RoutedEventArgs) Handles button4.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As RoutedEventArgs) Handles button5.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As RoutedEventArgs) Handles button6.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As RoutedEventArgs) Handles button7.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As RoutedEventArgs) Handles button8.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As RoutedEventArgs) Handles button9.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
        End If
        display.AppendText(9)
    End Sub
    Private Sub Dot_Click(sender As Object, e As RoutedEventArgs) Handles dot.Click
        If resultgive = True Then
            display.Clear()
            resultgive = False
            display.AppendText("0.")
        Else
            display.AppendText(".")
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles clear.Click
        resultgive = True
        display.Clear()
        memory1 = String.Empty
        memory2 = String.Empty
        memory3 = String.Empty
    End Sub
    Private Sub Square_Click(sender As Object, e As RoutedEventArgs) Handles squarebutton.Click
        If String.IsNullOrEmpty(display.Text) Then
            System.Windows.MessageBox.Show("Please enter a valid number.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            square = Convert.ToDouble(display.Text)
            display.Text = Convert.ToString(Math.Sqrt(square))
        End If
    End Sub
    Private Sub Plus_negative_Click(sender As Object, e As RoutedEventArgs) Handles plus_negative.Click
        If String.IsNullOrEmpty(display.Text) Then
            System.Windows.MessageBox.Show("Please enter a valid number.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            minus = Convert.ToDouble(display.Text)
            plus = minus - minus - minus
            display.Text = Convert.ToString(plus)
        End If
    End Sub

    Private Sub Plusbutton_Click(sender As Object, e As RoutedEventArgs) Handles plusbutton.Click
        If String.IsNullOrEmpty(display.Text) Then
            System.Windows.MessageBox.Show("Please enter a valid number.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            memory1 = display.Text
            memory2 = "+"
            display.Clear()
        End If
    End Sub

    Private Sub Devide_Click(sender As Object, e As RoutedEventArgs) Handles devide.Click
        If String.IsNullOrEmpty(display.Text) Then
            System.Windows.MessageBox.Show("Please enter a valid number.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            memory1 = display.Text
            memory2 = "/"
            display.Clear()
        End If
    End Sub

    Private Sub Multiply_Click(sender As Object, e As RoutedEventArgs) Handles multiply.Click
        If String.IsNullOrEmpty(display.Text) Then
            System.Windows.MessageBox.Show("Please enter a valid number.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            memory1 = display.Text
            memory2 = "*"
            display.Clear()
        End If
    End Sub

    Private Sub Minbutton_Click(sender As Object, e As RoutedEventArgs) Handles minbutton.Click
        If String.IsNullOrEmpty(display.Text) Then
            System.Windows.MessageBox.Show("Please enter a valid number.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            memory1 = display.Text
            memory2 = "-"
            display.Clear()
        End If
    End Sub

    Private Sub Result_Click(sender As Object, e As RoutedEventArgs) Handles result.Click
        If String.IsNullOrEmpty(display.Text) Then
            System.Windows.MessageBox.Show("Please enter a valid number.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning)
        Else
            memory3 = display.Text
            sign = memory2
            nm1 = Convert.ToDouble(memory1)
            nm2 = Convert.ToDouble(memory3)
            Select Case (sign)
                Case "+"
                    nm3 = nm1 + nm2
                Case "-"
                    nm3 = nm1 - nm2
                Case "*"
                    nm3 = nm1 * nm2
                    sign = "X"
                Case "/"
                    nm3 = nm1 / nm2
            End Select
            display.Text = Convert.ToString(nm3)
            history.Text = history.Text + (vbNewLine + nm1.ToString + " " + sign + " " + nm2.ToString + " = " + nm3.ToString)
            resultgive = True
        End If
    End Sub

    Private Sub Display_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles display.PreviewTextInput
        If Not Char.IsDigit(e.Text, e.Text.Length - 1) Then
            e.Handled = True
        End If
    End Sub
End Class
