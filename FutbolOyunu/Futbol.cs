using FutbolOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    class Futbol
    {
        public  Random rastgeleSayi = new Random();
        protected string adSoyad;
        protected int formaNo;
        protected int hiz;
        protected int dayaniklik;
        protected int pas;
        protected int sut;
        protected int yetenek;
        protected int kararlilik;
        protected int dogalForm;
        protected int sans;
        public Futbol(string adSoyad, int formaNo)
        {
            hiz = rastgeleSayi.Next(50, 100);
            dayaniklik = rastgeleSayi.Next(50,100);
            pas = rastgeleSayi.Next(50,100);
            sut = rastgeleSayi.Next(50,100);
            yetenek = rastgeleSayi.Next(50,100);
            kararlilik = rastgeleSayi.Next(50,100);
            dogalForm = rastgeleSayi.Next(50,100);
            sans = rastgeleSayi.Next(50,100);
    }
        public Futbol()
        {

        }
        public virtual bool passVer()
        {
            int PasSkor = Convert.ToInt32(pas * 0.3 + yetenek * 0.3 + dayaniklik * 0.1 + dogalForm * 0.1 + sans * 0.2);
            if (PasSkor>60)
            {
                return true;
            }
            else
              return false;
        }
        public virtual bool golVurusu()
        {
            int golSkor = Convert.ToInt32(yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.2 + hiz*0.1 );
            if (golSkor > 70)
            {
                return true;
            }
            else
                return false;
        }



    }
    class Defans : Futbol
    {
        private int pozisyonAlma;
        private int kafa;
        private int sicrama;
        public Defans(string adSoyad, int formaNo)
        {
            this.adSoyad = adSoyad;
            this.formaNo = formaNo;
            hiz = rastgeleSayi.Next(50, 90);
            dayaniklik = rastgeleSayi.Next(50, 90);
            pas = rastgeleSayi.Next(50, 90);
            sut = rastgeleSayi.Next(50, 90);
            yetenek = rastgeleSayi.Next(50, 90);
            kararlilik = rastgeleSayi.Next(50, 90);
            dogalForm = rastgeleSayi.Next(50, 90);
            sans = rastgeleSayi.Next(50, 90);
            pozisyonAlma = rastgeleSayi.Next(50, 90);
            kafa = rastgeleSayi.Next(50, 90);
            sicrama = rastgeleSayi.Next(50, 90);
        }

        public virtual bool golVurusu()
        {
            int golSkor = Convert.ToInt32(yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.2 + kafa * 0.1+kararlilik*0.1);
            if (golSkor > 70)
            {
                return true;
            }
            else
                return false;
        }


    }
    class OrtaSaha : Futbol
    {
        private int uzunTop;
        private int ilkDokunus;
        private int uretkenlik;
        private int topSurme;
        private int ozelYetenek;
        public OrtaSaha(string adSoyad, int formaNo)
        {
            this.adSoyad = adSoyad;
            this.formaNo = formaNo;
            hiz = rastgeleSayi.Next(60, 100);
            dayaniklik = rastgeleSayi.Next(60, 100);
            pas = rastgeleSayi.Next(60, 100);
            sut = rastgeleSayi.Next(60, 100);
            yetenek = rastgeleSayi.Next(60, 100);
            kararlilik = rastgeleSayi.Next(60, 100);
            dogalForm = rastgeleSayi.Next(60, 100);
            sans = rastgeleSayi.Next(60, 100);
            uzunTop = rastgeleSayi.Next(60, 100);
            ilkDokunus = rastgeleSayi.Next(60, 100);
            uretkenlik = rastgeleSayi.Next(60, 100);
            topSurme = rastgeleSayi.Next(60, 100);
            ozelYetenek = rastgeleSayi.Next(60, 100);
        }

        public override bool passVer()
        {
            int PasSkor = Convert.ToInt32(pas * 0.3 + dayaniklik * 0.1 + dogalForm * 0.1 + sans * 0.2);
            if (PasSkor > 60)
            {
                return true;
            }
            else
                return false;
        }
        public virtual bool golVurusu()
        {
            int golSkor = Convert.ToInt32(yetenek * 0.3 + sut*0.2 +kararlilik*0.1+ dogalForm * 0.1 + sans * 0.2+hiz*0.1);
            if (golSkor > 70)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Forvet : Futbol
    {
        private int bitiricilik;
        private int ilkDokunus;
        private int kafa;
        private int ozelYetenek;
        private int sogukKanlilik;
        public Forvet(string adSoyad, int formaNo)
        {
            this.adSoyad = adSoyad;
            this.formaNo = formaNo;
            hiz = rastgeleSayi.Next(70, 100);
            dayaniklik = rastgeleSayi.Next(70, 100);
            pas = rastgeleSayi.Next(70, 100);
            sut = rastgeleSayi.Next(70, 100);
            yetenek = rastgeleSayi.Next(70, 100);
            kararlilik = rastgeleSayi.Next(70, 100);
            dogalForm = rastgeleSayi.Next(70, 100);
            sans = rastgeleSayi.Next(70, 100);
            bitiricilik = rastgeleSayi.Next(70, 100);
            ilkDokunus = rastgeleSayi.Next(70, 100);
            kafa = rastgeleSayi.Next(70, 100);
            ozelYetenek = rastgeleSayi.Next(70, 100);
            sogukKanlilik = rastgeleSayi.Next(70, 100);
        }

        public override bool passVer()
        {
            int PasSkor = Convert.ToInt32(pas * 0.3 + yetenek * 0.2+ozelYetenek*0.2+ dayaniklik * 0.1 + dogalForm * 0.1 + sans * 0.2);
            if (PasSkor > 60)
            {
                return true;
            }
            else
                return false;
        }
        public virtual bool golVurusu()
        {
            int golSkor = Convert.ToInt32(yetenek * 0.2 + sut * 0.1 +kafa*0.1+ kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.2 + kafa * 0.1 + kararlilik * 0.1);
            if (golSkor > 70)
            {
                return true;
            }
            else
                return false;
        }


    }
}
    
   

