﻿Public Class frmAddQuiz
    Private Sub frmAddQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'QuizDataSet.Values' table. You can move, or remove it, as needed.
        'Me.ValuesTableAdapter.Fill(Me.QuizDataSet.Values)
        ''TODO: This line of code loads data into the 'QuizDataSet.TLE' table. You can move, or remove it, as needed.
        'Me.TLETableAdapter.Fill(Me.QuizDataSet.TLE)
        ''TODO: This line of code loads data into the 'QuizDataSet.Science' table. You can move, or remove it, as needed.
        'Me.ScienceTableAdapter.Fill(Me.QuizDataSet.Science)
        ''TODO: This line of code loads data into the 'QuizDataSet.Math' table. You can move, or remove it, as needed.
        'Me.MathTableAdapter.Fill(Me.QuizDataSet.Math)
        ''TODO: This line of code loads data into the 'QuizDataSet.Mapeh' table. You can move, or remove it, as needed.
        'Me.MapehTableAdapter.Fill(Me.QuizDataSet.Mapeh)
        ''TODO: This line of code loads data into the 'QuizDataSet.Filipino' table. You can move, or remove it, as needed.
        'Me.FilipinoTableAdapter.Fill(Me.QuizDataSet.Filipino)
        ''TODO: This line of code loads data into the 'QuizDataSet.English' table. You can move, or remove it, as needed.
        'Me.EnglishTableAdapter.Fill(Me.QuizDataSet.English)
        ''TODO: This line of code loads data into the 'QuizDataSet.Copy_Of_Math' table. You can move, or remove it, as needed.
        'Me.Copy_Of_MathTableAdapter.Fill(Me.QuizDataSet.Copy_Of_Math)
        ''TODO: This line of code loads data into the 'QuizDataSet.Computer' table. You can move, or remove it, as needed.
        'Me.ComputerTableAdapter.Fill(Me.QuizDataSet.Computer)
        ''TODO: This line of code loads data into the 'QuizDataSet.AP' table. You can move, or remove it, as needed.
        'Me.APTableAdapter.Fill(Me.QuizDataSet.AP)

    End Sub

    Private Sub cboSubj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubj.SelectedIndexChanged
        'TODO: This line of code loads data into the 'QuizDataSet.Values' table. You can move, or remove it, as needed.
        Me.ValuesTableAdapter.Fill(Me.QuizDataSet.Values)
        'TODO: This line of code loads data into the 'QuizDataSet.TLE' table. You can move, or remove it, as needed.
        Me.TLETableAdapter.Fill(Me.QuizDataSet.TLE)
        'TODO: This line of code loads data into the 'QuizDataSet.Science' table. You can move, or remove it, as needed.
        Me.ScienceTableAdapter.Fill(Me.QuizDataSet.Science)
        'TODO: This line of code loads data into the 'QuizDataSet.Math' table. You can move, or remove it, as needed.
        Me.MathTableAdapter.Fill(Me.QuizDataSet.Math)
        'TODO: This line of code loads data into the 'QuizDataSet.Mapeh' table. You can move, or remove it, as needed.
        Me.MapehTableAdapter.Fill(Me.QuizDataSet.Mapeh)
        'TODO: This line of code loads data into the 'QuizDataSet.Filipino' table. You can move, or remove it, as needed.
        Me.FilipinoTableAdapter.Fill(Me.QuizDataSet.Filipino)
        'TODO: This line of code loads data into the 'QuizDataSet.English' table. You can move, or remove it, as needed.
        Me.EnglishTableAdapter.Fill(Me.QuizDataSet.English)
        'TODO: This line of code loads data into the 'QuizDataSet.Copy_Of_Math' table. You can move, or remove it, as needed.
        Me.Copy_Of_MathTableAdapter.Fill(Me.QuizDataSet.Copy_Of_Math)
        'TODO: This line of code loads data into the 'QuizDataSet.Computer' table. You can move, or remove it, as needed.
        Me.ComputerTableAdapter.Fill(Me.QuizDataSet.Computer)
        'TODO: This line of code loads data into the 'QuizDataSet.AP' table. You can move, or remove it, as needed.
        Me.APTableAdapter.Fill(Me.QuizDataSet.AP)

        BSquiz.DataMember = cboSubj.Text
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BSquiz.AddNew()
        txtID.Text = DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value + 1
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Validate()
        BSquiz.EndEdit()
        UpdateData()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        BSquiz.RemoveCurrent()
    End Sub

    Public Sub UpdateData()
        If cboSubj.Text = "Math" Then
            MathTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Science" Then
            ScienceTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "AP" Then
            APTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Computer" Then
            ComputerTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "English" Then
            EnglishTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Filipino" Then
            FilipinoTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Mapeh" Then
            MapehTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "TLE" Then
            TLETableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Values" Then
            ValuesTableAdapter.Update(QuizDataSet)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtQ.Clear()
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtD.Clear()
        txtCorrect.Clear()
        txtNotes.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmQuiz.Show()
    End Sub
End Class