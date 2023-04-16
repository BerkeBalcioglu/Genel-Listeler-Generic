using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genel_Listeler_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList();
            List<string> liste = new List<string>();             // Sadece stringlerin odluğu bir liste.

            liste.Add("Kod");
            liste.Add("Yazmak");
            liste.Add("Çok");
            liste.Add("zor");
            liste.Add("ula");
            string[] isimler = { "zor diyorum lan anlsana", "ya valla bak", "şaka şaka " };   // İsimler dizisi oluşturur.
            liste.AddRange(isimler);                                                          // İsimler dizisini listeye EKLER.
            liste.Insert(0, "berke");                                                         // Aralığa KOD EKLER. 
            liste.InsertRange(0, isimler);                                                    // 0.listenin odluğu yere str dizsinin listesini Ekler.  
            for (int i = 0; i<liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
            liste.Sort();                                                                      // alfabetik yada numerik sıralar- For Döngüsü açmak zorundasın.
            liste.Reverse();                                                                   // listeyi terse çevirir.
            liste[0]= "Yakışıklı erkekler güzel kod yazarlar";                                 // 0.listenin olduğu yere "Yakışıklı erkekler güzel kod yazarlar"; yazar.
            liste.Remove("kod");                                                               // Listede "kod" değişekninin olduğu yeri çıkarır.siler.
            liste.RemoveAt(liste.Count -1);                                                    // Listenin sonundaki indis elemanını kaldırır.
            liste.RemoveRange(0, 3);                                                           // Listede ki 0. elemandan başla 3 eleman boyunca sil (0,1,2).  
            for (int i = 0; i<liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
            liste.Clear();                                                                     // Listedeki bütün elemanları siler listeyi temizler.





            Console.ReadKey(); 
        }
    }
}
