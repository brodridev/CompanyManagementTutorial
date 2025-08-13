using CompanyManagement.Application.DTOs;
using CompanyManagement.Application.Services;
using CompanyManagement.Domain.Interfaces;
using Moq;
using Xunit;

namespace CompanyManagement.Tests.Unit.Services;

public class CompanyServiceTests
{
    [Fact]
    public async Task CreateAsync_ShouldReturnNewId()
    {
        // Arrange
        var repoMock = new Mock<ICompanyRepository>();
        var uowMock = new Mock<IUnitOfWork>();

        var service = new CompanyService(repoMock.Object, uowMock.Object);
        var dto = new CreateCompanyDto("Company 1", DateTime.Now);

        // Act
        var result = await service.CreateAsync(dto);

        // Assert
        Assert.NotEqual(Guid.Empty, result);
    }
}