﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public struct Pixel
    {
        public ushort X, Y;

        public Pixel(ushort x, ushort y)
        {
            X = x;
            Y = y;
        }
    }
}
