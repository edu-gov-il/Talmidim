using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Mzt.Partners.Interfaces.MosadKita
{
    public class MegamaInfo
    {
        public int SHNAT_LIMUDIM { get; set; }
        public int SEMEL_MOSAD { get; set; }
        public long ID_MEGAMA { get; set; }
        public int SEMEL_MEGAMA { get; set; }
        public long SEMEL_MEGAMA_MOSAD { get; set; }
        public string SHEM_MEGAMA_MOSAD { get; set; }
        public DateTime TAARICH_IDKUN_MEGAMA { get; set; }
        public DateTime? TAARICH_SIYUM_MEGAMA { get; set; }
        public int SHICHVA { get; set; }
        public int? MICHSAT_TALMIDIM_MEVUKESHET { get; set; }
        public int? MICHSAT_TALMIDIM { get; set; }
        public int STATUS_ISHUR_MEGAMA { get; set; }
        public DateTime? TAARICH_STATUS_ISHUR_MEGAMA { get; set; }
        public string HEARAT_STATUS_ISHUR_MEGAMA { get; set; }
        public int SHIBUTZ { get; set; }
        public DateTime? TAARICH_HATCHALA_SHICHVA { get; set; }
        public DateTime? TAARICH_SIYUM_SHICHVA { get; set; }
        public DateTime TAARICH_IDKUN_SHICHVA { get; set; }
        public string CODE_MISHTAMESH_MEADKEN { get; set; }
        public DateTime TAARICH_IDKUN_MEGAMA_ISHUR { get; set; }
        public DateTime? TAARICH_SIYUM_MEGAMA_ISHUR { get; set; }
    }



}
