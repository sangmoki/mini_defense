using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    void Start()
    {
        
    }

    public void OnClickStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnClickStage1()
    {
        SceneManager.LoadScene("Stage1");

        PlayerPrefs.GetInt("StageNumber", 1);
        PlayerPrefs.Save();
    }
}
