using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New enemy Wave", menuName = "Enemies/Wave config", order = 0)]
public class EnemyWavesConfig : ScriptableObject
{
    [System.Serializable]
    public class EachEnemyconfig
    {
        public EnemyController enemyPrefab;
        public Vector3 spawnReferencePosition;
        public bool useSpecificXPosition;
        public EnemyConfig configEnemy;
        
    }
    public Quaternion spawnRotation;
    public List<EachEnemyconfig> waves;

    public float cadence;
    public bool isHorizontal;
}
