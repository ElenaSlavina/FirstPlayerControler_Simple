using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public abstract void OnInteract();
    public abstract void OnFocus();
    public abstract void OnLoseFocus();

    public virtual void Awake()
    {
        gameObject.layer = 6;
    }
}
