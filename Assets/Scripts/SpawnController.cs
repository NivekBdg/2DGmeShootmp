using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    [SerializeField] private List<EnemyWavesConfig> wavesConfig;
    //[SerializeField] private Quaternion spawnRotation;
    [SerializeField] private float initialWaitTime;
    [SerializeField] private float cadenceBetweenWaves;

    private void Start()
    {
        StartCoroutine(EnemySpawnerCoroutine());
    }


    private IEnumerator EnemySpawnerCoroutine()
    {
        yield return new WaitForSeconds(initialWaitTime);

        foreach(var wave in wavesConfig)
        {
            foreach (var enemy in wave.waves)
            {
                Vector3 enemyPosition;
                if (enemy.useSpecificXPosition)
                {
                    enemyPosition = enemy.spawnReferencePosition;
                }
                else
                {
                    if(wave.isHorizontal)
                    {
                        enemyPosition = new Vector3(enemy.spawnReferencePosition.x,
                            Random.Range(-enemy.spawnReferencePosition.y, enemy.spawnReferencePosition.y), enemy.spawnReferencePosition.z);
                    }
                    else
                    {
                        enemyPosition = new Vector3(Random.Range(-enemy.spawnReferencePosition.x, enemy.spawnReferencePosition.x),
                            enemy.spawnReferencePosition.y, enemy.spawnReferencePosition.z);
                    }
                }
                SpawnEnemy(enemy.enemyPrefab, enemy.configEnemy, enemyPosition, wave.spawnRotation);
                yield return new WaitForSeconds(wave.cadence);
            }

            yield return new WaitForSeconds(cadenceBetweenWaves);
        }
        

    }

    public void SpawnEnemy(EnemyController enemyPrefab, EnemyConfig config, Vector3 enemyPosition, Quaternion rotation)
    {
        var enemyInstance = Instantiate(enemyPrefab, enemyPosition, rotation);
        enemyInstance.config = config;
    }
}
