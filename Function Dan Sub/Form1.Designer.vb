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
        Me.btnKlik1 = New System.Windows.Forms.Button()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.txtboxInput1 = New System.Windows.Forms.TextBox()
        Me.btnKlik2 = New System.Windows.Forms.Button()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.btnKlik3 = New System.Windows.Forms.Button()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.txtboxInput2 = New System.Windows.Forms.TextBox()
        Me.lblOutput4 = New System.Windows.Forms.Label()
        Me.btnKlik4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnKlik1
        '
        Me.btnKlik1.Location = New System.Drawing.Point(302, 41)
        Me.btnKlik1.Name = "btnKlik1"
        Me.btnKlik1.Size = New System.Drawing.Size(94, 29)
        Me.btnKlik1.TabIndex = 0
        Me.btnKlik1.Text = "Klik"
        Me.btnKlik1.UseVisualStyleBackColor = True
        '
        'lblOutput1
        '
        Me.lblOutput1.AutoSize = True
        Me.lblOutput1.Location = New System.Drawing.Point(436, 45)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(53, 20)
        Me.lblOutput1.TabIndex = 1
        Me.lblOutput1.Text = "Label1"
        '
        'txtboxInput1
        '
        Me.txtboxInput1.Location = New System.Drawing.Point(120, 147)
        Me.txtboxInput1.Name = "txtboxInput1"
        Me.txtboxInput1.Size = New System.Drawing.Size(125, 27)
        Me.txtboxInput1.TabIndex = 2
        '
        'btnKlik2
        '
        Me.btnKlik2.Location = New System.Drawing.Point(302, 143)
        Me.btnKlik2.Name = "btnKlik2"
        Me.btnKlik2.Size = New System.Drawing.Size(94, 29)
        Me.btnKlik2.TabIndex = 3
        Me.btnKlik2.Text = "Klik"
        Me.btnKlik2.UseVisualStyleBackColor = True
        '
        'lblOutput2
        '
        Me.lblOutput2.AutoSize = True
        Me.lblOutput2.Location = New System.Drawing.Point(436, 147)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(53, 20)
        Me.lblOutput2.TabIndex = 4
        Me.lblOutput2.Text = "Label2"
        '
        'btnKlik3
        '
        Me.btnKlik3.Location = New System.Drawing.Point(302, 242)
        Me.btnKlik3.Name = "btnKlik3"
        Me.btnKlik3.Size = New System.Drawing.Size(94, 29)
        Me.btnKlik3.TabIndex = 5
        Me.btnKlik3.Text = "Klik"
        Me.btnKlik3.UseVisualStyleBackColor = True
        '
        'lblOutput3
        '
        Me.lblOutput3.AutoSize = True
        Me.lblOutput3.Location = New System.Drawing.Point(436, 242)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(53, 20)
        Me.lblOutput3.TabIndex = 6
        Me.lblOutput3.Text = "Label3"
        '
        'txtboxInput2
        '
        Me.txtboxInput2.Location = New System.Drawing.Point(120, 334)
        Me.txtboxInput2.Name = "txtboxInput2"
        Me.txtboxInput2.Size = New System.Drawing.Size(125, 27)
        Me.txtboxInput2.TabIndex = 7
        '
        'lblOutput4
        '
        Me.lblOutput4.AutoSize = True
        Me.lblOutput4.Location = New System.Drawing.Point(436, 338)
        Me.lblOutput4.Name = "lblOutput4"
        Me.lblOutput4.Size = New System.Drawing.Size(53, 20)
        Me.lblOutput4.TabIndex = 8
        Me.lblOutput4.Text = "Label4"
        '
        'btnKlik4
        '
        Me.btnKlik4.Location = New System.Drawing.Point(302, 334)
        Me.btnKlik4.Name = "btnKlik4"
        Me.btnKlik4.Size = New System.Drawing.Size(94, 29)
        Me.btnKlik4.TabIndex = 9
        Me.btnKlik4.Text = "Klik"
        Me.btnKlik4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKlik4)
        Me.Controls.Add(Me.lblOutput4)
        Me.Controls.Add(Me.txtboxInput2)
        Me.Controls.Add(Me.lblOutput3)
        Me.Controls.Add(Me.btnKlik3)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.btnKlik2)
        Me.Controls.Add(Me.txtboxInput1)
        Me.Controls.Add(Me.lblOutput1)
        Me.Controls.Add(Me.btnKlik1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKlik1 As Button
    Friend WithEvents lblOutput1 As Label
    Friend WithEvents txtboxInput1 As TextBox
    Friend WithEvents btnKlik2 As Button
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents btnKlik3 As Button
    Friend WithEvents lblOutput3 As Label
    Friend WithEvents txtboxInput2 As TextBox
    Friend WithEvents lblOutput4 As Label
    Friend WithEvents btnKlik4 As Button
End Class
