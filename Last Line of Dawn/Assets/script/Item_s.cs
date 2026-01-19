using UnityEngine;
using UnityEngine.UI;
using static Allcontrol;
namespace script
{
    public class Item_s : MonoBehaviour
    {
        private int cherries = GameManager.Instance.score;
        [SerializeField] private Text  cherryCountText;
        [SerializeField] private AudioSource Collect;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Cherry")
            {
                Collect.Play();
                Destroy(collision.gameObject);
                cherries++;
                cherryCountText.text = "Cherries: " + cherries;
            
                GameManager.Instance.score += cherries;
            }
        
        }

 
    }
}
