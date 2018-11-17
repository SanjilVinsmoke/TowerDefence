﻿
using UnityEngine;

public class Enemy : MonoBehaviour {


    public float speed = 10f;
    private Transform target;
    
    private int  wavepointIndex=0;


	void Start () {
        target = Waypoints.points[0];

	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime,Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }

        void GetNextWaypoint()
        {
            
            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];
        }
    }
}