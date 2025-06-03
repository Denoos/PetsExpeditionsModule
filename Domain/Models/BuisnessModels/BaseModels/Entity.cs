using System.Runtime.InteropServices;

namespace Domain.Models.BuisnessModels.BaseModels
{
    public class Entity
    {
        public string Name { get; set; }

        public int BAB { get; set; }

        public int STR { get; set; }

        public int DEX { get; set; }

        public int CON { get; set; }

        public int INT { get; set; }

        public int WIS { get; set; }

        public int CHA { get; set; }

        public int AC { get; set; }

        public int CritHitMult { get; set; }

        public string BaseDamage { get; set; }

        public string DamageBonus { get; set; }

        public int Fort { get; set; }

        public int Refl { get; set; }

        public int Will { get; set; }

        public int MaxHP { get; set; }
    }
}
