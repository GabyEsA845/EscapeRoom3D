using UnityEngine;

public class OldDoorController : MonoBehaviour
{
    [SerializeField] private bool isOpen;

    public void Open()
    {
        isOpen = true;
        Debug.Log("Puerta abierta (controlador antiguo).");
    }
}
