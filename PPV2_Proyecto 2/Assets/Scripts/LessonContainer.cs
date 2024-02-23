using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LessonContainer : MonoBehaviour
{
    [Header ("GameObject Configuration")]
    public int Lection = 0;
    public int CurrentLession;
    public int TotalLessions = 0;
    public bool AreAllLessionsComplete = false;

    [Header("UI Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonStage;

    [Header("External GameObject Configuration")]
    public GameObject lessonContainer;

    void Start()
    {
        if (lessonContainer != null)
        {
            OnUpdateUI();
        }

        else
        {
            Debug.LogWarning("GameObject nulo, revisa las variables de tipo GameObject lesson container");
        }
    }

    public void OnUpdateUI()
    {
        if (StageTitle != null || LessonStage != null) 
        { 
            StageTitle.text = "Leccion " + Lection;
            LessonStage.text = "Leccion " + CurrentLession + " de " + TotalLessions;
        }

        else
        {
            Debug.LogWarning("GameObject nulo, revisa las variables del tipo TMP_Text");
        }
    }

    public void EnableWindow () 
    {
        OnUpdateUI();

        if(lessonContainer.activeSelf)
        {
            lessonContainer.SetActive(false);
        }

        else
        {
            lessonContainer.SetActive(true);
        }
    }
}
