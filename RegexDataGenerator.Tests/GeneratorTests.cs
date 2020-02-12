using System.Text.RegularExpressions;
using NUnit.Framework;

namespace RegexDataGenerator.Tests
{
    [TestFixture]
    public class GeneratorTests
    {
        [Test]
        public void GeneratorNestedGroupsTest()
        {
            Assert.IsTrue(GeneratorTest("ab(cd)(ef(gh)i)jk"));
        }

        public bool GeneratorTest(string regexp)
        {
            var rxrdg = new RegExpDataGenerator(regexp);
            var regex = new Regex(regexp);

            for (var i = 0; i < 10; i++)
            {
                if(regex.IsMatch(rxrdg.Next()) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
