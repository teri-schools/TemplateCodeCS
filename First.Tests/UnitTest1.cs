global using NUnit.Framework;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace First.Test;


public class Tests
{
    
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    [TestCase(1, false)]
    [TestCase(2, true)]
    public static void FirstProgram_ToTestFunction_ReturnBool(int in_num, bool out_result)
    {
        bool result = FirstProgram.ToTestFunction(in_num);
        Assert.That(out_result, Is.EqualTo(result));
    }
}