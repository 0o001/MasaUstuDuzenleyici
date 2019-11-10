using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasaUstuDuzenleyici
{
    public class MoveFile
    {
        string kaynakYol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        string hedefYol = "";
        public static string tiklananKategori = "";
        public static ArrayList dosyaismi = new ArrayList();
        public void KategoriyeGore(bool durum)
        {
            dosyaismi.Clear();
            if (durum)
            {
                kaynakYol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Düzenli\");
            }

            foreach (var a in DosyaUzantisi.uzantilar)
            {
                if (durum)
                {
                    hedefYol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Düzenli\";
                    Directory.CreateDirectory(hedefYol + a.Key);
                    hedefYol += a.Key + "\\";
                }
                try
                {
                    DirectoryInfo directory = new DirectoryInfo(kaynakYol);
                    FileInfo[] file_list_;
                    bool varMi = false;
                    for (int i = 0; i < a.Value.Length; i++)
                    {
                        file_list_ = directory.GetFiles("*" + a.Value[i]);
                        if (file_list_.Length != 0)
                        {
                            for (int j = 0; j < file_list_.Length; j++)
                            {
                                if (durum) // Dosyayı Taşı
                                {
                                    File.Move(kaynakYol + file_list_[j].Name, hedefYol + @"\" + file_list_[j].Name);
                                    varMi = true;
                                }
                                else    // Dosyayı Listele
                                {
                                    varMi = true;
                                    if (tiklananKategori == a.Key)
                                    {
                                        dosyaismi.Add(file_list_[j].Name.ToString());
                                    }
                                    if (tiklananKategori == "Tümü")
                                    {
                                        dosyaismi.Add(file_list_[j].Name.ToString());
                                    }
                                }
                            }
                        }
                    }
                    if (!varMi)
                    {
                        try
                        {
                            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Düzenli\" + a.Key + "\\", false);
                        }
                        catch { }
                    }
                }
                catch (DirectoryNotFoundException dnfhata)
                {
                    MessageBox.Show("Yol eksik veya bulunamadı!\n" + dnfhata);
                }
                catch (IOException iohata)
                {
                    MessageBox.Show("AHAAH\n" + iohata.ToString()); //?
                }

            }
        }
    }
}
