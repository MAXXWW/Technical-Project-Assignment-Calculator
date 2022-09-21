using System;
namespace SkilvulTugas
{

    class CalculatorSederhana
    {
        static void Main(String[] args)
        {
            // Pembuka
            Console.WriteLine("========================================");
            Console.WriteLine("-------- CALCULATOR SEDERHANA ----------");
            Console.WriteLine("========================================");

            int ulang = 1; //kunci perulangan

            do
            {
                // Menerima input user
                Console.WriteLine("\nOperator Aritmatika");
                Console.WriteLine("1. + (Penjumlahan)\n2. - (Pengurangan)\n3. * (Perkalian)\n4. / (Pembagian)");
                Console.Write("\nPilih metode yang Anda inginkan: ");
                string Metode = Console.ReadLine() ?? "";
                int metode = int.Parse(Metode);

                //Operasi
                switch (metode)
                {
                    case 1:
                        float a, b, hasil;

                        Console.WriteLine("\n------------- PENJUMLAHAN --------------");
                        Console.Write("Masukkan angka ke-1 : ");
                        String A = MengambilInput();
                        a = float.Parse(A);
                        Console.Write("Masukkan angka ke-2 : ");
                        String B = MengambilInput();
                        b = float.Parse(B);

                        hasil = a + b;
                        Console.Write($"\nHasil dari penjumlahan {a} + {b} = {hasil}");

                        Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
                        string Pilihan = Console.ReadLine() ?? "";
                        char pilihan = char.Parse(Pilihan);

                        ulang = UlangProgram(pilihan);
                        break;
                    case 2:
                        Console.WriteLine("\n------------- PENGURANGAN --------------");
                        Console.Write("Masukkan angka ke-1 : ");
                        A = MengambilInput();
                        a = float.Parse(A);
                        Console.Write("Masukkan angka ke-2 : ");
                        B = MengambilInput();
                        b = float.Parse(B);

                        hasil = a - b;
                        Console.Write($"\nHasil dari penjumlahan {a} - {b} = {hasil}");

                        Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
                        Pilihan = Console.ReadLine() ?? "";
                        pilihan = char.Parse(Pilihan);

                        ulang = UlangProgram(pilihan);
                        break;
                    case 3:
                        Console.WriteLine("\n-------------- PERKALIAN ---------------");
                        Console.Write("Masukkan angka ke-1 : ");
                        A = MengambilInput();
                        a = float.Parse(A);
                        Console.Write("Masukkan angka ke-2 : ");
                        B = MengambilInput();
                        b = float.Parse(B);

                        hasil = a * b;
                        Console.Write($"\nHasil dari penjumlahan {a} * {b} = {hasil}");

                        Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
                        Pilihan = Console.ReadLine() ?? "";
                        pilihan = char.Parse(Pilihan);

                        ulang = UlangProgram(pilihan);
                        break;
                    case 4:
                        Console.WriteLine("\n-------------- PEMBAGIAN ---------------");
                        Console.Write("Masukkan angka ke-1 : ");
                        A = MengambilInput();
                        a = float.Parse(A);
                        Console.Write("Masukkan angka ke-2 : ");
                        B = MengambilInput();
                        b = float.Parse(B);

                        if (b == 0)
                        {
                            b = 0; //syarat
                            while (b == 0)
                            {
                                Console.Write("Masukkan angka ke-2 (selain 0): ");

                                B = MengambilInput();
                                b = float.Parse(B);
                            }
                        }

                        hasil = a / b;
                        Console.Write($"\nHasil dari penjumlahan {a} / {b} = {hasil}");

                        Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
                        Pilihan = Console.ReadLine() ?? "";
                        pilihan = char.Parse(Pilihan);

                        ulang = UlangProgram(pilihan);
                        break;
                    default:
                        Console.WriteLine("\n----------------------------------------");
                        Console.WriteLine("Pilih metode dengan benar!");
                        ulang = 1;
                        break;
                }
            } while (ulang == 1);
        }

        // Method yang berfungsi mengulang program
        static int UlangProgram(char pil)
        {
            if (pil == 'y' || pil == 'Y')
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Method yang berfungsi mengambil input dari user
        static string MengambilInput()
        {
            string Input = Console.ReadLine() ?? "";
            return Input;
        }
    }
}