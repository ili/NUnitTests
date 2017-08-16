using System;
using NUnit.Framework;
using Shared;

namespace UnitTestProject45
{
	[TestFixture]
	public class Test45
	{
		[Test]
		[TestBuilder]
		public void BuildedTest45(int value)
		{
			Console.WriteLine(value);
			Assert.That(value != 0);
		}

		[Test]
		public void SimpleTest45()
		{
		}

		[Test]
		[ThrowsBuilder]
		public void ThrowsBuildedTest45()
		{
		}
	}
}