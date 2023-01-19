using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja : MonoBehaviour
{

    [SerializeField]
    GameObject objectToSpawn;

    [SerializeField]
    float spawnTime;

    float aux_X;
    float aux_Y;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnCoroutine());

    }

    IEnumerator SpawnCoroutine()
    {

        while (isActiveAndEnabled)
        {
            aux_X = Random.Range(0.4f, -0.4f);
            aux_Y = Random.Range(1.8f, 2.3f);

            //transform.position = new Vector3(aux_X, aux_Y, 0);

            GameObject instance = Instantiate(objectToSpawn, transform.position, Quaternion.identity,transform);

            instance.transform.position = new Vector3(aux_X, aux_Y, 0);
            yield return new WaitForSeconds(Random.Range(0.3f,1.5f));
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
