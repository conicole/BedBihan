﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class HumanFaction : AbstractFaction
    {
        public HumanFaction(int size): base(size)
        {
            this.unitFactory = new UnitFactoryHuman();
            this.createArmy(size);
        }
    }
}
