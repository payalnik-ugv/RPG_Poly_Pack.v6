using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    [SerializeField] private Resource resource;
    [SerializeField] private GameObject diamondVisual;

    // Update is called once per frame
    void Update()
    {
        diamondVisual.transform.Rotate(0, (3 + Time.deltaTime), 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter");
        //resource = Resource.Diamond;
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Inventory inventory = other.GetComponent<Inventory>();
            inventory.AddResource(resource);
        }
    }
}