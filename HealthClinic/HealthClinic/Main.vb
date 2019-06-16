Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.MdiParent = Me
        FormB.MdiParent = Me
        FormH.MdiParent = Me
        Patient.MdiParent = Me
        AddVisitation.MdiParent = Me
        DoctorList.MdiParent = Me
        AddBooking.MdiParent = Me
        Visitation.MdiParent = Me
        Veiw_Booking.MdiParent = Me
        ManageLogin.MdiParent = Me
        Doctor.MdiParent = Me
        Login.Show()
    End Sub
End Class
