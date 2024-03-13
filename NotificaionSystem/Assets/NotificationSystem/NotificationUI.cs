using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationUI : MonoBehaviour
{
    public NotificationSO notificationSO;

    public Text message;
    public Image icon;

    public float lifeTime;

    private Image backgroundImage;
    private AudioSource audioSource;

    private void Start()
    {
        backgroundImage = GetComponent<Image>();
        audioSource = GetComponent<AudioSource>();

        message.text = notificationSO.message;
        icon.sprite = notificationSO.icon;
        backgroundImage.color = notificationSO.backgroundColor;
        lifeTime = notificationSO.lifeTime;
        audioSource.clip = notificationSO.audio;

        StartCoroutine(NotificationLifeTime());
    }

    private IEnumerator NotificationLifeTime()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
