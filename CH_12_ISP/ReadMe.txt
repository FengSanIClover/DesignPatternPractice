Interface Segregation Principle (ISP) 介面隔離原則
(Clients should not be forced to depend on methods that they do not use.)
(客戶不應該被強迫依賴他們不使用的方法)

把不同功能從介面中分離出來，針對不同需求的用戶，開放其對應需求的介面，提拱使用，客戶端不應該依賴它不需要的介面。
類別間的依賴關係應該建立在最小的介面上。

介面隔離原則與單一職責的審視角度是不相同的，單一職責要求的是類別和介面職責單一，
注重的是職責，這是業務邏輯上的劃分，而介面隔離原則要求介面的方法儘量少。

此類別庫內容:
IAvengers : 設定攻擊方法的介面
IFly : 運用介面隔離原則隔離出飛行方法的介面
Thor : 繼承 IAvengers IFly 2個介面並實作方法的類別
AntMan : 繼承 IAvengers 介面並實作方法的類別
Implent 資料夾 -> Implent_ISP : 實作 介面隔離原則 的範例專案

使用介面隔離原則的實踐
介面功能盡量少：要避免胖介面的狀況，能拆除功能就拆，達到一個介面只服務一個子模組/商業邏輯，介面中方法應該盡量少。
但有可能會與單一職責原則有衝突，比如已經拆成最仔細但功能還是很多，此時要以單一職責原則為優先。
介面若被設計得太混雜，可使用轉接器模式處理。

介面隔離原則的4層原則
1.介面要儘量小。
2.介面要高內聚。
3.定製服務（單獨為一個個體提供優良的服務）。
4.介面設計是有限度的（靈活設計介面粒度大小）。

優點
遵守介面隔離原則最大的好處是，在需要多型時，會比較容易為類別實作對應方法，
維持系統的靈活性和可維護性。

參考資料 https://ithelp.ithome.com.tw/articles/10192464
		 http://glj8989332.blogspot.com/2018/04/design-pattern-interface-segregation.html
		 https://codertw.com/%E7%A8%8B%E5%BC%8F%E8%AA%9E%E8%A8%80/589577/#outline__4_0_1