class Word
{
    public string FromLanguage { get; set; }
    public string ToLanguage { get; set; }
    public string FromWord { get; set; }
    public string ToWord { get; set; }

    public Word(string fromlanguage, string tolanguage, string fromword, string toword)
    {
        FromLanguage = fromlanguage;
        ToLanguage = tolanguage;
        FromWord = fromword;
        ToWord = toword;
    }
}