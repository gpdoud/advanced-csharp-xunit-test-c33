using System;

using Xunit;

namespace TestMathLibrary {

	public class TestMathLib {

		[Theory]
		[InlineData(2, 1, 2)]
		[InlineData(2, -1, -2)]
		[InlineData(-2, -1, 2)]
		[InlineData(0, 0, -2)]
		[InlineData(1, -1, 0)]
		public void TestMult(int ans, int a, int b) {
			Assert.Equal(ans, MathLibrary.MathLib.Mult(a, b));
		}
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
