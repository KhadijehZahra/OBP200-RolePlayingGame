namespace OBP200_RolePlayingGame;

public class Enemy
{
    public string Name { get; private set; }
    public int Hp { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int XpReward { get; private set; }
    public int GoldReward { get; private set; }
    
    public virtual int GetAttack()
    {
        return Attack;
    }

    public Enemy(string name, int hp, int attack, int defense, int xp, int gold)
    {
        Name = name;
        Hp = hp;
        Attack = attack;
        Defense = defense;
        XpReward = xp;
        GoldReward = gold;
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        if (Hp < 0)
        {
            Hp = 0;
        }
    }

    public bool IsDead()
    {
        return Hp <= 0;
    }
}


public class Boss : Enemy
{
    public Boss(string name, int hp, int atk, int def, int xp, int gold)
        : base(name, hp, atk, def, xp, gold)
    {
    }

    public override int GetAttack()
    {
        return Attack + 3;
    }
}