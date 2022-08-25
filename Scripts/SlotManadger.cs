using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManadger : MonoBehaviour
{
    // public static SlotManadger slotManadger;
    public bool slotoff;
    [SerializeField] private List <UiItem> _itemGOList;
    [SerializeField] private GameObject SalutGOEndGame;
    UiItem uiItem;
    private bool endGame;


    void Start()
    {

       SalutGOEndGame.SetActive(false);
       FindItems();

       // slotManadger = this;

        for (int i = 0; i < _itemGOList.Count; i++)
        {
            _itemGOList[i].gameObject.SetActive(false);
        }
        ItemGO_True();
    }

    void Update()
    {       
        if (slotoff) RemoveItem();
    }

    public void ItemGO_True()
    {
        uiItem=_itemGOList[Random.RandomRange(0, _itemGOList.Count)];
        uiItem.gameObject.SetActive(true);
    }

    public void RemoveItem()
    {
        slotoff = false;
        if (_itemGOList.Count > 0) _itemGOList.Remove(uiItem);
        if (_itemGOList.Count == 0)
        {
            endGame = true;
            SalutGOEndGame.SetActive(true);
        }
        
        if (!endGame) ItemGO_True();
    }

    void FindItems()
    {
        var item= FindObjectsOfType<UiItem>();      
        for (int i = 0; i < item.Length; i++)
        {
            _itemGOList.Add(item[i]);
        }
            
    }



}
