using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Emsi
{
    internal class Ouvrage
    {
        private String date;
        private String num;


        public Ouvrage(string date, string num)
        {
            this.date = date;
            this.num = num;
        }

     
        public void setDate(String date)
        {
            date = date;
        }
        public void setNumero(String n)
        {
            num = n;
        }
    
        public String getDate()
        {
            return date;
        }
        public String getNumero()
        {
            return num;
        }



    }
}
