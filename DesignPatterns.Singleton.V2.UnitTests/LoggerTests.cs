using System.Collections.Concurrent;

namespace DesignPatterns.Singleton.V2.UnitTests
{

    public class LoggerTests
    {
        [Fact]
        public void GetInstance_MultipleParallelRequests_ReturnsSameInstance()
        {
            //Arrange
            ConcurrentBag<Logger> loggerBag = new();
            Logger firstInstance = Logger.GetInstance("Test");
            ParallelOptions options = new()
            {
                MaxDegreeOfParallelism = 10
            };


            //Act
            Parallel.For(0, 100, options =>
            {
                loggerBag.Add(Logger.GetInstance("Test"));
            });

            //Assert
            foreach (var logger in loggerBag)
            {
                Assert.Same(firstInstance, logger);
            }
        }
    }
}