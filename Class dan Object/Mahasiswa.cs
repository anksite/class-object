using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_dan_Object {
    class Mahasiswa {

        //properties
        //public string nim { get; set; }
        //public string nama { get; set; }
        //public double ipk { get; set; }

        public string nim;
        public string nama;
        public float ipk;

        public Mahasiswa(string nim, string nama, float ipk) {
            this.nim = nim;
            this.nama = nama;
            this.ipk = ipk;
        }

        public void registrasi() {
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("NIM  : {0}", nim);
            Console.WriteLine("IPK  : {0}", ipk);
            Console.WriteLine("Telah melakukan registrasi!");
        }

        public void isiKrs() {
            Console.WriteLine("{0} sedang mengisi KRS", nama);
        }
    }
}
