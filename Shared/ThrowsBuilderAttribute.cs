using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace Shared
{
	[AttributeUsage(AttributeTargets.Method)]
	public class ThrowsBuilderAttribute : NUnitAttribute, ITestBuilder, IImplyFixture
	{
		public IEnumerable<TestMethod> BuildFrom(IMethodInfo method, Test suite)
		{
			throw new InvalidOperationException("We do need some more diagnosics");
		}
	}
}