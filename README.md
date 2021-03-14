# Perbandingan Gambar
Program ini dibuat untuk menyelesaikan salah satu tugas mata kuliah Metodologi Peneltian. Program ini akan melakukan perbandingan pada 2 (dua) gambar untuk melihat apakah gambar tersebut SAMA, MIRIP, atau BEDA.

## Teori
Program ini menggunakan Root Mean Square Error (RMSE) untuk mengukur perbedaaan dari gambar yang akan dibandingkan.

## Metode 
Langkah - langkah yang digunakan untuk melakukan perbandingan gambar:
1. Melakuakan resize pada Gambar1 dan Gambar2 menjadi 64 x 64 pixel.
2. Lakukan nested loop (width x height) dari salah satu gambar.
3. Ambil nilai RGB dari tiap pixel Gambar1 dan Gambar2, lalu jumlahkan nilai tersebut (R+G+B).
4. Jumlahkan delta (selisih) dari penjumlahan RGB tiap pixel Gambar1 dan Gambar2.
5. Ulangi langkah 3 dan 4 diatas sampai langkah 2 selesai.
6. Bagi nilai delta tersebut dengan ukuran gambar (64 x 64 pixel)
7. Lalu ambil nilai kuadratkan dari hasil langkah 6.

## Kriteria
Kriteria yang digunakan untuk menentukan apakah gambar tersebut SAMA, MIRIP, atau beda:
- Jika nilai RMSE == 0, Maka "KEDUA GAMBAR SAMA"
- Jika nilai RMSE > 0 dan RMSE < 0.01, Maka "KEDUA GAMBAR MIRIP"
- Jika nilai RMSE > 0.01, Maka "KEDUA GAMBAR BERDEBDA"

## Fitur
- Dapat memilih gambar yang akan dibandingkan.
- Dapat melihat matriks dari gambar yang dibandingkan.
- Dapat menentukan apakah gambar tersebut SAMA, MIRIP, atau BEDA.

## Teknologi
- Visual Studio 2019 Community
- C#
- .NET Framework 3.5

## Penggunaan
Sebelum anda menggunakan program ini tentukan path yang akan digunakan untuk menyimpan hasil matriks.
```
# Pada Form1.cs, tentukan:
private string pathHasil1 = @"D:\[UBAH-PATH-INI]\MatriksRGB_Gambar1.txt";
private string pathHasil2 = @"D:\[UBAH-PATH-INI]\MatriksRGB_Gambar2.txt";
```