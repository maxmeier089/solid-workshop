using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    public abstract class Movie
    {

        public string Title { get; set; }

        public abstract double DetermineAmount(int daysRented);
        public abstract double DeterminePoints(int daysRented);

    }
}
