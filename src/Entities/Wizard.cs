namespace Abstraindo_um_Jogo_de_RPG_Usando_POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.currentHP = HP;
            this.currentMP = MP;
            this.HP = HP;
            this.MP = MP;
        }
        public override string FisicalAttack()
        {
            return this.Name + " used fisical attack.";
        }

        public string MagicalAttack(int Bonus, int mpCost)
        {
            if (Bonus > 6)
            {
                this.currentMP =- mpCost;
                return this.Name + " casted a super magic attack with bonus of " + Bonus + " that costed " + mpCost + " mana.";
            }
            else 
            {
                this.currentMP =- mpCost;
                return this.Name + " casted a weak magic attack with bonus of " + Bonus + " that costed " + mpCost + " mana.";
            }
            
        }
    }
}