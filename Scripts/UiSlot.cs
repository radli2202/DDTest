using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UiSlot : MonoBehaviour, IDropHandler
{

    [SerializeField] private string nameSlot;
    [SerializeField] private AudioSource _audioGet;
    SlotManadger slotManadger;

   
    void Start()
    {
        // slotManadger = SlotManadger.slotManadger;
        slotManadger = FindObjectOfType<SlotManadger>();
         _audioGet = _audioGet.GetComponent<AudioSource>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        var pointItem = eventData.pointerDrag.transform;

        string nameItem = pointItem.GetComponent<UiItem>()._nameItem;
        if (nameItem == nameSlot)
        {
            // slotManadger.RemoveItem();
            // slotManadger.ItemGO_True();
            slotManadger.slotoff = true;
            pointItem.SetParent(transform);
            pointItem.localPosition = Vector3.zero;
            _audioGet.Play();
            
        }

      
    }
}
