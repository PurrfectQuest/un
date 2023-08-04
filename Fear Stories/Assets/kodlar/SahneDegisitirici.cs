using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneDegisitirici : MonoBehaviour
{
    // Sahne değiştirmek için kullanacağınız butonun tetikleyicisi (mesela bir düğme)
    public void SahneDegistir(string sahneID)
    {
        SceneManager.LoadScene(sahneID);
    }
}
