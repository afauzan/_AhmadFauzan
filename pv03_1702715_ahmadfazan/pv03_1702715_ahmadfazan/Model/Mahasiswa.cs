using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pv03_1702715_ahmadfazan.Model
{
    class Mahasiswa
    {
        public Mahasiswa(int id, String nim, String nama)
        {
            Id = id;
            Nim = nim;
            Nama = nama;
        }

        public Mahasiswa()
        {

        }

        public int Id{ get; set; }
        public String Nim { get; set; }
        public String Nama { get; set; }
    }
}
