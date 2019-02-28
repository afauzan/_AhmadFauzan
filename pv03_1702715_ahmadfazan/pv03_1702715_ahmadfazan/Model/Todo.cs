using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pv03_1702715_ahmadfazan.Model
{
    class Todo
    {
        

        public Todo()
        {

        }

        public Todo(int id, string nimMhs, String nama, String kategori)
        {
            Id = id;
            NimMhs = nimMhs;
            Nama = nama;
            Kategori = kategori;

        }

        public int Id { get; set; }
        public string NimMhs { get; set; }
        public string Nama { get; set; }
        public string Kategori { get; set; }

        
    }

    

    
}
