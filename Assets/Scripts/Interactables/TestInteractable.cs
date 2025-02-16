using UnityEngine;

public class TestInteractable : Interactable
{
    public override void OnFocus()
    {
        Debug.Log($"OnFocus at {gameObject.name}");
    }

    public override void OnInteract()
    {
        Debug.Log($"OnInteract at {gameObject.name}");
    }

    public override void OnLoseFocus()
    {
        Debug.Log($"OnLoseFocus at {gameObject.name}");
    }
}
