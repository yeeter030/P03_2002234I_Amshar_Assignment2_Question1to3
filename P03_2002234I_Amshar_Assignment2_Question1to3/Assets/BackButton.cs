using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    [SerializeField]
    Button ButtonGoBack;

    public AudioSource mAudioSource;
    public AudioClip mAudioClick;

    // Start is called before the first frame update
    void Awake()
    {
        ButtonGoBack.onClick.AddListener(
        delegate
        {
            OnClick_BackButton();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick_BackButton()
    {
        StartCoroutine(ChangeScene());
    }
    IEnumerator ChangeScene()
    {
        mAudioSource.PlayOneShot(mAudioClick);
        yield return new WaitForSeconds(mAudioClick.length);
        SceneManager.LoadScene("Menu");
        Debug.Log("Waited");
    }
}
