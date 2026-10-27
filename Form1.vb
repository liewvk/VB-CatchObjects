Option Strict On

Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1

    Private ReadOnly rnd As New Random()
    Private ReadOnly fallingObjects As New List(Of PictureBox)()

    Private Const playerSpeed As Integer = 15
    Private Const spawnInterval As Integer = 900

    Private fallingSpeed As Integer = 5
    Private score As Integer = 0
    Private lives As Integer = 3
    Private spawnElapsed As Integer = 0
    Private gameOver As Boolean = True
    Private playArea As Control

    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' Use the same container as the player so that
        ' object and player coordinates match.
        playArea = picPlayer.Parent

        Me.KeyPreview = True
        Me.DoubleBuffered = True

        gameTimer.Stop()
        gameTimer.Interval = 20

        ' The designer object supplies the image and size.
        picFallingObject.Visible = False

        lblScore.Text = "Score: 0"
        lblLives.Text = "Lives: 3"
        lblGameOver.Visible = False
        btnRestart.Visible = False

        PositionPlayer()
    End Sub

    Private Sub PositionPlayer()
        picPlayer.Left =
            Math.Max(0,
                     (playArea.ClientSize.Width - picPlayer.Width) \ 2)

        picPlayer.Top =
            Math.Max(0,
                     playArea.ClientSize.Height - picPlayer.Height - 15)

        picPlayer.BringToFront()
    End Sub

    Private Sub StartGame()
        gameTimer.Stop()
        ClearFallingObjects()

        score = 0
        lives = 3
        fallingSpeed = 5
        spawnElapsed = 0
        gameOver = False

        lblScore.Text = "Score: 0"
        lblLives.Text = "Lives: 3"
        lblGameOver.Visible = False

        btnStart.Enabled = False
        btnRestart.Visible = False

        PositionPlayer()
        StartFallingObject()

        Me.ActiveControl = Nothing
        Me.Focus()

        gameTimer.Start()
    End Sub

    ' This event is essential: it runs the animation.
    Private Sub gameTimer_Tick(
        sender As Object,
        e As EventArgs
    ) Handles gameTimer.Tick

        If gameOver Then Return

        MoveFallingObjects()

        If gameOver Then Return

        spawnElapsed += gameTimer.Interval

        If spawnElapsed >= spawnInterval Then
            spawnElapsed = 0
            StartFallingObject()
        End If
    End Sub

    Private Sub StartFallingObject()
        Dim obj As New PictureBox()

        obj.Size = picFallingObject.Size
        obj.Image = picFallingObject.Image
        obj.SizeMode = picFallingObject.SizeMode
        obj.BackColor = picFallingObject.BackColor
        obj.TabStop = False

        ' Make an object visible even if no image was assigned.
        If obj.Image Is Nothing Then
            obj.BackColor = Color.Red
        End If

        Dim maxLeft As Integer =
            Math.Max(0, playArea.ClientSize.Width - obj.Width)

        obj.Location = New Point(rnd.Next(maxLeft + 1), -obj.Height)

        playArea.Controls.Add(obj)
        fallingObjects.Add(obj)
        obj.BringToFront()

        lblScore.BringToFront()
        lblLives.BringToFront()
    End Sub

    Private Sub MoveFallingObjects()
        ' Loop backwards so removing an object is safe.
        For i As Integer = fallingObjects.Count - 1 To 0 Step -1
            Dim obj As PictureBox = fallingObjects(i)

            obj.Top += fallingSpeed

            If obj.Bounds.IntersectsWith(picPlayer.Bounds) Then
                score += 10
                lblScore.Text = "Score: " & score.ToString()

                RemoveFallingObject(i)
                IncreaseDifficulty()

            ElseIf obj.Top >= playArea.ClientSize.Height Then
                lives -= 1
                lblLives.Text = "Lives: " & lives.ToString()

                RemoveFallingObject(i)

                If lives <= 0 Then
                    EndGame()
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub RemoveFallingObject(index As Integer)
        Dim obj As PictureBox = fallingObjects(index)

        fallingObjects.RemoveAt(index)
        playArea.Controls.Remove(obj)
        obj.Dispose()
    End Sub

    Private Sub ClearFallingObjects()
        For i As Integer = fallingObjects.Count - 1 To 0 Step -1
            RemoveFallingObject(i)
        Next
    End Sub

    Private Sub IncreaseDifficulty()
        ' Check the highest score first.
        If score >= 100 Then
            fallingSpeed = 10
        ElseIf score >= 50 Then
            fallingSpeed = 7
        Else
            fallingSpeed = 5
        End If
    End Sub

    ' Handles arrow keys even when a button has focus.
    Protected Overrides Function ProcessCmdKey(
        ByRef msg As Message,
        keyData As Keys
    ) As Boolean

        Dim key As Keys = keyData And Keys.KeyCode

        If Not gameOver AndAlso playArea IsNot Nothing Then
            Select Case key
                Case Keys.Left
                    picPlayer.Left =
                        Math.Max(0, picPlayer.Left - playerSpeed)

                    Return True

                Case Keys.Right
                    Dim maxLeft As Integer =
                        Math.Max(0,
                                 playArea.ClientSize.Width - picPlayer.Width)

                    picPlayer.Left =
                        Math.Min(maxLeft, picPlayer.Left + playerSpeed)

                    Return True
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub EndGame()
        gameOver = True
        gameTimer.Stop()

        lblGameOver.Text =
            "Game Over! Final Score: " & score.ToString()

        lblGameOver.Visible = True
        lblGameOver.BringToFront()

        btnStart.Enabled = True
        btnRestart.Visible = True
        btnRestart.BringToFront()
    End Sub

    Private Sub btnStart_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnStart.Click

        StartGame()
    End Sub

    Private Sub btnRestart_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRestart.Click

        StartGame()
    End Sub

    Private Sub Form1_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles MyBase.FormClosed

        gameTimer.Stop()
        ClearFallingObjects()
    End Sub

End Class