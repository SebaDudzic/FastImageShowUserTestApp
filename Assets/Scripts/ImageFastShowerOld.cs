using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFastShowerOld : MonoBehaviour {

    [SerializeField]
    private Image imageTemplate;
    [SerializeField]
    private float milisecondsToWait = 100f;
    [SerializeField]
    private ImagesDatabase imagesDB;

    private System.DateTime startTime;

    private void Awake()
    {
        imageTemplate.sprite = null;
    }

    public void Show()
    {
        StartCoroutine(ShowCor());
	}

    private IEnumerator ShowCor()
    {
        imageTemplate.sprite = imagesDB.GetRandomImage();
        startTime = System.DateTime.Now;

        yield return new WaitForSeconds(milisecondsToWait / 1000f);

        imageTemplate.sprite = null;
        double milisecondElapsed = (System.DateTime.Now - startTime).TotalMilliseconds;
        Debug.Log(string.Format("Time given: {0}\nTimeElapsed: {1}",milisecondsToWait,milisecondElapsed));
    }
}
