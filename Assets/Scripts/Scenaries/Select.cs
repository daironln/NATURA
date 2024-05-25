using System;
using UnityEngine;
using TMPro;

namespace Scenaries
{
    public class Select : MonoBehaviour
    {
        [SerializeField] private TextMeshPro question;
        [SerializeField] private TextMeshPro[] badAns;
        [SerializeField] private TextMeshPro correctAns;
        [SerializeField] private GameObject pannel;
        private void OnMouseDown()
        {
            if (gameObject.CompareTag("Basura"))
            {
               
            }
            else if (gameObject.CompareTag("Fabrica"))
            {
                
            }
        }

    }
}
