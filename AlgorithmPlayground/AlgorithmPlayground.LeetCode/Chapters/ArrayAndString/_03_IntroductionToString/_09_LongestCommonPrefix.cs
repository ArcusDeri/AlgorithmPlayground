using System.Text;

namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString;

public class _09_LongestCommonPrefix
{
    public static string LongestCommonPrefix(string[] strs)
    {
        var sb = new StringBuilder();
        var template = strs[0];

        for (var i = 0; i < template.Length; i++)
        {
            for (var j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != template[i])
                {
                    return sb.ToString();  
                }
            }

            sb.Append(template[i]);
        }
        
        return sb.ToString();
    }
}
