using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WhatsApp.Intl
{
    public class Language
    {
        public string Code { get; }

        private Language(string code) { Code = code; }

        [JsonIgnore] public static Language Afrikaans => new Language("af");
        [JsonIgnore] public static Language Albanian => new Language("sq");
        [JsonIgnore] public static Language Arab => new Language("ar");
        [JsonIgnore] public static Language Azerbaijani => new Language("az");
        [JsonIgnore] public static Language Bengalish => new Language("bn");
        [JsonIgnore] public static Language Bulgarian => new Language("bg");
        [JsonIgnore] public static Language Catalan => new Language("ca");
        [JsonIgnore] public static Language ChineseCN => new Language("zh_CN");
        [JsonIgnore] public static Language ChineseHK => new Language("zh_HK");
        [JsonIgnore] public static Language ChineseTW => new Language("zh_TW");
        [JsonIgnore] public static Language Croatian => new Language("hr");
        [JsonIgnore] public static Language Czech => new Language("cs");
        [JsonIgnore] public static Language Danish => new Language("da");
        [JsonIgnore] public static Language Dutch => new Language("nl");
        [JsonIgnore] public static Language English => new Language("en");
        [JsonIgnore] public static Language EnglishUK => new Language("en_GB");
        [JsonIgnore] public static Language EnglishUS => new Language("en_US");
        [JsonIgnore] public static Language Estonian => new Language("et");
        [JsonIgnore] public static Language Philippine => new Language("fil");
        [JsonIgnore] public static Language Finnish => new Language("fi");
        [JsonIgnore] public static Language French => new Language("fr");
        [JsonIgnore] public static Language German => new Language("de");
        [JsonIgnore] public static Language Greek => new Language("el");
        [JsonIgnore] public static Language Gujarati => new Language("gu");
        [JsonIgnore] public static Language Hausa => new Language("ha");
        [JsonIgnore] public static Language Hebrew => new Language("he");
        [JsonIgnore] public static Language Hindi => new Language("hi");
        [JsonIgnore] public static Language Hungarian => new Language("hu");
        [JsonIgnore] public static Language Indonesian => new Language("id");
        [JsonIgnore] public static Language Irish => new Language("ga");
        [JsonIgnore] public static Language Italian => new Language("it");
        [JsonIgnore] public static Language Japanese => new Language("ja");
        [JsonIgnore] public static Language Canares => new Language("kn");
        [JsonIgnore] public static Language Kazajo => new Language("kk");
        [JsonIgnore] public static Language Corean => new Language("ko");
        [JsonIgnore] public static Language Lao => new Language("lo");
        [JsonIgnore] public static Language Letonian => new Language("lv");
        [JsonIgnore] public static Language Lituanian => new Language("lt");
        [JsonIgnore] public static Language Macednian => new Language("mk");
        [JsonIgnore] public static Language Malayo => new Language("ms");
        [JsonIgnore] public static Language Malayalam => new Language("ml");
        [JsonIgnore] public static Language Marathi => new Language("mr");
        [JsonIgnore] public static Language Norwegian => new Language("nb");
        [JsonIgnore] public static Language Persian => new Language("fa");
        [JsonIgnore] public static Language Polish => new Language("pl");
        [JsonIgnore] public static Language PortugueseBR => new Language("pt_BR");
        [JsonIgnore] public static Language PortuguesePT => new Language("pt_PT");
        [JsonIgnore] public static Language Punjabi => new Language("pa");
        [JsonIgnore] public static Language Romanian => new Language("ro");
        [JsonIgnore] public static Language Russian => new Language("ru");
        [JsonIgnore] public static Language Serbian => new Language("sr");
        [JsonIgnore] public static Language Slovak => new Language("sk");
        [JsonIgnore] public static Language Slovenian => new Language("sl");
        [JsonIgnore] public static Language Spanish => new Language("es");
        [JsonIgnore] public static Language SpanishAR => new Language("es_AR");
        [JsonIgnore] public static Language SpanishES => new Language("es_ES");
        [JsonIgnore] public static Language SpanishMX => new Language("es_MX");
        [JsonIgnore] public static Language Swahili => new Language("sw");
        [JsonIgnore] public static Language Swedish => new Language("sv");
        [JsonIgnore] public static Language Tamil => new Language("ta");
        [JsonIgnore] public static Language Telugu => new Language("te");
        [JsonIgnore] public static Language Thai => new Language("th");
        [JsonIgnore] public static Language Turkish => new Language("tr");
        [JsonIgnore] public static Language Ukrainian => new Language("uk");
        [JsonIgnore] public static Language Urdu => new Language("ur");
        [JsonIgnore] public static Language Uzbek => new Language("uz");
        [JsonIgnore] public static Language Vietnamese => new Language("vi");
        [JsonIgnore] public static Language Zulu => new Language("zu");
    }
}
