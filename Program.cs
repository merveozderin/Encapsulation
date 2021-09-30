using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci() ;
            ogrenci.Isim ="Merve" ;
            ogrenci.Soyisim = "Özderin" ;
            ogrenci.Ogrencino = 256 ;
            ogrenci.Sinif = 4 ;

            ogrenci.OgrenciBilgileriniGetir() ;

            ogrenci.SinifDüsür() ;
            ogrenci.OgrenciBilgileriniGetir() ;

            Ogrenci ogrenci1 = new Ogrenci("Hayat", "Güzel" , 123, 1) ;
            ogrenci1.OgrenciBilgileriniGetir() ;
            ogrenci1.SinifDüsür() ;
            ogrenci1.OgrenciBilgileriniGetir() ;
           
            
        }
    }

    class Ogrenci
    {
        private string isim ;
        private string soyisim ;
        private int ogrencino ;
        private int sinif ;

        public string Isim 
        {
            get { return isim ;}
            set { isim = value ;}
        }

        public string Soyisim { get => soyisim ; set => soyisim = value ;}
        public int Ogrencino { get => ogrencino ; set => ogrencino = value ;}
        public int Sinif 
        { 
            get => sinif ; 
            set 
            {
                if( value < 1 )
                {
                    Console.Write("Sınıf en az 1 olabilir.") ;
                    sinif = 1 ;
                }
                else
                  sinif = value ;

            }
        }
        public Ogrenci (string isim, string soyisim, int ogrencino, int sinif)
        {
            Isim = isim ;
            Soyisim = soyisim ;
            Ogrencino = ogrencino ;
            Sinif = sinif ;
        }

        public Ogrenci() {}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*****Öğrenci Bilgileri*****") ;
            Console.WriteLine("Öğrenci Adı     :{0}", this.Isim) ;
            Console.WriteLine("Öğrenci Soyadı  :{0}", this.Soyisim) ;
            Console.WriteLine("Öğrenci No      :{0}", this.Ogrencino) ;
            Console.WriteLine("Öğrenci Sınıfı  :{0}", this.Sinif) ;
        }

        public void SinifArttir ()
        {
            this.Sinif = this.Sinif + 1 ;
        }

          public void SinifDüsür ()
        {
            this.Sinif = this.Sinif - 1 ;
        }
    } 
}
