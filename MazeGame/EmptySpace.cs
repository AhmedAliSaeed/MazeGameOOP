﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class EmptySpace : IMazeObject
    {
        public char Icon => ' ';

        public bool IsSolid => false;
    }
}
