﻿using System;
using System.Collections.Generic;
using System.Text;
using Tetris.DataTypes;

namespace Tetris.Shapes
{
    public class SShape : Shape
    {
        public override char Code => 'S';

        public override Pixel[] Pixels => new Pixel[4]
        {
            new Pixel(0, 0),
            new Pixel(1, 1),
            new Pixel(1, 0),
            new Pixel(2, 1),
        };
    }
}
