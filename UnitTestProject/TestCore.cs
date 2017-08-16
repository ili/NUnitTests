using NUnit.Framework;
using Shared;

namespace UnitTestProject
{
	[TestFixture]
	internal class TestCore
	{
		[Test]
		[TestBuilder]
		public void BuildedTestCore(int value)
		{
			Assert.That(value != 0);
		}

		[Test]
		public void SimpleTestCore()
		{
		}

		[Test]
		[ThrowsBuilder]
		public void ThrowsBuildedTestCore(int value)
		{
		}
	}
}