using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public GameObject Player;
    public float x, y, z;
    void Update()
    {
        x = Player.transform.position.x+1;
        y = Player.transform.position.y;
        z = Player.transform.position.z;
    }
   
    void OnTriggerEnter(Collider other)
    {
       PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }

     void Start()
    {
        x=PlayerPrefs.GetFloat("x");
        y=PlayerPrefs.GetFloat("y");
        z=PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x, y, z);
        Player.transform.position = LoadPosition;
    }
}
