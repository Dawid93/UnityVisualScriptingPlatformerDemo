using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private int sampleVar;
    
    public void DoSomething(string message)
    {
        Debug.Log($"I did {message}");
    }
}
