# 🏕️ RylVa Camp Store

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge\&logo=c-sharp\&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge\&logo=.net\&logoColor=white)
![Windows](https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge\&logo=windows\&logoColor=white)

**RylVa Camp Store** adalah aplikasi kasir (*Point of Sale*) dan manajemen inventaris berbasis desktop yang dirancang untuk mendukung operasional toko perlengkapan berkemah (*camping equipment store*).

Dikembangkan sebagai **Tugas Akhir (TA) Rekayasa Perangkat Lunak**, aplikasi ini bertujuan untuk mendigitalisasi proses pencatatan transaksi dan pengelolaan inventaris. Sistem dirancang untuk meningkatkan akurasi perhitungan, menjaga konsistensi pencatatan, mempermudah pengelolaan data, serta mempercepat pelayanan pelanggan.

---

## ✨ Fitur Unggulan

### 🛍️ 1. Transaksi Pembelian dan Penyewaan

Mendukung dua jenis transaksi, yaitu pembelian barang secara langsung dan penyewaan berdasarkan durasi harian. Sistem menyediakan pilihan metode pembayaran serta simulasi pembayaran kredit dengan bunga otomatis sebesar **2,5%**, sesuai mekanisme yang diterapkan dalam aplikasi.

### 🔄 2. Pembaruan Stok Otomatis

Sistem memperbarui ketersediaan barang setelah transaksi berhasil divalidasi, sehingga stok inventaris tetap mengikuti transaksi yang tercatat.

### 🖨️ 3. Integrasi Thermal Printer

Mendukung pencetakan struk transaksi melalui printer kasir untuk menghasilkan bukti pembayaran secara langsung.

**Perangkat yang ditargetkan:** Blueprint Eco80D atau printer thermal sejenis yang kompatibel.

### 🗑️ 4. Clean Delete System

Fitur penghapusan data pada panel Admin untuk membersihkan riwayat pesanan beserta file teks struk terkait, guna mengurangi sisa berkas yang tidak lagi diperlukan.

### 💾 5. One-Click Backup

Mempermudah pencadangan basis data ke folder tujuan melalui satu tindakan, sehingga salinan data dapat disimpan untuk kebutuhan pemulihan.

---

## 🛠️ Teknologi yang Digunakan

| Komponen           | Teknologi                   |
| ------------------ | --------------------------- |
| Bahasa Pemrograman | C#                          |
| Framework          | .NET Framework              |
| Antarmuka          | Windows Forms (WinForms)    |
| Penyimpanan Data   | Flat-File Database (`.txt`) |
| Sistem Operasi     | Windows                     |
| Perangkat Cetak    | Thermal Printer             |

### Arsitektur Penyimpanan

Aplikasi menggunakan pendekatan **Flat-File**, yaitu penyimpanan data dalam berkas teks lokal. Pendekatan ini digunakan untuk menerapkan konsep dasar pengolahan data melalui operasi *Input/Output* (I/O), pembacaan dan penulisan berkas, serta pengelolaan data tanpa bergantung pada server basis data terpisah.

---

## 📸 Antarmuka Sistem

Tambahkan poster atau tangkapan layar aplikasi agar pengunjung repositori dapat melihat tampilan sistem.

Simpan gambar di dalam repositori, misalnya pada folder `assets`, kemudian gunakan nama berkas yang sesuai.

![Poster RylVa Camp Store](assets/poster-rylva-camp-store.jpg)

> **Catatan:** Pastikan berkas gambar tersedia di lokasi tersebut. Ganti `assets/poster-rylva-camp-store.jpg` sesuai dengan nama dan lokasi gambar yang sebenarnya.

---

## 🚀 Cara Menjalankan Aplikasi

Ikuti langkah-langkah berikut untuk menjalankan proyek di komputer lokal.

### Prasyarat

Pastikan perangkat telah memenuhi persyaratan berikut:

* Sistem operasi Windows.
* Visual Studio 2019 atau versi lebih baru yang kompatibel dengan proyek.
* Workload **.NET desktop development** telah terpasang.
* Printer thermal telah terpasang dan dikonfigurasi apabila ingin menggunakan fitur pencetakan.

> **Catatan:** Versi .NET Framework yang dibutuhkan mengikuti konfigurasi proyek di Visual Studio.

### 1. Clone Repositori

Jalankan perintah berikut melalui terminal:

```bash
git clone https://github.com/RylVa000/RylVa_CampStore.git
```

### 2. Buka Proyek

1. Buka folder repositori yang telah diunduh.
2. Cari berkas `RylVaCampStore.sln`.
3. Buka berkas tersebut menggunakan Visual Studio.
4. Tunggu hingga proses pemuatan proyek selesai.

### 3. Jalankan Aplikasi

1. Pastikan proyek berhasil dimuat tanpa kesalahan konfigurasi.
2. Pilih konfigurasi **Debug**.
3. Tekan **F5** atau klik tombol **Start** untuk menjalankan aplikasi.

### 4. Build Aplikasi

Untuk membuat hasil kompilasi:

1. Pilih menu **Build → Build Solution**.
2. Tunggu hingga proses kompilasi selesai.
3. Periksa folder keluaran proyek, biasanya `bin/Debug` atau `bin/Release`, sesuai konfigurasi build.

> **Catatan:** Lokasi dan keberadaan berkas `.exe` bergantung pada konfigurasi proyek serta hasil proses build.

---

## 📖 Panduan Penggunaan

### 1. Login

Masuk menggunakan akun Admin atau Kasir yang telah terdaftar di aplikasi.

### 2. Dashboard dan Katalog

Jelajahi katalog barang dan pilih produk berdasarkan kategori yang tersedia, seperti tenda, tas, dan perlengkapan memasak.

### 3. Transaksi

Tambahkan barang ke keranjang, tentukan jenis transaksi pembelian atau penyewaan, lalu pilih metode pembayaran yang tersedia.

### 4. Pembayaran dan Validasi

Periksa rincian transaksi, kemudian lakukan pembayaran. Setelah transaksi berhasil diproses, sistem akan menjalankan mekanisme pencatatan transaksi dan pembaruan stok sesuai implementasinya.

### 5. Manajemen Admin

Gunakan panel Admin untuk mengakses fitur pengelolaan data, memantau informasi penjualan, mencadangkan data, dan menghapus riwayat yang tidak lagi diperlukan.

---

## 🛠️ Troubleshooting

### Mengatasi Error Print Spooler

Apabila muncul pesan seperti `Local print spooler service is not running`, layanan pencetakan Windows mungkin sedang tidak aktif.

Ikuti langkah berikut:

1. Tekan **Windows + R**.
2. Ketik `services.msc`, kemudian tekan **Enter**.
3. Cari layanan **Print Spooler**.
4. Klik kanan layanan tersebut, lalu pilih **Start** atau **Restart**.
5. Jika diperlukan, buka **Properties** dan atur **Startup type** menjadi **Automatic**.

Setelah layanan aktif, coba jalankan kembali fitur pencetakan.

### Masalah Umum Lainnya

* **Aplikasi tidak dapat dijalankan:** Periksa konfigurasi proyek dan versi .NET Framework yang diperlukan.
* **Data tidak terbaca:** Pastikan berkas data tersedia pada lokasi yang diharapkan aplikasi.
* **Struk tidak tercetak:** Periksa koneksi printer, status perangkat, pemilihan printer, dan antrean cetak Windows.
* **Build gagal:** Periksa pesan kesalahan pada jendela *Error List* di Visual Studio.

---

## 🔮 Rencana Pengembangan

Beberapa pengembangan yang dapat dipertimbangkan untuk meningkatkan fungsionalitas dan keamanan aplikasi:

* **Migrasi Basis Data:** Mengembangkan penyimpanan dari Flat-File menuju sistem RDBMS, seperti MySQL atau Microsoft SQL Server.
* **Keamanan Kata Sandi:** Menggunakan algoritma *password hashing* yang sesuai, seperti Argon2id, bcrypt, atau PBKDF2, dengan salt untuk melindungi kredensial pengguna.
* **Ekspor Laporan:** Menambahkan kemampuan ekspor laporan penjualan ke format PDF atau Excel (`.xlsx`).
* **Pengembangan Laporan:** Memperluas analisis penjualan dan penyajian informasi inventaris.
* **Peningkatan Pengelolaan Data:** Memperkuat validasi, konsistensi penyimpanan, dan mekanisme pemulihan data.

---

## 👨‍💻 Profil Pengembang

| Informasi          | Detail                                   |
| ------------------ | ---------------------------------------- |
| Nama Pengembang    | Berryl Zelva                             |
| Status             | Siswa Kelas X RPL C                      |
| Instansi/Sekolah   | SMK Negeri 1 Cimahi                        |
| GitHub             | [@RylVa000](https://github.com/RylVa000) |
| Instagram          | [@Va_RylVa](https://www.instagram.com/va_rylva       |

---

## 📄 Lisensi

Proyek ini didistribusikan di bawah **MIT License**. Anda bebas menggunakan, memodifikasi, dan mendistribusikan ulang kode ini untuk keperluan pembelajaran maupun pengembangan lebih lanjut.

---

**RylVa Camp Store**
*Didesain dan dikembangkan untuk memenuhi Tugas Akhir (TA) Rekayasa Perangkat Lunak.*
