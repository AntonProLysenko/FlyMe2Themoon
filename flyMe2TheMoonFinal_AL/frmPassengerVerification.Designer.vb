﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengerVerification
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblErrormessage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPassengerID = New System.Windows.Forms.TextBox()
        Me.btmShowPass = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(187, 378)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(418, 88)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Sign in"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(187, 495)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(418, 88)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Sign up"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btmShowPass)
        Me.GroupBox1.Controls.Add(Me.lblErrormessage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassengerID)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(413, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(940, 602)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign in"
        '
        'lblErrormessage
        '
        Me.lblErrormessage.AutoSize = True
        Me.lblErrormessage.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrormessage.Location = New System.Drawing.Point(264, 310)
        Me.lblErrormessage.Name = "lblErrormessage"
        Me.lblErrormessage.Size = New System.Drawing.Size(0, 48)
        Me.lblErrormessage.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 48)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 48)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Passenger ID"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(377, 249)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(345, 55)
        Me.txtPassword.TabIndex = 3
        '
        'txtPassengerID
        '
        Me.txtPassengerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassengerID.Location = New System.Drawing.Point(377, 125)
        Me.txtPassengerID.Name = "txtPassengerID"
        Me.txtPassengerID.Size = New System.Drawing.Size(345, 55)
        Me.txtPassengerID.TabIndex = 2
        '
        'btmShowPass
        '
        Me.btmShowPass.BackColor = System.Drawing.SystemColors.Control
        Me.btmShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmShowPass.Location = New System.Drawing.Point(749, 249)
        Me.btmShowPass.Margin = New System.Windows.Forms.Padding(0)
        Me.btmShowPass.Name = "btmShowPass"
        Me.btmShowPass.Size = New System.Drawing.Size(83, 58)
        Me.btmShowPass.TabIndex = 7
        Me.btmShowPass.Text = "👀"
        Me.btmShowPass.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btmShowPass.UseVisualStyleBackColor = False
        '
        'frmPassengerVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1737, 667)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(1765, 746)
        Me.Name = "frmPassengerVerification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passenger Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPassengerID As TextBox
    Friend WithEvents lblErrormessage As Label
    Friend WithEvents btmShowPass As Button
    Friend WithEvents Timer1 As Timer
End Class
