using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OntriggerDestroy : MonoBehaviour
{
    
    public GameObject platform;
    public GameObject DeadScreen;
    public GameObject WinScreen;
    private void Start()
    {
            DeadScreen.SetActive(false);
        WinScreen.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            if(gameObject.CompareTag("Key"))
            {
            Destroy(platform);
            GameVariables.KeyCount++;
                WinScreen.SetActive(true);
              //play animatiom
                SceneManager.LoadScene(1);
            
            }
            if(gameObject.name == "DeadTrigger")
            {
              
                Destroy(platform);
                DeadScreen.SetActive(true);
                StartCoroutine(DeadTrigger());
            }
            else
            {
                Destroy(platform);
            }

        }
    }
    IEnumerator DeadTrigger()
    {
        
        DeadScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
   

}
