<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelKaryawan = New System.Windows.Forms.Panel()
        Me.CmbBoxGolonganKaryawan = New System.Windows.Forms.ComboBox()
        Me.DataGridKaryawan = New System.Windows.Forms.DataGridView()
        Me.NamaKaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Golongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gaji = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnHapusKaryawan = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnTambahKaryawan = New System.Windows.Forms.Button()
        Me.TxtBoxGajiKaryawan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBoxNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPembelian = New System.Windows.Forms.Button()
        Me.BtnPenjualan = New System.Windows.Forms.Button()
        Me.panelPembelian = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimeBeli = New System.Windows.Forms.DateTimePicker()
        Me.TxtBoxHargaJual = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBoxJumlahBarangBeli = New System.Windows.Forms.TextBox()
        Me.DataGridPembelian = New System.Windows.Forms.DataGridView()
        Me.TanggalBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnHapusBeli = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BtnTambahBeli = New System.Windows.Forms.Button()
        Me.TxtBoxHargaBeli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBoxNamaBarangBeli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelPenjualan = New System.Windows.Forms.Panel()
        Me.CmbBoxNamaBarang = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePenjualan = New System.Windows.Forms.DateTimePicker()
        Me.TxtBoxHargaTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtBoxJlhBarangBeli = New System.Windows.Forms.TextBox()
        Me.DataGridPenjualan = New System.Windows.Forms.DataGridView()
        Me.BtnHapusJual = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnTambahJual = New System.Windows.Forms.Button()
        Me.TxtBoxHargaPer100gr = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelKaryawan.SuspendLayout()
        CType(Me.DataGridKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPembelian.SuspendLayout()
        CType(Me.DataGridPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPenjualan.SuspendLayout()
        CType(Me.DataGridPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelKaryawan
        '
        Me.panelKaryawan.Controls.Add(Me.CmbBoxGolonganKaryawan)
        Me.panelKaryawan.Controls.Add(Me.DataGridKaryawan)
        Me.panelKaryawan.Controls.Add(Me.BtnHapusKaryawan)
        Me.panelKaryawan.Controls.Add(Me.Button5)
        Me.panelKaryawan.Controls.Add(Me.BtnTambahKaryawan)
        Me.panelKaryawan.Controls.Add(Me.TxtBoxGajiKaryawan)
        Me.panelKaryawan.Controls.Add(Me.Label6)
        Me.panelKaryawan.Controls.Add(Me.Label5)
        Me.panelKaryawan.Controls.Add(Me.TxtBoxNamaKaryawan)
        Me.panelKaryawan.Controls.Add(Me.Label4)
        Me.panelKaryawan.Controls.Add(Me.Label1)
        Me.panelKaryawan.Location = New System.Drawing.Point(261, 97)
        Me.panelKaryawan.Name = "panelKaryawan"
        Me.panelKaryawan.Size = New System.Drawing.Size(962, 544)
        Me.panelKaryawan.TabIndex = 0
        Me.panelKaryawan.Visible = False
        '
        'CmbBoxGolonganKaryawan
        '
        Me.CmbBoxGolonganKaryawan.FormattingEnabled = True
        Me.CmbBoxGolonganKaryawan.Items.AddRange(New Object() {"Golongan 1", "Golongan 2", "Golongan 3"})
        Me.CmbBoxGolonganKaryawan.Location = New System.Drawing.Point(121, 70)
        Me.CmbBoxGolonganKaryawan.Name = "CmbBoxGolonganKaryawan"
        Me.CmbBoxGolonganKaryawan.Size = New System.Drawing.Size(162, 21)
        Me.CmbBoxGolonganKaryawan.TabIndex = 11
        '
        'DataGridKaryawan
        '
        Me.DataGridKaryawan.AllowUserToAddRows = False
        Me.DataGridKaryawan.AllowUserToDeleteRows = False
        Me.DataGridKaryawan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridKaryawan.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaKaryawan, Me.Golongan, Me.Gaji})
        Me.DataGridKaryawan.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridKaryawan.Location = New System.Drawing.Point(6, 155)
        Me.DataGridKaryawan.Name = "DataGridKaryawan"
        Me.DataGridKaryawan.ReadOnly = True
        Me.DataGridKaryawan.Size = New System.Drawing.Size(945, 389)
        Me.DataGridKaryawan.TabIndex = 10
        '
        'NamaKaryawan
        '
        Me.NamaKaryawan.HeaderText = "Nama Karyawan"
        Me.NamaKaryawan.Name = "NamaKaryawan"
        Me.NamaKaryawan.ReadOnly = True
        Me.NamaKaryawan.Width = 101
        '
        'Golongan
        '
        Me.Golongan.HeaderText = "Golongan"
        Me.Golongan.Name = "Golongan"
        Me.Golongan.ReadOnly = True
        Me.Golongan.Width = 78
        '
        'Gaji
        '
        Me.Gaji.HeaderText = "Gaji"
        Me.Gaji.Name = "Gaji"
        Me.Gaji.ReadOnly = True
        Me.Gaji.Width = 50
        '
        'BtnHapusKaryawan
        '
        Me.BtnHapusKaryawan.Location = New System.Drawing.Point(350, 107)
        Me.BtnHapusKaryawan.Name = "BtnHapusKaryawan"
        Me.BtnHapusKaryawan.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapusKaryawan.TabIndex = 9
        Me.BtnHapusKaryawan.Text = "Hapus"
        Me.BtnHapusKaryawan.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(350, 69)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Ubah"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BtnTambahKaryawan
        '
        Me.BtnTambahKaryawan.Location = New System.Drawing.Point(350, 30)
        Me.BtnTambahKaryawan.Name = "BtnTambahKaryawan"
        Me.BtnTambahKaryawan.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambahKaryawan.TabIndex = 7
        Me.BtnTambahKaryawan.Text = "Tambah"
        Me.BtnTambahKaryawan.UseVisualStyleBackColor = True
        '
        'TxtBoxGajiKaryawan
        '
        Me.TxtBoxGajiKaryawan.Enabled = False
        Me.TxtBoxGajiKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxGajiKaryawan.Location = New System.Drawing.Point(121, 108)
        Me.TxtBoxGajiKaryawan.Name = "TxtBoxGajiKaryawan"
        Me.TxtBoxGajiKaryawan.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxGajiKaryawan.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gaji"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Golongan"
        '
        'TxtBoxNamaKaryawan
        '
        Me.TxtBoxNamaKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNamaKaryawan.Location = New System.Drawing.Point(121, 32)
        Me.TxtBoxNamaKaryawan.Name = "TxtBoxNamaKaryawan"
        Me.TxtBoxNamaKaryawan.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxNamaKaryawan.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manajemen Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Aplikasi Manajemen Usaha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(578, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Aplikasi ini dibuat untuk memudahkan manajemen karyawan, pembelian, dan penjualan" &
    " secara sederhana"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.QuizSebelumUTS.My.Resources.Resources.MembershipOrEmployee
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(34, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 55)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Manajemen Karyawan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnPembelian
        '
        Me.BtnPembelian.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPembelian.Image = Global.QuizSebelumUTS.My.Resources.Resources.New_Arrivals
        Me.BtnPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPembelian.Location = New System.Drawing.Point(34, 168)
        Me.BtnPembelian.Name = "BtnPembelian"
        Me.BtnPembelian.Size = New System.Drawing.Size(198, 68)
        Me.BtnPembelian.TabIndex = 4
        Me.BtnPembelian.Text = "Manajemen Pembelian"
        Me.BtnPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPembelian.UseVisualStyleBackColor = True
        '
        'BtnPenjualan
        '
        Me.BtnPenjualan.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPenjualan.Image = Global.QuizSebelumUTS.My.Resources.Resources.Sale
        Me.BtnPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPenjualan.Location = New System.Drawing.Point(34, 252)
        Me.BtnPenjualan.Name = "BtnPenjualan"
        Me.BtnPenjualan.Size = New System.Drawing.Size(198, 62)
        Me.BtnPenjualan.TabIndex = 5
        Me.BtnPenjualan.Text = "Manajemen Penjualan"
        Me.BtnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPenjualan.UseVisualStyleBackColor = True
        '
        'panelPembelian
        '
        Me.panelPembelian.Controls.Add(Me.Label12)
        Me.panelPembelian.Controls.Add(Me.DateTimeBeli)
        Me.panelPembelian.Controls.Add(Me.TxtBoxHargaJual)
        Me.panelPembelian.Controls.Add(Me.Label11)
        Me.panelPembelian.Controls.Add(Me.TxtBoxJumlahBarangBeli)
        Me.panelPembelian.Controls.Add(Me.DataGridPembelian)
        Me.panelPembelian.Controls.Add(Me.BtnHapusBeli)
        Me.panelPembelian.Controls.Add(Me.Button6)
        Me.panelPembelian.Controls.Add(Me.BtnTambahBeli)
        Me.panelPembelian.Controls.Add(Me.TxtBoxHargaBeli)
        Me.panelPembelian.Controls.Add(Me.Label7)
        Me.panelPembelian.Controls.Add(Me.Label8)
        Me.panelPembelian.Controls.Add(Me.TxtBoxNamaBarangBeli)
        Me.panelPembelian.Controls.Add(Me.Label9)
        Me.panelPembelian.Controls.Add(Me.Label10)
        Me.panelPembelian.Location = New System.Drawing.Point(261, 97)
        Me.panelPembelian.Name = "panelPembelian"
        Me.panelPembelian.Size = New System.Drawing.Size(962, 544)
        Me.panelPembelian.TabIndex = 12
        Me.panelPembelian.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(627, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Tanggal Beli"
        '
        'DateTimeBeli
        '
        Me.DateTimeBeli.Location = New System.Drawing.Point(630, 69)
        Me.DateTimeBeli.Name = "DateTimeBeli"
        Me.DateTimeBeli.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeBeli.TabIndex = 14
        '
        'TxtBoxHargaJual
        '
        Me.TxtBoxHargaJual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxHargaJual.Location = New System.Drawing.Point(438, 68)
        Me.TxtBoxHargaJual.Name = "TxtBoxHargaJual"
        Me.TxtBoxHargaJual.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxHargaJual.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(304, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Harga Jual (100 Gram)"
        '
        'TxtBoxJumlahBarangBeli
        '
        Me.TxtBoxJumlahBarangBeli.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxJumlahBarangBeli.Location = New System.Drawing.Point(121, 69)
        Me.TxtBoxJumlahBarangBeli.Name = "TxtBoxJumlahBarangBeli"
        Me.TxtBoxJumlahBarangBeli.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxJumlahBarangBeli.TabIndex = 11
        '
        'DataGridPembelian
        '
        Me.DataGridPembelian.AllowUserToAddRows = False
        Me.DataGridPembelian.AllowUserToDeleteRows = False
        Me.DataGridPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridPembelian.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TanggalBeli, Me.NamaBarang, Me.JumlahStok, Me.HargaBeli, Me.HargaJual})
        Me.DataGridPembelian.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridPembelian.Location = New System.Drawing.Point(6, 155)
        Me.DataGridPembelian.Name = "DataGridPembelian"
        Me.DataGridPembelian.ReadOnly = True
        Me.DataGridPembelian.Size = New System.Drawing.Size(945, 389)
        Me.DataGridPembelian.TabIndex = 10
        '
        'TanggalBeli
        '
        Me.TanggalBeli.HeaderText = "Tanggal Beli"
        Me.TanggalBeli.Name = "TanggalBeli"
        Me.TanggalBeli.ReadOnly = True
        Me.TanggalBeli.Width = 84
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.ReadOnly = True
        Me.NamaBarang.Width = 89
        '
        'JumlahStok
        '
        Me.JumlahStok.HeaderText = "Qty (Gram)"
        Me.JumlahStok.Name = "JumlahStok"
        Me.JumlahStok.ReadOnly = True
        Me.JumlahStok.Width = 76
        '
        'HargaBeli
        '
        Me.HargaBeli.HeaderText = "Harga Beli"
        Me.HargaBeli.Name = "HargaBeli"
        Me.HargaBeli.ReadOnly = True
        Me.HargaBeli.Width = 75
        '
        'HargaJual
        '
        Me.HargaJual.HeaderText = "Harga Jual (100 gr)"
        Me.HargaJual.Name = "HargaJual"
        Me.HargaJual.ReadOnly = True
        Me.HargaJual.Width = 101
        '
        'BtnHapusBeli
        '
        Me.BtnHapusBeli.Location = New System.Drawing.Point(208, 109)
        Me.BtnHapusBeli.Name = "BtnHapusBeli"
        Me.BtnHapusBeli.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapusBeli.TabIndex = 9
        Me.BtnHapusBeli.Text = "Hapus"
        Me.BtnHapusBeli.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(106, 109)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Ubah"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BtnTambahBeli
        '
        Me.BtnTambahBeli.Location = New System.Drawing.Point(10, 109)
        Me.BtnTambahBeli.Name = "BtnTambahBeli"
        Me.BtnTambahBeli.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambahBeli.TabIndex = 7
        Me.BtnTambahBeli.Text = "Tambah"
        Me.BtnTambahBeli.UseVisualStyleBackColor = True
        '
        'TxtBoxHargaBeli
        '
        Me.TxtBoxHargaBeli.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxHargaBeli.Location = New System.Drawing.Point(438, 33)
        Me.TxtBoxHargaBeli.Name = "TxtBoxHargaBeli"
        Me.TxtBoxHargaBeli.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxHargaBeli.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Harga Beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Jumlah Stok (Gram)"
        '
        'TxtBoxNamaBarangBeli
        '
        Me.TxtBoxNamaBarangBeli.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNamaBarangBeli.Location = New System.Drawing.Point(121, 32)
        Me.TxtBoxNamaBarangBeli.Name = "TxtBoxNamaBarangBeli"
        Me.TxtBoxNamaBarangBeli.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxNamaBarangBeli.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nama Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Manajemen Pembelian"
        '
        'panelPenjualan
        '
        Me.panelPenjualan.Controls.Add(Me.CmbBoxNamaBarang)
        Me.panelPenjualan.Controls.Add(Me.Label13)
        Me.panelPenjualan.Controls.Add(Me.DateTimePenjualan)
        Me.panelPenjualan.Controls.Add(Me.TxtBoxHargaTotal)
        Me.panelPenjualan.Controls.Add(Me.Label14)
        Me.panelPenjualan.Controls.Add(Me.TxtBoxJlhBarangBeli)
        Me.panelPenjualan.Controls.Add(Me.DataGridPenjualan)
        Me.panelPenjualan.Controls.Add(Me.BtnHapusJual)
        Me.panelPenjualan.Controls.Add(Me.Button3)
        Me.panelPenjualan.Controls.Add(Me.BtnTambahJual)
        Me.panelPenjualan.Controls.Add(Me.TxtBoxHargaPer100gr)
        Me.panelPenjualan.Controls.Add(Me.Label15)
        Me.panelPenjualan.Controls.Add(Me.Label16)
        Me.panelPenjualan.Controls.Add(Me.Label17)
        Me.panelPenjualan.Controls.Add(Me.Label18)
        Me.panelPenjualan.Location = New System.Drawing.Point(261, 97)
        Me.panelPenjualan.Name = "panelPenjualan"
        Me.panelPenjualan.Size = New System.Drawing.Size(962, 544)
        Me.panelPenjualan.TabIndex = 16
        Me.panelPenjualan.Visible = False
        '
        'CmbBoxNamaBarang
        '
        Me.CmbBoxNamaBarang.FormattingEnabled = True
        Me.CmbBoxNamaBarang.Location = New System.Drawing.Point(132, 30)
        Me.CmbBoxNamaBarang.Name = "CmbBoxNamaBarang"
        Me.CmbBoxNamaBarang.Size = New System.Drawing.Size(162, 21)
        Me.CmbBoxNamaBarang.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(627, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Tanggal Jual"
        '
        'DateTimePenjualan
        '
        Me.DateTimePenjualan.Location = New System.Drawing.Point(630, 69)
        Me.DateTimePenjualan.Name = "DateTimePenjualan"
        Me.DateTimePenjualan.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePenjualan.TabIndex = 14
        '
        'TxtBoxHargaTotal
        '
        Me.TxtBoxHargaTotal.Enabled = False
        Me.TxtBoxHargaTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxHargaTotal.Location = New System.Drawing.Point(438, 68)
        Me.TxtBoxHargaTotal.Name = "TxtBoxHargaTotal"
        Me.TxtBoxHargaTotal.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxHargaTotal.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(315, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Harga Total"
        '
        'TxtBoxJlhBarangBeli
        '
        Me.TxtBoxJlhBarangBeli.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxJlhBarangBeli.Location = New System.Drawing.Point(132, 68)
        Me.TxtBoxJlhBarangBeli.Name = "TxtBoxJlhBarangBeli"
        Me.TxtBoxJlhBarangBeli.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxJlhBarangBeli.TabIndex = 11
        '
        'DataGridPenjualan
        '
        Me.DataGridPenjualan.AllowUserToAddRows = False
        Me.DataGridPenjualan.AllowUserToDeleteRows = False
        Me.DataGridPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridPenjualan.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridPenjualan.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridPenjualan.Location = New System.Drawing.Point(6, 155)
        Me.DataGridPenjualan.Name = "DataGridPenjualan"
        Me.DataGridPenjualan.ReadOnly = True
        Me.DataGridPenjualan.Size = New System.Drawing.Size(945, 389)
        Me.DataGridPenjualan.TabIndex = 10
        '
        'BtnHapusJual
        '
        Me.BtnHapusJual.Location = New System.Drawing.Point(208, 109)
        Me.BtnHapusJual.Name = "BtnHapusJual"
        Me.BtnHapusJual.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapusJual.TabIndex = 9
        Me.BtnHapusJual.Text = "Hapus"
        Me.BtnHapusJual.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(106, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Ubah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnTambahJual
        '
        Me.BtnTambahJual.Location = New System.Drawing.Point(10, 109)
        Me.BtnTambahJual.Name = "BtnTambahJual"
        Me.BtnTambahJual.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambahJual.TabIndex = 7
        Me.BtnTambahJual.Text = "Tambah"
        Me.BtnTambahJual.UseVisualStyleBackColor = True
        '
        'TxtBoxHargaPer100gr
        '
        Me.TxtBoxHargaPer100gr.Enabled = False
        Me.TxtBoxHargaPer100gr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxHargaPer100gr.Location = New System.Drawing.Point(438, 33)
        Me.TxtBoxHargaPer100gr.Name = "TxtBoxHargaPer100gr"
        Me.TxtBoxHargaPer100gr.Size = New System.Drawing.Size(162, 22)
        Me.TxtBoxHargaPer100gr.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(315, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Harga Per 100 gr"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 15)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Jumlah Jual (100 gr)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 15)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Nama Barang"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 15)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Manajemen Penjualan"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tanggal Jual"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 93
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 97
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qty (100 Gram)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 95
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Harga Satuan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Harga Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 81
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.panelPenjualan)
        Me.Controls.Add(Me.panelPembelian)
        Me.Controls.Add(Me.BtnPenjualan)
        Me.Controls.Add(Me.BtnPembelian)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelKaryawan)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelKaryawan.ResumeLayout(False)
        Me.panelKaryawan.PerformLayout()
        CType(Me.DataGridKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPembelian.ResumeLayout(False)
        Me.panelPembelian.PerformLayout()
        CType(Me.DataGridPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPenjualan.ResumeLayout(False)
        Me.panelPenjualan.PerformLayout()
        CType(Me.DataGridPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelKaryawan As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnPembelian As Button
    Friend WithEvents BtnPenjualan As Button
    Friend WithEvents DataGridKaryawan As DataGridView
    Friend WithEvents NamaKaryawan As DataGridViewTextBoxColumn
    Friend WithEvents Golongan As DataGridViewTextBoxColumn
    Friend WithEvents Gaji As DataGridViewTextBoxColumn
    Friend WithEvents BtnHapusKaryawan As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BtnTambahKaryawan As Button
    Friend WithEvents TxtBoxGajiKaryawan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxNamaKaryawan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbBoxGolonganKaryawan As ComboBox
    Friend WithEvents panelPembelian As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimeBeli As DateTimePicker
    Friend WithEvents TxtBoxHargaJual As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtBoxJumlahBarangBeli As TextBox
    Friend WithEvents DataGridPembelian As DataGridView
    Friend WithEvents TanggalBeli As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents JumlahStok As DataGridViewTextBoxColumn
    Friend WithEvents HargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents HargaJual As DataGridViewTextBoxColumn
    Friend WithEvents BtnHapusBeli As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents BtnTambahBeli As Button
    Friend WithEvents TxtBoxHargaBeli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBoxNamaBarangBeli As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents panelPenjualan As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePenjualan As DateTimePicker
    Friend WithEvents TxtBoxHargaTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtBoxJlhBarangBeli As TextBox
    Friend WithEvents DataGridPenjualan As DataGridView
    Friend WithEvents BtnHapusJual As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnTambahJual As Button
    Friend WithEvents TxtBoxHargaPer100gr As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CmbBoxNamaBarang As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
