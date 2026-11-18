using UnityEngine;

public class SPAWNER : MonoBehaviour
{
    public GameObject prefabToSpawn;   // повлечи го prefab-от тука во Inspector
    public float spawnRadius = 5f;     // големина на кругот
    public int numberOfItems = 1;      // колку предмети
    public float spawnDelay = 2f;      // колку секунди чека

    void Start()
    {
        Invoke("Spawn", spawnDelay);   // повикај Spawn по spawnDelay секунди
    }

    void Spawn()
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            Vector2 mesto = Random.insideUnitCircle.normalized * spawnRadius;
            Instantiate(prefabToSpawn, transform.position + (Vector3)mesto, Quaternion.identity);
        }
    }
}