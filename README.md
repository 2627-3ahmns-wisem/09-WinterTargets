# Frosty Targets – 3AHMNS

Unity-Version: **6000.3.24f1**. Projekt: Frosty Targets.

## Projekt öffnen
1. Unity Hub öffnen, **Add project from disk** wählen und diesen Ordner auswählen.
2. Unity **6000.3.24f1** verwenden und den ersten Paketimport abwarten.
3. Szene `Assets/MyGame/Scenes/ShootingScene.unity` öffnen, **Play** drücken.
4. `Assets/MyGame/Scripts/GameManager.cs` und `Target.cs` untersuchen.

## Hinweis bei `UnityEngine.UI` / `Text`-Fehlern
Das Paket **Unity UI (uGUI)** ist unter `Packages/manifest.json` als `com.unity.ugui` eingetragen. Falls trotzdem CS0234 oder CS0246 erscheint: `Window > Package Management > Package Manager` öffnen und unter **In Project** prüfen, ob Unity UI geladen ist. Im Paketmanager **Refresh/Resolve** ausführen; gegebenenfalls Unity schließen und den Ordner `Library` löschen, dann erneut öffnen. Nicht die `using UnityEngine.UI`-Zeile entfernen: sie wird für die vorhandene Punkteanzeige gebraucht.

## Unterricht
Das vorhandene Spawning, der Score und der Sieg bei zehn Treffern sind **Ausgangscode**. Schüler:innen erweitern diese Mechaniken anhand der GitHub-Issues. Der Erstimport ist eine Ausgangsversion; keine Aufgaben sind vorweg implementiert.

## E00 Documentation
wenn man das Game startet führt es alle mindest Funktionen aus außer, dass das Crosshair nicht auf dem  Curser abgestimmt ist und man die Zielscheiben dadurch nicht shooten kann.
1. Wie kommuniziert Target mit GameManager?
  Das Script Target kommuniziert mit dem Script GameManager, indem es eine Referenz auf die GameManager-Komponente erstellt.
   
2. Was bewirkt Destroy(gameObject, 2f)?
  Destroy(gameObject, 2f) löscht das aktuelle GameObject nach 2 Sekunden aus dem Spiel.

## P03 – Ziele bewegen sich während ihrer Lebensdauer
1. Weshalb wird Time.deltaTime verwendet?
  Time.deltaTime gibt die Zeit an, die seit dem letzten Frame vergangen ist. Ohne Time.deltaTime könnte sich das Target auf schnelleren Computern schneller bewegen.
   
2. Was ist der Unterschied zwischen lokaler und globaler Position?
  Globale Position (position): Gibt die Position eines Objekts in der gesamten Szene bzw. Welt an.
  Lokale Position (localPosition): Gibt die Position eines Objekts relativ zu seinem übergeordneten Objekt an.
   
