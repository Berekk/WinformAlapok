using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformAlapokOOPGyakorlas
{
    class Emberek
    {
        private List<Ember> lista = new List<Ember>();
        public Emberek(int db)
        {
            for (int i = 0; i < db; i++)
            {
                lista.Add(new Ember());
                
            }
        }

        public override string ToString()
        {
            string result = "";

            result += String.Format("Testsúly(kg) / Testmagasság(cm) / TTI / Testalkat|");
                
                foreach (var i in lista)
                {
                result += String.Format("{0} / {1} / {2} / {3}|", i.TestSuly, i.TestMagassag, i.TestTomegIndex, i.TestalkatSzoveggel);
                }
            return result;
        }

        public double atlagosTestSuly()
        {
            double temp = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                temp += lista[i].TestSuly;
            }
            return temp / lista.Count;
        }

        public int atlagosTestMagassag()
        {
            int temp = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                temp += lista[i].TestMagassag;
            }
            return temp / lista.Count;
        }

        public int legnagyobbTTISorszam()
        {
            int sorszam = 1;
            double max = lista[0].TestTomegIndex;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].TestTomegIndex > max)
                {
                    max = lista[i].TestTomegIndex;
                    sorszam = i + 1;
                }
            }
            return sorszam;
        }

        public int legkisebbTTISorszam()
        {
            int sorszam = 1;
            double min = lista[0].TestTomegIndex;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].TestTomegIndex < min)
                {
                    min = lista[i].TestTomegIndex;
                    sorszam = i + 1;
                }
            }
            return sorszam;
        }

        public Ember elsoNormalTestalkat()
        {
            int index = 0;
            for (int i = 0; i < lista.Count && (lista[i].TestalkatSzoveggel!= "normál testalkatú"); i++)
            {
                index++;
            }
            if (index >= lista.Count)
            {
                return null;
            }
            return lista[index];
        }

        public string egyEmberKiiras(Ember index)
        {
            try
            {
                return String.Format("{0} / {1} / {2} / {3}", index.TestSuly, index.TestMagassag, index.TestTomegIndex, index.TestalkatSzoveggel);
            }
            catch (Exception)
            {
                return String.Format("nincs normál testalkatú");
            }
        }
    }
}
