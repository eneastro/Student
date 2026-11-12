using System.Collections;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Gem gemPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float respawnDelay;

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += OnDestroyed;
    }

    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= OnDestroyed;
    }
    
    void OnDestroyed(GameItem gameItem)
    {
        if (gameItem == GameItem.Gem)
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawnDelay);
        Instantiate(gemPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
