namespace TestApp.Tests;

public class ProgramTests
{
    [Fact]
    public void TestHelloWorld()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(TestApp));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello World!");
    }
}