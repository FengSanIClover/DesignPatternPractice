設計原則:
1.針對介面來設計程式，而不要針對實作來設計程式。
2.運用包含來取代繼承
	若使用繼承 Hero 類別來擴充技能將導致過多的類別，形成濫用繼承，組合爆炸(CombineExplosion)的狀況
	改使用包含 ISkill 介面的方式來擴充技能

動機(Motivation):
1.不同的演算法有不同的適用場合
2.增加新的演算法往往是困難的
3.封裝演算法的細節或是資料結構(如排序演算法 Sort)

意圖(Intent):
定義一組演算法，封裝每一個演算法的實作，然後可以在不同的演算法實作中隨意切換(此專案的Skill)

適用場景(Applicability):
封裝演算法或行為與其使用多重條件式來決定行為，不如套用策略模式
如:
1.卡牌遊戲的卡片效果
2.訂單的稅率計算
3.下棋 AI 的難度切換
4.作業系統的排程演算法
5.地圖的路線規劃演算法

架構(Structure):如 StrategyPattern.png 圖片

參與者(Participants): 如 Strategy.png 圖片

互動(Collaboration):
程式一開始創建 Context，選取任一 ConcreteStrategy 傳進 Context 建構子中，另 Context 包含且維護，
Context 與 Strategy 互動來執行演算法，執行演算法時， Context 委派呼叫了 Strategy，
Context 必須傳遞該演算法所需部分或全部的資訊給 Strategy

後果(Consequences):
優點
1.演算法可以隨意切換
2.讓演算法具有自己的繼承架構
3.每個演算法被封裝進單獨的類別中開發，較好理解、維護(關注點分離)

缺點
1.客戶端必須知道不同演算法之間的差異，才得以選擇適當的演算法
2.物件數量會增加，因為每個演算法實作都會被獨立於一個類別中

行為類注重演算法流程，責任分配，描述物件參與者與互動，使用繼承與多型建構出多種不同行為


Context：英雄類別
Strategy:招式介面
ConcreteStrategy:招式類別