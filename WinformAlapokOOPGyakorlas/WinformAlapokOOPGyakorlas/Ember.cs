using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformAlapokOOPGyakorlas
{
    class Ember
    {
        private double testSuly;
        private int testMagassag;
        private static Random rnd = new Random();

        public double TestSuly
        {
            get
            {
                return testSuly;
            }
        }

        public int TestMagassag
        {
            get
            {
                return testMagassag;
            }
        }

        public double TestTomegIndex
        {
            get
            {
                return testTomegIndex();
            }
        }

        public string TestalkatSzoveggel
        {
            get
            {
                return testalkatSzoveggel(testalkalt());
            }
        }
        
        public Ember(double testSuly, int testMagassag)
        {
            this.testSuly = testSuly;
            this.testMagassag = testMagassag;
        }

        public Ember()
        {
            testSuly = Math.Round(rnd.NextDouble() * 50 + 50, 1);
            testMagassag = rnd.Next(150, 200);
        }

        public override string ToString()
        {
            return String.Format
                ("Magasság: {0}\nSúly: {1:0.0}\nTest tömeg index: {2}\nEz a normál tartomány{3} esik, {4}"
                , testMagassag, testSuly, this.testTomegIndex(), normalTTI() ? "ba" : "on kívül", testalkatSzoveggel(testalkalt())   
                );
        }

        public double testTomegIndex()
        {
            return Math.Round(testSuly / Math.Pow((testMagassag / 100.0), 2), 2);
        }

        public bool normalTTI()
        {
            return (testTomegIndex() >= 18.5 && testTomegIndex() < 25);
        }

        public int testalkalt()
        {
            if (testTomegIndex() < 18.5)
            {
                return -1;
            }
            else if(25 > testTomegIndex() && testTomegIndex() >= 18.5)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public string testalkatSzoveggel(int testalkat)
        {
            switch (testalkalt())
            {
                case -1: return "alultáplált"; 
                case 0: return "normál testalkatú"; 
                case 1: return "túlsúlyos";
                default: return "";
            }

        }
    }
}
