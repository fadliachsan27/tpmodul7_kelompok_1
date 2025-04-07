using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa_103022300018
{
    public class Mahasiswa
    {
        public string nama_depan { get; set; }
        public string nama_belakang { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void ReadJSON()
    {
        try
        {
            string jsonText = File.ReadAllText("tp7_1_103022300018.json");
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonText);
            Console.WriteLine($"Nama {data.nama_depan} {data.nama_belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca file JSON: " + ex.Message);
        }
    }

    public static void Main(string[] args)
    {
        DataMahasiswa_103022300018.ReadJSON();
        KuliahMahasiswa_103022300018.ReadJSON();
    }
}
