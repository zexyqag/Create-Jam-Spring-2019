using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

    public float time;
    public GameObject powerUp;

	// Use this for initialization
	void Start () {
        time = Random.Range(5, 10);
	}
	
	// Update is called once per frame
	void Update () {
       Vector2 position = new Vector2(Random.Range(-8.26f, 8.26f), Random.Range(9, 10));

        time -= Time.deltaTime;

        if(time < 0){
            time = Random.Range(5, 10);
            GameObject newGameObject = Instantiate(powerUp);
            newGameObject.transform.position = position;

        }
	}
}
