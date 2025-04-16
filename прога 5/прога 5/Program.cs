using System;
using System.Text;
using System.Text.RegularExpressions;

// Інтерфейси
interface IAlphabetDetectable
{
    string DetectAlphabet();
}

interface IOriginDetectable
{
    string GetOrigin();
}

// Абстрактний клас
abstract class Text
{
    protected readonly string content;

    public Text(string content)
    {
        this.content = content;
    }

    public abstract int GetCharacterCount();
    public abstract void DisplayInfo();
}

// Клас "Речення"
class Sentence : Text, IAlphabetDetectable
{
    public Sentence(string content) : base(content) { }

    public override int GetCharacterCount() => content.Length;

    