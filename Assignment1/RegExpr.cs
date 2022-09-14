namespace Assignment1;

using System.Text.RegularExpressions;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines) 
    {
        var pattern = @"([a-zA-Z0-9]+)";

        foreach (var v in lines) {
            var matches = Regex.Matches(v, pattern);
            foreach (var m in matches) 
            {
                if (m != null) 
                {
                    yield return m.ToString();
                }
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
    {
        var pattern = @"(?<width>[0-9]+)x(?<height>[0-9]+)";

        foreach (var v in resolutions) 
        {
            var matches = Regex.Matches(v, pattern);

            foreach (Match _v in matches)
            {
                int width;
                int height;
                int.TryParse(_v.Groups["width"].Value, out width);
                int.TryParse(_v.Groups["height"].Value, out height);

                yield return (width, height);
            }
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag)
    {
        string _tag = "<" + tag + ">(.*?)</" + tag + ">";
        var pattern = @_tag;

        var matches = Regex.Matches(html, pattern);
        foreach (Match v in matches)
        {
            yield return v.Groups[1].Value.ToString();
        }
    }

    public static IEnumerable<string> Urls(string html)
    {
        var pattern = @".?href=""([\d\S]*?)""(.?title=""([\d\W\w]*?)"")?";
    
        var matches = Regex.Matches(html, pattern);
        foreach (Match v in matches)
        {
            string _result = "" + v.Groups[1].Value.ToString() + ", " + v.Groups[3].Value.ToString();

            yield return _result;
        }
    }
}