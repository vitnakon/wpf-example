using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVVM_Example;
using MVVM_Example.ViewModel;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private ApplicationViewModel mainModel;

        [TestInitialize]
        public void Initialization()
        {
            mainModel = new ApplicationViewModel(new DefaultDialogService(), new JsonFileService());
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(mainModel.Phones.Count,3);
        }
    }
}
