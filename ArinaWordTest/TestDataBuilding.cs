

namespace ArinaWordTest
{
    [TestClass]
    public class TestDataBuilding
    {
        [TestMethod]
        public void Provinces_1()
        {
            Province P1 = new Province
            {
                ID = "P1",
                Name = "��1"
            };

            Province P2 = new Province
            {
                ID = "P2",
                Name = "��2"
            };
        }
    }
}