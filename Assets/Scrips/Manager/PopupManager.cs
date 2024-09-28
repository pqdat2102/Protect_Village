using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    private static PopupManager ins;

    public static PopupManager Ins { get => ins; }

    [SerializeField] private GameObject mask;
    [SerializeField] private PopupGameOver popupGameOver;



    private void Awake()
    {
        if (ins != null && ins != this)
        {
            Destroy(this);
        }
        else
        {
            ins = this;
        }
    }


    public void ShowPopupGameOver()
    {
        popupGameOver.ShowPopup();
    }

    public void HidePopupGameOver()
    {
        popupGameOver.HidePopup();
    }

}
