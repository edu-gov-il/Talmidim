using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Mzt.Partners.Interfaces.MosadKita
{
    // ttt
    public class MosadKita
    {
        public class Mechanech   
        {
            public int SUG_ZEHUT_MECHANECH { get; set; }
            public long MIS_ZEHUT_MECHANECH { get; set; }
            public string SHEM_PRATI { get; set; }
            public string SHEM_MISHPACHA { get; set; }
        }

        public int SHNAT_LIMUDIM { get; set; }
        public int SEMEL_MOSAD { get; set; }
        public int SHICHVA { get; set; }
        public int MAKBILA { get; set; }
        public long IDֹֹ_KITA { get; set; }
        public int SUG_KITA { get; set; }
        public string SHEM_KITA { get; set; }
        public int? HERKEV_KITA { get; set; }
        public int? MIN_TALMIDIM { get; set; }
        public int? MAX_TALMIDIM { get; set; }
        public int SHALAV_CHINUCH { get; set; }
        public int? STATUS_ISHUR_MATE { get; set; }
        public DateTime? TAARICH_ISHUR_MATE { get; set; }
        public string HEARAT_ISHUR { get; set; }
        public int SHIBUTZ { get; set; }
        public DateTime TAARICH_HATCHALA { get; set; }
        public DateTime? TAARICH_SIYUM { get; set; }
        public DateTime TAARICH_IDKUN { get; set; }
        public string CODE_MISHTAMESH_MEADKEN { get; set; }
        public IList<Mechanech> MECHANCHIM { get; set; }

    }
}
