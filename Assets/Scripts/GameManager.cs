using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public CustomDoubleLinkedList dialogos = new();
    private Node<Dialogo> current;

    [Header("UI Elements")]
    public TextMeshProUGUI dialogText;
    public Button nextButton;
    public Button prevButton;

    void Start()
    {
        dialogos.AddDialog("Hola, ¿cómo estás?", Emotion.Happy);
        dialogos.AddDialog("Bien, un poco cansado.", Emotion.None);
        dialogos.AddDialog("¿Estuviste estudiando hasta tarde otra vez?", Emotion.Angry);
        dialogos.AddDialog("Sí, perdí la noción del tiempo…", Emotion.None);
        dialogos.AddDialog("Tienes que cuidarte, no puedes seguir así.", Emotion.Scared);
        dialogos.AddDialog("Lo sé, gracias por preocuparte.", Emotion.Happy);
        dialogos.AddDialog("Bueno… ¿quieres que salgamos a tomar aire?", Emotion.Happy);
        dialogos.AddDialog("Me encantaría, hace tiempo que no salimos juntos.", Emotion.Happy);
        dialogos.AddDialog("Perfecto, vamos antes de que oscurezca.", Emotion.None);
        dialogos.AddDialog("Oye… gracias por estar siempre conmigo.", Emotion.Happy);
        dialogos.AddDialog("Siempre lo estaré, no lo dudes nunca.", Emotion.Happy);

        current = dialogos.Head;
        UpdateDialog();

        nextButton.onClick.AddListener(ShowNext);
        prevButton.onClick.AddListener(ShowPrev);
    }

    void UpdateDialog()
    {
        if (current != null)
        {
            dialogText.text = current.Value.ToString();
        }
        else
        {
            dialogText.text = "Fin de la conversación.";
        }
    }

    public void ShowNext()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            UpdateDialog();
        }
    }

    public void ShowPrev()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            UpdateDialog();
        }
    }
}