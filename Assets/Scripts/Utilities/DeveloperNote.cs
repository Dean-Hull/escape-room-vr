using UnityEngine;

public class DeveloperNote : MonoBehaviour
{
    [TextArea(4, 10)]
    [SerializeField] private string description;

    private void Awake() 
    {
        Destroy(this);
    }
}