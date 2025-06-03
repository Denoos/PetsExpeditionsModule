using Domain.Models.BuisnessModels.BaseModels;

namespace Domain.Models.BuisnessModels
{
    public class Pet : Entity
    {
        public int CharacterId { get; }

        public int GoodEvilLine { get; }

        public int LawChaosLine { get; }

        private Pet(string Name, int BAB, int STR, int DEX, int CON, int INT, int WIS, int CHA, int AC, int CritHitMult, string BaseDamage, string DamageBonus, int Fort, int Refl, int Will, int MaxHP, int CharacterId, int GoodEvilLine, int LawChaosLine)
        {
            this.Name = Name;
            this.BAB = BAB;
            this.STR = STR;
            this.DEX = DEX;
            this.CON = CON;
            this.INT = INT;
            this.WIS = WIS;
            this.CHA = CHA;
            this.AC = AC;
            this.CritHitMult = CritHitMult;
            this.BaseDamage = BaseDamage;
            this.DamageBonus = DamageBonus;
            this.Fort = Fort;
            this.Refl = Refl;
            this.Will = Will;
            this.MaxHP = MaxHP;
            this.CharacterId = CharacterId;
            this.GoodEvilLine = GoodEvilLine;
            this.LawChaosLine = LawChaosLine;
        }

        public static Pet Create(string Name, int BAB, int STR, int DEX, int CON, int INT, int WIS, int CHA, int AC, int CritHitMult, string BaseDamage, string DamageBonus, int Fort, int Refl, int Will, int MaxHP, int CharacterId, int GoodEvilLine, int LawChaosLine)
            => new(Name, BAB, STR, DEX, CON, INT, WIS, CHA, AC, CritHitMult, BaseDamage, DamageBonus, Fort, Refl, Will, MaxHP, CharacterId, GoodEvilLine, LawChaosLine);
    }
}
