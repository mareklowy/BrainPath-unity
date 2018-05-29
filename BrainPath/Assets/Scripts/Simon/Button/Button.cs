using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    [SerializeField]
    GameManager gameLogic;
    AudioSource sfx;
    public Color mainColor;
    public Color highlightColor;
    public int buttonID { get; set; }

    private void Awake()
    {
        sfx = GetComponent<AudioSource>();
    }

    public void OnMouseDown()
    {
        ActivateButton();
        gameLogic.Choose(buttonID);
    }

    private void ResetButton()
    {
        GetComponent<MeshRenderer>().material.color = mainColor;
    }

    public void ActivateButton()
    {
        GetComponent<MeshRenderer>().material.color = highlightColor;
        sfx.Play();
        Invoke("ResetButton", .5f);
    }

    private void OnMouseUp()
    {
        ResetButton();
    }

    private void Start()
    {
        ResetButton();
    }


}
