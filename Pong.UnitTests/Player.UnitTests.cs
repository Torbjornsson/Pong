using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pong.UnitTests
{
    [TestClass]
    public class Player_UnitTests
    {
        [TestMethod]
        public void PlayerInitialScore_IsZero()
        {
            var player = new Player();

            Assert.AreEqual(0, player.Score);
        }
    }
}
