using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Mzt.Partners.Interfaces.Talmid
{
    public class TalmidGormeyKesher
    {
        public int SUG_ZEHUT_TALMID { get; set; }
        public int MISPAR_ZEHUT_TALMID { get; set; }
        public int SEMEL_MOSAD_TALMID { get; set; }
        public int SUG_ZEHUT_GOREM_KESHER { get; set; }
        public int MISPAR_ZEHUT_GOREM_KESHER { get; set; }
        public int SUG_ZEHUT_KODEM_G_KESHER { get; set; }
        public int MISPAR_ZEHUT_KODEM_G_KESHER { get; set; }
        public int CODE_SUG_YESHUT_GOREM_KESHER { get; set; }
        public int MZT_KESHER_GOREM_TALMID_PARIT { get; set; }
        public int CODE_MAAMAD_HORE_GOREM_KESHER { get; set; }
        public int CODE_SUG_KIRVA_GOREM_KESHER { get; set; }
        //public int HAIM_ACHRAI_GOREM_KESHER { get; set; }
        public int HAIM_MESHALEM_GOREM_KESHER { get; set; }
        public int SEMEL_MOSAD_GOREM_KESHER { get; set; }
        public DateTime TAARICH_HATCHALA_GOREM_KESHER { get; set; }
        public DateTime TAARICH_SIYUM_GOREM_KESHER { get; set; }
        public string SHEM_PRATI_GOREM_KESHER { get; set; }
        public string SHEM_MISHPACHA_GOREM_KESHER { get; set; }
        public int SFAT_DIBUR_GOREM_KESHER { get; set; }
        public string ISUK_GOREM_KESHER { get; set; }
        public int CODE_ERETS_LEDA_GOREM_KESHER { get; set; }
        public DateTime TAARICH_LEDA_KOVEA_GOREM_KESHER { get; set; }
        public string DARKON_GOREM_KESHER { get; set; }
        //public int ERETS_DARKON_GOREM_KESHER { get; set; }
        public int MISPAR_SHNOT_LIMUD_GOREM_KESHER { get; set; }
        public int DIVUACH_MATSAV_MISHPAHTI_GOREM_KESHER { get; set; }
        public int HAIM_NIFTAR_GOREM_KESHER { get; set; }
        public DateTime TAARICH_IDKUN_PRATIM_GOREM_KESHER { get; set; }
        public string CODE_MISHTAMESH_MEADKEN_PRATIM_GOREM_KESHER { get; set; }
        public List<GoremKesherEmail> GOREM_KESHER_EMAIL_LIST { get; set; }
        public List<GoremKesherTelephone> GOREM_KESHER_TELEPHONE_LIST { get; set; }
        public List<GoremKesherKtovet> GOREM_KESHER_KTOVET_LIST { get; set; }
    }
}
