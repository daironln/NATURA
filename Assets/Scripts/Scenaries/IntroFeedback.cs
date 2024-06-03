using System;
using UnityEngine;
using TMPro;

namespace Scenaries
{
    public class IntroFeedback : MonoBehaviour
    {
        [SerializeField] private Animations.Animations ani;
        [SerializeField] private GameObject other;
        private bool o = false;

        [SerializeField]
        private TextMeshProUGUI te;

        // Update is called once per frame
        private void Start()
        {
            ani.ScaleUILoop(this.gameObject, new Vector3(1.1f, 1.1f, 1.1f));
            
        }
        
        private void StartOther()
        {
            ani.ScaleUILoop(other, new Vector3(1.1f, 1.1f, 1.1f));
            
            o = true;
        }
    }
}
