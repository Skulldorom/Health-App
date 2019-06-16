Public Class AddBooking
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql, UsernameString, PasswordString As String
    Dim a, max As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(DateTimePicker1.Text) Then
            MessageBox.Show("Please fill in all details.")
            Exit Sub
        End If

        Dim con1 As New OleDb.OleDbConnection
        Dim ds1 As New DataSet
        Dim da1 As OleDb.OleDbDataAdapter
        Dim sql1 As String
        Dim a1, max1 As Integer
        Dim found1 As Boolean = False
        Dim namestring1 As String

        Dim fileName1 As String = My.Application.Info.DirectoryPath()
        fileName1 += "\HealthClinicDB.accdb"
        con1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName1 & ";Persist Security Info=False;"

        con1.Open()
        sql1 = "SELECT * FROM Patient"
        da1 = New OleDb.OleDbDataAdapter(sql1, con1)

        da1.Fill(ds1, "Patient")
        con1.Close()
        max1 = ds1.Tables("Patient").Rows.Count
        max1 -= 1

        For a1 = 0 To max1
            namestring1 = ds1.Tables("Patient").Rows(a1).Item(0)


            If TextBox2.Text = namestring1 Then
                found1 = True
            End If
        Next
        If found1 = False Then
            MessageBox.Show("Patient ID not found")
            Exit Sub
        End If

        Dim con2 As New OleDb.OleDbConnection
        Dim ds2 As New DataSet
        Dim da2 As OleDb.OleDbDataAdapter
        Dim sql2 As String
        Dim a2, max2 As Integer
        Dim found2 As Boolean = False
        Dim docstring As String

        Dim fileName2 As String = My.Application.Info.DirectoryPath()
        fileName2 += "\HealthClinicDB.accdb"
        con2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName2 & ";Persist Security Info=False;"

        con2.Open()
        sql2 = "SELECT * FROM Staff"
        da2 = New OleDb.OleDbDataAdapter(sql2, con2)

        da2.Fill(ds2, "Staff")
        con2.Close()
        max2 = ds2.Tables("Staff").Rows.Count
        max2 -= 1

        For a2 = 0 To max2
            docstring = ds2.Tables("Staff").Rows(a2).Item(0)


            If TextBox3.Text = docstring Then
                found2 = True
            End If
        Next
        If found2 = False Then
            MessageBox.Show("Doctor ID not found")
            Exit Sub
        End If

        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"


        con.Open()
        sql = "INSERT INTO Bookings Values (?,?,?,?)"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDb.OleDbParameter("BookingID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("PatientID", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("DocotorID", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("BDate", CType(DateTimePicker1.Text, String)))


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Booking Added.")
            Me.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class