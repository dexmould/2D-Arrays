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
        Me.BtnGetElement = New System.Windows.Forms.Button()
        Me.TxtFirstDimension = New System.Windows.Forms.TextBox()
        Me.TxtSecondDimension = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnGetElement
        '
        Me.BtnGetElement.Location = New System.Drawing.Point(76, 51)
        Me.BtnGetElement.Name = "BtnGetElement"
        Me.BtnGetElement.Size = New System.Drawing.Size(120, 23)
        Me.BtnGetElement.TabIndex = 0
        Me.BtnGetElement.Text = "Get Array Element"
        Me.BtnGetElement.UseVisualStyleBackColor = True
        '
        'TxtFirstDimension
        '
        Me.TxtFirstDimension.Location = New System.Drawing.Point(33, 25)
        Me.TxtFirstDimension.Name = "TxtFirstDimension"
        Me.TxtFirstDimension.Size = New System.Drawing.Size(100, 20)
        Me.TxtFirstDimension.TabIndex = 1
        '
        'TxtSecondDimension
        '
        Me.TxtSecondDimension.Location = New System.Drawing.Point(139, 25)
        Me.TxtSecondDimension.Name = "TxtSecondDimension"
        Me.TxtSecondDimension.Size = New System.Drawing.Size(100, 20)
        Me.TxtSecondDimension.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 121)
        Me.Controls.Add(Me.TxtSecondDimension)
        Me.Controls.Add(Me.TxtFirstDimension)
        Me.Controls.Add(Me.BtnGetElement)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGetElement As Button
    Friend WithEvents TxtFirstDimension As TextBox
    Friend WithEvents TxtSecondDimension As TextBox
End Class
