/*
Nama        : Mohamad Lutfi
NIM         : 1302204066
Kelas       : SE-44-02
 */

using System;

namespace modul3_1302204066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ MENCARI KODE BUAH ------------");
            Console.WriteLine("Daftar buah yang terssedia: ");
            Console.WriteLine("1. Apel          " + " 8. Kelapa");
            Console.WriteLine("2. Aprikot       " + " 9. Jagung");
            Console.WriteLine("3. Alpukat       " + " 10. Kurma");
            Console.WriteLine("4. Pisang        " + " 11. Durian");
            Console.WriteLine("5. Paprika       " + " 12. Anggur");
            Console.WriteLine("6. Blackberry    " + " 13. Melon");
            Console.WriteLine("7. Ceri          " + " 14. Semangka");

            Console.Write("Masukkan nama buah: ");
            string masukan = Console.ReadLine();
            if (masukan == "")
            {
                Console.Write("*Anda tidak memasukkan nama buah" + "\n");
            }

            KodeBuah kodeBuah = new KodeBuah();
            Console.WriteLine("Kode Buah "+ masukan + ": " + kodeBuah.getKodeBuah(masukan) + "\n");

        }
    }
}