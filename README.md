# KALKULATOR_APP
Nama  : Hidayah Nur Septiani <br>
NRP   : 5025241247 <br>
Kelas : PBKK C <br>

<div align="center">

# DOKUMENTASI

<img width="336" height="417" alt="image" src="https://github.com/user-attachments/assets/e10e29bd-8773-4c36-833a-852f9574b212" />

<br><br>

<video src="https://github.com/user-attachments/assets/79746d12-e891-435f-a159-f7cc8659b93c" controls width="80%">
</video>

</div>

<br>

# PENJELASAN

Pada Pemrograman Kalkulator terdapat 3 file inti :

**1. Form1.cs**<br>
file ini berisi codingan mengenai bagaimana logika utama dari kalkulator yang dibuat.
terdapat fungsi-fungsi yang mengatur cara kerja kalkulator, salah satunya fungsi fokus. <br>
 private void fokus()<br>
 {<br>
     textutama.Focus();<br>
     textutama.Select(textutama.Text.Length, 1);<br>
 }<br>
Fungsi ini berguna untuk mengembalikan fokus aktif/kursor ke kotak teks (textutama) setelah tombol ditekan, sekaligus memastikan posisi kursor berada di paling ujung kanan agar siap menerima input berikutnya tanpa kendala tampilan.<br>

**2. Form1.Designer.cs**<br>
file ini berisi konfigurasi UI yang secara otomatis dikelola oleh Visual Studio, seperti deklarasi komponen, method initializeComponent(), dan method Dispose().<br>

**3. Form1.cs[Design]**<br>
file ini adalah kanvas interaktif untuk merancang UI aplikasi, yang dimana kita bisa drag and drop button, textbox, label dan masih banyak lagi. Ketika terdapat button atau kotak teks di kanvas jendela properties akan menampilkan pengaturannya seperti warna background, size, font dan lain-lain.<br>

# Fitur Aplikasi<br>
- **Operasi Aritmatika:** Penjumlahan (+), Pengurangan (-), Perkalian (*), dan Pembagian (/).
- **Bilangan Desimal (Koma):** Mendukung perhitungan pecahan dengan tombol koma/titik.
- **Eksekusi Hasil (=):** Menghitung total operasi matematika secara instan.
- **Reset/Clear:** Membersihkan tampilan dan mereset memori perhitungan kembali ke awal.
