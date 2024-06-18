using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGenerator : MonoBehaviour
{
    public GameObject spritePrefab;
    public Sprite[] next;
    public float generateHight;


    private GameObject sprite;


    // Start is called before the first frame update
    void Start()
    {
        sprite = generate();
    }

    // Update is called once per frame
    void Update()
    {
        if (!sprite.GetComponent<SpriteController>().isControlled)
        {
            sprite = generate();
        }
    }

    GameObject generate()
    {
        Vector3 pos;
        GameObject spr = Instantiate(spritePrefab) as GameObject;
        spr.GetComponent<SpriteRenderer>().sprite = next[Random.Range(0,next.Length)];
        spr.AddComponent<PolygonCollider2D>();
        return spr;
    }
}
