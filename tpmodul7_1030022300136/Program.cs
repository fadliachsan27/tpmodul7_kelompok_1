using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa_103022300136
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }

    class Program
    {
        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_1_103022300136.json";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File tidak ditemukan: {filePath}");
                    return;
                }

                string jsonData = File.ReadAllText(filePath);
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonData);

                if (mhs != null && mhs.nama != null)
                {
                    Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
                }
                else
                {
                    Console.WriteLine("Data mahasiswa kosong atau format JSON tidak sesuai.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal membaca file: " + e.Message);
            }
        }

        static void Main(string[] args)
        {
            ReadJSON();
            Console.ReadLine();
        }
    }
}

