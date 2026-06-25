using Mono.Cecil;
using System;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int _diamondAmmount;
    private int _goldAmmount;

    public event Action<int, int> ONCanvasUpdate;

    public void AddResource(AllEnums resource)
    {
        //int enumTypeNumber = (int) resource;
        switch (resource)
        {
            case AllEnums.Diamond:
                _diamondAmmount++;
                //Debug.Log("Ammount for " + Resource.Diamond + " (index: " + enumTypeNumber + ")");
                break;
            case AllEnums.Gold:
                _goldAmmount++;
                //Debug.Log("Ammount for " + Resource.Gold  + " (index: " + enumTypeNumber + ")");
                break;
                //case Resource.Banknote:
                //    Debug.Log("Ammount for " + Resource.Banknote + " (index: " + enumTypeNumber + ")");
                //    break;
        }
        ONCanvasUpdate?.Invoke(_diamondAmmount, _goldAmmount);
        //Debug.Log(_diamondAmmount);
    }
}