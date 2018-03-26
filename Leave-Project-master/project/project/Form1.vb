Imports System.Data
Public Class loginform
    Sub enability()
        If tbusername.TextLength > 0 And tbpassword.TextLength > 0 Then
            butlogin.Enabled = True
        Else
            butlogin.Enabled = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butcancel.Click
        Me.Close()
    End Sub

    Private Sub butlogin_Click(sender As Object, e As EventArgs) Handles butlogin.Click
        Dim conn As New OleDb.OleDbConnection
        Dim query As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim daad As New OleDb.OleDbDataAdapter
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jitinjg\Desktop\Leave-Project-master\try.mdb;User ID=admin"

        conn.Open()
        query = New OleDb.OleDbCommand("Select * FROM login WHERE username = " + tbusername.Text)
        dr = query.ExecuteReader()
        MsgBox("oooolalal")
        dr.Read()
        MsgBox("data 1 : " + dr(0) + Environment.NewLine + "data 2 : " + dr(1))
        conn.Close()
    End Sub

    Private Sub ContentChanged(sender As Object, e As EventArgs) Handles tbusername.TextChanged, tbpassword.TextChanged
        enability()
    End Sub
End Class
