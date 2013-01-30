namespace Rhino.Mocks.Tests.FieldsProblem
{
    using Xunit;

    public interface IToString
    {
    }

    public class FieldProblem_Markus
    {
        [Fact]
        public void StubbingToString()
        {
            var obj = MockRepository.GenerateStub<object>();
            obj.Stub(x => x.ToString()).Return("my-tostring");
            Assert.Equal("my-tostring", obj.ToString());
        }

        [Fact]
        public void StubbingToString2()
        {
            var obj = MockRepository.GenerateStub<MyObject>();
            obj.Stub(x => x.ToString()).Return("my-tostring");
            Assert.Equal("my-tostring", obj.ToString());
        }

        [Fact]
        public void StubbingToString3()
        {
            var obj = MockRepository.GenerateStub<IToString>();
            obj.Stub(x => x.ToString()).Return("my-tostring");
            Assert.Equal("my-tostring", obj.ToString());
        }
    }

    public class MyObject
    {
    }
}
