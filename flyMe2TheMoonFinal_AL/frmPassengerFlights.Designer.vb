﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengerFlights
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
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lstUpcomingFlights = New System.Windows.Forms.ListBox()
        Me.lblMilesTotal = New System.Windows.Forms.Label()
        Me.lblTotalMIles = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(1028, 550)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(215, 87)
        Me.btnDone.TabIndex = 0
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lstUpcomingFlights
        '
        Me.lstUpcomingFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUpcomingFlights.FormattingEnabled = True
        Me.lstUpcomingFlights.ItemHeight = 32
        Me.lstUpcomingFlights.Location = New System.Drawing.Point(28, 152)
        Me.lstUpcomingFlights.Name = "lstUpcomingFlights"
        Me.lstUpcomingFlights.Size = New System.Drawing.Size(2213, 388)
        Me.lstUpcomingFlights.TabIndex = 1
        '
        'lblMilesTotal
        '
        Me.lblMilesTotal.AutoSize = True
        Me.lblMilesTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesTotal.Location = New System.Drawing.Point(51, 93)
        Me.lblMilesTotal.Name = "lblMilesTotal"
        Me.lblMilesTotal.Size = New System.Drawing.Size(388, 32)
        Me.lblMilesTotal.TabIndex = 2
        Me.lblMilesTotal.Text = "Upcoming Flights Total Miles:"
        '
        'lblTotalMIles
        '
        Me.lblTotalMIles.AutoSize = True
        Me.lblTotalMIles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMIles.Location = New System.Drawing.Point(440, 93)
        Me.lblTotalMIles.Name = "lblTotalMIles"
        Me.lblTotalMIles.Size = New System.Drawing.Size(31, 32)
        Me.lblTotalMIles.TabIndex = 3
        Me.lblTotalMIles.Text = "0"
        '
        'frmPassengerFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2268, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotalMIles)
        Me.Controls.Add(Me.lblMilesTotal)
        Me.Controls.Add(Me.lstUpcomingFlights)
        Me.Controls.Add(Me.btnDone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(1970, 684)
        Me.Name = "frmPassengerFlights"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Future Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDone As Button
    Friend WithEvents lstUpcomingFlights As ListBox
    Friend WithEvents lblMilesTotal As Label
    Friend WithEvents lblTotalMIles As Label
End Class
