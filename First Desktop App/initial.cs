using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Desktop_App
{
    internal class initial
    {


        public static Dictionary<string, Dictionary<string, Dictionary<string, string>>> Programming_Datas = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>() {

            { 
                //Start First Item
                "PHP" , new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "مباحث مقدماتی", new Dictionary<string, string>()
                        {
                            { "سلام دنیا", "<?php echo \"Hello World!\" ?>"}
                        }

                    },
                    {
                        "مباحث پیشرفته", new Dictionary<string, string>()
                        {
                            { "سلام دنیا", "<?php echo \"Hello World!\""}
                        }
                    }
                }
            },
            {
                "JavaScript" , new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "مباحث مقدماتی", new Dictionary<string, string>()
                        {
                            { "سلام دنیا", "<script> alert(\"Hello World!\")</script>"}
                        }
                    },
                    {
                        "مباحث متوسط", new Dictionary<string, string>()
                        {
                            { "سلام دنیا", "<script> alert(\"Hello World!\")</script>"}
                        }
                    },
                    {
                        "مباحث پیشرفته", new Dictionary<string, string>()
                        {
                            { "سلام دنیا", "<script> alert(\"Hello World!\")</script>"},
                            {
                                "ساخت فضاپیما با جاوااسکریپت",
                                "<script>\n\talert(\"StarCraft Made By Javascript!!!\")\n</script>"
                            }
                        }
                    }
                }
            }
        };

        public static List<string> Programming_Languages
        {
            get
            {
                return new List<string>(Programming_Datas.Keys);
            }
        }

        public static List<string> get_programming_language_topics(string programming_language)
        {
            if (!Programming_Datas.ContainsKey(programming_language))
                return new List<string>();
            return new List<string>(Programming_Datas[programming_language].Keys);
        }

        public static List<string> get_programming_codes(string programming_language, string Language_Topic)
        {
            if (!Programming_Datas[programming_language].ContainsKey(Language_Topic))
                return new List<string>();
            return new List<string>(Programming_Datas[programming_language][Language_Topic].Keys);
        }

        public static string get_programming_code(string programming_language, string Language_Topic, string programming_code)
        {
            if (!Programming_Datas[programming_language][Language_Topic].ContainsKey(programming_code))
                return "";
            return Programming_Datas[programming_language][Language_Topic][programming_code];
        }


    }
}
