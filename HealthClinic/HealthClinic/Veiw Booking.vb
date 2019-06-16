Public Class Veiw_Booking
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddBooking.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String

        Dim fileName As String = My.Application.Info.DirectoryPath()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT BookingID, Bookings.PatientID, Patient.LastName, Staff.DoctorID,Staff.LastName, BDate FROM ((Bookings INNER JOIN Staff ON Bookings.DoctorID = Staff.DoctorID) INNER JOIN Patient ON Bookings.PatientID = Patient.PatientID) WHERE Staff.Lastname = '" + TextBox1.Text + "'"
        da = New OleDb.OleDbDataAdapter(Sql, con)
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

    Private Sub Veiw_Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub
End Class