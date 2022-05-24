using System.Collections.Generic;
using Xunit;

namespace CodeWars.DidYouMean
{
    public class DidYouMeanTests
    {
		[Fact]
        public void TestDictionary1()
        {
            DidYouMeanClass kata = new DidYouMeanClass(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
            Assert.Equal("strawberry", kata.FindMostSimilar("strawbery"));
            Assert.Equal("cherry", kata.FindMostSimilar("berry"));
        }

        [Fact]
        public void TestDictionary2()
        {
            DidYouMeanClass kata = new DidYouMeanClass(new List<string> { "javascript", "java", "ruby", "php", "python", "coffeescript" });
            Assert.Equal("java", kata.FindMostSimilar("heaven"));
            Assert.Equal("javascript", kata.FindMostSimilar("javascript"));
        }
    }
}