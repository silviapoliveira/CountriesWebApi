using Newtonsoft.Json;
using System.IO;

namespace CountriesWebApi.Modelos
{
    public class Country
    {
        #region Propriedades

        public Name name { get; set; }

        public string CountryName
        {
            get
            {
                return $"{name.common}";
            }
            set
            {
                CountryName = value;
            }

        }
        public bool IsInternetAvailable { get; set; }
        public MapMarker marker { get; set; }
        public List<string> tld { get; set; }
        public string cca2 { get; set; }
        public string ccn3 { get; set; }
        public string cca3 { get; set; }
        public bool independent { get; set; }
        public string status { get; set; }
        public bool unMember { get; set; }
        public Currencies currencies { get; set; }
        public Idd idd { get; set; }
        public List<string> capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public Languages languages { get; set; }
        public Translations translations { get; set; }
        public List<double> latlng { get; set; }
        public bool landlocked { get; set; }
        public double area { get; set; }
        public Demonyms demonyms { get; set; }
        public string flag { get; set; }
        public Maps maps { get; set; }
        public int population { get; set; }
        public Car car { get; set; }
        public List<string> timezones { get; set; }
        public List<string> continents { get; set; }
        public Flags flags { get; set; }
        public CoatOfArms coatOfArms { get; set; }
        public string startOfWeek { get; set; }
        public CapitalInfo capitalInfo { get; set; }
        public PostalCode postalCode { get; set; }
        public string cioc { get; set; }
        public Gini gini { get; set; }
        public string fifa { get; set; }
        public List<string> borders { get; set; }

        #endregion

        #region Propriedades Readonly

        public string DisplayName
        {
            get
            {
                if (name?.common != null)
                {
                    return name.common;
                }
                else
                {
                    return "N/D";
                }
            }
        }

        public string DisplayCapital
        {
            get
            {
                if (capital != null && capital.Count > 0)
                {
                    return capital[0];
                }
                else
                {
                    return "N/D";
                }
            }
        }

        public string DisplayRegion
        {
            get
            {
                if (region != null)
                {
                    return region;
                }
                else
                {
                    return "N/D";
                }
            }
        }

        public string DisplaySubRegion
        {
            get
            {
                if (subregion != null)
                {
                    return subregion;
                }
                else
                {
                    return "N/D";
                }
            }
        }

        public string DisplayPopulation
        {
            get
            {
                if (population != 0)
                {
                    return population.ToString();
                }
                else
                {
                    return "N/D";
                }
            }
        }

        public string DisplayGini
        {
            get
            {
                if (gini != null)
                {
                    return gini.ToString();
                }
                else
                {
                    return "N/D";
                }
            }
        }

        public string DisplayFlag
        {
            get
            {
                if (flags?.png != null)
                {
                    return flags.png;
                }
                else
                {
                    return "Sem imagem disponível";
                }
            }
        }

        public string DisplayFlagLocal
        {
            get
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", DisplayName + ".png");
                return File.Exists(imagePath) ? imagePath : null;
            }
        }

        #endregion

        public class AED
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class AFN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Afr
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class ALL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class AMD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Amh
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class ANG
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class AOA
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ara
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Arc
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class ARS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class AUD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class AWG
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Aym
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Aze
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class AZN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BAM
        {
            public string name { get; set; }
        }

        public class Bar
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class BBD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BDT
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Bel
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ben
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ber
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class BGN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BHD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BIF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Bis
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Bjz
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class BMD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BND
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BOB
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Bos
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Bre
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class BRL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BSD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BTN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Bul
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Bwg
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class BWP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BYN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class BZD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class CAD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Cal
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class CapitalInfo
        {
            public List<double> latlng { get; set; }
        }

        public class Car
        {
            public List<string> signs { get; set; }
            public string side { get; set; }
        }

        public class Cat
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class CDF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ces
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Cha
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class CHF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ckb
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class CKD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class CLP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Cnr
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class CNY
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class CoatOfArms
        {
            public string png { get; set; }
            public string svg { get; set; }
        }

        public class COP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class CRC
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Crs
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class CUC
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class CUP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Currencies
        {
            public XPF XPF { get; set; }
            public ISK ISK { get; set; }
            public EUR EUR { get; set; }
            public XOF XOF { get; set; }
            public KMF KMF { get; set; }
            public AUD AUD { get; set; }
            public CAD CAD { get; set; }
            public BYN BYN { get; set; }
            public GYD GYD { get; set; }
            public GMD GMD { get; set; }
            public TND TND { get; set; }
            public XAF XAF { get; set; }
            public RWF RWF { get; set; }
            public KHR KHR { get; set; }
            public USD USD { get; set; }
            public KRW KRW { get; set; }
            public MUR MUR { get; set; }
            public MVR MVR { get; set; }
            public VUV VUV { get; set; }
            public MWK MWK { get; set; }
            public EGP EGP { get; set; }
            public GEL GEL { get; set; }
            public NZD NZD { get; set; }
            public CVE CVE { get; set; }
            public UYU UYU { get; set; }
            public LAK LAK { get; set; }
            public DKK DKK { get; set; }
            public FOK FOK { get; set; }
            public MKD2 MKD { get; set; }
            public CLP CLP { get; set; }
            public MOP MOP { get; set; }
            public JOD JOD { get; set; }
            public JMD JMD { get; set; }
            public BBD BBD { get; set; }
            public DZD DZD { get; set; }
            public MAD MAD { get; set; }
            public MRU MRU { get; set; }
            public QAR QAR { get; set; }
            public GTQ GTQ { get; set; }
            public XCD XCD { get; set; }
            public PGK PGK { get; set; }
            public BRL BRL { get; set; }
            public MDL MDL { get; set; }
            public KGS KGS { get; set; }
            public ANG ANG { get; set; }
            public VND VND { get; set; }
            public AOA AOA { get; set; }
            public MYR MYR { get; set; }
            public CHF CHF { get; set; }
            public THB THB { get; set; }
            public DOP DOP { get; set; }
            public UZS UZS { get; set; }
            public GNF GNF { get; set; }
            public BTN BTN { get; set; }
            public INR INR { get; set; }
            public KYD KYD { get; set; }
            public NOK NOK { get; set; }
            public ILS ILS { get; set; }
            public BND BND { get; set; }
            public SGD SGD { get; set; }
            public IQD IQD { get; set; }
            public JPY JPY { get; set; }
            public LSL LSL { get; set; }
            public ZAR ZAR { get; set; }
            public TVD TVD { get; set; }
            public SSP SSP { get; set; }
            public GBP GBP { get; set; }
            public SHP SHP { get; set; }
            public AFN AFN { get; set; }
            public SBD SBD { get; set; }
            public CNY CNY { get; set; }
            public ERN ERN { get; set; }
            public RUB RUB { get; set; }
            public AMD AMD { get; set; }
            public SRD SRD { get; set; }
            public BSD BSD { get; set; }
            public BZD BZD { get; set; }
            public JEP JEP { get; set; }
            public SEK SEK { get; set; }
            public BWP BWP { get; set; }
            public IMP IMP { get; set; }
            public AED AED { get; set; }
            public IRR IRR { get; set; }
            public STN STN { get; set; }
            public BDT BDT { get; set; }
            public RON2 RON { get; set; }
            public SDG SDG { get; set; }
            public BAM BAM { get; set; }
            public SCR SCR { get; set; }
            public LKR LKR { get; set; }
            public MXN MXN { get; set; }
            public YER YER { get; set; }
            public PYG PYG { get; set; }
            public VES VES { get; set; }
            public UAH UAH { get; set; }
            public PKR PKR { get; set; }
            public KPW KPW { get; set; }
            public ZWL ZWL { get; set; }
            public TZS TZS { get; set; }
            public CKD CKD { get; set; }
            public PLN PLN { get; set; }
            public WST WST { get; set; }
            public CZK CZK { get; set; }
            public IDR IDR { get; set; }
            public BOB BOB { get; set; }
            public COP COP { get; set; }
            public HNL HNL { get; set; }
            public LYD LYD { get; set; }
            public MNT MNT { get; set; }
            public CDF CDF { get; set; }
            public FKP FKP { get; set; }
            public SYP SYP { get; set; }
            public ZMW ZMW { get; set; }
            public MMK MMK { get; set; }
            public CRC CRC { get; set; }
            public SOS SOS { get; set; }
            public HUF HUF { get; set; }
            public TRY TRY { get; set; }
            public OMR OMR { get; set; }
            public NPR NPR { get; set; }
            public MGA MGA { get; set; }
            public KZT KZT { get; set; }
            public DJF DJF { get; set; }
            public GIP GIP { get; set; }
            public GGP GGP { get; set; }
            public NAD NAD { get; set; }
            public ALL ALL { get; set; }
            public HTG HTG { get; set; }
            public TOP TOP { get; set; }
            public HKD HKD { get; set; }
            public SAR SAR { get; set; }
            public CUC CUC { get; set; }
            public CUP CUP { get; set; }
            public PAB PAB { get; set; }
            public LRD LRD { get; set; }
            public AZN AZN { get; set; }
            public KID KID { get; set; }
            public ETB ETB { get; set; }
            public TTD TTD { get; set; }
            public SLL SLL { get; set; }
            public MZN MZN { get; set; }
            public FJD FJD { get; set; }
            public TMT TMT { get; set; }
            public TJS TJS { get; set; }
            public LBP LBP { get; set; }
            public NGN NGN { get; set; }
            public ARS ARS { get; set; }
            public BMD BMD { get; set; }
            public NIO NIO { get; set; }
            public SZL SZL { get; set; }
            public BHD BHD { get; set; }
            public KES KES { get; set; }
            public RSD RSD { get; set; }
            public PHP PHP { get; set; }
            public KWD KWD { get; set; }
            public TWD TWD { get; set; }
            public BIF BIF { get; set; }
            public BGN BGN { get; set; }
            public PEN PEN { get; set; }
            public AWG AWG { get; set; }
            public GHS GHS { get; set; }
            public UGX UGX { get; set; }
        }

        public class CVE
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Cym
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class CZK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Dan
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Demonyms
        {
            public Eng eng { get; set; }
            public Fra fra { get; set; }
        }

        public class Deu
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Div
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class DJF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class DKK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class DOP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class DZD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Dzo
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class EGP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ell
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Eng
        {
            public string official { get; set; }
            public string common { get; set; }
            public string f { get; set; }
            public string m { get; set; }
        }

        public class ERN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Est
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class ETB
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class EUR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Fao
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Fas
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Fij
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Fil
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Fin
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class FJD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class FKP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Flags
        {
            public string png { get; set; }
            public string svg { get; set; }
            public string alt { get; set; }
        }

        public class FOK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Fra
        {
            public string official { get; set; }
            public string common { get; set; }
            public string f { get; set; }
            public string m { get; set; }
        }

        public class GBP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class GEL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class GGP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class GHS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Gil
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Gini
        {
            [JsonProperty("2017")]
            public double? _2017 { get; set; }

            [JsonProperty("2018")]
            public double? _2018 { get; set; }

            [JsonProperty("2009")]
            public double? _2009 { get; set; }

            [JsonProperty("2014")]
            public double? _2014 { get; set; }

            [JsonProperty("2019")]
            public double? _2019 { get; set; }

            [JsonProperty("1998")]
            public double? _1998 { get; set; }

            [JsonProperty("2015")]
            public double? _2015 { get; set; }

            [JsonProperty("2016")]
            public double? _2016 { get; set; }

            [JsonProperty("2010")]
            public double? _2010 { get; set; }

            [JsonProperty("2011")]
            public double? _2011 { get; set; }

            [JsonProperty("2004")]
            public double? _2004 { get; set; }

            [JsonProperty("2013")]
            public double? _2013 { get; set; }

            [JsonProperty("2003")]
            public double? _2003 { get; set; }

            [JsonProperty("2012")]
            public double? _2012 { get; set; }

            [JsonProperty("1999")]
            public double? _1999 { get; set; }

            [JsonProperty("2006")]
            public double? _2006 { get; set; }

            [JsonProperty("2008")]
            public double? _2008 { get; set; }

            [JsonProperty("2005")]
            public double? _2005 { get; set; }

            [JsonProperty("1992")]
            public double? _1992 { get; set; }

            public override string ToString()
            {
                if (_2019 != null)
                {
                    return _2019.ToString();
                }
                else if (_2018 != null)
                {
                    return _2018.ToString();
                }
                else if (_2017 != null)
                {
                    return _2017.ToString();
                }
                else if (_2016 != null)
                {
                    return _2016.ToString();
                }
                else if (_2015 != null)
                {
                    return _2015.ToString();
                }
                else if (_2014 != null)
                {
                    return _2014.ToString();
                }
                else if (_2013 != null)
                {
                    return _2013.ToString();
                }
                else if (_2012 != null)
                {
                    return _2012.ToString();
                }
                else if (_2011 != null)
                {
                    return _2011.ToString();
                }
                else if (_2010 != null)
                {
                    return _2010.ToString();
                }
                else if (_2009 != null)
                {
                    return _2009.ToString();
                }
                else if (_2008 != null)
                {
                    return _2008.ToString();
                }
                else if (_2006 != null)
                {
                    return _2006.ToString();
                }
                else if (_2005 != null)
                {
                    return _2005.ToString();
                }
                else if (_2004 != null)
                {
                    return _2004.ToString();
                }
                else if (_2003 != null)
                {
                    return _2003.ToString();
                }
                else if (_1999 != null)
                {
                    return _1999.ToString();
                }
                else if (_1998 != null)
                {
                    return _1998.ToString();
                }
                else if (_1992 != null)
                {
                    return _1992.ToString();
                }
                else
                {
                    return "N/D"; // Se nenhum valor estiver disponível, retornar "N/D"
                }
            }
        }

        public class GIP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Gle
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Glv
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class GMD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class GNF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Grn
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Gsw
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class GTQ
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class GYD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Hat
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Heb
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Her
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Hgm
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Hif
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Hin
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class HKD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Hmo
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class HNL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Hrv
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class HTG
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class HUF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Hun
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Hye
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Idd
        {
            public string root { get; set; }
            public List<string> suffixes { get; set; }
        }

        public class IDR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class ILS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class IMP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ind
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class INR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class IQD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class IRR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class ISK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Isl
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ita
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Jam
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class JEP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class JMD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class JOD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Jpn
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class JPY
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Kal
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Kat
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Kaz
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Kck
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class KES
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class KGS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Khi
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Khm
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class KHR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class KID
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Kin
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Kir
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class KMF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Kon
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Kor
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class KPW
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class KRW
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class KWD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Kwn
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class KYD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class KZT
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class LAK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Languages
        {
            public string fra { get; set; }
            public string isl { get; set; }
            public string deu { get; set; }
            public string ltz { get; set; }
            public string ara { get; set; }
            public string zdj { get; set; }
            public string eng { get; set; }
            public string est { get; set; }
            public string bel { get; set; }
            public string rus { get; set; }
            public string kin { get; set; }
            public string khm { get; set; }
            public string ell { get; set; }
            public string kor { get; set; }
            public string mfe { get; set; }
            public string swe { get; set; }
            public string ita { get; set; }
            public string div { get; set; }
            public string bis { get; set; }
            public string nya { get; set; }
            public string kat { get; set; }
            public string mri { get; set; }
            public string nzs { get; set; }
            public string por { get; set; }
            public string slk { get; set; }
            public string spa { get; set; }
            public string lao { get; set; }
            public string dan { get; set; }
            public string fao { get; set; }
            public string niu { get; set; }
            public string mkd { get; set; }
            public string tur { get; set; }
            public string zho { get; set; }
            public string jam { get; set; }
            public string ber { get; set; }
            public string mey { get; set; }
            public string hmo { get; set; }
            public string tpi { get; set; }
            public string lit { get; set; }
            public string ron { get; set; }
            public string kir { get; set; }
            public string nld { get; set; }
            public string pap { get; set; }
            public string vie { get; set; }
            public string msa { get; set; }
            public string gsw { get; set; }
            public string roh { get; set; }
            public string tha { get; set; }
            public string uzb { get; set; }
            public string dzo { get; set; }
            public string mah { get; set; }
            public string nno { get; set; }
            public string nob { get; set; }
            public string smi { get; set; }
            public string heb { get; set; }
            public string hrv { get; set; }
            public string arc { get; set; }
            public string ckb { get; set; }
            public string jpn { get; set; }
            public string sot { get; set; }
            public string tvl { get; set; }
            public string fin { get; set; }
            public string prs { get; set; }
            public string pus { get; set; }
            public string tuk { get; set; }
            public string tir { get; set; }
            public string cat { get; set; }
            public string hye { get; set; }
            public string de { get; set; }
            public string eus { get; set; }
            public string glc { get; set; }
            public string smo { get; set; }
            public string tkl { get; set; }
            public string bjz { get; set; }
            public string nrf { get; set; }
            public string tsn { get; set; }
            public string glv { get; set; }
            public string fas { get; set; }
            public string kal { get; set; }
            public string ben { get; set; }
            public string bos { get; set; }
            public string srp { get; set; }
            public string mlt { get; set; }
            public string crs { get; set; }
            public string sin { get; set; }
            public string tam { get; set; }
            public string grn { get; set; }
            public string nor { get; set; }
            public string ukr { get; set; }
            public string urd { get; set; }
            public string slv { get; set; }
            public string bwg { get; set; }
            public string kck { get; set; }
            public string khi { get; set; }
            public string ndc { get; set; }
            public string nde { get; set; }
            public string sna { get; set; }
            public string toi { get; set; }
            public string tso { get; set; }
            public string ven { get; set; }
            public string xho { get; set; }
            public string zib { get; set; }
            public string swa { get; set; }
            public string rar { get; set; }
            public string pol { get; set; }
            public string ces { get; set; }
            public string ind { get; set; }
            public string aym { get; set; }
            public string que { get; set; }
            public string sag { get; set; }
            public string pov { get; set; }
            public string mon { get; set; }
            public string kon { get; set; }
            public string lin { get; set; }
            public string lua { get; set; }
            public string nau { get; set; }
            public string cnr { get; set; }
            public string mya { get; set; }
            public string som { get; set; }
            public string gle { get; set; }
            public string hun { get; set; }
            public string cha { get; set; }
            public string nep { get; set; }
            public string mlg { get; set; }
            public string kaz { get; set; }
            public string nfr { get; set; }
            public string afr { get; set; }
            public string her { get; set; }
            public string hgm { get; set; }
            public string kwn { get; set; }
            public string loz { get; set; }
            public string ndo { get; set; }
            public string lat { get; set; }
            public string sqi { get; set; }
            public string hat { get; set; }
            public string ton { get; set; }
            public string aze { get; set; }
            public string lav { get; set; }
            public string gil { get; set; }
            public string amh { get; set; }
            public string pau { get; set; }
            public string fij { get; set; }
            public string hif { get; set; }
            public string pih { get; set; }
            public string tgk { get; set; }
            public string ssw { get; set; }
            public string tet { get; set; }
            public string cal { get; set; }
            public string fil { get; set; }
            public string run { get; set; }
            public string bul { get; set; }
            public string nbl { get; set; }
            public string nso { get; set; }
            public string zul { get; set; }
            public string hin { get; set; }
        }

        public class Lao
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Lat
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Lav
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class LBP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Lin
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Lit
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class LKR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Loz
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class LRD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class LSL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ltz
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Lua
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class LYD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class MAD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Mah
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Maps
        {
            public string googleMaps { get; set; }
            public string openStreetMaps { get; set; }
        }

        public class MDL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Mey
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Mfe
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class MGA
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Mkd
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class MKD2
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Mlg
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Mlt
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class MMK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class MNT
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Mon
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class MOP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Mri
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class MRU
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Msa
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class MUR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class MVR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class MWK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class MXN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Mya
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class MYR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class MZN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class NAD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Name
        {
            public string common { get; set; }
            public string official { get; set; }
            public NativeName nativeName { get; set; }
        }

        public class NativeName
        {
            public Fra fra { get; set; }
            public Isl isl { get; set; }
            public Deu deu { get; set; }
            public Ltz ltz { get; set; }
            public Ara ara { get; set; }
            public Zdj zdj { get; set; }
            public Eng eng { get; set; }
            public Est est { get; set; }
            public Bel bel { get; set; }
            public Rus rus { get; set; }
            public Kin kin { get; set; }
            public Khm khm { get; set; }
            public Ell ell { get; set; }
            public Kor kor { get; set; }
            public Mfe mfe { get; set; }
            public Swe swe { get; set; }
            public Ita ita { get; set; }
            public Div div { get; set; }
            public Bis bis { get; set; }
            public Nya nya { get; set; }
            public Kat kat { get; set; }
            public Mri mri { get; set; }
            public Nzs nzs { get; set; }
            public Por por { get; set; }
            public Slk slk { get; set; }
            public Spa spa { get; set; }
            public Lao lao { get; set; }
            public Dan dan { get; set; }
            public Fao fao { get; set; }
            public Niu niu { get; set; }
            public Mkd mkd { get; set; }
            public Tur tur { get; set; }
            public Zho zho { get; set; }
            public Jam jam { get; set; }
            public Ber ber { get; set; }
            public Mey mey { get; set; }
            public Hmo hmo { get; set; }
            public Tpi tpi { get; set; }
            public Lit lit { get; set; }
            public Ron ron { get; set; }
            public Kir kir { get; set; }
            public Nld nld { get; set; }
            public Pap pap { get; set; }
            public Vie vie { get; set; }
            public Msa msa { get; set; }
            public Gsw gsw { get; set; }
            public Roh roh { get; set; }
            public Tha tha { get; set; }
            public Uzb uzb { get; set; }
            public Dzo dzo { get; set; }
            public Mah mah { get; set; }
            public Nno nno { get; set; }
            public Nob nob { get; set; }
            public Smi smi { get; set; }
            public Heb heb { get; set; }
            public Hrv hrv { get; set; }
            public Arc arc { get; set; }
            public Ckb ckb { get; set; }
            public Jpn jpn { get; set; }
            public Sot sot { get; set; }
            public Tvl tvl { get; set; }
            public Fin fin { get; set; }
            public Prs prs { get; set; }
            public Pus pus { get; set; }
            public Tuk tuk { get; set; }
            public Tir tir { get; set; }
            public Cat cat { get; set; }
            public Hye hye { get; set; }
            public Bar bar { get; set; }
            public Smo smo { get; set; }
            public Tkl tkl { get; set; }
            public Bjz bjz { get; set; }
            public Nrf nrf { get; set; }
            public Tsn tsn { get; set; }
            public Glv glv { get; set; }
            public Fas fas { get; set; }
            public Kal kal { get; set; }
            public Ben ben { get; set; }
            public Bos bos { get; set; }
            public Srp srp { get; set; }
            public Mlt mlt { get; set; }
            public Crs crs { get; set; }
            public Sin sin { get; set; }
            public Tam tam { get; set; }
            public Grn grn { get; set; }
            public Nor nor { get; set; }
            public Ukr ukr { get; set; }
            public Urd urd { get; set; }
            public Slv slv { get; set; }
            public Bwg bwg { get; set; }
            public Kck kck { get; set; }
            public Khi khi { get; set; }
            public Ndc ndc { get; set; }
            public Nde nde { get; set; }
            public Sna sna { get; set; }
            public Toi toi { get; set; }
            public Tso tso { get; set; }
            public Ven ven { get; set; }
            public Xho xho { get; set; }
            public Zib zib { get; set; }
            public Swa swa { get; set; }
            public Rar rar { get; set; }
            public Pol pol { get; set; }
            public Ces ces { get; set; }
            public Ind ind { get; set; }
            public Aym aym { get; set; }
            public Que que { get; set; }
            public Sag sag { get; set; }
            public Pov pov { get; set; }
            public Mon mon { get; set; }
            public Kon kon { get; set; }
            public Lin lin { get; set; }
            public Lua lua { get; set; }
            public Nau nau { get; set; }
            public Cnr cnr { get; set; }
            public Mya mya { get; set; }
            public Som som { get; set; }
            public Gle gle { get; set; }
            public Hun hun { get; set; }
            public Cha cha { get; set; }
            public Nep nep { get; set; }
            public Mlg mlg { get; set; }
            public Kaz kaz { get; set; }
            public Nfr nfr { get; set; }
            public Afr afr { get; set; }
            public Her her { get; set; }
            public Hgm hgm { get; set; }
            public Kwn kwn { get; set; }
            public Loz loz { get; set; }
            public Ndo ndo { get; set; }
            public Lat lat { get; set; }
            public Sqi sqi { get; set; }
            public Hat hat { get; set; }
            public Ton ton { get; set; }
            public Aze aze { get; set; }
            public Lav lav { get; set; }
            public Gil gil { get; set; }
            public Amh amh { get; set; }
            public Pau pau { get; set; }
            public Fij fij { get; set; }
            public Hif hif { get; set; }
            public Pih pih { get; set; }
            public Tgk tgk { get; set; }
            public Ssw ssw { get; set; }
            public Tet tet { get; set; }
            public Cal cal { get; set; }
            public Fil fil { get; set; }
            public Run run { get; set; }
            public Bul bul { get; set; }
            public Nbl nbl { get; set; }
            public Nso nso { get; set; }
            public Zul zul { get; set; }
            public Hin hin { get; set; }
        }

        public class Nau
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nbl
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ndc
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nde
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ndo
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nep
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nfr
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class NGN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class NIO
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Niu
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nld
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nno
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nob
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class NOK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Nor
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class NPR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Nrf
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nso
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Nya
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class NZD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Nzs
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class OMR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class PAB
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Pap
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Pau
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class PEN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Per
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class PGK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class PHP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Pih
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class PKR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class PLN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Pol
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Por
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class PostalCode
        {
            public string format { get; set; }
            public string regex { get; set; }
        }

        public class Pov
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Prs
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Pus
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class PYG
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class QAR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Que
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Rar
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Roh
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ron
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class RON2
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class RSD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class RUB
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Run
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Rus
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class RWF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Sag
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class SAR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class SBD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class SCR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class SDG
        {
            public string name { get; set; }
        }

        public class SEK
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class SGD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class SHP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Sin
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Slk
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class SLL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Slv
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Smi
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Smo
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Sna
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Som
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class SOS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Sot
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Spa
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Sqi
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class SRD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Srp
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class SSP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ssw
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class STN
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Swa
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Swe
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class SYP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class SZL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Tam
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Tet
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Tgk
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Tha
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class THB
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Tir
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class TJS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Tkl
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class TMT
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class TND
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Toi
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Ton
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class TOP
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Tpi
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Translations
        {
            public Ara ara { get; set; }
            public Bre bre { get; set; }
            public Ces ces { get; set; }
            public Cym cym { get; set; }
            public Deu deu { get; set; }
            public Est est { get; set; }
            public Fin fin { get; set; }
            public Fra fra { get; set; }
            public Hrv hrv { get; set; }
            public Hun hun { get; set; }
            public Ita ita { get; set; }
            public Jpn jpn { get; set; }
            public Kor kor { get; set; }
            public Nld nld { get; set; }
            public Per per { get; set; }
            public Pol pol { get; set; }
            public Por por { get; set; }
            public Rus rus { get; set; }
            public Slk slk { get; set; }
            public Spa spa { get; set; }
            public Srp srp { get; set; }
            public Swe swe { get; set; }
            public Tur tur { get; set; }
            public Urd urd { get; set; }
            public Zho zho { get; set; }
        }

        public class TRY
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Tsn
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Tso
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class TTD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Tuk
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Tur
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class TVD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Tvl
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class TWD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class TZS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class UAH
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class UGX
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ukr
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Urd
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class USD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class UYU
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Uzb
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class UZS
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Ven
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class VES
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Vie
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class VND
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class VUV
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class WST
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class XAF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class XCD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Xho
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class XOF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class XPF
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class YER
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class ZAR
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Zdj
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Zho
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Zib
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class ZMW
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Zul
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class ZWL
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }
    }
}
