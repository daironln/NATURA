using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaleryController : MonoBehaviour
{
    [SerializeField] Image[] galImagesLocks;
    [SerializeField] Sprite[] galImagesUnlocks;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            if (GameManager.Instance.getContCorrectAns(i) >= 2)
            {
                galImagesLocks[i].sprite = galImagesUnlocks[i];
            }
        }
    }
    
    
}
