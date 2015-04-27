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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblLocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAll = New DMSEventCreatorUtility.dsAll()
        Me.TblLocTableAdapter = New DMSEventCreatorUtility.dsAllTableAdapters.tblLocTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHowMany = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.TblLocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblLocBindingSource
        Me.ComboBox1.DisplayMember = "LocDescription"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "LocID"
        '
        'TblLocBindingSource
        '
        Me.TblLocBindingSource.DataMember = "tblLoc"
        Me.TblLocBindingSource.DataSource = Me.DsAll
        '
        'DsAll
        '
        Me.DsAll.DataSetName = "dsAll"
        Me.DsAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLocTableAdapter
        '
        Me.TblLocTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(402, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'txtHowMany
        '
        Me.txtHowMany.Location = New System.Drawing.Point(147, 85)
        Me.txtHowMany.Name = "txtHowMany"
        Me.txtHowMany.Size = New System.Drawing.Size(100, 22)
        Me.txtHowMany.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "How Many stops"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Line"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(296, 89)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(88, 17)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "LineRunning"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 416)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHowMany)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TblLocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DsAll As DMSEventCreatorUtility.dsAll
    Friend WithEvents TblLocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblLocTableAdapter As DMSEventCreatorUtility.dsAllTableAdapters.tblLocTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHowMany As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
