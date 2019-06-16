Public Class ManageLogin


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If UserName.Text = "" Or Psw.Text = "" Then
            MessageBox.Show("Please fill in all information.")
            Exit Sub
        End If


        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql, UsernameString, PasswordString As String
        Dim a, max As Integer
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

        For a = 0 To max
            UsernameString = ds.Tables("HLogin").Rows(a).Item(0)
            PasswordString = ds.Tables("HLogin").Rows(a).Item(1)
            If UserName.Text = UsernameString Then
                If Psw.Text = PasswordString Then
                    Panel2.Hide()
                    Panel3.Show()
                    Exit Sub

                End If
            End If
        Next
        MessageBox.Show("Wrong User Name or Password")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub UserName_Click(sender As Object, e As EventArgs) Handles UserName.Click
        UserName.SelectAll()
    End Sub

    Private Sub Psw_Click(sender As Object, e As EventArgs) Handles Psw.Click
        Psw.SelectAll()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles EditP.Click
        Panel3.Show()
        Panel4.Hide()
    End Sub

    Private Sub AddSwitch_Click(sender As Object, e As EventArgs) Handles AddSwitch.Click
        Panel4.Show()
        Panel3.Hide()
    End Sub

    Private Sub UpdateP_Click(sender As Object, e As EventArgs) Handles UpdateP.Click
        If UNP.Text <> UCP.Text Then
            MessageBox.Show("Passwords Must Match")
            Exit Sub
        End If

        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql, UsernameString, PasswordString As String
        Dim a, max As Integer
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim OP As Boolean = False
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM HLogin"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "HLogin")
        con.Close()
        max = ds.Tables("HLogin").Rows.Count
        max -= 1

        For a = 0 To max
            UsernameString = ds.Tables("HLogin").Rows(a).Item(0)
            PasswordString = ds.Tables("HLogin").Rows(a).Item(1)
            If UserName.Text = UsernameString Then
                If UOP.Text = PasswordString Then
                    OP = True
                End If
            End If
        Next

        If OP = False Then
            MessageBox.Show("Old Password does not match")
            Exit Sub
        End If


        con.Open()
        Dim str As String
        str = "Update [HLogin] set [Password] = '" & UNP.Text & "' Where [Username] = '" & UserName.Text & "'"
        Dim cmd = New OleDb.OleDbCommand(str, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Password Updated")
            UOP.Clear()
            UNP.Clear()
            UCP.Clear()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ManageLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Hide()
        Panel4.Hide()
    End Sub

    Private Sub CreateAccount_Click(sender As Object, e As EventArgs) Handles CreateAccount.Click
        If AP.Text <> ACP.Text Then
            MessageBox.Show("Passwords Must Match")
            Exit Sub
        End If
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim sql As String
        fileName += "\HealthClinicDB.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        If RadioButton1.Checked = True Then

            con.Open()
            sql = "INSERT INTO BLogin Values (?,?)"
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
            cmd.Parameters.Add(New OleDb.OleDbParameter("UserName", CType(AUsername.Text, String)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("Password", CType(AP.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                MessageBox.Show("Account Created.")
                AUsername.Clear()
                AP.Clear()
                ACP.Clear()
            Catch ex As Exception
                con.Close()
                MessageBox.Show(ex.Message)
            End Try
        ElseIf RadioButton2.Checked = True Then
            con.Open()
            sql = "INSERT INTO HLogin Values (?,?)"
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
            cmd.Parameters.Add(New OleDb.OleDbParameter("UserName", CType(AUsername.Text, String)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("Password", CType(AP.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                MessageBox.Show("Account Created.")
                AUsername.Clear()
                AP.Clear()
                ACP.Clear()
            Catch ex As Exception
                con.Close()
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
End Class