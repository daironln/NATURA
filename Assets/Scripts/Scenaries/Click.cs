using UnityEngine;

namespace Scenaries
{
    public class Click : MonoBehaviour
    {
        [SerializeField] private int scene;
        [SerializeField] private int problem;
        [SerializeField] private Animations.Animations ani;
        private void OnMouseDown()
        {
            ani.Jump(this.gameObject.transform.parent.gameObject);
            Select.Instance.Quiz(scene, problem);
        }
    }
}
