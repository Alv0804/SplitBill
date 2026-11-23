# SplitBill

A modern Windows Forms Desktop application built with **.NET 10 (Visual Basic .NET)** and **Supabase (PostgreSQL)** to manage group activities, track dining/hangout orders, calculate bill splitting with proportional tax and discounts, and streamline payment confirmations.

---

## 🚀 Fitur Utama

- **Manajemen Kegiatan / Grup**: Buat grup nongkrong, makan bersama, patungan sewa tempat, atau perjalanan wisata bersama teman.
- **Sistem Undangan & Keanggotaan Fleksibel**:
  - Kode undangan unik 8 karakter dengan tombol salin & regenerasi (khusus Admin / Pembuat Grup).
  - Mode Instant Join (langsung bergabung tanpa perlu persetujuan) atau Request Join.
  - Tambah teman langsung dengan nama unik (mencegah duplikasi nama di dalam satu kegiatan).
  - Sinkronisasi otomatis: Anggota dengan nama yang sama dengan display name pengguna akan otomatis tertaut ke akun saat login.
- **Pencatatan Menu & Pesanan**:
  - Catat pesanan per anggota dengan mudah (nama item, harga, porsi, catatan).
  - Status pesanan (Pending, Approved).
  - Opsi penagihan otomatis dari daftar pesanan: pesanan yang sudah dibuatkan tagihan otomatis diarsipkan dari daftar pesanan aktif.
- **Split Bill Pintar & Akurat**:
  - **Bagi Rata (Equal Split)**: Total biaya dibagi sama rata ke semua anggota terpilih.
  - **Bayar Sendiri-Sendiri (Order Items + Tax / Service Charge Proporsional)**: Biaya pesanan masing-masing anggota dihitung akurat ditambah proporsi pajak, biaya layanan, dan diskon.
- **Tagihan & Konfirmasi Pembayaran Terpusat**:
  - Tampilan ringkasan siapa membayar kepada siapa.
  - **Member Role**: Anggota dapat menandai status pembayaran mereka sendiri (`✓ Saya Sudah Bayar`).
  - **Owner / Host Role**: Pembuat grup memiliki kontrol penuh untuk memverifikasi dan mengonfirmasi pembayaran (`✓ Konfirmasi Diterima`) serta menyelesaikan seluruh kegiatan.
- **Dashboard Interaktif**:
  - Ringkasan kegiatan aktif, riwayat selesai, kontak tersimpan, dan tempat favorit.
  - Kartu kegiatan responsif dengan navigasi cepat.

---

## 🛠️ Tech Stack & Arsitektur

- **Language & Framework**: .NET 10.0 Windows Forms (Visual Basic .NET)
- **Database & Backend**: [Supabase](https://supabase.com/) (PostgreSQL 15+, Row-Level Security, RPC Functions)
- **Unit Testing**: xUnit, Microsoft.NET.Test.Sdk
- **Struktur Proyek**:
  - `SplitBill.App`: Antarmuka pengguna (Windows Forms UI, custom controls, form dialogs).
  - `SplitBill.Core`: Domain models, logika kalkulasi split bill, kalkulasi pajak/diskon proporsional.
  - `SplitBill.Data`: Repository layer, integrasi Supabase REST API & RPC, session manager, credential handling.
  - `SplitBill.Tests`: Unit test untuk validasi keakuratan kalkulasi pembagian biaya dan logika bisnis.
  - `supabase/`: Skrip migrasi database SQL terstruktur (`migrations/`) dan seed data.

---

## ⚙️ Persyaratan Sistem & Instalasi

### 1. Prasyarat
- [.NET 10 SDK](https://dotnet.microsoft.com/download) atau lebih baru.
- [Visual Studio 2022 / 2026](https://visualstudio.microsoft.com/) dengan workload *.NET Desktop Development*.
- Akun atau instance lokal [Supabase](https://supabase.com/).

### 2. Konfigurasi Database (Supabase)
Jalankan file SQL migrasi yang ada di folder `supabase/migrations/` pada **Supabase SQL Editor** Anda secara berurutan:
1. `202611210001_initial_schema.sql`
2. `202611220001_onboarding_rpc.sql`
3. `202611230001_group_management_rpc.sql`
4. `202611240001_expenses_and_settlement_rpc.sql`
5. `202611250001_instant_join_rpc.sql`
6. `202611250002_unique_member_names.sql`
7. `202611250003_auto_link_members.sql`
8. `202611250004_link_orders_to_expense.sql`

### 3. Konfigurasi Kredensial Lingkungan
Aplikasi membaca konfigurasi Supabase secara aman melalui Environment Variables:
- `SPLITBILL_SUPABASE_URL`: URL project Supabase Anda (misal `https://xyz.supabase.co`).
- `SPLITBILL_SUPABASE_ANON_KEY`: Anon / public API key Supabase Anda.

*(Opsional untuk development lokal: Anda juga dapat meletakkannya di `%APPDATA%\SplitBill\appsettings.local.json`)*.

---

## 🏃 Cara Menjalankan

### Melalui Terminal / CLI:
```bash
# Clone repository
git clone https://github.com/Alv0804/SplitBill.git
cd SplitBill

# Restore & Build
dotnet restore
dotnet build

# Jalankan Unit Tests
dotnet test

# Jalankan Aplikasi
dotnet run --project SplitBill.App
```

### Melalui Visual Studio:
1. Buka file solusi `SplitBill.sln` atau `PROJECT UAS.slnx`.
2. Set `SplitBill.App` sebagai *Startup Project*.
3. Tekan **F5** atau klik tombol **Start** untuk menjalankan aplikasi.

---

## 📄 Lisensi
Proyek ini dikembangkan untuk keperluan akademik dan open source. Silakan digunakan dan dikembangkan lebih lanjut.
