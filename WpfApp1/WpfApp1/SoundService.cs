using System.Media;

namespace TSCHMI
{
    /// <summary>
    /// Системные звуки Windows (ЛР6).
    /// Не требует файлов — использует встроенные звуки ОС.
    /// </summary>
    public class SoundService
    {
        public void PlayClick() => SystemSounds.Asterisk.Play();
        public void PlayDone() => SystemSounds.Exclamation.Play();
        public void PlayError() => SystemSounds.Hand.Play();
    }
}