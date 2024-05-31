using UnityEngine;
using UnityEngine.UI;

namespace Animations
{
    public class Animations : MonoBehaviour
    {
        public void Jump(GameObject obj)
        {
            Vector3 origScale = obj.GetComponent<RectTransform>().localScale;
            LeanTween.scale(obj.GetComponentInParent<Image>().gameObject.GetComponent<RectTransform>(), new Vector3(1.15f, 1.15f, 1.15f), 0.2f);
            LeanTween.scale(obj.GetComponentInParent<Image>().gameObject.GetComponent<RectTransform>(), origScale, 0.3f)
                .setEase(LeanTweenType.easeOutBounce).setDelay(0.2f);
        }

        public void ScaleUI(GameObject obj)
        {
            LeanTween.scale(obj.GetComponent<RectTransform>(), new Vector3(1, 1, 1), 0.8f).setEase(LeanTweenType.easeOutBounce);
        }
        
        public void ScaleUIto0(GameObject obj)
        {
            LeanTween.scale(obj.GetComponent<RectTransform>(), new Vector3(0, 0, 0), 0.8f).setEase(LeanTweenType.easeOutBounce);
        }
        
        public void ScaleUILoop(GameObject obj, Vector3 to)
        {
            LeanTween.scale(obj.GetComponent<RectTransform>(), to, 0.8f).setEase(LeanTweenType.easeOutBounce).setLoopPingPong();
        }

        public void MoveUI(GameObject obj, Vector3 pos)
        {
            LeanTween.move(obj.GetComponent<RectTransform>(), pos, 0.8f).setEase(LeanTweenType.easeOutBounce);
        }
        
    }
}
