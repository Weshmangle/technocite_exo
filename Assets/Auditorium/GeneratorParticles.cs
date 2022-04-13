using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorParticles : MonoBehaviour
{
    [SerializeField] private float spawnDelay = 1.0f;
    [SerializeField] private GameObject prefabParticles;
    [SerializeField] private float radiusSpawn;
    [SerializeField] private float lifeTimeParticle = 5;

    void Start()
    {
        StartCoroutine(SpawnParticles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnParticles()
    {
        yield return new WaitForSeconds(1);
        
        var pos = Random.insideUnitCircle;

        StartCoroutine(SpawnParticles());

        var particle = Instantiate(prefabParticles, new Vector3(pos.x * radiusSpawn, 0, pos.y * radiusSpawn), Quaternion.identity);
        particle.GetComponent<TrailRenderer>().autodestruct = true;
        Destroy(particle, lifeTimeParticle);
    }
}
