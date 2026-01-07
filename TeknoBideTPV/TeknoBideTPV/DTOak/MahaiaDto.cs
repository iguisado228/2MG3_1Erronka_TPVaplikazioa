using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoBideTPV.DTOak
{
    public class MahaiDto
    {
        public int Id { get; set; }
        public int Zenbakia { get; set; }
        public int PertsonaKopurua { get; set; }
        public string Kokapena { get; set; } = string.Empty;
    }
}
