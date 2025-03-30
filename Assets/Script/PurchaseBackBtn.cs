using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseBackBtn : MonoBehaviour
{
    [SerializeField] Button PurchaseBack;

    void Start()
    {
        PurchaseBack.onClick.AddListener(OnClickBtn);
    }

    private void OnClickBtn()
    {
        ItemPurchase.Instance.ClosePurchasePanel();
    }
}
