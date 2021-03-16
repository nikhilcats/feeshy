using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingAction : MonoBehaviour
{
    Fishing fishing = new Fishing();
    public ItemDatabase itemDatabase;
    public Inventory inventory;
    public SpriteRenderer spriterenderer;
    public Sprite NormalPole;
    public Sprite CastedPole;
    public SpriteRenderer GreenFish;
    public SpriteRenderer OrangeFish;
    public SpriteRenderer BlueFish;
    public SpriteRenderer RainbowFish;

    private System.Random rnd = new System.Random();
    private bool isRunning = false;

    private IEnumerator CastWithWait()
    {
        if(isRunning == false)
        {
            isRunning = true;
            spriterenderer.sprite = CastedPole;
            yield return new WaitForSecondsRealtime(rnd.Next(3,8));
            Item fishCaught = fishing.CastLine(itemDatabase, inventory);
            switch (fishCaught.id)
            {
                case 1:
                    BlueFish.sortingLayerName = "Fish";
                    yield return new WaitForSecondsRealtime(1.5f);
                    BlueFish.sortingLayerName = "Backgrounds";
                    break;
                case 2:
                    GreenFish.sortingLayerName = "Fish";
                    yield return new WaitForSecondsRealtime(1.5f);
                    GreenFish.sortingLayerName = "Backgrounds";
                    break;
                case 3:
                    OrangeFish.sortingLayerName = "Fish";
                    yield return new WaitForSecondsRealtime(1.5f);
                    OrangeFish.sortingLayerName = "Backgrounds";
                    break;
                case 4:
                    RainbowFish.sortingLayerName = "Fish";
                    yield return new WaitForSecondsRealtime(1.5f);
                    RainbowFish.sortingLayerName = "Backgrounds";
                    break;
                default:
                    Debug.Log("Didnt work");
                    break;
            }
            spriterenderer.sprite = NormalPole;
            Debug.Log(fishCaught.name);
            isRunning = false;
        }
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Ive been clicked UWU");
        StartCoroutine(CastWithWait());
        
    }
    
}
