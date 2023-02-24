Public Class Form1
    Dim x, y, z As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "POUND" And ComboBox2.Text = "USD" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 1.21
            Label2.Text = y
        ElseIf ComboBox1.Text = "POUND" And ComboBox2.Text = "INR" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 100.08
            Label2.Text = y
        ElseIf ComboBox1.Text = "POUND" And ComboBox2.Text = "SAR" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 4.54
            Label2.Text = y
        ElseIf ComboBox1.Text = "POUND" And ComboBox2.Text = "EURO" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 1.13
            Label2.Text = y



        ElseIf ComboBox1.Text = "USD" And ComboBox2.Text = "INR" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 82.59
            Label2.Text = y
        ElseIf ComboBox1.Text = "USD" And ComboBox2.Text = "POUND" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 0.83
            Label2.Text = y
        ElseIf ComboBox1.Text = "USD" And ComboBox2.Text = "EURO" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 0.93
            Label2.Text = y
        ElseIf ComboBox1.Text = "USD" And ComboBox2.Text = "SAR" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 3.75
            Label2.Text = y
        ElseIf ComboBox1.Text = "USD" And ComboBox2.Text = "USD" Then
            Label2.Text = Nothing
            x = TextBox1.Text
            y = x * 1
            Label2.Text = y


        ElseIf ComboBox1.Text = "SAR" Then

            If ComboBox2.Text = "USD" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.27
                Label2.Text = y
            ElseIf ComboBox2.Text = "INR" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 22.01
                Label2.Text = y
            ElseIf ComboBox2.Text = "POUND" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.22
                Label2.Text = y
            ElseIf ComboBox2.Text = "EURO" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.25
                Label2.Text = y

            Else
                Label2.Text = Nothing
                x = TextBox1.Text
                Label2.Text = x
            End If


        ElseIf ComboBox1.Text = "INR" Then
            If ComboBox2.Text = "USD" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.012
                Label2.Text = y
            ElseIf ComboBox2.Text = "SAR" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.045
                Label2.Text = y
            ElseIf ComboBox2.Text = "POUND" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.1
                Label2.Text = y
            ElseIf ComboBox2.Text = "EURO" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.011
                Label2.Text = y
            Else
                Label2.Text = Nothing
                x = TextBox1.Text
                Label2.Text = x
            End If

        ElseIf ComboBox1.Text = "EURO" Then
            If ComboBox2.Text = "USD" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 1.07
                Label2.Text = y
            ElseIf ComboBox2.Text = "SAR" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 4.02
                Label2.Text = y
            ElseIf ComboBox2.Text = "POUND" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 0.88
                Label2.Text = y
            ElseIf ComboBox2.Text = "INR" Then
                Label2.Text = Nothing
                x = TextBox1.Text
                y = x * 88.41
                Label2.Text = y
            Else
                Label2.Text = Nothing
                x = TextBox1.Text
                Label2.Text = x
            End If

        Else
                Label2.Text = Nothing
            x = TextBox1.Text
            Label2.Text = x

        End If
    End Sub
End Class
