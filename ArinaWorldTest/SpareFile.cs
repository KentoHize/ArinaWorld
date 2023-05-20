using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using System.Text;
using Aritiafel.Characters.Heroes;

namespace ArinaWorldTest
{
    [TestClass]
    public class SpareFile
    {
        [TestMethod]
        public void Spare()
        {
            Tina.SaveProject(ProjectChoice.ArinaWorld, "D");            
        }
    }
}
