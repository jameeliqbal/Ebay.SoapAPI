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
        Me.btnUpdateInventory = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.btnGetToken = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdateInventory
        '
        Me.btnUpdateInventory.Location = New System.Drawing.Point(393, 168)
        Me.btnUpdateInventory.Name = "btnUpdateInventory"
        Me.btnUpdateInventory.Size = New System.Drawing.Size(344, 125)
        Me.btnUpdateInventory.TabIndex = 0
        Me.btnUpdateInventory.Text = "3. Bulk Update Price / Quantity"
        Me.btnUpdateInventory.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(12, 12)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(158, 75)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "1. Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(13, 108)
        Me.txtToken.Multiline = True
        Me.txtToken.Name = "txtToken"
        Me.txtToken.ReadOnly = True
        Me.txtToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtToken.Size = New System.Drawing.Size(347, 330)
        Me.txtToken.TabIndex = 2
        '
        'btnGetToken
        '
        Me.btnGetToken.Location = New System.Drawing.Point(177, 13)
        Me.btnGetToken.Name = "btnGetToken"
        Me.btnGetToken.Size = New System.Drawing.Size(183, 74)
        Me.btnGetToken.TabIndex = 3
        Me.btnGetToken.Text = "2. Get Token"
        Me.btnGetToken.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGetToken)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnUpdateInventory)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateInventory As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtToken As TextBox
    Friend WithEvents btnGetToken As Button
End Class
