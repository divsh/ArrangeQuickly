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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblComparisonCount = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.txtSortedList = New System.Windows.Forms.TextBox()
        Me.btnEqual = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(612, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblComparisonCount
        '
        Me.lblComparisonCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblComparisonCount.AutoSize = True
        Me.lblComparisonCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblComparisonCount.Location = New System.Drawing.Point(588, 416)
        Me.lblComparisonCount.Name = "lblComparisonCount"
        Me.lblComparisonCount.Size = New System.Drawing.Size(73, 13)
        Me.lblComparisonCount.TabIndex = 3
        Me.lblComparisonCount.Text = "comparisons#"
        Me.lblComparisonCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalItems
        '
        Me.lblTotalItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTotalItems.Location = New System.Drawing.Point(504, 416)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalItems.TabIndex = 4
        Me.lblTotalItems.Text = "Total Items"
        '
        'btnA
        '
        Me.btnA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnA.Location = New System.Drawing.Point(12, 322)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(675, 23)
        Me.btnA.TabIndex = 5
        Me.btnA.Text = "OptionA"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnB.Location = New System.Drawing.Point(12, 351)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(675, 23)
        Me.btnB.TabIndex = 6
        Me.btnB.Text = "OptionB"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select the "
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(69, 293)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "(Specify the comparitive word. For e.g. greater, longer, lower, more, lesser, bet" & _
    "ter)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "That will move to top."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSortedList)
        Me.SplitContainer1.Size = New System.Drawing.Size(675, 275)
        Me.SplitContainer1.SplitterDistance = 327
        Me.SplitContainer1.TabIndex = 10
        '
        'txtList
        '
        Me.txtList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtList.Location = New System.Drawing.Point(0, 0)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(327, 275)
        Me.txtList.TabIndex = 1
        '
        'txtSortedList
        '
        Me.txtSortedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSortedList.Location = New System.Drawing.Point(0, 0)
        Me.txtSortedList.Multiline = True
        Me.txtSortedList.Name = "txtSortedList"
        Me.txtSortedList.Size = New System.Drawing.Size(344, 275)
        Me.txtSortedList.TabIndex = 3
        '
        'btnEqual
        '
        Me.btnEqual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEqual.Location = New System.Drawing.Point(12, 380)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(675, 23)
        Me.btnEqual.TabIndex = 11
        Me.btnEqual.Text = "Equal"
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 438)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.lblComparisonCount)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Arrange Quickly"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblComparisonCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalItems As System.Windows.Forms.Label
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtList As System.Windows.Forms.TextBox
    Friend WithEvents txtSortedList As System.Windows.Forms.TextBox
    Friend WithEvents btnEqual As System.Windows.Forms.Button

End Class
