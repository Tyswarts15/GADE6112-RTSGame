using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGame
{
    abstract class Unit
    {
        private int xPos;
        private int yPos;
        private int Health;
        private int Speed;
        private int Attack;
        private int attackRange;
        private string Faction;
        private string Image;

    }

    public Unit(int xPos, int yPos, int Health, int Speed, int Attack, int AttackRange, string Faction, string Image)
    {
        health = Health;
        speed = Speed;
        attack = Attack
        attackRange = AttackRange
        faction = Faction
        image = Image;


    }

    public int xPosition
    {
        get { return posX }
        set { posX = value; }
    }

    public int yPosition
    {
        get { return posY }
        set { posY = value; }
    }

    public int health
    {        
        get { return Health }
        set {  Health = value; }    
    }

    public int speed
    {
        get { return Speed  }
        set { Speed = value; }
    }

    public int attack
    {
        get { return attack}
        set {attack  = value; }
    }

    public int attackRange
    {
        get { return atackR }
        set { attackR = value; }
    }

   



    abstract public void MoveToPosition(int 1Pos, int 2Pos, int 3Pos, int 4Pos); 

    abstract public bool Attack();                                             

    abstract public bool InRange(int xPos, int yPos, int attackRange);      

    abstract public int ReturnPosition(int xPos, int yPos);                    

    abstract public bool Dead();                                           
                                         
}
