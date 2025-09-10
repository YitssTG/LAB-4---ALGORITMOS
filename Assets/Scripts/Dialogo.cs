using UnityEngine;

public enum Emotion
{
    None,
    Happy,
    Angry,
    Scared,
}

public class Dialogo
{
    public string texto;
    public Emotion emotion;

    public Dialogo(string texto, Emotion emotion)
    {
        this.texto = texto;
        this.emotion = emotion;
    }

    public override string ToString()
    {
        return texto + " [" + emotion.ToString() + "]";
    }
}