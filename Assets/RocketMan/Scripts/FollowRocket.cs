using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRocket : MonoBehaviour {

    [SerializeField]
    Transform target;

    float initY;

	// Use this for initialization
	void Start () {
        initY = transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(target.position.x, target.position.y + initY, transform.position.z);
	}
}
