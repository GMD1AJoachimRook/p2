using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skulls : MonoBehaviour {
    public List<GameObject> objects = new List<GameObject>();
    public List<GameObject> clones = new List<GameObject>();
    public int toSpawn;
    public int p;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < 50; i++)
        {
            toSpawn = Random.Range(0, objects.Count);
            clones.Add(
            Instantiate(objects[toSpawn], new Vector3(Random.Range(0, 75), Random.Range(0, 75), Random.Range(0, 75)), Quaternion.identity));

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            for (int i = 0; i < clones.Count; i++)
            {
                if (clones[i] != null && clones[i].tag == "Skoel")
                {
                    Destroy(clones[i]);
                }
            }
        }
    }
}
