using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MasaUstuDuzenleyici
{
    public class DosyaUzantisi
    {
        //--------------------------------------------------------------
        //    ORTAĞIMIN İÇİNE SİNMEDİKTEN SONRA
        //    NE YAZMIŞIM NASIL YAZMIŞIM BENİM İÇİN ÖNEMlİ DEĞİL
        //    BU BENİM PROGRAMIM DEĞİL, "BİZİM PROGRAMIMIZ" KARDEŞİM .)
        //--------------------------------------------------------------
        public static string prop_Resim { get { return "Resim"; } }
        public static string prop_Video { get { return "Video"; } }
        public static string prop_Ses { get { return "Ses"; } }
        public static string prop_Word { get { return "Word"; } }
        public static string prop_Excel { get { return "Excel"; } }
        public static string prop_Sunum { get { return "Sunum"; } }
        public static string prop_Sikistirilmis { get { return "Sıkıştırılmış Dosya"; } }
        public static string prop_Text { get { return "Text Dosyaları"; } }
        public static string prop_Diger { get { return "Diğer"; } }


        public static Dictionary<string, string[]> uzantilar = new Dictionary<string, string[]>()
        {
            { DosyaUzantisi.prop_Resim, new string[] { "*.jpg",
"ACT", "ART","BMP", "BLP","CiT","CPT","CUT","DDS","DiB","DjVu","EGT","Exif","GiF","iCNS","iCO","iFF","ilbm","lbm","JNG","JPEG","JP2","LBM","MAX","MiFF","MNG","MSP","NiTF","OTA","PBM","PC1","PC2","PC3","PCF","PCX","PDN","PGM","Pi1","Pi2","Pi3","PiCT","PCT","PNG","PNM","PPM","PSB","PSD","PSP","PX","PXR","QFX","RAW","RLE","SCT","SGi","TGA","TiFF","XBM","XCF","XPM","AWG","Ai","EPS","CGM","CDR","CMX","DXF","EGT","SVG","STL","VRML","X3D","WMF","EMF","ART","XAR"} },

            { DosyaUzantisi.prop_Video, new string[] { "AAF","3GP","ASF","AVCHD","AVi","CAM","DAT","MPEG","DSH","FLV","M1V","M2V","SWF","FLA","FLR","MKV","WRAP","MNG","MOV","MPEG","MP4","MXF","NSV","OGM","RM","SVi","SMi","WMV","DivX","Xvid"} },

            { DosyaUzantisi.prop_Ses, new string[] { "AiFF", "AU ", "CDDA ", "RAW ", "WAV", "FLAC ", "LA", "PAC", "M4A", "APE", "RKA", "RKAU", "SHN", "TTA", "WV", "WMA", "MP2", "MP3", "Speex", "Vorbis", "GSM", "WMA", "AAC", "m4a", "mp4", "m4p", "aac", "MPC", "VQF", "RA", "RM", "OTS", "SWA", "VOX", "VOC", "DWD", "SMP", "CUST", "MiD", "MUS", "SiB", "GYM", "VGM", "PSF", "NSF", "MOD", "PTB", "S3M", "XM", "iT", "MT2", "MNG", "PSF", "RMJ", "SPC", "NiFF", "YM", "JAM", "ASF" } },

            { DosyaUzantisi.prop_Word, new string[] { "*.doc",   "*.docx" } },

            { DosyaUzantisi.prop_Excel, new string[] { "*.xlsx", "*.xls" } },

            { DosyaUzantisi.prop_Sunum, new string[] { "*.pptx", "*.ppt","*.odp" } },

            { DosyaUzantisi.prop_Sikistirilmis, new string[] { "*.rar", "*.zip", "*.7z", "*.tar", "*.gz" } },

            { DosyaUzantisi.prop_Text, new string[] { "*.txt","*.rtf" } },

            { DosyaUzantisi.prop_Diger, new string[] { "*.url", "*.pdf"} }
        };

        public static int[] renkler = 
            { 0x00bcd4, 0xf44336, 0x3f51b5, 0x2196f3, 0x4caf50, 0xff5722, 0x9c27b0, 0xeeeeee, 0x9e9e9e };
        //      RESİM     VİDEO     SES       WORD      EXCEL    SUNUM      RAR       TEXT      DİĞER
    }
}
