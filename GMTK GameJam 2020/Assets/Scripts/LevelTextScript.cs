using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelTextScript : MonoBehaviour
{
    public float fadeStartTime = 2;

    public Text levelText;
    //Fade time in seconds
    public float fadeOutTime;



    void Start()
    {
        levelText.text = ("LEVEL " + SceneManager.GetActiveScene().buildIndex);     // lEVELTEXT IS "level" + CURRENT SCENE INDEX

        Invoke("FadeOut", fadeStartTime);           // Bullet lifetime timer
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }
    private IEnumerator FadeOutRoutine()
    {
        Text text = GetComponent<Text>();
        Color originalColor = text.color;
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }
    }
}

