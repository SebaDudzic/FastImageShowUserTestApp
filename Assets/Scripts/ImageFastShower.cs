using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFastShower : MonoBehaviour
{

    [SerializeField]
    private Image imageTemplate;
    [SerializeField]
    private Text timeText;
    [SerializeField]
    private InputField timeInputField;
    [SerializeField]
    private float milisecondsToWait = 100f;
    [SerializeField]
    private ImagesDatabase imagesDB;

    private System.DateTime startTime;
    private double timeLeftMiliseconds = -1;
    private bool showing = false;

    private void Awake()
    {
        imageTemplate.sprite = null;
    }

    public void Show()
    {
        imageTemplate.sprite = imagesDB.GetRandomImage();
        startTime = System.DateTime.Now;
        timeLeftMiliseconds = GetTimeToShow();
        showing = true;
    }

    private void Update()
    {
        if (showing)
        {
            if (timeLeftMiliseconds <= 0)
            {
                imageTemplate.sprite = null;
                double milisecondElapsed = (System.DateTime.Now - startTime).TotalMilliseconds;
                string timeTextValue = string.Format("Time given: {0}\nTimeElapsed: {1}", GetTimeToShow(), milisecondElapsed);
                timeText.text = timeTextValue;
                Debug.Log(timeTextValue);
                showing = false;
            }

            timeLeftMiliseconds -= Time.deltaTime * 1000;
        }
    }

    private double GetTimeToShow()
    {
        try
        {
            int timeToShowFromInput = System.Int32.Parse(timeInputField.text);

            if(Mathf.Approximately(timeToShowFromInput,0))
            {
                return milisecondsToWait;
            }
            else
            {
                return timeToShowFromInput;
            }
        }
        catch(System.Exception e)
        {
            return milisecondsToWait;
        }
    }
}
