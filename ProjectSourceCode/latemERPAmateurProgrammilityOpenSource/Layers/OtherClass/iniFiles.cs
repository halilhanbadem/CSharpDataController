using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace latemERPAmateurProgrammilityOpenSource.Layers.OtherClass
{
    public static class iniFiles
    {
        static string directory = AppDomain.CurrentDomain.BaseDirectory;
        static string fileName = directory + @"\config.ini";

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string kategori, string anahtar, string deger, string dosyaAdi);

        [DllImport("kernel32.dll")]
        static extern uint GetPrivateProfileString(string kategori, string anahtar, string lpDefault, StringBuilder sb, int sbKapasite, string dosyaAdi);

        public static bool iniWrite(string kategori, string anahtar, string deger)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            return WritePrivateProfileString(kategori, anahtar, deger, fileName);
        }

        public static string iniRead(string kategori, string anahtar)
        {
            StringBuilder sb = new StringBuilder(500);

            GetPrivateProfileString(kategori, anahtar, "", sb, sb.Capacity, fileName);

            string veri = sb.ToString();
            sb.Clear();
            return veri;
        }
    }
}
