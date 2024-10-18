using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCrawlerCamera : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    
    void Start()
    {
        offset = transform.position - target.transform.position;
    }
    
    void LateUpdate()
    {
        Vector3 newPos = target.transform.position + offset;
        transform.position = newPos;
    }
}
