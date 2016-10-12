using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Šibenice
{
    class Nitro

    {
        public static string vypis="";
        public static string tajenka = "";
        public static int errory = 0;

        public static string test(char pismeno)
        {
            if (vypis == tajenka)
            {
                vypis = (vypis + "\n HOTOVO :-)");
            }
            else
            {
                vypis= hadani(pismeno);
            }
            if (vypis == tajenka)
            {
                vypis = (vypis + "\n HOTOVO :-)");
            }
            return vypis;
        }

        public static string generuj() //nahodne vybere novou vetu k test
        {
            Random RandomNumber = new Random();
            
            int vyber;
            errory = 0;
                        
            vyber = RandomNumber.Next(1, 15);

            switch(vyber)
            {
                case 1:
                    tajenka="KDO JINEMU JAMU KOPA SAM DO NI PADA";        
                break;

                case 2:
                    tajenka="JACHYME HOD HO DO STROJE";        
                break;

                case 3:
                    tajenka="HOP DO POLE";        
                break;
                
                case 4:
                    tajenka="SUL NAD ZLATO";        
                break;

                case 5:
                    tajenka="HLAVNE CO KORODUJE VY TUPCI";       
                break;
                
                case 6:
                tajenka = "KDE UDELALI SOUDRUZU Z NDR CHYBU";        
                break;
                
                case 7:
                tajenka = "VRCHNI PRCHNI";
                break;
                
                case 8:
                tajenka = "TO ZASE BUDE V ALEJICH NABLITO";
                break;
                
                case 9:
                tajenka = "HLINIK SE ODSTEHOVAL DO HUMPOLCE";
                break;
                
                case 10:
                tajenka = "NO NEDIVTE SE DYT MU HORI BARAK";
                break;
                
                case 11:
                tajenka = "A CHCIJE A CHCIJE";
                break;

                case 12:
                tajenka = "PET SAMIC";
                break;

                case 13:
                tajenka = "NEBEROU MI NA ALZE REKLAMACI NA REPRAKY";
                break;

                case 14:
                tajenka = "STERACE STIRAJI";
                break;

                case 15:
                tajenka = "ZAVRETE OCI ODCHAZIM";
                break;
            }
            
            
            nahled();
            return vypis; 
        }
        
        public static void nahled() // vytvori hadanku
        {
            vypis = "";
            int delka = tajenka.Length;

            for (int i = 0; i < delka; i++)
            {
                if (tajenka[i] == ' ')
                {
                    vypis = (vypis + " ");
                }
                else
                {
                    vypis = (vypis + "-");
                }
            }
        }

        public static string hadani(char pismeno) // zmeni vypis o uhadle pismeno
        {
            int delka = tajenka.Length;
            string pomocny="";

            for (int i=0 ; i < delka ; i++) 
            {
               if (tajenka[i] == pismeno)
                {
                    pomocny=(pomocny + pismeno);
                }
                else
                {
                    pomocny=(pomocny + vypis[i]);
                }
            }
            if (pomocny == vypis)
            {
                errory++;
            }
            return pomocny;
        }
   
    
    }
}
