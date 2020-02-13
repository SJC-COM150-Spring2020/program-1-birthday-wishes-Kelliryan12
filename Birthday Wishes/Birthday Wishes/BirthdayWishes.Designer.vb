<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BirthdayWishes
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(32, 43)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(278, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Please Enter Your Name "
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        Me.txtName.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(36, 94)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(140, 27)
        Me.txtName.TabIndex = 1
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.Color.White
        Me.btnClick.Location = New System.Drawing.Point(36, 148)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(95, 29)
        Me.btnClick.TabIndex = 2
        Me.btnClick.Text = "Enter"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.Location = New System.Drawing.Point(36, 212)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(246, 134)
        Me.lstOut.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(36, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(151, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Birthday_Wishes.My.Resources.Resources.Balloons
        Me.PictureBox1.Location = New System.Drawing.Point(383, 148)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BirthdayWishes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(677, 476)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "BirthdayWishes"
        Me.Text = "Birthday Wishes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClick As Button
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
