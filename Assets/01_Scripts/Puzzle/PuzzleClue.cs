using UnityEngine;

public class PuzzleClue : MonoBehaviour, IInteractable
{
    [SerializeField] private string clueText = "Cuenta los objetos de la habitación en orden: 1, 2, 3, 4";

    public void Interact()
    {
        Debug.Log("Pista: " + clueText);
    }
}
