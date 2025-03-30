using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPurchase : MonoBehaviour
{
    [SerializeField] UnitObject[] unitObjects;
    [SerializeField] int ItemNumber;
    [SerializeField] int ItemPrice;
    [SerializeField] GameObject BlackPanel;
    [SerializeField] GameObject PurchasePanel;
    [SerializeField] GameObject AlarmPanel;
    [SerializeField] Text UnitName;
    [SerializeField] Image UnitImage;
    [SerializeField] Text AlarmText;

    [HideInInspector] public static ItemPurchase Instance;

    int CurrentCoin = 0;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        CurrentCoin = PlayerPrefs.GetInt("Coin");
    }

    public void SelectItem()
    {
        PlayerPrefs.SetInt("ItemNumber", ItemNumber);
        PlayerPrefs.Save();

        BlackPanel.SetActive(true);
        PurchasePanel.SetActive(true);

        UnitName.text = unitObjects[ItemNumber - 1].UnitName;
        UnitImage.sprite = unitObjects[ItemNumber - 1].UnitImage;
    }

    public void PurchaseItemBtn()
    {
        if (CurrentCoin < ItemPrice)
        {
            AlarmPanel.SetActive(true);
            AlarmText.text = "코인이 부족합니다 !";
            return;
        }

        AlarmPanel.SetActive(true);
        AlarmText.text = "구매를 완료했습니다.";

        PlayerPrefs.SetInt("Unit" + (ItemNumber + 3), 1);
        PlayerPrefs.SetInt("Coin", CurrentCoin - ItemPrice);
        PlayerPrefs.Save();
    }

    public void ClosePurchasePanel()
    {
        BlackPanel.SetActive(false);
        PurchasePanel.SetActive(false);

        PlayerPrefs.DeleteKey("ItemNumber");
    }
}
