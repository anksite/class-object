using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_dan_Object {

    class Program {

        static void Main(string[] args) {
            Mahasiswa saya = new Mahasiswa("18.11.3344", "Andi", 3.20f);
            saya.registrasi();
            saya.isiKrs();

            Console.WriteLine("\n\n");

            Mahasiswa kamu = new Mahasiswa("18.11.1234", "Reno", 3.50f);
            kamu.registrasi();
            kamu.isiKrs();

            Console.ReadKey();
        }
    }
}
