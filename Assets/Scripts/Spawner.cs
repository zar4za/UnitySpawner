using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private bool _canSpawn = true;
    [SerializeField] private float _spawnDelaySeconds = 2f;
    [SerializeField] private Player _enemyTarget;

    private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (_canSpawn)
        {
            int spawnPointIndex = Random.Range(0, _spawnPoints.Length);
            _spawnPoints[spawnPointIndex].SpawnEnemy(_enemyTarget);
            yield return new WaitForSeconds(_spawnDelaySeconds);
        }
    }
}
