using Infrastructure.Interfaces.Helpers;
namespace Infrastructure.Interfaces.Helpers.Tests;

public class UniqueIdGenerator_Tests
{
    [Fact]

   
    public void Generate_ShouldReturnGuidtoString_WhenSuccessful()
    { 
        // Act
        string result = UniqueIdGenerator.Generate();
        // Assert
        Assert.NotEmpty(result);
        Assert.True(Guid.TryParse(result, out _));
    }
}
