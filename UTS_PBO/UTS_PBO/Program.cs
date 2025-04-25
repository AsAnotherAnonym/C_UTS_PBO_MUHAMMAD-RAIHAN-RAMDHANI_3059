using System;
using System.Runtime.CompilerServices;
using LayananDigitalBank;

namespace LayananDigitalBank;
{
    abstract class user;
    {
        private int nomorRekening;
        private string nama;
        private int saldo;

        public int NomorRekening
        {
            get { return nomorRekening; }
            set { nomorRekening = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public AkunBank(int nomor, string nama, int saldoAwal)
        {
            NomorRekening = nomor;
            Nama = nama;
            Saldo = saldoAwal;
        }

        public virtual void Info()
        {
            Console.WriteLine("Nama: " + Nama);
            Console.WriteLine("Nomor Rekening: " + NomorRekening);
            Console.WriteLine("Saldo: Rp" + Saldo);
        }
    }
    
    public class tarikDana(int nomorRekening, string nama, int saldo) : user;
    {
        
    }
        
    public class setorDana(int nomorRekening, string nama, int saldo) : user;
    {
        
    }
        
    public class transferDana(int nomorRekening, string nama, int saldo) : user;
    {
         
    }
        
    class Program;
    {
        static void Main()
        {
            Console.WriteLine("1. Tarik Saldo");
            Console.WriteLine("2. Setor Saldo");
            Console.WriteLine("3. Transfer Saldo");
            Console.WriteLine("Silahkan pilih anda ingin melakukan apa");
            


            Console.ReadLine("Masukkan Nomor:");
            Console.ReadLine("Masukkan Nama :");
            Console.ReadLine("Masukkan Saldo:");   
        }
    }
}
