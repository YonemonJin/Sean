<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txtplate = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plate Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(574, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Model"
        '
        'txttype
        '
        Me.txttype.Location = New System.Drawing.Point(78, 12)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(103, 20)
        Me.txttype.TabIndex = 3
        '
        'txtplate
        '
        Me.txtplate.Location = New System.Drawing.Point(319, 104)
        Me.txtplate.Name = "txtplate"
        Me.txtplate.Size = New System.Drawing.Size(103, 20)
        Me.txtplate.TabIndex = 4
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(649, 401)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(103, 20)
        Me.txtmodel.TabIndex = 5
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(36, 184)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(346, 254)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "Save Record"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(442, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(346, 254)
        Me.btnback.TabIndex = 7
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtplate)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttype As TextBox
    Friend WithEvents txtplate As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnback As Button
End Class
