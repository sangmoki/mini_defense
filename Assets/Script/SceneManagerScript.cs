using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    GameObject BlackPanel, GameOverPanel;

    void Start()
    {
        BlackPanel = GameObject.Find("BlackPanel");
        GameOverPanel = GameObject.Find("GameOverPanel");
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

    public void OnClickGameOverPanelOff()
    {
        BlackPanel.SetActive(false);
        GameOverPanel.SetActive(false);

        SceneManager.LoadScene("UserScene");
    }
}
