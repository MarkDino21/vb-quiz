﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.cboUser)
        Me.Panel1.Location = New System.Drawing.Point(16, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 192)
        Me.Panel1.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SkyBlue
        Me.btnLogin.Enabled = False
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(151, 120)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(118, 40)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(275, 120)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 40)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cboUser
        '
        Me.cboUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(24, 42)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(369, 28)
        Me.cboUser.TabIndex = 0
        Me.cboUser.Text = "Select User Here . . ."
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 308)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmUser"
        Me.Text = "frmUser"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cboUser As ComboBox
End Class
