using System;
using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Models
{
    public enum CurrencyEnum
    {
        [Display(Name=("United Arab Emirates Dirham"))]
        AED,
        [Display(Name = ("Afghanistan Afghani"))]
        AFN,
        [Display(Name = ("Albania Lek"))]
        ALL,
        [Display(Name = ("Armenia Dram"))]
        AMD,
        [Display(Name = ("Netherlands Antilles Guilder"))]
        ANG,
        [Display(Name = ("Angola Kwanza"))]
        AOA,
        [Display(Name = ("Argentina Peso"))]
        ARS,
        [Display(Name = ("Australia Dollar"))]
        AUD,
        [Display(Name = ("Aruba Guilder"))]
        AWG,
        [Display(Name = ("Azerbaijan Manat"))]
        AZN,
        [Display(Name = ("Bosnia and Herzegovina Convertible Mark"))]
        BAM,
        [Display(Name = ("Barbados Dollar"))]
        BBD,
        [Display(Name = ("Bangladesh Taka"))]
        BDT,
        [Display(Name = ("Bulgaria Lev"))]
        BGN,
        [Display(Name = ("Bahrain Dinar"))]
        BHD,
        [Display(Name = ("Burundi Franc"))]
        BIF,
        [Display(Name = ("Bermuda Dollar"))]
        BMD,
        [Display(Name = ("Brunei Darussalam Dollar"))]
        BND, 
        [Display(Name = ("Bolivia Bolíviano"))]
        BOB,
        [Display(Name = ("Brazil Real"))]
        BRL,
        [Display(Name = ("Bahamas Dollar"))]
        BSD,
        [Display(Name = ("Bitcoin"))]
        BTC,
        [Display(Name = ("Bhutan Ngultrum"))]
        BTN,
        [Display(Name = ("Botswana Pula"))]
        BWP,
        [Display(Name = ("Belarus Ruble"))]
        BYN,
        [Display(Name = ("Belarusian Ruble"))]
        BYR,
        [Display(Name = ("Belize Dollar"))]
        BZD,
        [Display(Name = ("Canada Dollar"))]
        CAD,
        [Display(Name = ("Congo/Kinshasa Franc"))]
        CDF,
        [Display(Name = ("Switzerland Franc"))]
        CHF,
        [Display(Name = ("Chilean Unit of Account (UF)"))]
        CLF,
        [Display(Name = ("Chile Peso"))]
        CLP,
        [Display(Name = ("China Yuan Renminbi"))]
        CNY,
        [Display(Name = ("Colombia Peso"))]
        COP,
        [Display(Name = ("Costa Rica Colon"))]
        CRC,
        [Display(Name = ("Cuba Convertible Peso"))]
        CUC,
        [Display(Name = ("Cuba Peso"))]
        CUP,
        [Display(Name = ("Cape Verde Escudo"))]
        CVE,
        [Display(Name = ("Czech Republic Koruna"))]
        CZK,
        [Display(Name = ("Djibouti Franc"))]
        DJF,
        [Display(Name = ("Denmark Krone"))]
        DKK,
        [Display(Name = ("Dominican Republic Peso"))]
        DOP,
        [Display(Name = ("Algeria Dinar"))]
        DZD,
        [Display(Name = ("Egypt Pound"))]
        EGP,
        [Display(Name = ("Eritrea Nakfa"))]
        ERN,
        [Display(Name = ("Ethiopia Birr"))]
        ETB,
        [Display(Name = ("Euro Member Countries"))]
        EUR,
        [Display(Name = ("Fiji Dollar"))]
        FJD,
        [Display(Name = ("Falkland Islands (Malvinas) Pound"))]
        FKP,
        [Display(Name = ("United Kingdom Pound"))]
        GBP,
        [Display(Name = ("Georgia Lari"))]
        GEL,
        [Display(Name = ("Guernsey Pound"))]
        GGP,
        [Display(Name = ("Ghana Cedi"))]
        GHS,
        [Display(Name = ("Gibraltar Pound"))]
        GIP,
        [Display(Name = ("Gambia Dalasi"))]
        GMD,
        [Display(Name = ("Guinea Franc"))]
        GNF,
        [Display(Name = ("Guatemala Quetzal"))]
        GTQ,
        [Display(Name = ("Guyana Dollar"))]
        GYD,
        [Display(Name = ("Hong Kong Dollar"))]
        HKD,
        [Display(Name = ("Honduras Lempira"))]
        HNL,
        [Display(Name = ("Croatia Kuna"))]
        HRK,
        [Display(Name = ("Haiti Gourde"))]
        HTG,
        [Display(Name = ("Hungary Forint"))]
        HUF,
        [Display(Name = ("Indonesia Rupiah"))]
        IDR,
        [Display(Name = ("Israel Shekel"))]
        ILS,
        [Display(Name = ("Isle of Man Pound"))]
        IMP,
        [Display(Name = ("India Rupee"))]
        INR,
        [Display(Name = ("Iraq Dinar"))]
        IQD,
        [Display(Name = ("Iran Rial"))]
        IRR,
        [Display(Name = ("Iceland Krona"))]
        ISK,
        [Display(Name = ("Jersey Pound"))]
        JEP,
        [Display(Name = ("Jamaica Dollar"))]
        JMD,
        [Display(Name = ("Jordan Dinar"))]
        JOD,
        [Display(Name = ("Japan Yen"))]
        JPY,
        [Display(Name = ("Kenya Shilling"))]
        KES,
        [Display(Name = ("Kyrgyzstan Som"))]
        KGS,
        [Display(Name = ("Cambodia Riel"))]
        KHR,
        [Display(Name = ("Comorian Franc"))]
        KMF,
        [Display(Name = ("Korea (North) Won"))]
        KPW,
        [Display(Name = ("Korea (South) Won"))]
        KRW,
        [Display(Name = ("Kuwait Dinar"))]
        KWD,
        [Display(Name = ("Kuwait Dinar"))]
        KYD,
        [Display(Name = ("Kazakhstan Tenge"))]
        KZT,
        [Display(Name = ("Laos Kip"))]
        LAK,
        [Display(Name = ("Lebanon Pound"))]
        LBP,
        [Display(Name = ("Sri Lanka Rupee"))]
        LKR,
        [Display(Name = ("Liberia Dollar"))]
        LRD,
        [Display(Name = ("Lesotho Loti"))]
        LSL,
        [Display(Name = ("Lithuanian litas"))]
        LTL,
        [Display(Name = ("Latvian lats"))]
        LVL,
        [Display(Name = ("Libya Dinar"))]
        LYD,
        [Display(Name = ("Morocco Dirham"))]
        MAD,
        [Display(Name = ("Moldova Leu"))]
        MDL,
        [Display(Name = ("Madagascar Ariary"))]
        MGA,
        [Display(Name = ("Macedonia Denar"))]
        MKD,
        [Display(Name = ("Myanmar (Burma) Kyat"))]
        MMK,
        [Display(Name = ("	Mongolia Tughrik"))]
        MNT,
        [Display(Name = ("Macau Pataca"))]
        MOP,
        [Display(Name = ("Mauritania Ouguiya"))]
        MRO,
        [Display(Name = ("Mauritius Rupee"))]
        MUR,
        [Display(Name = ("Maldives (Maldive Islands) Rufiyaa"))]
        MVR,
        [Display(Name = ("Malawi Kwacha"))]
        MWK,
        [Display(Name = ("Mexico Peso"))]
        MXN,
        [Display(Name = ("Malaysia Ringgit"))]
        MYR,
        [Display(Name = ("Mozambique Metical"))]
        MZN,
        [Display(Name = ("Namibia Dollar"))]
        NAD,
        [Display(Name = ("Nigeria Naira"))]
        NGN,
        [Display(Name = ("Nicaragua Cordoba"))]
        NIO,
        [Display(Name = ("Norway Krone"))]
        NOK,
        [Display(Name = ("Nepal Rupee"))]
        NPR,
        [Display(Name = ("New Zealand Dollar"))]
        NZD,
        [Display(Name = ("Oman Rial"))]
        OMR,
        [Display(Name = ("Panama Balboa"))]
        PAB,
        [Display(Name = ("Peru Sol"))]
        PEN,
        [Display(Name = ("Papua New Guinea Kina"))]
        PGK,
        [Display(Name = ("Philippines Peso"))]
        PHP,
        [Display(Name = ("Pakistan Rupee"))]
        PKR,
        [Display(Name = ("Poland Zloty"))]
        PLN,
        [Display(Name = ("Paraguay Guarani"))]
        PYG,
        [Display(Name = ("Qatar Riyal"))]
        QAR,
        [Display(Name = ("Romania Leu"))]
        RON,
        [Display(Name = ("Serbia Dinar"))]
        RSD,
        [Display(Name = ("Russia Ruble"))]
        RUB,
        [Display(Name = ("Rwanda Franc"))]
        RWF,
        [Display(Name = ("Saudi Arabia Riyal"))]
        SAR,
        [Display(Name = ("Solomon Islands Dollar"))]
        SBD,
        [Display(Name = ("Seychelles Rupee"))]
        SCR,
        [Display(Name = ("Sudan Pound"))]
        SDG,
        [Display(Name = ("Sweden Krona"))]
        SEK,
        [Display(Name = ("Singapore Dollar"))]
        SGD,
        [Display(Name = ("Saint Helena Pound"))]
        SHP,
        [Display(Name = ("Sierra Leone Leone"))]
        SLL,
        [Display(Name = ("Somalia Shilling"))]
        SOS,
        [Display(Name = ("Suriname Dollar"))]
        SRD,
        [Display(Name = ("São Tomé and Príncipe dobra"))]
        STD,
        [Display(Name = ("El Salvador Colon"))]
        SVC,
        [Display(Name = ("Syria Pound"))]
        SYP,
        [Display(Name = ("eSwatini Lilangeni"))]
        SZL,
        [Display(Name = ("Thailand Baht"))]
        THB,
        [Display(Name = ("Tajikistan Somoni"))]
        TJS,
        [Display(Name = ("Turkmenistan Manat"))]
        TMT,
        [Display(Name = ("Tunisia Dinar"))]
        TND,
        [Display(Name = ("Tonga Pa'anga"))]
        TOP,
        [Display(Name = ("Turkey Lira"))]
        TRY,
        [Display(Name = ("Trinidad and Tobago Dollar"))]
        TTD,
        [Display(Name = ("Taiwan New Dollar"))]
        TWD,
        [Display(Name = ("Tanzania Shilling"))]
        TZS,
        [Display(Name = ("Ukraine Hryvnia"))]
        UAH,
        [Display(Name = ("Uganda Shilling"))]
        UGX,
        [Display(Name = ("United States Dollar"))]
        USD,
        [Display(Name = ("Uruguay Peso"))]
        UYU,
        [Display(Name = ("Uzbekistan Som"))]
        UZS,
        [Display(Name = ("Venezuela Bolívar"))]
        VEF,
        [Display(Name = ("Viet Nam Dong"))]
        VND,
        [Display(Name = ("Vanuatu Vatu"))]
        VUV,
        [Display(Name = ("Samoa Tala"))]
        WST,
        [Display(Name = ("Communauté Financière Africaine (BEAC) CFA Franc BEAC"))]
        XAF,
        [Display(Name = ("Silver Ounce"))]
        XAG,
        [Display(Name = ("GOLD"))]
        XAU,
        [Display(Name = ("East Caribbean Dollar"))]
        XCD,
        [Display(Name = ("International Monetary Fund (IMF) Special Drawing Rights"))]
        XDR,
        [Display(Name = ("Communauté Financière Africaine (BCEAO) Franc"))]
        XOF,
        [Display(Name = ("Comptoirs Français du Pacifique (CFP) Franc"))]
        XPF,
        [Display(Name = ("Yemen Rial"))]
        YER,
        [Display(Name = ("South Africa Rand"))]
        ZAR,
        [Display(Name = ("New Zambian Kwacha"))]
        ZMK,
        [Display(Name = ("Old Zambian Kwacha"))]
        ZMW,
        [Display(Name = ("Zimbabwean dollar"))]
        ZWL
    }
}
