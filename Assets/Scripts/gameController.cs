using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{

    public GameObject[] powerUp;
    private float[] timers = new float[3];
    public float[] intialTimes = new float[3];
    public GameObject player;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 2; i++){
            timers[i] = intialTimes[i];
        }
        for (int i = 0; i < 2; i++){
            GameObject Player = Instantiate(player);
            Player.gameObject.GetComponent<playerScript>().PID = i + 1;
        }
    }
	
	// Update is called once per frame
	void Update () {
       Vector2 position = new Vector2(Random.Range(-8.26f, 8.26f), Random.Range(9, 10));

        for (int i = 0; i < timers.Length; i++){
            timers[i] -= Time.deltaTime;

            if (timers[i] < 0)
            {
                timers[i] = intialTimes[i];
                GameObject newGameObject = Instantiate(powerUp[i]);
                newGameObject.transform.position = position;

            }
        }


	}
}


