using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // O construtor recebe a referência e o texto bruto
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Divide o texto por espaços e cria um objeto Word para cada parte
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Esconde uma quantidade específica de palavras aleatórias
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Filtra apenas as palavras que ainda não estão escondidas
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // Se não houver palavras visíveis suficientes, esconde o que sobrar
        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove da lista temporária para não repetir
        }
    }

    // Monta a string completa com a referência e o texto (alguns com underscores)
    public string GetDisplayText()
    {
        string scriptureText = "";
        
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    // Verifica se todas as palavras já foram escondidas
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
