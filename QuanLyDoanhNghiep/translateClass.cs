using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;

namespace QuanLyDoanhNghiep
{
    // lớp "dịch "
    class translateClass
    {
        public string translateText(string word, string fromLang, string toLang)
        {
            var fromLanguage = fromLang;
            var toLanguage = toLang;

            var url = $"https://translate.googleapis.com" +
                $"/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";

            }
        }
        /*public transFrom(Form toTranslate, string defaultLanguage)
        {
            //Initializing variables
            Form mainForm = toTranslate;
            string Default = defaultLanguage;
            string CurrentLanguage = defaultLanguage;

            //Creating languages directory if it does not exist
            if (!Directory.Exists("Languages"))
            {
                Directory.CreateDirectory("Languages");
            }

            //We translate to the default language
            transForm(Default);
        }*/
    }
}
