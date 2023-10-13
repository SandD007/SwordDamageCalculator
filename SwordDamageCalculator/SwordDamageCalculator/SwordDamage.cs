using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageCalculator
{
    public class SwordDamageCalulator
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
        private int roll;
        private bool flaming;
        private bool magic;

        public SwordDamageCalulator(int startingRoll) 
        {
            roll = startingRoll;
            CalculateDamage();
        }

        public int Damage { get; private set; }

        public int Roll 
        {
            get
            {
                return roll;
            } 
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        public bool Flaming
        {
            get { return flaming;}
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private void CalculateDamage()
        {
            decimal magicMultiplaier = 1m;
            if (Magic)
            {
                magicMultiplaier = 1.75m;
            }
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplaier) + BASE_DAMAGE;
            if(Flaming)
            {
                Damage += FLAME_DAMAGE;
            }
            
        }
        

    }
}
