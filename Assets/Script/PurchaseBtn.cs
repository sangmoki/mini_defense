using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseBtn : MonoBehaviour
{
    [SerializeField] Button purchaseBtn;


    // Start is called before the first frame update
    void Start()
    {
        purchaseBtn.onClick.AddListener(OnClickBtn);
    }

    private void OnClickBtn()
    {
        ItemPurchase.Instance.PurchaseItemBtn();
    }
}
