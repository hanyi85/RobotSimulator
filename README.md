# Robot Motion Limiter - 機器手臂運動極限監控終端


##  專案背景
在自動化生產線中，機器手臂的安全性（Safety Logic）是研發核心。本專案模擬 cpcRobot 系列機器手臂在三維空間（X, Y, Z）運行的路徑監控，旨在開發一套直觀且具備防呆機制的監控終端（HMI），防止手臂超出物理工作包絡面（Working Envelope）導致的碰撞與損壞。

##  核心功能與技術亮點

### 1. 三軸運動空間解析
*   **座標即時追蹤**：透過垂直滑桿佈局精確模擬機器手臂末端（TCP）在空間中的位置。
*   **距離計算法則**：後台採用歐幾里得距離公式（Euclidean Distance）實作 3D 空間長度計算，偵測手臂伸展之絕對距離。

### 2. 動態安全性警報系統
*   **限位偵測 (Limit Detection)**：當計算距離超過物理限制（預設 450mm）時，系統會從「SYSTEM READY」狀態立即切換至「LIMIT EXCEEDED」紅色警報模式。
*   **發光 LED 狀態燈**：使用 WPF `DropShadowEffect` 實作具備發光質感的 LED 指示燈，模擬真實控制箱的物理回饋。

### 3. 工業級 HMI 介面設計
*   **高辨識度配色**：採用深色模式（Dark Mode）與高對比色（藍/紅/綠），符合 ISO 標準下工業環境對監控螢幕的高辨識度要求。
*   **一鍵復位 (Emergency Reset)**：實作快速歸零功能，模擬生產現場遭遇異常時的緊急重置操作。

##  開發工具
*   **Framework**: .NET 8.0 WPF
*   **Language**: C#
*   **Layout**: XAML (Grid, UniformGrid, StackPanel)
*   **Features**: Data Binding, Value Formatting, Dynamic Visual States

##  職能展示
本作品展現了開發者在以下領域的軟實力：
1.  **邏輯思考能力**：將抽象的空間座標轉化為具體的安全性判斷條件。
2.  **UI 互動設計**：考慮到工業場景的使用習慣，設計垂直化、模組化的控制介面。
3.  **快速原型開發**：針對特定產業（機器人、自動化）快速產出具備實用價值的軟體原型。
