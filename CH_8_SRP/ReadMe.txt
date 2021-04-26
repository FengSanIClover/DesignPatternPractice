Single responsibility principle (SRP)單一職責原則
(A class should have only one reason to change.)

一個類別，只負責一件事，但並非只有一個方法，
以車來說，責任是在路上行駛，並非只有行駛這一個方法，而是由前進，後退，煞車等基本功能組成，
設計時要注意功能不能切得太細，造成過度設計(over design)
怎麼規劃一個類別責任，要視實際情況而定。

此類別庫內容:
IRestaurantService : 未實現單一職責原則的介面
InsideRestaurantService : 實現單一職責原則後的介面之一
IOuterRestaurantService : 實現單一職責原則後的介面之一
UserfulWaiter : 繼承未實現單一職責原則的介面並實作方法的類別
InsideWaiter : 繼承實現單一職責原則後的介面並實作方法的類別
OuterWaiter : 繼承實現單一職責原則後的介面並實作方法的類別
Implent 資料夾 -> Implent_SRP : 實作 單一職責原則 的範例專案


優點
遵守 SRP 的好處如下：

1.類別的複雜性降低。
2.可讀性與可維護性提升。
3.單一類別的複雜度降低，因為要實現的職責都很清晰明確的定義，這將大幅提升可讀性與可維護性。
4.降低因更改的風險：如果單一職責能做得好，更改一項類別或介面時，不會引起其他介面或類別的變更。

強健性提升
如果有做好 SRP ，那修改只會對同一個介面或類別有影響，這對擴展性和維護性都有很大的幫助。

潛在問題
SRP 是個充滿爭議的原則。爭議的點是，那個「變化原因」會是什麼？或者說，職責該如何劃分？

因為變化原因和職責都是無法量化的，而且會因為專案需求或環境變化而改變，只能建議介面的單一職責原則要遵守，
而類別盡量達到，所以事實上 SRP 很難在專案上完美地實現。
如果硬要達成 SRP 的條件，最直接的方法就是一個方法一個介面，結果會變成介面數量劇增，反而帶來更多麻煩。

參考資料 https://ithelp.ithome.com.tw/articles/10191955 
		 http://glj8989332.blogspot.com/2018/02/design-pattern-single-responsibility.html
