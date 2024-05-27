using UnityEngine;

namespace Animations
{
    public class Animations : MonoBehaviour
    {
        public void Jump(GameObject obj)
        {
            Vector3 origScale = obj.transform.localScale;
            LeanTween.scale(obj.GetComponentInParent<SpriteRenderer>().gameObject, new Vector3(0.15f, 0.15f, 0.15f), 0.2f);
            LeanTween.scale(obj.GetComponentInParent<SpriteRenderer>().gameObject, origScale, 0.3f)
                .setEase(LeanTweenType.easeOutBounce).setDelay(0.2f);
        }

        public void ScaleUI(GameObject obj)
        {
            LeanTween.scale(obj.GetComponent<RectTransform>(), new Vector3(1, 1, 1), 0.8f).setEase(LeanTweenType.easeOutBounce);
        }
    }
}
