using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour {

    [SerializeField] private GameObject _hidden;
    [SerializeField] private GameObject _btnplay;
    [SerializeField] private GameObject _firstText;

    [SerializeField] private GameObject _hidden2;
    [SerializeField] private GameObject _hidden3;
    [SerializeField] private GameObject _hidden4;
    [SerializeField] private GameObject _hidden5;
    [SerializeField] private GameObject _hidden6;
    [SerializeField] private GameObject _hidden7;
    [SerializeField] private GameObject _hidden8;


    public void PlayGame()
    {
        _firstText.SetActive(false);
        _btnplay.SetActive(false);
        _hidden.SetActive(true);
    }

    public void FirstItem()
    {
        _hidden.SetActive(false);
        StartCoroutine(WaitForSecondItem());
        
    }
    public void SecondItem()
    {
        _hidden2.SetActive(false);
        StartCoroutine(WaitForThirdItem());
        
    }
    public void ThirdItem()
    {
        _hidden3.SetActive(false);
        StartCoroutine(WaitForFourthItem());
    }
    public void FourthItem()
    {
        _hidden4.SetActive(false);
        StartCoroutine(WaitForFifththItem());
    }

    public void FifthItem()
    {
        _hidden5.SetActive(false);
        StartCoroutine(WaitForSixthItem());
    }

    public void SixthItem()
    {
        _hidden6.SetActive(false);
        StartCoroutine(WaitForSeventhItem());
    }

    public void SeventhhItem()
    {
        _hidden7.SetActive(false);
        StartCoroutine(WaitForEightItem());
    }

    public void EightItem()
    {
        _hidden8.SetActive(false);
    }

    IEnumerator WaitForSecondItem()
    {
        yield return new WaitForSeconds(2);
        _hidden2.SetActive(true);
    }

    IEnumerator WaitForThirdItem()
    {
        yield return new WaitForSeconds(2);
        _hidden3.SetActive(true);
    }

    IEnumerator WaitForFourthItem()
    {
        yield return new WaitForSeconds(2);
        _hidden4.SetActive(true);
    }

    IEnumerator WaitForFifththItem()
    {
        yield return new WaitForSeconds(2);
        _hidden5.SetActive(true);
    }

    IEnumerator WaitForSixthItem()
    {
        yield return new WaitForSeconds(2);
        _hidden6.SetActive(true);
    }

    IEnumerator WaitForSeventhItem()
    {
        yield return new WaitForSeconds(2);
        _hidden7.SetActive(true);
    }

    IEnumerator WaitForEightItem()
    {
        yield return new WaitForSeconds(2);
        _hidden8.SetActive(true);
    }
}

