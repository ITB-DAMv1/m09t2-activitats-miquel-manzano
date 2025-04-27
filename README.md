# T2. Activitats

## 1. Investiga la llibreria `System.Diagnostics`


La llibreria **System.Diagnostics** proporciona classes per interactuar amb processos del sistema, diagnosticar aplicacions i mesurar el rendiment. Aquí tens els components més rellevants:

### 1. Classe Process

Permet iniciar i gestionar processos del sistema operatiu.

**Propietats importants:**
- `Id`: Obtenir l'ID del procés
- `ProcessName`: Nom de l'executable
- `StartTime`: Hora d'inici del procés
- `HasExited`: Indica si el procés ha finalitzat
- `ExitCode`: Codi de sortida del procés
- `BasePriority`: Prioritat bàsica del procés
- `WorkingSet`: Memòria física utilitzada (en bytes)
- `Threads`: Col·lecció de fils del procés
- `Modules`: Mòduls carregats pel procés

**Mètodes útils:**
- `Start()`: Inicia un procés
- `Kill()`: Finalitza forçosament un procés
- `WaitForExit()`: Espera que el procés finalitzi
- `CloseMainWindow()`: Tanca el procés enviant un missatge de tancament a la finestra principal
- `GetProcesses()`: Obtenir tots els processos en execució
- `GetProcessById()`: Obtenir un procés pel seu ID

### 2. Classe Stopwatch

Proporciona mètodes per mesurar el temps transcorregut amb alta precisió.

**Mètodes principals:**
- `Start()`: Inicia o repren la mesura del temps
- `Stop()`: Atura la mesura del temps
- `Reset()`: Reinicia el cronòmetre a zero
- `Restart()`: Reinicia i comença a mesurar immediatament

**Propietats importants:**
- `Elapsed`: Temps transcorregut (`TimeSpan`)
- `ElapsedMilliseconds`: Temps transcorregut en mil·lisegons
- `ElapsedTicks`: Temps transcorregut en ticks
- `IsRunning`: Indica si el cronòmetre està actiu

### 3. Classe Debug

Proporciona mètodes per ajudar en la depuració.

**Mètodes útils:**
- `Write()` / `WriteLine()`: Escriu missatges a la finestra de sortida de depuració
- `Assert()`: Mostra un diàleg d'error si la condició és falsa
- `Fail()`: Genera un missatge d'error
- `Print()`: Escriu un missatge seguit d'un salt de línia


---

## 4. Investigació de la classe `Thread` i comparació amb `Task`

# Comparativa Thread vs Task en .NET

| Característica               | Thread (`System.Threading`)                          | Task (`System.Threading.Tasks`)                     |
|------------------------------|-----------------------------------------------------|----------------------------------------------------|
| **Nivell d'abstracció**      | Baix nivell (gestió directa de fils del sistema)    | Alt nivell (abstracció sobre ThreadPool)          |
| **Gestió de recursos**       | Cada Thread consumeix ~1MB (stack)                  | Reutilitza fils del ThreadPool (més eficient)     |
| **Escalabilitat**            | Limitada (~100-1000 fils)                           | Alta (milers de tasques)                          |
| **Retorn de valors**         | No suportat directament                             | Suportat via `Task<TResult>`                      |
| **Control d'errors**         | Complex (UnhandledException)                        | Integrat (`AggregateException`)                   |
| **Cancel·lació**             | Manual (variables volatils) + `Abort` (no segur)    | Via `CancellationToken` (segur)                   |
| **Continuacions**            | Manual (sincronització complexa)                    | Automàtiques (`ContinueWith`, `async/await`)      |
| **Operacions I/O**           | Bloquejant                                          | No bloquejant (ideal per I/O)                     |
| **Prioritat**                | Configurable (`ThreadPriority`)                     | No configurable (gestió automàtica)               |
| **Exemple d'ús**             | ```new Thread(() => {...}).Start()```               | ```Task.Run(() => {...})```                        |
| **Recomanat per**            | - Operacions CPU-bound llargues<br>- Necessitat de prioritat específica | - Operacions I/O-bound<br>- Codi asíncron modern |

---



[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/LXcrfC_Y)
