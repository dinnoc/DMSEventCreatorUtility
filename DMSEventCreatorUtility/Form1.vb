Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1


    Public rowid As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsAll.tblLoc' table. You can move, or remove it, as needed.
        Me.TblLocTableAdapter.Fill(Me.DsAll.tblLoc)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "Start" Then
            Button1.Text = "Stop"
            Timer1.Start()
        Else
            Button1.Text = "Start"
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = rowid

        'insert into table event start and end time
        Dim adapEvent As New dsAllTableAdapters.QueriesTableAdapter

        If lblStatus.Text = "LineRunning" Then
            adapEvent.InsertStartEvent(Now, ComboBox1.SelectedValue, 99, 0, -1, 0, rowid)
            lblStatus.Text = "LineStopped"
        Else
            adapEvent.InsertEndEvent(Now, 0, 0, rowid)
            lblStatus.Text = "LineRunning"
        End If

    End Sub

End Class