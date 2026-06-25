using UnityEngine;
using TMPro;

public class CanvasUpdater : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private TMP_Text diamondTextAmmount;
    [SerializeField] private TMP_Text goldTextAmmount;

    // Start is called before the first frame update
    void Start()
    {
        inventory.ONCanvasUpdate += InvertoryOnONCanvasUpdate;
    }

    void OnDisable()
    {
        inventory.ONCanvasUpdate -= InvertoryOnONCanvasUpdate;
    }

    //private void InvertoryOnONCanvasUpdate(int diamondAmmount)
    //{
    //    diamondTextAmmount.text = diamondAmmount.ToString();
    //}
    private void InvertoryOnONCanvasUpdate(int diamondAmmount, int goldAmmount)
    {
        diamondTextAmmount.text = diamondAmmount.ToString();
        goldTextAmmount.text = goldAmmount.ToString();

        /**
         ** If the player collects 4 or more resources, they lose the game.
         */
        if ((diamondAmmount + goldAmmount) >= 4)
        {
            Audio.instance.Loose();
        }
        else
        {
            Audio.instance.Victory();
        }
    }
}
