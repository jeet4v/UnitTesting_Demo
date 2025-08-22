using DataProject;
using Moq;

namespace UnitTestingBy_Moq_MSTest
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private Mock<IRepository> _mockRepository;
        private Mock<ILogger> _mockLogger;
        private DataService _dataService;

        [TestInitialize]
        public void MySetup()
        {
            // Mock<IRepository>() means we are not suppling the actual class implementation here,
            // instead we are just passing the mock implementation.
            _mockRepository = new Mock<IRepository>();
            _mockLogger = new Mock<ILogger>();
            _dataService = new DataService(_mockRepository.Object, _mockLogger.Object);
        }

        [TestMethod]
        public void ProcessData_ShouldReturnProcessed_WhenDataExists()
        {
            // Arrange
            int testId = 1;
            _mockRepository.Setup(r => r.GetData(testId)).Returns("SampleData");
            // we are telling to the moq framework (OR setting up the return value) that,
            // when _dataService.ProcessData() is calling the _repository.GetData(id),
            // then that method should return "SampleData" value, without any issue.

            // Act
            var result = _dataService.ProcessData(testId);

            // Assert
            Assert.AreEqual("Processed: SampleData", result);

            _mockLogger.Verify(l => l.Log("Data found: SampleData"), Times.Once);

        }

        [TestMethod]
        public void ProcessData_ShouldReturnNoData_WhenRepositoryReturnsNull()
        {
            // Arrange
            int testId = 2;
            _mockRepository.Setup(r => r.GetData(testId)).Returns((string)null);

            // Act
            var result = _dataService.ProcessData(testId);

            // Assert
            Assert.AreEqual("No Data", result);

            _mockLogger.Verify(l => l.Log("No data found for id 2"), Times.Once);
        }
    }
}
