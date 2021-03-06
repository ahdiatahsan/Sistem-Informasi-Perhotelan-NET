﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    [DesignerGenerated()]
    public partial class f_karyawan : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_karyawan));
            this._Panel1 = new System.Windows.Forms.Panel();
            this._Label1 = new System.Windows.Forms.Label();
            this._Dgv_karyawan = new System.Windows.Forms.DataGridView();
            this._Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._T_cari = new System.Windows.Forms.TextBox();
            this._B_cari = new System.Windows.Forms.Button();
            this._B_tambah = new System.Windows.Forms.Button();
            this._B_edit = new System.Windows.Forms.Button();
            this._B_hapus = new System.Windows.Forms.Button();
            this._B_refresh = new System.Windows.Forms.Button();
            this._Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Dgv_karyawan)).BeginInit();
            this.SuspendLayout();
            // 
            // _Panel1
            // 
            this._Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._Panel1.Controls.Add(this._Label1);
            this._Panel1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Panel1.Location = new System.Drawing.Point(10, 9);
            this._Panel1.Name = "_Panel1";
            this._Panel1.Size = new System.Drawing.Size(659, 67);
            this._Panel1.TabIndex = 0;
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1.ForeColor = System.Drawing.Color.White;
            this._Label1.Location = new System.Drawing.Point(238, 11);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(208, 42);
            this._Label1.TabIndex = 0;
            this._Label1.Text = "Data Karyawan";
            // 
            // _Dgv_karyawan
            // 
            this._Dgv_karyawan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Dgv_karyawan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this._Dgv_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Dgv_karyawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Column1,
            this._Column2,
            this._Column3,
            this._Column4,
            this._Column5});
            this._Dgv_karyawan.Location = new System.Drawing.Point(10, 121);
            this._Dgv_karyawan.Name = "_Dgv_karyawan";
            this._Dgv_karyawan.ReadOnly = true;
            this._Dgv_karyawan.Size = new System.Drawing.Size(538, 218);
            this._Dgv_karyawan.TabIndex = 1;
            // 
            // _Column1
            // 
            this._Column1.HeaderText = "ID";
            this._Column1.Name = "_Column1";
            this._Column1.ReadOnly = true;
            this._Column1.Width = 55;
            // 
            // _Column2
            // 
            this._Column2.HeaderText = "Nama Karyawan";
            this._Column2.Name = "_Column2";
            this._Column2.ReadOnly = true;
            this._Column2.Width = 130;
            // 
            // _Column3
            // 
            this._Column3.HeaderText = "Jenis Kelamin";
            this._Column3.Name = "_Column3";
            this._Column3.ReadOnly = true;
            // 
            // _Column4
            // 
            this._Column4.HeaderText = "Alamat";
            this._Column4.Name = "_Column4";
            this._Column4.ReadOnly = true;
            this._Column4.Width = 105;
            // 
            // _Column5
            // 
            this._Column5.HeaderText = "No. Telp";
            this._Column5.Name = "_Column5";
            this._Column5.ReadOnly = true;
            this._Column5.Width = 105;
            // 
            // _T_cari
            // 
            this._T_cari.Location = new System.Drawing.Point(10, 90);
            this._T_cari.Name = "_T_cari";
            this._T_cari.Size = new System.Drawing.Size(582, 25);
            this._T_cari.TabIndex = 2;
            this._T_cari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.T_cari_KeyDown);
            // 
            // _B_cari
            // 
            this._B_cari.BackColor = System.Drawing.Color.Snow;
            this._B_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._B_cari.Image = ((System.Drawing.Image)(resources.GetObject("_B_cari.Image")));
            this._B_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._B_cari.Location = new System.Drawing.Point(598, 90);
            this._B_cari.Name = "_B_cari";
            this._B_cari.Size = new System.Drawing.Size(71, 25);
            this._B_cari.TabIndex = 3;
            this._B_cari.Text = "Cari";
            this._B_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._B_cari.UseVisualStyleBackColor = false;
            this._B_cari.Click += new System.EventHandler(this.B_cari_Click);
            // 
            // _B_tambah
            // 
            this._B_tambah.BackColor = System.Drawing.Color.Snow;
            this._B_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._B_tambah.Image = ((System.Drawing.Image)(resources.GetObject("_B_tambah.Image")));
            this._B_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._B_tambah.Location = new System.Drawing.Point(554, 121);
            this._B_tambah.Name = "_B_tambah";
            this._B_tambah.Size = new System.Drawing.Size(115, 50);
            this._B_tambah.TabIndex = 4;
            this._B_tambah.Text = "           Tambah";
            this._B_tambah.UseVisualStyleBackColor = false;
            this._B_tambah.Click += new System.EventHandler(this.B_tambah_Click);
            // 
            // _B_edit
            // 
            this._B_edit.BackColor = System.Drawing.Color.Snow;
            this._B_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._B_edit.Image = ((System.Drawing.Image)(resources.GetObject("_B_edit.Image")));
            this._B_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._B_edit.Location = new System.Drawing.Point(554, 177);
            this._B_edit.Name = "_B_edit";
            this._B_edit.Size = new System.Drawing.Size(115, 50);
            this._B_edit.TabIndex = 5;
            this._B_edit.Text = "   Edit";
            this._B_edit.UseVisualStyleBackColor = false;
            this._B_edit.Click += new System.EventHandler(this.B_edit_Click);
            // 
            // _B_hapus
            // 
            this._B_hapus.BackColor = System.Drawing.Color.Snow;
            this._B_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._B_hapus.Image = ((System.Drawing.Image)(resources.GetObject("_B_hapus.Image")));
            this._B_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._B_hapus.Location = new System.Drawing.Point(554, 233);
            this._B_hapus.Name = "_B_hapus";
            this._B_hapus.Size = new System.Drawing.Size(115, 50);
            this._B_hapus.TabIndex = 6;
            this._B_hapus.Text = "        Hapus";
            this._B_hapus.UseVisualStyleBackColor = false;
            this._B_hapus.Click += new System.EventHandler(this.B_hapus_Click);
            // 
            // _B_refresh
            // 
            this._B_refresh.BackColor = System.Drawing.Color.Snow;
            this._B_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._B_refresh.Image = ((System.Drawing.Image)(resources.GetObject("_B_refresh.Image")));
            this._B_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._B_refresh.Location = new System.Drawing.Point(554, 289);
            this._B_refresh.Name = "_B_refresh";
            this._B_refresh.Size = new System.Drawing.Size(115, 50);
            this._B_refresh.TabIndex = 7;
            this._B_refresh.Text = "         Refresh";
            this._B_refresh.UseVisualStyleBackColor = false;
            this._B_refresh.Click += new System.EventHandler(this.B_refresh_Click);
            // 
            // f_karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(678, 346);
            this.Controls.Add(this._B_refresh);
            this.Controls.Add(this._B_hapus);
            this.Controls.Add(this._B_edit);
            this.Controls.Add(this._B_tambah);
            this.Controls.Add(this._B_cari);
            this.Controls.Add(this._T_cari);
            this.Controls.Add(this._Dgv_karyawan);
            this.Controls.Add(this._Panel1);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "f_karyawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Karyawan";
            this.Load += new System.EventHandler(this.f_karyawan_Load);
            this._Panel1.ResumeLayout(false);
            this._Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Dgv_karyawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private Label _Label1;

        internal Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 != null)
                {
                }

                _Label1 = value;
                if (_Label1 != null)
                {
                }
            }
        }

        private DataGridView _Dgv_karyawan;

        internal DataGridView Dgv_karyawan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Dgv_karyawan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Dgv_karyawan != null)
                {
                }

                _Dgv_karyawan = value;
                if (_Dgv_karyawan != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _Column1;

        internal DataGridViewTextBoxColumn Column1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Column1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Column1 != null)
                {
                }

                _Column1 = value;
                if (_Column1 != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _Column2;

        internal DataGridViewTextBoxColumn Column2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Column2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Column2 != null)
                {
                }

                _Column2 = value;
                if (_Column2 != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _Column3;

        internal DataGridViewTextBoxColumn Column3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Column3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Column3 != null)
                {
                }

                _Column3 = value;
                if (_Column3 != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _Column4;

        internal DataGridViewTextBoxColumn Column4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Column4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Column4 != null)
                {
                }

                _Column4 = value;
                if (_Column4 != null)
                {
                }
            }
        }

        private DataGridViewTextBoxColumn _Column5;

        internal DataGridViewTextBoxColumn Column5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Column5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Column5 != null)
                {
                }

                _Column5 = value;
                if (_Column5 != null)
                {
                }
            }
        }

        private TextBox _T_cari;

        internal TextBox T_cari
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_cari;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_cari != null)
                {
                    _T_cari.KeyDown -= T_cari_KeyDown;
                }

                _T_cari = value;
                if (_T_cari != null)
                {
                    _T_cari.KeyDown += T_cari_KeyDown;
                }
            }
        }

        private Button _B_cari;

        internal Button B_cari
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_cari;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_cari != null)
                {
                    _B_cari.Click -= B_cari_Click;
                }

                _B_cari = value;
                if (_B_cari != null)
                {
                    _B_cari.Click += B_cari_Click;
                }
            }
        }

        private Button _B_tambah;

        internal Button B_tambah
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_tambah;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_tambah != null)
                {
                    _B_tambah.Click -= B_tambah_Click;
                }

                _B_tambah = value;
                if (_B_tambah != null)
                {
                    _B_tambah.Click += B_tambah_Click;
                }
            }
        }

        private Button _B_edit;

        internal Button B_edit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_edit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_edit != null)
                {
                    _B_edit.Click -= B_edit_Click;
                }

                _B_edit = value;
                if (_B_edit != null)
                {
                    _B_edit.Click += B_edit_Click;
                }
            }
        }

        private Button _B_hapus;

        internal Button B_hapus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_hapus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_hapus != null)
                {
                    _B_hapus.Click -= B_hapus_Click;
                }

                _B_hapus = value;
                if (_B_hapus != null)
                {
                    _B_hapus.Click += B_hapus_Click;
                }
            }
        }

        private Button _B_refresh;

        internal Button B_refresh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_refresh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_refresh != null)
                {
                    _B_refresh.Click -= B_refresh_Click;
                }

                _B_refresh = value;
                if (_B_refresh != null)
                {
                    _B_refresh.Click += B_refresh_Click;
                }
            }
        }
    }
}