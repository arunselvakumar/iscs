namespace Core.Tests
{
    using Xunit;

    public class Class1
    {
        public Class1()
        {
            // var foo = Common.IsDBNull(89);
            var foo = Numbers.IsNumber(45);
        }

        [Fact]
        public void IsNumberWorking()
        {
            var foo = Numbers.IsNumber("Hello World");


            Assert.Equal(true, Numbers.IsNumber(45));
            Assert.Equal(true, Numbers.IsNumber(45.89));
            Assert.Equal(true, Numbers.IsNumber(00.89));
            Assert.Equal(true, Numbers.IsNumber(-90));
            Assert.Equal(false, Numbers.IsNumber("Hello World"));
        }
    }
}
