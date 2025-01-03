using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace InariUdon.Player
{
    [CustomName("Entrance Sound Player")]
    [HelpMessage("Play sound using AudioSource when player joined or left. To disable either of them, select None.")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.NoVariableSync)]
    public class EntranceSoundPlayer : UdonSharpBehaviour
    {
        public AudioSource joinedSoundSource;
        public AudioSource leftSoundSource;

        public override void OnPlayerJoined(VRCPlayerApi player)
        {
            if (joinedSoundSource != null) joinedSoundSource.Play();
        }

        public override void OnPlayerLeft(VRCPlayerApi player)
        {
            if (leftSoundSource != null) leftSoundSource.Play();
        }
    }
}
