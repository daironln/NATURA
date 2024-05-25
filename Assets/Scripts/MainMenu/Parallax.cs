using UnityEngine;
using UnityEngine.Serialization;

namespace MainMenu
{
    public class Parallax : MonoBehaviour
    {
        [SerializeField] private float min = 2f;
        [SerializeField] private float max = 2f;

        void Update()
        {
            float x = Input.GetTouch(0).position.x;
            float y = Input.GetTouch(0).position.x;

            this.GetComponent<RectTransform>().position = new Vector2(
                (x / Screen.width) ,
                (y / Screen.height) 
                );
        }

    }
}
