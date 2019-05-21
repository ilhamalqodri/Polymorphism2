using System;

using Newtonsoft.Json;

namespace polymorphism2
{
    internal class ConvertToJson : IConvertObject
    {
        public object JsonConvert { get; private set; }

        public void Convert(Mahasiswa mhs)
        {
            string json = NewMethod(mhs);

            Console.WriteLine("Hasil konversi ke json :\n");
            Console.WriteLine(json);
        }

        private string NewMethod(Mahasiswa mhs)
        {
           
        }
    }
}
