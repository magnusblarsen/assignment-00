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


    [Fact]
    public void DivideBy4True()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(TestApp));
        bool result2004 = Program.isLeapYear(2004);
        bool result1512 = Program.isLeapYear(1512);
        bool result44 = Program.isLeapYear(44);
        

        // Assert
        result2004.Should().BeTrue();
        result1512.Should().BeTrue();
        result44.Should().BeTrue();
    }


    [Fact]
    public void DivideBy4False()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(TestApp));
        bool result2006 = Program.isLeapYear(2006);
        bool result1511 = Program.isLeapYear(1512);
        bool result47 = Program.isLeapYear(47);
        

        // Assert
        result2006.Should().BeFalse();
        result1511.Should().BeFalse();
        result47.Should().BeFalse();
    }
    
}