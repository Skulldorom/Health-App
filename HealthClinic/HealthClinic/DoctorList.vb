Public Class DoctorList
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim a, max As Integer
    Private Sub DoctorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filltable()
    End Sub

    Sub filltable()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"


        con.Open()
        sql = "SELECT * FROM Staff"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        Dim DBDT As New DataTable
        da.Fill(DBDT)
        con.Close()
        DataGridView1.DataSource = DBDT
    End Sub
End Class