using UnityEngine;

public class PuzzleClue : MonoBehaviour, IInteractable
{
    [SerializeField] private string clueText = "Las cifras van de menor a mayor: 1, 2, 3, 4";

    public void Interact()
    {
        Debug.Log("Pista: " + clueText);
    }
}
