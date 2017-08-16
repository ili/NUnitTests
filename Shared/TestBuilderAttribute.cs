using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Builders;

namespace Shared
{
	[AttributeUsage(AttributeTargets.Method)]
	public class TestBuilderAttribute : NUnitAttribute, ITestBuilder, IImplyFixture
	{
		public IEnumerable<TestMethod> BuildFrom(IMethodInfo method, Test suite)
		{
			var builder = new NUnitTestCaseBuilder();

			var test1 = builder.BuildTestMethod(method, suite, new TestCaseParameters(new object[] {1}));
			SetName(test1, method, "1");
			yield return test1;

			var test2 = builder.BuildTestMethod(method, suite, new TestCaseParameters(new object[] {2}));
			SetName(test2, method, "2");
			yield return test2;
		}

		private static void SetName(TestMethod test, IMethodInfo method, string value)
		{
			var name = method.Name + "." + value;

			test.Name = method.TypeInfo.FullName.Replace("Tests.", "") + "." + name;
		}
	}
}