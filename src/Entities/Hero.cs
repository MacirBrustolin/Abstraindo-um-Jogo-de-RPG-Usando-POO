namespace Abstraindo_um_Jogo_de_RPG_Usando_POO.src.Entities
{
    public abstract class Hero
    {

        
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.currentHP = HP;
            this.currentMP = MP;
            this.HP = HP;
            this.MP = MP;
        }

        public Hero(){

        }

        public string? Name;
        public int Level;
        public string? HeroType;
        public int currentHP;
        public int currentMP;
        public int HP;
        public int MP;


        public override string ToString()
        {
            return ("\n      " + this.Name + "\n\tLvl. " + this.Level + " " + this.HeroType + "\n\tHP     " + this.currentHP + " / " + this.HP + "\n\tMP     " + this.currentMP + " / " + this.MP);
        }

        public virtual string FisicalAttack()
        {
            return this.Name + " Atacou.";
        }

        public virtual string MagicalAttack()
        {
            return this.Name + " usou Magia.";
        }
    }
}