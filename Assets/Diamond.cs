using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField] private GameObject diamondVisual; // Reference to the diamond visual GameObject

    // Update is called once per frame
    void Update()
    {
        diamondVisual.transform.Rotate(Vector3.up * 150f * Time.deltaTime); // Rotate the diamond visual around the Y-axis   
    }
}
