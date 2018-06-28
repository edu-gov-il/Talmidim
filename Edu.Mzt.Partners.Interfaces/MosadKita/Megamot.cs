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
        public int SEMEL_MISGERET_IRGUNIT { get; set; }
        public int SHICHVA { get; set; }
        public int SEMEL_MEGAMA { get; set; }
        public long SIDURI_MEGAMA_MOSAD { get; set; }
        public string KINUI_MEGAMA { get; set; }
        public int? MICHSAT_TALMIDIM_MEVUKESHET { get; set; }
        public int? MICHSAT_TALMIDIM { get; set; }
        public int STATUS_ISHUR_MEGAMA { get; set; }
        public DateTime? TAARICH_STATUS_ISHUR_MEGAMA { get; set; }
        public string HEARA_STATUS_ISHUR_MEGAMA { get; set; }
        public int PAIL { get; set; }
        public DateTime? TAARICH_HATCHALA { get; set; }
        public DateTime? TAARICH_SIYUM { get; set; }

        public DateTime TAARICH_IDKUN { get; set; }
        public string CODE_MISHTAMESH_MEADKEN { get; set; }
    }

}
