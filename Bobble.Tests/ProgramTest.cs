using System;
using Dobble;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bobble.Tests
{
    [TestClass]
    public class ProgramTest
    {
        private const int n = 3;
        private const int rep = n;

        [TestMethod]
        public void AllCardsConnectWithEachOver()
        {
            const int width = 1 + (rep - 1)*n;
            var cards = new CardsGenerator().Generate(n, rep);
            ShowCards(cards);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i1 = 0; i1 < width; i1++)
                    {
                        bool isConnect = false;
                        for (int j1 = 0; j1 < n; j1++)
                        {
                            if (cards[j, i] == cards[j1, i1])
                            {
                                isConnect = true;
                                break;
                            }
                        }

                        Assert.IsTrue(isConnect);
                    }
                }
            }
        }

        private void ShowCards(int[,] array)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (rep - 1) * n + 1; j++)
                {
                    for (int k = 0; k < 2 - array[i, j].ToString().Length; k++)
                    {
                        System.Diagnostics.Debug.Write(" ");
                    }

                    System.Diagnostics.Debug.Write(array[i, j] + " ");
                }

                System.Diagnostics.Debug.WriteLine("");
            }
        }
    }
}
