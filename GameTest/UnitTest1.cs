using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WFA_SimpleGame;

namespace GameTest
{
    [TestClass]
    public class GameTest

    {
        private CarRace carRace = new CarRace();
        [TestMethod]
        public void CarSpeed_Increase()
        {
            KeyEventArgs args = new KeyEventArgs(Keys.Up);
            carRace.CarSpeed = 10;

            carRace.Form1_KeyDown(null, args);

            Assert.AreEqual(11, carRace.CarSpeed);
        }
        [TestMethod]
        public void LeftKey_MoveCarLeft()
        {
            var e = new KeyEventArgs(Keys.Left);
            carRace.MyCar.Left = 50;

            carRace.Form1_KeyDown(null, e);

            Assert.AreEqual(45, carRace.MyCar.Left);
        }

        [TestMethod]
        public void CarSpeed()
        {
            KeyEventArgs args = new KeyEventArgs(Keys.Up);
            carRace.CarSpeed = 20;

            carRace.Form1_KeyDown(null, args);

            Assert.AreEqual(20, carRace.CarSpeed);
        }

        [TestMethod]
        public void CarSpeed_GreaterThan_Zero()
        {
            KeyEventArgs args = new KeyEventArgs(Keys.Down);
            carRace.CarSpeed = 10;

            carRace.Form1_KeyDown(null, args);

            Assert.AreEqual(9, carRace.CarSpeed);
        }

        [TestMethod]
        public void Zero_CarSpeed()
        {
            KeyEventArgs args = new KeyEventArgs(Keys.Down);
            carRace.CarSpeed = 0;

            carRace.Form1_KeyDown(null, args);

            Assert.AreEqual(0, carRace.CarSpeed);
        }

        [TestMethod]
        public void Car_Position100()
        {
            KeyEventArgs args = new KeyEventArgs(Keys.Left);
            carRace.MyCar.Left = 100;

            carRace.Form1_KeyDown(null, args);

            Assert.AreEqual(95, carRace.MyCar.Left);
        }

        [TestMethod]
        public void CarSpeed_Decrease()
        {
            KeyEventArgs args = new KeyEventArgs(Keys.Left);
            carRace.MyCar.Left = 11;

            carRace.Form1_KeyDown(null, args);

            Assert.AreEqual(11, carRace.MyCar.Left);
        }

        [TestMethod]
        public void CarLeft_Position()
        {
            KeyEventArgs args = new KeyEventArgs(Keys.Right);
            carRace.MyCar.Left = 300;

            carRace.Form1_KeyDown(null, args);

            Assert.AreEqual(305, carRace.MyCar.Left);
        }

        [TestMethod]
        public void CarRight_Position()
        {
            
            KeyEventArgs args = new KeyEventArgs(Keys.Right);
            carRace.MyCar. Left = 370;
            
            carRace.Form1_KeyDown(null, args);
            
            Assert.AreEqual(370, carRace.MyCar.Left);
        }

        [TestMethod]
        public void Other_KeyCodes()
        {
            
            KeyEventArgs args = new KeyEventArgs(Keys.A);
            carRace.CarSpeed = 10;
            carRace.MyCar.Left = 100;
            
            carRace.Form1_KeyDown(null, args);
            
            Assert.AreEqual(10, carRace.CarSpeed);
            Assert.AreEqual(100, carRace.MyCar.Left);
        }
    }

}
