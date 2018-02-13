using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Models.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void Test_JustATest_True()
    {
      Assert.AreEqual(true, ProjectModel.Test(true));
      Assert.AreEqual(false, ProjectModel.Test(false));
    }
  }
