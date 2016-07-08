namespace Core.Tests
{
    using Xunit;

    public class Class1
    {
        public Class1()
        {
            // var foo = Common.IsDBNull(89);
            var foo = Number.IsNumber(45);
        }

        [Fact]
        public void IsNumberWorking()
        {
            var foo = Number.IsNumber("Hello World");


            Assert.Equal(true, Number.IsNumber(45));
            Assert.Equal(true, Number.IsNumber(45.89));
            Assert.Equal(true, Number.IsNumber(00.89));
            Assert.Equal(true, Number.IsNumber(-90));
            Assert.Equal(false, Number.IsNumber("Hello World"));
        }
    }
}
