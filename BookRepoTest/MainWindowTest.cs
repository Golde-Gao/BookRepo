

using BookRepo.ViewModel;

namespace BookRepoTest
{
    public class MainWindowTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var mm = new MainWindowModel();
            mm.Print();
        }
    }
}