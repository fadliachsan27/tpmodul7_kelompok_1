using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class DataMahasiswa_103022330051
{
    public Nama nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }
}

public class MataKuliah
{
    public string code { get; set; }
    public string name { get; set; }
}

public class KuliahMahasiswa_103022330051
{
    public List<MataKuliah> MataKuliah { get; set; }
}

class Program
{
    static void Main()
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Baca JSON 1
            string jsonMahasiswa = File.ReadAllText("tp7_1_103022330051.json");
            DataMahasiswa_103022330051 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_103022330051>(jsonMahasiswa, options);

            Console.WriteLine("=== Data Mahasiswa ===");
            Console.WriteLine($"Nama     : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"NIM      : {mahasiswa.nim}");
            Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
            Console.WriteLine();

            // Baca JSON 2
            string jsonMK = File.ReadAllText("tp7_2_103022330051.json");
            KuliahMahasiswa_103022330051 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa_103022330051>(jsonMK, options);

            Console.WriteLine("=== Daftar Mata Kuliah ===");
            int i = 1;
            foreach (var mk in kuliah.MataKuliah)
            {
                Console.WriteLine($"MK {i}: {mk.code} - {mk.name}");
                i++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Gagal membaca file: " + e.Message);
        }

        Console.ReadLine();
    }
}
