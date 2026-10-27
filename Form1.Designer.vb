<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picPlayer = New PictureBox()
        picFallingObject = New PictureBox()
        lblScore = New Label()
        lblLives = New Label()
        btnStart = New Button()
        btnRestart = New Button()
        lblGameOver = New Label()
        gameTimer = New Timer(components)
        CType(picPlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFallingObject, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picPlayer
        ' 
        picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), Image)
        picPlayer.InitialImage = CType(resources.GetObject("picPlayer.InitialImage"), Image)
        picPlayer.Location = New Point(327, 346)
        picPlayer.Name = "picPlayer"
        picPlayer.Size = New Size(78, 76)
        picPlayer.SizeMode = PictureBoxSizeMode.StretchImage
        picPlayer.TabIndex = 0
        picPlayer.TabStop = False
        ' 
        ' picFallingObject
        ' 
        picFallingObject.Image = CType(resources.GetObject("picFallingObject.Image"), Image)
        picFallingObject.InitialImage = Nothing
        picFallingObject.Location = New Point(327, 40)
        picFallingObject.Name = "picFallingObject"
        picFallingObject.Size = New Size(55, 58)
        picFallingObject.SizeMode = PictureBoxSizeMode.StretchImage
        picFallingObject.TabIndex = 0
        picFallingObject.TabStop = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(18, 28)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(56, 25)
        lblScore.TabIndex = 1
        lblScore.Text = "Score"
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLives.Location = New Point(18, 73)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(50, 25)
        lblLives.TabIndex = 1
        lblLives.Text = "Lives"
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(13, 137)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(87, 43)
        btnStart.TabIndex = 2
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(13, 206)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(87, 43)
        btnRestart.TabIndex = 2
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' lblGameOver
        ' 
        lblGameOver.AutoSize = True
        lblGameOver.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGameOver.Location = New Point(13, 276)
        lblGameOver.Name = "lblGameOver"
        lblGameOver.Size = New Size(101, 25)
        lblGameOver.TabIndex = 1
        lblGameOver.Text = "Game Over"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRestart)
        Controls.Add(btnStart)
        Controls.Add(lblGameOver)
        Controls.Add(lblLives)
        Controls.Add(lblScore)
        Controls.Add(picFallingObject)
        Controls.Add(picPlayer)
        Name = "Form1"
        Text = "Form1"
        CType(picPlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(picFallingObject, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picFallingObject As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblGameOver As Label
    Friend WithEvents gameTimer As Timer

End Class
