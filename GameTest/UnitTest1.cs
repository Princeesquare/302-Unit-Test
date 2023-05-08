using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WFA_SimpleGame;

namespace GameTest
{
    [TestClass]
    public class GameTest

    {
        [TestMethod]
        public void TestEnemyMovement()
        {
            Form1 form = new Form1();
            form.MoveEnemy();
            // Arrange
            Random R = new Random();
            int initialTop1 = 550; // Set initial position above 500 for Enemy1
            int initialTop2 = 550; // Set initial position above 500 for Enemy2
            int initialTop3 = 550; // Set initial position above 500 for Enemy3
            int initialTop4 = 550; // Set initial position above 500 for Enemy4
            int carSpeed = 5; // Set the desired car speed
            int expectedTop1 = initialTop1 - carSpeed; // Expected top position for Enemy1
            int expectedTop2 = initialTop2 - carSpeed; // Expected top position for Enemy2
            int expectedTop3 = initialTop3 - carSpeed; // Expected top position for Enemy3
            int expectedTop4 = initialTop4 - carSpeed; // Expected top position for Enemy4

            // Act
            if (initialTop1 > 500)
            {
                Enemy1.Left = R.Next(11, 100);
                Enemy1.Top = initialTop1;
            }
            else
            {
                Enemy1.Top += carSpeed;
            }

            if (initialTop2 > 500)
            {
                Enemy2.Left = R.Next(100, 190);
                Enemy2.Top = initialTop2;
            }
            else
            {
                Enemy2.Top += carSpeed;
            }

            if (initialTop3 > 500)
            {
                Enemy3.Left = R.Next(200, 290);
                Enemy3.Top = initialTop3;
            }
            else
            {
                Enemy3.Top += carSpeed;
            }

            if (initialTop4 > 500)
            {
                Enemy4.Left = R.Next(300, 370);
                Enemy4.Top = initialTop4;
            }
            else
            {
                Enemy4.Top += carSpeed;
            }

            // Assert
            Assert.AreEqual(expectedTop1, Enemy1.Top);
            Assert.AreEqual(expectedTop2, Enemy2.Top);
            Assert.AreEqual(expectedTop3, Enemy3.Top);
            Assert.AreEqual(expectedTop4, Enemy4.Top);
        }
    }

}
