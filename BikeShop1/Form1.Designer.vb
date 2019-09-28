<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DatesBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.discountBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.numBikesBox = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.totalBox = New System.Windows.Forms.GroupBox()
        Me.btn_Total = New System.Windows.Forms.Button()
        Me.Lbl_total = New System.Windows.Forms.Label()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.DatesBox.SuspendLayout()
        Me.discountBox.SuspendLayout()
        Me.numBikesBox.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.totalBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatesBox
        '
        Me.DatesBox.Controls.Add(Me.Label2)
        Me.DatesBox.Controls.Add(Me.Label1)
        Me.DatesBox.Controls.Add(Me.DateTimePicker2)
        Me.DatesBox.Controls.Add(Me.DateTimePicker1)
        Me.DatesBox.Location = New System.Drawing.Point(12, 12)
        Me.DatesBox.Name = "DatesBox"
        Me.DatesBox.Size = New System.Drawing.Size(149, 111)
        Me.DatesBox.TabIndex = 0
        Me.DatesBox.TabStop = False
        Me.DatesBox.Text = "Hire Dates"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "The last day of hire:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The hire from date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 85)
        Me.DateTimePicker2.MinDate = New Date(2016, 10, 19, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 33)
        Me.DateTimePicker1.MinDate = New Date(2016, 10, 19, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'discountBox
        '
        Me.discountBox.Controls.Add(Me.ComboBox1)
        Me.discountBox.Location = New System.Drawing.Point(167, 12)
        Me.discountBox.Name = "discountBox"
        Me.discountBox.Size = New System.Drawing.Size(206, 53)
        Me.discountBox.TabIndex = 1
        Me.discountBox.TabStop = False
        Me.discountBox.Text = "Discount"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"(none)", "Students 5%", "OAP 10%", "Cycling club 15%"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.MaxDropDownItems = 4
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(46, 129)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "£10 deposit must be paid"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'numBikesBox
        '
        Me.numBikesBox.Controls.Add(Me.NumericUpDown1)
        Me.numBikesBox.Location = New System.Drawing.Point(168, 72)
        Me.numBikesBox.Name = "numBikesBox"
        Me.numBikesBox.Size = New System.Drawing.Size(205, 51)
        Me.numBikesBox.TabIndex = 3
        Me.numBikesBox.TabStop = False
        Me.numBikesBox.Text = "How many bikes?"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(95, 9)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalBox
        '
        Me.totalBox.Controls.Add(Me.btn_Total)
        Me.totalBox.Controls.Add(Me.Lbl_total)
        Me.totalBox.Location = New System.Drawing.Point(12, 152)
        Me.totalBox.Name = "totalBox"
        Me.totalBox.Size = New System.Drawing.Size(361, 143)
        Me.totalBox.TabIndex = 4
        Me.totalBox.TabStop = False
        Me.totalBox.Text = "Total"
        '
        'btn_Total
        '
        Me.btn_Total.Location = New System.Drawing.Point(251, 107)
        Me.btn_Total.Name = "btn_Total"
        Me.btn_Total.Size = New System.Drawing.Size(104, 23)
        Me.btn_Total.TabIndex = 1
        Me.btn_Total.Text = "Display Total"
        Me.btn_Total.UseVisualStyleBackColor = True
        '
        'Lbl_total
        '
        Me.Lbl_total.AutoSize = True
        Me.Lbl_total.Location = New System.Drawing.Point(31, 16)
        Me.Lbl_total.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Lbl_total.Name = "Lbl_total"
        Me.Lbl_total.Size = New System.Drawing.Size(165, 13)
        Me.Lbl_total.TabIndex = 0
        Me.Lbl_total.Text = "Total result will be displayed here."
        Me.Lbl_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(211, 301)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Submit.TabIndex = 5
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(292, 301)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 6
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 336)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.totalBox)
        Me.Controls.Add(Me.numBikesBox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.discountBox)
        Me.Controls.Add(Me.DatesBox)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Bike Shop"
        Me.DatesBox.ResumeLayout(False)
        Me.DatesBox.PerformLayout()
        Me.discountBox.ResumeLayout(False)
        Me.numBikesBox.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.totalBox.ResumeLayout(False)
        Me.totalBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatesBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents discountBox As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents numBikesBox As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents totalBox As GroupBox
    Friend WithEvents btn_Total As Button
    Friend WithEvents Lbl_total As Label
    Friend WithEvents btn_Submit As Button
    Friend WithEvents btn_Exit As Button
End Class
