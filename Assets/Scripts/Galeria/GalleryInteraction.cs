using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Galeria
{
    public class GalleryInteraction : MonoBehaviour
    {
        [SerializeField] private Image backGroundImg;
        [SerializeField] private Sprite backGroundImg1;
        [SerializeField] private Sprite backGroundImg2;
    
        [SerializeField] private GameObject galIcons1;
        [SerializeField] private GameObject galIcons2;

        [SerializeField] private GameObject antBtn;
        [SerializeField] private GameObject sigBtn;

        [SerializeField] private Vector3 pos1;
        [SerializeField] private Vector3 pos2;


        public void Sig()
        {
            backGroundImg.sprite = backGroundImg2;
            sigBtn.SetActive(false);
            antBtn.SetActive(true);

            LeanTween.move(galIcons1.GetComponent<RectTransform>(), pos1, 0.4f);
            LeanTween.move(galIcons2.GetComponent<RectTransform>(), pos2, 0.8f).setEase(LeanTweenType.easeOutBounce);
        }
    
        public void Ant()
        {
            backGroundImg.sprite = backGroundImg1;
            sigBtn.SetActive(true);
            antBtn.SetActive(false);
            
            LeanTween.move(galIcons2.GetComponent<RectTransform>(), pos1, 0.4f);
            LeanTween.move(galIcons1.GetComponent<RectTransform>(), pos2, 0.8f).setEase(LeanTweenType.easeOutBounce);
        }

        public void Exit()
        {
            SceneManager.LoadScene(0);
        }
    }
}
