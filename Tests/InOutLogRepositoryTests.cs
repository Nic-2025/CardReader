using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using IdCard.Hanel.Models;

namespace ReadIdCard.Tests
{
    public class InOutLogRepositoryTests
    {
        [Fact]
        public void GetList_ShouldReturnFilteredAndPaginatedResults()
        {
            // Arrange
            var mockDbSet = new Mock<DbSet<InOutLog>>();
            var mockContext = new Mock<AuthenCardDbContext>();
            mockContext.Setup(c => c.InOutLogs).Returns(mockDbSet.Object);

            var data = new List<InOutLog>
            {
                new InOutLog { Id = "1", CustomerId = "123", CheckInTime = new DateTime(2023, 1, 1) },
                new InOutLog { Id = "2", CustomerId = "123", CheckInTime= new DateTime(2023, 1, 2) },
                new InOutLog { Id = "3", CustomerId = "456", CheckInTime = new DateTime(2023, 1, 3) }
            }.AsQueryable();

            mockDbSet.As<IQueryable<InOutLog>>().Setup(m => m.Provider).Returns(data.Provider);
            mockDbSet.As<IQueryable<InOutLog>>().Setup(m => m.Expression).Returns(data.Expression);
            mockDbSet.As<IQueryable<InOutLog>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockDbSet.As<IQueryable<InOutLog>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var repository = new InOutLogRepository(mockContext.Object);

            // Act
            var result = repository.GetList(new DateTime(2023, 1, 1), new DateTime(2023, 1, 2), 0, 10, "123");

            // Assert
            Assert.Equal(2, result.Total);
            Assert.Equal(2, result.Data.Count);
            Assert.All(result.Data, log => Assert.Equal("123", log.CustomerId));
        }
    }
}
