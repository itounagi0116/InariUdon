# InariUdon
Useful prefabs and Udon scripts for VRChat World SDK 3.0

## Usage
Place prefabs into Scene in [Assets/InariUdon/Components/<COMPONENT_NAME>](Assets/InariUdon/Components) or add UdonScript in Script directory.

## Setup
1. Install requirements in below.
2. Download latest non-pre-release `InariUdon-<VERSION>.zip` from [Releases](https://github.com/esnya/InariUdon/releases).
3. Unzip and drag and drop .unitypackage into Project window of Unity.

## Requirements
* VRC SDK3 Worlds
* UdonSharp
* UdonToolkt

## Copmonents
### USharpVideo+
Enhanced Version of [USharpVideo](https://github.com/MerlinVR/USharpVideo) by [MerlinVR](https://github.com/MerlinVR). Requires [MerlinVR/USharpVideo](https://github.com/MerlinVR/USharpVideo).

#### Features
* Toggle Loop
* Modify Screen Brightness

### Sun Contrller
* Synchronized controller of real-time directional lights such as the sun.
* Also re-renders the reflection probe.

### Misc
* FloatValueDriver
 * Drives float parameters of animators by one float value calculated from scene.
* EntranceSoundPlayer
* OwnerNameDisplay
* PlayerCounterDisplay
* ReflectionProbeDriver
  * Provides CustomEvent `RenderProbe` to render realtime ReflectionProbe.
* UpdateFPSVisualizer
