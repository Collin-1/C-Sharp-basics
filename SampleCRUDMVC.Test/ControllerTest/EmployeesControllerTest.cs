using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.AspNetCore.Hosting;
using SampleCRUDMVC.Data;
using SampleCRUDMVC.Models;
using Xunit;






namespace SampleCRUDMVC.Test.ControllerTest
{
    public class EmployeesControllerTest : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly Mock<IWebHostEnvironment> _mockEnv;
        private readonly EmployeesController _controller;

        public EmployeesControllerTest()
        {
            // In-memory database for testing
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            _context = new ApplicationDbContext(options);
            _mockEnv = new Mock<IWebHostEnvironment>();

            // Seeding test data
            _context.Employees.Add(new Employee
            {
                Id = 1,
                FirstName = "John",
                MiddleName = "Thabang",
                LastName = "Doe",
                PhoneNumber = "123456789",
                EmailAddress = "john.doe@gmail.com",
                Gender = "Male",
                Country = "South Africa",
                yearsAtCompany = "5", 
                JobTiltle = "Software Engineer",
                Seniority = "Mid",
                Department = "IT"
            });
            _context.Employees.Add(new Employee
            {
                Id = 2,
                FirstName = "Jane",
                MiddleName = "Mel",
                LastName = "Smith",
                PhoneNumber = "063456835",
                EmailAddress = "jane.smith@gmail.com",
                Gender = "Female",
                Country = "South Africa",
                yearsAtCompany = "7", 
                JobTiltle = "HR Manager",
                Seniority = "Senior",
                Department = "HR"
            });
            _context.SaveChanges();

            _controller = new EmployeesController(_context, _mockEnv.Object);
        }

        [Fact]
        public async Task Index_ReturnsViewResult_WithListOfEmployees()
        {
            var result = await _controller.Index(null) as ViewResult;
            var model = result.Model as List<Employee>;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.NotNull(model);
            Assert.Equal(2, model.Count);
        }

        [Fact]
        public async Task Details_ReturnsNotFound_WhenIdIsNull()
        {
            var result = await _controller.Details(null);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Details_ReturnsViewResult_WithEmployee()
        {
            var result = await _controller.Details(1) as ViewResult;
            var model = result.Model as Employee;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.NotNull(model);
            Assert.Equal(1, model.Id);
        }

        [Fact]
        public async Task DeleteConfirmed_RemovesEmployee()
        {
            await _controller.DeleteConfirmed(1);

            var employee = await _context.Employees.FindAsync(1);
            Assert.Null(employee);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}