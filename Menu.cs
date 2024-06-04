using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestScore;

    private void Start()
    {
        bestScore.text = PlayerPrefs.GetInt("SaveBestScoreDoodleTest").ToString();
    }

    public void ShowGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowEarn()
    {
        SceneManager.LoadScene("Earn");
    }

    public void ShowBoost()
    {
        SceneManager.LoadScene("Boost");
    }

    public void ShowLeaders()
    {
        SceneManager.LoadScene("Leaders");
    }




}
