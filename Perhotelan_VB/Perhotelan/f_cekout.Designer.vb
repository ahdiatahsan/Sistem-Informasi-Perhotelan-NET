﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_cekout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_cekout))
        Me.L_header = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C_id = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.B_simpan = New System.Windows.Forms.Button()
        Me.B_reset = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.L_harga = New System.Windows.Forms.Label()
        Me.L_tipe = New System.Windows.Forms.Label()
        Me.L_lantai = New System.Windows.Forms.Label()
        Me.L_kamar = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.L_id = New System.Windows.Forms.Label()
        Me.L_nama = New System.Windows.Forms.Label()
        Me.L_jk = New System.Windows.Forms.Label()
        Me.L_alamat = New System.Windows.Forms.Label()
        Me.L_telp = New System.Windows.Forms.Label()
        Me.L_durasi = New System.Windows.Forms.Label()
        Me.L_total = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.L_cekin = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.L_cekout = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_header
        '
        Me.L_header.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_header.BackColor = System.Drawing.Color.Transparent
        Me.L_header.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_header.ForeColor = System.Drawing.Color.White
        Me.L_header.Location = New System.Drawing.Point(0, 15)
        Me.L_header.Name = "L_header"
        Me.L_header.Size = New System.Drawing.Size(862, 42)
        Me.L_header.TabIndex = 0
        Me.L_header.Text = "Check Out Tamu"
        Me.L_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.L_header)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 76)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(17, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lantai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(17, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipe Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(17, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Harga Kamar"
        '
        'C_id
        '
        Me.C_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_id.FormattingEnabled = True
        Me.C_id.Items.AddRange(New Object() {"- Pilih -", "Standard", "Deluxe", "Suite"})
        Me.C_id.Location = New System.Drawing.Point(158, 30)
        Me.C_id.Name = "C_id"
        Me.C_id.Size = New System.Drawing.Size(237, 30)
        Me.C_id.TabIndex = 12
        Me.C_id.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(139, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(139, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(139, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(139, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = ":"
        '
        'B_simpan
        '
        Me.B_simpan.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.B_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_simpan.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_simpan.ForeColor = System.Drawing.Color.White
        Me.B_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_simpan.Location = New System.Drawing.Point(668, 429)
        Me.B_simpan.Name = "B_simpan"
        Me.B_simpan.Size = New System.Drawing.Size(83, 43)
        Me.B_simpan.TabIndex = 18
        Me.B_simpan.TabStop = False
        Me.B_simpan.Text = "Simpan"
        Me.B_simpan.UseVisualStyleBackColor = False
        '
        'B_reset
        '
        Me.B_reset.BackColor = System.Drawing.Color.Firebrick
        Me.B_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_reset.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_reset.ForeColor = System.Drawing.Color.White
        Me.B_reset.Location = New System.Drawing.Point(758, 429)
        Me.B_reset.Name = "B_reset"
        Me.B_reset.Size = New System.Drawing.Size(83, 43)
        Me.B_reset.TabIndex = 19
        Me.B_reset.TabStop = False
        Me.B_reset.Text = "Reset"
        Me.B_reset.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(139, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 22)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(17, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 22)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "No. Kamar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.L_total)
        Me.GroupBox1.Controls.Add(Me.L_id)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.L_harga)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.L_tipe)
        Me.GroupBox1.Controls.Add(Me.L_durasi)
        Me.GroupBox1.Controls.Add(Me.L_lantai)
        Me.GroupBox1.Controls.Add(Me.L_kamar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(14, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 319)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kamar"
        '
        'L_harga
        '
        Me.L_harga.AutoSize = True
        Me.L_harga.BackColor = System.Drawing.Color.Transparent
        Me.L_harga.Location = New System.Drawing.Point(158, 198)
        Me.L_harga.Name = "L_harga"
        Me.L_harga.Size = New System.Drawing.Size(93, 22)
        Me.L_harga.TabIndex = 27
        Me.L_harga.Text = "Harga Kamar"
        '
        'L_tipe
        '
        Me.L_tipe.AutoSize = True
        Me.L_tipe.BackColor = System.Drawing.Color.Transparent
        Me.L_tipe.Location = New System.Drawing.Point(158, 158)
        Me.L_tipe.Name = "L_tipe"
        Me.L_tipe.Size = New System.Drawing.Size(80, 22)
        Me.L_tipe.TabIndex = 26
        Me.L_tipe.Text = "Tipe Kamar"
        '
        'L_lantai
        '
        Me.L_lantai.AutoSize = True
        Me.L_lantai.BackColor = System.Drawing.Color.Transparent
        Me.L_lantai.Location = New System.Drawing.Point(158, 118)
        Me.L_lantai.Name = "L_lantai"
        Me.L_lantai.Size = New System.Drawing.Size(48, 22)
        Me.L_lantai.TabIndex = 25
        Me.L_lantai.Text = "Lantai"
        '
        'L_kamar
        '
        Me.L_kamar.AutoSize = True
        Me.L_kamar.BackColor = System.Drawing.Color.Transparent
        Me.L_kamar.Location = New System.Drawing.Point(158, 77)
        Me.L_kamar.Name = "L_kamar"
        Me.L_kamar.Size = New System.Drawing.Size(75, 22)
        Me.L_kamar.TabIndex = 24
        Me.L_kamar.Text = "No. Kamar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.L_cekout)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.L_cekin)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.L_telp)
        Me.GroupBox2.Controls.Add(Me.L_alamat)
        Me.GroupBox2.Controls.Add(Me.L_jk)
        Me.GroupBox2.Controls.Add(Me.L_nama)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.C_id)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(440, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 319)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tamu"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(139, 236)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 22)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = ":"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(17, 236)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 22)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Durasi Inap"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(139, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 22)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(17, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Nama Lengkap"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(139, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 22)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(139, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 22)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(139, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 22)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(139, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 22)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(17, 195)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 22)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "No. Telp"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(17, 156)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 22)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Alamat"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(17, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 22)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Jenis Kelamin"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(18, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(61, 22)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "ID Tamu"
        '
        'L_id
        '
        Me.L_id.AutoSize = True
        Me.L_id.BackColor = System.Drawing.Color.Transparent
        Me.L_id.Location = New System.Drawing.Point(158, 38)
        Me.L_id.Name = "L_id"
        Me.L_id.Size = New System.Drawing.Size(72, 22)
        Me.L_id.TabIndex = 28
        Me.L_id.Text = "ID_Kamar"
        '
        'L_nama
        '
        Me.L_nama.AutoSize = True
        Me.L_nama.BackColor = System.Drawing.Color.Transparent
        Me.L_nama.Location = New System.Drawing.Point(158, 77)
        Me.L_nama.Name = "L_nama"
        Me.L_nama.Size = New System.Drawing.Size(87, 22)
        Me.L_nama.TabIndex = 29
        Me.L_nama.Text = "Nama Tamu"
        '
        'L_jk
        '
        Me.L_jk.AutoSize = True
        Me.L_jk.BackColor = System.Drawing.Color.Transparent
        Me.L_jk.Location = New System.Drawing.Point(158, 118)
        Me.L_jk.Name = "L_jk"
        Me.L_jk.Size = New System.Drawing.Size(93, 22)
        Me.L_jk.TabIndex = 30
        Me.L_jk.Text = "Jenis Kelamin"
        '
        'L_alamat
        '
        Me.L_alamat.AutoSize = True
        Me.L_alamat.BackColor = System.Drawing.Color.Transparent
        Me.L_alamat.Location = New System.Drawing.Point(158, 156)
        Me.L_alamat.Name = "L_alamat"
        Me.L_alamat.Size = New System.Drawing.Size(55, 22)
        Me.L_alamat.TabIndex = 31
        Me.L_alamat.Text = "Alamat"
        '
        'L_telp
        '
        Me.L_telp.AutoSize = True
        Me.L_telp.BackColor = System.Drawing.Color.Transparent
        Me.L_telp.Location = New System.Drawing.Point(158, 195)
        Me.L_telp.Name = "L_telp"
        Me.L_telp.Size = New System.Drawing.Size(58, 22)
        Me.L_telp.TabIndex = 32
        Me.L_telp.Text = "No. Telp"
        '
        'L_durasi
        '
        Me.L_durasi.AutoSize = True
        Me.L_durasi.BackColor = System.Drawing.Color.Transparent
        Me.L_durasi.Location = New System.Drawing.Point(158, 236)
        Me.L_durasi.Name = "L_durasi"
        Me.L_durasi.Size = New System.Drawing.Size(79, 22)
        Me.L_durasi.TabIndex = 33
        Me.L_durasi.Text = "Durasi Inap"
        '
        'L_total
        '
        Me.L_total.AutoSize = True
        Me.L_total.BackColor = System.Drawing.Color.Transparent
        Me.L_total.Location = New System.Drawing.Point(158, 277)
        Me.L_total.Name = "L_total"
        Me.L_total.Size = New System.Drawing.Size(80, 22)
        Me.L_total.TabIndex = 36
        Me.L_total.Text = "Total Bayar"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(139, 277)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 22)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(17, 277)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 22)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "Total Bayar"
        '
        'L_cekin
        '
        Me.L_cekin.AutoSize = True
        Me.L_cekin.BackColor = System.Drawing.Color.Transparent
        Me.L_cekin.Location = New System.Drawing.Point(158, 235)
        Me.L_cekin.Name = "L_cekin"
        Me.L_cekin.Size = New System.Drawing.Size(67, 22)
        Me.L_cekin.TabIndex = 35
        Me.L_cekin.Text = "Check_In"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(139, 236)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 22)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(17, 235)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 22)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Check_In"
        '
        'L_cekout
        '
        Me.L_cekout.AutoSize = True
        Me.L_cekout.BackColor = System.Drawing.Color.Transparent
        Me.L_cekout.Location = New System.Drawing.Point(158, 275)
        Me.L_cekout.Name = "L_cekout"
        Me.L_cekout.Size = New System.Drawing.Size(78, 22)
        Me.L_cekout.TabIndex = 38
        Me.L_cekout.Text = "Check_Out"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(139, 275)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 22)
        Me.Label29.TabIndex = 37
        Me.Label29.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(17, 274)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(78, 22)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Check_Out"
        '
        'f_cekout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 484)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.B_reset)
        Me.Controls.Add(Me.B_simpan)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "f_cekout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Out Tamu"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents L_header As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents C_id As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents B_simpan As Button
    Friend WithEvents B_reset As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents L_harga As Label
    Friend WithEvents L_tipe As Label
    Friend WithEvents L_lantai As Label
    Friend WithEvents L_kamar As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents L_id As Label
    Friend WithEvents L_total As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents L_durasi As Label
    Friend WithEvents L_telp As Label
    Friend WithEvents L_alamat As Label
    Friend WithEvents L_jk As Label
    Friend WithEvents L_nama As Label
    Friend WithEvents L_cekin As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents L_cekout As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
End Class
