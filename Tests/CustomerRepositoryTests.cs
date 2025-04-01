using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace IdCard.Hanel.Models.Tests
{
    public class CustomerRepositoryTests
    {
        private readonly Mock<AuthenCardDbContext> _mockContext;
        private readonly Mock<DbSet<Customer>> _mockCustomerSet;
        private readonly Mock<DbSet<InOutLog>> _mockInOutLogSet;
        private readonly CustomerRepository _repository;

        public CustomerRepositoryTests()
        {
            _mockContext = new Mock<AuthenCardDbContext>();
            _mockCustomerSet = new Mock<DbSet<Customer>>();
            _mockInOutLogSet = new Mock<DbSet<InOutLog>>();

            _mockContext.Setup(c => c.Set<Customer>()).Returns(_mockCustomerSet.Object);
            _mockContext.Setup(c => c.Set<InOutLog>()).Returns(_mockInOutLogSet.Object);

            _repository = new CustomerRepository(_mockContext.Object);
        }

        [Fact]
        public void GetCustomers_ShouldReturnCustomersWithinDateRange()
        {
            // Arrange
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = "1",
                    HoTen = "John Doe",
                    InOutLogs = new List<InOutLog>
                    {
                        new() { CheckInTime = new DateTime(2023, 1, 1) },
                        new() { CheckInTime = new DateTime(2023, 1, 5) }
                    }
                },
                new Customer
                {
                    Id = "2",
                    HoTen = "Jane Smith",
                    InOutLogs = new List<InOutLog>
                    {
                        new() { CheckInTime = new DateTime(2023, 2, 1) }
                    }
                }
            }.AsQueryable();

            _mockCustomerSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(customers.Provider);
            _mockCustomerSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(customers.Expression);
            _mockCustomerSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(customers.ElementType);
            _mockCustomerSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(customers.GetEnumerator());

            // Act
            var result = _repository.GetCustomers(new DateTime(2023, 1, 1), new DateTime(2023, 1, 31));

            // Assert
            Assert.NotNull(result);
            Assert.Single(result.Data);
            Assert.Equal("John Doe", result.Data[0].HoTen);
            Assert.Equal(2, result.Data[0].InOutLogCount);
        }
    }
}
