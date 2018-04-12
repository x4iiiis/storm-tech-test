using NUnit.Framework;

namespace Storm.InterviewTest.Hearthstone.Tests.Specification
{
    public abstract class ContextSpecification : TestBase
    {
        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            Context_BeforeAllSpecs();
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            CleanUpContext_AfterAllSpecs();
        }

        public override void SetUp()
        {
            SharedContext();
            Context();
            Because();
        }

        public override void TearDown()
        {
            Because_After();
            CleanUpContext();
        }

        protected void Pending()
        {
            Assert.Ignore();
        }

        protected void Pending(string message)
        {
            Assert.Ignore(message);
        }

        protected virtual void SharedContext() { System.Diagnostics.Debug.WriteLine("WARNING: Shared context setup not implemented"); }
        protected virtual void Context() { }
        protected virtual void CleanUpContext() { }
        protected virtual void Context_BeforeAllSpecs() { }
        protected virtual void CleanUpContext_AfterAllSpecs() { }
        protected virtual void Because() { }
        protected virtual void Because_After() { }
    }
}