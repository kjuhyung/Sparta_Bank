using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cashAmountTxt;
    [SerializeField] private TextMeshProUGUI banlanceAmountTxt;

    [SerializeField] private GameObject lackPanel;

    [SerializeField] private TMP_InputField depositInput;

    int cashAmount; 
    int banlanceAmount; 


    private void Awake()
    {
        cashAmount = 100000;
        banlanceAmount = 50000;
    }

    public void Deposit(int amount)
    {     
        if(cashAmount < amount)
        {
            lackPanel.SetActive(true);
            return;
        }
        cashAmount -= amount;
        banlanceAmount += amount;
    }

    public void Withdraw(int amount)
    {
        if (banlanceAmount < amount)
        {
            lackPanel.SetActive(true);
            return;
        }
        banlanceAmount -= amount;
        cashAmount += amount;
    }

    private void LateUpdate()
    {
        cashAmountTxt.text = cashAmount.ToString();
        banlanceAmountTxt.text = banlanceAmount.ToString();
    }
}

