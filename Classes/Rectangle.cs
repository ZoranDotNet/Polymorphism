﻿namespace Lab_7_Polymorphism.Classes
{
    class Rectangle : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Base = 4;
            Height = 8;
        }

        public override double Area(double rectangleBase, double height)
        {
            return rectangleBase * height;
        }

        public override double Circumference(double rectangleBase, double height)
        {
            return 2 * rectangleBase + 2 * height;
        }

    }
}
