using UnityEngine;

public class CustomDoubleLinkedList : DoubleLinkedList<Dialogo>
{
    public void AddDialog(string texto, Emotion emotion)
    {
        Dialogo nuevo = new Dialogo(texto, emotion);
        Node<Dialogo> newNode = new Node<Dialogo>(nuevo);

        if (Head == null) 
        {
            Head = Tail = newNode;
            Count++;
            return;
        }

        Tail.SetNext(newNode);
        newNode.SetPrev(Tail);
        Tail = newNode;
        Count++;
    }

    public void ShowConversation()
    {
        Debug.Log("Historial de diálogos:");
        ReadForward(Head);
    }

    public void ShowPrevious()
    {
        Debug.Log("Revisando hacia atrás:");
        ReadBackward(Tail);
    }
}