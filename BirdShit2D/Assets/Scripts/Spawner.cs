using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject npc;

    public float maxHiz;
    public float minHiz;
    public float suankiHiz;
    public float SpawnRate=2f;
    public float nextSpawn=0f;
    
    
    
    void Awake()
    {
        suankiHiz = minHiz;
        spawnla();
    }

    public void spawnla()
    {
        GameObject Spawnlayan =  Instantiate(npc, transform.position, transform.rotation);
        Spawnlayan.GetComponent<NPCHareket>().spawner = this;
        StartCoroutine(bekle());
        
        
    }
    IEnumerator bekle()
    {
        yield return new WaitForSeconds(2.5f);
        spawnla();
    }

    void Update()
    {
        
    }
}
