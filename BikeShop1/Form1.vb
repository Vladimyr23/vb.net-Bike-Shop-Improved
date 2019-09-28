Public Class Form1
    ''Global variables declaration
    Dim start_date As Date
    Dim end_date As Date
    Dim hire_days As Integer
    Dim discount As Integer


    ''DateTimePicker1 date change event
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateTimePicker1.Value
    End Sub

    ''DateTimePicker2 date change event and hire days amount calculation
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
    End Sub

    ''Discount ComboBox
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 1 Then
            discount = 5
        ElseIf ComboBox1.SelectedIndex = 2 Then
            discount = 10
        ElseIf ComboBox1.SelectedIndex = 3 Then
            discount = 15
        Else
            discount = 0
        End If
    End Sub

    Private Sub btn_Total_Click(sender As Object, e As EventArgs) Handles btn_Total.Click
        ''Local variables
        Dim total As Decimal
        Dim days As Integer
        Dim index_date As Date
        Dim discount_total As Decimal
        Dim disc_dep_total As Decimal
        days = 0
        total = 0
        index_date = DateTimePicker1.Value.ToShortDateString
        ''Season price definition after this line
        Do
            If index_date.Month = 3 Or index_date.Month = 4 Or index_date.Month = 5 Then
                total = total + 10
            ElseIf index_date.Month = 6 Or index_date.Month = 7 Or index_date.Month = 8 Then
                total = total + 25
            ElseIf index_date.Month = 9 Or index_date.Month = 10 Or index_date.Month = 11 Then
                total = total + 15
            Else
                total = total + 5
            End If
            index_date = index_date.AddDays(1)
            days += 1
        Loop Until index_date > DateTimePicker2.Value.ToShortDateString
        total = total * NumericUpDown1.Value            ''Grand total calculation
        discount_total = total * discount / 100         ''Total discount calculation
        disc_dep_total = total - discount_total + 10    ''Final total amount to pay with discount and £10 deposit
        total = Decimal.Round(total, 2)                 ''Two decimal places rounding
        ''Total label message
        Lbl_total.Text = "Your total " & NumericUpDown1.Value & " bike(s) rent price for " & days & " day(s)" & Environment.NewLine & "from " & DateTimePicker1.Value.ToShortDateString & " to " & DateTimePicker2.Value.ToShortDateString & " inclusive is £" & total & Environment.NewLine & "discount " & discount & "% which is £" & discount_total & Environment.NewLine & "deposit  £10" & Environment.NewLine & "total to pay £" & disc_dep_total
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        End
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        If CheckBox1.Checked = True Then
            End
        Else
            MsgBox("£10 must bepaid. Please, tick the box when paid.", MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class
