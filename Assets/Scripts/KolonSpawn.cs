using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KolonSpawn : MonoBehaviour
{

    public Birdy BirdScript;

    public GameObject Borular;

    public float height;

    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isDead)
        {
            GameObject obje = Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            Destroy(obje, 10);
            yield return new WaitForSeconds(time);
        }
    }
}
