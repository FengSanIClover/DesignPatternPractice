Dependency Inversion Principle (DIP) 依賴反轉原則 
搭配
Dependency Injection Principle (DIP) 依賴注入原則
( 
  High-level modules should not depend on low-level modules. Both should depend on abstractions.
  Abstractions should not depend on details. Details should depend on abstractions. 
)
(
  高層模組不應該依賴底層模組，它們都應該依賴抽象。
  抽象不應該依賴細節。細節應該依賴抽象。
)

它的目標就是解除物件與物件間，兩者的直接相依關係。

為何依賴要反轉：現實中的人類都是直接對具體事物有依賴關係，比如我們要做漢堡就做漢堡，要泡奶茶就泡奶茶。
但到了物件導向程式設計，需要將事物做抽象化，定義抽象類別或介面，然後再定義抽象之間的依賴關係，這就是依賴反轉。
結合里氏替換原則：抽象化之間定義好依賴關係，再由各自的具體子類別去完成商業邏輯，達到替換子類別不會影響軟體功能。

此類別庫內容:
IAvengers : 設定攻擊方法的介面
DoctorStrange : 繼承 IAvengers 介面並實作方法的類別
Hulk : 繼承 IAvengers 介面並實作方法的類別
Task : 實作 依賴反轉原則 依賴注入原則 的類別
Implent 資料夾 -> Implent_DIP : 實作 依賴反轉原則 依賴注入原則 的專案


優點
1.減少類別間的耦合性。
2.提高系統的穩定性，降低並行開發引起的風險。
3.提高代碼的可讀性和可維護性。


參考資料 https://ithelp.ithome.com.tw/articles/10192844
		 https://kknews.cc/zh-tw/other/8olnyyg.html
		 http://glj8989332.blogspot.com/2018/03/design-pattern-dependency-inversion.html