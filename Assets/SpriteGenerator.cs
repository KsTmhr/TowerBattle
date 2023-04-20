using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGenerator : MonoBehaviour
{
    public GameObject spritePrefab;
    public Sprite[] next;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject sprite = Instantiate(spritePrefab) as GameObject;
            sprite.GetComponent<SpriteRenderer>().sprite = next[Random.Range(0,6)];
            sprite.AddComponent<PolygonCollider2D>();
        }
    }
}
