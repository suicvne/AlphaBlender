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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.MaskPictureBox = New System.Windows.Forms.PictureBox()
        Me.CombinedPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaskPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombinedPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(466, 432)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(466, 251)
        Me.SplitContainer2.SplitterDistance = 224
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CombinedPictureBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ImagePictureBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 251)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MaskPictureBox)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 251)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mask"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagePictureBox.Location = New System.Drawing.Point(3, 16)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(218, 232)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImagePictureBox.TabIndex = 0
        Me.ImagePictureBox.TabStop = False
        '
        'MaskPictureBox
        '
        Me.MaskPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaskPictureBox.Location = New System.Drawing.Point(3, 16)
        Me.MaskPictureBox.Name = "MaskPictureBox"
        Me.MaskPictureBox.Size = New System.Drawing.Size(232, 232)
        Me.MaskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MaskPictureBox.TabIndex = 1
        Me.MaskPictureBox.TabStop = False
        '
        'CombinedPictureBox
        '
        Me.CombinedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CombinedPictureBox.Location = New System.Drawing.Point(3, 16)
        Me.CombinedPictureBox.Name = "CombinedPictureBox"
        Me.CombinedPictureBox.Size = New System.Drawing.Size(460, 158)
        Me.CombinedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CombinedPictureBox.TabIndex = 2
        Me.CombinedPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 432)
        Me.Controls.Add(Me.SplitContainer1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "AlphaBlender Library Test (VB)"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaskPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombinedPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MaskPictureBox As PictureBox
    Friend WithEvents CombinedPictureBox As PictureBox
End Class
