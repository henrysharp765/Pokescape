using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PokescapeServer
{
    public class ScapeMonsterMove
    {
        public int MoveDamage;
        public string Name;
    }
    public enum ScapeMonsterType
    {
        Fire, 
        Water,
        Rock
    }
    public class ScapeMonster
    {
        public (int xCord, int yCord) PokemonCoordinates;
        public string ScapeMonsterName;
        public string ScapeMonsterId;
        public ScapeMonsterType Type;
        public double MaximumHealth;
        public double Health;
        public double DamagePerHit;
        public List<ScapeMonsterMove> Moves;
        public int Level; 

        public ScapeMonster() { }   

    }
}
