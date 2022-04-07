using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpwanScript : MonoBehaviour
{
    public float spwanRange;
    // Start is called before the first frame update
    void Start()
    {
       transform.position = new Vector2(Random.Range(spwanRange, spwanRange), spwanRange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
