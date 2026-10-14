using UnityEngine;

public class OldDoorController : MonoBehaviour
{
    [SerializeField] private bool isOpen;
    [SerializeField] private Animator animator;

    public void Open()
    {
        if (isOpen)
            return;

        isOpen = true;
        if (animator != null)
            animator.SetTrigger("Open");

        Debug.Log("Puerta abierta (controlador antiguo).");
    }
}
