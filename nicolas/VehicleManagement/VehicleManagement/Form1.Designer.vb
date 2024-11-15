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
        Me.btnload = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.datarecord = New System.Windows.Forms.DataGridView()
        CType(Me.datarecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(37, 30)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(110, 67)
        Me.btnload.TabIndex = 0
        Me.btnload.Text = "Load Info"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(37, 121)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(110, 67)
        Me.btninsert.TabIndex = 1
        Me.btninsert.Text = "Insert Info"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(37, 371)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(110, 67)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'datarecord
        '
        Me.datarecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datarecord.Location = New System.Drawing.Point(174, 30)
        Me.datarecord.Name = "datarecord"
        Me.datarecord.Size = New System.Drawing.Size(614, 408)
        Me.datarecord.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.datarecord)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btnload)
        Me.Name = "Form1"
        Me.Text = "Vehicle Management"
        CType(Me.datarecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnload As Button
    Friend WithEvents btninsert As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents datarecord As DataGridView
End Class
