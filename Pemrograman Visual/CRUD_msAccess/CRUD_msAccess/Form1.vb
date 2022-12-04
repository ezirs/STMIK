' Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim Conn As MySqlConnection

    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim connString As String


    Sub Koneksi()
        connString = "Server=127.0.0.1; Database=latihan_yorick_3c1; Uid=root; Pwd=''"
        Conn = New MySqlConnection(connString)

        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub getData()
        Koneksi()
        da = New MySqlDataAdapter("Select * from TBL_BARANG", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "TBL_BARANG")
        dgvListBarang.DataSource = (ds.Tables("TBL_BARANG"))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getData()
    End Sub


    Sub setError()
        End
    End Sub


    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click


        Dim msg As String = "Kolom kosong"
        If txtKodeBarang.Text = "" Then
            ErrorProvider1.SetError(txtKodeBarang, msg)
        Else
            ErrorProvider1.SetError(txtKodeBarang, "")
        End If

        If txtNamaBarang.Text = "" Then
            ErrorProvider1.SetError(txtNamaBarang, msg)
        Else
            ErrorProvider1.SetError(txtNamaBarang, "")
        End If

        If txtHarga.Text = "" Then
            ErrorProvider1.SetError(txtHarga, msg)
        Else
            ErrorProvider1.SetError(txtHarga, "")
        End If

        If txtJumlahStok.Text = "" Then
            ErrorProvider1.SetError(txtJumlahStok, msg)
        Else
            ErrorProvider1.SetError(txtJumlahStok, "")
        End If

        If cmbSatuan.Text = "" Then
            ErrorProvider1.SetError(cmbSatuan, msg)
        Else
            ErrorProvider1.SetError(cmbSatuan, "")
        End If

        If ErrorProvider1.GetError(txtKodeBarang) = "" And ErrorProvider1.GetError(txtNamaBarang) = "" And ErrorProvider1.GetError(txtHarga) = "" And ErrorProvider1.GetError(txtJumlahStok) = "" Then
            Dim CMD As MySqlCommand
            Call Koneksi()
            Dim simpan As String = "insert into TBL_BARANG values ('" & txtKodeBarang.Text & "', '" & txtNamaBarang.Text & "', '" & txtHarga.Text & "', '" & txtJumlahStok.Text & "', '" & cmbSatuan.Text & "')"
            CMD = New MySqlCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            getData()
        End If
    End Sub

    
    Private Sub txtKodeBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        txtKodeBarang.MaxLength = 6
        If e.KeyChar = Chr(16) Then
            Call Koneksi()
            Dim CMD As MySqlCommand
            Dim RD As MySqlDataReader
            CMD = New MySqlCommand("Select * Form TBL_BARANG where KodeBarang = '" & txtKodeBarang.Text & "'")
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("Kode Barang Tidak Ada, Silakan Coba lagi!")
                txtKodeBarang.Focus()
            Else
                txtNamaBarang.Text = RD.Item("NamaBarang")
                txtHarga.Text = RD.Item("HargaBarang")
                txtJumlahStok.Text = RD.Item("JumlahBarang")
                cmbSatuan.Text = RD.Item("SatuanBarang")
                txtNamaBarang.Focus()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call Koneksi()
        Dim CMD As MySqlCommand
        Dim edit As String = "update TBL_BARANG set NamaBarang='" & txtNamaBarang.Text & "', HargaBarang='" & txtHarga.Text & "', JumlahBarang='" & txtJumlahStok.Text & "', SatuanBarang='" & cmbSatuan.Text & "' where KodeBarang = '" & txtKodeBarang.Text & "'"
        CMD = New MySqlCommand(edit, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil di update")
        getData()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtKodeBarang.Text = "" Then
            MsgBox("Silakan Pilih data yang akan di hapus dengan Masukan KODE barang dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim CMD As MySqlCommand
                Dim hapus As String = "delete From TBL_BARANG where KodeBarang = '" & txtKodeBarang.Text & "'"
                CMD = New MySqlCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil di hapus")
                getData()
            End If
        End If
    End Sub
End Class
