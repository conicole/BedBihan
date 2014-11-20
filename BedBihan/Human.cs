﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Human : Unit
    {
        public int numberOfKills
        {
            get;
            private set;
        }

        public void addKill()
        {
            this.numberOfKills++;
        }
  

        public override void moveOn(Hexagon hexagon)
        {
            throw new NotImplementedException();
        }

        public Human() : base()
        {
            this.costOfMovement[(int) Field.Plain] = 0.5F;
            Console.WriteLine("created human");
        }

        public Human(int maxLife, int att, int def, int maxMov, Coordinates spawningPoint) : base(maxLife, att, def, maxMov, spawningPoint)
        {
            this.costOfMovement[(int) Field.Plain] = 0.5F;
        }



       
    }
}
