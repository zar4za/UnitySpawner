using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    public void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, transform.position, transform.rotation);
    }
}
