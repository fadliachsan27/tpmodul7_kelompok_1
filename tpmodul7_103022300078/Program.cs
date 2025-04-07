using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

/*public class DataMahasiswa103022300078
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
                string filePath = "tp7_1_103022300078.json";

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
}*/

public class MataKuliah
{
    public string code { get; set; }
    public string name { get; set; }
}

public class KuliahMahasiswa_103022300078
{
    public List<MataKuliah> MataKuliah { get; set; }

    public void ReadJSON()
    {
        try
        {
            string json = File.ReadAllText("tp7_2_103022300078.json");
            KuliahMahasiswa_103022300078 data = JsonSerializer.Deserialize<KuliahMahasiswa_103022300078>(json);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in data.MataKuliah)
            {
                Console.WriteLine($"MK {i} {mk.code} - {mk.name}");
                i++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Gagal membaca file: " + e.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        KuliahMahasiswa_103022300078 mhs = new KuliahMahasiswa_103022300078();
        mhs.ReadJSON();
        Console.ReadLine();
    }
}



