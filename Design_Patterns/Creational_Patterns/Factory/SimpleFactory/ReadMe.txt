設計原則:
由一個工廠物件決定創建出哪一種產品類的例項，它經常被用於封裝建立物件的程式碼。

動機(Motivation):
將產生物件的選擇邏輯放於子類別中

意圖(Intent):
創建物件而不將建立邏輯邏輯暴露給客戶端。
通過共用方法創建物件

適用場景(Applicability):
當無法預期應該建立的物件類型時
當一個物件希望其子物件成為特定於新建立物件的子物件時

如:
根據文件類型建立不同文件(PDF、Excel、Word)

架構(Structure): 如 SimpleFactoryPattern.png 圖片

參與者(Participants): 如 SimpleFactory.png 圖片

互動(Collaboration):
透過 TrainingCamp 類別的靜態方法 TrainAdventurer 建立對應的冒險者類別，客戶端無須知道是如何建立的

後果(Consequences):
優點
工廠封裝了各類別的建構式邏輯，客戶端不需要知道如何建構類別實體，可以直接操作公開的方法，做到實質的隔離，達成了職責分離。
透過參數設定檔，可以實現不修改成客戶端程式碼的，而增加可以使用類別。

缺點
使用簡單工廠模式將會增加系統中類別的數量，純理論來說增加了系統的複雜度和理解難度。
有可能造成工廠邏輯過於複雜，不利於系統的擴展和維護。
因使用靜態方法，所以工廠類別無法繼承。