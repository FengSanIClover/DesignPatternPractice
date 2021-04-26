設計原則:
IComponent 為 Leaf 物件和整個 Composite 物件定義一個統一的介面。
這使客戶端可以通過 IComponent 介面來統一處理 Leaf 和Composite 物件： 
Leaf 物件直接執行請求，Composite 物件將請求遞迴的向下傳遞到樹結構的子組件。
這使客戶端類更易於實現，更改，測試和重用。

動機(Motivation):
在各類的繪圖軟體中，允許使用者可以畫單純的圖形外也能夠建立複雜的圖形，
使用者也可透過把大量的單純圖性組成群組的方式來建造複雜的圖形。
簡單要達成這樣的目的的實作就是定義這些圖形的物件，
比如說：Line、Text 這樣的圖元物件，再加上一些物件像是這些圖元物件的容器。
而這個時候就有一個問題產生了：程式碼必須要用不同的方式來對待對待圖元物件以及容器物件，
而這樣就會讓整個應用程式的程式碼變得相當的複雜。
Composite 的目的，就是要抽象化出一個抽象物件同時代表了圖元物件以及容器物件。

意圖(Intent):
將類別 組成 樹狀結構，以表示整個或部分的層次結構

適用場景(Applicability):
需要表示一個物件整體或部分的層次結構
希望使用者忽略組合物件與單個物件的不同，使用者將統一地使用組合結構中的所有物件
當以相同的方式使用多個類別，並且經常使用幾乎相同的代碼來處理每個類別時

如
1.公司組織圖
2.網站 Menu

架構(Structure): 如 CompositePattern.png 圖片

參與者(Participants): 如 Composite.png 圖片

互動(Collaboration):
程式一開始時先建立 Composite 樹狀結構資料 ，Client 向樹狀結構的初始 Composite 發送請求，
該請求被轉發到樹結構下的所有子 Component 物件(Leaf 、 Composite)，依序執行

後果(Consequences):
優點
1.組合模式使得客戶端程式碼可以一致地處理物件和物件容器，無需關係處理的單個物件，還是組合的物件容器
2.將 客戶程式碼與複雜的物件容器結構 解耦
3.可以更容易地往組合物件中加入新的構件

缺點
1.使得設計更加複雜。客戶端需要花更多時間理清類之間的層次關係

Component
描述在 Composite 中物件的interface
實作一些共通的部分
定義存取、管理其 Child 物件的介面

Leaf (Primitive, Single, Part, Containee 別名)
表示在 Composite 中 Leaf 物件，這樣的物件沒有 Child。
定義單一特定的物件行為

Composite (Group, Whole, Container, Branch 別名)
定義有 Child 物件的行為
儲存 Child 元件
實作 Child 相關的物件行為

Client
透過 Component 所定義的 Interface操縱 Compositition 物件