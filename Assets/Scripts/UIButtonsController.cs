using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonsController : MonoBehaviour {

    [SerializeField]
    private ImageFastShower imageFastShower;

	public void OnShowFastImageClicked()
    {
        imageFastShower.Show();
    }
}
