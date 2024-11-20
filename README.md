# InariUdon  
VRChat World SDK 3.0 用の便利なプレハブとUdonスクリプト

[![GitHub license](https://img.shields.io/github/license/SeaeeesSan/SimpleFolderIcon)](https://github.com/SeaeeesSan/SimpleFolderIcon/blob/master/LICENSE)

## 必要要件
- [VRChat Creator Companion(VCC)](https://github.com/vrchat-community/creator-companion) 経由でインストールする [**UdonSharp 1.x**](https://github.com/vrchat-community/UdonSharp)
- [UdonToolkit](https://github.com/orels1/UdonToolkit/)
- [Udon Sun Controller](https://github.com/esnya/UdonSunController)

---

## はじめに  

1. [**VRChat Creator Companion(VCC)**](https://github.com/vrchat-community/creator-companion) を使用して、UdonSharpを含むワールド用Unityプロジェクトを作成してください。  
2. メニューから「Window」→「Package Manager」を開きます。  
3. パッケージマネージャーウィンドウの左上にある「+」ボタンをクリックし、`Add package from git URL` を選択します。  
4. 次のURLを入力し、「Add」ボタンをクリックしてください：  
   - 通常版: `https://github.com/esnya/InariUdon.git?path=/Packages/com.nekometer.esnya.inari-udon`  
   - ベータ版: `https://github.com/esnya/InariUdon.git?path=/Packages/com.nekometer.esnya.inari-udon#beta`  

---

![image](https://user-images.githubusercontent.com/2088693/180705211-f0f25559-d66f-460c-aede-445a230ae87a.png)  
![image](https://user-images.githubusercontent.com/2088693/180705244-5dea9e3b-62a0-4ed5-b12d-89e612f49ecc.png)  

---

### 追加資料(整備中)
以下に、 **このスクリプトの機能** の簡単な説明を追加しています(LLMを用いて作成している為その点はご留意下さい)

| **スクリプト名**                          | **説明**                                                                                     |
|-------------------------------------------|---------------------------------------------------------------------------------------------|
| **ClockAnimationStarter**                | 現在の時間に基づいてアニメーション時間を調整するスクリプト。                                   |
| **MultiTextLoader**                      | 複数のテキストアセットを読み込み、対応するオブジェクトに適用するスクリプト。                  |
| **EventDescriptionAttribute**            | イベントの説明を定義するためのカスタム属性。                                                  |
| **AnimatorDriver**                       | Animatorのパラメータを操作するためのドライバースクリプト。                                    |
| **ClockDriver**                          | 時計の針（秒針、分針、時針）の回転を現在の時間に基づいて制御。                                |
| **FloatMultiValueDriver**                | 複数のターゲットに対して浮動小数点値を制御するスクリプト。                                    |
| **RotationDriver**                       | ターゲットの回転を制御するスクリプト。                                                       |
| **SyncedSpinner**                        | 同期された回転を行うスクリプト。                                                            |
| **AbstractImageDownloder**               | VRCUrlから画像をダウンロードし、指定されたレンダラーのマテリアルに適用。                      |
| **MultiImageDownloder**                  | 複数のURLから画像をダウンロードし、順次適用するスクリプト。                                   |
| **MultiImageManagedDisplay**             | MultiImageManagerからの画像を表示するスクリプト。                                            |
| **SingleImageDownloder**                 | 単一のURLから画像をダウンロードし適用するスクリプト。                                        |
| **StringDownloader**                     | 指定されたURLから文字列をダウンロードし、UIコンポーネントに適用。                             |
| **CustomUdonProgramFolder**              | カスタムUdonプログラムフォルダーを管理するエディタスクリプト。                                |
| **EsnyaUdonToolsSettings**               | Esnya Udon Toolsの設定を管理するスクリプト。                                                |
| **InariUdonEditorTools**                 | UdonSharpProgramAssetの作成を支援するエディタツール。                                        |
| **PlaylistTool**                         | プレイリストを生成し、IwaSync3やその他のターゲットに適用するエディタツール。                  |
| **RepairUdon**                           | Udonスクリプトを修復するためのエディタツール。                                              |
