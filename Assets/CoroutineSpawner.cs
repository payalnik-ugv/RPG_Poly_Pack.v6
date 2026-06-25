using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CouroutineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private Coroutine _spawCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        _spawCoroutine = StartCoroutine(SpawnCourutine());
    }

    private void Update()
    {
        if (Keyboard.current != null && Keyboard.current.oKey.wasPressedThisFrame)
        {
            //StopAllCoroutines();
            StopCoroutine(_spawCoroutine);
        }
    }

    public IEnumerator SpawnCourutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}