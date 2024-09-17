using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace SOSXR.DOTweenExtender
{
    /// <summary>
    ///     Supports setting the desired AudioSource(s) in the inspector, or to search for all available AudioSources in the
    ///     scene.
    /// </summary>
    public class AudioFader : MonoBehaviour
    {
        [SerializeField] private List<AudioSource> m_sources;
        [SerializeField] private float m_duration = 2.5f;


        [ContextMenu(nameof(FindAllAudioSources))]
        public void FindAllAudioSources()
        {
            m_sources = new List<AudioSource>();
            m_sources = FindObjectsOfType<AudioSource>().ToList();
        }


        [ContextMenu(nameof(StartAudioFade))]
        public void StartAudioFade()
        {
            StartAudioFade(m_duration);
        }


        public void StartAudioFade(float fadeDuration)
        {
            foreach (var source in m_sources)
            {
                StartCoroutine(AudioFadeCR(source, fadeDuration, 0));
            }
        }


        private IEnumerator AudioFadeCR(AudioSource audioSource, float duration, float targetVolume)
        {
            if (audioSource == null || !audioSource.gameObject.activeInHierarchy)
            {
                yield break;
            }

            float currentTime = 0;
            var start = audioSource.volume;

            while (currentTime < duration)
            {
                currentTime += Time.deltaTime;

                if (audioSource == null || !audioSource.gameObject.activeInHierarchy)
                {
                    yield break;
                }

                audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);

                yield return null;
            }
        }


        private void OnDisable()
        {
            StopAllCoroutines();
        }
    }
}