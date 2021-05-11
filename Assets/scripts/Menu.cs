using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    /*
    public void ButtonStart()
      {
          SceneManager.LoadScene(1);
      }

      public void ButtonCredits()
      {
          SceneManager.LoadScene(2);
      }
  */
    [SerializeField] private GameObject progressPanel;
    [SerializeField] private Slider progressBar;
    [SerializeField] private Text progressValue;

    public void Awake()
    {
        progressPanel.SetActive(false);
    }
    public void LoadLevel(int SceneIndex)
    {
        progressPanel.SetActive(true);
        StartCoroutine(LoadLevelAsync(SceneIndex));
    }
 
    private IEnumerator LoadLevelAsync(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress);
            progressBar.value = progress;
            progressValue.text = (progress * 100f).ToString("F0") + "%";
            //Debug.Log(progress);

            yield return null;
        }
    }
}
