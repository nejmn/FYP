using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishTrigger : MonoBehaviour
{
    public AudioSource end;
    public Animator screen;
    private void OnTriggerEnter(Collider other)
    {
        end.Play();
        screen.gameObject.SetActive(true);
        screen.Play("JumpscareAlpha");
        StartCoroutine(End());
    }

    IEnumerator End()
    {
      
        yield return new WaitForSeconds(5.5f);
        screen.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(0);
        
    }
}
