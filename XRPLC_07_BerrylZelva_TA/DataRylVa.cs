using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel; 


namespace XRPLC_07_BerrylZelva_TA
{
    //class yang nampung seluruh barang di keranjang
    public class Keranjang
    {
        public string Nama
        {
            get; set;
        }
        public int hargaSatuan
        {
            get; set;
        }
        public int qty
        {
            get; set;
        }
        public int lamaSewa
        {
            get; set;
        } = 1;
        public int subtotal
        {
            get
            {
                return hargaSatuan * qty * lamaSewa;
            }
        }

    } 

    public static class DatabaseRylVa
    {
        public static string pilihanMode = "";
        public static string MetodeBayar = "";
        public static string akunLogin = "";
        public static string akunLogout = "";
        public static string statusPesanan = "";
        public static int totalPayment = 0;
        public static string back = ""; 
        public static bool logoutSewa = false;
        public static bool logoutBeli = false;
        public static bool sudahBayar = false;

        public static string GetFolderApp()
        {
            //mendapatkan alamat folder komputer, terutama file dokumen tempat database dibentuk
            string folderDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderApp = Path.Combine(folderDoc, "RylVaCampStore");

            if (!Directory.Exists(folderApp))
            {
                Directory.CreateDirectory(folderApp);
            }
            return folderApp;
        }

        public static string FilePengguna //buat/edit filePenguna
        {
            get 
            { 
                return Path.Combine(GetFolderApp(), "DataPengunaRylVa.txt"); 
            }
        }

        public static string FileBarang//buat/edit fileBarang
        {
            get 
            { 
                return Path.Combine(GetFolderApp(), "DataBarangRylVa.txt"); 
            }
        }

        public static string FilePesanan//buat/edit filePesanan
        {
            get
            {
                return Path.Combine(GetFolderApp(), "DataPesananRylVa.txt");
            }
        }

        public static string Waktu
        {
            get
            {
                return DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        public static string KodeAntri
        {
            get
            {
                string pathFile = DatabaseRylVa.FilePesanan;
                int nomorAntrian = 1;

                if (File.Exists(pathFile))
                {
                    //mengambil data untuk nentuin nomor antrian
                    string[] semuaData = File.ReadAllLines(pathFile);
                    int maxID = 0;
                    foreach (string baris in semuaData)
                    {
                        if (string.IsNullOrWhiteSpace(baris))
                        {
                            continue;
                        }

                        string[] Data = baris.Split(';');

                        string IDNow = Data[0];
                        string[] belahID = IDNow.Split('-');

                        if (belahID.Length == 2)
                        {
                            if (int.TryParse(belahID[1].Trim(), out int IDBaru))
                            {
                                if (IDBaru > maxID)
                                {
                                    maxID = IDBaru;
                                }
                            }
                        }
                    }
                    nomorAntrian = maxID + 1;
                }

                return $"RylVa - {nomorAntrian}";
            }
        }

        public static string FolderGambar
        {
            get
            {
                //mengambil berdasarkan alamat dan nama file
                string folderImg = Path.Combine(GetFolderApp(), "Images");
                if (!Directory.Exists(folderImg))
                {
                    Directory.CreateDirectory(folderImg);
                }
                return folderImg;
            }
        }

        //menampung isi class keranjang kedalam sebuah list utama 
        public static BindingList<Keranjang> daftarbelanja = new BindingList<Keranjang>();

    }
}
