Public Class Form1
    Dim barangList = New List(Of String)
    Dim hargaList = New List(Of Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelKaryawan.Visible = True
        panelPembelian.Visible = False
        panelPenjualan.Visible = False
    End Sub

    Private Sub BtnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnTambahKaryawan.Click
        With DataGridKaryawan
            Dim row As String() = New String() {TxtBoxNamaKaryawan.Text, CmbBoxGolonganKaryawan.SelectedItem.ToString(), TxtBoxGajiKaryawan.Text}
            .Rows.Add(row)
        End With
    End Sub

    Private Sub CmbBoxGolonganKaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxGolonganKaryawan.SelectedIndexChanged
        Dim selected = CmbBoxGolonganKaryawan.SelectedItem.ToString()

        If selected = "Golongan 1" Then
            TxtBoxGajiKaryawan.Text = "2.000.000"
        ElseIf selected = "Golongan 2" Then
            TxtBoxGajiKaryawan.Text = "2.500.000"
        ElseIf selected = "Golongan 1" Then
            TxtBoxGajiKaryawan.Text = "3.500.000"
        End If
    End Sub

    Private Sub BtnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles BtnHapusKaryawan.Click
        If DataGridKaryawan.CurrentRow.Index <> DataGridKaryawan.NewRowIndex Then
            DataGridKaryawan.Rows.RemoveAt(DataGridKaryawan.CurrentRow.Index)
        Else MsgBox("Tidak Ada Data Dipilih!")
        End If
    End Sub

    Private Sub BtnTambahBeli_Click(sender As Object, e As EventArgs) Handles BtnTambahBeli.Click
        With DataGridPembelian
            Dim row As String() = New String() {DateTimeBeli.Value.ToString("dd/MM/yyyy"), TxtBoxNamaBarangBeli.Text, TxtBoxJumlahBarangBeli.Text,
                TxtBoxHargaBeli.Text, TxtBoxHargaJual.Text}
            .Rows.Add(row)
            barangList.Add(TxtBoxNamaBarangBeli.Text)
            hargaList.Add(Integer.Parse(TxtBoxHargaJual.Text))
        End With
    End Sub

    Private Sub BtnHapusBeli_Click(sender As Object, e As EventArgs) Handles BtnHapusBeli.Click
        If DataGridPembelian.CurrentRow.Index <> DataGridPembelian.NewRowIndex Then
            DataGridPembelian.Rows.RemoveAt(DataGridPembelian.CurrentRow.Index)
        Else MsgBox("Tidak Ada Data Dipilih!")
        End If
    End Sub

    Private Sub BtnPembelian_Click(sender As Object, e As EventArgs) Handles BtnPembelian.Click
        panelKaryawan.Visible = False
        panelPembelian.Visible = True
        panelPenjualan.Visible = False
    End Sub

    Private Sub BtnPenjualan_Click(sender As Object, e As EventArgs) Handles BtnPenjualan.Click
        panelPenjualan.Visible = True
        panelKaryawan.Visible = False
        panelPembelian.Visible = False

        For Each value In barangList
            CmbBoxNamaBarang.Items.Add(value)
        Next value
    End Sub

    Private Sub BtnTambahJual_Click(sender As Object, e As EventArgs) Handles BtnTambahJual.Click
        With DataGridPenjualan
            Dim row As String() = New String() {DateTimePenjualan.Value.ToString("dd/MM/yyyy"), CmbBoxNamaBarang.SelectedItem.ToString(), TxtBoxJlhBarangBeli.Text,
                TxtBoxHargaPer100gr.Text, TxtBoxHargaTotal.Text}
            .Rows.Add(row)
        End With
    End Sub

    Private Sub CmbBoxNamaBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxNamaBarang.SelectedIndexChanged
        TxtBoxHargaPer100gr.Text = hargaList(CmbBoxNamaBarang.SelectedIndex)
    End Sub

    Private Sub TxtBoxJlhBarangBeli_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxJlhBarangBeli.TextChanged
        If TxtBoxJlhBarangBeli.Text <> "" Then TxtBoxHargaTotal.Text = Integer.Parse(TxtBoxJlhBarangBeli.Text) * Integer.Parse(TxtBoxHargaPer100gr.Text)
    End Sub

    Private Sub BtnHapusJual_Click(sender As Object, e As EventArgs) Handles BtnHapusJual.Click
        If DataGridPenjualan.CurrentRow.Index <> DataGridPenjualan.NewRowIndex Then
            DataGridPenjualan.Rows.RemoveAt(DataGridPenjualan.CurrentRow.Index)
        Else MsgBox("Tidak Ada Data Dipilih!")
        End If
    End Sub
End Class
