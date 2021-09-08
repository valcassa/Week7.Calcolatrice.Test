using System;
using Week7.Calcolatrice.Core;
using Xunit;

namespace Calcolatrice2
{
    public class CalcolatriceTest
    {
        [Fact]

        public void Somma()
        {
            Calcolatrice calcolatrice = new Calcolatrice();

            double risultato = calcolatrice.Somma(1, 2);

            Assert.True(risultato == 3);
        }

        [Fact]
        public void Sottrazione()
        {
            Calcolatrice calcolatrice = new Calcolatrice();

            double risultato = calcolatrice.Sottrazione(1, 2);

            Assert.True(risultato == -1);
        }

        [Fact]
        public void Moltiplicazione()
        {
            Calcolatrice calcolatrice = new Calcolatrice();

            double risultato = calcolatrice.Moltiplicazione(1, 2);

            Assert.True(risultato == 2);
        }

        [Fact]
        public void Divisione()
        {
            Calcolatrice calcolatrice = new Calcolatrice();

            double risultato = calcolatrice.Div(1, 2);

            Assert.True(risultato == 0.5);
        }
    }
}
