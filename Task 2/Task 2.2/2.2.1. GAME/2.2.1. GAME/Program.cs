using System;

namespace _2._2._1._GAME
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Position
    {
        protected int X;
        protected int Y;
    }

    abstract class Board
    {
        protected Position position;
        public abstract void GetPosition(Position coordinates);
    }

    class Player : Board
    {
        protected int Health;
        public void GetHealth(int health)
        {
            this.Health = health;
        }
        public override void GetPosition(Position coordinates)
        {
            this.position = coordinates;
        }
        public void Move(Position newCoordinates)
        {
            this.position = newCoordinates;
        }
    }

    abstract class Enemy : Board
    {
        public abstract void DealDamage();

        public abstract void Move(Position newCoordinates);
    }

    class Vampire : Enemy
    {
        public override void GetPosition(Position coordinates)
        {

        }

        public override void DealDamage()
        {

        }

        public override void Move(Position newCoordinates)
        {
            this.position = newCoordinates;
        }

        public void DealBleeding()
        {

        }
    }

    class Spider : Enemy
    {
        public override void GetPosition(Position coordinates)
        {

        }

        public override void DealDamage()
        {

        }

        public override void Move(Position newCoordinates)
        {
            this.position = newCoordinates;
        }

        public void DealPoisoning()
        {

        }
    }

    class Skeleton : Enemy
    {
        public override void GetPosition(Position coordinates)
        {

        }

        public override void DealDamage()
        {

        }

        public override void Move(Position newCoordinates)
        {
            this.position = newCoordinates;
        }
    }

    abstract class Boost : Board
    {

        public abstract void Healing();

        public abstract void DamageBoost();
    }

    class Apple : Boost
    {
        public override void GetPosition(Position coordinates)
        {

        }

        public override void DamageBoost()
        {
            
        }

        public override void Healing()
        {
            
        }
    }

    class Cherry : Boost
    {
        public override void DamageBoost()
        {
            
        }

        public override void GetPosition(Position coordinates)
        {
            
        }

        public override void Healing()
        {
            
        }

        public void HPSlot ()
        {

        }
    }

    class Orange : Boost
    {
        public override void DamageBoost()
        {
            
        }

        public override void GetPosition(Position coordinates)
        {
            
        }

        public override void Healing()
        {
            
        }

        public void ExtraLife ()
        {

        }
    }

    abstract class Obstruction : Board
    {
        public abstract void Size();
    }

    class Bush : Obstruction
    {
        public override void GetPosition(Position coordinates)
        {
            
        }

        public override void Size()
        {

        }
    }
    class Tree : Obstruction
    {
        public override void GetPosition(Position coordinates)
        {
            
        }

        public override void Size()
        {
            
        }
    }

    class Rock : Obstruction
    {
        public override void GetPosition(Position coordinates)
        {
            
        }

        public override void Size()
        {
            
        }
    }
}
