Public Class Visitation
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim a, max As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filltable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddVisitation.Show()
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Dim choice As String = ""
        Dim support As String = "'"
        If RadioButton3.Checked = True Then
            choice = "Staff.Lastname"
        ElseIf RadioButton2.Checked = True Then
            choice = "Patient.Lastname"
        ElseIf RadioButton1.Checked = True Then
            choice = "VisitationID"
            support = ""
        End If

        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT VisitationID, Visitation.PatientID, Patient.LastName, Staff.LastName, VDate, Reason FROM ((Visitation INNER JOIN Staff ON Visitation.DoctorID = Staff.DoctorID) INNER JOIN Patient ON Visitation.PatientID = Patient.PatientID) WHERE " + choice + "= " + support + TextBox1.Text + support
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

    Private Sub Visitation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filltable()
    End Sub

    Sub filltable()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT VisitationID, Visitation.PatientID, Patient.LastName, Staff.LastName, VDate, Reason FROM ((Visitation INNER JOIN Staff ON Visitation.DoctorID = Staff.DoctorID) INNER JOIN Patient ON Visitation.PatientID = Patient.PatientID)"
        da = New OleDb.OleDbDataAdapter(sql, con)
        Dim DBDT As New DataTable
        da.Fill(DBDT)
        con.Close()
        DataGridView1.DataSource = DBDT
    End Sub
End Class