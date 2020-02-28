namespace GitHookTestConsole
{
    public interface IText
    {
        string Concat(string text1, string text2);
    }

    public class Text : IText
    {
        public string Concat(string text1, string text2)
        {
            return string.Concat(text1, text2);
        }
    }
}