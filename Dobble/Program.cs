using System;
using System.Globalization;

namespace Dobble
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 4; // number of images on a card
            const int rep = 4; // number of repeters of an image

            var cards = new CardsGenerator().Generate(n, rep);
        }
    }
}
