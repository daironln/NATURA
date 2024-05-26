using Scenaries;
using UnityEngine;
using TMPro;

namespace Questions
{
    public class QuestController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI[] text;
        [SerializeField] private Select sel;

        public void IncorrectAns(int index)
        {
            Debug.Log(index);

            text[index].color = new Color32(132, 24, 24, 255);
        }
        public void CorrectAns(int index)
        {
            Debug.Log(index);

            text[index].color = new Color32(24, 132, 24, 255);
        }

        public void Ans(int index)
        {
            Debug.Log("Ans");
            if(index.Equals(sel.CorrectIdx())) CorrectAns(index);
            else IncorrectAns(index);
            Debug.Log(sel.CorrectIdx());
        }
    }
}
