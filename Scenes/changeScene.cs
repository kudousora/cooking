using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void ButtonClicked()
    {  
        Invoke("change_button2",2f);
    }
    public void ButtonClicked2()
    {
        Invoke("change_button3", 2f);
    }
    public void ButtonClicked3()
    {
        Invoke("change_button4", 2f);
    }
    public void ButtonClicked4()
    {
        Invoke("change_button5", 2f);
    }


    public void change_button()
    {
        SceneManager.LoadScene("Question1");
    }
    public void change_button3()
    {
        SceneManager.LoadScene("Question2");
    }
    public void change_button4()
    {
        SceneManager.LoadScene("Question3");
    }
    public void change_button5()
    {
        SceneManager.LoadScene("Question4");
    }
    public void change_button1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void change_button2()
    {
        SceneManager.LoadScene("result");
    }
}