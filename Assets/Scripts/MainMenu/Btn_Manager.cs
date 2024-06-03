using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class Btn_Manager : MonoBehaviour
    {
        public void QuitGame()
        {
            Application.Quit();
        }

        public void NewGame(int idx)
        {
            SceneManager.LoadScene(idx);
        }
        
        public void Galery()
        {
            SceneManager.LoadScene(6);
        }

        public void Credits()
        {
            
        }
    }
}
    

