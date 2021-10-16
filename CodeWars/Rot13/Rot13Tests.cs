using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeWars.Rot13
{
	public class Rot13Tests
	{
		private Rot13 _rot13 =  new Rot13();

		[Fact]
		public void Test1()
		{
			var result = _rot13.Method("ROT13 example.");
			Assert.Equal("EBG13 rknzcyr.", result);
		}

		[Fact]
		public void Test2()
		{
			var result = _rot13.Method("This is my first ROT13 excercise!");
			Assert.Equal("Guvf vf zl svefg EBG13 rkprepvfr!", result);
		}
	}
}
