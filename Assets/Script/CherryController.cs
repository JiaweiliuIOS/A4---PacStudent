using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
enum CherryStatus
{
    appear,
    disappear

};
enum CherryWalkingStatus
{
    walking,
    stopped
}
public class CherryController : MonoBehaviour
{

    private Vector2Int currentWalkingDirection = Vector2Int.left;

    private Vector2Int homeNode = new Vector2Int(26, -27);
   
    private CherryStatus cherryState = CherryStatus.appear;
    private CherryWalkingStatus walkingState = CherryWalkingStatus.stopped;
    public float time = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        walkingState = CherryWalkingStatus.walking;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cherryState == CherryStatus.disappear)
            return;
        if (walkingState == CherryWalkingStatus.walking)
        {
            
            return;
        }

        
        walkingState = CherryWalkingStatus.walking;
    }

    void Spawn()
    { 
        gameObject.SetActive(true);
        transform.localPosition = new Vector3(homeNode.x, homeNode.y, transform.localPosition.z);
        walkingState = CherryWalkingStatus.walking;
        cherryState = CherryStatus.appear;
        currentWalkingDirection = Vector2Int.left;

    }

    void unSpawn()
    {
        gameObject.SetActive(false);
        walkingState = CherryWalkingStatus.stopped;
        cherryState = CherryStatus.disappear;
        int reProduceTime = UnityEngine.Random.Range(10,25);
        Invoke("Spawn", reProduceTime);
    }
}