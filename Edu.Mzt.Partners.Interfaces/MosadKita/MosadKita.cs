using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Mzt.Partners.Interfaces.MosadKita
{
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
        public int? STATUS_ISHUR_AGAF { get; set; }
        public DateTime? TAARICH_ISHUR_MATE { get; set; }
        public DateTime? TAARICH_ISHUR_AGAF { get; set; }
        public int? STATUS_ISHUR_MATE { get; set; }
        public string HEARAT_ISHUR { get; set; }
        public int SHIBUTZ { get; set; }
        public int SEMEL_MEGAMA_LE_DIPLOMA { get; set; }
        public DateTime TAARICH_HATCHALA { get; set; }
        public DateTime? TAARICH_SIYUM { get; set; }
        public DateTime TAARICH_IDKUN { get; set; }
        public string CODE_MISHTAMESH_MEADKEN { get; set; }
        public IList<Mechanech> MECHANCHIM { get; set; }
    }

    public class MosadInfo
    {
        public int SHNAT_LIMUDIM { get; set; }
        public int SEMEL_MOSAD { get; set; }
        public string SHEM_MOSAD { get; set; }
        public string SHEM_LE_BAGRUT { get; set; }
        public int SEMEL_RECHOV { get; set; }
        public string SHEM_RECHOV { get; set; }
        public int? MISPAR_BAYIT { get; set; }
        public int SEMEL_YISHUV { get; set; }
        public int? MACHOZ_GEOGRAFI { get; set; }
        public int? KIDOMET_TELEPHONE { get; set; }
        public int? TELEPHONE_MOSAD { get; set; }
        public int? KIDOMET_FAX { get; set; }
        public int? MIS_FAX { get; set; }
        public int? SEMEL_YISHUV_MICHTAVIM { get; set; }
        public int? MIKUD_MICHTAVIM { get; set; }
        public int GOREM_MEDAVEACH { get; set; }
        public DateTime? TAARICH_YESUD { get; set; }
        public int? MUTAV { get; set; }
        public int? SUG_ZEHUT_MENAHEL { get; set; }
        public int? MIS_ZEHUT_MENAHEL { get; set; }
        public string SHEM_MENAHEL { get; set; }
        public int? ZEHUT_MEFAKEACH { get; set; }
        public string SHEM_MEFAKEACH { get; set; }
        public int? SUG_PIKUACH { get; set; }
        public int ME_SHICHVA_MEUSHAR { get; set; }
        public int AD_SHICHVA_MEUSHAR { get; set; }
        public int SHLAVE_CHINUCH_MEUSHARIM { get; set; }
        public int YESODI_MEUSHAR { get; set; }
        public int CHATIVAT_BENAIM_MEUSHAR { get; set; }
        public int CHATIVA_ELIONA_MEUSHAR { get; set; }
        public int STATUS_MOSAD { get; set; }
        public int? STATUS_YESODI { get; set; }
        public int? STATUS_CHATAB { get; set; }
        public int? STATUS_ELYONA { get; set; }
        public int? HAKTZAA { get; set; }
        public int? SUG_EZOR_RISHUM { get; set; }
        public int SUG_MISGERET { get; set; }
        public int? CHINUCH { get; set; }
        public int MIGZAR { get; set; }
        public int? SFAT_HORAA { get; set; }
        public int? HERKEV { get; set; }
        public int? ZMAN_LIMUD { get; set; }
        public int? PNIMIYA_ZMUDA { get; set; }
        public string YEMEY_LIMUD_STR { get; set; }
        public int? NATIV { get; set; }
        public int MAAMAD_MISHPATI { get; set; }
        public string ZAKAUT_SCHAR_LIMUD { get; set; }
        public int? ZAKAUT_LE_MOCHZAKUT { get; set; }
        public float? ACHUZ_RAMAT_SHERUT { get; set; }
        public int? PROFIL_MORIM { get; set; }
        public int? MEGISH_LE_BAGRUT_KAYTZ { get; set; }
        public int? KOD_LE_TZIUN_KAYTZ { get; set; }
        public int? MEGISH_LE_BAGRUT_CHOREF { get; set; }
        public int? KOD_LE_TZIUN_CHOREF { get; set; }
        public int? TACHANAT_KLITA { get; set; }
        public int? MIS_ZEVET { get; set; }
        public DateTime TAARICH_IDKUN { get; set; }
        public string CODE_MISHTAMESH_MEADKEN { get; set; }
    }


}
