﻿Public Class frmUser
    Dim newUser As Boolean = False
    Dim userFile As String = Application.StartupPath & "\user.txt"
    Dim userList As String
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreader As New System.IO.StreamReader(userFile)
        userList = objreader.ReadToEnd
        cboUser.Items.AddRange(IO.File.ReadAllLines(userFile))
        objreader.Close()
    End Sub
    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUser.SelectedIndexChanged
        If cboUser.Items.Contains(cboUser.Text) Then
            btnLogin.Enabled = True
            newUser = False
        End If

        If cboUser.Text = "<Add new user>" Then
            newUser = True
            cboUser.Text = ""
            btnExit.Text = "true"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userReady As Boolean = False
        If cboUser.Text = "Admin" Then
            frmAddQuiz.Show()
            frmAddQuiz.WindowState = FormWindowState.Maximized
            Close()
        ElseIf cboUser.Text.Length > 1 Then
            userReady = True
            If newUser = True Then
                If cboUser.Items.Contains(cboUser.Text) Then
                    MsgBox("Username already taken!", MsgBoxStyle.Exclamation, "User")
                    userReady = False
                Else
                    cboUser.Items.Add(cboUser.Text)

                    Dim objWriter As New System.IO.StreamWriter(userFile)
                    objWriter.Write(cboUser.Text & vbCrLf & userList)
                    objWriter.Close()
                    MsgBox(cboUser.Text & vbCrLf & userList)

                    userReady = True
                End If

            End If
            If userReady = True Then
                Form1.lblUser.Text = cboUser.Text
                Form1.Show()
                Close()
            End If

        Else
            MsgBox("Invalid Username, Please use another username.", vbExclamation, "Invalid")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub frmUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frmAddQuiz.Hide()

    End Sub
End Class