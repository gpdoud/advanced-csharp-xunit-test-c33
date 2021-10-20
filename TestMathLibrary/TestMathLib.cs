using System;

using Xunit;

namespace TestMathLibrary {

	public class TestMathLib {

		[Theory]
		[InlineData(3, 1, 2)]
		[InlineData(-3, -1, -2)]
		public void TestAdd(int ans, int a, int b) {
			Assert.Equal(ans, MathLibrary.MathLib.Add(a, b));
		}
	
		[Fact]
		public void TestPI() {
			Assert.Equal(3.1415926m, MathLibrary.MathLib.PI);
		}
	}
}
