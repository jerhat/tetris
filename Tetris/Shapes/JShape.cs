﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris.Shapes
{
    public class JShape : Shape
    {
        public override char Code => 'J';

        public override Pixel[] Pixels => new Pixel[4]
        {
            new Pixel(0, 0),
            new Pixel(1, 0),
            new Pixel(1, 1),
            new Pixel(1, 2),
        };
    }
}
