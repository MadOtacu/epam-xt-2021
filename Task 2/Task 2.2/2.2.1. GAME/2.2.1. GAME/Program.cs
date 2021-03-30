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
        public int X;
        public int Y;
    }

    abstract class GameObject
    {
        public Position position { get; protected set; }
    }

    class Player : GameObject
    {
        public int Health { get; private set; }

        public void Move(Position newCoordinates)
        {
            position = newCoordinates;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    abstract class Enemy : GameObject
    {
        protected Player target;

        protected int damage;

        public Enemy (Player player)
        {
            target = player;
        }

        public abstract void DealDamage();

        public abstract void Move(Position newCoordinates);
    }

    class Vampire : Enemy
    {
        public Vampire(Player player) : base(player)
        {
        }

        public override void DealDamage()
        {
            target.TakeDamage(damage);
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
        public Spider(Player player) : base(player)
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
        public Skeleton(Player player) : base(player)
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

    abstract class Boost : GameObject
    {

        public abstract void Healing();

        public abstract void DamageBoost();
    }

    class Apple : Boost
    {

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

        public override void Healing()
        {
            
        }

        public void ExtraLife ()
        {

        }
    }

    abstract class Obstruction : GameObject
    {
        public int[] Size;
        public Obstruction (int[] size)
        {
            Size = size;
        }
    }

    class Bush : Obstruction
    {
        public Bush(int[] size) : base(size)
        {

        }
    }
    class Tree : Obstruction
    {
        public Tree(int[] size) : base(size)
        {

        }
    }

    class Rock : Obstruction
    {
        public Rock(int[] size) : base(size)
        {

        }
    }
}
