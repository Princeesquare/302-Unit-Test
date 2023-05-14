using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WFA_SimpleGame;

namespace GameTest
{
    [TestClass]
    public class GameTest

    {
            private Form1 _form;

            [TestInitialize]
            public void Setup()
            {
                _form = new Form1();
            }

            [TestMethod]
            public void UpKey_IncreaseCarSpeed()
            {
                // Arrange
                var e = new KeyEventArgs(Keys.Up);

                // Act
                _form.Form1_KeyDown(null, e);

                // Assert
                Assert.AreEqual(1, _form.CarSpeed);
            }

            [TestMethod]
            public void DownKey_DecreaseCarSpeed()
            {
                // Arrange
                var e = new KeyEventArgs(Keys.Down);
                _form.CarSpeed = 5;

                // Act
                _form.Form1_KeyDown(null, e);

                // Assert
                Assert.AreEqual(4, _form.CarSpeed);
            }

            [TestMethod]
            public void LeftKey_MoveCarLeft()
            {
                // Arrange
                var e = new KeyEventArgs(Keys.Left);
                _form.MyCar.Left = 50;

                // Act
                _form.Form1_KeyDown(null, e);

                // Assert
                Assert.AreEqual(45, _form.MyCar.Left);
            }

            [TestMethod]
            public void RightKey_MoveCarRight()
            {
                // Arrange
                var e = new KeyEventArgs(Keys.Right);
                _form.MyCar.Left = 50;

                // Act
                _form.Form1_KeyDown(null, e);

                // Assert
                Assert.AreEqual(55, _form.MyCar.Left);
            }
    }

}
