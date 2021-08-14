# KemonoFriendsCMC.Mods.ShowUsingMod
けものフレンズ Cellien May Cry（以下「ゲーム本体」とする）のMOD使用中であることを表示するMOD（以下「本MOD」とする）

## ゲーム本体の情報
* 製作者様
  * 坂本龍様
    * 連絡先はゲーム本体付属の説明書を参照してください
* ダウンロードURL
  * ふりーむ！：https://www.freem.ne.jp/win/game/25092
  * フリーゲーム夢現：https://freegame-mugen.jp/action/game_9372.html

## 本MODの概要

* 画面右下に`MOD(Addon)`という赤色の表示を追加する

## 導入方法

1. BepInExの導入、及びマネージコードストリッピングされていないdllファイルを適用したゲーム本体を準備する
  * 手順: https://github.com/pri-san/KemonoFriendsCMC.Mods.HowToInstall/blob/main/README.md
2. `(ゲーム本体のルート)\BepInEx\plugins`に本MODの実行ファイル(`KemonoFriendsCMC.Mods.ShowUsingMod.dll`)を配置する

## 動作確認環境

* ゲーム本体 v1.9.0 (x64)、BepInEx 5.4.11

## 注意点

* 下記の行為はご遠慮ください
  1. 著作者（ゲーム本体及び本MOD開発者）を騙る行為
  2. `けものフレンズプロジェクト 二次創作ガイドライン`（ https://kemono-friends.jp/guideline/ ）に違反する行為
  3. 本MODにより変化した挙動をゲーム本体の仕様と騙る行為
  4. ゲーム本体の定める規約に違反する行為
* 本MODはゲーム本体の制作とは無関係の有志のMODです
  * データ消失、パフォーマンスの低下等の責任を負いかねますので、自己責任で利用してください
  * バグや不具合が発生することがありますので、*セーブデータのバックアップ*、*ゲーム本体のバックアップ*を行った上で実行することを推奨します
* 本MODの実行ファイル、及びソースコードは`MITライセンス`です
  * ライセンス本文は`LICENSE`ファイルを参照してください
  * ゲーム本体のライセンスに関してはゲーム本体付属の説明書を参照してください

## 連絡先

* Twitter: @Puri_san_P
* e-mail: pri.san.pg@gmail.com

## ビルド手順(開発者向け)

### 以下のファイルをdllフォルダに追加

* `(BepInExのルート)\BepInEx\core` から取得
  * 0Harmony.dll
  * BepInEx.dll
* `(ゲーム本体のルート)\KemonoFriendsCMC_Data\Managed` から取得
  * Assembly-CSharp.dll
  * netstandard.dll
  * System.Diagnostics.StackTrace.dll
  * System.Globalization.Extensions.dll
  * System.IO.Compression.dll
  * System.IO.Compression.FileSystem.dll
  * System.Net.Http.dll
  * System.Runtime.Serialization.Xml.dll
  * System.Xml.XPath.XDocument.dll
  * Unity.TextMeshPro.dll
  * UnityEngine.CoreModule.dll
  * UnityEngine.dll
  * UnityEngine.UI.dll

### VisualStudioでReleaseビルド

* .NETFramework4が必要です
  * 別途インストールするのではなく、VisualStudioのインストーラを使用するとスムーズにインストールできます
* `KemonoFriendsCMC.Mods.ShowUsingMod\bin\Release\KemonoFriendsCMC.Mods.ShowUsingMod.dll`にプラグインのDLLが出力されます
