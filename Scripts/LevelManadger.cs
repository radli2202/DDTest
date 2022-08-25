using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManadger : MonoBehaviour
{
    [SerializeField] private GameObject [] _GOslotsItems;
    [SerializeField] private float timeActive;
    int massiveint,check;

    void Start()
    {
        massiveint = _GOslotsItems.Length;
        check = massiveint;
        for(int i=0; i < _GOslotsItems.Length; i++)
        {
            _GOslotsItems[i].SetActive(false);
        }

        StartCoroutine(OnSlot());
    }

    IEnumerator OnSlot()
    {
        yield return new WaitForSeconds(timeActive);
        if (check > 0)
        {
            if (!_GOslotsItems[massiveint - 1].activeInHierarchy)
            {
                check = massiveint - 1;
                _GOslotsItems[massiveint - 1].SetActive(true);
                massiveint--;
                StartCoroutine(OnSlot());
            }

        }
      
       
        yield break;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
