using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class DaftarKuliah
    {
        public List<MataKuliah> mata_kuliah { get; set; }
    }

    public class KuliahMahasiswa_103022300018
    {
        public static void ReadJSON()
        {
            try
            {
                string path = "tp7_2_103022300018.json";
                string jsonString = File.ReadAllText(path);
                DaftarKuliah data = JsonSerializer.Deserialize<DaftarKuliah>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int index = 1;
                foreach (var mk in data.mata_kuliah)
                {
                    Console.WriteLine($"MK {index} {mk.code} - {mk.name}");
                    index++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Gagal membaca file JSON: {e.Message}");
            }
        }
    }
