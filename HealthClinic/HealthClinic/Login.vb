Public Class Login
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql, UsernameString, PasswordString As String
    Dim a, max As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserName.Text = "" Or Psw.Text = "" Then
            MessageBox.Show("Please fill in all information.")
            Exit Sub
        End If

        If HU.Checked = True Then
            HGetData()
            For a = 0 To max
                UsernameString = ds.Tables("HLogin").Rows(a).Item(0)
                PasswordString = ds.Tables("HLogin").Rows(a).Item(1)
                If UserName.Text = UsernameString Then

                    If Psw.Text = PasswordString Then
                        FormH.Show()
                        Me.Close()
                        Exit Sub

                    End If
                End If
            Next
            MessageBox.Show("Wrong User Name or Password")
        Else
            BGetData()
            For a = 0 To max
                UsernameString = ds.Tables("BLogin").Rows(a).Item(0)
                PasswordString = ds.Tables("BLogin").Rows(a).Item(1)
                If UserName.Text = UsernameString Then

                    If Psw.Text = PasswordString Then
                        FormB.Show()
                        Me.Close()
                        Exit Sub

                    End If
                End If
            Next
            MessageBox.Show("Wrong User Name or Password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub BU_CheckedChanged(sender As Object, e As EventArgs) Handles BU.CheckedChanged

    End Sub

    Sub BGetData()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        'Dim Filenameremove As String = "\bin\Debug"
        'fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM BLogin"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "BLogin")
        con.Close()
        max = ds.Tables("BLogin").Rows.Count
        max -= 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BU.Checked = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        HU.Checked = True
    End Sub

    Sub HGetData()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        'Dim Filenameremove As String = "\bin\Debug"
        'fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM HLogin"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "HLogin")
        con.Close()
        max = ds.Tables("HLogin").Rows.Count
        max -= 1
    End Sub

    Private Sub UserName_Click(sender As Object, e As EventArgs) Handles UserName.Click
        UserName.SelectAll()
    End Sub

    Private Sub Psw_Click(sender As Object, e As EventArgs) Handles Psw.Click
        Psw.SelectAll()
    End Sub
End Class