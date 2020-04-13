Public Class Form3
    Sub panggil()
        connection()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Table1")
        DataGridView1.DataSource = DS.Tables("Table1")
        DataGridView1.Enabled = True
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggil()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("TERIMAKASIH :)" & vbCrLf & "DAN SELALU JAGA KESEHATAN AGAR HIDUP LEBIH BAIK!!")
        End
    End Sub
End Class