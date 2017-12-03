<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtrete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filtrete))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGetStatus = New System.Windows.Forms.ToolStripButton()
        Me.tsbFanState = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lFanMode = New System.Windows.Forms.Label()
        Me.lMode = New System.Windows.Forms.Label()
        Me.lInsideTemp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lOutside = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lOutsideTemp = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lSelectedTemp = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGetStatus, Me.tsbFanState})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(759, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGetStatus
        '
        Me.tsbGetStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGetStatus.Image = CType(resources.GetObject("tsbGetStatus.Image"), System.Drawing.Image)
        Me.tsbGetStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGetStatus.Name = "tsbGetStatus"
        Me.tsbGetStatus.Size = New System.Drawing.Size(64, 22)
        Me.tsbGetStatus.Text = "Get Status"
        '
        'tsbFanState
        '
        Me.tsbFanState.Checked = True
        Me.tsbFanState.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbFanState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbFanState.Image = CType(resources.GetObject("tsbFanState.Image"), System.Drawing.Image)
        Me.tsbFanState.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFanState.Name = "tsbFanState"
        Me.tsbFanState.Size = New System.Drawing.Size(30, 22)
        Me.tsbFanState.Text = "Fan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(759, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(759, 394)
        Me.SplitContainer1.SplitterDistance = 503
        Me.SplitContainer1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lFanMode, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lMode, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lInsideTemp, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lOutside, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lOutsideTemp, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(503, 394)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lFanMode
        '
        Me.lFanMode.AutoSize = True
        Me.lFanMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFanMode.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lFanMode.Location = New System.Drawing.Point(254, 207)
        Me.lFanMode.Name = "lFanMode"
        Me.lFanMode.Size = New System.Drawing.Size(246, 127)
        Me.lFanMode.TabIndex = 10
        Me.lFanMode.Text = "Label4"
        Me.lFanMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lMode
        '
        Me.lMode.AutoSize = True
        Me.lMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lMode.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMode.Location = New System.Drawing.Point(3, 207)
        Me.lMode.Name = "lMode"
        Me.lMode.Size = New System.Drawing.Size(245, 127)
        Me.lMode.TabIndex = 9
        Me.lMode.Text = "Label4"
        Me.lMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lInsideTemp
        '
        Me.lInsideTemp.AutoSize = True
        Me.lInsideTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lInsideTemp.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lInsideTemp.Location = New System.Drawing.Point(254, 40)
        Me.lInsideTemp.Name = "lInsideTemp"
        Me.lInsideTemp.Size = New System.Drawing.Size(246, 127)
        Me.lInsideTemp.TabIndex = 8
        Me.lInsideTemp.Text = "Label4"
        Me.lInsideTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inside"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lOutside
        '
        Me.lOutside.AutoSize = True
        Me.lOutside.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lOutside.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lOutside.Location = New System.Drawing.Point(3, 0)
        Me.lOutside.Name = "lOutside"
        Me.lOutside.Size = New System.Drawing.Size(245, 40)
        Me.lOutside.TabIndex = 0
        Me.lOutside.Text = "Outside"
        Me.lOutside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mode"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fan Mode"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lOutsideTemp
        '
        Me.lOutsideTemp.AutoSize = True
        Me.lOutsideTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lOutsideTemp.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lOutsideTemp.Location = New System.Drawing.Point(3, 40)
        Me.lOutsideTemp.Name = "lOutsideTemp"
        Me.lOutsideTemp.Size = New System.Drawing.Size(245, 127)
        Me.lOutsideTemp.TabIndex = 7
        Me.lOutsideTemp.Text = "Label4"
        Me.lOutsideTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lSelectedTemp, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 337)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(245, 54)
        Me.TableLayoutPanel3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Selected Temperature"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lSelectedTemp
        '
        Me.lSelectedTemp.AutoSize = True
        Me.lSelectedTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lSelectedTemp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSelectedTemp.Location = New System.Drawing.Point(3, 15)
        Me.lSelectedTemp.Name = "lSelectedTemp"
        Me.lSelectedTemp.Size = New System.Drawing.Size(239, 39)
        Me.lSelectedTemp.TabIndex = 1
        Me.lSelectedTemp.Text = "Label5"
        Me.lSelectedTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rtbOutput, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.00508!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.99493!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(252, 394)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'rtbOutput
        '
        Me.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbOutput.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOutput.Location = New System.Drawing.Point(3, 70)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(246, 321)
        Me.rtbOutput.TabIndex = 0
        Me.rtbOutput.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Filtrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 441)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Filtrete"
        Me.Text = "Filtrete"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tsbGetStatus As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents tsbFanState As ToolStripButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lOutside As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lOutsideTemp As Label
    Friend WithEvents lFanMode As Label
    Friend WithEvents lMode As Label
    Friend WithEvents lInsideTemp As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents lSelectedTemp As Label
End Class
