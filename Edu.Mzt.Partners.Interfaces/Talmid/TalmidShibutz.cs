using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Mzt.Partners.Interfaces.Talmid
{
    public class TalmidShibutz
    {
        public long MEZAHE_RESHUMA_SHIBUTZ { get; set; }
        public int SUG_ZEHUT { get; set; }
        public int MISPAR_ZEHUT { get; set; }        
        public int SEMEL_MOSAD { get; set; }
        public int SHNAT_LIMUDIM { get; set; }
        public DateTime TAARICH_HATCHALA { get; set; }
        public DateTime? TAARICH_SIYUM { get; set; }
        public int? TKINUT_SHIBUTZ { get; set; }   // 1= ok , 2 = not ok 
        public int? SHICHVA { get; set; }
        public int? MAKBILA { get; set; }        
        public int? SEMEL_MEGAMA_MISRAD { get; set; }
        public int? SEMEL_MEGAMA_MOSAD { get; set; }
        public int? CODE_NATIV { get; set; }
        public int? CODE_MASLUL { get; set; }
        public int? CODE_HASMACHA { get; set; }
        public int? CODE_STATUS_RISHUM_TA { get; set; }
        public DateTime? TAARICH_AZIVA { get; set; }
        public int? CODE_SIBAT_AZIVA { get; set; }
        public string PIRUT_AZIVA { get; set; }        
        public int? CODE_MAKOR_NATON_TALMID { get; set; }
        public int? CODE_ZAKAUT_LSCHAR_LIMUD { get; set; }
        public DateTime? TAARICH_IDKUN_SCHASR_LIMUD { get; set; }
        
        public int? CODE_IDKUN_SHIBUTZ { get; set; }        
        public string CODE_MISHTAMESH_YOTSER { get; set; }
        public DateTime TAARICH_YETSIRAT_RESHUMA { get; set; }
        public string CODE_MISHTAMESH_MEADKEN { get; set; }
        public DateTime TAARICH_IDKUN_RESHUMA { get; set; }

        public IEnumerable<ShgiyaShibutz> ShgiotShibutz { get; set; }

    }
}
