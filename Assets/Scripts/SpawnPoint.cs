using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    public void SpawnEnemy(Player player)
    {
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
        enemy.Init(player);
    }
}
