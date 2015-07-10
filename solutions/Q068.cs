public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        List<string> answer = new List<string>();
        int currentLength = -1;
        List<string> currentLine = new List<string>();
        foreach (var word in words)
        {
            currentLength = currentLength + 1 + word.Length;
            if (currentLength > maxWidth)
            {
                PrintNewLine(currentLine, maxWidth, answer);
                currentLength = word.Length;
            }
            currentLine.Add(word);
        }
        if (currentLine.Count > 0)
        {
            answer.Add(String.Join(" ", currentLine.ToArray()));
        }

        return answer.Select(a => a.PadRight(maxWidth)).ToList();
    }

    private void PrintNewLine(List<String> words, int length, List<String> answer)
    {
        int spaceCount = words.Count - 1;
        int totalSpace = length - words.Sum(w => w.Length);
        StringBuilder sb = new StringBuilder();
        sb.Append(words[0]);
        for (int i = 1; i < words.Count; i++)
        {
            int spaceLength = totalSpace / spaceCount;
            if (i <= totalSpace % spaceCount)
            {
                spaceLength++;
            }
            sb.Append(new String(' ', spaceLength));
            sb.Append(words[i]);
        }
        answer.Add(sb.ToString());
        words.Clear();
    }
}
