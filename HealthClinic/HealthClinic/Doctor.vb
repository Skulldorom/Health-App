Public Class Doctor
    Dim p1 As Boolean = True
    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filltable()
        Panel1.Hide()
    End Sub

    Sub filltable()
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String

        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM Staff"
        da = New OleDb.OleDbDataAdapter(sql, con)
        Dim DBDT As New DataTable
        Try
            da.Fill(DBDT)
            con.Close()
            DataGridView1.DataSource = DBDT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If p1 = True Then
            Panel1.Show()
            Panel2.Hide()
            p1 = False
        Else
            filltable()
            Panel2.Show()
            Panel1.Hide()
            p1 = True
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String

        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"


        con.Open()
        sql = "INSERT INTO Staff Values (?,?,?)"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, con)
        cmd.Parameters.Add(New OleDb.OleDbParameter("DoctorID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("FirstName", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("LastName", CType(TextBox3.Text, String)))



        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            MessageBox.Show("Doctor Added.")
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class