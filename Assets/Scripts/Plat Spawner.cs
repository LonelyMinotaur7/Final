using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatSpawner : MonoBehaviour
{

    float time = 0.5f;
    float maxtime = 0.4f;

    int random;
    int random2;

    public GameObject Platform;
    public Transform Spawner;
    public GameObject Diamond;
    public Transform DiamondSpawn;

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;

        if (time <= 0)
        {
            Debug.Log("Time");
            time = maxtime;

            GameObject Currentobj = Instantiate(Platform, Spawner.position, Quaternion.identity);

            random = Random.Range(1, 3);
            random2 = Random.Range(1, 3);

            Debug.Log(random);

            if (random == 1)
            {
                Spawner.transform.position += new Vector3(2.5f, 0, 0);
            }
            else
            {
                Spawner.transform.position += new Vector3(0, 0, 2.5f);
            }

            if (random2 == 1)
            {
                GameObject Currentobj2 = Instantiate(Diamond, DiamondSpawn.position, Quaternion.identity);
                Destroy(Currentobj2, 10);
            }
            else
            {
                
            }

        }
    }
}
 