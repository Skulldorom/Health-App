Public Class Patient
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim a, max As Integer

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        PanelHider()
        Panel1.Show()
    End Sub

    Sub PanelHider()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Dim found As Boolean = False
        Dim namestring As String
        For a = 0 To max
            namestring = ds.Tables("Patient").Rows(a).Item(2)
            If SearchB.Text = namestring Then
                found = True
            End If
        Next
        If found = False Then
            MessageBox.Show("Patient Name not found")
        End If
        filltable()
        PanelHider()
        Panel2.Show()
    End Sub

    Private Sub cancelbtn1_Click(sender As Object, e As EventArgs) Handles cancelbtn1.Click
        Me.Close()
    End Sub

    Private Sub addp_Click(sender As Object, e As EventArgs) Handles addp.Click
        PanelHider()
        Panel3.Show()
    End Sub

    Private Sub cancelbtn2_Click(sender As Object, e As EventArgs) Handles cancelbtn2.Click
        PanelHider()
        Panel1.Show()
    End Sub

    Sub filltable()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"


        con.Open()
        sql = "SELECT * FROM Patient WHERE LastName ='" + SearchB.Text + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        Dim DBDT As New DataTable
        da.Fill(DBDT)
        con.Close()
        DataGridView1.DataSource = DBDT
    End Sub

    Private Sub Enterbtn_Click(sender As Object, e As EventArgs) Handles Enterbtn.Click
        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(TextBox4.Text) Or String.IsNullOrEmpty(TextBox5.Text) Then
            MessageBox.Show("Please fill in all details.")
            Exit Sub
        End If

        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"


        con.Open()
        sql = "INSERT INTO Patient Values (?,?,?,?,?)"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDb.OleDbParameter("PatientID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("FirstName", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("LastName", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Telephone", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Email", CType(TextBox5.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Patient Added.")
            GetData()
            PanelHider()
            Panel1.Show()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelHider()
        Panel1.Show()
    End Sub

    Sub GetData()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM Patient"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Patient")
        con.Close()
        max = ds.Tables("Patient").Rows.Count
        max -= 1
    End Sub
End Class