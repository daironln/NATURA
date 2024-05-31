using UnityEngine;
using UnityEngine.UIElements;

namespace Scenaries
{
    public class Click : MonoBehaviour
    {
        [SerializeField] private int scene;
        [SerializeField] private int problem;
        [SerializeField] private Animations.Animations ani;
        private void OnMouseDown()
        {
            GameManager.Instance.setActualProblem(this.gameObject.transform.parent.tag);
            if(!Select.Instance.isPanelActive())
                ani.Jump(this.gameObject.transform.parent.gameObject);
            
            Select.Instance.Quiz(scene, problem);
           //this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }

        public int getProblem()
        {
            return problem;
        }
    }
}
