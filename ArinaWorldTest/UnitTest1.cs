using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace ArinaWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [TestMethod]
        public void TestMethod1()
        {
            string IniPath = "C:\\Programs\\TestArea\\test.ini";
            WritePrivateProfileString("A", "AA", "BBB", IniPath);
            WritePrivateProfileString(null, "CC", "33", IniPath);
            //StringBuilder temp = new StringBuilder(255);
            //int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            //return temp.ToString();
        }

        //public void IniWriteValue(string Section, string Key, string Value)
        //{
            
        //}

        //public string IniReadValue(string Section, string Key)
        //{
            
        //}
    }
}
