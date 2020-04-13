Public Class Form2
    Dim sql As String
    Sub panggil()
        connection()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Table1")
        DataGridView1.DataSource = DS.Tables("Table1")
        DataGridView1.Enabled = True




    End Sub

    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call connection()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sql
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("KLIK KEGIATAN YANG ANDA LAKUKAN")
        Call panggil()

    End Sub

    Dim t As Integer

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            t += 1
        Else
            t -= 1
        End If
    End Sub
    Dim resiko As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKAN NAMA ANDA!")
        ElseIf TextBox2.Text = "" Then
            MsgBox("MASUKAN NIS ANDA!")
        ElseIf TextBox3.Text = "" Then
            MsgBox("MASUKAN ROMBEL ANDA!")
        Else
            If t <= 7 Then
                resiko = "Resiko Rendah"
                Panel1.BackColor = Color.Green
                Label7.Text = t
                Label5.Text = resiko
            ElseIf t <= 14 Then
                resiko = "Resiko Sedang"
                Panel1.BackColor = Color.Yellow
                Label7.Text = t
                Label5.Text = resiko
            ElseIf t <= 21 Then
                resiko = "Resiko Tinggi"
                Panel1.BackColor = Color.Red
                Label7.Text = t
                Label5.Text = resiko
            End If
            sql = "insert into Table1(name_s,nis,rombel,resiko)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & resiko & " ')"
            Call jalan()
            MsgBox("Data Tersimpan,Resiko terkena covid anda, " & resiko & vbCrLf & "JUMLAH CEKLIS " & t & vbCrLf & "TETAPLAH JAGA KESEHATAN:)")
            Call panggil()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            Label7.Text = "-"
            Label5.Text = "RESIKO"
            Panel1.BackColor = Color.White


        End If



    End Sub
    Dim nisbaru As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "delete from Table1 where nis = '" & nisbaru & "'"
        Call jalan()
        MsgBox("Data Anda sudah dihapus")
        Call panggil()
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("TERIMAKASIH :)" & vbCrLf & "DAN SELALU JAGA KESEHATAN AGAR HIDUP LEBIH BAIK!!")
        End
    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim a As Integer
        a = DataGridView1.CurrentRow.Index

        nisbaru = DataGridView1.Item(1, a).Value
    End Sub
End Class