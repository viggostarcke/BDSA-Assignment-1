namespace Assignment1.Tests;

using System.Text;
using Xunit;
using FluentAssertions;

public class RegExprTests
{
    
    [Fact]
    public void SplitLine_returns_1_string_from_1_arrays()
    {
        //arrange
        string[] testArray1 = { "to!", "be# or not", "#€@to be" };

        //act
        var result = RegExpr.SplitLine(testArray1);

        //assert
        result.Should().BeEquivalentTo(new [] { "to", "be", "or", "not", "to", "be" });
    }

    [Fact]
    public void Resolution_returns_tuples_from_stream() 
    {
        //arrange
        string[] testArray = { "1920x1080", "1024x768, 800x600" };

        //act
        var result = RegExpr.Resolution(testArray);

        //assert
        result.Should().BeEquivalentTo(new [] { (1920, 1080), (1024, 768), (800, 600) });
    }

    [Fact]
    public void InnerText_returns_inner_text_of_HTML_tags()
    {
        //arrange
        string html = "<h2>Flower</h2>";
        string tag = "h2";

        //act
        var result = RegExpr.InnerText(html, tag);

        //assert
        result.Should().BeEquivalentTo("Flower");
    }

}