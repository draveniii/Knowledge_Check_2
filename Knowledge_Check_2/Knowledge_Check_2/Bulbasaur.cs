using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Check_2
{
    internal class Bulbasaur : Pokemon
    {
        public string Ability {  get; set; }
        public string Nature { get; set; }

        public Bulbasaur()
        {
            NickName = "";
            Ability = "";
            Nature = "";
        }

        new public string ToString()
        {
            return $"\nName: {NickName}\nAbility: {Ability}\nNature: {Nature}\n";
        }
    }
}
