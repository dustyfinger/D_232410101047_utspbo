using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_232410101047_utspbo.App.Model
{
    public class M_Buku
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string judul { get; set; }
        [Required]
        public string pengarang { get; set; }
        [Required]
        public string tahun_terbit { get; set; }
        [Required]
        public string kategori { get; set; }
    }
}
