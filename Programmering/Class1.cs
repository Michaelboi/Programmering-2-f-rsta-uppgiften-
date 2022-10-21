using System;

namespace Programmering2Exempel
{
    public class Bil
    {
        private int hjul = 4;
        private string färg = "Blå";
        private string motortyp = "Diesel";
        

        public int getHjul()
        {
            return this.hjul;
        }
        public string getFärg()
        {
            return this.färg;
        }
        public string getMotortyp()
        {
            return this.motortyp;
        }
        public void sethjul(int hjul)
        {
            this.hjul = hjul;

        }
        public void setFärg(string färg)
        {
            this.färg = färg;
        }
    }
}